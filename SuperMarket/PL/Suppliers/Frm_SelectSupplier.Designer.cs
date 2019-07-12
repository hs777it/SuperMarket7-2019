namespace SuperMarket.PL.Suppliers
{
    partial class Frm_SelectSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SelectSupplier));
            this.DGVSelectSupplier = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.إغلاقToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchUsers = new DevExpress.XtraEditors.SearchControl();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSelectSupplier)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchUsers.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVSelectSupplier
            // 
            this.DGVSelectSupplier.AllowUserToAddRows = false;
            this.DGVSelectSupplier.AllowUserToDeleteRows = false;
            this.DGVSelectSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVSelectSupplier.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGVSelectSupplier.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DGVSelectSupplier.ColumnHeadersHeight = 30;
            this.DGVSelectSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVSelectSupplier.Location = new System.Drawing.Point(0, 54);
            this.DGVSelectSupplier.MultiSelect = false;
            this.DGVSelectSupplier.Name = "DGVSelectSupplier";
            this.DGVSelectSupplier.ReadOnly = true;
            this.DGVSelectSupplier.RowHeadersVisible = false;
            this.DGVSelectSupplier.RowHeadersWidth = 60;
            this.DGVSelectSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVSelectSupplier.Size = new System.Drawing.Size(303, 323);
            this.DGVSelectSupplier.TabIndex = 7;
            this.DGVSelectSupplier.DoubleClick += new System.EventHandler(this.DGVSelectSupplier_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.إغلاقToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(311, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // إغلاقToolStripMenuItem
            // 
            this.إغلاقToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("إغلاقToolStripMenuItem.Image")));
            this.إغلاقToolStripMenuItem.Name = "إغلاقToolStripMenuItem";
            this.إغلاقToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.إغلاقToolStripMenuItem.Text = "إضافة مورد جديد";
            this.إغلاقToolStripMenuItem.Click += new System.EventHandler(this.إغلاقToolStripMenuItem_Click);
            // 
            // SearchUsers
            // 
            this.SearchUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchUsers.Location = new System.Drawing.Point(0, 24);
            this.SearchUsers.Name = "SearchUsers";
            this.SearchUsers.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.SearchUsers.Properties.Appearance.Options.UseFont = true;
            this.SearchUsers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.SearchUsers.Size = new System.Drawing.Size(311, 20);
            this.SearchUsers.TabIndex = 15;
            this.SearchUsers.TextChanged += new System.EventHandler(this.SearchUsers_TextChanged);
            // 
            // Frm_SelectSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 377);
            this.Controls.Add(this.SearchUsers);
            this.Controls.Add(this.DGVSelectSupplier);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_SelectSupplier";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إختيار مورد";
            this.Load += new System.EventHandler(this.Frm_SelectSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSelectSupplier)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchUsers.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem إغلاقToolStripMenuItem;
        private DevExpress.XtraEditors.SearchControl SearchUsers;
        public System.Windows.Forms.DataGridView DGVSelectSupplier;
    }
}