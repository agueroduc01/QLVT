using QLVT_DATHANG.ReportForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLVT_DATHANG
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }
        // 1. Load Form
        private Form CheckExists(Type formType)
        {
            foreach (var form in this.MdiChildren)
            {
                if (form.GetType() == formType) 
                    return form;
            }
            return null;
        }

        private void LoadLoginForm()
        {
            var form = CheckExists(typeof(FormLogin));
            if (form != null)
                form.Activate();
            else
            {
                var fLogin = new FormLogin();
                fLogin.MdiParent = this;
                WindowState = FormWindowState.Normal;
                Dock = DockStyle.Fill;
                fLogin.Show();
            }
        }

        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadLoginForm();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadLoginForm();
            
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            var formMain = Program.FormMain;
            formMain.page_business.Visible = 
                formMain.page_cat.Visible = 
                formMain.page_report.Visible = false;

            formMain.btn_logout.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInCustomizing;
            formMain.btn_login.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInRuntime;

            WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;

            foreach (var item in formMain.MdiChildren)
            {
                item.Close();
            }

            LoadLoginForm();
        }

        private void LoadEmployeeForm()
        {
            var form = CheckExists(typeof(FormEmployee));
            if (form != null)
                form.Activate();
            else
            {
                foreach (var item in MdiChildren)
                {
                    item.Close();
                }
                var fEmployee = new FormEmployee();
                fEmployee.MdiParent = this;
                fEmployee.Show();
            }
        }

        private void LoadProductForm()
        {
            var form = CheckExists(typeof(FormProduct));
            if (form != null)
                form.Activate();
            else
            {
                foreach (var item in MdiChildren)
                {
                    item.Close();
                }
                var fProduct = new FormProduct();
                fProduct.MdiParent = this;
                fProduct.Show();
            }

        }

        private void LoadWarehouseForm()
        {
            var form = CheckExists(typeof(FormWarehouse));
            if (form != null)
                form.Activate();
            else
            {
                foreach (var item in MdiChildren)
                {
                    item.Close();
                }
                var fProduct = new FormWarehouse();
                fProduct.MdiParent = this;
                fProduct.Show();
            }
        }

        private void LoadImReceiptForm()
        {
            var form = CheckExists(typeof(FormImReceipt));
            if (form != null)
                form.Activate();
            else
            {
                foreach (var item in MdiChildren)
                {
                    item.Close();
                }
                var fProduct = new FormImReceipt();
                fProduct.MdiParent = this;
                fProduct.Show();
            }
        }

        private void LoadExReceiptForm()
        {
            var form = CheckExists(typeof(FormExReceipt));
            if (form != null)
                form.Activate();
            else
            {
                foreach (var item in MdiChildren)
                {
                    item.Close();
                }
                var fProduct = new FormExReceipt();
                fProduct.MdiParent = this;
                fProduct.Show();
            }
        }

        private void LoadOrderForm()
        {
            var form = CheckExists(typeof(FormOrder));
            if (form != null)
                form.Activate();
            else
            {
                foreach (var item in MdiChildren)
                {
                    item.Close();
                }
                var fProduct = new FormOrder();
                fProduct.MdiParent = this;
                fProduct.Show();
            }
        }

        private void LoadFprt_DetailQuantityPriceImEx()
        {
            var form = CheckExists(typeof(Frpt_DetailQuantityPriceImEx));
            if (form != null)
                form.Activate();
            else
            {
                foreach (var item in MdiChildren)
                {
                    item.Close();
                }
                var frptDetailQuantityPriceImEx = new Frpt_DetailQuantityPriceImEx();
                frptDetailQuantityPriceImEx.MdiParent = this;
                frptDetailQuantityPriceImEx.Show();
            }
        }

        private void LoadFprt_EmployeeActivities()
        {
            var form = CheckExists(typeof(Frpt_EmployeeActivities));
            if (form != null)
                form.Activate();
            else
            {
                foreach (var item in MdiChildren)
                {
                    item.Close();
                }
                var frptEmployeeActivities = new Frpt_EmployeeActivities();
                frptEmployeeActivities.MdiParent = this;
                frptEmployeeActivities.Show();
            }
        }

        private void btn_employee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadEmployeeForm();
        }

        private void btn_product_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadProductForm();
        }

        private void btn_warehouse_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadWarehouseForm();
        }

        private void btn_invoice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadImReceiptForm();
        }

        private void btn_order_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadOrderForm();
        }

        private void btn_exReceipt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadExReceiptForm();
        }

        private void btn_EmployeeActivities_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadFprt_EmployeeActivities();
        }

        private void btn_DetailQuantityImEx_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadFprt_DetailQuantityPriceImEx();
        }
    }
}
