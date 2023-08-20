using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraEditors.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLVT_DATHANG
{
    internal static class Program
    {
        public static FormMain FormMain;
        public static BindingSource bds_subscriptionList = new BindingSource();

        public static SqlConnection Connection = new SqlConnection();
        public static string Server;
        public static string Database = "QLVT_DATHANG";
        public static string UserId; // Server Login
        public static string Password;
        public static string ConnectionString;

        public static string RemoteUserId = "HTKN";
        public static string RemotePassword = "123456";
        public static string ConnectionUserId;
        public static string ConnectionPassword;

        public static SqlDataReader Reader;
        public static int SubsIndex;
        public static string EmployeeId;
        public static string FullName;
        public static string Role;
        public static string BranchId;

        public static bool LoginToServer()
        {
            if (Connection != null && Connection.State == ConnectionState.Open)
                Connection.Close();

            try
            {
                var serverString = $"Server={Server};";
                var dbString = $"Database={Database};";
                var uidString = $"Uid={ConnectionUserId};";
                var passwordString = $"Password={ConnectionPassword};";
                ConnectionString = serverString + dbString + uidString + passwordString;

                Connection.ConnectionString = ConnectionString;
                Connection.Open(); // Destination

                var reader = ExecSqlDataReader("SELECT MaCN FROM ChiNhanh");
                if (reader == null)
                {
                    MessageBox.Show("Error when trying to get the current branch.", "Error", MessageBoxButtons.OK);
                    return false;
                }
                reader.Read();
                BranchId = reader[0].ToString();
                reader.Close();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when logging into Database.\nPlease check your username & password" + ex.Message);
                return false;
            }
        }

        public static SqlDataReader ExecSqlDataReader(string cmd)
        {
            var sqlCmd = new SqlCommand(cmd)
            {
                CommandType = CommandType.Text,
                Connection = Connection
            };

            if (Connection.State == ConnectionState.Closed)
                Connection.Open();

            SqlDataReader reader = null;
            try
            {
                reader = sqlCmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                Connection.Close();
                MessageBox.Show(ex.Message);
            }

            return reader;
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormMain = new FormMain();
            Application.Run(FormMain);
        }
    }
}
