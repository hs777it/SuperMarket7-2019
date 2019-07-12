namespace SuperMarket.PL.RetuenPruChase
{
    partial class FrmSelectListPur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelectListPur));
            this.TxtSearch = new DevExpress.XtraEditors.SearchControl();
            this.DGV_Order = new System.Windows.Forms.DataGridView();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(215, 12);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TxtSearch.Properties.Appearance.Options.UseFont = true;
            this.TxtSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.TxtSearch.Size = new System.Drawing.Size(681, 20);
            this.TxtSearch.TabIndex = 1;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // DGV_Order
            // 
            this.DGV_Order.AllowUserToAddRows = false;
            this.DGV_Order.AllowUserToDeleteRows = false;
            this.DGV_Order.AllowUserToResizeColumns = false;
            this.DGV_Order.AllowUserToResizeRows = false;
            this.DGV_Order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Order.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV_Order.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DGV_Order.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Order.Location = new System.Drawing.Point(2, 20);
            this.DGV_Order.MultiSelect = false;
            this.DGV_Order.Name = "DGV_Order";
            this.DGV_Order.ReadOnly = true;
            this.DGV_Order.RowHeadersVisible = false;
            this.DGV_Order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Order.Size = new System.Drawing.Size(1141, 424);
            this.DGV_Order.TabIndex = 0;
            this.DGV_Order.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Order_CellDoubleClick);
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.DGV_Order);
            this.groupControl4.Location = new System.Drawing.Point(1, 50);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl4.Size = new System.Drawing.Size(1145, 446);
            this.groupControl4.TabIndex = 0;
            this.groupControl4.Text = "تفاصيل الفواتير";
            // 
            // FrmSelectListPur
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 497);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.groupControl4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSelectListPur";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فواتير الشراء";
            ((System.ComponentModel.ISupportInitialize)(this.TxtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SearchControl TxtSearch;
        public System.Windows.Forms.DataGridView DGV_Order;
        private DevExpress.XtraEditors.GroupControl groupControl4;
    }
}