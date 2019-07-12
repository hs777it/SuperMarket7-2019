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

namespace SuperMarket.PL.Customers
{
    public partial class FrmAddCustomers : DevExpress.XtraEditors.XtraForm
    {
        Classes.clsCustomers ClsCust = new Classes.clsCustomers();
        public FrmAddCustomers()
        {
            InitializeComponent();
            TxtCusId.Visible = false;
            BtnAdd.Enabled = false;
            UserName.Text = Program.UserName;
            var dateNow = DateTime.Now;
            var date = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day);
            DateSupp.DateTime = dateNow;
            TxtCusName.Focus();
        }

        private void TxtCusName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtPhone.Focus();
            }
        }

        private void TxtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtCompany.Focus();
            }
        }

        private void TxtCompany_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtAddress.Focus();
            }
        }

        private void TxtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtF.Focus();
            }
        }

        private void TxtF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtT.Focus();
            }
        }

        private void TxtT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtE.Focus();
            }
        }



        private void TxtE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtNotes.Focus();
            }
        }

        private void TxtNotes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnAdd_Click(sender, e);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try

            {
                if (TxtCusId.Text == string.Empty || TxtCusName.Text == string.Empty || TxtPhone.Text == string.Empty
           || TxtCompany.Text == string.Empty || TxtAddress.Text == string.Empty || TxtNotes.Text == string.Empty)
                {
                    return;
                }

                ClsCust.CustomersAdd(Convert.ToInt32(TxtCusId.Text), TxtCusName.Text, TxtPhone.Text, TxtCompany.Text,
                TxtAddress.Text, TxtNotes.Text, TxtF.Text, TxtT.Text, TxtE.Text, DateSupp.DateTime, UserName.Text, Convert.ToDouble(credit.Text), Convert.ToDouble(debit.Text) );
                MessageBox.Show("تم إضافة المورد بنجاح", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnNew.Enabled = true;
                BtnAdd.Enabled = false;
                clear();

            }
            catch
            {
                return;
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                TxtCusId.Text = ClsCust.GetMaxCustomers().Rows[0][0].ToString();
                BtnNew.Enabled = false;
                BtnAdd.Enabled = true;
            }
            catch
            {
                return;
            }
        }
        void clear()
        {
            var dateNow = DateTime.Now;
            var date = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day);
            DateSupp.DateTime = dateNow;
            TxtCusId.Text = "";
            TxtCusName.Text = "";
            TxtPhone.Text = "";
            TxtCompany.Text = "";
            TxtAddress.Text = "";
            TxtNotes.Text = "......";
            TxtF.Text = "Facebook.com";
            TxtT.Text = "twitter.com";
            TxtE.Text = "google.com";
            credit.Text = "0";
            debit.Text = "0";
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}