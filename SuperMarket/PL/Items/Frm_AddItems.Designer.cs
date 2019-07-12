namespace SuperMarket.PL.Items
{
    partial class Frm_AddItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AddItems));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnNew = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.BtmClos = new DevExpress.XtraEditors.SimpleButton();
            this.Status = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CmbStock = new System.Windows.Forms.ComboBox();
            this.Cmb_CatID = new System.Windows.Forms.ComboBox();
            this.TxtItemId = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.DateAdded = new DevExpress.XtraEditors.DateEdit();
            this.TxtDiscount = new DevExpress.XtraEditors.TextEdit();
            this.BtnPurList = new DevExpress.XtraEditors.SimpleButton();
            this.TxtQTE = new DevExpress.XtraEditors.TextEdit();
            this.TxtItemName = new DevExpress.XtraEditors.TextEdit();
            this.TxtPurPrice = new DevExpress.XtraEditors.TextEdit();
            this.TxtBarCode = new DevExpress.XtraEditors.TextEdit();
            this.TxtSalePrice = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.DGV_PruChaseOrder = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtItemId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateAdded.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateAdded.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtItemName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPurPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBarCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSalePrice.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PruChaseOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.BtnNew);
            this.groupBox1.Controls.Add(this.BtnEdit);
            this.groupBox1.Controls.Add(this.BtnAdd);
            this.groupBox1.Controls.Add(this.BtnClose);
            this.groupBox1.Controls.Add(this.BtmClos);
            this.groupBox1.Controls.Add(this.Status);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 370);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // BtnNew
            // 
            this.BtnNew.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNew.Appearance.Options.UseFont = true;
            this.BtnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnNew.ImageOptions.Image")));
            this.BtnNew.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnNew.Location = new System.Drawing.Point(299, 19);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(92, 35);
            this.BtnNew.TabIndex = 9;
            this.BtnNew.Text = "جديد";
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.Appearance.Options.UseFont = true;
            this.BtnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.ImageOptions.Image")));
            this.BtnEdit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnEdit.Location = new System.Drawing.Point(201, 20);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(92, 33);
            this.BtnEdit.TabIndex = 21;
            this.BtnEdit.Text = "تعديل ";
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Appearance.Options.UseFont = true;
            this.BtnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.ImageOptions.Image")));
            this.BtnAdd.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnAdd.Location = new System.Drawing.Point(201, 19);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(92, 35);
            this.BtnAdd.TabIndex = 10;
            this.BtnAdd.Text = "حفظ";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Appearance.Options.UseFont = true;
            this.BtnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.ImageOptions.Image")));
            this.BtnClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(12, 14);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(89, 35);
            this.BtnClose.TabIndex = 12;
            this.BtnClose.Text = "إغلاق";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtmClos
            // 
            this.BtmClos.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmClos.Appearance.Options.UseFont = true;
            this.BtmClos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtmClos.ImageOptions.Image")));
            this.BtmClos.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtmClos.Location = new System.Drawing.Point(12, 14);
            this.BtmClos.Name = "BtmClos";
            this.BtmClos.Size = new System.Drawing.Size(89, 35);
            this.BtmClos.TabIndex = 21;
            this.BtmClos.Text = "إغلاق";
            this.BtmClos.Click += new System.EventHandler(this.BtmClos_Click);
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.Color.Maroon;
            this.Status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Status.ForeColor = System.Drawing.Color.Cornsilk;
            this.Status.Location = new System.Drawing.Point(99, -6);
            this.Status.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(126, 40);
            this.Status.TabIndex = 20;
            this.Status.Text = "الفاتورة مضافة";
            this.Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.CmbStock);
            this.groupBox2.Controls.Add(this.Cmb_CatID);
            this.groupBox2.Controls.Add(this.TxtItemId);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.DateAdded);
            this.groupBox2.Controls.Add(this.TxtDiscount);
            this.groupBox2.Controls.Add(this.BtnPurList);
            this.groupBox2.Controls.Add(this.TxtQTE);
            this.groupBox2.Controls.Add(this.TxtItemName);
            this.groupBox2.Controls.Add(this.TxtPurPrice);
            this.groupBox2.Controls.Add(this.TxtBarCode);
            this.groupBox2.Controls.Add(this.TxtSalePrice);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 370);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات الصنف";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // CmbStock
            // 
            this.CmbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CmbStock.FormattingEnabled = true;
            this.CmbStock.Location = new System.Drawing.Point(12, 335);
            this.CmbStock.Name = "CmbStock";
            this.CmbStock.Size = new System.Drawing.Size(288, 21);
            this.CmbStock.TabIndex = 51;
            // 
            // Cmb_CatID
            // 
            this.Cmb_CatID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Cmb_CatID.FormattingEnabled = true;
            this.Cmb_CatID.Location = new System.Drawing.Point(12, 66);
            this.Cmb_CatID.Name = "Cmb_CatID";
            this.Cmb_CatID.Size = new System.Drawing.Size(288, 21);
            this.Cmb_CatID.TabIndex = 51;
            // 
            // TxtItemId
            // 
            this.TxtItemId.Location = new System.Drawing.Point(138, 29);
            this.TxtItemId.Name = "TxtItemId";
            this.TxtItemId.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TxtItemId.Properties.Appearance.Options.UseFont = true;
            this.TxtItemId.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtItemId.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TxtItemId.Properties.ReadOnly = true;
            this.TxtItemId.Size = new System.Drawing.Size(162, 20);
            this.TxtItemId.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(310, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "رقم الصنف :";
            // 
            // DateAdded
            // 
            this.DateAdded.EditValue = new System.DateTime(2017, 6, 17, 16, 34, 29, 475);
            this.DateAdded.Location = new System.Drawing.Point(12, 97);
            this.DateAdded.Name = "DateAdded";
            this.DateAdded.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.DateAdded.Properties.Appearance.Options.UseFont = true;
            this.DateAdded.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateAdded.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateAdded.Size = new System.Drawing.Size(288, 20);
            this.DateAdded.TabIndex = 23;
            // 
            // TxtDiscount
            // 
            this.TxtDiscount.Location = new System.Drawing.Point(12, 301);
            this.TxtDiscount.Name = "TxtDiscount";
            this.TxtDiscount.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TxtDiscount.Properties.Appearance.Options.UseFont = true;
            this.TxtDiscount.Size = new System.Drawing.Size(288, 20);
            this.TxtDiscount.TabIndex = 26;
            this.TxtDiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDiscount_KeyDown);
            this.TxtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDiscount_KeyPress);
            // 
            // BtnPurList
            // 
            this.BtnPurList.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPurList.Appearance.Options.UseFont = true;
            this.BtnPurList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnPurList.ImageOptions.Image")));
            this.BtnPurList.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnPurList.Location = new System.Drawing.Point(12, 32);
            this.BtnPurList.Name = "BtnPurList";
            this.BtnPurList.Size = new System.Drawing.Size(120, 28);
            this.BtnPurList.TabIndex = 9;
            this.BtnPurList.Text = "قائمة الشراء";
            this.BtnPurList.Click += new System.EventHandler(this.BtnPurList_Click);
            // 
            // TxtQTE
            // 
            this.TxtQTE.Location = new System.Drawing.Point(12, 267);
            this.TxtQTE.Name = "TxtQTE";
            this.TxtQTE.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TxtQTE.Properties.Appearance.Options.UseFont = true;
            this.TxtQTE.Size = new System.Drawing.Size(288, 20);
            this.TxtQTE.TabIndex = 26;
            this.TxtQTE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtQTE_KeyDown);
            this.TxtQTE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQTE_KeyPress);
            // 
            // TxtItemName
            // 
            this.TxtItemName.Location = new System.Drawing.Point(12, 165);
            this.TxtItemName.Name = "TxtItemName";
            this.TxtItemName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TxtItemName.Properties.Appearance.Options.UseFont = true;
            this.TxtItemName.Size = new System.Drawing.Size(288, 20);
            this.TxtItemName.TabIndex = 26;
            this.TxtItemName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtItemName_KeyDown);
            // 
            // TxtPurPrice
            // 
            this.TxtPurPrice.Location = new System.Drawing.Point(12, 199);
            this.TxtPurPrice.Name = "TxtPurPrice";
            this.TxtPurPrice.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TxtPurPrice.Properties.Appearance.Options.UseFont = true;
            this.TxtPurPrice.Size = new System.Drawing.Size(288, 20);
            this.TxtPurPrice.TabIndex = 25;
            this.TxtPurPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPurPrice_KeyDown);
            this.TxtPurPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPurPrice_KeyPress);
            // 
            // TxtBarCode
            // 
            this.TxtBarCode.Location = new System.Drawing.Point(12, 131);
            this.TxtBarCode.Name = "TxtBarCode";
            this.TxtBarCode.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TxtBarCode.Properties.Appearance.Options.UseFont = true;
            this.TxtBarCode.Size = new System.Drawing.Size(288, 20);
            this.TxtBarCode.TabIndex = 25;
            this.TxtBarCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBarCode_KeyDown);
            // 
            // TxtSalePrice
            // 
            this.TxtSalePrice.Location = new System.Drawing.Point(12, 233);
            this.TxtSalePrice.Name = "TxtSalePrice";
            this.TxtSalePrice.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TxtSalePrice.Properties.Appearance.Options.UseFont = true;
            this.TxtSalePrice.Size = new System.Drawing.Size(288, 20);
            this.TxtSalePrice.TabIndex = 24;
            this.TxtSalePrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSalePrice_KeyDown);
            this.TxtSalePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSalePrice_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(309, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "تاريخ الاضافة :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(310, 236);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "سعر البيع :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.Location = new System.Drawing.Point(310, 335);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "المخزن :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(310, 202);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "سعر الشراء :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(310, 66);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "رقم المجموعة :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(310, 304);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "الخصم :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(310, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "إسم الصنف :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(310, 270);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "الكمية :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(310, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "الباركود :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupControl4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 371);
            this.panel1.TabIndex = 2;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.DGV_PruChaseOrder);
            this.groupControl4.Location = new System.Drawing.Point(3, 3);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl4.Size = new System.Drawing.Size(394, 376);
            this.groupControl4.TabIndex = 20;
            this.groupControl4.Text = "عمليات التوريد والشراء";
            // 
            // DGV_PruChaseOrder
            // 
            this.DGV_PruChaseOrder.AllowUserToAddRows = false;
            this.DGV_PruChaseOrder.AllowUserToDeleteRows = false;
            this.DGV_PruChaseOrder.AllowUserToResizeColumns = false;
            this.DGV_PruChaseOrder.AllowUserToResizeRows = false;
            this.DGV_PruChaseOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_PruChaseOrder.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV_PruChaseOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_PruChaseOrder.Location = new System.Drawing.Point(2, 20);
            this.DGV_PruChaseOrder.MultiSelect = false;
            this.DGV_PruChaseOrder.Name = "DGV_PruChaseOrder";
            this.DGV_PruChaseOrder.ReadOnly = true;
            this.DGV_PruChaseOrder.Size = new System.Drawing.Size(390, 354);
            this.DGV_PruChaseOrder.TabIndex = 8;
            this.DGV_PruChaseOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_PruChaseOrder_CellClick);
            this.DGV_PruChaseOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_PruChaseOrder_CellDoubleClick);
            // 
            // Frm_AddItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 430);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_AddItems";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة صنف جديد";
            this.Load += new System.EventHandler(this.Frm_AddItems_Load);
            this.Leave += new System.EventHandler(this.Frm_AddItems_Leave);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtItemId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateAdded.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateAdded.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtItemName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPurPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBarCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSalePrice.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PruChaseOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Status;
        public DevExpress.XtraEditors.TextEdit TxtItemName;
        public DevExpress.XtraEditors.TextEdit TxtBarCode;
        public DevExpress.XtraEditors.TextEdit TxtQTE;
        public DevExpress.XtraEditors.TextEdit TxtPurPrice;
        public DevExpress.XtraEditors.TextEdit TxtSalePrice;
        public DevExpress.XtraEditors.TextEdit TxtDiscount;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        public System.Windows.Forms.DataGridView DGV_PruChaseOrder;
        public DevExpress.XtraEditors.SimpleButton BtnAdd;
        public DevExpress.XtraEditors.SimpleButton BtnNew;
        public DevExpress.XtraEditors.SimpleButton BtnEdit;
        public DevExpress.XtraEditors.DateEdit DateAdded;
        public DevExpress.XtraEditors.TextEdit TxtItemId;
        public System.Windows.Forms.ComboBox Cmb_CatID;
        public DevExpress.XtraEditors.SimpleButton BtnPurList;
        private DevExpress.XtraEditors.SimpleButton BtmClos;
        public System.Windows.Forms.ComboBox CmbStock;
        private System.Windows.Forms.Label label10;
    }
}