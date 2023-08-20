namespace QLVT_DATHANG
{
    partial class FormProduct
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
            this.gpc_info = new DevExpress.XtraEditors.GroupControl();
            this.panel11 = new System.Windows.Forms.Panel();
            this.spe_count = new DevExpress.XtraEditors.SpinEdit();
            this.bds_VatTu = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new QLVT_DATHANG.DS();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new DevExpress.XtraEditors.TextEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_unit = new DevExpress.XtraEditors.TextEdit();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_name = new DevExpress.XtraEditors.TextEdit();
            this.tbla_VatTu = new QLVT_DATHANG.DSTableAdapters.VatTuTableAdapter();
            this.tableAdapterManager = new QLVT_DATHANG.DSTableAdapters.TableAdapterManager();
            this.tbla_CTDDH = new QLVT_DATHANG.DSTableAdapters.CTDDHTableAdapter();
            this.tbla_CTPN = new QLVT_DATHANG.DSTableAdapters.CTPNTableAdapter();
            this.tbla_CTPX = new QLVT_DATHANG.DSTableAdapters.CTPXTableAdapter();
            this.gdc_VatTu = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuongTon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bds_CTPX = new System.Windows.Forms.BindingSource(this.components);
            this.bds_CTPN = new System.Windows.Forms.BindingSource(this.components);
            this.bds_CTDDH = new System.Windows.Forms.BindingSource(this.components);
            this.btn_ProdList = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barmngr_employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpc_info)).BeginInit();
            this.gpc_info.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spe_count.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_VatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_unit.Properties)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdc_VatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_CTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_CTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_CTDDH)).BeginInit();
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
            this.btn_exit,
            this.btn_ProdList});
            this.barmngr_employee.MainMenu = this.bar2;
            this.barmngr_employee.MaxItemId = 9;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_reload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_ProdList)});
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
            this.barDockControlTop.Size = new System.Drawing.Size(1940, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 656);
            this.barDockControlBottom.Manager = this.barmngr_employee;
            this.barDockControlBottom.Size = new System.Drawing.Size(1940, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barmngr_employee;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 626);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1940, 30);
            this.barDockControlRight.Manager = this.barmngr_employee;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 626);
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
            // gpc_info
            // 
            this.gpc_info.Controls.Add(this.panel11);
            this.gpc_info.Controls.Add(this.panel1);
            this.gpc_info.Controls.Add(this.panel3);
            this.gpc_info.Controls.Add(this.panel5);
            this.gpc_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpc_info.Enabled = false;
            this.gpc_info.Location = new System.Drawing.Point(0, 30);
            this.gpc_info.Name = "gpc_info";
            this.gpc_info.Size = new System.Drawing.Size(1940, 92);
            this.gpc_info.TabIndex = 14;
            this.gpc_info.Text = "Thông tin Vật tư";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.spe_count);
            this.panel11.Controls.Add(this.label8);
            this.panel11.Location = new System.Drawing.Point(1348, 34);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(440, 48);
            this.panel11.TabIndex = 4;
            // 
            // spe_count
            // 
            this.spe_count.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_VatTu, "SoLuongTon", true));
            this.spe_count.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spe_count.Location = new System.Drawing.Point(157, 10);
            this.spe_count.MenuManager = this.barmngr_employee;
            this.spe_count.Name = "spe_count";
            this.spe_count.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spe_count.Properties.Appearance.Options.UseFont = true;
            this.spe_count.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spe_count.Properties.DisplayFormat.FormatString = "n0";
            this.spe_count.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spe_count.Size = new System.Drawing.Size(280, 28);
            this.spe_count.TabIndex = 4;
            // 
            // bds_VatTu
            // 
            this.bds_VatTu.DataMember = "VatTu";
            this.bds_VatTu.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số lượng tồn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Location = new System.Drawing.Point(10, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 48);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Vật tư";
            // 
            // txt_id
            // 
            this.txt_id.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_VatTu, "MaVT", true));
            this.txt_id.Location = new System.Drawing.Point(157, 10);
            this.txt_id.MenuManager = this.barmngr_employee;
            this.txt_id.Name = "txt_id";
            this.txt_id.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Properties.Appearance.Options.UseFont = true;
            this.txt_id.Size = new System.Drawing.Size(280, 28);
            this.txt_id.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txt_unit);
            this.panel3.Location = new System.Drawing.Point(902, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(440, 48);
            this.panel3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đơn vị tính";
            // 
            // txt_unit
            // 
            this.txt_unit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_VatTu, "DVT", true));
            this.txt_unit.Location = new System.Drawing.Point(157, 10);
            this.txt_unit.MenuManager = this.barmngr_employee;
            this.txt_unit.Name = "txt_unit";
            this.txt_unit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_unit.Properties.Appearance.Options.UseFont = true;
            this.txt_unit.Size = new System.Drawing.Size(280, 28);
            this.txt_unit.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.txt_name);
            this.panel5.Location = new System.Drawing.Point(456, 34);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(440, 48);
            this.panel5.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên Vật tư";
            // 
            // txt_name
            // 
            this.txt_name.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_VatTu, "TenVT", true));
            this.txt_name.Location = new System.Drawing.Point(157, 10);
            this.txt_name.MenuManager = this.barmngr_employee;
            this.txt_name.Name = "txt_name";
            this.txt_name.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Properties.Appearance.Options.UseFont = true;
            this.txt_name.Size = new System.Drawing.Size(280, 28);
            this.txt_name.TabIndex = 2;
            // 
            // tbla_VatTu
            // 
            this.tbla_VatTu.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = this.tbla_CTDDH;
            this.tableAdapterManager.CTPNTableAdapter = this.tbla_CTPN;
            this.tableAdapterManager.CTPXTableAdapter = this.tbla_CTPX;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_DATHANG.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VatTuTableAdapter = this.tbla_VatTu;
            // 
            // tbla_CTDDH
            // 
            this.tbla_CTDDH.ClearBeforeFill = true;
            // 
            // tbla_CTPN
            // 
            this.tbla_CTPN.ClearBeforeFill = true;
            // 
            // tbla_CTPX
            // 
            this.tbla_CTPX.ClearBeforeFill = true;
            // 
            // gdc_VatTu
            // 
            this.gdc_VatTu.DataSource = this.bds_VatTu;
            this.gdc_VatTu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdc_VatTu.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gdc_VatTu.Location = new System.Drawing.Point(0, 122);
            this.gdc_VatTu.MainView = this.gridView1;
            this.gdc_VatTu.MenuManager = this.barmngr_employee;
            this.gdc_VatTu.Name = "gdc_VatTu";
            this.gdc_VatTu.Size = new System.Drawing.Size(1940, 534);
            this.gdc_VatTu.TabIndex = 15;
            this.gdc_VatTu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaVT,
            this.colTenVT,
            this.colDVT,
            this.colSoLuongTon});
            this.gridView1.GridControl = this.gdc_VatTu;
            this.gridView1.Name = "gridView1";
            // 
            // colMaVT
            // 
            this.colMaVT.FieldName = "MaVT";
            this.colMaVT.MinWidth = 25;
            this.colMaVT.Name = "colMaVT";
            this.colMaVT.OptionsColumn.AllowEdit = false;
            this.colMaVT.Visible = true;
            this.colMaVT.VisibleIndex = 0;
            this.colMaVT.Width = 94;
            // 
            // colTenVT
            // 
            this.colTenVT.FieldName = "TenVT";
            this.colTenVT.MinWidth = 25;
            this.colTenVT.Name = "colTenVT";
            this.colTenVT.OptionsColumn.AllowEdit = false;
            this.colTenVT.Visible = true;
            this.colTenVT.VisibleIndex = 1;
            this.colTenVT.Width = 94;
            // 
            // colDVT
            // 
            this.colDVT.FieldName = "DVT";
            this.colDVT.MinWidth = 25;
            this.colDVT.Name = "colDVT";
            this.colDVT.OptionsColumn.AllowEdit = false;
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 2;
            this.colDVT.Width = 94;
            // 
            // colSoLuongTon
            // 
            this.colSoLuongTon.FieldName = "SoLuongTon";
            this.colSoLuongTon.MinWidth = 25;
            this.colSoLuongTon.Name = "colSoLuongTon";
            this.colSoLuongTon.OptionsColumn.AllowEdit = false;
            this.colSoLuongTon.Visible = true;
            this.colSoLuongTon.VisibleIndex = 3;
            this.colSoLuongTon.Width = 94;
            // 
            // bds_CTPX
            // 
            this.bds_CTPX.DataMember = "FK_CTPX_VatTu";
            this.bds_CTPX.DataSource = this.bds_VatTu;
            // 
            // bds_CTPN
            // 
            this.bds_CTPN.DataMember = "FK_CTPN_VatTu";
            this.bds_CTPN.DataSource = this.bds_VatTu;
            // 
            // bds_CTDDH
            // 
            this.bds_CTDDH.DataMember = "FK_CTDDH_VatTu";
            this.bds_CTDDH.DataSource = this.bds_VatTu;
            // 
            // btn_ProdList
            // 
            this.btn_ProdList.Caption = "Danh sách vật tư";
            this.btn_ProdList.Id = 8;
            this.btn_ProdList.Name = "btn_ProdList";
            this.btn_ProdList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ProdList_ItemClick);
            // 
            // FormProduct
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1940, 656);
            this.Controls.Add(this.gdc_VatTu);
            this.Controls.Add(this.gpc_info);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormProduct";
            this.Text = "Vật tư";
            this.Load += new System.EventHandler(this.FormProduct2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barmngr_employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpc_info)).EndInit();
            this.gpc_info.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spe_count.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_VatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_unit.Properties)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdc_VatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_CTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_CTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_CTDDH)).EndInit();
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
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btn_list;
        private DevExpress.XtraBars.BarButtonItem btn_exit;
        private DevExpress.XtraEditors.GroupControl gpc_info;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource bds_VatTu;
        private DS DS;
        private DSTableAdapters.VatTuTableAdapter tbla_VatTu;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gdc_VatTu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTenVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuongTon;
        private DevExpress.XtraEditors.SpinEdit spe_count;
        private DevExpress.XtraEditors.TextEdit txt_id;
        private DevExpress.XtraEditors.TextEdit txt_unit;
        private DevExpress.XtraEditors.TextEdit txt_name;
        private DSTableAdapters.CTPXTableAdapter tbla_CTPX;
        private System.Windows.Forms.BindingSource bds_CTPX;
        private DSTableAdapters.CTPNTableAdapter tbla_CTPN;
        private System.Windows.Forms.BindingSource bds_CTPN;
        private DSTableAdapters.CTDDHTableAdapter tbla_CTDDH;
        private System.Windows.Forms.BindingSource bds_CTDDH;
        private DevExpress.XtraBars.BarButtonItem btn_ProdList;
    }
}