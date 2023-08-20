namespace QLVT_DATHANG.ReportForm
{
    partial class Frpt_EmployeeActivities
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_branch = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.editToDate = new DevExpress.XtraEditors.DateEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.editFromDate = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_HotenNV = new System.Windows.Forms.ComboBox();
            this.sPHotenMaNVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLVT_DATHANG.DS();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_maNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sP_HotenMaNVTableAdapter = new QLVT_DATHANG.DSTableAdapters.SP_HotenMaNVTableAdapter();
            this.btn_Print = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Preview = new DevExpress.XtraEditors.SimpleButton();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editToDate.Properties.CalendarTimeProperties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editFromDate.Properties.CalendarTimeProperties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPHotenMaNVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.cb_branch);
            this.panel7.Location = new System.Drawing.Point(57, 69);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(449, 40);
            this.panel7.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(33, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi nhánh";
            // 
            // cb_branch
            // 
            this.cb_branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_branch.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_branch.FormattingEnabled = true;
            this.cb_branch.Location = new System.Drawing.Point(135, 4);
            this.cb_branch.Name = "cb_branch";
            this.cb_branch.Size = new System.Drawing.Size(280, 29);
            this.cb_branch.TabIndex = 1;
            this.cb_branch.SelectedIndexChanged += new System.EventHandler(this.cb_branch_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.editToDate);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(512, 183);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(359, 40);
            this.panel3.TabIndex = 19;
            // 
            // editToDate
            // 
            this.editToDate.EditValue = null;
            this.editToDate.Location = new System.Drawing.Point(158, 10);
            this.editToDate.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.editToDate.Name = "editToDate";
            this.editToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.editToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.editToDate.Size = new System.Drawing.Size(155, 22);
            this.editToDate.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(53, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đến ngày";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.editFromDate);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(512, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 40);
            this.panel2.TabIndex = 18;
            // 
            // editFromDate
            // 
            this.editFromDate.EditValue = null;
            this.editFromDate.Location = new System.Drawing.Point(152, 10);
            this.editFromDate.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.editFromDate.Name = "editFromDate";
            this.editFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.editFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.editFromDate.Size = new System.Drawing.Size(155, 22);
            this.editFromDate.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(51, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Từ ngày";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmb_HotenNV);
            this.panel1.Location = new System.Drawing.Point(57, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 40);
            this.panel1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(33, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên nhân viên :";
            // 
            // cmb_HotenNV
            // 
            this.cmb_HotenNV.DataSource = this.sPHotenMaNVBindingSource;
            this.cmb_HotenNV.DisplayMember = "Hoten";
            this.cmb_HotenNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_HotenNV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_HotenNV.FormattingEnabled = true;
            this.cmb_HotenNV.Location = new System.Drawing.Point(208, 4);
            this.cmb_HotenNV.Name = "cmb_HotenNV";
            this.cmb_HotenNV.Size = new System.Drawing.Size(155, 29);
            this.cmb_HotenNV.TabIndex = 1;
            this.cmb_HotenNV.ValueMember = "MaNV";
            this.cmb_HotenNV.SelectedIndexChanged += new System.EventHandler(this.cmb_HotenNV_SelectedIndexChanged);
            // 
            // sPHotenMaNVBindingSource
            // 
            this.sPHotenMaNVBindingSource.DataMember = "SP_HotenMaNV";
            this.sPHotenMaNVBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txt_maNV);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(57, 271);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(396, 40);
            this.panel4.TabIndex = 21;
            // 
            // txt_maNV
            // 
            this.txt_maNV.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_maNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_maNV.Location = new System.Drawing.Point(232, 3);
            this.txt_maNV.Name = "txt_maNV";
            this.txt_maNV.ReadOnly = true;
            this.txt_maNV.Size = new System.Drawing.Size(100, 34);
            this.txt_maNV.TabIndex = 22;
            this.txt_maNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(65, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã nhân viên :";
            // 
            // sP_HotenMaNVTableAdapter
            // 
            this.sP_HotenMaNVTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(1006, 183);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(88, 40);
            this.btn_Print.TabIndex = 23;
            this.btn_Print.Text = "In ra file";
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_Preview
            // 
            this.btn_Preview.Location = new System.Drawing.Point(1006, 69);
            this.btn_Preview.Name = "btn_Preview";
            this.btn_Preview.Size = new System.Drawing.Size(88, 40);
            this.btn_Preview.TabIndex = 22;
            this.btn_Preview.Text = "Xem trước";
            this.btn_Preview.Click += new System.EventHandler(this.btn_Preview_Click);
            // 
            // Frpt_EmployeeActivities
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1255, 418);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Preview);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel7);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Frpt_EmployeeActivities";
            this.Text = "Frpt_EmployeeActivities";
            this.Load += new System.EventHandler(this.Frpt_EmployeeActivities_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editToDate.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editFromDate.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPHotenMaNVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_branch;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.DateEdit editToDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.DateEdit editFromDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_HotenNV;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_maNV;
        private DS dS;
        private System.Windows.Forms.BindingSource sPHotenMaNVBindingSource;
        private DSTableAdapters.SP_HotenMaNVTableAdapter sP_HotenMaNVTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btn_Print;
        private DevExpress.XtraEditors.SimpleButton btn_Preview;
    }
}