namespace SuperMarket.PL.Places
{
    partial class Frm_Places
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Places));
            this.TxtItemId = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.SearchUsers = new DevExpress.XtraEditors.SearchControl();
            this.DGV_Places = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.تعديلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CmbPlaces = new DevExpress.XtraEditors.ComboBoxEdit();
            this.CmbStand = new DevExpress.XtraEditors.ComboBoxEdit();
            this.CmbFloar = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnDel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TxtItemId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchUsers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Places)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbPlaces.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbStand.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbFloar.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtItemId
            // 
            this.TxtItemId.Location = new System.Drawing.Point(546, 32);
            this.TxtItemId.Name = "TxtItemId";
            this.TxtItemId.Properties.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F);
            this.TxtItemId.Properties.Appearance.Options.UseFont = true;
            this.TxtItemId.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtItemId.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TxtItemId.Properties.ReadOnly = true;
            this.TxtItemId.Size = new System.Drawing.Size(126, 28);
            this.TxtItemId.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F);
            this.label4.Location = new System.Drawing.Point(306, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 48;
            this.label4.Text = "الاتجاة :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F);
            this.label6.Location = new System.Drawing.Point(306, 35);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 21);
            this.label6.TabIndex = 49;
            this.label6.Text = "الستاند :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F);
            this.label3.Location = new System.Drawing.Point(682, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 50;
            this.label3.Text = "الطابق :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F);
            this.label2.Location = new System.Drawing.Point(682, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 51;
            this.label2.Text = "رقم الصنف :";
            // 
            // BtnClose
            // 
            this.BtnClose.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Appearance.Options.UseFont = true;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(634, 421);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(143, 52);
            this.BtnClose.TabIndex = 31;
            this.BtnClose.Text = "إغلاق";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.Appearance.Options.UseFont = true;
            this.BtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.Image")));
            this.BtnEdit.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnEdit.Location = new System.Drawing.Point(194, 421);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(143, 52);
            this.BtnEdit.TabIndex = 29;
            this.BtnEdit.Text = "تعديل مكان ";
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Appearance.Options.UseFont = true;
            this.BtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.Image")));
            this.BtnAdd.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnAdd.Location = new System.Drawing.Point(14, 421);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(164, 52);
            this.BtnAdd.TabIndex = 28;
            this.BtnAdd.Text = "إضافة مكان جديد";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 6F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.simpleButton1.Location = new System.Drawing.Point(709, 25);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(40, 36);
            this.simpleButton1.TabIndex = 19;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // SearchUsers
            // 
            this.SearchUsers.Location = new System.Drawing.Point(8, 32);
            this.SearchUsers.Name = "SearchUsers";
            this.SearchUsers.Properties.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F);
            this.SearchUsers.Properties.Appearance.Options.UseFont = true;
            this.SearchUsers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.SearchUsers.Size = new System.Drawing.Size(695, 28);
            this.SearchUsers.TabIndex = 14;
            this.SearchUsers.TextChanged += new System.EventHandler(this.SearchUsers_TextChanged);
            // 
            // DGV_Places
            // 
            this.DGV_Places.AllowUserToAddRows = false;
            this.DGV_Places.AllowUserToDeleteRows = false;
            this.DGV_Places.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Places.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV_Places.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DGV_Places.ColumnHeadersHeight = 30;
            this.DGV_Places.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_Places.ContextMenuStrip = this.contextMenuStrip1;
            this.DGV_Places.Location = new System.Drawing.Point(8, 64);
            this.DGV_Places.MultiSelect = false;
            this.DGV_Places.Name = "DGV_Places";
            this.DGV_Places.ReadOnly = true;
            this.DGV_Places.RowHeadersVisible = false;
            this.DGV_Places.RowHeadersWidth = 60;
            this.DGV_Places.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Places.Size = new System.Drawing.Size(741, 215);
            this.DGV_Places.TabIndex = 6;
            this.DGV_Places.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Places_CellDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعديلToolStripMenuItem,
            this.حذفToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(100, 48);
            // 
            // تعديلToolStripMenuItem
            // 
            this.تعديلToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("تعديلToolStripMenuItem.Image")));
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.تعديلToolStripMenuItem.Text = "تعديل";
            this.تعديلToolStripMenuItem.Click += new System.EventHandler(this.تعديلToolStripMenuItem_Click);
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("حذفToolStripMenuItem.Image")));
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.حذفToolStripMenuItem.Text = "حذف";
            this.حذفToolStripMenuItem.Click += new System.EventHandler(this.حذفToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtItemId);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.CmbPlaces);
            this.groupBox2.Controls.Add(this.CmbStand);
            this.groupBox2.Controls.Add(this.CmbFloar);
            this.groupBox2.Location = new System.Drawing.Point(14, 298);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(763, 112);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // CmbPlaces
            // 
            this.CmbPlaces.Location = new System.Drawing.Point(34, 66);
            this.CmbPlaces.Name = "CmbPlaces";
            this.CmbPlaces.Properties.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F);
            this.CmbPlaces.Properties.Appearance.Options.UseFont = true;
            this.CmbPlaces.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbPlaces.Properties.Items.AddRange(new object[] {
            "يمين",
            "شمال",
            "وسط",
            "فوق",
            "تحت"});
            this.CmbPlaces.Size = new System.Drawing.Size(262, 28);
            this.CmbPlaces.TabIndex = 47;
            // 
            // CmbStand
            // 
            this.CmbStand.Location = new System.Drawing.Point(34, 32);
            this.CmbStand.Name = "CmbStand";
            this.CmbStand.Properties.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F);
            this.CmbStand.Properties.Appearance.Options.UseFont = true;
            this.CmbStand.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbStand.Properties.Items.AddRange(new object[] {
            "رقم 1",
            "رقم 2",
            "رقم 3",
            "رقم4",
            "رقم 5",
            "رقم 6",
            "رقم 7",
            "رقم8",
            "رقم9",
            "رقم 10",
            "رقم 11",
            "رقم 12",
            "رقم 13",
            "رقم 14",
            "رقم 15",
            "رقم 16",
            "رقم17",
            "رقم 18",
            "رقم19",
            "رقم 20",
            "رقم 21",
            "رقم 22",
            "رقم 23",
            "رقم 24",
            "رقم 25",
            "رقم26",
            "رقم 27",
            "رقم28",
            "رقم 29",
            "رقم 30",
            "رقم31",
            "رقم32",
            "رقم33",
            "رقم34",
            "رقم35",
            "رقم36",
            "رقم37",
            "رقم38",
            "رقم39",
            "رقم40"});
            this.CmbStand.Size = new System.Drawing.Size(262, 28);
            this.CmbStand.TabIndex = 47;
            // 
            // CmbFloar
            // 
            this.CmbFloar.Location = new System.Drawing.Point(410, 66);
            this.CmbFloar.Name = "CmbFloar";
            this.CmbFloar.Properties.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F);
            this.CmbFloar.Properties.Appearance.Options.UseFont = true;
            this.CmbFloar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbFloar.Properties.Items.AddRange(new object[] {
            "الطابق الاول",
            "الطابق الثانى",
            "الطابق الثالث ",
            "الطابق الرابع",
            "الطابق الخامس",
            "الطابق السادس",
            "الطابق السابع",
            "الطابق الثامن",
            "الطابق التاسع",
            "الطابق العاشر",
            "الطابق الاحدى عشر",
            "الطابق الاثنى عشر",
            "الطابق الثالث عشر",
            "الطابق الرابع عشر",
            "الطابق الخامس عشر",
            "الطابق السادس عشر",
            "الطابق السابع عشر",
            "الطابق الثامن عشر",
            "الطابق التاسع عشر",
            "الطابق العشرون"});
            this.CmbFloar.Size = new System.Drawing.Size(262, 28);
            this.CmbFloar.TabIndex = 47;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.SearchUsers);
            this.groupBox1.Controls.Add(this.DGV_Places);
            this.groupBox1.Location = new System.Drawing.Point(14, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(763, 293);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات أماكن الاصناف";
            // 
            // BtnDel
            // 
            this.BtnDel.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDel.Appearance.Options.UseFont = true;
            this.BtnDel.Image = ((System.Drawing.Image)(resources.GetObject("BtnDel.Image")));
            this.BtnDel.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnDel.Location = new System.Drawing.Point(343, 421);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(143, 52);
            this.BtnDel.TabIndex = 30;
            this.BtnDel.Text = "حذف ";
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // Frm_Places
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 483);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnDel);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Places";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لوحة تحكم  اماكن الاصناف";
            this.Load += new System.EventHandler(this.Frm_Places_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtItemId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchUsers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Places)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbPlaces.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbStand.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbFloar.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.TextEdit TxtItemId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public DevExpress.XtraEditors.SimpleButton BtnClose;
        public DevExpress.XtraEditors.SimpleButton BtnEdit;
        public DevExpress.XtraEditors.SimpleButton BtnAdd;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SearchControl SearchUsers;
        public System.Windows.Forms.DataGridView DGV_Places;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.ComboBoxEdit CmbPlaces;
        private DevExpress.XtraEditors.ComboBoxEdit CmbStand;
        private DevExpress.XtraEditors.ComboBoxEdit CmbFloar;
        private System.Windows.Forms.GroupBox groupBox1;
        public DevExpress.XtraEditors.SimpleButton BtnDel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem تعديلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
    }
}