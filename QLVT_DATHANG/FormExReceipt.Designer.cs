﻿namespace QLVT_DATHANG
{
    partial class FormExReceipt
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
            this.bar3 = new DevExpress.XtraBars.Bar();
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
            this.DS = new QLVT_DATHANG.DS();
            this.bds_PhieuXuat = new System.Windows.Forms.BindingSource(this.components);
            this.tbla_PhieuXuat = new QLVT_DATHANG.DSTableAdapters.PhieuXuatTableAdapter();
            this.tableAdapterManager = new QLVT_DATHANG.DSTableAdapters.TableAdapterManager();
            this.tbla_CTPX = new QLVT_DATHANG.DSTableAdapters.CTPXTableAdapter();
            this.tbla_Kho = new QLVT_DATHANG.DSTableAdapters.KhoTableAdapter();
            this.gdc_PhieuXuat = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaPX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTenKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gdv_CTPX = new System.Windows.Forms.DataGridView();
            this.colCTPXMaPX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCTPXVT = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bds_VatTu = new System.Windows.Forms.BindingSource(this.components);
            this.colCTPXSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCTPXDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cms_CTPX = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ms_save = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_cancel = new System.Windows.Forms.ToolStripMenuItem();
            this.bds_CTPX = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_branch = new System.Windows.Forms.ComboBox();
            this.gpc_info = new DevExpress.XtraEditors.GroupControl();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cusName = new DevExpress.XtraEditors.TextEdit();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cbb_whsname = new System.Windows.Forms.ComboBox();
            this.bds_Kho = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txt_whsId = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_eeId = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dte_date = new DevExpress.XtraEditors.DateEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbb_fullname = new System.Windows.Forms.ComboBox();
            this.bds_DSNV = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_exportId = new DevExpress.XtraEditors.TextEdit();
            this.tbla_DSNV = new QLVT_DATHANG.DSTableAdapters.DS_NVTableAdapter();
            this.tbla_VatTu = new QLVT_DATHANG.DSTableAdapters.VatTuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barmngr_employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_PhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdc_PhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_CTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_VatTu)).BeginInit();
            this.cms_CTPX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_CTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpc_info)).BeginInit();
            this.gpc_info.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cusName.Properties)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_Kho)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_whsId.Properties)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_eeId.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dte_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_date.Properties.CalendarTimeProperties)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_DSNV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_exportId.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.btn_exit});
            this.barmngr_employee.MainMenu = this.bar3;
            this.barmngr_employee.MaxItemId = 8;
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_add),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_edit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_delete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_save, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_undo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_reload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // btn_add
            // 
            this.btn_add.Caption = "Thêm";
            this.btn_add.Id = 0;
            this.btn_add.ImageOptions.SvgImage = global::QLVT_DATHANG.Properties.Resources.addparagraphtotableofcontents;
            this.btn_add.Name = "btn_add";
            this.btn_add.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_add.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_add_ItemClick);
            // 
            // btn_edit
            // 
            this.btn_edit.Caption = "Hiệu chỉnh";
            this.btn_edit.Id = 1;
            this.btn_edit.ImageOptions.SvgImage = global::QLVT_DATHANG.Properties.Resources.bo_contract;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1938, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 935);
            this.barDockControlBottom.Manager = this.barmngr_employee;
            this.barDockControlBottom.Size = new System.Drawing.Size(1938, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barmngr_employee;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 905);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1938, 30);
            this.barDockControlRight.Manager = this.barmngr_employee;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 905);
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
            this.btn_exit.ImageOptions.SvgImage = global::QLVT_DATHANG.Properties.Resources.reviewingpane;
            this.btn_exit.Name = "btn_exit";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bds_PhieuXuat
            // 
            this.bds_PhieuXuat.DataMember = "PhieuXuat";
            this.bds_PhieuXuat.DataSource = this.DS;
            // 
            // tbla_PhieuXuat
            // 
            this.tbla_PhieuXuat.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = this.tbla_CTPX;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = this.tbla_Kho;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = this.tbla_PhieuXuat;
            this.tableAdapterManager.UpdateOrder = QLVT_DATHANG.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VatTuTableAdapter = null;
            // 
            // tbla_CTPX
            // 
            this.tbla_CTPX.ClearBeforeFill = true;
            // 
            // tbla_Kho
            // 
            this.tbla_Kho.ClearBeforeFill = true;
            // 
            // gdc_PhieuXuat
            // 
            this.gdc_PhieuXuat.DataSource = this.bds_PhieuXuat;
            this.gdc_PhieuXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdc_PhieuXuat.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gdc_PhieuXuat.Location = new System.Drawing.Point(0, 417);
            this.gdc_PhieuXuat.MainView = this.gridView1;
            this.gdc_PhieuXuat.MenuManager = this.barmngr_employee;
            this.gdc_PhieuXuat.Name = "gdc_PhieuXuat";
            this.gdc_PhieuXuat.Size = new System.Drawing.Size(1938, 518);
            this.gdc_PhieuXuat.TabIndex = 1;
            this.gdc_PhieuXuat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaPX,
            this.colNgay,
            this.colHoTenKH,
            this.colMaNV,
            this.colMaKho});
            this.gridView1.GridControl = this.gdc_PhieuXuat;
            this.gridView1.Name = "gridView1";
            // 
            // colMaPX
            // 
            this.colMaPX.FieldName = "MaPX";
            this.colMaPX.MinWidth = 25;
            this.colMaPX.Name = "colMaPX";
            this.colMaPX.Visible = true;
            this.colMaPX.VisibleIndex = 0;
            this.colMaPX.Width = 94;
            // 
            // colNgay
            // 
            this.colNgay.FieldName = "Ngay";
            this.colNgay.MinWidth = 25;
            this.colNgay.Name = "colNgay";
            this.colNgay.Visible = true;
            this.colNgay.VisibleIndex = 1;
            this.colNgay.Width = 94;
            // 
            // colHoTenKH
            // 
            this.colHoTenKH.FieldName = "HoTenKH";
            this.colHoTenKH.MinWidth = 25;
            this.colHoTenKH.Name = "colHoTenKH";
            this.colHoTenKH.Visible = true;
            this.colHoTenKH.VisibleIndex = 2;
            this.colHoTenKH.Width = 94;
            // 
            // colMaNV
            // 
            this.colMaNV.FieldName = "MaNV";
            this.colMaNV.MinWidth = 25;
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Visible = true;
            this.colMaNV.VisibleIndex = 3;
            this.colMaNV.Width = 94;
            // 
            // colMaKho
            // 
            this.colMaKho.FieldName = "MaKho";
            this.colMaKho.MinWidth = 25;
            this.colMaKho.Name = "colMaKho";
            this.colMaKho.Visible = true;
            this.colMaKho.VisibleIndex = 4;
            this.colMaKho.Width = 94;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gdv_CTPX);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 30);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1938, 387);
            this.panelControl1.TabIndex = 18;
            // 
            // gdv_CTPX
            // 
            this.gdv_CTPX.AutoGenerateColumns = false;
            this.gdv_CTPX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_CTPX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCTPXMaPX,
            this.colCTPXVT,
            this.colCTPXSoLuong,
            this.colCTPXDonGia});
            this.gdv_CTPX.ContextMenuStrip = this.cms_CTPX;
            this.gdv_CTPX.DataSource = this.bds_CTPX;
            this.gdv_CTPX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdv_CTPX.Location = new System.Drawing.Point(942, 2);
            this.gdv_CTPX.Name = "gdv_CTPX";
            this.gdv_CTPX.RowHeadersWidth = 51;
            this.gdv_CTPX.RowTemplate.Height = 24;
            this.gdv_CTPX.Size = new System.Drawing.Size(994, 383);
            this.gdv_CTPX.TabIndex = 17;
            // 
            // colCTPXMaPX
            // 
            this.colCTPXMaPX.DataPropertyName = "MaPX";
            this.colCTPXMaPX.HeaderText = "MaPX";
            this.colCTPXMaPX.MinimumWidth = 6;
            this.colCTPXMaPX.Name = "colCTPXMaPX";
            this.colCTPXMaPX.Width = 125;
            // 
            // colCTPXVT
            // 
            this.colCTPXVT.DataPropertyName = "MaVT";
            this.colCTPXVT.DataSource = this.bds_VatTu;
            this.colCTPXVT.DisplayMember = "TenVT";
            this.colCTPXVT.HeaderText = "VatTu";
            this.colCTPXVT.MinimumWidth = 6;
            this.colCTPXVT.Name = "colCTPXVT";
            this.colCTPXVT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCTPXVT.ValueMember = "MaVT";
            this.colCTPXVT.Width = 125;
            // 
            // bds_VatTu
            // 
            this.bds_VatTu.DataMember = "VatTu";
            this.bds_VatTu.DataSource = this.DS;
            // 
            // colCTPXSoLuong
            // 
            this.colCTPXSoLuong.DataPropertyName = "SoLuong";
            this.colCTPXSoLuong.HeaderText = "SoLuong";
            this.colCTPXSoLuong.MinimumWidth = 6;
            this.colCTPXSoLuong.Name = "colCTPXSoLuong";
            this.colCTPXSoLuong.Width = 125;
            // 
            // colCTPXDonGia
            // 
            this.colCTPXDonGia.DataPropertyName = "DonGia";
            this.colCTPXDonGia.HeaderText = "DonGia";
            this.colCTPXDonGia.MinimumWidth = 6;
            this.colCTPXDonGia.Name = "colCTPXDonGia";
            this.colCTPXDonGia.Width = 125;
            // 
            // cms_CTPX
            // 
            this.cms_CTPX.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_CTPX.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_save,
            this.ms_delete,
            this.ms_cancel});
            this.cms_CTPX.Name = "cms_CTPX";
            this.cms_CTPX.Size = new System.Drawing.Size(196, 76);
            // 
            // ms_save
            // 
            this.ms_save.Name = "ms_save";
            this.ms_save.Size = new System.Drawing.Size(195, 24);
            this.ms_save.Text = "Ghi Chi tiết Phiếu";
            this.ms_save.Click += new System.EventHandler(this.ms_save_Click);
            // 
            // ms_delete
            // 
            this.ms_delete.Name = "ms_delete";
            this.ms_delete.Size = new System.Drawing.Size(195, 24);
            this.ms_delete.Text = "Xóa Chi tiết Phiếu";
            this.ms_delete.Click += new System.EventHandler(this.ms_delete_Click);
            // 
            // ms_cancel
            // 
            this.ms_cancel.Name = "ms_cancel";
            this.ms_cancel.Size = new System.Drawing.Size(195, 24);
            this.ms_cancel.Text = "Hoàn tác";
            this.ms_cancel.Click += new System.EventHandler(this.ms_cancel_Click);
            // 
            // bds_CTPX
            // 
            this.bds_CTPX.DataMember = "FK_CTPX_PX";
            this.bds_CTPX.DataSource = this.bds_PhieuXuat;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.panel7);
            this.panelControl2.Controls.Add(this.gpc_info);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(940, 383);
            this.panelControl2.TabIndex = 17;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.cb_branch);
            this.panel7.Location = new System.Drawing.Point(17, 5);
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
            // gpc_info
            // 
            this.gpc_info.Appearance.BackColor = System.Drawing.Color.White;
            this.gpc_info.Appearance.Options.UseBackColor = true;
            this.gpc_info.Controls.Add(this.panel10);
            this.gpc_info.Location = new System.Drawing.Point(8, 51);
            this.gpc_info.Name = "gpc_info";
            this.gpc_info.Size = new System.Drawing.Size(920, 320);
            this.gpc_info.TabIndex = 14;
            this.gpc_info.Text = "Bảng thông tin";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel4);
            this.panel10.Controls.Add(this.panel8);
            this.panel10.Controls.Add(this.panel9);
            this.panel10.Controls.Add(this.panel6);
            this.panel10.Controls.Add(this.panel2);
            this.panel10.Controls.Add(this.panel3);
            this.panel10.Controls.Add(this.panel1);
            this.panel10.Location = new System.Drawing.Point(5, 31);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(900, 280);
            this.panel10.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txt_cusName);
            this.panel4.Location = new System.Drawing.Point(4, 111);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(440, 48);
            this.panel4.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Họ tên Khách hàng";
            // 
            // txt_cusName
            // 
            this.txt_cusName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_PhieuXuat, "HoTenKH", true));
            this.txt_cusName.Location = new System.Drawing.Point(157, 10);
            this.txt_cusName.MenuManager = this.barmngr_employee;
            this.txt_cusName.Name = "txt_cusName";
            this.txt_cusName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cusName.Properties.Appearance.Options.UseFont = true;
            this.txt_cusName.Size = new System.Drawing.Size(280, 28);
            this.txt_cusName.TabIndex = 20;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.cbb_whsname);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Location = new System.Drawing.Point(3, 219);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(440, 48);
            this.panel8.TabIndex = 4;
            // 
            // cbb_whsname
            // 
            this.cbb_whsname.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bds_PhieuXuat, "MaKho", true));
            this.cbb_whsname.DataSource = this.bds_Kho;
            this.cbb_whsname.DisplayMember = "TenKho";
            this.cbb_whsname.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_whsname.FormattingEnabled = true;
            this.cbb_whsname.Location = new System.Drawing.Point(157, 10);
            this.cbb_whsname.Name = "cbb_whsname";
            this.cbb_whsname.Size = new System.Drawing.Size(280, 29);
            this.cbb_whsname.TabIndex = 8;
            this.cbb_whsname.ValueMember = "MaKho";
            this.cbb_whsname.SelectedIndexChanged += new System.EventHandler(this.cbb_whsname_SelectedIndexChanged);
            // 
            // bds_Kho
            // 
            this.bds_Kho.DataMember = "Kho";
            this.bds_Kho.DataSource = this.DS;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(79, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tên Kho";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txt_whsId);
            this.panel9.Controls.Add(this.label9);
            this.panel9.Location = new System.Drawing.Point(449, 219);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(440, 48);
            this.panel9.TabIndex = 4;
            // 
            // txt_whsId
            // 
            this.txt_whsId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_PhieuXuat, "MaKho", true));
            this.txt_whsId.Location = new System.Drawing.Point(157, 10);
            this.txt_whsId.MenuManager = this.barmngr_employee;
            this.txt_whsId.Name = "txt_whsId";
            this.txt_whsId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_whsId.Properties.Appearance.Options.UseFont = true;
            this.txt_whsId.Size = new System.Drawing.Size(280, 28);
            this.txt_whsId.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(86, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã Kho";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txt_eeId);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(449, 165);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(440, 48);
            this.panel6.TabIndex = 4;
            // 
            // txt_eeId
            // 
            this.txt_eeId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_PhieuXuat, "MaNV", true));
            this.txt_eeId.Location = new System.Drawing.Point(157, 10);
            this.txt_eeId.MenuManager = this.barmngr_employee;
            this.txt_eeId.Name = "txt_eeId";
            this.txt_eeId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_eeId.Properties.Appearance.Options.UseFont = true;
            this.txt_eeId.Size = new System.Drawing.Size(280, 28);
            this.txt_eeId.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã Nhân Viên";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dte_date);
            this.panel2.Location = new System.Drawing.Point(3, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 48);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày";
            // 
            // dte_date
            // 
            this.dte_date.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_PhieuXuat, "Ngay", true));
            this.dte_date.EditValue = null;
            this.dte_date.Location = new System.Drawing.Point(157, 10);
            this.dte_date.MenuManager = this.barmngr_employee;
            this.dte_date.Name = "dte_date";
            this.dte_date.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dte_date.Properties.Appearance.Options.UseFont = true;
            this.dte_date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dte_date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dte_date.Size = new System.Drawing.Size(280, 28);
            this.dte_date.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbb_fullname);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(3, 165);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(440, 48);
            this.panel3.TabIndex = 3;
            // 
            // cbb_fullname
            // 
            this.cbb_fullname.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bds_PhieuXuat, "MaNV", true));
            this.cbb_fullname.DataSource = this.bds_DSNV;
            this.cbb_fullname.DisplayMember = "HoTen";
            this.cbb_fullname.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_fullname.FormattingEnabled = true;
            this.cbb_fullname.Location = new System.Drawing.Point(156, 10);
            this.cbb_fullname.Name = "cbb_fullname";
            this.cbb_fullname.Size = new System.Drawing.Size(280, 29);
            this.cbb_fullname.TabIndex = 8;
            this.cbb_fullname.ValueMember = "MaNV";
            this.cbb_fullname.SelectedIndexChanged += new System.EventHandler(this.cbb_fullname_SelectedIndexChanged);
            // 
            // bds_DSNV
            // 
            this.bds_DSNV.DataMember = "DsNV";
            this.bds_DSNV.DataSource = this.DS;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Họ Tên Nhân Viên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_exportId);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 48);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Phiếu Xuất";
            // 
            // txt_exportId
            // 
            this.txt_exportId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_PhieuXuat, "MaPX", true));
            this.txt_exportId.Location = new System.Drawing.Point(157, 10);
            this.txt_exportId.MenuManager = this.barmngr_employee;
            this.txt_exportId.Name = "txt_exportId";
            this.txt_exportId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_exportId.Properties.Appearance.Options.UseFont = true;
            this.txt_exportId.Size = new System.Drawing.Size(280, 28);
            this.txt_exportId.TabIndex = 18;
            // 
            // tbla_DSNV
            // 
            this.tbla_DSNV.ClearBeforeFill = true;
            // 
            // tbla_VatTu
            // 
            this.tbla_VatTu.ClearBeforeFill = true;
            // 
            // FormExReceipt
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1938, 935);
            this.Controls.Add(this.gdc_PhieuXuat);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormExReceipt";
            this.Text = "Phiếu Xuất";
            this.Load += new System.EventHandler(this.FormExReceipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barmngr_employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_PhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdc_PhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_CTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_VatTu)).EndInit();
            this.cms_CTPX.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bds_CTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpc_info)).EndInit();
            this.gpc_info.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cusName.Properties)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_Kho)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_whsId.Properties)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_eeId.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dte_date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_date.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_DSNV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_exportId.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barmngr_employee;
        private DevExpress.XtraBars.Bar bar3;
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
        private System.Windows.Forms.BindingSource bds_PhieuXuat;
        private DS DS;
        private DSTableAdapters.PhieuXuatTableAdapter tbla_PhieuXuat;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gdc_PhieuXuat;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPX;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTenKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKho;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_branch;
        private DevExpress.XtraEditors.GroupControl gpc_info;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox cbb_whsname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbb_fullname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private DSTableAdapters.CTPXTableAdapter tbla_CTPX;
        private System.Windows.Forms.BindingSource bds_CTPX;
        private System.Windows.Forms.DataGridView gdv_CTPX;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private DSTableAdapters.KhoTableAdapter tbla_Kho;
        private System.Windows.Forms.BindingSource bds_Kho;
        private System.Windows.Forms.BindingSource bds_DSNV;
        private DSTableAdapters.DS_NVTableAdapter tbla_DSNV;
        private DevExpress.XtraEditors.TextEdit txt_cusName;
        private DevExpress.XtraEditors.TextEdit txt_whsId;
        private DevExpress.XtraEditors.TextEdit txt_eeId;
        private DevExpress.XtraEditors.DateEdit dte_date;
        private DevExpress.XtraEditors.TextEdit txt_exportId;
        private System.Windows.Forms.BindingSource bds_VatTu;
        private DSTableAdapters.VatTuTableAdapter tbla_VatTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCTPXMaPX;
        private System.Windows.Forms.DataGridViewComboBoxColumn colCTPXVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCTPXSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCTPXDonGia;
        private System.Windows.Forms.ContextMenuStrip cms_CTPX;
        private System.Windows.Forms.ToolStripMenuItem ms_save;
        private System.Windows.Forms.ToolStripMenuItem ms_delete;
        private System.Windows.Forms.ToolStripMenuItem ms_cancel;
    }
}