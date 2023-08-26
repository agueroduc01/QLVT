using DevExpress.XtraEditors;
using DevExpress.XtraGrid.EditForm.Helpers;
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
    public partial class Frpt_DetailQuantityPriceImEx : DevExpress.XtraEditors.XtraForm
    {
        public Frpt_DetailQuantityPriceImEx()
        {
            InitializeComponent();
        }

        private void Frpt_DetailQuantityPriceImEx_Load(object sender, EventArgs e)
        {
            editFromDate.EditValue = "01-01-2017";
            editToDate.EditValue = "01-01-2018";

            cmb_Loai.SelectedIndex = 1;
        }

        private void btn_Preview_Click(object sender, EventArgs e)
        {
            string vaiTro = Program.Role;
            string loaiPhieu = (cmb_Loai.SelectedItem.ToString() == "NHẬP" ? "N" : "X");

            DateTime fromDate = editFromDate.DateTime;
            DateTime toDate = editToDate.DateTime;
            Xrpt_DetailQuantityPriceImEx rpt = new Xrpt_DetailQuantityPriceImEx(vaiTro, loaiPhieu, fromDate, toDate);
            rpt.lbl_fromDate.Text = fromDate.ToString("dd-MM-yyyy");
            rpt.lbl_toDate.Text = toDate.ToString("dd-MM-yyyy");
            rpt.lbl_title.Text = "BẢNG KÊ CHI TIẾT SỐ LƯỢNG TRỊ GIÁ HÀNG " + (loaiPhieu == "X" ? "XUẤT" : "NHẬP");
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            printTool.ShowPreviewDialog();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            string vaiTro = Program.Role;
            string loaiPhieu = (cmb_Loai.SelectedItem.ToString() == "NHẬP" ? "N" : "X");
            DateTime fromDate = editFromDate.DateTime;
            DateTime toDate = editToDate.DateTime;
            Xrpt_DetailQuantityPriceImEx report = new Xrpt_DetailQuantityPriceImEx(vaiTro, loaiPhieu, fromDate, toDate);
            report.lbl_fromDate.Text = fromDate.ToString("dd-MM-yyyy");
            report.lbl_toDate.Text = toDate.ToString("dd-MM-yyyy");
            report.lbl_title.Text = "BẢNG KÊ CHI TIẾT SỐ LƯỢNG TRỊ GIÁ HÀNG " + (loaiPhieu == "X" ? "XUẤT" : "NHẬP");

            try
            {
                if (File.Exists(@"D:\Xrpt_DetailQuantityPriceImEx.pdf"))
                {
                    DialogResult dr = MessageBox.Show("File Xrpt_DetailQuantityPriceImEx.pdf tại ổ D đã có!\nBạn có muốn tạo lại?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        report.ExportToPdf(@"D:\Xrpt_DetailQuantityPriceImEx.pdf");
                        MessageBox.Show("File Xrpt_DetailQuantityPriceImEx.pdf đã được ghi thành công tại ổ D",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    report.ExportToPdf(@"D:\Xrpt_DetailQuantityPriceImEx.pdf");
                    MessageBox.Show("File Xrpt_DetailQuantityPriceImEx.pdf đã được ghi thành công tại ổ D",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Vui lòng đóng file Xrpt_DetailQuantityPriceImEx.pdf",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}