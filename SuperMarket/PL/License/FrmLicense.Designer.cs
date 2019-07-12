namespace SuperMarket.PL.License
{
    partial class FrmLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLicense));
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.TxSerial3 = new System.Windows.Forms.TextBox();
            this.BtnSend = new DevExpress.XtraEditors.SimpleButton();
            this.TxGet = new System.Windows.Forms.TextBox();
            this.TxSerial2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxSerial = new System.Windows.Forms.TextBox();
            this.TxSerial1 = new System.Windows.Forms.TextBox();
            this.BuTrial = new DevExpress.XtraEditors.SimpleButton();
            this.BuLogin = new DevExpress.XtraEditors.SimpleButton();
            this.LabTrial1 = new System.Windows.Forms.Label();
            this.LabDays = new System.Windows.Forms.Label();
            this.LabTrial = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox.SuspendLayout();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox.Controls.Add(this.pnl1);
            this.groupBox.Controls.Add(this.BuTrial);
            this.groupBox.Controls.Add(this.BuLogin);
            this.groupBox.Controls.Add(this.LabTrial1);
            this.groupBox.Controls.Add(this.LabDays);
            this.groupBox.Controls.Add(this.LabTrial);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox.Location = new System.Drawing.Point(0, 306);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(410, 274);
            this.groupBox.TabIndex = 17;
            this.groupBox.TabStop = false;
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnl1.Controls.Add(this.progressBar1);
            this.pnl1.Controls.Add(this.TxSerial3);
            this.pnl1.Controls.Add(this.BtnSend);
            this.pnl1.Controls.Add(this.TxGet);
            this.pnl1.Controls.Add(this.TxSerial2);
            this.pnl1.Controls.Add(this.label2);
            this.pnl1.Controls.Add(this.label1);
            this.pnl1.Controls.Add(this.TxSerial);
            this.pnl1.Controls.Add(this.TxSerial1);
            this.pnl1.Location = new System.Drawing.Point(11, 52);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(389, 145);
            this.pnl1.TabIndex = 963;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.DarkCyan;
            this.progressBar1.Location = new System.Drawing.Point(48, 64);
            this.progressBar1.MarqueeAnimationSpeed = 30;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(330, 10);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 19;
            // 
            // TxSerial3
            // 
            this.TxSerial3.Font = new System.Drawing.Font("Tahoma", 15F);
            this.TxSerial3.Location = new System.Drawing.Point(292, 101);
            this.TxSerial3.MaxLength = 4;
            this.TxSerial3.Name = "TxSerial3";
            this.TxSerial3.Size = new System.Drawing.Size(86, 32);
            this.TxSerial3.TabIndex = 17;
            this.TxSerial3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnSend
            // 
            this.BtnSend.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.BtnSend.Appearance.Options.UseFont = true;
            this.BtnSend.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSend.ImageOptions.Image")));
            this.BtnSend.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.BtnSend.Location = new System.Drawing.Point(3, 30);
            this.BtnSend.Margin = new System.Windows.Forms.Padding(6);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(41, 33);
            this.BtnSend.TabIndex = 962;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // TxGet
            // 
            this.TxGet.Font = new System.Drawing.Font("Tahoma", 15F);
            this.TxGet.Location = new System.Drawing.Point(48, 31);
            this.TxGet.MaxLength = 4;
            this.TxGet.Name = "TxGet";
            this.TxGet.ReadOnly = true;
            this.TxGet.Size = new System.Drawing.Size(330, 32);
            this.TxGet.TabIndex = 14;
            this.TxGet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxSerial2
            // 
            this.TxSerial2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.TxSerial2.Location = new System.Drawing.Point(200, 101);
            this.TxSerial2.MaxLength = 4;
            this.TxSerial2.Name = "TxSerial2";
            this.TxSerial2.Size = new System.Drawing.Size(86, 32);
            this.TxSerial2.TabIndex = 16;
            this.TxSerial2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(315, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "رقم المنتج";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(311, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "رقم التفعيل";
            // 
            // TxSerial
            // 
            this.TxSerial.Font = new System.Drawing.Font("Tahoma", 15F);
            this.TxSerial.Location = new System.Drawing.Point(16, 101);
            this.TxSerial.MaxLength = 4;
            this.TxSerial.Name = "TxSerial";
            this.TxSerial.Size = new System.Drawing.Size(86, 32);
            this.TxSerial.TabIndex = 14;
            this.TxSerial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxSerial1
            // 
            this.TxSerial1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.TxSerial1.Location = new System.Drawing.Point(108, 101);
            this.TxSerial1.MaxLength = 4;
            this.TxSerial1.Name = "TxSerial1";
            this.TxSerial1.Size = new System.Drawing.Size(86, 32);
            this.TxSerial1.TabIndex = 15;
            this.TxSerial1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BuTrial
            // 
            this.BuTrial.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuTrial.Appearance.Options.UseFont = true;
            this.BuTrial.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BuTrial.ImageOptions.Image")));
            this.BuTrial.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BuTrial.Location = new System.Drawing.Point(11, 207);
            this.BuTrial.Name = "BuTrial";
            this.BuTrial.Size = new System.Drawing.Size(189, 43);
            this.BuTrial.TabIndex = 961;
            this.BuTrial.Text = "تشغيل النسخة التجربية";
            this.BuTrial.Click += new System.EventHandler(this.BuTrial_Click);
            this.BuTrial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BuTrial_KeyDown);
            // 
            // BuLogin
            // 
            this.BuLogin.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuLogin.Appearance.Options.UseFont = true;
            this.BuLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BuLogin.ImageOptions.Image")));
            this.BuLogin.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BuLogin.Location = new System.Drawing.Point(265, 207);
            this.BuLogin.Name = "BuLogin";
            this.BuLogin.Size = new System.Drawing.Size(134, 43);
            this.BuLogin.TabIndex = 961;
            this.BuLogin.Text = "تسجيل النسخة";
            this.BuLogin.Click += new System.EventHandler(this.BuLogin_Click);
            this.BuLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BuLogin_KeyDown);
            // 
            // LabTrial1
            // 
            this.LabTrial1.AutoSize = true;
            this.LabTrial1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTrial1.Location = new System.Drawing.Point(86, 17);
            this.LabTrial1.Name = "LabTrial1";
            this.LabTrial1.Size = new System.Drawing.Size(26, 16);
            this.LabTrial1.TabIndex = 16;
            this.LabTrial1.Text = "يوم";
            // 
            // LabDays
            // 
            this.LabDays.AutoSize = true;
            this.LabDays.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.LabDays.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LabDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDays.ForeColor = System.Drawing.Color.Crimson;
            this.LabDays.Location = new System.Drawing.Point(127, 17);
            this.LabDays.Name = "LabDays";
            this.LabDays.Size = new System.Drawing.Size(26, 16);
            this.LabDays.TabIndex = 15;
            this.LabDays.Text = "15";
            // 
            // LabTrial
            // 
            this.LabTrial.AutoSize = true;
            this.LabTrial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTrial.Location = new System.Drawing.Point(163, 17);
            this.LabTrial.Name = "LabTrial";
            this.LabTrial.Size = new System.Drawing.Size(194, 16);
            this.LabTrial.TabIndex = 14;
            this.LabTrial.Text = "الفترة التجريبية الممنوحة لك هي";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SuperMarket.Properties.Resources.tumblr_o8stotSAQR1ul8y65o1_1280;
            this.pictureBox1.Location = new System.Drawing.Point(47, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // FrmLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 580);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLicense";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تفعيل النظام";
            this.Load += new System.EventHandler(this.FrmLicense_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLicense_KeyDown);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label LabTrial1;
        private System.Windows.Forms.Label LabDays;
        private System.Windows.Forms.Label LabTrial;
        private System.Windows.Forms.TextBox TxSerial3;
        private System.Windows.Forms.TextBox TxSerial2;
        private System.Windows.Forms.TextBox TxSerial1;
        private System.Windows.Forms.TextBox TxSerial;
        private DevExpress.XtraEditors.SimpleButton BuTrial;
        private DevExpress.XtraEditors.SimpleButton BuLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.TextBox TxGet;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton BtnSend;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}