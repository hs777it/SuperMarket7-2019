namespace SuperMarket.PL.RetuenPruChase
{
    partial class FrmPurReturnManger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPurReturnManger));
            this.TxtSearch = new DevExpress.XtraEditors.SearchControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.DGV_SalesOrder = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.تعديلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.إسترجاعToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAprof = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNew = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SalesOrder)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(124, 8);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TxtSearch.Properties.Appearance.Options.UseFont = true;
            this.TxtSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.TxtSearch.Size = new System.Drawing.Size(480, 20);
            this.TxtSearch.TabIndex = 30;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.DGV_SalesOrder);
            this.groupControl4.Location = new System.Drawing.Point(12, 42);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl4.Size = new System.Drawing.Size(666, 320);
            this.groupControl4.TabIndex = 29;
            this.groupControl4.Text = "تفاصيل الفواتير";
            // 
            // DGV_SalesOrder
            // 
            this.DGV_SalesOrder.AllowUserToAddRows = false;
            this.DGV_SalesOrder.AllowUserToDeleteRows = false;
            this.DGV_SalesOrder.AllowUserToResizeColumns = false;
            this.DGV_SalesOrder.AllowUserToResizeRows = false;
            this.DGV_SalesOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_SalesOrder.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV_SalesOrder.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DGV_SalesOrder.ContextMenuStrip = this.contextMenuStrip1;
            this.DGV_SalesOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_SalesOrder.Location = new System.Drawing.Point(2, 20);
            this.DGV_SalesOrder.MultiSelect = false;
            this.DGV_SalesOrder.Name = "DGV_SalesOrder";
            this.DGV_SalesOrder.ReadOnly = true;
            this.DGV_SalesOrder.RowHeadersVisible = false;
            this.DGV_SalesOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_SalesOrder.Size = new System.Drawing.Size(662, 298);
            this.DGV_SalesOrder.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعديلToolStripMenuItem,
            this.حذفToolStripMenuItem,
            this.إسترجاعToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 70);
            // 
            // تعديلToolStripMenuItem
            // 
            this.تعديلToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("تعديلToolStripMenuItem.Image")));
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.تعديلToolStripMenuItem.Text = "تعديل";
            this.تعديلToolStripMenuItem.Click += new System.EventHandler(this.تعديلToolStripMenuItem_Click);
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("حذفToolStripMenuItem.Image")));
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.حذفToolStripMenuItem.Text = "حذف";
            this.حذفToolStripMenuItem.Click += new System.EventHandler(this.حذفToolStripMenuItem_Click);
            // 
            // إسترجاعToolStripMenuItem
            // 
            this.إسترجاعToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("إسترجاعToolStripMenuItem.Image")));
            this.إسترجاعToolStripMenuItem.Name = "إسترجاعToolStripMenuItem";
            this.إسترجاعToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.إسترجاعToolStripMenuItem.Text = "إسترجاع";
            this.إسترجاعToolStripMenuItem.Click += new System.EventHandler(this.إسترجاعToolStripMenuItem_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Appearance.Options.UseFont = true;
            this.BtnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.ImageOptions.Image")));
            this.BtnClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(685, 311);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(137, 40);
            this.BtnClose.TabIndex = 28;
            this.BtnClose.Text = "إغلاق";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnAprof
            // 
            this.BtnAprof.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAprof.Appearance.Options.UseFont = true;
            this.BtnAprof.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAprof.ImageOptions.Image")));
            this.BtnAprof.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnAprof.Location = new System.Drawing.Point(685, 195);
            this.BtnAprof.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAprof.Name = "BtnAprof";
            this.BtnAprof.Size = new System.Drawing.Size(137, 41);
            this.BtnAprof.TabIndex = 26;
            this.BtnAprof.Text = "إسترجاع";
            this.BtnAprof.Click += new System.EventHandler(this.BtnAprof_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Appearance.Options.UseFont = true;
            this.BtnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.ImageOptions.Image")));
            this.BtnDelete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnDelete.Location = new System.Drawing.Point(685, 144);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(137, 41);
            this.BtnDelete.TabIndex = 27;
            this.BtnDelete.Text = "حذف";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.Appearance.Options.UseFont = true;
            this.BtnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.ImageOptions.Image")));
            this.BtnEdit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnEdit.Location = new System.Drawing.Point(685, 93);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(137, 41);
            this.BtnEdit.TabIndex = 24;
            this.BtnEdit.Text = "تعديل";
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNew.Appearance.Options.UseFont = true;
            this.BtnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnNew.ImageOptions.Image")));
            this.BtnNew.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnNew.Location = new System.Drawing.Point(685, 42);
            this.BtnNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(137, 41);
            this.BtnNew.TabIndex = 25;
            this.BtnNew.Text = "مرتجع جديدة";
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // FrmPurReturnManger
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 370);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnAprof);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnNew);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPurReturnManger";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لوحة التحكم بمرتجعات الشراء";
            ((System.ComponentModel.ISupportInitialize)(this.TxtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SalesOrder)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SearchControl TxtSearch;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private System.Windows.Forms.DataGridView DGV_SalesOrder;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem تعديلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private DevExpress.XtraEditors.SimpleButton BtnAprof;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnEdit;
        private DevExpress.XtraEditors.SimpleButton BtnNew;
        private System.Windows.Forms.ToolStripMenuItem إسترجاعToolStripMenuItem;
    }
}