using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT_DATHANG
{
    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        private readonly SqlConnection PublisherConnection = new SqlConnection("Server=localhost; Database=QLVT_DATHANG; Integrated Security=True");
        private readonly string SubscriptionsViewName = "V_DS_PhanManh";
        private readonly string SPLogin = "dbo.SP_DANGNHAP";

        // 2. Get Subscriptions from Publisher
        private bool ConnectToPublisher()
        {
            if (PublisherConnection != null && PublisherConnection.State == ConnectionState.Open)
                PublisherConnection.Close();
            try
            {
                PublisherConnection.Open();
                return true;
            }
            catch
            {
                MessageBox.Show("Error when connecting to Publisher Server.\nPlease check your Server name & Database in connection string");
                return false;
            }
        }
        private void LoadSubscriptionsToCombobox()
        {
            if (!ConnectToPublisher())
                return;

            var dataTable = new DataTable();
            var adapter = new SqlDataAdapter($"SELECT TOP 2 * FROM {SubscriptionsViewName}", PublisherConnection);
            adapter.Fill(dataTable);
            PublisherConnection.Close();

            // Store for later using in branch combobox
            Program.bds_subscriptionList.DataSource = dataTable;

            cb_branch.DataSource = dataTable;
            cb_branch.DisplayMember = "TenCN";
            cb_branch.ValueMember = "TenServer";

            cb_branch.SelectedIndex = 1;
            cb_branch.SelectedIndex = 0;
        }
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            LoadSubscriptionsToCombobox();
            cb_branch.DropDownStyle = ComboBoxStyle.DropDownList;
            txb_username.Text = "TT";
            txb_password.Text = "123456";
        }

        // 3. Event when Branch Value changes in Combobox
        private void cb_branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.Server = cb_branch.SelectedValue.ToString();
            }
            catch
            {
                Console.WriteLine("Xuất hiện lỗi! Vui lòng xem lại code!");
            }
        }

        // 4. Handle Login
        private bool HandleLogin()
        {
            // It's set here because here we can access form controls
            Program.UserId = Program.ConnectionUserId = txb_username.Text;
            Program.Password = Program.ConnectionPassword = txb_password.Text;
            
            // Index of subscription in list
            // Used to set index of combobox in Employee Form
            Program.SubsIndex = cb_branch.SelectedIndex; 
            
            // Open connection
            if (!Program.LoginToServer()) // Stop program when Logging in failed!
                return false;

            // When Uid & password are correct!

            var cmdExecSP = $"EXEC {SPLogin} '{Program.UserId}'";
            Program.Reader = Program.ExecSqlDataReader(cmdExecSP);
            if (Program.Reader == null)
                return false;

            Program.Reader.Read();
            Program.EmployeeId = Program.Reader[0].ToString();
            Program.FullName = Program.Reader[1].ToString();
            Program.Role = Program.Reader[2].ToString();

            Program.Reader.Close();
            Program.Connection.Close();

            if (Convert.IsDBNull(Program.EmployeeId)) // ???
            {
                MessageBox.Show("Thông tin login bị sai!\tVui lòng kiểm tra lại Chi nhánh, Username & Mật khẩu!", "", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txb_username.Text.Trim() == "" || txb_password.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống Username & Mật khẩu!");
                return;
            }

            bool loginResult = HandleLogin();
            if (!loginResult)
                return;

            Close();

            Program.FormMain.page_cat.Visible = true;

            Program.FormMain.btn_login.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInCustomizing; // False
            Program.FormMain.btn_logout.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInRuntime; // True

            Program.FormMain.MaximizeBox = true;
            Program.FormMain.WindowState = FormWindowState.Maximized;
            Program.FormMain.Show();
            
            Program.FormMain.MaNV.Text = "Employee ID: " + Program.EmployeeId.ToString();
            Program.FormMain.HoTen.Text = "Full name: " + Program.FullName.ToString();
            Program.FormMain.Nhom.Text = "Role: " + Program.Role.ToString();
        }
    }
}