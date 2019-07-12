namespace SuperMarket.PL.Users
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUserName = new DevExpress.XtraEditors.TextEdit();
            this.TxtUserPass = new DevExpress.XtraEditors.TextEdit();
            this.BtnExit = new DevExpress.XtraEditors.SimpleButton();
            this.BtnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.checkRemember = new DevExpress.XtraEditors.CheckButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUserPass.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "كلمة المرور:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "اسم المستخدم:";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(4, 6);
            this.TxtUserName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TxtUserName.Properties.Appearance.Options.UseFont = true;
            this.TxtUserName.Size = new System.Drawing.Size(325, 30);
            this.TxtUserName.TabIndex = 0;
            this.TxtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtUserName_KeyDown);
            // 
            // TxtUserPass
            // 
            this.TxtUserPass.Location = new System.Drawing.Point(4, 46);
            this.TxtUserPass.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TxtUserPass.Name = "TxtUserPass";
            this.TxtUserPass.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TxtUserPass.Properties.Appearance.Options.UseFont = true;
            this.TxtUserPass.Properties.UseSystemPasswordChar = true;
            this.TxtUserPass.Size = new System.Drawing.Size(325, 30);
            this.TxtUserPass.TabIndex = 1;
            this.TxtUserPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtUserPass_KeyDown);
            // 
            // BtnExit
            // 
            this.BtnExit.Appearance.Font = new System.Drawing.Font("Al-Mothnna", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnExit.Appearance.Options.UseFont = true;
            this.BtnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.ImageOptions.Image")));
            this.BtnExit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnExit.Location = new System.Drawing.Point(47, 130);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(138, 37);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "إغلاق";
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Appearance.Font = new System.Drawing.Font("Al-Mothnna", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnLogin.Appearance.Options.UseFont = true;
            this.BtnLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnLogin.ImageOptions.Image")));
            this.BtnLogin.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.BtnLogin.Location = new System.Drawing.Point(191, 130);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(138, 37);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "دخول";
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // checkRemember
            // 
            this.checkRemember.Appearance.Font = new System.Drawing.Font("Al-Mothnna", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.checkRemember.Appearance.Options.UseFont = true;
            this.checkRemember.Location = new System.Drawing.Point(157, 85);
            this.checkRemember.Name = "checkRemember";
            this.checkRemember.Size = new System.Drawing.Size(172, 29);
            this.checkRemember.TabIndex = 4;
            this.checkRemember.Text = "تذكر هذا المستخدم؟";
            this.checkRemember.CheckedChanged += new System.EventHandler(this.checkRemember_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.imageSlider1);
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 357);
            this.panel1.TabIndex = 6;
            // 
            // imageSlider1
            // 
            this.imageSlider1.AllowLooping = true;
            this.imageSlider1.AutoSlide = DevExpress.XtraEditors.Controls.AutoSlide.Forward;
            this.imageSlider1.AutoSlideInterval = 5000;
            this.imageSlider1.CurrentImageIndex = 0;
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images"))));
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images1"))));
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images2"))));
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images3"))));
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images4"))));
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images5"))));
            this.imageSlider1.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomInside;
            this.imageSlider1.Location = new System.Drawing.Point(4, 9);
            this.imageSlider1.Name = "imageSlider1";
            this.imageSlider1.Size = new System.Drawing.Size(409, 334);
            this.imageSlider1.TabIndex = 6;
            this.imageSlider1.Text = "imageSlider1";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.TxtUserName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.BtnExit);
            this.panel2.Controls.Add(this.checkRemember);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.BtnLogin);
            this.panel2.Controls.Add(this.TxtUserPass);
            this.panel2.Location = new System.Drawing.Point(12, 367);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(421, 191);
            this.panel2.TabIndex = 7;
            // 
            // Frm_Login
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 570);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Al-Mothnna", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUserPass.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit TxtUserName;
        private DevExpress.XtraEditors.TextEdit TxtUserPass;
        private DevExpress.XtraEditors.SimpleButton BtnExit;
        private DevExpress.XtraEditors.SimpleButton BtnLogin;
        private DevExpress.XtraEditors.CheckButton checkRemember;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider1;
        private System.Windows.Forms.Panel panel2;
    }
}