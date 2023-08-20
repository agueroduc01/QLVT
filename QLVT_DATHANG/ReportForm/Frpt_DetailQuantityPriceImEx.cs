using DevExpress.XtraEditors;
using DevExpress.XtraGrid.EditForm.Helpers;
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
    public partial class Frpt_DetailQuantityPriceImEx : DevExpress.XtraEditors.XtraForm
    {
        public Frpt_DetailQuantityPriceImEx()
        {
            InitializeComponent();
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

        private void Frpt_DetailQuantityPriceImEx_Load(object sender, EventArgs e)
        {
            cb_branch.DataSource = Program.bds_subscriptionList;
            cb_branch.DisplayMember = "TenCN";
            cb_branch.ValueMember = "TenServer";
            cb_branch.SelectedIndex = Program.SubsIndex;

            editFromDate.EditValue = "01-01-2017";
            editToDate.EditValue = "01-01-2018";

            cmb_Loai.SelectedIndex = 1;

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

        private void btn_Preview_Click(object sender, EventArgs e)
        {
            string vaiTro = Program.Role;
            string loaiPhieu = (cmb_Loai.SelectedItem.ToString() == "NHẬP" ? "N" : "X");
            MessageBox.Show(loaiPhieu);

            DateTime fromDate = editFromDate.DateTime;
            DateTime toDate = editToDate.DateTime;
            Xrpt_DetailQuantityPriceImEx rpt = new Xrpt_DetailQuantityPriceImEx(vaiTro, loaiPhieu, fromDate, toDate);
            rpt.lbl_fromDate.Text = toDate.ToString("dd-MM-yyyy");
            rpt.lbl_toDate.Text = fromDate.ToString("dd-MM-yyyy");
            rpt.lbl_title.Text = "BẢNG KÊ CHI TIẾT SỐ LƯỢNG TRỊ GIÁ HÀNG " + loaiPhieu;
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            printTool.ShowPreviewDialog();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {

        }
    }
}