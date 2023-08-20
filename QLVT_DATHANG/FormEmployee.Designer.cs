namespace QLVT_DATHANG
{
    partial class FormEmployee
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
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barmngr_employee = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btn_list = new DevExpress.XtraBars.BarButtonItem();
            this.btn_add = new DevExpress.XtraBars.BarButtonItem();
            this.btn_edit = new DevExpress.XtraBars.BarButtonItem();
            this.btn_delete = new DevExpress.XtraBars.BarButtonItem();
            this.btn_save = new DevExpress.XtraBars.BarButtonItem();
            this.btn_undo = new DevExpress.XtraBars.BarButtonItem();
            this.btn_reload = new DevExpress.XtraBars.BarButtonItem();
            this.btn_transferBranch = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btn_exit = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pn_newBranch = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_newBranch = new System.Windows.Forms.ComboBox();
            this.gpc_info = new DevExpress.XtraEditors.GroupControl();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txt_address = new DevExpress.XtraEditors.TextEdit();
            this.bds_NhanVien = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new QLVT_DATHANG.DS();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_cmnd = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_firstname = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_lastname = new DevExpress.XtraEditors.TextEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dte_birthday = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.cb_deleted = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_branchId = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_salary = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_branch = new System.Windows.Forms.ComboBox();
            this.tbla_NhanVien = new QLVT_DATHANG.DSTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new QLVT_DATHANG.DSTableAdapters.TableAdapterManager();
            this.gdc_NhanVien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaCN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThaiXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bds_PhieuXuat = new System.Windows.Forms.BindingSource(this.components);
            this.tbla_PhieuXuat = new QLVT_DATHANG.DSTableAdapters.PhieuXuatTableAdapter();
            this.bds_PhieuNhap = new System.Windows.Forms.BindingSource(this.components);
            this.tbla_PhieuNhap = new QLVT_DATHANG.DSTableAdapters.PhieuNhapTableAdapter();
            this.bds_DatHang = new System.Windows.Forms.BindingSource(this.components);
            this.tbla_DatHang = new QLVT_DATHANG.DSTableAdapters.DatHangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barmngr_employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.pn_newBranch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpc_info)).BeginInit();
            this.gpc_info.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_address.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_NhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cmnd.Properties)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_firstname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_lastname.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dte_birthday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_birthday.Properties.CalendarTimeProperties)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_branchId.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_salary.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdc_NhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_PhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_PhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_DatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // barmngr_employee
            // 
            this.barmngr_employee.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barmngr_employee.DockControls.Add(this.barDockControlTop);
            this.barmngr_employee.DockControls.Add(this.barDockControlBottom);
            this.barmngr_employee.DockControls.Add(this.barDockControlLeft);
            this.barmngr_employee.DockControls.Add(this.barDockControlRight);
            this.barmngr_employee.Form = this;
            this.barmngr_employee.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_add,
            this.btn_edit,
            this.btn_delete,
            this.btn_save,
            this.btn_undo,
            this.btn_reload,
            this.btn_list,
            this.btn_exit,
            this.btn_transferBranch});
            this.barmngr_employee.MainMenu = this.bar3;
            this.barmngr_employee.MaxItemId = 9;
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_list, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_add),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_edit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_delete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_save, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_undo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_reload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_transferBranch, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // btn_list
            // 
            this.btn_list.Caption = "Danh sách nhân viên";
            this.btn_list.Id = 6;
            this.btn_list.ImageOptions.SvgImage = global::QLVT_DATHANG.Properties.Resources.customerprofilereport;
            this.btn_list.Name = "btn_list";
            this.btn_list.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_list.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_list_ItemClick);
            // 
            // btn_add
            // 
            this.btn_add.Caption = "Thêm";
            this.btn_add.Id = 0;
            this.btn_add.ImageOptions.SvgImage = global::QLVT_DATHANG.Properties.Resources.newcustomer;
            this.btn_add.Name = "btn_add";
            this.btn_add.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_add.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_add_ItemClick);
            // 
            // btn_edit
            // 
            this.btn_edit.Caption = "Hiệu chỉnh";
            this.btn_edit.Id = 1;
            this.btn_edit.ImageOptions.SvgImage = global::QLVT_DATHANG.Properties.Resources.employees;
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_edit_ItemClick);
            // 
            // btn_delete
            // 
            this.btn_delete.Caption = "Xóa";
            this.btn_delete.Id = 2;
            this.btn_delete.ImageOptions.SvgImage = global::QLVT_DATHANG.Properties.Resources.actions_removecircled;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_delete_ItemClick);
            // 
            // btn_save
            // 
            this.btn_save.Caption = "Lưu";
            this.btn_save.Id = 3;
            this.btn_save.ImageOptions.SvgImage = global::QLVT_DATHANG.Properties.Resources.save;
            this.btn_save.Name = "btn_save";
            this.btn_save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_save_ItemClick);
            // 
            // btn_undo
            // 
            this.btn_undo.Caption = "Phục hồi";
            this.btn_undo.Id = 4;
            this.btn_undo.ImageOptions.SvgImage = global::QLVT_DATHANG.Properties.Resources.backward;
            this.btn_undo.Name = "btn_undo";
            this.btn_undo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_undo_ItemClick);
            // 
            // btn_reload
            // 
            this.btn_reload.Caption = "Reload";
            this.btn_reload.Id = 5;
            this.btn_reload.ImageOptions.SvgImage = global::QLVT_DATHANG.Properties.Resources.actions_refresh;
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_reload_ItemClick);
            // 
            // btn_transferBranch
            // 
            this.btn_transferBranch.Caption = "Chuyển chi nhánh";
            this.btn_transferBranch.Id = 8;
            this.btn_transferBranch.ImageOptions.SvgImage = global::QLVT_DATHANG.Properties.Resources.bo_department;
            this.btn_transferBranch.Name = "btn_transferBranch";
            this.btn_transferBranch.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_transferBranch_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barmngr_employee;
            this.barDockControlTop.Size = new System.Drawing.Size(1938, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 646);
            this.barDockControlBottom.Manager = this.barmngr_employee;
            this.barDockControlBottom.Size = new System.Drawing.Size(1938, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barmngr_employee;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 616);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1938, 30);
            this.barDockControlRight.Manager = this.barmngr_employee;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 616);
            // 
            // btn_exit
            // 
            this.btn_exit.Caption = "Thoát";
            this.btn_exit.Id = 7;
            this.btn_exit.ImageOptions.SvgImage = global::QLVT_DATHANG.Properties.Resources.reviewingpane;
            this.btn_exit.Name = "btn_exit";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.pn_newBranch);
            this.panelControl1.Controls.Add(this.gpc_info);
            this.panelControl1.Controls.Add(this.panel7);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 30);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1938, 254);
            this.panelControl1.TabIndex = 4;
            // 
            // pn_newBranch
            // 
            this.pn_newBranch.Controls.Add(this.label10);
            this.pn_newBranch.Controls.Add(this.cb_newBranch);
            this.pn_newBranch.Location = new System.Drawing.Point(467, 6);
            this.pn_newBranch.Name = "pn_newBranch";
            this.pn_newBranch.Size = new System.Drawing.Size(449, 40);
            this.pn_newBranch.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Location = new System.Drawing.Point(18, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Chi nhánh mới";
            // 
            // cb_newBranch
            // 
            this.cb_newBranch.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_newBranch.FormattingEnabled = true;
            this.cb_newBranch.Location = new System.Drawing.Point(157, 4);
            this.cb_newBranch.Name = "cb_newBranch";
            this.cb_newBranch.Size = new System.Drawing.Size(280, 29);
            this.cb_newBranch.TabIndex = 1;
            // 
            // gpc_info
            // 
            this.gpc_info.Controls.Add(this.panel9);
            this.gpc_info.Controls.Add(this.panel10);
            this.gpc_info.Location = new System.Drawing.Point(12, 52);
            this.gpc_info.Name = "gpc_info";
            this.gpc_info.Size = new System.Drawing.Size(1829, 182);
            this.gpc_info.TabIndex = 14;
            this.gpc_info.Text = "Bảng thông tin";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel8);
            this.panel9.Controls.Add(this.panel6);
            this.panel9.Controls.Add(this.panel4);
            this.panel9.Controls.Add(this.panel2);
            this.panel9.Location = new System.Drawing.Point(5, 106);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1812, 66);
            this.panel9.TabIndex = 13;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txt_address);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Location = new System.Drawing.Point(1341, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(440, 48);
            this.panel8.TabIndex = 8;
            // 
            // txt_address
            // 
            this.txt_address.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_NhanVien, "DiaChi", true));
            this.txt_address.Location = new System.Drawing.Point(157, 10);
            this.txt_address.MenuManager = this.barmngr_employee;
            this.txt_address.Name = "txt_address";
            this.txt_address.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Properties.Appearance.Options.UseFont = true;
            this.txt_address.Size = new System.Drawing.Size(280, 28);
            this.txt_address.TabIndex = 9;
            // 
            // bds_NhanVien
            // 
            this.bds_NhanVien.DataMember = "NhanVien";
            this.bds_NhanVien.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(90, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Địa chỉ";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txt_cmnd);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(449, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(440, 48);
            this.panel6.TabIndex = 6;
            // 
            // txt_cmnd
            // 
            this.txt_cmnd.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_NhanVien, "CMND", true));
            this.txt_cmnd.Location = new System.Drawing.Point(157, 10);
            this.txt_cmnd.MenuManager = this.barmngr_employee;
            this.txt_cmnd.Name = "txt_cmnd";
            this.txt_cmnd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cmnd.Properties.Appearance.Options.UseFont = true;
            this.txt_cmnd.Size = new System.Drawing.Size(280, 28);
            this.txt_cmnd.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(95, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "CMND";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txt_firstname);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txt_lastname);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(440, 48);
            this.panel4.TabIndex = 5;
            // 
            // txt_firstname
            // 
            this.txt_firstname.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_NhanVien, "Ten", true));
            this.txt_firstname.Location = new System.Drawing.Point(337, 10);
            this.txt_firstname.MenuManager = this.barmngr_employee;
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_firstname.Properties.Appearance.Options.UseFont = true;
            this.txt_firstname.Size = new System.Drawing.Size(100, 28);
            this.txt_firstname.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Họ tên";
            // 
            // txt_lastname
            // 
            this.txt_lastname.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_NhanVien, "Ho", true));
            this.txt_lastname.Location = new System.Drawing.Point(157, 10);
            this.txt_lastname.MenuManager = this.barmngr_employee;
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lastname.Properties.Appearance.Options.UseFont = true;
            this.txt_lastname.Size = new System.Drawing.Size(174, 28);
            this.txt_lastname.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dte_birthday);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(895, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 48);
            this.panel2.TabIndex = 7;
            // 
            // dte_birthday
            // 
            this.dte_birthday.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_NhanVien, "NgaySinh", true));
            this.dte_birthday.EditValue = null;
            this.dte_birthday.Location = new System.Drawing.Point(157, 10);
            this.dte_birthday.MenuManager = this.barmngr_employee;
            this.dte_birthday.Name = "dte_birthday";
            this.dte_birthday.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dte_birthday.Properties.Appearance.Options.UseFont = true;
            this.dte_birthday.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dte_birthday.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dte_birthday.Size = new System.Drawing.Size(280, 28);
            this.dte_birthday.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày sinh";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.panel5);
            this.panel10.Controls.Add(this.panel3);
            this.panel10.Controls.Add(this.panel1);
            this.panel10.Location = new System.Drawing.Point(5, 31);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1812, 69);
            this.panel10.TabIndex = 12;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.cb_deleted);
            this.panel11.Controls.Add(this.label8);
            this.panel11.Location = new System.Drawing.Point(1341, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(440, 48);
            this.panel11.TabIndex = 4;
            // 
            // cb_deleted
            // 
            this.cb_deleted.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bds_NhanVien, "TrangThaiXoa", true));
            this.cb_deleted.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_deleted.Location = new System.Drawing.Point(157, 12);
            this.cb_deleted.Name = "cb_deleted";
            this.cb_deleted.Size = new System.Drawing.Size(104, 24);
            this.cb_deleted.TabIndex = 4;
            this.cb_deleted.Text = "Đã xóa";
            this.cb_deleted.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Trạng thái xóa";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txt_branchId);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(449, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(440, 48);
            this.panel5.TabIndex = 2;
            // 
            // txt_branchId
            // 
            this.txt_branchId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_NhanVien, "MaCN", true));
            this.txt_branchId.Location = new System.Drawing.Point(157, 10);
            this.txt_branchId.MenuManager = this.barmngr_employee;
            this.txt_branchId.Name = "txt_branchId";
            this.txt_branchId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_branchId.Properties.Appearance.Options.UseFont = true;
            this.txt_branchId.Size = new System.Drawing.Size(280, 28);
            this.txt_branchId.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Chi nhánh";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_salary);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(895, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(440, 48);
            this.panel3.TabIndex = 3;
            // 
            // txt_salary
            // 
            this.txt_salary.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_NhanVien, "Luong", true));
            this.txt_salary.Location = new System.Drawing.Point(157, 10);
            this.txt_salary.MenuManager = this.barmngr_employee;
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salary.Properties.Appearance.Options.UseFont = true;
            this.txt_salary.Properties.DisplayFormat.FormatString = "n0";
            this.txt_salary.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_salary.Size = new System.Drawing.Size(280, 28);
            this.txt_salary.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lương";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 48);
            this.panel1.TabIndex = 1;
            // 
            // txt_id
            // 
            this.txt_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_NhanVien, "MaNV", true));
            this.txt_id.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(157, 10);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(280, 28);
            this.txt_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Nhân viên";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.cb_branch);
            this.panel7.Location = new System.Drawing.Point(12, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(449, 40);
            this.panel7.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(55, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi nhánh";
            // 
            // cb_branch
            // 
            this.cb_branch.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_branch.FormattingEnabled = true;
            this.cb_branch.Location = new System.Drawing.Point(157, 4);
            this.cb_branch.Name = "cb_branch";
            this.cb_branch.Size = new System.Drawing.Size(280, 29);
            this.cb_branch.TabIndex = 1;
            this.cb_branch.SelectedIndexChanged += new System.EventHandler(this.cb_branch_SelectedIndexChanged);
            // 
            // tbla_NhanVien
            // 
            this.tbla_NhanVien.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.tbla_NhanVien;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_DATHANG.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VatTuTableAdapter = null;
            // 
            // gdc_NhanVien
            // 
            this.gdc_NhanVien.DataSource = this.bds_NhanVien;
            this.gdc_NhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdc_NhanVien.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gdc_NhanVien.Location = new System.Drawing.Point(0, 284);
            this.gdc_NhanVien.MainView = this.gridView1;
            this.gdc_NhanVien.MenuManager = this.barmngr_employee;
            this.gdc_NhanVien.Name = "gdc_NhanVien";
            this.gdc_NhanVien.Size = new System.Drawing.Size(1938, 362);
            this.gdc_NhanVien.TabIndex = 9;
            this.gdc_NhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNV,
            this.colHo,
            this.colTen,
            this.colCMND,
            this.colDiaChi,
            this.colNgaySinh,
            this.colLuong,
            this.colMaCN,
            this.colTrangThaiXoa});
            this.gridView1.GridControl = this.gdc_NhanVien;
            this.gridView1.Name = "gridView1";
            // 
            // colMaNV
            // 
            this.colMaNV.FieldName = "MaNV";
            this.colMaNV.MinWidth = 25;
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.OptionsColumn.AllowEdit = false;
            this.colMaNV.Visible = true;
            this.colMaNV.VisibleIndex = 0;
            this.colMaNV.Width = 94;
            // 
            // colHo
            // 
            this.colHo.FieldName = "Ho";
            this.colHo.MinWidth = 25;
            this.colHo.Name = "colHo";
            this.colHo.OptionsColumn.AllowEdit = false;
            this.colHo.Visible = true;
            this.colHo.VisibleIndex = 1;
            this.colHo.Width = 94;
            // 
            // colTen
            // 
            this.colTen.FieldName = "Ten";
            this.colTen.MinWidth = 25;
            this.colTen.Name = "colTen";
            this.colTen.OptionsColumn.AllowEdit = false;
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 2;
            this.colTen.Width = 94;
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 25;
            this.colCMND.Name = "colCMND";
            this.colCMND.OptionsColumn.AllowEdit = false;
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 3;
            this.colCMND.Width = 94;
            // 
            // colDiaChi
            // 
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.MinWidth = 25;
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.OptionsColumn.AllowEdit = false;
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 4;
            this.colDiaChi.Width = 94;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNgaySinh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgaySinh.FieldName = "NgaySinh";
            this.colNgaySinh.MinWidth = 25;
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.OptionsColumn.AllowEdit = false;
            this.colNgaySinh.Visible = true;
            this.colNgaySinh.VisibleIndex = 5;
            this.colNgaySinh.Width = 94;
            // 
            // colLuong
            // 
            this.colLuong.DisplayFormat.FormatString = "n0";
            this.colLuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colLuong.FieldName = "Luong";
            this.colLuong.MinWidth = 25;
            this.colLuong.Name = "colLuong";
            this.colLuong.OptionsColumn.AllowEdit = false;
            this.colLuong.Visible = true;
            this.colLuong.VisibleIndex = 6;
            this.colLuong.Width = 94;
            // 
            // colMaCN
            // 
            this.colMaCN.DisplayFormat.FormatString = "n0";
            this.colMaCN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMaCN.FieldName = "MaCN";
            this.colMaCN.MinWidth = 25;
            this.colMaCN.Name = "colMaCN";
            this.colMaCN.OptionsColumn.AllowEdit = false;
            this.colMaCN.Visible = true;
            this.colMaCN.VisibleIndex = 7;
            this.colMaCN.Width = 94;
            // 
            // colTrangThaiXoa
            // 
            this.colTrangThaiXoa.FieldName = "TrangThaiXoa";
            this.colTrangThaiXoa.MinWidth = 25;
            this.colTrangThaiXoa.Name = "colTrangThaiXoa";
            this.colTrangThaiXoa.OptionsColumn.AllowEdit = false;
            this.colTrangThaiXoa.Visible = true;
            this.colTrangThaiXoa.VisibleIndex = 8;
            this.colTrangThaiXoa.Width = 94;
            // 
            // bds_PhieuXuat
            // 
            this.bds_PhieuXuat.DataMember = "FK_PX_NhanVien";
            this.bds_PhieuXuat.DataSource = this.bds_NhanVien;
            // 
            // tbla_PhieuXuat
            // 
            this.tbla_PhieuXuat.ClearBeforeFill = true;
            // 
            // bds_PhieuNhap
            // 
            this.bds_PhieuNhap.DataMember = "FK_PhieuNhap_NhanVien";
            this.bds_PhieuNhap.DataSource = this.bds_NhanVien;
            // 
            // tbla_PhieuNhap
            // 
            this.tbla_PhieuNhap.ClearBeforeFill = true;
            // 
            // bds_DatHang
            // 
            this.bds_DatHang.DataMember = "FK_DatHang_NhanVien";
            this.bds_DatHang.DataSource = this.bds_NhanVien;
            // 
            // tbla_DatHang
            // 
            this.tbla_DatHang.ClearBeforeFill = true;
            // 
            // FormEmployee
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1938, 646);
            this.Controls.Add(this.gdc_NhanVien);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEmployee";
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.FormEmployee2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barmngr_employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.pn_newBranch.ResumeLayout(false);
            this.pn_newBranch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpc_info)).EndInit();
            this.gpc_info.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_address.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_NhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cmnd.Properties)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_firstname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_lastname.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dte_birthday.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_birthday.Properties)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_branchId.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_salary.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdc_NhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_PhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_PhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_DatHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarManager barmngr_employee;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btn_list;
        private DevExpress.XtraBars.BarButtonItem btn_add;
        private DevExpress.XtraBars.BarButtonItem btn_edit;
        private DevExpress.XtraBars.BarButtonItem btn_delete;
        private DevExpress.XtraBars.BarButtonItem btn_save;
        private DevExpress.XtraBars.BarButtonItem btn_undo;
        private DevExpress.XtraBars.BarButtonItem btn_reload;
        private DevExpress.XtraBars.BarButtonItem btn_exit;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_branch;
        private DevExpress.XtraEditors.GroupControl gpc_info;
        private System.Windows.Forms.BindingSource bds_NhanVien;
        private DS DS;
        private DSTableAdapters.NhanVienTableAdapter tbla_NhanVien;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gdc_NhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colHo;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colMaCN;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThaiXoa;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id;
        private DevExpress.XtraEditors.TextEdit txt_branchId;
        private DevExpress.XtraEditors.TextEdit txt_firstname;
        private DevExpress.XtraEditors.TextEdit txt_lastname;
        private DevExpress.XtraEditors.TextEdit txt_cmnd;
        private DevExpress.XtraEditors.TextEdit txt_address;
        private DevExpress.XtraEditors.DateEdit dte_birthday;
        private System.Windows.Forms.CheckBox cb_deleted;
        private DevExpress.XtraEditors.TextEdit txt_salary;
        private System.Windows.Forms.BindingSource bds_PhieuXuat;
        private DSTableAdapters.PhieuXuatTableAdapter tbla_PhieuXuat;
        private System.Windows.Forms.BindingSource bds_PhieuNhap;
        private DSTableAdapters.PhieuNhapTableAdapter tbla_PhieuNhap;
        private System.Windows.Forms.BindingSource bds_DatHang;
        private DSTableAdapters.DatHangTableAdapter tbla_DatHang;
        private System.Windows.Forms.Panel pn_newBranch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_newBranch;
        private DevExpress.XtraBars.BarButtonItem btn_transferBranch;
    }
}