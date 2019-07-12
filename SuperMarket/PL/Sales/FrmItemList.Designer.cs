namespace SuperMarket.PL.Sales
{
    partial class FrmItemList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItemList));
            this.DGVSelectIems = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TlAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtSearch = new DevExpress.XtraEditors.SearchControl();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSelectIems)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSearch.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVSelectIems
            // 
            this.DGVSelectIems.AllowUserToAddRows = false;
            this.DGVSelectIems.AllowUserToDeleteRows = false;
            this.DGVSelectIems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVSelectIems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVSelectIems.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGVSelectIems.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DGVSelectIems.ColumnHeadersHeight = 30;
            this.DGVSelectIems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVSelectIems.Location = new System.Drawing.Point(0, 55);
            this.DGVSelectIems.MultiSelect = false;
            this.DGVSelectIems.Name = "DGVSelectIems";
            this.DGVSelectIems.ReadOnly = true;
            this.DGVSelectIems.RowHeadersVisible = false;
            this.DGVSelectIems.RowHeadersWidth = 60;
            this.DGVSelectIems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVSelectIems.Size = new System.Drawing.Size(442, 331);
            this.DGVSelectIems.TabIndex = 19;
            this.DGVSelectIems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVSelectIems_CellDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlAdd});
            this.menuStrip1.Location = new System.Drawing.Point(0, 20);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(442, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TlAdd
            // 
            this.TlAdd.Image = ((System.Drawing.Image)(resources.GetObject("TlAdd.Image")));
            this.TlAdd.Name = "TlAdd";
            this.TlAdd.Size = new System.Drawing.Size(122, 20);
            this.TlAdd.Text = "إضافة صنف جديد";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtSearch.Location = new System.Drawing.Point(0, 0);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TxtSearch.Properties.Appearance.Options.UseFont = true;
            this.TxtSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.TxtSearch.Size = new System.Drawing.Size(442, 20);
            this.TxtSearch.TabIndex = 21;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // FrmItemList
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 398);
            this.Controls.Add(this.DGVSelectIems);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.TxtSearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmItemList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قائمة الاصناف";
            this.Leave += new System.EventHandler(this.FrmItemList_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSelectIems)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSearch.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView DGVSelectIems;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TlAdd;
        private DevExpress.XtraEditors.SearchControl TxtSearch;
    }
}