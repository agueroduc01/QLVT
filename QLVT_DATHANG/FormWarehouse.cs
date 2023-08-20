using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
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
    public partial class FormWarehouse : DevExpress.XtraEditors.XtraForm
    {
        public int RowIndex = 0; // When recovering deleted row, insert that row to this index (like never far away)
        public object NewRow;
        public bool IsAdding;
        public FormWarehouse()
        {
            InitializeComponent();
        }

        private void khoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_Kho.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }
         
        private void TurnOnEditingState()
        {
            RowIndex = bds_Kho.Position;
            gpc_info.Enabled = true;
            gdc_Kho.Enabled = false;

            txt_branchId.Text = Program.BranchId;
            btn_add.Enabled = btn_edit.Enabled = btn_delete.Enabled = btn_reload.Enabled = false;
            btn_save.Enabled = btn_undo.Enabled = true;

            txt_branchId.Enabled = false;
        }
        private void TurnOffEditingState()
        {

            gdc_Kho.Enabled = true;
            gpc_info.Enabled = false;

            btn_add.Enabled = btn_edit.Enabled = btn_delete.Enabled = btn_reload.Enabled = true;
            btn_save.Enabled = btn_undo.Enabled = false;

            IsAdding = false;
        }
        private void FormWarehouse2_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;

            tbla_Kho.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_Kho.Fill(this.DS.Kho);
            tbla_DatHang.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_DatHang.Fill(this.DS.DatHang);
            tbla_PhieuNhap.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_PhieuNhap.Fill(this.DS.PhieuNhap);
            tbla_PhieuXuat.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_PhieuXuat.Fill(this.DS.PhieuXuat);


            cb_branch.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_branch.DataSource = Program.bds_subscriptionList;
            cb_branch.DisplayMember = "TenCN";
            cb_branch.ValueMember = "TenServer";
            cb_branch.SelectedIndex = Program.SubsIndex;

            gpc_info.Enabled = false;

            if (Program.Role == "CongTy")
            {
               btn_add.Enabled = btn_delete.Enabled = btn_edit.Enabled = btn_undo.Enabled = btn_save.Enabled = false;
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
            NewRow = bds_Kho.AddNew();
            IsAdding = true;

            txt_branchId.Text = Program.BranchId;
        }

        private void btn_edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TurnOnEditingState();
        }

        private void btn_delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string warehouseId = "";
            if (bds_DatHang.Count > 0)
            {
                MessageBox.Show(
                    "Kho đã được sử dụng ở Đơn Đặt hàng! Không thể Xóa",
                    "Lỗi Ràng buộc", MessageBoxButtons.OK);
                return;
            }
            if (bds_PhieuNhap.Count > 0)
            {
                MessageBox.Show(
                    "Kho đã được sử dụng ở Đơn Phiếu Nhập! Không thể Xóa",
                    "Lỗi Ràng buộc", MessageBoxButtons.OK);
                return;
            }
            if (bds_PhieuXuat.Count > 0)
            {
                MessageBox.Show(
                    "Kho đã được sử dụng ở Đơn Phiếu Xuất! Không thể Xóa",
                    "Lỗi Ràng buộc", MessageBoxButtons.OK);
                return;
            }

            var deleteConfirm = MessageBox.Show("Kho sẽ bị Xóa Vĩnh viễn! Bạn có muốn xóa?", "Xác nhận Xóa", MessageBoxButtons.OKCancel);
            if (deleteConfirm == DialogResult.OK)
            {
                try
                {
                    warehouseId = ((DataRowView)bds_Kho[bds_Kho.Position])["MaKho"].ToString();
                    bds_Kho.RemoveCurrent();

                    tbla_Kho.Connection.ConnectionString = Program.ConnectionString;
                    tbla_Kho.Update(DS.Kho);
                }
                catch (Exception ex) // There maybe it's deleted it in UI but not in DB -> Re fill the UI
                {
                    MessageBox.Show("Lỗi khi Xóa Kho! Làm ơn thử lại" + ex.Message, "Lỗi", MessageBoxButtons.OK); // Sometimes, computers are crazy so ... 
                    tbla_Kho.Fill(DS.Kho);
                    bds_Kho.Position = bds_Kho.Find("MaKho", warehouseId); // Jump to Employee position
                    return;
                }
            }

            // Strict constraint -> If there are no employees, Cannot Delete
            if (bds_Kho.Count == 0)
                btn_delete.Enabled = false;
        }

        private void btn_save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_id.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống Mã Kho!", "Lỗi Nhập liệu", MessageBoxButtons.OK);
                txt_id.Focus();
                return;
            }
            if (txt_name.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống Tên Kho!", "Lỗi Nhập liệu", MessageBoxButtons.OK);
                txt_name.Focus();
                return;
            }
            if (txt_address.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống Địa chỉ Kho!", "Lỗi Nhập liệu", MessageBoxButtons.OK);
                txt_address.Focus();
                return;
            }

            try
            {
                bds_Kho.EndEdit();
                bds_Kho.ResetCurrentItem();

                tbla_Kho.Connection.ConnectionString = Program.ConnectionString;
                tbla_Kho.Update(DS.Kho);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm Kho!" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                return;
            }

            TurnOffEditingState();
        }

        private void btn_undo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bds_Kho.CancelEdit(); 
            if (IsAdding)
            {
                var res = bds_Kho.Contains(NewRow);
                if (res)
                    bds_Kho.Remove(NewRow);
                IsAdding = false;
            }
            if (btn_add.Enabled == false) // When adding or editing, this button will be unabled
                bds_Kho.Position = RowIndex;

            TurnOffEditingState();
        }

        private void btn_reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                tbla_Kho.Fill(DS.Kho);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi Reload: " + ex.Message, "", MessageBoxButtons.OK);
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
                MessageBox.Show("Lỗi khi kết nối với Chi nhánh khác", "Lỗi", MessageBoxButtons.OK);
                return;
            }

            tbla_Kho.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_Kho.Fill(this.DS.Kho);
            tbla_DatHang.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_DatHang.Fill(this.DS.DatHang);
            tbla_PhieuNhap.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_PhieuNhap.Fill(this.DS.PhieuNhap);
            tbla_PhieuXuat.Connection.ConnectionString = Program.ConnectionString;
            this.tbla_PhieuXuat.Fill(this.DS.PhieuXuat);

            // Role Company cannot edit data and branchid is just used to add data.
            // The reason it's here that is some subjects not only change branch but also update data.
        }
    }
}