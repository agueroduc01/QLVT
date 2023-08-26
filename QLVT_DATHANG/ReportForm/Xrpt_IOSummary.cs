using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT_DATHANG.ReportForm
{
    public partial class Xrpt_IOSummary : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_IOSummary(DateTime fromDate, DateTime toDate)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = "XpoProvider=MSSqlServer;" + Program.ConnectionString;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = fromDate;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = toDate;
            this.sqlDataSource1.Fill();
        }

    }
}
