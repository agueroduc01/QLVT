using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT_DATHANG.ReportForm
{
    public partial class Xrpt_ProductList : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_ProductList()
        {
            InitializeComponent();
            //this.sqlDataSource1.Connection.ConnectionString = "XpoProvider=MSSqlServer;" + Program.ConnectionString;
        }

    }
}
