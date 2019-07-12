namespace SuperMarket.PL.AboutSystem
{
    partial class frmGetShot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGetShot));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.حفظالصورةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.إرسالالصورةللمبرمجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.إغلاقToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textEdit1 = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(858, 598);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.حفظالصورةToolStripMenuItem,
            this.إرسالالصورةللمبرمجToolStripMenuItem,
            this.إغلاقToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // حفظالصورةToolStripMenuItem
            // 
            this.حفظالصورةToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("حفظالصورةToolStripMenuItem.Image")));
            this.حفظالصورةToolStripMenuItem.Name = "حفظالصورةToolStripMenuItem";
            this.حفظالصورةToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.حفظالصورةToolStripMenuItem.Text = "حفظ الصورة";
            this.حفظالصورةToolStripMenuItem.Click += new System.EventHandler(this.حفظالصورةToolStripMenuItem_Click);
            // 
            // إرسالالصورةللمبرمجToolStripMenuItem
            // 
            this.إرسالالصورةللمبرمجToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("إرسالالصورةللمبرمجToolStripMenuItem.Image")));
            this.إرسالالصورةللمبرمجToolStripMenuItem.Name = "إرسالالصورةللمبرمجToolStripMenuItem";
            this.إرسالالصورةللمبرمجToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.إرسالالصورةللمبرمجToolStripMenuItem.Text = "إرسال الصورة للمبرمج";
            this.إرسالالصورةللمبرمجToolStripMenuItem.Click += new System.EventHandler(this.إرسالالصورةللمبرمجToolStripMenuItem_Click);
            // 
            // إغلاقToolStripMenuItem
            // 
            this.إغلاقToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("إغلاقToolStripMenuItem.Image")));
            this.إغلاقToolStripMenuItem.Name = "إغلاقToolStripMenuItem";
            this.إغلاقToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.إغلاقToolStripMenuItem.Text = "إغلاق";
            this.إغلاقToolStripMenuItem.Click += new System.EventHandler(this.إغلاقToolStripMenuItem_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = resources.GetString("textEdit1.EditValue");
            this.textEdit1.Location = new System.Drawing.Point(115, 12);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.textEdit1.Properties.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.textEdit1.Properties.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.textEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.textEdit1.Properties.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("textEdit1.Properties.Appearance.Image")));
            this.textEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit1.Properties.Appearance.Options.UseBorderColor = true;
            this.textEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit1.Properties.Appearance.Options.UseImage = true;
            this.textEdit1.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textEdit1.Properties.XlsxFormatString = "html";
            this.textEdit1.Size = new System.Drawing.Size(711, 473);
            this.textEdit1.TabIndex = 31;
            this.textEdit1.Visible = false;
            // 
            // frmGetShot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 598);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmGetShot";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem حفظالصورةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem إرسالالصورةللمبرمجToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem إغلاقToolStripMenuItem;
        public System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.MemoEdit textEdit1;
    }
}