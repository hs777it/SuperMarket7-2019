using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SuperMarket.PL.Users
{
    public partial class frmLock : DevExpress.XtraEditors.XtraForm
    {
        public frmLock()
        {
            InitializeComponent();
        }

        private void frmLock_Load(object sender, EventArgs e)
        {
            //lblMarquee.Visible = false;
            lblUsername.Focus();
            lblUsername.Text = "اسم المستخدم الحالي: " + Program.UserName;
            PL.Main.FrmMain.getMainForm.Enabled = false;
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != Program.UserName)
            {
                lblErr.Visible = true;
                lblErr.Text = "كلمة سر إلغاء القفل خطأ";
                return;
            }
            else
            {
                PL.Main.FrmMain.getMainForm.Enabled = true;
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToShortTimeString();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            btnUnlock.PerformClick();
        }
    }
}