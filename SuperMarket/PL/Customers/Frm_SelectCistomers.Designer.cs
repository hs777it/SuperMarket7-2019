namespace SuperMarket.PL.Customers
{
    partial class Frm_SelectCistomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SelectCistomers));
            this.DGVSelectCustomers = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.إغلاقToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchCust = new DevExpress.XtraEditors.SearchControl();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSelectCustomers)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchCust.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVSelectCustomers
            // 
            this.DGVSelectCustomers.AllowUserToAddRows = false;
            this.DGVSelectCustomers.AllowUserToDeleteRows = false;
            this.DGVSelectCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVSelectCustomers.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGVSelectCustomers.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DGVSelectCustomers.ColumnHeadersHeight = 30;
            this.DGVSelectCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVSelectCustomers.Location = new System.Drawing.Point(0, 56);
            this.DGVSelectCustomers.MultiSelect = false;
            this.DGVSelectCustomers.Name = "DGVSelectCustomers";
            this.DGVSelectCustomers.ReadOnly = true;
            this.DGVSelectCustomers.RowHeadersVisible = false;
            this.DGVSelectCustomers.RowHeadersWidth = 60;
            this.DGVSelectCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVSelectCustomers.Size = new System.Drawing.Size(418, 335);
            this.DGVSelectCustomers.TabIndex = 16;
            this.DGVSelectCustomers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVSelectCustomers_CellDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.إغلاقToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 20);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(431, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // إغلاقToolStripMenuItem
            // 
            this.إغلاقToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("إغلاقToolStripMenuItem.Image")));
            this.إغلاقToolStripMenuItem.Name = "إغلاقToolStripMenuItem";
            this.إغلاقToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.إغلاقToolStripMenuItem.Text = "إضافة عميل جديد";
            this.إغلاقToolStripMenuItem.Click += new System.EventHandler(this.إغلاقToolStripMenuItem_Click);
            // 
            // SearchCust
            // 
            this.SearchCust.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchCust.Location = new System.Drawing.Point(0, 0);
            this.SearchCust.Name = "SearchCust";
            this.SearchCust.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.SearchCust.Properties.Appearance.Options.UseFont = true;
            this.SearchCust.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.SearchCust.Size = new System.Drawing.Size(431, 20);
            this.SearchCust.TabIndex = 18;
            this.SearchCust.TextChanged += new System.EventHandler(this.SearchCust_TextChanged);
            // 
            // Frm_SelectCistomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 392);
            this.Controls.Add(this.DGVSelectCustomers);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.SearchCust);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_SelectCistomers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إختيار عميل";
            ((System.ComponentModel.ISupportInitialize)(this.DGVSelectCustomers)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchCust.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView DGVSelectCustomers;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem إغلاقToolStripMenuItem;
        private DevExpress.XtraEditors.SearchControl SearchCust;
    }
}