namespace QLVT_DATHANG
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_login = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonGalleryBarItem1 = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.btn_create_login = new DevExpress.XtraBars.BarButtonItem();
            this.btn_logout = new DevExpress.XtraBars.BarButtonItem();
            this.btn_employee = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_EmployeeActivities = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DetailQuantityImEx = new DevExpress.XtraBars.BarButtonItem();
            this.btn_product = new DevExpress.XtraBars.BarButtonItem();
            this.btn_warehouse = new DevExpress.XtraBars.BarButtonItem();
            this.btn_order = new DevExpress.XtraBars.BarButtonItem();
            this.btn_imReceipt = new DevExpress.XtraBars.BarButtonItem();
            this.btn_exReceipt = new DevExpress.XtraBars.BarButtonItem();
            this.page_cat = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.page_business = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.page_report = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.page_system = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MaNV = new System.Windows.Forms.ToolStripStatusLabel();
            this.HoTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.Nhom = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(55);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btn_login,
            this.ribbonGalleryBarItem1,
            this.btn_create_login,
            this.btn_logout,
            this.btn_employee,
            this.barButtonItem5,
            this.btn_EmployeeActivities,
            this.barButtonItem7,
            this.btn_DetailQuantityImEx,
            this.btn_product,
            this.btn_warehouse,
            this.btn_order,
            this.btn_imReceipt,
            this.btn_exReceipt});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(6);
            this.ribbonControl1.MaxItemId = 15;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 605;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.page_cat,
            this.page_business,
            this.page_report,
            this.page_system});
            this.ribbonControl1.Size = new System.Drawing.Size(798, 193);
            // 
            // btn_login
            // 
            this.btn_login.Caption = "Đăng nhập";
            this.btn_login.Id = 1;
            this.btn_login.ImageOptions.SvgImage = global::QLVT_DATHANG.Properties.Resources.security_key;
            this.btn_login.Name = "btn_login";
            this.btn_login.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInRuntime;
            this.btn_login.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogin_ItemClick);
            // 
            // ribbonGalleryBarItem1
            // 
            this.ribbonGalleryBarItem1.Caption = "ribbonGalleryBarItem1";
            this.ribbonGalleryBarItem1.Id = 2;
            this.ribbonGalleryBarItem1.Name = "ribbonGalleryBarItem1";
            // 
            // btn_create_login
            // 
            this.btn_create_login.Caption = "Tạo tài khoản";
            this.btn_create_login.Id = 3;
            this.btn_create_login.ImageOptions.SvgImage = global::QLVT_DATHANG.Properties.Resources.actions_addcircled;
            this.btn_create_login.Name = "btn_create_login";
            this.btn_create_login.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInCustomizing;
            // 
            // btn_logout
            // 
            this.btn_logout.Caption = "Đăng xuất";
            this.btn_logout.Id = 4;
            this.btn_logout.ImageOptions.SvgImage = global::QLVT_DATHANG.Properties.Resources.security_warningcircled2;
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInCustomizing;
            this.btn_logout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // btn_employee
            // 
            this.btn_employee.Caption = "Nhân viên";
            this.btn_employee.Id = 5;
            this.btn_employee.ImageOptions.SvgImage = global::QLVT_DATHANG.Properties.Resources.bo_lead;
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_employee_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Lập phiếu nhập / xuất";
            this.barButtonItem5.Id = 6;
            this.barButtonItem5.ImageOptions.SvgImage = global::QLVT_DATHANG.Properties.Resources.addfile;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // btn_EmployeeActivities
            // 
            this.btn_EmployeeActivities.Caption = "Hoạt động nhân viên";
            this.btn_EmployeeActivities.Id = 7;
            this.btn_EmployeeActivities.ImageOptions.SvgImage = global::QLVT_DATHANG.Properties.Resources.employeesummary;
            this.btn_EmployeeActivities.Name = "btn_EmployeeActivities";
            this.btn_EmployeeActivities.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_EmployeeActivities_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Phiếu nhân viên lập trong năm";
            this.barButtonItem7.Id = 8;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // btn_DetailQuantityImEx
            // 
            this.btn_DetailQuantityImEx.Caption = "Bảng kê chi tiết số lượng trị giá nhập xuất";
            this.btn_DetailQuantityImEx.Id = 9;
            this.btn_DetailQuantityImEx.ImageOptions.SvgImage = global::QLVT_DATHANG.Properties.Resources.printallpages;
            this.btn_DetailQuantityImEx.Name = "btn_DetailQuantityImEx";
            this.btn_DetailQuantityImEx.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DetailQuantityImEx_ItemClick);
            // 
            // btn_product
            // 
            this.btn_product.Caption = "Vật tư";
            this.btn_product.Id = 10;
            this.btn_product.ImageOptions.SvgImage = global::QLVT_DATHANG.Properties.Resources.bo_product;
            this.btn_product.Name = "btn_product";
            this.btn_product.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_product_ItemClick);
            // 
            // btn_warehouse
            // 
            this.btn_warehouse.Caption = "Kho";
            this.btn_warehouse.Id = 11;
            this.btn_warehouse.ImageOptions.SvgImage = global::QLVT_DATHANG.Properties.Resources.bo_order;
            this.btn_warehouse.Name = "btn_warehouse";
            this.btn_warehouse.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_warehouse_ItemClick);
            // 
            // btn_order
            // 
            this.btn_order.Caption = "Đơn đặt hàng";
            this.btn_order.Id = 12;
            this.btn_order.ImageOptions.SvgImage = global::QLVT_DATHANG.Properties.Resources.shipment;
            this.btn_order.Name = "btn_order";
            this.btn_order.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_order_ItemClick);
            // 
            // btn_imReceipt
            // 
            this.btn_imReceipt.Caption = "Phiếu nhập";
            this.btn_imReceipt.Id = 13;
            this.btn_imReceipt.ImageOptions.SvgImage = global::QLVT_DATHANG.Properties.Resources.employeetasklist;
            this.btn_imReceipt.Name = "btn_imReceipt";
            this.btn_imReceipt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_invoice_ItemClick);
            // 
            // btn_exReceipt
            // 
            this.btn_exReceipt.Caption = "Phiếu xuất";
            this.btn_exReceipt.Id = 14;
            this.btn_exReceipt.ImageOptions.SvgImage = global::QLVT_DATHANG.Properties.Resources.portrait;
            this.btn_exReceipt.Name = "btn_exReceipt";
            this.btn_exReceipt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_exReceipt_ItemClick);
            // 
            // page_cat
            // 
            this.page_cat.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.page_cat.Name = "page_cat";
            this.page_cat.Text = "Danh mục";
            this.page_cat.Visible = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_employee);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_product);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_warehouse);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_order);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_imReceipt);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_exReceipt);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // page_business
            // 
            this.page_business.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.page_business.Name = "page_business";
            this.page_business.Text = "Nghiệp vụ";
            this.page_business.Visible = false;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // page_report
            // 
            this.page_report.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.page_report.Name = "page_report";
            this.page_report.Text = "Báo cáo";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_EmployeeActivities);
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_DetailQuantityImEx);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // page_system
            // 
            this.page_system.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.page_system.Name = "page_system";
            this.page_system.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_login);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_create_login);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_logout);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MaNV,
            this.HoTen,
            this.Nhom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 733);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(798, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MaNV
            // 
            this.MaNV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaNV.Name = "MaNV";
            this.MaNV.Size = new System.Drawing.Size(50, 20);
            this.MaNV.Text = "MaNV";
            // 
            // HoTen
            // 
            this.HoTen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoTen.Name = "HoTen";
            this.HoTen.Size = new System.Drawing.Size(52, 20);
            this.HoTen.Text = "HoTen";
            // 
            // Nhom
            // 
            this.Nhom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nhom.Name = "Nhom";
            this.Nhom.Size = new System.Drawing.Size(50, 20);
            this.Nhom.Text = "Nhom";
            // 
            // FormMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(798, 759);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Quản lý vật tư";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.RibbonGalleryBarItem ribbonGalleryBarItem1;
        private DevExpress.XtraBars.BarButtonItem btn_employee;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem btn_EmployeeActivities;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem btn_DetailQuantityImEx;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel MaNV;
        public System.Windows.Forms.ToolStripStatusLabel HoTen;
        public System.Windows.Forms.ToolStripStatusLabel Nhom;
        public DevExpress.XtraBars.BarButtonItem btn_login;
        public DevExpress.XtraBars.BarButtonItem btn_create_login;
        public DevExpress.XtraBars.BarButtonItem btn_logout;
        public DevExpress.XtraBars.Ribbon.RibbonPage page_system;
        public DevExpress.XtraBars.Ribbon.RibbonPage page_cat;
        public DevExpress.XtraBars.Ribbon.RibbonPage page_business;
        public DevExpress.XtraBars.Ribbon.RibbonPage page_report;
        private DevExpress.XtraBars.BarButtonItem btn_product;
        private DevExpress.XtraBars.BarButtonItem btn_warehouse;
        private DevExpress.XtraBars.BarButtonItem btn_order;
        private DevExpress.XtraBars.BarButtonItem btn_imReceipt;
        private DevExpress.XtraBars.BarButtonItem btn_exReceipt;
    }
}

