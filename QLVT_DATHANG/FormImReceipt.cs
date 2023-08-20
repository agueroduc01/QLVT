using DevExpress.UIAutomation;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Filtering.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public int RowIndex = 0; // When recovering deleted row, insert that row to this index (like never far away)
        public object NewRow;
        public bool IsAdding = false;
        public FormImReceipt()
        {
            InitializeComponent();
        }

        private void SetUIConstraints()
        {
            // Bar Manager
            txt_importId.ReadOnly = true;
            txt_eeId.ReadOnly = true;
            txt_whsId.ReadOnly = true;

            // Group Control Infor
            gpc_info.Enabled = false;
            cbb_fullname.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_whsname.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_DDH.DropDownStyle = ComboBoxStyle.DropDownList;
            dte_date.Properties.EditMask = "dd/MM/yyyy";
            dte_date.Properties.UseMaskAsDisplayFormat = true;
            dte_date.ReadOnly = true;

            cbb_product.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_price.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            txt_price.Properties.DisplayFormat.FormatString = "n0";
            txt_price.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            txt_price.Properties.EditFormat.FormatString = "n0";
            txt_quantity.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            txt_quantity.Properties.DisplayFormat.FormatString = "n0";
            txt_quantity.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            txt_quantity.Properties.EditFormat.FormatString = "n0";

            // Group control Phieu Nhap
            colMaPN.OptionsColumn.AllowEdit = false;
            colNgay.OptionsColumn.AllowEdit = false;
            colMaSoDDH.OptionsColumn.AllowEdit = false;
            colMaNV.OptionsColumn.AllowEdit = false;
            colMaKho.OptionsColumn.AllowEdit = false;

            colNgay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            colNgay.DisplayFormat.FormatString = "dd/MM/yyyy";

            // Grid view CTPN
            colCTPNMaPN.ReadOnly = true;    colCTPNMaPN.HeaderText = "Mã Phiếu Nhập";
            colCTPNMaVT.ReadOnly = true;    colCTPNMaVT.HeaderText = "Mã Vật Tư";
            colCTPNSoLuong.ReadOnly = true; colCTPNSoLuong.HeaderText = "Số Lượng";
            colCTPNDonGia.ReadOnly = true;  colCTPNDonGia.HeaderText = "Đơn Giá";
        }

        private void TurnOnEditingState()
        {
            gpc_info.Enabled = true;
            gdc_PhieuNhap.Enabled = false;

            btn_add.Enabled = btn_edit.Enabled = btn_delete.Enabled = btn_reload.Enabled = false;
            btn_save.Enabled = btn_undo.Enabled = true;
        }

        private void TurnOffEditingState()
        {
            gpc_info.Enabled = false;
            gdc_PhieuNhap.Enabled = true;

            btn_add.Enabled = btn_edit.Enabled = btn_delete.Enabled = btn_reload.Enabled = true;
            btn_save.Enabled = btn_undo.Enabled = false;
            IsAdding = false;

            // Special of Import Receipt
            cbb_DDH.DataSource = bds_PhieuNhap;
            cbb_DDH.DisplayMember = "MaSoDDH";
            cbb_DDH.ValueMember = "MaSoDDH";

            tbla_DDH_Chua_Nhap.Fill(DS.DDH_Chua_Nhap);
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

            // Load combobox branch
            cb_branch.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_branch.DataSource = Program.bds_subscriptionList;
            cb_branch.DisplayMember = "TenCN";
            cb_branch.ValueMember = "TenServer";
            cb_branch.SelectedIndex = Program.SubsIndex;

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
            }catch { }
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
            NewRow = bds_PhieuNhap.AddNew();
            IsAdding = true;

            cbb_DDH.DataSource = bds_DDH_Chua_Nhap;
            cbb_DDH.DisplayMember = "MaSoDDH";
            cbb_DDH.ValueMember = "MaSoDDH";
            try
            {
                if (cbb_DDH.Items.Count > 0)
                    cbb_DDH.SelectedIndex = 0;
            }
            catch { }

            // 
            txt_importId.ReadOnly = false;
            dte_date.Enabled = false;
            dte_date.EditValue = DateTime.Now.ToString();
            dte_date.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";

            // Special 
            if (bds_DDH_Chua_Nhap.Count == 0)
                btn_add.Enabled = false;
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

            var deleteConfirm = MessageBox.Show("Bạn chắc chắc muốn xóa Phiếu nhập này?", "Xác nhận xóa", MessageBoxButtons.OKCancel);
            if (deleteConfirm == DialogResult.OK)
            {
                try
                {
                    var idData = ((DataRowView)bds_PhieuNhap[bds_PhieuNhap.Position])["MaPN"].ToString();
                    ImReceiptId = idData; // Store Receipt ID to roll back to this Employee position
                    bds_PhieuNhap.RemoveCurrent();

                    tbla_PhieuNhap.Connection.ConnectionString = Program.ConnectionString;
                    tbla_PhieuNhap.Update(DS.PhieuNhap);

                    
                }
                catch (Exception ex) // There maybe it's deleted it in UI but not in DB -> Re fill the UI
                {
                    MessageBox.Show("Xảy ra lỗi trong khi xóa. Vui lòng thử lại!\t" + ex.Message, "Lỗi", MessageBoxButtons.OK); // Sometimes, computers are crazy so ... 
                    tbla_PhieuNhap.Fill(DS.PhieuNhap);
                    bds_PhieuNhap.Position = bds_PhieuNhap.Find("MaPN", ImReceiptId); // Jump to Receipt position
                    return;
                }
            }

            // Special -> Because it's always greater than 0
            tbla_DDH_Chua_Nhap.Fill(DS.DDH_Chua_Nhap);
            btn_add.Enabled = true;
        }

        private void btn_save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_importId.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống Mã Phiếu nhập!", "Lỗi nhập liệu", MessageBoxButtons.OK);
                txt_importId.Focus();
                return;
            }
            if (cbb_fullname.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống Nhân viên lập phiếu!", "Lỗi nhập liệu", MessageBoxButtons.OK);
                cbb_fullname.Focus();
                return;
            }
            if (cbb_whsname.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống Kho!", "Lỗi nhập liệu", MessageBoxButtons.OK);
                cbb_whsname.Focus();
                return;
            } 
            // Have to check this PhieuNhap whether has any CTPNs?

            try
            {
                bds_PhieuNhap.EndEdit();
                bds_PhieuNhap.ResetCurrentItem();

                tbla_PhieuNhap.Connection.ConnectionString = Program.ConnectionString;
                tbla_PhieuNhap.Update(DS.PhieuNhap);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi khi thêm Phiếu. Vui lòng thử lại!" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                return;
            }

            TurnOffEditingState();

            // Special 
            tbla_DDH_Chua_Nhap.Fill(DS.DDH_Chua_Nhap);
            var ds = DS.DDH_Chua_Nhap as DataTable;
            if (ds.Rows.Count == 0)
                btn_add.Enabled = false;
        }

        private void btn_undo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bds_PhieuNhap.CancelEdit();
            if (IsAdding)
            {
                var res = bds_PhieuNhap.Contains(NewRow);
                if (res)
                    bds_PhieuNhap.Remove(NewRow);
                IsAdding = false;
            }
            cbb_DDH.Enabled = true;

            if (btn_add.Enabled == false) // When adding the Row Position points to the last row
                bds_PhieuNhap.Position = RowIndex;

            TurnOffEditingState();
        }

        private void btn_reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                tbla_PhieuNhap.Fill(DS.PhieuNhap);
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

        private void ms_add_Click(object sender, EventArgs e)
        {

        }

        private void ms_save_Click(object sender, EventArgs e)
        {

        }

        private void ms_delete_Click(object sender, EventArgs e)
        {

        }

        private void ms_cancel_Click(object sender, EventArgs e)
        {

        }
    }
}