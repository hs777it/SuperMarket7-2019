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

namespace SuperMarket.PL.Store
{
    public partial class Frm_Stores : DevExpress.XtraEditors.XtraForm
    {
        Classes.ClsStores ClsStore = new Classes.ClsStores();
        public Frm_Stores()
        {
            InitializeComponent();
            BtnAdd.Enabled = false;
            BtnEdit.Enabled = false;
            BtnDel.Enabled = false;
            clear();
            DGvPreview();
            TxtUser.Text = Program.UserName;
            TxtStoreName.Focus();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                TxtSoreId.Text = ClsStore.UsersMaxId().Rows[0][0].ToString();
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
            if (TxtSoreId.Text == string.Empty || TxtStoreName.Text == string.Empty || TxtStoreAdress.Text == string.Empty
              || TxtStoreAdmin.Text == string.Empty || TxtUser.Text == string.Empty )
            {
                MessageBox.Show("رجاء اكمال البيانات!!", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                ClsStore.AddStore(Convert.ToInt32(TxtSoreId.Text), TxtStoreName.Text, TxtStoreAdress.Text,
                    TxtStoreAdmin.Text,  TxtUser.Text);
                MessageBox.Show("تم العملية بنجاح", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnNew.Enabled = true;
                BtnAdd.Enabled = false;
                clear();
                DGvPreview();
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

        void DGvPreview()
        {
            try
            {

                Dgv_Stores.DataSource = ClsStore.GetAllStores();
                Dgv_Stores.Columns[0].Visible = false;
                Dgv_Stores.Columns[2].Visible = false;
                Dgv_Stores.Columns[3].Visible = false;
                Dgv_Stores.Columns[4].Visible = false;
                Dgv_Stores.Columns[5].Visible = false;
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

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (TxtSoreId.Text == string.Empty || TxtStoreName.Text == string.Empty || TxtStoreAdress.Text == string.Empty
             || TxtStoreAdmin.Text == string.Empty || TxtUser.Text == string.Empty)
            {
                MessageBox.Show("رجاء اكمال البيانات!!", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                DialogResult dialog = MessageBox.Show("هل انت متأكد من انك تريد تعديل البيانات؟", "واى إن للبرمجيات", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.No)
                {
                    return;
                }
                ClsStore.UpdateStore(Convert.ToInt32(TxtSoreId.Text), TxtStoreName.Text, TxtStoreAdress.Text,
                    TxtStoreAdmin.Text, TxtUser.Text);
                MessageBox.Show("تم العملية بنجاح", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnEdit.Enabled = false;
                BtnDel.Enabled = false;
                clear();
                DGvPreview();
            }
            catch
            {
                return;
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
           
            try
            {
                DialogResult dialog = MessageBox.Show("هل انت متأكد من انك تريد حذف المخزن؟", "واى إن للبرمجيات", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.No)
                {
                    return;
                }

                int Id = Convert.ToInt32(TxtSoreId.Text);
                ClsStore.deleteStore(Id);
                MessageBox.Show("تم حذف المخزن بنجاح", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);

                BtnEdit.Enabled = false;
                BtnDel.Enabled = false;
                clear();
                DGvPreview();
            }
            catch
            {
                return;
            }
        }

        private void Dgv_Stores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtSoreId.Text = Dgv_Stores.CurrentRow.Cells[0].Value.ToString();
                TxtStoreName.Text = Dgv_Stores.CurrentRow.Cells[1].Value.ToString();
                TxtStoreAdress.Text = Dgv_Stores.CurrentRow.Cells[2].Value.ToString();
                TxtStoreAdmin.Text = Dgv_Stores.CurrentRow.Cells[3].Value.ToString();
                TxtUser.Text = Dgv_Stores.CurrentRow.Cells[4].Value.ToString();
                
                BtnEdit.Enabled = true;
                BtnDel.Enabled = true;
            }
            catch
            {
                return;
            }
        }

        private void SearchStores_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Dgv_Stores.DataSource = ClsStore.SearshStore(SearchStores.Text);
            }
            catch
            {
                return;
            }
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

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnEdit_Click(sender, e);
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnDel_Click(sender, e);
        }
    }
}