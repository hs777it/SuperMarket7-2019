namespace SuperMarket.PL.Users
{
    partial class frmLock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLock));
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnUnlock = new DevExpress.XtraEditors.SimpleButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblMarquee = new System.Windows.Forms.Label();
            this.lblErr = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.theClock1 = new TheClock.TheClock();
            this.lblDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.theClock1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(0, -4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(830, 10);
            this.label5.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(0, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(830, 30);
            this.label2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Al-Mothnna", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(285, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "ادخل كلمة السر لفتح النظام";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Al-Mothnna", 12F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUsername.Location = new System.Drawing.Point(285, 140);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(214, 23);
            this.lblUsername.TabIndex = 12;
            this.lblUsername.Text = "ادخل كلمة السر لفتح النظام";
            // 
            // btnUnlock
            // 
            this.btnUnlock.Appearance.Font = new System.Drawing.Font("Al-Mothnna", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnUnlock.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUnlock.Appearance.Options.UseFont = true;
            this.btnUnlock.Appearance.Options.UseForeColor = true;
            this.btnUnlock.AutoSize = true;
            this.btnUnlock.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnUnlock.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUnlock.ImageOptions.Image")));
            this.btnUnlock.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnUnlock.Location = new System.Drawing.Point(268, 187);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(34, 34);
            this.btnUnlock.TabIndex = 8;
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Al-Mothnna", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPassword.Location = new System.Drawing.Point(305, 189);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPassword.Size = new System.Drawing.Size(214, 30);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblMarquee
            // 
            this.lblMarquee.Font = new System.Drawing.Font("Al-Mothnna", 14F);
            this.lblMarquee.Location = new System.Drawing.Point(112, 9);
            this.lblMarquee.Name = "lblMarquee";
            this.lblMarquee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMarquee.Size = new System.Drawing.Size(591, 23);
            this.lblMarquee.TabIndex = 15;
            this.lblMarquee.Text = "لا إله إلا الله محمد رسول الله";
            this.lblMarquee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErr
            // 
            this.lblErr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErr.Location = new System.Drawing.Point(312, 222);
            this.lblErr.Name = "lblErr";
            this.lblErr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblErr.Size = new System.Drawing.Size(210, 23);
            this.lblErr.TabIndex = 16;
            this.lblErr.Text = "label3";
            this.lblErr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblErr.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Al-Mothnna", 12F, System.Drawing.FontStyle.Bold);
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTime.Location = new System.Drawing.Point(12, 307);
            this.lblTime.Name = "lblTime";
            this.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTime.Size = new System.Drawing.Size(156, 29);
            this.lblTime.TabIndex = 17;
            this.lblTime.Text = "                    ";
            // 
            // theClock1
            // 
            this.theClock1.AdvancedMode = false;
            this.theClock1.BackColor = System.Drawing.Color.Transparent;
            this.theClock1.EnableFadeFocus = false;
            this.theClock1.Location = new System.Drawing.Point(57, 76);
            this.theClock1.Name = "theClock1";
            this.theClock1.Size = new System.Drawing.Size(130, 130);
            this.theClock1.TabIndex = 18;
            this.theClock1.Text = "theClock1";
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Al-Mothnna", 12F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDate.Location = new System.Drawing.Point(179, 307);
            this.lblDate.Name = "lblDate";
            this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDate.Size = new System.Drawing.Size(177, 29);
            this.lblDate.TabIndex = 19;
            this.lblDate.Text = "                    ";
            // 
            // frmLock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 361);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnUnlock);
            this.Controls.Add(this.theClock1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblErr);
            this.Controls.Add(this.lblMarquee);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmLock";
            this.Load += new System.EventHandler(this.frmLock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.theClock1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btnUnlock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblMarquee;
        private System.Windows.Forms.Label lblErr;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
        private TheClock.TheClock theClock1;
        private System.Windows.Forms.Label lblDate;
    }
}