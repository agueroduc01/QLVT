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
        public int RowDatHangIndex = 0; // When recovering deleted row, insert that row to this index (like never far away)
        // public int RowCTDDHIndex = 0;
        public object NewDDHRow;
        public object NewCTDDHRow;
        public bool IsAdding = false;
        public FormOrder()
        {
            InitializeComponent();
        }

        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_DatHang.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void SetUpUIConstraints()
        {
            // Bar Manager
            txt_eeId.ReadOnly = true;
            txt_whsId.ReadOnly = true;

            // Group Control Infor
            gpc_info.Enabled = false;
            cbb_fullname.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_whsname.DropDownStyle = ComboBoxStyle.DropDownList;
            dte_date.ReadOnly = true;
            dte_date.Properties.EditMask = "dd/MM/yyyy";
            dte_date.Properties.UseMaskAsDisplayFormat = true;

            // Group control Phieu Nhap
            colMaSoDDH.OptionsColumn.AllowEdit = false; colMaSoDDH.Caption = "Mã Đơn đặt hàng";
            colNgay.OptionsColumn.AllowEdit = false; colNgay.Caption = "Mã Ngày";
            colNhaCC.OptionsColumn.AllowEdit = false; colNhaCC.Caption = "Mã Nhà Cung cấp";
            colMaNV.OptionsColumn.AllowEdit = false; colMaNV.Caption = "Mã Nhân viên";
            colMaKho.OptionsColumn.AllowEdit = false; colMaKho.Caption = "Mã Kho";

            colNgay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            colNgay.DisplayFormat.FormatString = "dd/MM/yyyy";

            // Grid view CTPN
            colCTDDHMaSoDDH.ReadOnly = true;
            colCTDDHMaSoDDH.HeaderText = "Mã Phiếu Nhập"; colCTDDHMaSoDDH.Width = 200;
            MaVT.HeaderText = "Vật tư"; MaVT.Width = 280;
            //cb_MaVT.Width = 280;
            colCTDDHSoLuong.HeaderText = "Số Lượng"; colCTDDHSoLuong.Width = 200;
            colCTDDHDonGia.HeaderText = "Đơn Giá"; colCTDDHDonGia.Width = 200;
    
        }
        private void TurnOnEditingState()
        {
            gpc_info.Enabled = true;
            gdc_DatHang.Enabled = false;

            btn_add.Enabled = btn_edit.Enabled = btn_delete.Enabled = btn_reload.Enabled = false;
            btn_save.Enabled = btn_undo.Enabled = true;
        }

        private void TurnOffEditingState()
        {
            gpc_info.Enabled = false;
            gdc_DatHang.Enabled = true;

            btn_add.Enabled = btn_edit.Enabled = btn_delete.Enabled = btn_reload.Enabled = true;
            btn_save.Enabled = btn_undo.Enabled = false;
            IsAdding = false;

            // Special
            txt_orderId.ReadOnly = false;
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

            // Load combobox branch
            cb_branch.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_branch.DataSource = Program.bds_subscriptionList;
            cb_branch.DisplayMember = "TenCN";
            cb_branch.ValueMember = "TenServer";
            cb_branch.SelectedIndex = Program.SubsIndex;

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
            NewDDHRow = bds_DatHang.AddNew();
            RowDatHangIndex = bds_DatHang.Position;
            IsAdding = true;
            //  
            dte_date.Enabled = false;
            dte_date.EditValue = DateTime.Now.ToString();
            dte_date.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
        }

        private void btn_edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TurnOnEditingState();
            txt_orderId.ReadOnly = true;
        }

        private void btn_delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // 1. Check wheather this Employee can be deleted
            // A row can not be deleted if it's referenced to another Table (it's a FK)
            string OrderId = "";

            var deleteConfirm = MessageBox.Show("Are you sure to delete this Order?", "Confirm", MessageBoxButtons.OKCancel);
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
                    MessageBox.Show("Error when deleting this Import Receipt. Please delete again" + ex.Message, "", MessageBoxButtons.OK); // Sometimes, computers are crazy so ... 
                    tbla_DatHang.Fill(DS.DatHang);
                    bds_DatHang.Position = bds_DatHang.Find("MaSoDDH", OrderId); // Jump to Order position
                    return;
                }
            }

            if (bds_DatHang.Count == 0)
                btn_delete.Enabled = false;
        }

        private void btn_save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_orderId.Text.Trim() == "")
            {
                MessageBox.Show("Cannot blank Order ID!", "", MessageBoxButtons.OK);
                txt_orderId.Focus();
                return;
            }
            if (txt_supplier.Text.Trim() == "")
            {
                MessageBox.Show("Cannot blank Supllier!", "", MessageBoxButtons.OK);
                txt_supplier.Focus();
                return;
            }
            if (cbb_fullname.Text.Trim() == "")
            {
                MessageBox.Show("Cannot blank Employee!", "", MessageBoxButtons.OK);
                cbb_fullname.Focus();
                return;
            }
            if (cbb_whsname.Text.Trim() == "")

            try
            {
                // DataGridViewRow row = gdv_CTDDH.Rows[RowCTDDHIndex];
                // row.Cells[0].Value = txt_orderId.Text;
                // MessageBox.Show($"{((DataRowView)NewCTDDHRow)[0]}");
                
                //bds_DatHang.EndEdit();
                //bds_DatHang.ResetCurrentItem();
                //bds_CTDDH.EndEdit();
                //bds_CTDDH.ResetCurrentItem();

                //tbla_DatHang.Connection.ConnectionString = Program.ConnectionString;
                //tbla_DatHang.Update(DS.DatHang);
                //tbla_CTDDH.Connection.ConnectionString = Program.ConnectionString;
                //tbla_CTDDH.Update(DS.CTDDH);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when adding Order! " + ex.Message, "Error", MessageBoxButtons.OK);
            }
            finally
            {
                TurnOffEditingState();
            }
        }

        private void btn_undo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bds_DatHang.CancelEdit();
            if (IsAdding)
            {
                var res = bds_DatHang.Contains(NewDDHRow);
                if (res)
                    bds_DatHang.Remove(NewDDHRow);
                IsAdding = false;
            }


            if (btn_add.Enabled == false) // When adding the Row Position points to the last row
                bds_DatHang.Position = RowDatHangIndex;

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
            try
            {
                if (cbb_fullname.SelectedValue != null)
                {
                    txt_eeId.Text = cbb_fullname.SelectedValue.ToString();
                }
            }
            catch { }
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
            DataRowView current = (DataRowView)bds_CTDDH.Current;
            var s = current.Row["MaVT"] as string;
            
            MessageBox.Show(s);
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
    }
}