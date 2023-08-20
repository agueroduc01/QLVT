using DevExpress.Utils.Filtering.Internal;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT_DATHANG
{
    public partial class FormExReceipt : DevExpress.XtraEditors.XtraForm
    {
        public int RowIndex = 0; // When recovering deleted row, insert that row to this index (like never far away)
        public object NewRow;
        public bool IsAdding = false;
        public FormExReceipt()
        {
            InitializeComponent();
        }
        private void SetUIConstraints()
        {
            // Group Control
            txt_exportId.ReadOnly = true;
            txt_eeId.ReadOnly = true;
            txt_whsId.ReadOnly = true;

            // Group Control Infor
            gpc_info.Enabled = false;
            cbb_fullname.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_whsname.DropDownStyle = ComboBoxStyle.DropDownList;
            dte_date.Properties.EditMask = "dd/MM/yyyy";
            dte_date.Properties.UseMaskAsDisplayFormat = true;
            dte_date.ReadOnly = true;

            // Group control Phieu Xuat
            colMaPX.OptionsColumn.AllowEdit = false; colMaPX.Caption = "Mã Phiếu Xuất";
            colNgay.OptionsColumn.AllowEdit = false; colNgay.Caption = "Ngày";
            colNgay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            colNgay.DisplayFormat.FormatString = "dd/MM/yyyy";
            colHoTenKH.OptionsColumn.AllowEdit = false; colHoTenKH.Caption = "Họ tên Khách hàng";
            colMaNV.OptionsColumn.AllowEdit = false; colMaNV.Caption = "Mã Nhân viên";
            colMaKho.OptionsColumn.AllowEdit = false; colMaKho.Caption = "Mã Kho";

            // Grid view CTPX
            colCTPXMaPX.HeaderText = "Mã Phiếu Xuất"; colCTPXMaPX.Width = 220; colCTPXMaPX.ReadOnly = true;
            colCTPXVT.HeaderText = "Vật Tư"; colCTPXVT.Width = 220;
            colCTPXSoLuong.HeaderText = "Số Lượng"; colCTPXSoLuong.Width = 220;
            colCTPXDonGia.HeaderText = "Đơn Giá"; colCTPXDonGia.Width = 220;

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
            // Grid Control "Phiếu xuất"
            gdc_PhieuXuat.Enabled = false;
        }
        private void TurnOffEditingState()
        {
            // Tool bar manager 
            btn_add.Enabled = btn_edit.Enabled = btn_delete.Enabled = btn_reload.Enabled = true;
            btn_save.Enabled = btn_undo.Enabled = false;
            // Group Info "Bảng thông tin"
            gpc_info.Enabled = false;
            txt_exportId.ReadOnly = true;
            // Grid Control "Phiếu xuất"
            gdc_PhieuXuat.Enabled = true;
            // Change State
            IsAdding = false;
            // Context menu strip
            ms_save.Visible = ms_cancel.Visible = true;
        }
        private void FormExReceipt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.VatTu' table. You can move, or remove it, as needed.
            this.tbla_VatTu.Fill(this.DS.VatTu);

            DS.EnforceConstraints = false;

            tbla_PhieuXuat.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_PhieuXuat.Fill(this.DS.PhieuXuat);
            tbla_CTPX.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_CTPX.Fill(this.DS.CTPX);
            tbla_DSNV.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_DSNV.Fill(this.DS.DsNV);
            tbla_Kho.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_Kho.Fill(this.DS.Kho);
             
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
        }

        private void btn_add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TurnOnEditingState();

            RowIndex = bds_PhieuXuat.Position;
            NewRow = bds_PhieuXuat.AddNew();
            IsAdding = true;

            txt_exportId.ReadOnly = false;
            // Date Edit 
            dte_date.Enabled = false;
            dte_date.EditValue = DateTime.Now.ToString();
            dte_date.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";

            // Strip Menu Item
            ms_save.Visible = ms_cancel.Visible = false;
        }
        private void btn_edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TurnOnEditingState();
        }
        private void btn_delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // 1. Check wheather this Employee can be deleted
            // A row can not be deleted if it's referenced to another Table (it's a FK)
            string ExReceiptId = "";

            var deleteConfirm = MessageBox.Show("Phiếu Xuất sẽ bị xóa vĩnh viễn, bạn có muốn xóa?", "Xác nhận xóa", MessageBoxButtons.OKCancel);
            if (deleteConfirm == DialogResult.OK)
            {
                try
                {
                    var idData = ((DataRowView)bds_PhieuXuat[bds_PhieuXuat.Position])["MaPX"].ToString();
                    ExReceiptId = idData; // Store Receipt ID to roll back to this Employee position
                    bds_PhieuXuat.RemoveCurrent();

                    tbla_PhieuXuat.Connection.ConnectionString = Program.ConnectionString;
                    tbla_PhieuXuat.Update(DS.PhieuXuat);
                }
                catch (Exception ex) // There maybe it's deleted it in UI but not in DB -> Re fill the UI
                {
                    MessageBox.Show("Xảy ra lỗi khi xóa Phiếu Xuất. Vui lòng thử lại\n" + ex.Message, "Lỗi Xóa ở DB", MessageBoxButtons.OK); // Sometimes, computers are crazy so ... 
                    tbla_PhieuXuat.Fill(DS.PhieuXuat);
                    bds_PhieuXuat.Position = bds_PhieuXuat.Find("MaPX", ExReceiptId); // Jump to Receipt position
                    return;
                }
            }

            if (bds_PhieuXuat.Count == 0)
                btn_delete.Enabled = false;
        }
        private bool ValidateInputs()
        {
            if (txt_exportId.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền thông tin Mã Phiếu Xuất!", "Lỗi nhập liệu", MessageBoxButtons.OK);
                txt_exportId.Focus();
                return false;
            }
            if (dte_date.EditValue.ToString().Trim() == "")
            {
                MessageBox.Show("Vui lòng điền thông tin Ngày!", "Lỗi nhập liệu", MessageBoxButtons.OK);
                dte_date.Focus();
                return false;
            }
            if (txt_cusName.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền thông tin Khách hàng!", "Lỗi nhập liệu", MessageBoxButtons.OK);
                txt_cusName.Focus();
                return false;
            }
            if (cbb_fullname.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền thông tin Nhân viên!", "Lỗi nhập liệu", MessageBoxButtons.OK);
                cbb_fullname.Focus();
                return false;
            }
            if (cbb_whsname.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền thông tin Kho!", "Lỗi nhập liệu", MessageBoxButtons.OK);
                cbb_whsname.Focus();
                return false;
            }
            return true;
        }
        private bool AddReceipt()
        {
            // Validate CTPX
            if (bds_CTPX.List.Count == 0)
            {
                MessageBox.Show("Khi thêm Phiếu xuất không được để trống Phiếu xuất. Vui lòng nhập lại!", "Lỗi nhập liệu");
                return false;
            }

            // Validate CTPX inputs
            foreach (DataRowView item in bds_CTPX)
            {
                if (item["MaVT"].ToString().Trim() == "")
                {
                    MessageBox.Show("Vật tư trong Chi tiết phiếu nhập không được để trống. Vui lòng kiểm tra lại", "Lỗi nhập liệu");
                    return false;
                }
                if (item["SoLuong"].ToString().Trim() == "")
                {
                    MessageBox.Show("Số lượng trong Chi tiết phiếu nhập không được để trống. Vui lòng kiểm tra lại", "Lỗi nhập liệu");
                    return false;
                }
                if (item["DonGia"].ToString().Trim() == "")
                {
                    MessageBox.Show("Đơn giá trong Chi tiết phiếu nhập không được để trống. Vui lòng kiểm tra lại", "Lỗi nhập liệu");
                    return false;
                }
            }

            tbla_CTPX.Connection.ConnectionString = Program.ConnectionString;
            tbla_PhieuXuat.Connection.ConnectionString = Program.ConnectionString;

            // Update PhieuXuat
            try
            {
                tbla_PhieuXuat.Update(DS.PhieuXuat);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi khi thêm Phiếu xuất. Vui lòng thử lại\n" + ex.Message, "Lỗi ghi vào CSDL", MessageBoxButtons.OK);
                return false;
            }
            // Update CTPX
            try
            {
                tbla_CTPX.Update(DS.CTPX);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi khi thêm Chi tiết Phiếu xuất. Vui lòng thử lại\n" + ex.Message, "Lỗi ghi vào CSDL", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }
        private void btn_save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!ValidateInputs())
                return;

            gdv_CTPX.EndEdit();
            bds_CTPX.EndEdit();
            bds_PhieuXuat.EndEdit();
            bds_PhieuXuat.ResetCurrentItem();

            if (IsAdding == true)
            {
                if (!AddReceipt()) return;
            }
            else
            {
                tbla_PhieuXuat.Connection.ConnectionString = Program.ConnectionString;
                try
                {
                    tbla_PhieuXuat.Update(DS.PhieuXuat);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi khi Ghi thông tin Phiếu Xuất vào CSDL. Vui lòng thử lại\n" + ex.Message, "Lỗi ghi vào CSDL", MessageBoxButtons.OK);
                    return;
                }
            }

            TurnOffEditingState();
        }
        private void btn_undo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bds_PhieuXuat.CancelEdit();
            if (IsAdding)
            {
                var res = bds_PhieuXuat.Contains(NewRow);
                if (res)
                    bds_PhieuXuat.Remove(NewRow);

                bds_PhieuXuat.Position = RowIndex;
            }

            TurnOffEditingState();
        }
        private void btn_reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                tbla_PhieuXuat.Fill(DS.PhieuXuat);
                tbla_CTPX.Fill(DS.CTPX);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when reloading: " + ex.Message, "", MessageBoxButtons.OK);
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
                MessageBox.Show("Error when connecting to new branch", "Error", MessageBoxButtons.OK);
                return;
            }

            tbla_PhieuXuat.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_PhieuXuat.Fill(this.DS.PhieuXuat);
            tbla_CTPX.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_CTPX.Fill(this.DS.CTPX);
            tbla_DSNV.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_DSNV.Fill(this.DS.DsNV);
            tbla_Kho.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_Kho.Fill(this.DS.Kho);
        }

        private void cbb_fullname_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_fullname.SelectedValue != null)
            {
                try
                {
                    txt_eeId.Text = cbb_fullname.SelectedValue.ToString();
                }
                catch { }
            }
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

        private void ms_save_Click(object sender, EventArgs e)
        {
            gdv_CTPX.EndEdit();
            bds_CTPX.EndEdit();
            bds_PhieuXuat.EndEdit();

            tbla_PhieuXuat.Connection.ConnectionString = Program.ConnectionString;
            try
            {
                tbla_CTPX.Update(DS.CTPX);
                MessageBox.Show("Ghi Chi tiết Phiếu Xuất vào CSDL thành công!", "Thông tin");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi dữ liệu vào CSDL! Vui lòng thử lại\t" + ex.Message);
            }
        }

        private void ms_delete_Click(object sender, EventArgs e)
        {
            if (bds_CTPX.Current != null)
                bds_CTPX.RemoveCurrent();
        }

        private void ms_cancel_Click(object sender, EventArgs e)
        {
            tbla_CTPX.Fill(DS.CTPX);
        }

        private void txt_exportId_Leave(object sender, EventArgs e)
        {
            bds_PhieuXuat.EndEdit();
            bds_PhieuXuat.ResetCurrentItem();
        }
    }
}