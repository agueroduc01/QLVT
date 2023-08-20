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
            // Bar Manager
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
            colMaPX.OptionsColumn.AllowEdit = false;
            colNgay.OptionsColumn.AllowEdit = false;
            colHoTenKH.OptionsColumn.AllowEdit = false;
            colMaNV.OptionsColumn.AllowEdit = false;
            colMaKho.OptionsColumn.AllowEdit = false;
            colNgay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            colNgay.DisplayFormat.FormatString = "dd/MM/yyyy";

            cbb_product.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_price.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            txt_price.Properties.DisplayFormat.FormatString = "n0";
            txt_price.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            txt_price.Properties.EditFormat.FormatString = "n0";
            txt_quantity.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            txt_quantity.Properties.DisplayFormat.FormatString = "n0";
            txt_quantity.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            txt_quantity.Properties.EditFormat.FormatString = "n0";

            // Grid view CTPX
            colCTPXMaPX.ReadOnly = true; colCTPXMaPX.HeaderText = "Mã Phiếu Xuất";  colCTPXMaPX.Width = 220;
            colCTPXMaVT.ReadOnly = true; colCTPXMaVT.HeaderText = "Mã Vật Tư";      colCTPXMaVT.Width = 220;
            colCTPXSoLuong.ReadOnly = true; colCTPXSoLuong.HeaderText = "Số Lượng"; colCTPXSoLuong.Width = 220;
            colCTPXDonGia.ReadOnly = true; colCTPXDonGia.HeaderText = "Đơn Giá";    colCTPXDonGia.Width = 220;

            
        }
        private void TurnOnEditingState()
        {
            gpc_info.Enabled = true;
            gdc_PhieuXuat.Enabled = false;

            btn_add.Enabled = btn_edit.Enabled = btn_delete.Enabled = btn_reload.Enabled = false;
            btn_save.Enabled = btn_undo.Enabled = true;
        }
        private void TurnOffEditingState()
        {
            gpc_info.Enabled = false;
            gdc_PhieuXuat.Enabled = true;

            btn_add.Enabled = btn_edit.Enabled = btn_delete.Enabled = btn_reload.Enabled = true;
            btn_save.Enabled = btn_undo.Enabled = false;
            IsAdding = false;
        }

        private void phieuXuatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_PhieuXuat.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

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
        }

        private void btn_add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TurnOnEditingState();
            NewRow = bds_PhieuXuat.AddNew();
            IsAdding = true;

            // 
            txt_exportId.ReadOnly = false;
            dte_date.Enabled = false;
            dte_date.EditValue = DateTime.Now.ToString();
            dte_date.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
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

            var deleteConfirm = MessageBox.Show("Are you sure to delete this Export Receipt?", "Confirm", MessageBoxButtons.OKCancel);
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
                    MessageBox.Show("Error when deleting this employee. Please delete again" + ex.Message, "", MessageBoxButtons.OK); // Sometimes, computers are crazy so ... 
                    tbla_PhieuXuat.Fill(DS.PhieuXuat);
                    bds_PhieuXuat.Position = bds_PhieuXuat.Find("MaPX", ExReceiptId); // Jump to Receipt position
                    return;
                }
            }

            if (bds_PhieuXuat.Count == 0)
                btn_delete.Enabled = false;
        }

        private void btn_save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_exportId.Text.Trim() == "")
            {
                MessageBox.Show("Cannot blank Import ID!", "", MessageBoxButtons.OK);
                txt_exportId.Focus();
                return;
            }
            if (dte_date.EditValue.ToString().Trim() == "")
            {
                MessageBox.Show("Cannot blank Date!", "", MessageBoxButtons.OK);
                dte_date.Focus();
                return;
            }
            if (txt_cusName.Text.Trim() == "")
            {
                MessageBox.Show("Cannot blank Customer!", "", MessageBoxButtons.OK);
                txt_cusName.Focus();
                return;
            }
            if (cbb_fullname.Text.Trim() == "")
            {
                MessageBox.Show("Cannot blank Employee!", "", MessageBoxButtons.OK);
                cbb_fullname.Focus();
                return;
            }
            if (cbb_whsname.Text.Trim() == "")
            {
                MessageBox.Show("Cannot blank Warehouse!", "", MessageBoxButtons.OK);
                cbb_whsname.Focus();
                return;
            }
            // Have to check this PhieuNhap whether has any CTPNs?

            try
            {
                bds_PhieuXuat.EndEdit();
                bds_PhieuXuat.ResetCurrentItem();

                tbla_PhieuXuat.Connection.ConnectionString = Program.ConnectionString;
                tbla_PhieuXuat.Update(DS.PhieuXuat);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when adding Export Receipt!" + ex.Message, "Error", MessageBoxButtons.OK);
                return;
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
                IsAdding = false;
            }


            if (btn_add.Enabled == false)
                bds_PhieuXuat.Position = RowIndex;

            TurnOffEditingState();
        }

        private void btn_reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                tbla_PhieuXuat.Fill(DS.PhieuXuat);
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
         
    }
}