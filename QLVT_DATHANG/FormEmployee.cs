using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using QLVT_DATHANG.ReportForm;

namespace QLVT_DATHANG
{
    public partial class FormEmployee : DevExpress.XtraEditors.XtraForm
    {
        private enum State
        {
            Reading = 0,
            Adding = 1,
            Editing = 2,
            Transfering = 3
        }
        private int RowIndex = 0; // When recovering deleted row, insert that row to this index (like never far away)
        private object NewRow;
        private State FormState = State.Reading;
        private string SP_CheckEEExist = "SP_CheckEEExistByCMND";
        public FormEmployee()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_NhanVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        } 
        private void OnBarmanagerEditingState()
        {
            btn_list.Enabled =
                btn_add.Enabled = 
                btn_edit.Enabled = 
                btn_delete.Enabled = 
                btn_reload.Enabled = 
                btn_transferBranch.Enabled = false;

            btn_save.Enabled = 
                btn_undo.Enabled = true;
        }
        private void OffBarmanagerEditingState()
        {
            btn_list.Enabled =
                btn_add.Enabled = 
                btn_edit.Enabled = 
                btn_delete.Enabled = 
                btn_reload.Enabled =
                btn_transferBranch.Enabled = true;

            btn_save.Enabled = 
                btn_undo.Enabled = false; 
        }
        private void OnInfoGCEditingState()
        {
            gpc_info.Enabled = true;
            gdc_NhanVien.Enabled = false; 
            // Prevent when adding, click to a row, row fill to gb_info
        }
        private void OffInfoGCEditingState()
        {
            pn_newBranch.Visible = false;
            gdc_NhanVien.Enabled = true;
            gpc_info.Enabled = false;
        }
        private int NextMaNV()
        {
            using (var connection = new SqlConnection(Program.ConnectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "EXEC SP_NextMaNV";
                return (int)command.ExecuteScalar();
            }
        }
        private bool CheckConstraints()
        {
            if (txt_lastname.Text.Trim() == "")
            {
                MessageBox.Show("Không thể trống Họ Nhân viên!", "Lỗi nhập liệu", MessageBoxButtons.OK);
                txt_lastname.Focus();
                return false;
            }
            if (txt_firstname.Text.Trim() == "")
            {
                MessageBox.Show("Không thể trống Tên Nhân viên!", "Lỗi nhập liệu", MessageBoxButtons.OK);
                txt_firstname.Focus();
                return false;
            }
            if (txt_cmnd.Text.Trim() == "")
            {
                MessageBox.Show("Không thể trống CMND", "Lỗi nhập liệu", MessageBoxButtons.OK);
                txt_cmnd.Focus();
                return false;
            }
            if (txt_salary.Text.Trim() == "")
            {
                MessageBox.Show("Không thể trống Lương!", "Lỗi nhập liệu", MessageBoxButtons.OK);
                txt_salary.Focus();
                return false;
            }

            return true;
        }
        private bool IsExistInNewBranch()
        {  
            // Command
            var checkCommand = new SqlCommand(SP_CheckEEExist)
            {
                CommandType = CommandType.StoredProcedure,
                Connection = Program.Connection
            };
            checkCommand.Parameters.AddWithValue("CMND", txt_cmnd.Text);
            // Added here
            var isEmployeeExist = checkCommand.Parameters.Add("@ReturnVal", SqlDbType.Int);
            isEmployeeExist.Direction = ParameterDirection.ReturnValue;

            // Credentials
            Program.Server = cb_newBranch.SelectedValue.ToString();
            Program.ConnectionUserId = Program.RemoteUserId;
            Program.ConnectionPassword = Program.RemotePassword;

            // Execute SP
            try
            {
                if (!Program.LoginToServer())
                {
                    MessageBox.Show("Lỗi kết nối tới Chi nhánh mới", "Lỗi kết nối", MessageBoxButtons.OK);
                    throw new Exception("");
                }
                if (Program.Connection.State == ConnectionState.Closed)
                    Program.Connection.Open();
                checkCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Program.Connection.Close();
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                Program.Connection.Close();
            }

            // Stop when this Employee has been existed on new branch
            if ((int)isEmployeeExist.Value > 0)
            {
                MessageBox.Show($"Nhân viên đã tồn tại ở {cb_newBranch.Text}! Không thể chuyển chi nhánh!", "Lỗi ràng buộc");

                Program.Server = cb_branch.SelectedValue.ToString();
                Program.ConnectionUserId = Program.UserId;
                Program.ConnectionPassword = Program.Password;
                if (!Program.LoginToServer())
                {
                    MessageBox.Show("Lỗi kết nối! Vui lòng thử lại", "Lỗi kết nối", MessageBoxButtons.OK);
                    throw new Exception("");
                }
                OffBarmanagerEditingState();
                OffInfoGCEditingState();
                FormState = State.Reading;
                return false;
            }
            return true;
        }
        private void InsertEEInfoToNewBranch()
        { 
            var SPInsertEmployee = "SP_InsertEmployee";
            var insertCommand = new SqlCommand(SPInsertEmployee)
            {
                CommandType = CommandType.StoredProcedure,
                Connection = Program.Connection,
                Parameters =
                {
                    new SqlParameter {ParameterName = "Ho", Value = txt_lastname.Text},
                    new SqlParameter {ParameterName = "Ten", Value = txt_firstname.Text},
                    new SqlParameter {ParameterName = "CMND", Value = txt_cmnd.Text},
                    new SqlParameter {ParameterName = "DiaChi", Value = txt_address.Text},
                    new SqlParameter {ParameterName = "NgaySinh", Value = dte_birthday.EditValue},
                    new SqlParameter {ParameterName = "Luong", Value = txt_salary.EditValue},
                }
            }; 

            try
            {
                if (Program.Connection.State == ConnectionState.Closed)
                    Program.Connection.Open();
                insertCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Program.Connection.Close();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Program.Connection.Close();
            }
        }
        private void HandleTransferEEToNewBranch()
        {
            //  1. Check Existance of Employee on new branch
            //  2. Insert Information to new branch
            //  3. Check isDeleted status on current branch

            // =======================================================================

            // 1. Check wheather this Employee exists on the new branch
            // If this combobox haven't had records
            if (cb_newBranch.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            try
            {
                if (!IsExistInNewBranch())
                    return;
            }
            catch { }

            // 2. Transfer all information of this Employee to the new branch
            InsertEEInfoToNewBranch();

            // 3. Update this Employee into isDeleted
            Program.Server = cb_branch.SelectedValue.ToString();
            Program.ConnectionUserId = Program.UserId;
            Program.ConnectionPassword = Program.Password;

            if (!Program.LoginToServer())
            {
                MessageBox.Show("Lỗi kết nối! Vui lòng thử lại", "Lỗi kết nối", MessageBoxButtons.OK);
                return;
            }
             
            try
            {  
                cb_deleted.Checked = true;
                bds_NhanVien.EndEdit();
                bds_NhanVien.ResetCurrentItem();
                tbla_NhanVien.Connection.ConnectionString = Program.ConnectionString;
                tbla_NhanVien.Update(DS.NhanVien);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            MessageBox.Show($"Điều chuyển nhân viên đến {cb_newBranch.Text} thành công!", "Thông tin");
        }
        private void FormEmployee2_Load(object sender, EventArgs e)
        {
            // 1. The reason we disable enforece constraints because there is not only
            // Employee Table but also others Tables are foreign tables (constraints)
            DS.EnforceConstraints = false;

            // 2. Connection String in App.config just to generate Dataset
            // This connection string is the real one. 
            // We have logged in which loginname, we'll use that loginname
            tbla_NhanVien.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_NhanVien.Fill(this.DS.NhanVien);
            tbla_DatHang.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_DatHang.Fill(this.DS.DatHang);
            tbla_PhieuNhap.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_PhieuNhap.Fill(this.DS.PhieuNhap);
            tbla_PhieuXuat.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_PhieuXuat.Fill(this.DS.PhieuXuat);

            // 3. We have to store Branch ID (which we logged in)
            // NOTE: This may occur an error, YOU HAVE TO FIND OUT AND FIX IT!!!
            // I think when there is no employee, it will cause an error!

            // 4. Load subs into combobox
            cb_branch.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_branch.DataSource = Program.bds_subscriptionList;
            cb_branch.DisplayMember = "TenCN";
            cb_branch.ValueMember = "TenServer";
            cb_branch.SelectedIndex = Program.SubsIndex;

            cb_newBranch.DropDownStyle = ComboBoxStyle.DropDownList;
            pn_newBranch.Visible = false;

            txt_branchId.Enabled = false;

            dte_birthday.Properties.EditMask = "dd/MM/yyyy";
            dte_birthday.Properties.UseMaskAsDisplayFormat = true;

            colNgaySinh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime; 
            colNgaySinh.DisplayFormat.FormatString = "dd/MM/yyyy";

            gpc_info.Enabled = false;

            // 5. Decentralization
            if (Program.Role == "CongTy")
            {
                cb_branch.Enabled = true;
                gpc_info.Enabled = btn_add.Enabled = btn_delete.Enabled = btn_edit.Enabled = btn_undo.Enabled = btn_save.Enabled = false;
            }
            else
            {
                cb_branch.Enabled = btn_undo.Enabled = btn_save.Enabled = false;
                btn_add.Enabled = btn_delete.Enabled = btn_edit.Enabled = true;
            }
        }

        private void btn_add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        { 
            // Set up UI
            OnBarmanagerEditingState();
            OnInfoGCEditingState();
            txt_id.ReadOnly = true;
            cb_deleted.Enabled = false;

            // Change State
            RowIndex = bds_NhanVien.Position;
            NewRow = bds_NhanVien.AddNew();
            FormState = State.Adding;

            // Set up Raw Data
            txt_id.Text = NextMaNV().ToString();
            dte_birthday.EditValue = "01/01/2000";
            txt_salary.Text = "4,000,000";
            txt_branchId.Text = Program.BranchId;
            cb_deleted.Checked = false;

            txt_lastname.Focus();
        }

        private void btn_edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        { 
            // Just set up UI
            OnBarmanagerEditingState();
            OnInfoGCEditingState();
            cb_deleted.Enabled = true;
            txt_id.Enabled = false;

            // Change State
            FormState = State.Editing;
        }

        private void btn_delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // 1. Check wheather this Employee can be deleted
            // A row can not be deleted if it's referenced to another Table (it's a FK)
            int EmployeeId = 0;

            if (bds_DatHang.Count > 0 || bds_PhieuNhap.Count > 0 || bds_PhieuXuat.Count > 0)
            {
                MessageBox.Show(
                    "Nhập viên đã có thông tin trong Đơn đặt hàng. Không thể Xóa!",
                    "Lỗi ràng buộc", MessageBoxButtons.OK);
                return;
            }
            if (bds_PhieuNhap.Count > 0)
            {
                MessageBox.Show(
                    "Nhập viên đã có thông tin trong Phiếu Nhập. Không thể Xóa!",
                    "Lỗi ràng buộc", MessageBoxButtons.OK);
                return;
            }
            if (bds_PhieuXuat.Count > 0)
            {
                MessageBox.Show(
                    "Nhập viên đã có thông tin trong Phiếu Xuất. Không thể Xóa!",
                    "Lỗi ràng buộc", MessageBoxButtons.OK);
                return;
            }

                var deleteConfirm = MessageBox.Show("Nhân viên sẽ bị xóa vĩnh viễn! Bạn có đồng ý Xóa nhân viên này?", "Xác nhận xóa nhân viên", MessageBoxButtons.OKCancel);
            if (deleteConfirm == DialogResult.OK)
            {
                try
                {
                    var idData = ((DataRowView)bds_NhanVien[bds_NhanVien.Position])["MaNV"].ToString();
                    EmployeeId = int.Parse(idData); // Store employeeID to roll back to this Employee position
                    bds_NhanVien.RemoveCurrent();

                    tbla_NhanVien.Connection.ConnectionString = Program.ConnectionString;
                    tbla_NhanVien.Update(DS.NhanVien);
                }
                catch (Exception ex) // There maybe it's deleted it in UI but not in DB -> Re fill the UI
                {
                    MessageBox.Show("Xảy ra lỗi trong khi xóa nhân viên. Làm ơn thử lại!\t" + ex.Message, "Lỗi", MessageBoxButtons.OK); // Sometimes, computers are crazy so ... 
                    tbla_NhanVien.Fill(DS.NhanVien);
                    bds_NhanVien.Position = bds_NhanVien.Find("MaNV", EmployeeId); // Jump to Employee position
                    return;
                }
            }

            // Strict constraint -> If there are no employees, Cannot Delete
            if (bds_NhanVien.Count == 0)
                btn_delete.Enabled = false;
        }

        private void btn_save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FormState == State.Transfering)
            {
                HandleTransferEEToNewBranch();
            }
            else
            {
                if (!CheckConstraints())
                    return;

                try
                {
                    bds_NhanVien.EndEdit();
                    bds_NhanVien.ResetCurrentItem();
                    tbla_NhanVien.Connection.ConnectionString = Program.ConnectionString;
                    tbla_NhanVien.Update(DS.NhanVien);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong khi thêm nhân viên. Làm ơn thử lại!\t" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                    return;
                }
            }
            OffBarmanagerEditingState();
            OffInfoGCEditingState();
            FormState = State.Reading;
        }

