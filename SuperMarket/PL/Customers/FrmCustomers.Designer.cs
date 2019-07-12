namespace SuperMarket.PL.Customers
{
    partial class FrmCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomers));
            this.SinglePrint = new DevExpress.XtraEditors.SimpleButton();
            this.AllPrint = new DevExpress.XtraEditors.SimpleButton();
            this.UserName = new DevExpress.XtraEditors.TextEdit();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtNotes = new DevExpress.XtraEditors.MemoEdit();
            this.TxtAddress = new DevExpress.XtraEditors.MemoEdit();
            this.DateSupp = new DevExpress.XtraEditors.DateEdit();
            this.SearchUsers = new DevExpress.XtraEditors.SearchControl();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.DGV_Cust = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.تعديلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.طباعةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtCompany = new DevExpress.XtraEditors.TextEdit();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.debit = new DevExpress.XtraEditors.TextEdit();
            this.credit = new DevExpress.XtraEditors.TextEdit();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtT = new DevExpress.XtraEditors.TextEdit();
            this.TxtPhone = new DevExpress.XtraEditors.TextEdit();
            this.TxtF = new DevExpress.XtraEditors.TextEdit();
            this.TxtCusName = new DevExpress.XtraEditors.TextEdit();
            this.TxtE = new DevExpress.XtraEditors.TextEdit();
            this.TxtCusId = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDel = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNew = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.UserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNotes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateSupp.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateSupp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchUsers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Cust)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCompany.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.debit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCusName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCusId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // SinglePrint
            // 
            this.SinglePrint.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold);
            this.SinglePrint.Appearance.Options.UseFont = true;
            this.SinglePrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SinglePrint.ImageOptions.Image")));
            this.SinglePrint.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.SinglePrint.Location = new System.Drawing.Point(1038, 270);
            this.SinglePrint.Name = "SinglePrint";
            this.SinglePrint.Size = new System.Drawing.Size(116, 32);
            this.SinglePrint.TabIndex = 19;
            this.SinglePrint.Text = "طباعة محدد";
            this.SinglePrint.Click += new System.EventHandler(this.SinglePrint_Click);
            // 
            // AllPrint
            // 
            this.AllPrint.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold);
            this.AllPrint.Appearance.Options.UseFont = true;
            this.AllPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("AllPrint.ImageOptions.Image")));
            this.AllPrint.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.AllPrint.Location = new System.Drawing.Point(1038, 308);
            this.AllPrint.Name = "AllPrint";
            this.AllPrint.Size = new System.Drawing.Size(116, 30);
            this.AllPrint.TabIndex = 20;
            this.AllPrint.Text = "طباعة الكل";
            this.AllPrint.Click += new System.EventHandler(this.AllPrint_Click);
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(416, 372);
            this.UserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserName.Name = "UserName";
            this.UserName.Properties.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.UserName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.UserName.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.UserName.Properties.Appearance.Options.UseBackColor = true;
            this.UserName.Properties.Appearance.Options.UseFont = true;
            this.UserName.Properties.Appearance.Options.UseForeColor = true;
            this.UserName.Properties.Appearance.Options.UseTextOptions = true;
            this.UserName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UserName.Properties.ReadOnly = true;
            this.UserName.Size = new System.Drawing.Size(501, 18);
            this.UserName.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label14.Location = new System.Drawing.Point(927, 373);
            this.label14.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "إسم المستخدم :";
            // 
            // TxtNotes
            // 
            this.TxtNotes.EditValue = "أكتب هنا .....";
            this.TxtNotes.Location = new System.Drawing.Point(416, 205);
            this.TxtNotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.TxtNotes.Properties.Appearance.Options.UseFont = true;
            this.TxtNotes.Size = new System.Drawing.Size(187, 82);
            this.TxtNotes.TabIndex = 9;
            this.TxtNotes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNotes_KeyDown);
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(730, 205);
            this.TxtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.TxtAddress.Properties.Appearance.Options.UseFont = true;
            this.TxtAddress.Size = new System.Drawing.Size(187, 82);
            this.TxtAddress.TabIndex = 4;
            this.TxtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtAddress_KeyDown);
            // 
            // DateSupp
            // 
            this.DateSupp.EditValue = new System.DateTime(2017, 6, 17, 16, 34, 29, 475);
            this.DateSupp.Location = new System.Drawing.Point(730, 58);
            this.DateSupp.Name = "DateSupp";
            this.DateSupp.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.DateSupp.Properties.Appearance.Options.UseFont = true;
            this.DateSupp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateSupp.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateSupp.Size = new System.Drawing.Size(187, 20);
            this.DateSupp.TabIndex = 0;
            // 
            // SearchUsers
            // 
            this.SearchUsers.Location = new System.Drawing.Point(8, 22);
            this.SearchUsers.Name = "SearchUsers";
            this.SearchUsers.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.SearchUsers.Properties.Appearance.Options.UseFont = true;
            this.SearchUsers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.SearchUsers.Size = new System.Drawing.Size(401, 20);
            this.SearchUsers.TabIndex = 14;
            this.SearchUsers.TextChanged += new System.EventHandler(this.SearchUsers_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(918, 202);
            this.label16.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(11, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(918, 132);
            this.label13.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "*";
            // 
            // DGV_Cust
            // 
            this.DGV_Cust.AllowUserToAddRows = false;
            this.DGV_Cust.AllowUserToDeleteRows = false;
            this.DGV_Cust.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Cust.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV_Cust.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DGV_Cust.ColumnHeadersHeight = 30;
            this.DGV_Cust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_Cust.ContextMenuStrip = this.contextMenuStrip1;
            this.DGV_Cust.Location = new System.Drawing.Point(8, 54);
            this.DGV_Cust.MultiSelect = false;
            this.DGV_Cust.Name = "DGV_Cust";
            this.DGV_Cust.ReadOnly = true;
            this.DGV_Cust.RowHeadersVisible = false;
            this.DGV_Cust.RowHeadersWidth = 60;
            this.DGV_Cust.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Cust.Size = new System.Drawing.Size(401, 342);
            this.DGV_Cust.TabIndex = 6;
            this.DGV_Cust.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Cust_CellDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعديلToolStripMenuItem,
            this.حذفToolStripMenuItem,
            this.طباعةToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(105, 70);
            // 
            // تعديلToolStripMenuItem
            // 
            this.تعديلToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("تعديلToolStripMenuItem.Image")));
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.تعديلToolStripMenuItem.Text = "تعديل";
            this.تعديلToolStripMenuItem.Click += new System.EventHandler(this.تعديلToolStripMenuItem_Click);
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(918, 95);
            this.label12.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "*";
            // 
            // TxtCompany
            // 
            this.TxtCompany.EditValue = "لايوجد";
            this.TxtCompany.Location = new System.Drawing.Point(416, 165);
            this.TxtCompany.Name = "TxtCompany";
            this.TxtCompany.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TxtCompany.Properties.Appearance.Options.UseFont = true;
            this.TxtCompany.Size = new System.Drawing.Size(501, 20);
            this.TxtCompany.TabIndex = 3;
            this.TxtCompany.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCompany_KeyDown);
            // 
            // BtnClose
            // 
            this.BtnClose.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Appearance.Options.UseFont = true;
            this.BtnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.ImageOptions.Image")));
            this.BtnClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(1038, 344);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(116, 52);
            this.BtnClose.TabIndex = 18;
            this.BtnClose.Text = "إغلاق";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.debit);
            this.groupBox1.Controls.Add(this.credit);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.UserName);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.TxtNotes);
            this.groupBox1.Controls.Add(this.TxtAddress);
            this.groupBox1.Controls.Add(this.DateSupp);
            this.groupBox1.Controls.Add(this.SearchUsers);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.DGV_Cust);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.TxtCompany);
            this.groupBox1.Controls.Add(this.TxtT);
            this.groupBox1.Controls.Add(this.TxtPhone);
            this.groupBox1.Controls.Add(this.TxtF);
            this.groupBox1.Controls.Add(this.TxtCusName);
            this.groupBox1.Controls.Add(this.TxtE);
            this.groupBox1.Controls.Add(this.TxtCusId);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1016, 407);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات العميل او الزبون";
            // 
            // debit
            // 
            this.debit.EditValue = "0";
            this.debit.Location = new System.Drawing.Point(416, 295);
            this.debit.Name = "debit";
            this.debit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.debit.Properties.Appearance.Options.UseFont = true;
            this.debit.Size = new System.Drawing.Size(187, 20);
            this.debit.TabIndex = 26;
            // 
            // credit
            // 
            this.credit.EditValue = "0";
            this.credit.Location = new System.Drawing.Point(730, 295);
            this.credit.Name = "credit";
            this.credit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.credit.Properties.Appearance.Options.UseFont = true;
            this.credit.Size = new System.Drawing.Size(187, 20);
            this.credit.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(613, 301);
            this.label15.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "دائن/له :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(926, 301);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "مدين/عليه :";
            // 
            // TxtT
            // 
            this.TxtT.EditValue = "تويتر";
            this.TxtT.Location = new System.Drawing.Point(416, 95);
            this.TxtT.Name = "TxtT";
            this.TxtT.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TxtT.Properties.Appearance.Options.UseFont = true;
            this.TxtT.Size = new System.Drawing.Size(187, 20);
            this.TxtT.TabIndex = 6;
            this.TxtT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtT_KeyDown);
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(730, 129);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TxtPhone.Properties.Appearance.Options.UseFont = true;
            this.TxtPhone.Size = new System.Drawing.Size(187, 20);
            this.TxtPhone.TabIndex = 2;
            this.TxtPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPhone_KeyDown);
            // 
            // TxtF
            // 
            this.TxtF.EditValue = "فيس بوك";
            this.TxtF.Location = new System.Drawing.Point(416, 58);
            this.TxtF.Name = "TxtF";
            this.TxtF.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TxtF.Properties.Appearance.Options.UseFont = true;
            this.TxtF.Size = new System.Drawing.Size(187, 20);
            this.TxtF.TabIndex = 5;
            this.TxtF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtF_KeyDown);
            // 
            // TxtCusName
            // 
            this.TxtCusName.Location = new System.Drawing.Point(730, 92);
            this.TxtCusName.Name = "TxtCusName";
            this.TxtCusName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TxtCusName.Properties.Appearance.Options.UseFont = true;
            this.TxtCusName.Size = new System.Drawing.Size(187, 20);
            this.TxtCusName.TabIndex = 1;
            this.TxtCusName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCusName_KeyDown);
            // 
            // TxtE
            // 
            this.TxtE.EditValue = "البريد الالكترونى";
            this.TxtE.Location = new System.Drawing.Point(416, 129);
            this.TxtE.Name = "TxtE";
            this.TxtE.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TxtE.Properties.Appearance.Options.UseFont = true;
            this.TxtE.Size = new System.Drawing.Size(187, 20);
            this.TxtE.TabIndex = 8;
            this.TxtE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtE_KeyDown);
            // 
            // TxtCusId
            // 
            this.TxtCusId.Location = new System.Drawing.Point(511, 22);
            this.TxtCusId.Name = "TxtCusId";
            this.TxtCusId.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TxtCusId.Properties.Appearance.Options.UseFont = true;
            this.TxtCusId.Size = new System.Drawing.Size(273, 20);
            this.TxtCusId.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(927, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "تاريخ التسجيل :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(613, 132);
            this.label11.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "البريد الالكترونى :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(826, 29);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "يرجي ملئ كافة البيانات الموجودة .";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(927, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "العنوان :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(614, 208);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "ملاحظات :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(613, 95);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "تويتر :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(926, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "الشركة :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(613, 58);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "الفيس بوك :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(927, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "الهاتف :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(927, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "إسم العميل : ";
            // 
            // BtnEdit
            // 
            this.BtnEdit.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.Appearance.Options.UseFont = true;
            this.BtnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.ImageOptions.Image")));
            this.BtnEdit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnEdit.Location = new System.Drawing.Point(1038, 154);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(116, 52);
            this.BtnEdit.TabIndex = 16;
            this.BtnEdit.Text = "تعديل";
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Appearance.Options.UseFont = true;
            this.BtnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.ImageOptions.Image")));
            this.BtnAdd.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnAdd.Location = new System.Drawing.Point(1038, 98);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(116, 52);
            this.BtnAdd.TabIndex = 15;
            this.BtnAdd.Text = "إضافة العميل";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDel.Appearance.Options.UseFont = true;
            this.BtnDel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDel.ImageOptions.Image")));
            this.BtnDel.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnDel.Location = new System.Drawing.Point(1038, 212);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(116, 52);
            this.BtnDel.TabIndex = 17;
            this.BtnDel.Text = "حذف";
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNew.Appearance.Options.UseFont = true;
            this.BtnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnNew.ImageOptions.Image")));
            this.BtnNew.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnNew.Location = new System.Drawing.Point(1038, 40);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(116, 52);
            this.BtnNew.TabIndex = 14;
            this.BtnNew.Text = "عميل جديد";
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // FrmCustomers
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 449);
            this.Controls.Add(this.SinglePrint);
            this.Controls.Add(this.AllPrint);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.BtnNew);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCustomers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة العملاء";
            ((System.ComponentModel.ISupportInitialize)(this.UserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNotes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateSupp.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateSupp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchUsers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Cust)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtCompany.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.debit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.credit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCusName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCusId.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton SinglePrint;
        private DevExpress.XtraEditors.SimpleButton AllPrint;
        private DevExpress.XtraEditors.TextEdit UserName;
        private System.Windows.Forms.Label label14;
        private DevExpress.XtraEditors.MemoEdit TxtNotes;
        private DevExpress.XtraEditors.MemoEdit TxtAddress;
        private DevExpress.XtraEditors.DateEdit DateSupp;
        private DevExpress.XtraEditors.SearchControl SearchUsers;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView DGV_Cust;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.TextEdit TxtCompany;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit TxtT;
        private DevExpress.XtraEditors.TextEdit TxtPhone;
        private DevExpress.XtraEditors.TextEdit TxtF;
        private DevExpress.XtraEditors.TextEdit TxtCusName;
        private DevExpress.XtraEditors.TextEdit TxtE;
        private DevExpress.XtraEditors.TextEdit TxtCusId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton BtnEdit;
        private DevExpress.XtraEditors.SimpleButton BtnAdd;
        private DevExpress.XtraEditors.SimpleButton BtnDel;
        private DevExpress.XtraEditors.SimpleButton BtnNew;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem تعديلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem طباعةToolStripMenuItem;
        private DevExpress.XtraEditors.TextEdit debit;
        private DevExpress.XtraEditors.TextEdit credit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
    }
}