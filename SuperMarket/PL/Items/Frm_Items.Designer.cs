namespace SuperMarket.PL.Items
{
    partial class Frm_Items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Items));
            this.BtnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.BtnPintAll = new DevExpress.XtraEditors.SimpleButton();
            this.SearchUsers = new DevExpress.XtraEditors.SearchControl();
            this.DGV_Items = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.تعديلالصنفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفالصنفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.معاينةالصنفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.إضافةشركةللصنفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.إضافةمكانللصنفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.طباعةالصنفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Status = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDel = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAddCompany = new DevExpress.XtraEditors.SimpleButton();
            this.BtnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAddPlace = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.SearchUsers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Items)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnPrint
            // 
            this.BtnPrint.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold);
            this.BtnPrint.Appearance.Options.UseFont = true;
            this.BtnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrint.ImageOptions.Image")));
            this.BtnPrint.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnPrint.Location = new System.Drawing.Point(1064, 368);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(143, 32);
            this.BtnPrint.TabIndex = 19;
            this.BtnPrint.Text = "طباعة صنف";
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // BtnPintAll
            // 
            this.BtnPintAll.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold);
            this.BtnPintAll.Appearance.Options.UseFont = true;
            this.BtnPintAll.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnPintAll.ImageOptions.Image")));
            this.BtnPintAll.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnPintAll.Location = new System.Drawing.Point(1064, 406);
            this.BtnPintAll.Name = "BtnPintAll";
            this.BtnPintAll.Size = new System.Drawing.Size(143, 30);
            this.BtnPintAll.TabIndex = 20;
            this.BtnPintAll.Text = "طباعة الكل";
            this.BtnPintAll.Click += new System.EventHandler(this.BtnPintAll_Click);
            // 
            // SearchUsers
            // 
            this.SearchUsers.Location = new System.Drawing.Point(98, 27);
            this.SearchUsers.Name = "SearchUsers";
            this.SearchUsers.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.SearchUsers.Properties.Appearance.Options.UseFont = true;
            this.SearchUsers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.SearchUsers.Size = new System.Drawing.Size(810, 20);
            this.SearchUsers.TabIndex = 14;
            this.SearchUsers.TextChanged += new System.EventHandler(this.SearchUsers_TextChanged);
            // 
            // DGV_Items
            // 
            this.DGV_Items.AllowUserToAddRows = false;
            this.DGV_Items.AllowUserToDeleteRows = false;
            this.DGV_Items.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Items.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV_Items.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DGV_Items.ColumnHeadersHeight = 30;
            this.DGV_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_Items.ContextMenuStrip = this.contextMenuStrip1;
            this.DGV_Items.Location = new System.Drawing.Point(8, 65);
            this.DGV_Items.MultiSelect = false;
            this.DGV_Items.Name = "DGV_Items";
            this.DGV_Items.ReadOnly = true;
            this.DGV_Items.RowHeadersVisible = false;
            this.DGV_Items.RowHeadersWidth = 60;
            this.DGV_Items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Items.Size = new System.Drawing.Size(1026, 412);
            this.DGV_Items.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعديلالصنفToolStripMenuItem,
            this.حذفالصنفToolStripMenuItem,
            this.toolStripSeparator1,
            this.معاينةالصنفToolStripMenuItem,
            this.إضافةشركةللصنفToolStripMenuItem,
            this.إضافةمكانللصنفToolStripMenuItem,
            this.toolStripSeparator2,
            this.طباعةالصنفToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(141, 148);
            // 
            // تعديلالصنفToolStripMenuItem
            // 
            this.تعديلالصنفToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("تعديلالصنفToolStripMenuItem.Image")));
            this.تعديلالصنفToolStripMenuItem.Name = "تعديلالصنفToolStripMenuItem";
            this.تعديلالصنفToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.تعديلالصنفToolStripMenuItem.Text = "تعديل الصنف";
            this.تعديلالصنفToolStripMenuItem.Click += new System.EventHandler(this.تعديلالصنفToolStripMenuItem_Click);
            // 
            // حذفالصنفToolStripMenuItem
            // 
            this.حذفالصنفToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("حذفالصنفToolStripMenuItem.Image")));
            this.حذفالصنفToolStripMenuItem.Name = "حذفالصنفToolStripMenuItem";
            this.حذفالصنفToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.حذفالصنفToolStripMenuItem.Text = "حذف الصنف";
            this.حذفالصنفToolStripMenuItem.Click += new System.EventHandler(this.حذفالصنفToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(137, 6);
            // 
            // معاينةالصنفToolStripMenuItem
            // 
            this.معاينةالصنفToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("معاينةالصنفToolStripMenuItem.Image")));
            this.معاينةالصنفToolStripMenuItem.Name = "معاينةالصنفToolStripMenuItem";
            this.معاينةالصنفToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.معاينةالصنفToolStripMenuItem.Text = "معاينة الصنف";
            this.معاينةالصنفToolStripMenuItem.Click += new System.EventHandler(this.معاينةالصنفToolStripMenuItem_Click);
            // 
            // إضافةشركةللصنفToolStripMenuItem
            // 
            this.إضافةشركةللصنفToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("إضافةشركةللصنفToolStripMenuItem.Image")));
            this.إضافةشركةللصنفToolStripMenuItem.Name = "إضافةشركةللصنفToolStripMenuItem";
            this.إضافةشركةللصنفToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.إضافةشركةللصنفToolStripMenuItem.Text = "إضافة شركة للصنف";
            this.إضافةشركةللصنفToolStripMenuItem.Click += new System.EventHandler(this.إضافةشركةللصنفToolStripMenuItem_Click);
            // 
            // إضافةمكانللصنفToolStripMenuItem
            // 
            this.إضافةمكانللصنفToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("إضافةمكانللصنفToolStripMenuItem.Image")));
            this.إضافةمكانللصنفToolStripMenuItem.Name = "إضافةمكانللصنفToolStripMenuItem";
            this.إضافةمكانللصنفToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.إضافةمكانللصنفToolStripMenuItem.Text = "إضافة مكان للصنف";
            this.إضافةمكانللصنفToolStripMenuItem.Click += new System.EventHandler(this.إضافةمكانللصنفToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(137, 6);
            // 
            // طباعةالصنفToolStripMenuItem
            // 
            this.طباعةالصنفToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("طباعةالصنفToolStripMenuItem.Image")));
            this.طباعةالصنفToolStripMenuItem.Name = "طباعةالصنفToolStripMenuItem";
            this.طباعةالصنفToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.طباعةالصنفToolStripMenuItem.Text = "طباعة الصنف";
            this.طباعةالصنفToolStripMenuItem.Click += new System.EventHandler(this.طباعةالصنفToolStripMenuItem_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Appearance.Options.UseFont = true;
            this.BtnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.ImageOptions.Image")));
            this.BtnClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(1064, 442);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(143, 52);
            this.BtnClose.TabIndex = 18;
            this.BtnClose.Text = "إغلاق";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Status);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.SearchUsers);
            this.groupBox1.Controls.Add(this.DGV_Items);
            this.groupBox1.Location = new System.Drawing.Point(14, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1042, 488);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الاصناف";
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.Color.Maroon;
            this.Status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Status.ForeColor = System.Drawing.Color.Cornsilk;
            this.Status.Location = new System.Drawing.Point(-145, 3);
            this.Status.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(141, 40);
            this.Status.TabIndex = 21;
            this.Status.Text = "الفاتورة غير مضافة";
            this.Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.simpleButton1.Location = new System.Drawing.Point(914, 22);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(40, 36);
            this.simpleButton1.TabIndex = 19;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.Appearance.Options.UseFont = true;
            this.BtnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.ImageOptions.Image")));
            this.BtnEdit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnEdit.Location = new System.Drawing.Point(1064, 89);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(143, 52);
            this.BtnEdit.TabIndex = 16;
            this.BtnEdit.Text = "تعديل صنف";
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Appearance.Options.UseFont = true;
            this.BtnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.ImageOptions.Image")));
            this.BtnAdd.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnAdd.Location = new System.Drawing.Point(1064, 31);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(143, 52);
            this.BtnAdd.TabIndex = 15;
            this.BtnAdd.Text = "إضافة صنف";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDel.Appearance.Options.UseFont = true;
            this.BtnDel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDel.ImageOptions.Image")));
            this.BtnDel.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnDel.Location = new System.Drawing.Point(1064, 147);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(143, 52);
            this.BtnDel.TabIndex = 17;
            this.BtnDel.Text = "حذف صنف";
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnAddCompany
            // 
            this.BtnAddCompany.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold);
            this.BtnAddCompany.Appearance.Options.UseFont = true;
            this.BtnAddCompany.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddCompany.ImageOptions.Image")));
            this.BtnAddCompany.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnAddCompany.Location = new System.Drawing.Point(1064, 268);
            this.BtnAddCompany.Name = "BtnAddCompany";
            this.BtnAddCompany.Size = new System.Drawing.Size(143, 43);
            this.BtnAddCompany.TabIndex = 20;
            this.BtnAddCompany.Text = "إضافة شركة للصنف";
            this.BtnAddCompany.Click += new System.EventHandler(this.BtnAddCompany_Click);
            // 
            // BtnPreview
            // 
            this.BtnPreview.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold);
            this.BtnPreview.Appearance.Options.UseFont = true;
            this.BtnPreview.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnPreview.ImageOptions.Image")));
            this.BtnPreview.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnPreview.Location = new System.Drawing.Point(1064, 217);
            this.BtnPreview.Name = "BtnPreview";
            this.BtnPreview.Size = new System.Drawing.Size(143, 45);
            this.BtnPreview.TabIndex = 19;
            this.BtnPreview.Text = "معاينة الصنف";
            this.BtnPreview.Click += new System.EventHandler(this.BtnPreview_Click);
            // 
            // BtnAddPlace
            // 
            this.BtnAddPlace.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold);
            this.BtnAddPlace.Appearance.Options.UseFont = true;
            this.BtnAddPlace.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddPlace.ImageOptions.Image")));
            this.BtnAddPlace.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnAddPlace.Location = new System.Drawing.Point(1064, 317);
            this.BtnAddPlace.Name = "BtnAddPlace";
            this.BtnAddPlace.Size = new System.Drawing.Size(143, 43);
            this.BtnAddPlace.TabIndex = 20;
            this.BtnAddPlace.Text = "إضافة مكان للصنف";
            this.BtnAddPlace.Click += new System.EventHandler(this.BtnAddPlace_Click);
            // 
            // Frm_Items
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 501);
            this.Controls.Add(this.BtnPreview);
            this.Controls.Add(this.BtnAddPlace);
            this.Controls.Add(this.BtnAddCompany);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.BtnPintAll);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnDel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Items";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لوحة التحكم بالاصناف";
            this.Load += new System.EventHandler(this.Frm_Items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SearchUsers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Items)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnPrint;
        private DevExpress.XtraEditors.SimpleButton BtnPintAll;
        private DevExpress.XtraEditors.SearchControl SearchUsers;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton BtnEdit;
        private DevExpress.XtraEditors.SimpleButton BtnAdd;
        private DevExpress.XtraEditors.SimpleButton BtnDel;
        private DevExpress.XtraEditors.SimpleButton BtnAddCompany;
        private DevExpress.XtraEditors.SimpleButton BtnPreview;
        private DevExpress.XtraEditors.SimpleButton BtnAddPlace;
        public System.Windows.Forms.DataGridView DGV_Items;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem تعديلالصنفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفالصنفToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem معاينةالصنفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem إضافةشركةللصنفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem إضافةمكانللصنفToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem طباعةالصنفToolStripMenuItem;
    }
}