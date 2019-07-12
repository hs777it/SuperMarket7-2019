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
using SuperMarket.Properties;
namespace SuperMarket.PL.License
{
    public partial class FrmRenew : DevExpress.XtraEditors.XtraForm
    {
        public FrmRenew()
        {
            InitializeComponent();
            groupPanel1.BringToFront();
            textBoxX3.BringToFront();
            textBoxX3.Focus();
        }

        private void textBoxX2_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (textBoxX2.Text == "1")
                    {
                        Settings.Default.Reset();
                        MessageBox.Show("تم تجديد الفترة التجربية بنجاح");
                        textBoxX2.Text = "";
                        textBoxX2.Focus();
                    }
                    if (textBoxX2.Text == "4")
                    {
                        this.Hide();
                        PL.License.FrmLicense frm = new PL.License.FrmLicense();
                        frm.ShowDialog();
                        this.Close();
                    }
                }
            }
            catch 
            {

                return;
            }
        }

        private void textBoxX3_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {

                    if (textBoxX3.Text == "3051999niI")
                    {
                        groupPanel1.SendToBack();
                        textBoxX3.SendToBack();
                        textBoxX2.Focus();
                    }
                }
            }
            catch 
            {

                return;
            }
        }
    }
}