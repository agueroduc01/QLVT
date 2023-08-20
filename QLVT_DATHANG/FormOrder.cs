using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraReports.UI;
using QLVT_DATHANG.ReportForm;
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
    public partial class FormOrder : DevExpress.XtraEditors.XtraForm
    {
        private enum FormState
        {
            Reading = 0,
            Adding = 1,
            Editing = 2,
        }
        public int RowDatHangIndex = 0; // When recovering deleted row, insert that row to this index (like never far away)
        public object NewDDHRow;
        private FormState CurrentState = FormState.Reading;

        public FormOrder()
        {
            InitializeComponent();
        }
         
        private void SetUpUIConstraints()
        {
            // Group Control
            this.AutoScaleMode = AutoScaleMode.None;
            txt_eeId.ReadOnly = true;
            txt_whsId.ReadOnly = true;

            // Group Control format & type
            gpc_info.Enabled = false;
            cbb_fullname.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_whsname.DropDownStyle = ComboBoxStyle.DropDownList;
            dte_date.ReadOnly = true;
            dte_date.Properties.EditMask = "dd/MM/yyyy";
            dte_date.Properties.UseMaskAsDisplayFormat = true;

            // GridView Don Dat Hang
            colMaSoDDH.OptionsColumn.AllowEdit = false; colMaSoDDH.Caption = "Mã Đơn đặt hàng";
            colNgay.OptionsColumn.AllowEdit = false; colNgay.Caption = "Mã Ngày";
            colNgay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            colNgay.DisplayFormat.FormatString = "dd/MM/yyyy";
            colNhaCC.OptionsColumn.AllowEdit = false; colNhaCC.Caption = "Mã Nhà Cung cấp";
            colMaNV.OptionsColumn.AllowEdit = false; colMaNV.Caption = "Mã Nhân viên";
            colMaKho.OptionsColumn.AllowEdit = false; colMaKho.Caption = "Mã Kho";

            // Grid view CTDDH
            colCTDDHMaSoDDH.ReadOnly = true;
            colCTDDHMaSoDDH.HeaderText = "Mã Phiếu Nhập"; colCTDDHMaSoDDH.Width = 220;
            cb_MaVT.HeaderText = "Vật tư"; cb_MaVT.Width = 220;
            colCTDDHSoLuong.HeaderText = "Số Lượng"; colCTDDHSoLuong.Width = 220;
            colCTDDHDonGia.HeaderText = "Đơn Giá"; colCTDDHDonGia.Width = 220;

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
            // Grid Control "Đặt hàng"
            gdc_DatHang.Enabled = false;
        }

        private void TurnOffEditingState()
        {
            // Tool bar manager 
            btn_add.Enabled = btn_edit.Enabled = btn_delete.Enabled = btn_reload.Enabled = true;
            btn_save.Enabled = btn_undo.Enabled = false;
            // Group Info "Bảng thông tin"
            gpc_info.Enabled = false;
            txt_orderId.ReadOnly = true;
            // Grid Control "Đặt hàng"
            gdc_DatHang.Enabled = true;
            CurrentState = FormState.Reading;
            // Context menu strip
            ms_save.Visible = ms_cancel.Visible = true;
        }
        private void FormOrder_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;

            tbla_DatHang.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_DatHang.Fill(this.DS.DatHang);
            tbla_Kho.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_Kho.Fill(this.DS.Kho);
            tbla_DSNV.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_DSNV.Fill(this.DS.DsNV);
            tbla_CTDDH.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_CTDDH.Fill(this.DS.CTDDH);
            tbla_VatTu.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_VatTu.Fill(this.DS.VatTu);

            SetUpUIConstraints();
 
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

            RowDatHangIndex = bds_DatHang.Position;
            NewDDHRow = bds_DatHang.AddNew();
            CurrentState = FormState.Adding;

            txt_orderId.ReadOnly = false;
            //  Date Edit Now
            dte_date.Enabled = false;
            dte_date.EditValue = DateTime.Now.ToString();
            dte_date.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";

            // Strip Menu Items
            ms_save.Visible = ms_cancel.Visible = false;
        }

        private void btn_edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TurnOnEditingState();
        }

        private void btn_delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string OrderId = "";

            var deleteConfirm = MessageBox.Show("Đơn đặt hàng sẽ bị xóa vĩnh viễn, bạn có muốn xóa?", "Xác nhận xóa", MessageBoxButtons.OKCancel);
            if (deleteConfirm == DialogResult.OK)
            {
                try
                {
                    var idData = ((DataRowView)bds_DatHang[bds_DatHang.Position])["MaSoDDH"].ToString();
                    OrderId = idData; // Store Order ID to roll back to this Order position
                    bds_DatHang.RemoveCurrent();

                    tbla_DatHang.Connection.ConnectionString = Program.ConnectionString;
                    tbla_DatHang.Update(DS.DatHang);
                }
                catch (Exception ex) // There maybe it's deleted it in UI but not in DB -> Re fill the UI
                {
                    MessageBox.Show("Xảy ra lỗi khi xóa Đơn đặt hàng. Vui lòng thử lại\n" + ex.Message, "Lỗi Xóa ở DB", MessageBoxButtons.OK); // Sometimes, computers are crazy so ... 
                    tbla_DatHang.Fill(DS.DatHang);
                    bds_DatHang.Position = bds_DatHang.Find("MaSoDDH", OrderId); // Jump to Order position
                    return;
                }
            }

            if (bds_DatHang.Count == 0)
                btn_delete.Enabled = false;
        }
        private bool ValidateInputs()
        {
            if (txt_orderId.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền thông tin Mã Đơn đặt hàng!", "Lỗi nhập liệu", MessageBoxButtons.OK);
                txt_orderId.Focus();
                return false;
            }
            if (txt_supplier.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền thông tin Nhà cung cấp!", "Lỗi nhập liệu", MessageBoxButtons.OK);
                txt_supplier.Focus();
                return false;
            }
            if (cbb_fullname.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền thông tin Nhân viên lập đơn!", "Lỗi nhập liệu", MessageBoxButtons.OK);
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
        private bool AddOrder()
        {
            // Validate CTDDH Count
            if (bds_CTDDH.List.Count == 0)
            {
                MessageBox.Show("Khi thêm Đơn đặt hàng không được để trống Chi tiết Đơn đặt hàng. Vui lòng nhập lại!", "Lỗi nhập liệu");
                return false;
            }

            // Validate CTDDH inputs
            foreach (DataRowView item in bds_CTDDH)
            {
                if (item["MaVT"].ToString().Trim() == "")
                {
                    MessageBox.Show("Vật tư trong Chi tiết đơn không được để trống. Vui lòng kiểm tra lại", "Lỗi nhập liệu");
                    return false;
                }
                if (item["SoLuong"].ToString().Trim() == "")
                {
                    MessageBox.Show("Số lượng trong Chi tiết đơn không được để trống. Vui lòng kiểm tra lại", "Lỗi nhập liệu");
                    return false;
                }
                if (item["DonGia"].ToString().Trim() == "")
                {
                    MessageBox.Show("Đơn giá trong Chi tiết đơn không được để trống. Vui lòng kiểm tra lại", "Lỗi nhập liệu");
                    return false;
                }
            }

            // Check Whether Order ID exist or not
            // ?
            // ?
            // ?

            tbla_CTDDH.Connection.ConnectionString = Program.ConnectionString;
            tbla_DatHang.Connection.ConnectionString = Program.ConnectionString;

            // Update DatHang
            try
            {
                tbla_DatHang.Update(DS.DatHang);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi khi thêm Đơn đặt hàng. Vui lòng thử lại\n" + ex.Message, "Lỗi ghi vào CSDL", MessageBoxButtons.OK);
                return false;
            }
            // Update CTDDH
            try
            {
                tbla_CTDDH.Update(DS.CTDDH);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi khi thêm Chi tiết Đơn đặt hàng. Vui lòng thử lại\n" + ex.Message, "Lỗi ghi vào CSDL", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        private void btn_save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!ValidateInputs())
                return;

            gdv_CTDDH.EndEdit();
            bds_CTDDH.EndEdit();
            bds_DatHang.EndEdit();
            bds_DatHang.ResetCurrentItem();

            // That means DatHang all pass
            // If it's Editing state. Just Save DatHang infor. But if it's Adding -> Check CTDDH
            if (CurrentState == FormState.Adding)
            {
                if (!AddOrder()) return;
            }
            else if (CurrentState == FormState.Editing)
            {
                tbla_DatHang.Connection.ConnectionString = Program.ConnectionString;
                try
                {
                    tbla_DatHang.Update(DS.DatHang);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi khi Ghi thông tin Đơn đặt hàng vào CSDL. Vui lòng thử lại\t" + ex.Message, "Lỗi ghi vào CSDL", MessageBoxButtons.OK);
                    return;
                }
            }

            TurnOffEditingState();
        }
        private void btn_undo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bds_DatHang.CancelEdit();
            if (CurrentState == FormState.Adding)
            {
                var res = bds_DatHang.Contains(NewDDHRow);
                if (res)
                    bds_DatHang.Remove(NewDDHRow);
                bds_DatHang.Position = RowDatHangIndex;
            }

            TurnOffEditingState();
        }
        private void btn_reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                tbla_DatHang.Fill(DS.DatHang);
                tbla_CTDDH.Fill(DS.CTDDH);
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

            tbla_DatHang.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_DatHang.Fill(this.DS.DatHang);
            tbla_Kho.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_Kho.Fill(this.DS.Kho);
            tbla_DSNV.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_DSNV.Fill(this.DS.DsNV);
            tbla_CTDDH.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_CTDDH.Fill(this.DS.CTDDH);
            tbla_VatTu.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_VatTu.Fill(this.DS.VatTu);
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
                {
                    txt_whsId.Text = cbb_whsname.SelectedValue.ToString();
                }
            }
            catch { }
        }

        private void ms_add_Click(object sender, EventArgs e)
        {

        }

        private void ms_save_Click(object sender, EventArgs e)
        {
            gdv_CTDDH.EndEdit();
            bds_CTDDH.EndEdit();

            tbla_CTDDH.Connection.ConnectionString = Program.ConnectionString;
            try
            {
                tbla_CTDDH.Update(DS.CTDDH);
                MessageBox.Show("Ghi Chi tiết đơn đặt hàng vào CSDL thành công!", "Thông tin");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi dữ liệu vào CSDL! Vui lòng thử lại\t" + ex.Message);
            }
        }

        private void ms_delete_Click(object sender, EventArgs e)
        {
            if (bds_CTDDH.Current != null)
                bds_CTDDH.RemoveCurrent();
        }

        private void ms_cancel_Click(object sender, EventArgs e)
        {
            tbla_CTDDH.Fill(DS.CTDDH);
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Xrpt_OrderListDontHaveImports rpt = new Xrpt_OrderListDontHaveImports();
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.PreviewForm.FormClosed += new FormClosedEventHandler(rpt.FormClosedEventHandler);
            print.ShowPreviewDialog();
        }

        private void txt_orderId_Leave(object sender, EventArgs e)
        {
            bds_DatHang.EndEdit();
            bds_DatHang.ResetCurrentItem();
        }
    }
}