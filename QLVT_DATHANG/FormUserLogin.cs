using DevExpress.Utils.Extensions;
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

namespace QLVT_DATHANG
{
    public partial class FormUserLogin : DevExpress.XtraEditors.XtraForm
    {
        public FormUserLogin()
        {
            InitializeComponent();
        }

        private void SetUIConstraints()
        {
            // Bar Manager
            btn_save.Enabled = btn_undo.Enabled = false;

            // Group Control Info 
            gpc_info.Enabled = false;
            cb_role.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_employeeId.ReadOnly = true;
            txt_password.Properties.UseSystemPasswordChar = true;
            txt_confirmPassword.Properties.UseSystemPasswordChar = true;

            // Grid Control
            colMaNV.Caption = "Mã Nhân viên"; colMaNV.OptionsColumn.AllowEdit = false;
            colHo.Caption = "Họ"; colHo.OptionsColumn.AllowEdit = false;
            colTen.Caption = "Tên"; colTen.OptionsColumn.AllowEdit = false;
            colCMND.Caption = "CMND"; colCMND.OptionsColumn.AllowEdit = false;
            colDiaChi.Caption = "Địa chỉ"; colDiaChi.OptionsColumn.AllowEdit = false;
            colNgaySinh.Caption = "Ngày sinh"; colNgaySinh.OptionsColumn.AllowEdit = false;
            colLuong.Caption = "Lương"; colLuong.OptionsColumn.AllowEdit = false;
            colMaCN.Caption = "Mã Chi nhánh"; colMaCN.OptionsColumn.AllowEdit = false;
            colTrangThaiXoa.Caption = "Trạng thái xóa"; colTrangThaiXoa.OptionsColumn.AllowEdit = false;

            DataTable dt = new DataTable();
            dt.Columns.Add("Role");
            dt.Columns.Add("Name");

            if (Program.Role == "CongTy")
            {
                dt.Rows.Add(new[] { "CongTy", "Công Ty" });
            }
            else
            {
                dt.Rows.Add(new[] { "ChiNhanh", "Chi Nhánh" });
                dt.Rows.Add(new[] { "User", "User" });
            }

            cb_role.DataSource = dt;
            cb_role.DisplayMember = "Name";
            cb_role.ValueMember = "Role";
        }
        private void TurnOnEditingState()
        {
            // Bar managers
            btn_add.Enabled = false;
            btn_save.Enabled = btn_undo.Enabled = true;

            // Controls
            gpc_info.Enabled = true;
            gdc_NVChuaLogin.Enabled = false;
        }
        private void TurnOffEditingState()
        {
            // Bar managers
            btn_add.Enabled = true;
            btn_save.Enabled = btn_undo.Enabled = false;

            // Controls
            gpc_info.Enabled = false;
            gdc_NVChuaLogin.Enabled = true;

            cb_role.SelectedIndex = 0;
            txt_login.Text = txt_password.Text = txt_confirmPassword.Text = "";
        }
        private void FormUserLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.V_LoginList' table. You can move, or remove it, as needed.
            this.tbla_loginList.Fill(this.DS.V_LoginList);
            DS.EnforceConstraints = false;
            this.tbla_NVChuaLogin.Fill(this.DS.NV_ChuaLogin);

            SetUIConstraints();
        }

        private bool CheckConstraints()
        {
            if (txt_login.Text.Trim().Length < 2) 
            {
                MessageBox.Show("Độ dài Tên tài khoản bắt buộc từ 2 ký tự trở lên!", "Lỗi nhập liệu");
                txt_login.Focus();
                return false;
            }
            if (txt_password.Text.Trim().Length < 3)
            {
                MessageBox.Show("Độ dài Mật khẩu bắt buộc từ 3 ký tự trở lên!", "Lỗi nhập liệu");
                txt_password.Focus();
                return false;
            }
            if (txt_password.Text != txt_confirmPassword.Text)
            {
                MessageBox.Show("Mật khẩu và Xác nhận mật khẩu không trùng nhau! Vui lòng nhập lại", "Lỗi nhập liệu");
                txt_confirmPassword.Focus();
                return false;
            }

            return true;
        }
        private void btn_add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TurnOnEditingState();
        }

        private void CreateLoginOnServer(SqlCommand cmd)
        {
            var returnValue = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnValue.Direction = ParameterDirection.ReturnValue;

            if (!Program.LoginToServer())
            {
                MessageBox.Show("Lỗi kết nối tới Chi nhánh mới", "Lỗi kết nối", MessageBoxButtons.OK);
                throw new Exception("");
            }
            // EXEC SP
            try
            {
                if (Program.Connection.State == ConnectionState.Closed)
                    Program.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch 
            {
                Program.Connection.Close(); 
                throw;
            }
            finally
            {
                Program.Connection.Close();
            }

            // Checking Result 
            if ((int) returnValue.Value == 1)
            {
                MessageBox.Show("Login đã tồn tại, vui lòng nhập Login khác!", "Lỗi nhập liệu");
                txt_login.Focus();
                return;
            }
            if ((int)returnValue.Value == 2)
            {
                MessageBox.Show("Username đã tồn tại (Nhân viên đã có tài khoản), vui lòng chọn Nhân viên khác!", "Lỗi nhập liệu");
                return;
            }

            MessageBox.Show("Tạo tài khoản thành công!", "Thông báo");
        }

        private void CreateLogin()
        {
            // Call SP create login
            var login = txt_login.Text;
            var username = txt_employeeId.Text;
            var password = txt_password.Text;
            var role = cb_role.SelectedValue;

            try
            {
                using (var connection = new SqlConnection(Program.ConnectionString))
                {
                    connection.Open();
                    var createLogincommand = new SqlCommand("SP_CreateLogin")
                    {
                        Connection = connection,
                        CommandType = CommandType.StoredProcedure,
                    };

                    createLogincommand.Parameters.AddWithValue("Login", login);
                    createLogincommand.Parameters.AddWithValue("username", username);
                    createLogincommand.Parameters.AddWithValue("password", password);
                    createLogincommand.Parameters.AddWithValue("role", role);

                    CreateLoginOnServer(createLogincommand);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi khi Tạo tài khoản! Vui lòng thử lại!\n" + ex.Message, "Lỗi");
                return;
            }

            tbla_NVChuaLogin.Fill(DS.NV_ChuaLogin);
            TurnOffEditingState();
        }

        private void btn_save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        { 
            if (!CheckConstraints())
                return;

            CreateLogin();
        }

        private void btn_undo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TurnOffEditingState();
        }

        private void btn_reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tbla_NVChuaLogin.Fill(DS.NV_ChuaLogin);
        }
    }
}