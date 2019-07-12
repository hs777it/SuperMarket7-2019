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

namespace SuperMarket.PL.Suppliers
{
    public partial class Frm_AddSpplier : DevExpress.XtraEditors.XtraForm
    {
        Classes.ClsSuppliers ClsCat = new Classes.ClsSuppliers();

        void clear()
        {
            var dateNow = DateTime.Now;
            DateSupp.DateTime = dateNow;
            TxtSuppId.Text = "";
            TxtSuppName.Text = "";
            TxtPhone.Text = "";
            TxtCompany.Text = "";
            TxtAddress.Text = "";
            TxtNotes.Text = "......";
            TxtF.Text = "Facebook.com";
            TxtT.Text = "twitter.com";
            TxtE.Text = "google.com";
            TxtW.Text = "www.google.com";
            UserName.Text = "";
            credit.Text = "0";
            debit.Text = "0";
        }
        public Frm_AddSpplier()
        {
            InitializeComponent();
            TxtSuppId.Visible = false;
            UserName.Text = Program.UserName;
            TxtSuppId.Text = ClsCat.SuppliersMaxId().Rows[0][0].ToString();
            BtnAdd.Enabled = false;
            var dateNow = DateTime.Now;
            var date = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day);
            DateSupp.DateTime = dateNow;

        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                TxtSuppId.Text = ClsCat.SuppliersMaxId().Rows[0][0].ToString();
                BtnNew.Enabled = false;
                BtnAdd.Enabled = true;
            }
            catch
            {
                return;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtSuppId.Text == string.Empty | TxtSuppName.Text == string.Empty | TxtPhone.Text == string.Empty
          | TxtCompany.Text == string.Empty | TxtAddress.Text == string.Empty | TxtNotes.Text == string.Empty )
            {
                return;
            }


            try

            {
                ClsCat.SuppliersAdd(Convert.ToInt32(TxtSuppId.Text), TxtSuppName.Text, TxtPhone.Text, TxtCompany.Text,
                TxtAddress.Text, TxtNotes.Text, TxtF.Text, TxtT.Text, TxtW.Text, TxtE.Text, DateSupp.DateTime, UserName.Text, Convert.ToDouble(credit.Text), Convert.ToDouble(debit.Text));
                MessageBox.Show("تم إضافة المورد بنجاح", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnNew.Enabled = true;
                BtnAdd.Enabled = false;
                clear();
                PL.Suppliers.Frm_SelectSupplier frm = new PL.Suppliers.Frm_SelectSupplier();
                frm.DGvPreview();

            }
            catch
            {
                return;
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}