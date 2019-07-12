namespace SuperMarket.PL.Sales
{
    partial class frmPlaces
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlaces));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtItemId = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbPlaces = new DevExpress.XtraEditors.ComboBoxEdit();
            this.CmbStand = new DevExpress.XtraEditors.ComboBoxEdit();
            this.CmbFloar = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtItemId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbPlaces.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbStand.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbFloar.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox2.Location = new System.Drawing.Point(4, 3);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(377, 191);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // TxtItemId
            // 
            this.TxtItemId.Location = new System.Drawing.Point(151, 32);
            this.TxtItemId.Name = "TxtItemId";
            this.TxtItemId.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TxtItemId.Properties.Appearance.Options.UseFont = true;
            this.TxtItemId.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtItemId.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TxtItemId.Properties.ReadOnly = true;
            this.TxtItemId.Size = new System.Drawing.Size(126, 20);
            this.TxtItemId.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(287, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "الاتجاة :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(287, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "الستاند :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(287, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "الطابق :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(287, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "رقم الصنف :";
            // 
            // CmbPlaces
            // 
            this.CmbPlaces.Location = new System.Drawing.Point(15, 134);
            this.CmbPlaces.Name = "CmbPlaces";
            this.CmbPlaces.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CmbPlaces.Properties.Appearance.Options.UseFont = true;
            this.CmbPlaces.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbPlaces.Properties.Items.AddRange(new object[] {
            "يمين",
            "شمال",
            "وسط",
            "فوق",
            "تحت"});
            this.CmbPlaces.Size = new System.Drawing.Size(262, 20);
            this.CmbPlaces.TabIndex = 47;
            // 
            // CmbStand
            // 
            this.CmbStand.Location = new System.Drawing.Point(15, 100);
            this.CmbStand.Name = "CmbStand";
            this.CmbStand.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
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
            this.CmbStand.Size = new System.Drawing.Size(262, 20);
            this.CmbStand.TabIndex = 47;
            // 
            // CmbFloar
            // 
            this.CmbFloar.Location = new System.Drawing.Point(15, 66);
            this.CmbFloar.Name = "CmbFloar";
            this.CmbFloar.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
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
            this.CmbFloar.Size = new System.Drawing.Size(262, 20);
            this.CmbFloar.TabIndex = 47;
            // 
            // frmPlaces
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 201);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPlaces";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مكان الصنف";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtItemId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbPlaces.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbStand.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbFloar.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        public DevExpress.XtraEditors.TextEdit TxtItemId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public DevExpress.XtraEditors.ComboBoxEdit CmbPlaces;
        public DevExpress.XtraEditors.ComboBoxEdit CmbStand;
        public DevExpress.XtraEditors.ComboBoxEdit CmbFloar;
    }
}