namespace SuperMarket.PL.Sales
{
    partial class FrmSalesTraffic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSalesTraffic));
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.DGV_Sales = new System.Windows.Forms.DataGridView();
            this.DateTo = new DevExpress.XtraEditors.DateEdit();
            this.DateFrom = new DevExpress.XtraEditors.DateEdit();
            this.Total_Amount_Ar = new DevExpress.XtraEditors.TextEdit();
            this.Total_Amount = new DevExpress.XtraEditors.TextEdit();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Sales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Total_Amount_Ar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Total_Amount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.DGV_Sales);
            this.groupControl4.Location = new System.Drawing.Point(7, 91);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl4.Size = new System.Drawing.Size(845, 355);
            this.groupControl4.TabIndex = 1;
            this.groupControl4.Text = "المبيعات";
            // 
            // DGV_Sales
            // 
            this.DGV_Sales.AllowUserToAddRows = false;
            this.DGV_Sales.AllowUserToDeleteRows = false;
            this.DGV_Sales.AllowUserToResizeColumns = false;
            this.DGV_Sales.AllowUserToResizeRows = false;
            this.DGV_Sales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Sales.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV_Sales.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DGV_Sales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Sales.Location = new System.Drawing.Point(2, 20);
            this.DGV_Sales.MultiSelect = false;
            this.DGV_Sales.Name = "DGV_Sales";
            this.DGV_Sales.ReadOnly = true;
            this.DGV_Sales.RowHeadersVisible = false;
            this.DGV_Sales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Sales.Size = new System.Drawing.Size(841, 333);
            this.DGV_Sales.TabIndex = 0;
            // 
            // DateTo
            // 
            this.DateTo.EditValue = new System.DateTime(2017, 7, 3, 16, 34, 29, 0);
            this.DateTo.Location = new System.Drawing.Point(137, 25);
            this.DateTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DateTo.Name = "DateTo";
            this.DateTo.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.DateTo.Properties.Appearance.Options.UseFont = true;
            this.DateTo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.DateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateTo.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.DateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateTo.Size = new System.Drawing.Size(238, 18);
            this.DateTo.TabIndex = 1;
            // 
            // DateFrom
            // 
            this.DateFrom.EditValue = new System.DateTime(2017, 7, 3, 16, 34, 29, 0);
            this.DateFrom.Location = new System.Drawing.Point(484, 25);
            this.DateFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.DateFrom.Properties.Appearance.Options.UseFont = true;
            this.DateFrom.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.DateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateFrom.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.DateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateFrom.Size = new System.Drawing.Size(238, 18);
            this.DateFrom.TabIndex = 0;
            this.DateFrom.EditValueChanged += new System.EventHandler(this.DateFrom_EditValueChanged);
            // 
            // Total_Amount_Ar
            // 
            this.Total_Amount_Ar.Location = new System.Drawing.Point(7, 469);
            this.Total_Amount_Ar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Total_Amount_Ar.Name = "Total_Amount_Ar";
            this.Total_Amount_Ar.Properties.Appearance.BackColor = System.Drawing.Color.CadetBlue;
            this.Total_Amount_Ar.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.Total_Amount_Ar.Properties.Appearance.ForeColor = System.Drawing.Color.Yellow;
            this.Total_Amount_Ar.Properties.Appearance.Options.UseBackColor = true;
            this.Total_Amount_Ar.Properties.Appearance.Options.UseFont = true;
            this.Total_Amount_Ar.Properties.Appearance.Options.UseForeColor = true;
            this.Total_Amount_Ar.Properties.Appearance.Options.UseTextOptions = true;
            this.Total_Amount_Ar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Total_Amount_Ar.Properties.ReadOnly = true;
            this.Total_Amount_Ar.Size = new System.Drawing.Size(640, 20);
            this.Total_Amount_Ar.TabIndex = 3;
            // 
            // Total_Amount
            // 
            this.Total_Amount.Location = new System.Drawing.Point(644, 469);
            this.Total_Amount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Total_Amount.Name = "Total_Amount";
            this.Total_Amount.Properties.Appearance.BackColor = System.Drawing.Color.CadetBlue;
            this.Total_Amount.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.Total_Amount.Properties.Appearance.ForeColor = System.Drawing.Color.Yellow;
            this.Total_Amount.Properties.Appearance.Options.UseBackColor = true;
            this.Total_Amount.Properties.Appearance.Options.UseFont = true;
            this.Total_Amount.Properties.Appearance.Options.UseForeColor = true;
            this.Total_Amount.Properties.Appearance.Options.UseTextOptions = true;
            this.Total_Amount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Total_Amount.Properties.ReadOnly = true;
            this.Total_Amount.Properties.EditValueChanged += new System.EventHandler(this.textEdit14_Properties_EditValueChanged);
            this.Total_Amount.Size = new System.Drawing.Size(208, 20);
            this.Total_Amount.TabIndex = 2;
            this.Total_Amount.TextChanged += new System.EventHandler(this.Total_Amount_TextChanged);
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.Honeydew;
            this.label18.Location = new System.Drawing.Point(7, 449);
            this.label18.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(640, 21);
            this.label18.TabIndex = 56;
            this.label18.Text = "إجمالى المبلغ بالعربية";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.Honeydew;
            this.label17.Location = new System.Drawing.Point(644, 449);
            this.label17.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(208, 21);
            this.label17.TabIndex = 57;
            this.label17.Text = "إجمالى المبيعات";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnClose
            // 
            this.BtnClose.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Appearance.Options.UseFont = true;
            this.BtnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.ImageOptions.Image")));
            this.BtnClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(759, 504);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(91, 40);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.Text = "إغلاق";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.DateTo);
            this.groupControl1.Controls.Add(this.DateFrom);
            this.groupControl1.Location = new System.Drawing.Point(7, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl1.Size = new System.Drawing.Size(845, 65);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "البحث بين تاريخين";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(735, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "من :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(388, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "إلى :";
            // 
            // FrmSalesTraffic
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 558);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.Total_Amount_Ar);
            this.Controls.Add(this.Total_Amount);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSalesTraffic";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حركة البيع";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Sales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Total_Amount_Ar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Total_Amount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl4;
        private System.Windows.Forms.DataGridView DGV_Sales;
        public DevExpress.XtraEditors.DateEdit DateTo;
        public DevExpress.XtraEditors.DateEdit DateFrom;
        private DevExpress.XtraEditors.TextEdit Total_Amount_Ar;
        private DevExpress.XtraEditors.TextEdit Total_Amount;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}