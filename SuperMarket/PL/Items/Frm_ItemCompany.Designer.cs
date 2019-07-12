namespace SuperMarket.PL.Items
{
    partial class Frm_ItemCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ItemCompany));
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.SearchUsers = new DevExpress.XtraEditors.SearchControl();
            this.DGV_company = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.حذفهذاالسطرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.تعديلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDel = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtItemCompany = new DevExpress.XtraEditors.TextEdit();
            this.TxtPhone = new DevExpress.XtraEditors.TextEdit();
            this.TxtItemId = new DevExpress.XtraEditors.TextEdit();
            this.Txtadress = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchUsers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_company)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtItemCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtItemId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtadress.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Appearance.Options.UseFont = true;
            this.BtnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.ImageOptions.Image")));
            this.BtnClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(634, 417);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(143, 52);
            this.BtnClose.TabIndex = 25;
            this.BtnClose.Text = "إغلاق";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.SearchUsers);
            this.groupBox1.Controls.Add(this.DGV_company);
            this.groupBox1.Location = new System.Drawing.Point(14, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(763, 293);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات شركات الاصناف";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.simpleButton1.Location = new System.Drawing.Point(709, 25);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(40, 36);
            this.simpleButton1.TabIndex = 19;
            // 
            // SearchUsers
            // 
            this.SearchUsers.Location = new System.Drawing.Point(8, 32);
            this.SearchUsers.Name = "SearchUsers";
            this.SearchUsers.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.SearchUsers.Properties.Appearance.Options.UseFont = true;
            this.SearchUsers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.SearchUsers.Size = new System.Drawing.Size(695, 20);
            this.SearchUsers.TabIndex = 14;
            this.SearchUsers.TextChanged += new System.EventHandler(this.SearchUsers_TextChanged);
            // 
            // DGV_company
            // 
            this.DGV_company.AllowUserToAddRows = false;
            this.DGV_company.AllowUserToDeleteRows = false;
            this.DGV_company.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_company.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV_company.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DGV_company.ColumnHeadersHeight = 30;
            this.DGV_company.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_company.ContextMenuStrip = this.contextMenuStrip1;
            this.DGV_company.Location = new System.Drawing.Point(8, 64);
            this.DGV_company.MultiSelect = false;
            this.DGV_company.Name = "DGV_company";
            this.DGV_company.ReadOnly = true;
            this.DGV_company.RowHeadersVisible = false;
            this.DGV_company.RowHeadersWidth = 60;
            this.DGV_company.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_company.Size = new System.Drawing.Size(741, 215);
            this.DGV_company.TabIndex = 6;
            this.DGV_company.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_company_CellDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.حذفهذاالسطرToolStripMenuItem,
            this.toolStripSeparator2,
            this.تعديلToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 54);
            // 
            // حذفهذاالسطرToolStripMenuItem
            // 
            this.حذفهذاالسطرToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("حذفهذاالسطرToolStripMenuItem.Image")));
            this.حذفهذاالسطرToolStripMenuItem.Name = "حذفهذاالسطرToolStripMenuItem";
            this.حذفهذاالسطرToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.حذفهذاالسطرToolStripMenuItem.Text = "حذف ";
            this.حذفهذاالسطرToolStripMenuItem.Click += new System.EventHandler(this.حذفهذاالسطرToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(97, 6);
            // 
            // تعديلToolStripMenuItem
            // 
            this.تعديلToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("تعديلToolStripMenuItem.Image")));
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.تعديلToolStripMenuItem.Text = "تعديل";
            this.تعديلToolStripMenuItem.Click += new System.EventHandler(this.تعديلToolStripMenuItem_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.Appearance.Options.UseFont = true;
            this.BtnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.ImageOptions.Image")));
            this.BtnEdit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnEdit.Location = new System.Drawing.Point(194, 417);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(143, 52);
            this.BtnEdit.TabIndex = 23;
            this.BtnEdit.Text = "تعديل ";
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Appearance.Options.UseFont = true;
            this.BtnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.ImageOptions.Image")));
            this.BtnAdd.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnAdd.Location = new System.Drawing.Point(14, 417);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(164, 52);
            this.BtnAdd.TabIndex = 22;
            this.BtnAdd.Text = "إضافة شركة جديدة";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDel.Appearance.Options.UseFont = true;
            this.BtnDel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDel.ImageOptions.Image")));
            this.BtnDel.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnDel.Location = new System.Drawing.Point(343, 417);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(143, 52);
            this.BtnDel.TabIndex = 24;
            this.BtnDel.Text = "حذف ";
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtItemCompany);
            this.groupBox2.Controls.Add(this.TxtPhone);
            this.groupBox2.Controls.Add(this.TxtItemId);
            this.groupBox2.Controls.Add(this.Txtadress);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(14, 294);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(763, 112);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // TxtItemCompany
            // 
            this.TxtItemCompany.Location = new System.Drawing.Point(410, 66);
            this.TxtItemCompany.Name = "TxtItemCompany";
            this.TxtItemCompany.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TxtItemCompany.Properties.Appearance.Options.UseFont = true;
            this.TxtItemCompany.Size = new System.Drawing.Size(262, 20);
            this.TxtItemCompany.TabIndex = 47;
            this.TxtItemCompany.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtItemCompany_KeyDown);
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(8, 32);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TxtPhone.Properties.Appearance.Options.UseFont = true;
            this.TxtPhone.Size = new System.Drawing.Size(288, 20);
            this.TxtPhone.TabIndex = 45;
            this.TxtPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPhone_KeyDown);
            // 
            // TxtItemId
            // 
            this.TxtItemId.Location = new System.Drawing.Point(546, 32);
            this.TxtItemId.Name = "TxtItemId";
            this.TxtItemId.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TxtItemId.Properties.Appearance.Options.UseFont = true;
            this.TxtItemId.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtItemId.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TxtItemId.Properties.ReadOnly = true;
            this.TxtItemId.Size = new System.Drawing.Size(126, 20);
            this.TxtItemId.TabIndex = 46;
            // 
            // Txtadress
            // 
            this.Txtadress.Location = new System.Drawing.Point(8, 66);
            this.Txtadress.Name = "Txtadress";
            this.Txtadress.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Txtadress.Properties.Appearance.Options.UseFont = true;
            this.Txtadress.Size = new System.Drawing.Size(288, 20);
            this.Txtadress.TabIndex = 44;
            this.Txtadress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtadress_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(306, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "العنوان :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(306, 35);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "الهاتف :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(682, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "إسم الشركة :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(682, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "رقم الصنف :";
            // 
            // Frm_ItemCompany
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ItemCompany";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لوحة تحكم  شركات الاصناف";
            this.Load += new System.EventHandler(this.Frm_ItemCompany_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SearchUsers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_company)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtItemCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtItemId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtadress.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SearchControl SearchUsers;
        public System.Windows.Forms.DataGridView DGV_company;
        private System.Windows.Forms.GroupBox groupBox2;
        public DevExpress.XtraEditors.TextEdit TxtItemCompany;
        public DevExpress.XtraEditors.TextEdit TxtPhone;
        public DevExpress.XtraEditors.TextEdit TxtItemId;
        public DevExpress.XtraEditors.TextEdit Txtadress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public DevExpress.XtraEditors.SimpleButton BtnClose;
        public DevExpress.XtraEditors.SimpleButton BtnEdit;
        public DevExpress.XtraEditors.SimpleButton BtnAdd;
        public DevExpress.XtraEditors.SimpleButton BtnDel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem حذفهذاالسطرToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem تعديلToolStripMenuItem;
    }
}