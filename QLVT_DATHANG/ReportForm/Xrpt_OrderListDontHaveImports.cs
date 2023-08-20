using DevExpress.XtraEditors.Controls;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QLVT_DATHANG.ReportForm
{
    public partial class Xrpt_OrderListDontHaveImports : DevExpress.XtraReports.UI.XtraReport
    {
        string tempConnectionString = Program.ConnectionString;
        public Xrpt_OrderListDontHaveImports()
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = "XpoProvider=MSSqlServer;" + Program.ConnectionString;
            this.sqlDataSource1.ConnectionName = "QLVT_DATHANG.Properties.Settings.QLVT_DATHANGConnectionString";
        }

        public void FormClosedEventHandler(object sender, EventArgs e)
        {
            MessageBox.Show(tempConnectionString);
            this.sqlDataSource1.Connection.ConnectionString = tempConnectionString;
        }
    }
}
