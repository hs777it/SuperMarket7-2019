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

namespace SuperMarket.PL.IncInfo
{
    public partial class FrmInc : DevExpress.XtraEditors.XtraForm
    {
        public FrmInc()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {


                Properties.Settings.Default.COMPANY_Name = TXT_NAME.Text;

                Properties.Settings.Default.COMPANY_Adress = TXT_NOTE.Text;
                Properties.Settings.Default.COMPANY_Tel = TXT_TEL.Text;
                Properties.Settings.Default.COMPANY_Phone = TXT_MOBILE.Text;
                Properties.Settings.Default.COMPANY_Email = TXT_EMAIL.Text;
                Properties.Settings.Default.COMPANY_Web = TXT_WEB.Text;

                Properties.Settings.Default.COMPANY_Logo = TXT_PATH.Text;

                Properties.Settings.Default.Save();
                MessageBox.Show("تمت عملية الحفظ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
            }
        }

        private void FrmInc_Load(object sender, EventArgs e)
        {
            try
            {
                TXT_NAME.Text = Properties.Settings.Default.COMPANY_Name;

                TXT_NOTE.Text = Properties.Settings.Default.COMPANY_Adress;
                TXT_TEL.Text = Properties.Settings.Default.COMPANY_Tel;
                TXT_MOBILE.Text = Properties.Settings.Default.COMPANY_Phone;
                TXT_EMAIL.Text = Properties.Settings.Default.COMPANY_Email;
                TXT_WEB.Text = Properties.Settings.Default.COMPANY_Web;

                TXT_PATH.Text = Properties.Settings.Default.COMPANY_Logo;
                PIC_LOGO.Image = Image.FromFile(Properties.Settings.Default.COMPANY_Logo);
            }
            catch
            {
            }
        }

        private void BTN_BROWS_IMAGE_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "ملفات الصور|*.JPG;*.PNG;*.GIF;*.BMP";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    PIC_LOGO.Image = Image.FromFile(ofd.FileName);


                    TXT_PATH.Text = ofd.FileName;
                    Properties.Settings.Default.COMPANY_Logo = ofd.FileName;

                    Properties.Settings.Default.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("", "" + ex);
            }
        }
    }
}