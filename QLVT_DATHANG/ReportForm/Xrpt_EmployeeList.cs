using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QLVT_DATHANG.ReportForm
{
    public partial class Xrpt_EmployeeList : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_EmployeeList()
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = "XpoProvider=MSSqlServer;" + Program.ConnectionString;
            //this.sqlDataSource1.Fill();
        }

    }
}
