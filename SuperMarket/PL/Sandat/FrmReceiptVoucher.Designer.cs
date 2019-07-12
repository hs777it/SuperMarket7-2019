﻿namespace SuperMarket.PL.Sandat
{
    partial class FrmReceiptVoucher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReceiptVoucher));
            this.statement = new DevExpress.XtraEditors.MemoEdit();
            this.label12 = new System.Windows.Forms.Label();
            this.VoucherDate = new DevExpress.XtraEditors.DateEdit();
            this.VoucherAmount = new DevExpress.XtraEditors.TextEdit();
            this.UserVoucher = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VoucherCode = new DevExpress.XtraEditors.TextEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.VoucherAmountAr = new DevExpress.XtraEditors.TextEdit();
            this.VoucherFrom = new DevExpress.XtraEditors.TextEdit();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNew = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.label9 = new System.Windows.Forms.Label();
            this.VoucherRNum = new DevExpress.XtraEditors.TextEdit();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.CmbCust = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.TxtNewDofaaAr = new DevExpress.XtraEditors.TextEdit();
            this.TxtNewDofaa = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtBaqi = new DevExpress.XtraEditors.TextEdit();
            this.txtBaqiAr = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.statement.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoucherDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoucherDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoucherAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserVoucher.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoucherCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoucherAmountAr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoucherFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoucherRNum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNewDofaaAr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNewDofaa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaqi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaqiAr.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // statement
            // 
            this.statement.EditValue = "أكتب هنا .....";
            this.statement.Location = new System.Drawing.Point(141, 217);
            this.statement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.statement.Name = "statement";
            this.statement.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.statement.Properties.Appearance.Options.UseFont = true;
            this.statement.Size = new System.Drawing.Size(553, 38);
            this.statement.TabIndex = 62;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label12.Location = new System.Drawing.Point(85, 218);
            this.label12.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 15);
            this.label12.TabIndex = 61;
            this.label12.Text = "البيان :";
            // 
            // VoucherDate
            // 
            this.VoucherDate.EditValue = new System.DateTime(2017, 6, 17, 16, 34, 29, 475);
            this.VoucherDate.Location = new System.Drawing.Point(549, 12);
            this.VoucherDate.Name = "VoucherDate";
            this.VoucherDate.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.VoucherDate.Properties.Appearance.Options.UseFont = true;
            this.VoucherDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.VoucherDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.VoucherDate.Size = new System.Drawing.Size(129, 20);
            this.VoucherDate.TabIndex = 55;
            // 
            // VoucherAmount
            // 
            this.VoucherAmount.Location = new System.Drawing.Point(140, 113);
            this.VoucherAmount.Name = "VoucherAmount";
            this.VoucherAmount.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.VoucherAmount.Properties.Appearance.Options.UseFont = true;
            this.VoucherAmount.Properties.Appearance.Options.UseTextOptions = true;
            this.VoucherAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.VoucherAmount.Size = new System.Drawing.Size(181, 20);
            this.VoucherAmount.TabIndex = 54;
            this.toolTip1.SetToolTip(this.VoucherAmount, "مجموع المبلغ المستحق لنا");
            this.VoucherAmount.TextChanged += new System.EventHandler(this.VoucherAmount_TextChanged);
            this.VoucherAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VoucherAmount_KeyPress);
            // 
            // UserVoucher
            // 
            this.UserVoucher.Location = new System.Drawing.Point(140, 263);
            this.UserVoucher.Name = "UserVoucher";
            this.UserVoucher.Properties.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.UserVoucher.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.UserVoucher.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.UserVoucher.Properties.Appearance.Options.UseBackColor = true;
            this.UserVoucher.Properties.Appearance.Options.UseFont = true;
            this.UserVoucher.Properties.Appearance.Options.UseForeColor = true;
            this.UserVoucher.Properties.Appearance.Options.UseTextOptions = true;
            this.UserVoucher.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UserVoucher.Properties.ReadOnly = true;
            this.UserVoucher.Size = new System.Drawing.Size(553, 20);
            this.UserVoucher.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(41, 266);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "مستخدم النظام :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(469, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "تاريخ السند :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(72, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "قبض من :";
            this.toolTip1.SetToolTip(this.label3, "إسم العميل أو الزبون");
            // 
            // VoucherCode
            // 
            this.VoucherCode.Location = new System.Drawing.Point(110, 12);
            this.VoucherCode.Name = "VoucherCode";
            this.VoucherCode.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.VoucherCode.Properties.Appearance.Options.UseFont = true;
            this.VoucherCode.Properties.Appearance.Options.UseTextOptions = true;
            this.VoucherCode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.VoucherCode.Properties.ReadOnly = true;
            this.VoucherCode.Size = new System.Drawing.Size(101, 20);
            this.VoucherCode.TabIndex = 63;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.Location = new System.Drawing.Point(35, 15);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 64;
            this.label10.Text = "رقم السند :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(59, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "قيمة السند :";
            this.toolTip1.SetToolTip(this.label1, "مجموع المبلغ المستحق لنا");
            // 
            // VoucherAmountAr
            // 
            this.VoucherAmountAr.Location = new System.Drawing.Point(327, 113);
            this.VoucherAmountAr.Name = "VoucherAmountAr";
            this.VoucherAmountAr.Properties.Appearance.BackColor = System.Drawing.Color.Silver;
            this.VoucherAmountAr.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.VoucherAmountAr.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.VoucherAmountAr.Properties.Appearance.Options.UseBackColor = true;
            this.VoucherAmountAr.Properties.Appearance.Options.UseFont = true;
            this.VoucherAmountAr.Properties.Appearance.Options.UseForeColor = true;
            this.VoucherAmountAr.Properties.Appearance.Options.UseTextOptions = true;
            this.VoucherAmountAr.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.VoucherAmountAr.Properties.ReadOnly = true;
            this.VoucherAmountAr.Size = new System.Drawing.Size(366, 20);
            this.VoucherAmountAr.TabIndex = 54;
            // 
            // VoucherFrom
            // 
            this.VoucherFrom.Location = new System.Drawing.Point(140, 78);
            this.VoucherFrom.Name = "VoucherFrom";
            this.VoucherFrom.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.VoucherFrom.Properties.Appearance.Options.UseFont = true;
            this.VoucherFrom.Properties.Appearance.Options.UseTextOptions = true;
            this.VoucherFrom.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.VoucherFrom.Size = new System.Drawing.Size(553, 20);
            this.VoucherFrom.TabIndex = 54;
            this.toolTip1.SetToolTip(this.VoucherFrom, "إسم العميل أو الزبون");
            // 
            // BtnClose
            // 
            this.BtnClose.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Appearance.Options.UseFont = true;
            this.BtnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.ImageOptions.Image")));
            this.BtnClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(442, 311);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(137, 40);
            this.BtnClose.TabIndex = 69;
            this.BtnClose.Text = "إغلاق";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Appearance.Options.UseFont = true;
            this.BtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.ImageOptions.Image")));
            this.BtnSave.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnSave.Location = new System.Drawing.Point(297, 311);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(137, 41);
            this.BtnSave.TabIndex = 65;
            this.BtnSave.Text = "حفظ السند";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNew.Appearance.Options.UseFont = true;
            this.BtnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnNew.ImageOptions.Image")));
            this.BtnNew.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnNew.Location = new System.Drawing.Point(152, 311);
            this.BtnNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(137, 41);
            this.BtnNew.TabIndex = 66;
            this.BtnNew.Text = "سند جديد";
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.Appearance.Options.UseFont = true;
            this.BtnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.ImageOptions.Image")));
            this.BtnEdit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnEdit.Location = new System.Drawing.Point(152, 311);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(137, 41);
            this.BtnEdit.TabIndex = 65;
            this.BtnEdit.Text = "تعديل السند";
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(214, 15);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "رقم سند الاستلام :";
            // 
            // VoucherRNum
            // 
            this.VoucherRNum.Location = new System.Drawing.Point(326, 12);
            this.VoucherRNum.Name = "VoucherRNum";
            this.VoucherRNum.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.VoucherRNum.Properties.Appearance.Options.UseFont = true;
            this.VoucherRNum.Properties.Appearance.Options.UseTextOptions = true;
            this.VoucherRNum.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.VoucherRNum.Size = new System.Drawing.Size(131, 20);
            this.VoucherRNum.TabIndex = 53;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.radioButton1.Location = new System.Drawing.Point(148, 45);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 19);
            this.radioButton1.TabIndex = 70;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "بدون تحديد";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.radioButton2.Location = new System.Drawing.Point(241, 45);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 19);
            this.radioButton2.TabIndex = 70;
            this.radioButton2.Text = "تحديد عميل";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // CmbCust
            // 
            this.CmbCust.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbCust.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbCust.DisplayMember = "Text";
            this.CmbCust.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbCust.FormattingEnabled = true;
            this.CmbCust.ItemHeight = 16;
            this.CmbCust.Location = new System.Drawing.Point(140, 77);
            this.CmbCust.Name = "CmbCust";
            this.CmbCust.Size = new System.Drawing.Size(553, 22);
            this.CmbCust.TabIndex = 71;
            this.toolTip1.SetToolTip(this.CmbCust, "إسم العميل أو الزبون");
            this.CmbCust.Visible = false;
            this.CmbCust.SelectedIndexChanged += new System.EventHandler(this.CmbCust_SelectedIndexChanged);
            // 
            // TxtNewDofaaAr
            // 
            this.TxtNewDofaaAr.Location = new System.Drawing.Point(327, 147);
            this.TxtNewDofaaAr.Name = "TxtNewDofaaAr";
            this.TxtNewDofaaAr.Properties.Appearance.BackColor = System.Drawing.Color.Silver;
            this.TxtNewDofaaAr.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TxtNewDofaaAr.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtNewDofaaAr.Properties.Appearance.Options.UseBackColor = true;
            this.TxtNewDofaaAr.Properties.Appearance.Options.UseFont = true;
            this.TxtNewDofaaAr.Properties.Appearance.Options.UseForeColor = true;
            this.TxtNewDofaaAr.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtNewDofaaAr.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TxtNewDofaaAr.Properties.ReadOnly = true;
            this.TxtNewDofaaAr.Size = new System.Drawing.Size(366, 20);
            this.TxtNewDofaaAr.TabIndex = 80;
            // 
            // TxtNewDofaa
            // 
            this.TxtNewDofaa.Location = new System.Drawing.Point(141, 147);
            this.TxtNewDofaa.Name = "TxtNewDofaa";
            this.TxtNewDofaa.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TxtNewDofaa.Properties.Appearance.Options.UseFont = true;
            this.TxtNewDofaa.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtNewDofaa.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TxtNewDofaa.Size = new System.Drawing.Size(180, 20);
            this.TxtNewDofaa.TabIndex = 79;
            this.TxtNewDofaa.TextChanged += new System.EventHandler(this.TxtNewDofaa_TextChanged);
            this.TxtNewDofaa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNewDofaa_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(20, 150);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 81;
            this.label6.Text = "تسديد دفعة جديدة :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(83, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 81;
            this.label4.Text = "الباقى :";
            // 
            // txtBaqi
            // 
            this.txtBaqi.Location = new System.Drawing.Point(142, 181);
            this.txtBaqi.Name = "txtBaqi";
            this.txtBaqi.Properties.Appearance.BackColor = System.Drawing.Color.Gray;
            this.txtBaqi.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtBaqi.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtBaqi.Properties.Appearance.Options.UseBackColor = true;
            this.txtBaqi.Properties.Appearance.Options.UseFont = true;
            this.txtBaqi.Properties.Appearance.Options.UseForeColor = true;
            this.txtBaqi.Properties.Appearance.Options.UseTextOptions = true;
            this.txtBaqi.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtBaqi.Properties.ReadOnly = true;
            this.txtBaqi.Size = new System.Drawing.Size(180, 20);
            this.txtBaqi.TabIndex = 79;
            this.txtBaqi.TextChanged += new System.EventHandler(this.txtBaqi_TextChanged);
            // 
            // txtBaqiAr
            // 
            this.txtBaqiAr.Location = new System.Drawing.Point(328, 181);
            this.txtBaqiAr.Name = "txtBaqiAr";
            this.txtBaqiAr.Properties.Appearance.BackColor = System.Drawing.Color.Silver;
            this.txtBaqiAr.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtBaqiAr.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtBaqiAr.Properties.Appearance.Options.UseBackColor = true;
            this.txtBaqiAr.Properties.Appearance.Options.UseFont = true;
            this.txtBaqiAr.Properties.Appearance.Options.UseForeColor = true;
            this.txtBaqiAr.Properties.Appearance.Options.UseTextOptions = true;
            this.txtBaqiAr.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtBaqiAr.Properties.ReadOnly = true;
            this.txtBaqiAr.Size = new System.Drawing.Size(366, 20);
            this.txtBaqiAr.TabIndex = 80;
            // 
            // FrmReceiptVoucher
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 359);
            this.Controls.Add(this.txtBaqiAr);
            this.Controls.Add(this.txtBaqi);
            this.Controls.Add(this.TxtNewDofaaAr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtNewDofaa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.VoucherCode);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.statement);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.VoucherDate);
            this.Controls.Add(this.VoucherRNum);
            this.Controls.Add(this.VoucherAmountAr);
            this.Controls.Add(this.VoucherAmount);
            this.Controls.Add(this.UserVoucher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.VoucherFrom);
            this.Controls.Add(this.CmbCust);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReceiptVoucher";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سند قبض مالى";
            ((System.ComponentModel.ISupportInitialize)(this.statement.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoucherDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoucherDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoucherAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserVoucher.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoucherCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoucherAmountAr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoucherFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoucherRNum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNewDofaaAr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNewDofaa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaqi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaqiAr.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.MemoEdit statement;
        public DevExpress.XtraEditors.DateEdit VoucherDate;
        public DevExpress.XtraEditors.TextEdit VoucherAmount;
        public DevExpress.XtraEditors.TextEdit UserVoucher;
        private System.Windows.Forms.Label label2;
        public DevExpress.XtraEditors.TextEdit VoucherCode;
        public DevExpress.XtraEditors.TextEdit VoucherAmountAr;
        public DevExpress.XtraEditors.TextEdit VoucherFrom;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label1;
        public DevExpress.XtraEditors.SimpleButton BtnClose;
        public DevExpress.XtraEditors.SimpleButton BtnSave;
        public DevExpress.XtraEditors.SimpleButton BtnNew;
        public DevExpress.XtraEditors.SimpleButton BtnEdit;
        public System.Windows.Forms.Label label9;
        public DevExpress.XtraEditors.TextEdit VoucherRNum;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CmbCust;
        public DevExpress.XtraEditors.TextEdit TxtNewDofaaAr;
        public DevExpress.XtraEditors.TextEdit TxtNewDofaa;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Label label4;
        public DevExpress.XtraEditors.TextEdit txtBaqi;
        public DevExpress.XtraEditors.TextEdit txtBaqiAr;
    }
}