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
    public partial class Frm : DevExpress.XtraEditors.XtraForm
    {
        public Frm()
        {
            InitializeComponent();
        }

        private void FileSelect_Click(object sender, EventArgs e)
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
            catch
            {
                return;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {

                Properties.Settings.Default.COMPANY_Name = TxtName.Text;
                Properties.Settings.Default.COMPANY_Adress = TxtAdress.Text;
                Properties.Settings.Default.COMPANY_Tel = TxtTel.Text;
                Properties.Settings.Default.COMPANY_Phone = TxtPhone.Text;
                Properties.Settings.Default.COMPANY_Fax = TxtFax.Text;
                Properties.Settings.Default.COMPANY_Email = TxtEmail.Text;
                Properties.Settings.Default.COMPANY_Web = TxtWebSite.Text;
                Properties.Settings.Default.COMPANY_Logo = TXT_PATH.Text;

              

                Properties.Settings.Default.Save();
                MessageBox.Show("تمت عملية الحفظ", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
            }
            catch
            {
                return;
            }
        }

        private void Frm_Load(object sender, EventArgs e)
        {
            try
            {
                TxtName.Text = Properties.Settings.Default.COMPANY_Name;
                TxtAdress.Text = Properties.Settings.Default.COMPANY_Adress;
                TxtTel.Text = Properties.Settings.Default.COMPANY_Tel;
                TxtPhone.Text = Properties.Settings.Default.COMPANY_Phone;
                TxtFax.Text = Properties.Settings.Default.COMPANY_Fax;
                TxtEmail.Text = Properties.Settings.Default.COMPANY_Email;
                TxtWebSite.Text = Properties.Settings.Default.COMPANY_Web;
                TXT_PATH.Text = Properties.Settings.Default.COMPANY_Logo;
                PIC_LOGO.Image = Image.FromFile(Properties.Settings.Default.COMPANY_Logo);
            }
            catch
            {
                return;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}