using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT_DATHANG.ReportForm
{
    public partial class Frpt_EmployeeActivities : DevExpress.XtraEditors.XtraForm
    {
        public Frpt_EmployeeActivities()
        {
            InitializeComponent();
        }

        private void Frpt_EmployeeActivities_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.SP_HotenMaNV' table. You can move, or remove it, as needed.
            this.sP_HotenMaNVTableAdapter.Connection.ConnectionString = Program.ConnectionString;
            this.sP_HotenMaNVTableAdapter.Fill(this.dS.SP_HotenMaNV);

            cb_branch.DataSource = Program.bds_subscriptionList;
            cb_branch.DisplayMember = "TenCN";
            cb_branch.ValueMember = "TenServer";
            cb_branch.SelectedIndex = Program.SubsIndex;

            editFromDate.EditValue = "01-01-2017";
            editToDate.EditValue = "01-01-2018";

            cmb_HotenNV.SelectedIndex = 0;
            txt_maNV.Text = cmb_HotenNV.SelectedValue.ToString();

            // 5. Decentralization
            if (Program.Role == "CongTy")
            {
                cb_branch.Enabled = true;
            }
            else
            {
                cb_branch.Enabled = false;
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
        }

        private void btn_Preview_Click(object sender, EventArgs e)
        {
            string hoTenNV = cmb_HotenNV.SelectedValue.ToString();

            DateTime fromDate = editFromDate.DateTime;
            DateTime toDate = editToDate.DateTime;
            DateTime createReportDate = DateTime.Now;
            Xrpt_EmployeeActivities rpt = new Xrpt_EmployeeActivities(hoTenNV, createReportDate, fromDate, toDate);
            //rpt.lbl_fromDate.Text = toDate.ToString("dd-MM-yyyy");
            //rpt.lbl_toDate.Text = fromDate.ToString("dd-MM-yyyy");
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            printTool.ShowPreviewDialog();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {

        }

        private void cmb_HotenNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_HotenNV.SelectedValue != null)
                {
                    txt_maNV.Text = cmb_HotenNV.SelectedValue.ToString();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}