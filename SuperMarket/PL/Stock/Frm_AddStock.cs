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

namespace SuperMarket.PL.Stock
{
    public partial class Frm_AddStock : DevExpress.XtraEditors.XtraForm
    {
        Classes.ClsStores ClsStore = new Classes.ClsStores();
        public Frm_AddStock()
        {        
            InitializeComponent();
            TxtUser.Text = Program.UserName;
            TxtStoreName.Focus();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtSoreId.Text == string.Empty || TxtStoreName.Text == string.Empty || TxtStoreAdress.Text == string.Empty
              || TxtStoreAdmin.Text == string.Empty || TxtUser.Text == string.Empty)
            {
                MessageBox.Show("رجاء اكمال البيانات!!", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                ClsStore.AddStore(Convert.ToInt32(TxtSoreId.Text), TxtStoreName.Text, TxtStoreAdress.Text,
                    TxtStoreAdmin.Text, TxtUser.Text);
                MessageBox.Show("تم العملية بنجاح", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clear();
                try
                {
                    TxtSoreId.Text = ClsStore.UsersMaxId().Rows[0][0].ToString();                   
                }
                catch
                {
                    return;
                }
            }
            catch
            {
                return;
            }
        }
        void clear()
        {

            TxtSoreId.Text = "";
            TxtStoreName.Text = "";
            TxtStoreAdress.Text = "";
            TxtStoreAdmin.Text = "";
        }

        private void TxtStoreName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtStoreAdress.Focus();
            }
        }

        private void TxtStoreAdress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtStoreAdmin.Focus();
            }
        }

        private void TxtStoreAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnAdd_Click(sender, e);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}