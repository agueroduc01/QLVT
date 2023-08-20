namespace QLVT_DATHANG
{
    partial class FormWarehouse
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
            this.barmngr_employee = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_add = new DevExpress.XtraBars.BarButtonItem();
            this.btn_edit = new DevExpress.XtraBars.BarButtonItem();
            this.btn_delete = new DevExpress.XtraBars.BarButtonItem();
            this.btn_save = new DevExpress.XtraBars.BarButtonItem();
            this.btn_undo = new DevExpress.XtraBars.BarButtonItem();
            this.btn_reload = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btn_list = new DevExpress.XtraBars.BarButtonItem();
            this.btn_exit = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gpc_info = new DevExpress.XtraEditors.GroupControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_branchId = new DevExpress.XtraEditors.TextEdit();
            this.bds_Kho = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new QLVT_DATHANG.DS();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_address = new DevExpress.XtraEditors.TextEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_id = new DevExpress.XtraEditors.TextEdit();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_branch = new System.Windows.Forms.ComboBox();
            this.tbla_Kho = new QLVT_DATHANG.DSTableAdapters.KhoTableAdapter();
            this.tableAdapterManager = new QLVT_DATHANG.DSTableAdapters.TableAdapterManager();
            this.tbla_DatHang = new QLVT_DATHANG.DSTableAdapters.DatHangTableAdapter();
            this.tbla_PhieuNhap = new QLVT_DATHANG.DSTableAdapters.PhieuNhapTableAdapter();
            this.tbla_PhieuXuat = new QLVT_DATHANG.DSTableAdapters.PhieuXuatTableAdapter();
            this.gdc_Kho = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaCN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bds_PhieuXuat = new System.Windows.Forms.BindingSource(this.components);
            this.bds_PhieuNhap = new System.Windows.Forms.BindingSource(this.components);
            this.bds_DatHang = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barmngr_employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpc_info)).BeginInit();
            this.gpc_info.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_branchId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_Kho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_address.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdc_Kho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_PhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_PhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_DatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // barmngr_employee
            // 
            this.barmngr_employee.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
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
            this.btn_exit});
            this.barmngr_employee.MainMenu = this.bar2;
            this.barmngr_employee.MaxItemId = 8;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_add),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_edit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_delete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_save, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_undo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_reload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btn_add
            // 
            this.btn_add.Caption = "Thêm";
            this.btn_add.Id = 0;
            this.btn_add.ImageOptions.SvgImage = global::QLVT_DATHANG.Properties.Resources.newproduct;
            this.btn_add.Name = "btn_add";
            this.btn_add.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_add.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_add_ItemClick);
            // 
            // btn_edit
            // 
            this.btn_edit.Caption = "Hiệu chỉnh";
            this.btn_edit.Id = 1;
            this.btn_edit.ImageOptions.SvgImage = global::QLVT_DATHANG.Properties.Resources.bo_price_item;
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barmngr_employee;
            this.barDockControlTop.Size = new System.Drawing.Size(1877, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 559);
            this.barDockControlBottom.Manager = this.barmngr_employee;
            this.barDockControlBottom.Size = new System.Drawing.Size(1877, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barmngr_employee;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 529);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1877, 30);
            this.barDockControlRight.Manager = this.barmngr_employee;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 529);
            // 
            // btn_list
            // 
            this.btn_list.Caption = "Danh sách nhân viên";
            this.btn_list.Id = 6;
            this.btn_list.ImageOptions.SvgImage = global::QLVT_DATHANG.Properties.Resources.customerprofilereport;
            this.btn_list.Name = "btn_list";
            this.btn_list.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btn_exit
            // 
            this.btn_exit.Caption = "Thoát";
            this.btn_exit.Id = 7;
            this.btn_exit.ImageOptions.SvgImage = global::QLVT_DATHANG.Properties.Resources.reviewingpane1;
            this.btn_exit.Name = "btn_exit";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gpc_info);
            this.panelControl1.Controls.Add(this.panel7);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 30);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1877, 176);
            this.panelControl1.TabIndex = 4;
            // 
            // gpc_info
            // 
            this.gpc_info.Controls.Add(this.panel4);
            this.gpc_info.Controls.Add(this.panel3);
            this.gpc_info.Controls.Add(this.panel2);
            this.gpc_info.Controls.Add(this.panel1);
            this.gpc_info.Location = new System.Drawing.Point(5, 51);
            this.gpc_info.Name = "gpc_info";
            this.gpc_info.Size = new System.Drawing.Size(1835, 105);
            this.gpc_info.TabIndex = 15;
            this.gpc_info.Text = "Thông tin Nhà kho";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txt_branchId);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(1350, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(440, 60);
            this.panel4.TabIndex = 4;
            // 
            // txt_branchId
            // 
            this.txt_branchId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_Kho, "MaCN", true));
            this.txt_branchId.Location = new System.Drawing.Point(157, 16);
            this.txt_branchId.MenuManager = this.barmngr_employee;
            this.txt_branchId.Name = "txt_branchId";
            this.txt_branchId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_branchId.Properties.Appearance.Options.UseFont = true;
            this.txt_branchId.Size = new System.Drawing.Size(280, 28);
            this.txt_branchId.TabIndex = 4;
            // 
            // bds_Kho
            // 
            this.bds_Kho.DataMember = "Kho";
            this.bds_Kho.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Chi nhánh";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txt_address);
            this.panel3.Location = new System.Drawing.Point(904, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(440, 60);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa chỉ";
            // 
            // txt_address
            // 
            this.txt_address.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_Kho, "DiaChi", true));
            this.txt_address.Location = new System.Drawing.Point(157, 16);
            this.txt_address.MenuManager = this.barmngr_employee;
            this.txt_address.Name = "txt_address";
            this.txt_address.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Properties.Appearance.Options.UseFont = true;
            this.txt_address.Size = new System.Drawing.Size(280, 28);
            this.txt_address.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_name);
            this.panel2.Location = new System.Drawing.Point(458, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 60);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên kho";
            // 
            // txt_name
            // 
            this.txt_name.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_Kho, "TenKho", true));
            this.txt_name.Location = new System.Drawing.Point(157, 16);
            this.txt_name.MenuManager = this.barmngr_employee;
            this.txt_name.Name = "txt_name";
            this.txt_name.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Properties.Appearance.Options.UseFont = true;
            this.txt_name.Size = new System.Drawing.Size(280, 28);
            this.txt_name.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 60);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(86, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã Kho";
            // 
            // txt_id
            // 
            this.txt_id.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_Kho, "MaKho", true));
            this.txt_id.Location = new System.Drawing.Point(157, 16);
            this.txt_id.MenuManager = this.barmngr_employee;
            this.txt_id.Name = "txt_id";
            this.txt_id.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Properties.Appearance.Options.UseFont = true;
            this.txt_id.Size = new System.Drawing.Size(280, 28);
            this.txt_id.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.cb_branch);
            this.panel7.Location = new System.Drawing.Point(5, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(449, 40);
            this.panel7.TabIndex = 14;
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
            // tbla_Kho
            // 
            this.tbla_Kho.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.tbla_DatHang;
            this.tableAdapterManager.KhoTableAdapter = this.tbla_Kho;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = this.tbla_PhieuNhap;
            this.tableAdapterManager.PhieuXuatTableAdapter = this.tbla_PhieuXuat;
            this.tableAdapterManager.UpdateOrder = QLVT_DATHANG.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VatTuTableAdapter = null;
            // 
            // tbla_DatHang
            // 
            this.tbla_DatHang.ClearBeforeFill = true;
            // 
            // tbla_PhieuNhap
            // 
            this.tbla_PhieuNhap.ClearBeforeFill = true;
            // 
            // tbla_PhieuXuat
            // 
            this.tbla_PhieuXuat.ClearBeforeFill = true;
            // 
            // gdc_Kho
            // 
            this.gdc_Kho.DataSource = this.bds_Kho;
            this.gdc_Kho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdc_Kho.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gdc_Kho.Location = new System.Drawing.Point(0, 206);
            this.gdc_Kho.MainView = this.gridView1;
            this.gdc_Kho.MenuManager = this.barmngr_employee;
            this.gdc_Kho.Name = "gdc_Kho";
            this.gdc_Kho.Size = new System.Drawing.Size(1877, 353);
            this.gdc_Kho.TabIndex = 6;
            this.gdc_Kho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaKho,
            this.colTenKho,
            this.colDiaChi,
            this.colMaCN});
            this.gridView1.GridControl = this.gdc_Kho;
            this.gridView1.Name = "gridView1";
            // 
            // colMaKho
            // 
            this.colMaKho.FieldName = "MaKho";
            this.colMaKho.MinWidth = 25;
            this.colMaKho.Name = "colMaKho";
            this.colMaKho.OptionsColumn.AllowEdit = false;
            this.colMaKho.Visible = true;
            this.colMaKho.VisibleIndex = 0;
            this.colMaKho.Width = 94;
            // 
            // colTenKho
            // 
            this.colTenKho.FieldName = "TenKho";
            this.colTenKho.MinWidth = 25;
            this.colTenKho.Name = "colTenKho";
            this.colTenKho.OptionsColumn.AllowEdit = false;
            this.colTenKho.Visible = true;
            this.colTenKho.VisibleIndex = 1;
            this.colTenKho.Width = 94;
            // 
            // colDiaChi
            // 
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.MinWidth = 25;
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.OptionsColumn.AllowEdit = false;
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 2;
            this.colDiaChi.Width = 94;
            // 
            // colMaCN
            // 
            this.colMaCN.FieldName = "MaCN";
            this.colMaCN.MinWidth = 25;
            this.colMaCN.Name = "colMaCN";
            this.colMaCN.OptionsColumn.AllowEdit = false;
            this.colMaCN.Visible = true;
            this.colMaCN.VisibleIndex = 3;
            this.colMaCN.Width = 94;
            // 
            // bds_PhieuXuat
            // 
            this.bds_PhieuXuat.DataMember = "FK_PhieuXuat_Kho";
            this.bds_PhieuXuat.DataSource = this.bds_Kho;
            // 
            // bds_PhieuNhap
            // 
            this.bds_PhieuNhap.DataMember = "FK_PhieuNhap_Kho";
            this.bds_PhieuNhap.DataSource = this.bds_Kho;
            // 
            // bds_DatHang
            // 
            this.bds_DatHang.DataMember = "FK_DatHang_Kho";
            this.bds_DatHang.DataSource = this.bds_Kho;
            // 
            // FormWarehouse
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1877, 559);
            this.Controls.Add(this.gdc_Kho);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormWarehouse";
            this.Text = "Nhà kho";
            this.Load += new System.EventHandler(this.FormWarehouse2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barmngr_employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gpc_info)).EndInit();
            this.gpc_info.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_branchId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_Kho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_address.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdc_Kho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_PhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_PhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_DatHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barmngr_employee;
        private DevExpress.XtraBars.Bar bar2;
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
        private DevExpress.XtraBars.BarButtonItem btn_list;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_branch;
        private DevExpress.XtraEditors.GroupControl gpc_info;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bds_Kho;
        private DS DS;
        private DSTableAdapters.KhoTableAdapter tbla_Kho;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gdc_Kho;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKho;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKho;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colMaCN;
        private DSTableAdapters.PhieuXuatTableAdapter tbla_PhieuXuat;
        private System.Windows.Forms.BindingSource bds_PhieuXuat;
        private DSTableAdapters.PhieuNhapTableAdapter tbla_PhieuNhap;
        private System.Windows.Forms.BindingSource bds_PhieuNhap;
        private DSTableAdapters.DatHangTableAdapter tbla_DatHang;
        private System.Windows.Forms.BindingSource bds_DatHang;
        private DevExpress.XtraEditors.TextEdit txt_id;
        private DevExpress.XtraEditors.TextEdit txt_branchId;
        private DevExpress.XtraEditors.TextEdit txt_address;
        private DevExpress.XtraEditors.TextEdit txt_name;
    }
}