using DevExpress.UIAutomation;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Filtering.Templates;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace QLVT_DATHANG
{
    public partial class FormImReceipt : DevExpress.XtraEditors.XtraForm
    {
        private int RowIndex = 0; // When recovering deleted row, insert that row to this index (like never far away)
        private object NewRow;
        private string SP_CheckMaPNExist = "SP_CheckMaPNExist";
        private enum FormState
        {
            Reading = 0,
            Adding = 1,
            Editing = 2,
        }
        private FormState State = FormState.Reading;
        private string SP_DeletePhieuNhap = "SP_DeletePhieuNhap";
        public FormImReceipt()
        {
            InitializeComponent();
        }

        private void SetUIConstraints()
        {
            // Group Control
            txt_importId.ReadOnly = true;
            txt_eeId.ReadOnly = true;
            txt_whsId.ReadOnly = true;

            // Group Control format & type
            gpc_info.Enabled = false;
            cbb_fullname.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_whsname.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_DDH.DropDownStyle = ComboBoxStyle.DropDownList;
            dte_date.Properties.EditMask = "dd/MM/yyyy";
            dte_date.Properties.UseMaskAsDisplayFormat = true;
            dte_date.ReadOnly = true;

            // Grid control Phieu Nhap
            colMaPN.OptionsColumn.AllowEdit = false; colMaPN.Caption = "Mã Phiếu Nhập";
            colNgay.OptionsColumn.AllowEdit = false; colNgay.Caption = "Ngày";
            colNgay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            colNgay.DisplayFormat.FormatString = "dd/MM/yyyy";
            colMaSoDDH.OptionsColumn.AllowEdit = false; colMaSoDDH.Caption = "Mã số Đơn đặt hàng";
            colMaNV.OptionsColumn.AllowEdit = false; colMaNV.Caption = "Mã Nhân viên";
            colMaKho.OptionsColumn.AllowEdit = false; colMaKho.Caption = "Mã Kho";

            // Grid view CTPN
            colCTPNMaPN.HeaderText = "Mã Phiếu Nhập"; colCTPNVatTu.Width = 200;
            colCTPNVatTu.HeaderText = "Vật tư"; colCTPNVatTu.Width = 280;
            colCTPNSoLuong.HeaderText = "Số Lượng"; colCTPNSoLuong.Width = 200;
            colCTPNDonGia.HeaderText = "Đơn Giá"; colCTPNDonGia.Width = 200;

            gdv_CTPN.AllowUserToAddRows = false; // Special

            // Context menu strip
            ms_delete.Visible = false;
            ms_cancel.Visible = false;

            // Load combobox branch
            cb_branch.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_branch.DataSource = Program.bds_subscriptionList;
            cb_branch.DisplayMember = "TenCN";
            cb_branch.ValueMember = "TenServer";
            cb_branch.SelectedIndex = Program.SubsIndex;
        }

        private void TurnOnEditingState()
        {
            // Tool bar manager 
            btn_add.Enabled = btn_edit.Enabled = btn_delete.Enabled = btn_reload.Enabled = false;
            btn_save.Enabled = btn_undo.Enabled = true;
            // Group Info "Bảng thông tin"
            gpc_info.Enabled = true;
            // Grid Control "Phiếu nhập"
            gdc_PhieuNhap.Enabled = false;
        }

        private void TurnOffEditingState()
        {
            // Bar Manager
            btn_add.Enabled = btn_edit.Enabled = btn_delete.Enabled = btn_reload.Enabled = true;
            btn_save.Enabled = btn_undo.Enabled = false;
            // Group Info "Bảng thông tin"
            gpc_info.Enabled = false;
            txt_importId.ReadOnly = true;
            // Grid Control "Phiếu nhập"
            gdc_PhieuNhap.Enabled = true;
            // Context menu strip
            ms_delete.Visible = ms_cancel.Visible = false;
            ms_save.Visible = ms_reload.Visible = true;

            State = FormState.Reading;
        }

        private void FormReceipt_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;

            tbla_PhieuNhap.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_PhieuNhap.Fill(this.DS.PhieuNhap);
            tbla_DDH_Chua_Nhap.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_DDH_Chua_Nhap.Fill(this.DS.DDH_Chua_Nhap);
            tbla_CTPN.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_CTPN.Fill(this.DS.CTPN);
            tbla_Kho.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_Kho.Fill(this.DS.Kho);
            tbla_VatTu.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_VatTu.Fill(this.DS.VatTu);
            tbla_DSNV.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_DSNV.Fill(this.DS.DsNV);
             
            SetUIConstraints();

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

            // Special 
            if (bds_DDH_Chua_Nhap.Count == 0)
                btn_add.Enabled = false;
            
        }

        private void cbb_fullname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbb_fullname.SelectedValue != null)
                    txt_eeId.Text = cbb_fullname.SelectedValue.ToString();
            }
            catch { }
        }

        private void cbb_whsname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbb_whsname.SelectedValue != null)
                    txt_whsId.Text = cbb_whsname.SelectedValue.ToString();
            }
            catch { }
        }

        private void btn_add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TurnOnEditingState();

            RowIndex = bds_PhieuNhap.Position;
            NewRow = bds_PhieuNhap.AddNew();
            State = FormState.Adding;

            // ?
            try
            {
                if (cbb_DDH.Items.Count > 0)
                {
                    cbb_DDH.SelectedIndex = 0;
                    ((DataRowView)bds_PhieuNhap.Current)["MaSoDDH"] = cbb_DDH.SelectedValue.ToString();
                }
            }
            catch { }

            txt_importId.ReadOnly = false;
            // Group info
            dte_date.Enabled = false;
            dte_date.EditValue = DateTime.Now.ToString();
            dte_date.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";

            // Strip Menu Item
            ms_delete.Visible = ms_cancel.Visible = true;
            ms_save.Visible = ms_reload.Visible = false;
        }

        private void btn_edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TurnOnEditingState();
            cbb_DDH.Enabled = false;
        }

        private void btn_delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // 1. Check wheather this Employee can be deleted
            // A row can not be deleted if it's referenced to another Table (it's a FK)
            string ImReceiptId = "";

            var deleteConfirm = MessageBox.Show("Phiếu Nhập sẽ bị xóa vĩnh viễn, bạn có muốn xóa?", "Xác nhận xóa", MessageBoxButtons.OKCancel);
            if (deleteConfirm == DialogResult.OK)
            {
                var execDeletePNCommand = new SqlCommand(SP_DeletePhieuNhap)
                {
                    CommandType = CommandType.StoredProcedure,
                    Connection = Program.Connection,
                };

                string maPN = ((DataRowView)bds_PhieuNhap.Current)["MaPN"].ToString();
                execDeletePNCommand.Parameters.AddWithValue("@MaPN", maPN);

                try
                {
                    if (Program.Connection.State == ConnectionState.Closed)
                        Program.Connection.Open();

                    execDeletePNCommand.ExecuteNonQuery();
                    Program.Connection.Close();

                    tbla_PhieuNhap.Fill(DS.PhieuNhap);
                }
                catch (Exception ex) // There maybe it's deleted it in UI but not in DB -> Re fill the UI
                {
                    MessageBox.Show("Xảy ra lỗi trong khi xóa. Vui lòng thử lại!\t" + ex.Message, "Lỗi Xóa ở DB", MessageBoxButtons.OK); // Sometimes, computers are crazy so ... 
                    tbla_PhieuNhap.Fill(DS.PhieuNhap);
                    bds_PhieuNhap.Position = bds_PhieuNhap.Find("MaPN", ImReceiptId); // Jump to Receipt position
                    return;
                }
            }

            // Special -> Because it's always greater than 0
            tbla_DDH_Chua_Nhap.Fill(DS.DDH_Chua_Nhap);
            btn_add.Enabled = true;

            if (bds_PhieuNhap.Count == 0)
                btn_delete.Enabled = false;
        }
        private bool ValidateInputs()
        {
            if (txt_importId.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống Mã Phiếu nhập!", "Lỗi nhập liệu", MessageBoxButtons.OK);
                txt_importId.Focus();
                return false;
            }
            if (cbb_fullname.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống Nhân viên lập phiếu!", "Lỗi nhập liệu", MessageBoxButtons.OK);
                cbb_fullname.Focus();
                return false;
            }
            if (cbb_whsname.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống Kho!", "Lỗi nhập liệu", MessageBoxButtons.OK);
                cbb_whsname.Focus();
                return false;
            }

            return true;
        }
        private bool CheckMaPNExist(string MaPN) // true -> Exist / false -> Haven't Existed yet
        {
            var checkCommand = new SqlCommand(SP_CheckMaPNExist)
            {
                CommandType = CommandType.StoredProcedure,
                Connection = Program.Connection,
                Parameters =
                {
                    new SqlParameter()
                    {
                        ParameterName = "@MaPN",
                        Value = MaPN
                    }
                }
            };

            var paramCheckExist = checkCommand.Parameters.Add("@Result", SqlDbType.Int);
            paramCheckExist.Direction = ParameterDirection.ReturnValue;

            try
            {
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

            if ((int)paramCheckExist.Value > 0)
                return true;
            return false;
        }

        private bool AddPhieuNhap()
        {
            MessageBox.Show("Add one and add another will cause an error related to Foreign KEY");
            // Have to check this PhieuNhap whether has any CTPNs?
            if (bds_CTPN.Count == 0)
            {
                MessageBox.Show("Chi tiết Phiếu nhập trống! Không thể tạo Phiếu Nhập!\nVui lòng thêm Chi tiết Phiếu", "Lỗi nhập liệu", MessageBoxButtons.OK);
                cbb_whsname.Focus();
                return false;
            }
            if (CheckMaPNExist(txt_importId.Text.Trim()))
            {
                MessageBox.Show("Mã phiếu nhập đã tồn tại! Vui lòng nhập lại!", "Lỗi nhập liệu", MessageBoxButtons.OK);
                txt_importId.Focus();
                return false;
            }
            // Save changes
            gdv_CTPN.EndEdit();
            bds_CTPN.EndEdit(); // New
            bds_CTPN.ResetCurrentItem();

            bds_PhieuNhap.EndEdit();
            bds_PhieuNhap.ResetCurrentItem();

            tbla_PhieuNhap.Connection.ConnectionString = Program.ConnectionString;
            tbla_CTPN.Connection.ConnectionString = Program.ConnectionString;

            // Write to DB
            try
            {
                tbla_PhieuNhap.Update(DS.PhieuNhap);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi khi thêm Phiếu. Vui lòng thử lại!\t" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                return false;
            }
            try
            {
                tbla_CTPN.Update(DS.CTPN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi khi thêm Chi tiết Phiếu. Vui lòng thử lại!\t" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                return false;
            }

            tbla_DDH_Chua_Nhap.Fill(DS.DDH_Chua_Nhap);
            string maPN = txt_importId.Text;
            tbla_PhieuNhap.Fill(DS.PhieuNhap); // Fix bug
            bds_PhieuNhap.Position = bds_PhieuNhap.Find("MaPN", maPN);
            tbla_CTPN.Fill(DS.CTPN);

            TurnOffEditingState();

            if (DS.DDH_Chua_Nhap.Count == 0)
                btn_add.Enabled = false;

            return true;
        }
        private void btn_save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!ValidateInputs()) return;

            if (State == FormState.Adding)
            {
                if (AddPhieuNhap() == false)
                    return;
            }
            else if (State == FormState.Editing)
            {
                bds_PhieuNhap.EndEdit();
                bds_PhieuNhap.ResetCurrentItem();
                tbla_PhieuNhap.Connection.ConnectionString = Program.ConnectionString;
                try
                {
                    tbla_PhieuNhap.Update(DS.PhieuNhap);
                    TurnOffEditingState();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi khi ghi thay đổi Phiếu. Vui lòng thử lại!" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btn_undo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bds_PhieuNhap.CancelEdit();

            if (State == FormState.Adding)
            {
                var res = bds_PhieuNhap.Contains(NewRow);
                if (res) bds_PhieuNhap.Remove(NewRow);
                bds_PhieuNhap.Position = RowIndex;
            }

            // Reset UI & Constraints
            TurnOffEditingState();
            cbb_DDH.Enabled = true; // ?
        }

        private void btn_reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                tbla_PhieuNhap.Fill(DS.PhieuNhap);
                tbla_CTPN.Fill(DS.CTPN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi. Vui lòng thử lại!" + ex.Message, "Lỗi", MessageBoxButtons.OK);
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
                MessageBox.Show("Lỗi kết nối. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK);
                return;
            }

            tbla_PhieuNhap.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_PhieuNhap.Fill(this.DS.PhieuNhap);
            tbla_DDH_Chua_Nhap.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_DDH_Chua_Nhap.Fill(this.DS.DDH_Chua_Nhap);
            tbla_CTPN.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_CTPN.Fill(this.DS.CTPN);
            tbla_Kho.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_Kho.Fill(this.DS.Kho);
            tbla_VatTu.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_VatTu.Fill(this.DS.VatTu);
            tbla_DSNV.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_DSNV.Fill(this.DS.DsNV);
        }

        private void ms_delete_Click(object sender, EventArgs e)
        {
            if (bds_CTPN.Count > 0)
            {
                bds_CTPN.RemoveCurrent();
            }
        }

        private void ms_save_Click(object sender, EventArgs e)
        {
            // When Reading
            gdv_CTPN.EndEdit();

            // BindingSource doesnot work! It just works when using DataGridView.EndEdit()
            bds_CTPN.EndEdit();
            bds_CTPN.ResetCurrentItem();

            tbla_CTPN.Connection.ConnectionString = Program.ConnectionString;
            tbla_CTPN.Update(DS.CTPN);
        }

        private void ms_reload_Click(object sender, EventArgs e)
        {
            tbla_CTPN.Fill(DS.CTPN);
        }

        private void ms_cancel_Click(object sender, EventArgs e)
        {
            FillCTPNBasedOnCTDDH();
        }

        private void FillCTPNBasedOnCTDDH() // It took me 3 hours
        {
            var count = bds_CTPN.Count;
            for (int i = 0; i < count; i++)
            {
                bds_CTPN.Position = 0;
                bds_CTPN.RemoveCurrent();
            }

            var maSoDDH = cbb_DDH.SelectedValue;
            Program.Reader =
                Program.ExecSqlDataReader($@"
                    SELECT MaVT, SoLuong, DonGia 
                    FROM CTDDH 
                    WHERE MaSoDDH = '{maSoDDH}'"
                );

            if (Program.Reader.HasRows)
            {
                while (Program.Reader.Read())
                {
                    DataRowView newRow = (DataRowView)bds_CTPN.AddNew();
                    newRow[0] = txt_importId.Text;
                    newRow[1] = Program.Reader["MaVT"];
                    newRow[2] = Program.Reader["SoLuong"];
                    newRow[3] = Program.Reader["DonGia"];
                    bds_CTPN.EndEdit();
                }
            }
            Program.Reader.Close();
        }

        private void cbb_DDH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (State == FormState.Adding)
            {
                if (cbb_DDH.SelectedValue != null)
                {
                    ((DataRowView)bds_PhieuNhap.Current)["MaSoDDH"] = cbb_DDH.SelectedValue.ToString();
                }

                FillCTPNBasedOnCTDDH();
            }
        }

        private void txt_importId_Leave(object sender, EventArgs e)
        {
            bds_PhieuNhap.EndEdit();
            bds_PhieuNhap.ResetCurrentItem();

            FillCTPNBasedOnCTDDH();
        }
    }
}