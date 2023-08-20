using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QLVT_DATHANG.ReportForm
{
    public partial class Xrpt_DetailQuantityPriceImEx : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_DetailQuantityPriceImEx(String vaiTro, String loaiPhieu, DateTime fromDate, DateTime toDate)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = "XpoProvider=MSSqlServer;" + Program.ConnectionString;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = vaiTro;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = loaiPhieu;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = fromDate;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = toDate;
            this.sqlDataSource1.Fill();
        }

    }
}
