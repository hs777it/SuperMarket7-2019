namespace SuperMarket.PL.PruChaseOrder
{
    partial class Frm_PruChaseManger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PruChaseManger));
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.DGV_PruChaseOrder = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.طباعةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNew = new DevExpress.XtraEditors.SimpleButton();
            this.BtnPrintSingle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnPrintAll = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PruChaseOrder)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.DGV_PruChaseOrder);
            this.groupControl4.Location = new System.Drawing.Point(5, 12);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl4.Size = new System.Drawing.Size(666, 355);
            this.groupControl4.TabIndex = 16;
            this.groupControl4.Text = "تفاصيل الفواتير";
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
            this.DGV_PruChaseOrder.MultiSelect = false;
            this.DGV_PruChaseOrder.Name = "DGV_PruChaseOrder";
            this.DGV_PruChaseOrder.ReadOnly = true;
            this.DGV_PruChaseOrder.RowHeadersVisible = false;
            this.DGV_PruChaseOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_PruChaseOrder.Size = new System.Drawing.Size(662, 333);
            this.DGV_PruChaseOrder.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.حذفToolStripMenuItem,
            this.طباعةToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(105, 48);
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
            // BtnClose
            // 
            this.BtnClose.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Appearance.Options.UseFont = true;
            this.BtnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.ImageOptions.Image")));
            this.BtnClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(676, 299);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(137, 40);
            this.BtnClose.TabIndex = 15;
            this.BtnClose.Text = "إغلاق";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Appearance.Options.UseFont = true;
            this.BtnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.ImageOptions.Image")));
            this.BtnDelete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnDelete.Location = new System.Drawing.Point(678, 65);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(137, 41);
            this.BtnDelete.TabIndex = 14;
            this.BtnDelete.Text = "حذف الفاتورة";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNew.Appearance.Options.UseFont = true;
            this.BtnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnNew.ImageOptions.Image")));
            this.BtnNew.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnNew.Location = new System.Drawing.Point(678, 14);
            this.BtnNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(137, 41);
            this.BtnNew.TabIndex = 13;
            this.BtnNew.Text = "فاتورة جديدة";
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnPrintSingle
            // 
            this.BtnPrintSingle.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrintSingle.Appearance.Options.UseFont = true;
            this.BtnPrintSingle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrintSingle.ImageOptions.Image")));
            this.BtnPrintSingle.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnPrintSingle.Location = new System.Drawing.Point(678, 116);
            this.BtnPrintSingle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPrintSingle.Name = "BtnPrintSingle";
            this.BtnPrintSingle.Size = new System.Drawing.Size(137, 41);
            this.BtnPrintSingle.TabIndex = 13;
            this.BtnPrintSingle.Text = "طباعة الفاتورة";
            this.BtnPrintSingle.Click += new System.EventHandler(this.BtnPrintSingle_Click);
            // 
            // BtnPrintAll
            // 
            this.BtnPrintAll.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrintAll.Appearance.Options.UseFont = true;
            this.BtnPrintAll.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrintAll.ImageOptions.Image")));
            this.BtnPrintAll.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnPrintAll.Location = new System.Drawing.Point(678, 248);
            this.BtnPrintAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPrintAll.Name = "BtnPrintAll";
            this.BtnPrintAll.Size = new System.Drawing.Size(137, 41);
            this.BtnPrintAll.TabIndex = 14;
            this.BtnPrintAll.Text = "طباعة الكل";
            this.BtnPrintAll.Click += new System.EventHandler(this.BtnPrintAll_Click);
            // 
            // Frm_PruChaseManger
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 370);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnPrintAll);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnPrintSingle);
            this.Controls.Add(this.BtnNew);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_PruChaseManger";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة أوامر الشراء";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PruChaseOrder)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnNew;
        private DevExpress.XtraEditors.SimpleButton BtnPrintSingle;
        private DevExpress.XtraEditors.SimpleButton BtnPrintAll;
        private System.Windows.Forms.DataGridView DGV_PruChaseOrder;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem طباعةToolStripMenuItem;
    }
}