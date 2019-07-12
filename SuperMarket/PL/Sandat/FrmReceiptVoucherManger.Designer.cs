namespace SuperMarket.PL.Sandat
{
    partial class FrmReceiptVoucherManger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReceiptVoucherManger));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.تعديلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.طباعةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.DGV_PruChaseOrder = new System.Windows.Forms.DataGridView();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnPrintSingle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNew = new DevExpress.XtraEditors.SimpleButton();
            this.TxtSearch = new DevExpress.XtraEditors.SearchControl();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PruChaseOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSearch.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعديلToolStripMenuItem,
            this.حذفToolStripMenuItem,
            this.طباعةToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(105, 70);
            // 
            // تعديلToolStripMenuItem
            // 
            this.تعديلToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("تعديلToolStripMenuItem.Image")));
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.تعديلToolStripMenuItem.Text = "تعديل";
            this.تعديلToolStripMenuItem.Click += new System.EventHandler(this.تعديلToolStripMenuItem_Click);
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("حذفToolStripMenuItem.Image")));
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.حذفToolStripMenuItem.Text = "حذف";
            this.حذفToolStripMenuItem.Click += new System.EventHandler(this.حذفToolStripMenuItem_Click);
            // 
            // طباعةToolStripMenuItem
            // 
            this.طباعةToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("طباعةToolStripMenuItem.Image")));
            this.طباعةToolStripMenuItem.Name = "طباعةToolStripMenuItem";
            this.طباعةToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.طباعةToolStripMenuItem.Text = "طباعة";
            this.طباعةToolStripMenuItem.Click += new System.EventHandler(this.طباعةToolStripMenuItem_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.Appearance.Options.UseFont = true;
            this.BtnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.ImageOptions.Image")));
            this.BtnEdit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnEdit.Location = new System.Drawing.Point(837, 87);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(144, 39);
            this.BtnEdit.TabIndex = 29;
            this.BtnEdit.Text = "تعديل السند";
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.DGV_PruChaseOrder);
            this.groupControl4.Location = new System.Drawing.Point(13, 44);
            this.groupControl4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl4.Size = new System.Drawing.Size(815, 372);
            this.groupControl4.TabIndex = 28;
            this.groupControl4.Text = "تفاصيل السندات";
            // 
            // DGV_PruChaseOrder
            // 
            this.DGV_PruChaseOrder.AllowUserToAddRows = false;
            this.DGV_PruChaseOrder.AllowUserToDeleteRows = false;
            this.DGV_PruChaseOrder.AllowUserToResizeColumns = false;
            this.DGV_PruChaseOrder.AllowUserToResizeRows = false;
            this.DGV_PruChaseOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_PruChaseOrder.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV_PruChaseOrder.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DGV_PruChaseOrder.ContextMenuStrip = this.contextMenuStrip1;
            this.DGV_PruChaseOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_PruChaseOrder.Location = new System.Drawing.Point(2, 20);
            this.DGV_PruChaseOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGV_PruChaseOrder.MultiSelect = false;
            this.DGV_PruChaseOrder.Name = "DGV_PruChaseOrder";
            this.DGV_PruChaseOrder.ReadOnly = true;
            this.DGV_PruChaseOrder.RowHeadersVisible = false;
            this.DGV_PruChaseOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_PruChaseOrder.Size = new System.Drawing.Size(811, 350);
            this.DGV_PruChaseOrder.TabIndex = 8;
            // 
            // BtnClose
            // 
            this.BtnClose.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Appearance.Options.UseFont = true;
            this.BtnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.ImageOptions.Image")));
            this.BtnClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(840, 367);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(144, 38);
            this.BtnClose.TabIndex = 27;
            this.BtnClose.Text = "إغلاق";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click_1);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Appearance.Options.UseFont = true;
            this.BtnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.ImageOptions.Image")));
            this.BtnDelete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnDelete.Location = new System.Drawing.Point(837, 142);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(144, 39);
            this.BtnDelete.TabIndex = 26;
            this.BtnDelete.Text = "حذف السند";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click_1);
            // 
            // BtnPrintSingle
            // 
            this.BtnPrintSingle.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrintSingle.Appearance.Options.UseFont = true;
            this.BtnPrintSingle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrintSingle.ImageOptions.Image")));
            this.BtnPrintSingle.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnPrintSingle.Location = new System.Drawing.Point(840, 312);
            this.BtnPrintSingle.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.BtnPrintSingle.Name = "BtnPrintSingle";
            this.BtnPrintSingle.Size = new System.Drawing.Size(144, 39);
            this.BtnPrintSingle.TabIndex = 24;
            this.BtnPrintSingle.Text = "طباعة السند";
            this.BtnPrintSingle.Click += new System.EventHandler(this.BtnPrintSingle_Click_1);
            // 
            // BtnNew
            // 
            this.BtnNew.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNew.Appearance.Options.UseFont = true;
            this.BtnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnNew.ImageOptions.Image")));
            this.BtnNew.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnNew.Location = new System.Drawing.Point(837, 32);
            this.BtnNew.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(144, 39);
            this.BtnNew.TabIndex = 25;
            this.BtnNew.Text = "سند جديد";
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click_1);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(196, 8);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TxtSearch.Properties.Appearance.Options.UseFont = true;
            this.TxtSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.TxtSearch.Size = new System.Drawing.Size(480, 20);
            this.TxtSearch.TabIndex = 30;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // FrmReceiptVoucherManger
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 419);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnPrintSingle);
            this.Controls.Add(this.BtnNew);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReceiptVoucherManger";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قائمة سندات القبض";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PruChaseOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSearch.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem طباعةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تعديلToolStripMenuItem;
        private DevExpress.XtraEditors.SimpleButton BtnEdit;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private System.Windows.Forms.DataGridView DGV_PruChaseOrder;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnPrintSingle;
        private DevExpress.XtraEditors.SimpleButton BtnNew;
        private DevExpress.XtraEditors.SearchControl TxtSearch;
    }
}