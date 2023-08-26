using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT_DATHANG.ReportForm
{
    public partial class Frpt_IOSummary : DevExpress.XtraEditors.XtraForm
    {
        public Frpt_IOSummary()
        {
            InitializeComponent();
        }

        private void Frpt_IOSummary_Load(object sender, EventArgs e)
        {
            editFromDate.EditValue = "01-01-2017";
            editToDate.EditValue = "01-01-2018";
        }

        private void btn_Preview_Click(object sender, EventArgs e)
        {
            DateTime fromDate = editFromDate.DateTime;
            DateTime toDate = editToDate.DateTime;
            Xrpt_IOSummary rpt = new Xrpt_IOSummary(fromDate, toDate);
            rpt.lblDate.Text = fromDate.ToString("dd-MM-yyyy") + " ĐẾN " + toDate.ToString("dd-MM-yyyy");
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            printTool.ShowPreviewDialog();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            DateTime fromDate = editFromDate.DateTime;
            DateTime toDate = editToDate.DateTime;
            Xrpt_IOSummary report = new Xrpt_IOSummary(fromDate, toDate);
            report.lblDate.Text = fromDate.ToString("dd-MM-yyyy") + " ĐẾN " + toDate.ToString("dd-MM-yyyy");

            try
            {
                if (File.Exists(@"D:\Xrpt_IOSummary.pdf"))
                {
                    DialogResult dr = MessageBox.Show("File Xrpt_IOSummary.pdf tại ổ D đã có!\nBạn có muốn tạo lại?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        report.ExportToPdf(@"D:\Xrpt_IOSummary.pdf");
                        MessageBox.Show("File ReportDSNhanVien.pdf đã được ghi thành công tại ổ D",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    report.ExportToPdf(@"D:\Xrpt_IOSummary.pdf");
                    MessageBox.Show("File Xrpt_IOSummary.pdf đã được ghi thành công tại ổ D",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Vui lòng đóng file Xrpt_IOSummary.pdf",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}