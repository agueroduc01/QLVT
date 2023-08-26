namespace QLVT_DATHANG.ReportForm
{
    partial class Frpt_IOSummary
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
            this.btn_Print = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Preview = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.editToDate = new DevExpress.XtraEditors.DateEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.editFromDate = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editToDate.Properties.CalendarTimeProperties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editFromDate.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(714, 185);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(88, 40);
            this.btn_Print.TabIndex = 23;
            this.btn_Print.Text = "In ra file";
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_Preview
            // 
            this.btn_Preview.Location = new System.Drawing.Point(714, 71);
            this.btn_Preview.Name = "btn_Preview";
            this.btn_Preview.Size = new System.Drawing.Size(88, 40);
            this.btn_Preview.TabIndex = 22;
            this.btn_Preview.Text = "Xem trước";
            this.btn_Preview.Click += new System.EventHandler(this.btn_Preview_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.editToDate);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(181, 185);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(359, 40);
            this.panel3.TabIndex = 21;
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
            this.panel2.Location = new System.Drawing.Point(181, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 40);
            this.panel2.TabIndex = 20;
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
            // Frpt_IOSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 341);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Preview);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Frpt_IOSummary";
            this.Text = "Frpt_IOSummary";
            this.Load += new System.EventHandler(this.Frpt_IOSummary_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editToDate.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editFromDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_Print;
        private DevExpress.XtraEditors.SimpleButton btn_Preview;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.DateEdit editToDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.DateEdit editFromDate;
        private System.Windows.Forms.Label label3;
    }
}