        private void btn_undo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bds_NhanVien.CancelEdit();

            if (FormState == State.Adding)
            {
                var res = bds_NhanVien.Contains(NewRow);
                if (res)
                    bds_NhanVien.Remove(NewRow);
                bds_NhanVien.Position = RowIndex;
            } 

            OffBarmanagerEditingState();
            OffInfoGCEditingState();
            FormState = State.Reading;
        }

        private void btn_reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                tbla_NhanVien.Fill(DS.NhanVien);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong khi Reloading\t" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void cb_branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If this combobox haven't had records
            if (cb_branch.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            Program.Server = cb_branch.SelectedValue.ToString();

            if (cb_branch.SelectedIndex != Program.SubsIndex)
            {
                Program.ConnectionUserId = Program.RemoteUserId;
                Program.ConnectionPassword = Program.RemotePassword;
            }
            else
            {
                Program.ConnectionUserId = Program.UserId;
                Program.ConnectionPassword = Program.Password;
            }

            if (!Program.LoginToServer())
            {
                MessageBox.Show("Xảy ra lỗi trong khi kết nối. Vui lòng thử lại", "Lỗi kết nối", MessageBoxButtons.OK);
                return;
            }

            tbla_NhanVien.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_NhanVien.Fill(this.DS.NhanVien);
            tbla_DatHang.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_DatHang.Fill(this.DS.DatHang);
            tbla_PhieuNhap.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_PhieuNhap.Fill(this.DS.PhieuNhap);
            tbla_PhieuXuat.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_PhieuXuat.Fill(this.DS.PhieuXuat);

            // Role Company cannot edit data and branchid is just used to add data.
            // The reason it's here that is some subjects not only change branch but also update data.
        }

        private void btn_transferBranch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Check Constraints
            if (cb_deleted.Checked)
            {
                MessageBox.Show("Không thể điều chuyển nhân viên đã bị xóa tới chi nhánh khác!", "Lỗi");
                return;
            }

            // Set up UI
            OnBarmanagerEditingState();
            pn_newBranch.Visible = true;
            gdc_NhanVien.Enabled = false;
            
            // Change State
            FormState = State.Transfering;

            // Set up Combobox Data
            DataTable dtTable = (DataTable) Program.bds_subscriptionList.DataSource;
            dtTable = dtTable.Copy();
            dtTable.Rows[Program.SubsIndex].Delete();
            cb_newBranch.DataSource = dtTable;
            cb_newBranch.DisplayMember = "TenCN";
            cb_newBranch.ValueMember = "TenServer";
        }

        private void btn_list_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Xrpt_EmployeeList rpt = new Xrpt_EmployeeList();
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}