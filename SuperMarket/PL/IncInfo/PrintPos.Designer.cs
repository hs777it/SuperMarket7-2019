namespace SuperMarket.PL.IncInfo
{
    partial class PrintPos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintPos));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BTN_SAVE = new DevComponents.DotNetBar.ButtonX();
            this.CH_PRINT = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_NAME_PRINT = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(561, 233);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BTN_SAVE);
            this.tabPage1.Controls.Add(this.CH_PRINT);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.TXT_NAME_PRINT);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(553, 207);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "POS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BTN_SAVE
            // 
            this.BTN_SAVE.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_SAVE.Checked = true;
            this.BTN_SAVE.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.BTN_SAVE.Location = new System.Drawing.Point(202, 123);
            this.BTN_SAVE.Name = "BTN_SAVE";
            this.BTN_SAVE.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.BTN_SAVE.Size = new System.Drawing.Size(112, 48);
            this.BTN_SAVE.TabIndex = 6670;
            this.BTN_SAVE.TabStop = false;
            this.BTN_SAVE.Text = "حفظ";
            this.BTN_SAVE.Click += new System.EventHandler(this.BTN_SAVE_Click);
            // 
            // CH_PRINT
            // 
            this.CH_PRINT.AutoSize = true;
            this.CH_PRINT.Location = new System.Drawing.Point(293, 100);
            this.CH_PRINT.Name = "CH_PRINT";
            this.CH_PRINT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CH_PRINT.Size = new System.Drawing.Size(90, 17);
            this.CH_PRINT.TabIndex = 2;
            this.CH_PRINT.Text = "طباعة مباشرة";
            this.CH_PRINT.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم الطابعة ";
            // 
            // TXT_NAME_PRINT
            // 
            this.TXT_NAME_PRINT.Location = new System.Drawing.Point(76, 47);
            this.TXT_NAME_PRINT.Name = "TXT_NAME_PRINT";
            this.TXT_NAME_PRINT.Size = new System.Drawing.Size(307, 20);
            this.TXT_NAME_PRINT.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(553, 207);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PrintPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 233);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrintPos";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إعدادات طابعة الكاشير";
            this.Load += new System.EventHandler(this.PrintPos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        public DevComponents.DotNetBar.ButtonX BTN_SAVE;
        private System.Windows.Forms.CheckBox CH_PRINT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_NAME_PRINT;
        private System.Windows.Forms.TabPage tabPage2;
    }
}