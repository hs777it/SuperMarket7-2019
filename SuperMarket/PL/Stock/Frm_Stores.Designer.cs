namespace SuperMarket.PL.Store
{
    partial class Frm_Stores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Stores));
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDel = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNew = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchStores = new DevExpress.XtraEditors.SearchControl();
            this.Dgv_Stores = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.تعديلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtSoreId = new DevExpress.XtraEditors.TextEdit();
            this.TxtStoreAdress = new DevExpress.XtraEditors.TextEdit();
            this.TxtStoreName = new DevExpress.XtraEditors.TextEdit();
            this.TxtUser = new DevExpress.XtraEditors.TextEdit();
            this.TxtStoreAdmin = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchStores.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Stores)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSoreId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStoreAdress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStoreName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStoreAdmin.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Appearance.Options.UseFont = true;
            this.BtnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.ImageOptions.Image")));
            this.BtnClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(559, 242);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(116, 52);
            this.BtnClose.TabIndex = 5;
            this.BtnClose.Text = "إغلاق";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDel.Appearance.Options.UseFont = true;
            this.BtnDel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDel.ImageOptions.Image")));
            this.BtnDel.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnDel.Location = new System.Drawing.Point(559, 184);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(116, 52);
            this.BtnDel.TabIndex = 4;
            this.BtnDel.Text = "حذف";
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.Appearance.Options.UseFont = true;
            this.BtnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.ImageOptions.Image")));
            this.BtnEdit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnEdit.Location = new System.Drawing.Point(559, 126);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(116, 52);
            this.BtnEdit.TabIndex = 3;
            this.BtnEdit.Text = "تعديل";
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Appearance.Options.UseFont = true;
            this.BtnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.ImageOptions.Image")));
            this.BtnAdd.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnAdd.Location = new System.Drawing.Point(559, 70);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(116, 52);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "إضافة";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNew.Appearance.Options.UseFont = true;
            this.BtnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnNew.ImageOptions.Image")));
            this.BtnNew.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnNew.Location = new System.Drawing.Point(559, 12);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(116, 52);
            this.BtnNew.TabIndex = 1;
            this.BtnNew.Text = "جديد";
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchStores);
            this.groupBox1.Controls.Add(this.Dgv_Stores);
            this.groupBox1.Controls.Add(this.TxtSoreId);
            this.groupBox1.Controls.Add(this.TxtStoreAdress);
            this.groupBox1.Controls.Add(this.TxtStoreName);
            this.groupBox1.Controls.Add(this.TxtUser);
            this.groupBox1.Controls.Add(this.TxtStoreAdmin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(521, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "أدخل بيانات المخزن";
            // 
            // SearchStores
            // 
            this.SearchStores.Location = new System.Drawing.Point(8, 15);
            this.SearchStores.Name = "SearchStores";
            this.SearchStores.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.SearchStores.Properties.Appearance.Options.UseFont = true;
            this.SearchStores.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.SearchStores.Size = new System.Drawing.Size(188, 20);
            this.SearchStores.TabIndex = 5;
            this.SearchStores.TextChanged += new System.EventHandler(this.SearchStores_TextChanged);
            // 
            // Dgv_Stores
            // 
            this.Dgv_Stores.AllowUserToAddRows = false;
            this.Dgv_Stores.AllowUserToDeleteRows = false;
            this.Dgv_Stores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Stores.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Dgv_Stores.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.Dgv_Stores.ContextMenuStrip = this.contextMenuStrip1;
            this.Dgv_Stores.Location = new System.Drawing.Point(8, 49);
            this.Dgv_Stores.MultiSelect = false;
            this.Dgv_Stores.Name = "Dgv_Stores";
            this.Dgv_Stores.ReadOnly = true;
            this.Dgv_Stores.RowHeadersVisible = false;
            this.Dgv_Stores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Stores.Size = new System.Drawing.Size(188, 233);
            this.Dgv_Stores.TabIndex = 6;
            this.Dgv_Stores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Stores_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعديلToolStripMenuItem,
            this.حذفToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
            // 
            // تعديلToolStripMenuItem
            // 
            this.تعديلToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("تعديلToolStripMenuItem.Image")));
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.تعديلToolStripMenuItem.Text = "تعديل";
            this.تعديلToolStripMenuItem.Click += new System.EventHandler(this.تعديلToolStripMenuItem_Click);
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("حذفToolStripMenuItem.Image")));
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.حذفToolStripMenuItem.Text = "حذف";
            this.حذفToolStripMenuItem.Click += new System.EventHandler(this.حذفToolStripMenuItem_Click);
            // 
            // TxtSoreId
            // 
            this.TxtSoreId.Location = new System.Drawing.Point(202, 66);
            this.TxtSoreId.Name = "TxtSoreId";
            this.TxtSoreId.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TxtSoreId.Properties.Appearance.Options.UseFont = true;
            this.TxtSoreId.Properties.ReadOnly = true;
            this.TxtSoreId.Size = new System.Drawing.Size(187, 20);
            this.TxtSoreId.TabIndex = 0;
            // 
            // TxtStoreAdress
            // 
            this.TxtStoreAdress.Location = new System.Drawing.Point(202, 135);
            this.TxtStoreAdress.Name = "TxtStoreAdress";
            this.TxtStoreAdress.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TxtStoreAdress.Properties.Appearance.Options.UseFont = true;
            this.TxtStoreAdress.Size = new System.Drawing.Size(187, 20);
            this.TxtStoreAdress.TabIndex = 2;
            this.TxtStoreAdress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtStoreAdress_KeyDown);
            // 
            // TxtStoreName
            // 
            this.TxtStoreName.Location = new System.Drawing.Point(202, 101);
            this.TxtStoreName.Name = "TxtStoreName";
            this.TxtStoreName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TxtStoreName.Properties.Appearance.Options.UseFont = true;
            this.TxtStoreName.Size = new System.Drawing.Size(187, 20);
            this.TxtStoreName.TabIndex = 1;
            this.TxtStoreName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtStoreName_KeyDown);
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(202, 207);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TxtUser.Properties.Appearance.Options.UseFont = true;
            this.TxtUser.Properties.ReadOnly = true;
            this.TxtUser.Size = new System.Drawing.Size(187, 20);
            this.TxtUser.TabIndex = 4;
            // 
            // TxtStoreAdmin
            // 
            this.TxtStoreAdmin.Location = new System.Drawing.Point(202, 173);
            this.TxtStoreAdmin.Name = "TxtStoreAdmin";
            this.TxtStoreAdmin.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TxtStoreAdmin.Properties.Appearance.Options.UseFont = true;
            this.TxtStoreAdmin.Size = new System.Drawing.Size(187, 20);
            this.TxtStoreAdmin.TabIndex = 3;
            this.TxtStoreAdmin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtStoreAdmin_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "مستخدم النظام :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(331, 29);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "يرجي ملئ كافة البيانات الموجودة .";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(398, 180);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "المشرف المسئول :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "عنوان المخزن :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "إسم المخزن :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "رقم المخزن :";
            // 
            // Frm_Stores
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 304);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Stores";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة المخازن";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchStores.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Stores)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtSoreId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStoreAdress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStoreName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStoreAdmin.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private DevExpress.XtraEditors.SimpleButton BtnDel;
        private DevExpress.XtraEditors.SimpleButton BtnEdit;
        private DevExpress.XtraEditors.SimpleButton BtnAdd;
        private DevExpress.XtraEditors.SimpleButton BtnNew;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SearchControl SearchStores;
        private System.Windows.Forms.DataGridView Dgv_Stores;
        private DevExpress.XtraEditors.TextEdit TxtSoreId;
        private DevExpress.XtraEditors.TextEdit TxtStoreAdress;
        private DevExpress.XtraEditors.TextEdit TxtStoreName;
        private DevExpress.XtraEditors.TextEdit TxtUser;
        private DevExpress.XtraEditors.TextEdit TxtStoreAdmin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem تعديلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
    }
}