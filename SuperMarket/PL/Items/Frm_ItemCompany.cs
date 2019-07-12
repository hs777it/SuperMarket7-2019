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

namespace SuperMarket.PL.Items
{
    public partial class Frm_ItemCompany : DevExpress.XtraEditors.XtraForm
    {
        Classes.ClsItemCompany ClsCo = new Classes.ClsItemCompany();
        DataTable Dt = new DataTable();
        public Frm_ItemCompany()
        {
            InitializeComponent();
            loadData();
            TxtItemCompany.Focus();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtItemCompany_KeyDown(object sender, KeyEventArgs e)
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
                Txtadress.Focus();
            }
        }

        private void Txtadress_KeyDown(object sender, KeyEventArgs e)
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
                if (TxtItemId.Text == string.Empty)
                {
                    MessageBox.Show("خانة رقم الصنف فارغة !!", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                ClsCo.InsertItemsComapny(Convert.ToInt32(TxtItemId.Text), TxtItemCompany.Text, TxtPhone.Text, Txtadress.Text);
                MessageBox.Show("تم إضافة شركة الصنف بنجاح", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
                clear();
            }
            catch
            {
                return;
            }
        }

        private void Frm_ItemCompany_Load(object sender, EventArgs e)
        {
            loadData();
            try
            {
                for (int i = 0; i < this.DGV_company.Rows.Count; i++)
                {

                    if (this.DGV_company.Rows[i].Cells["رقم الصنف"].Value.ToString() == TxtItemId.Text )
                    {
                        MessageBox.Show("تم بالفعل إضافة شركة لهذا الصنف", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtItemId.Text = string.Empty;
                        return;
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void loadData()
        {
            try
            {
                this.DGV_company.DataSource = ClsCo.GetAllItemsComapny();
            }
            catch
            {
                return;
            }
        }
              private void clear()
        {
            try
            {
                TxtItemId.Text = "";
                TxtItemCompany.Text = "";
                TxtPhone.Text = "";
                Txtadress.Text = "";
            }
            catch
            {
                return;
            }
        }

        private void DGV_company_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtItemId.Text = DGV_company.CurrentRow.Cells[0].Value.ToString();
                TxtItemCompany.Text = DGV_company.CurrentRow.Cells[1].Value.ToString();
                TxtPhone.Text = DGV_company.CurrentRow.Cells[2].Value.ToString();
                Txtadress.Text = DGV_company.CurrentRow.Cells[3].Value.ToString();
                
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
                if (TxtItemId.Text == string.Empty)
                {
                    MessageBox.Show("برجاء اختيار صنف!!", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                DialogResult dialog = MessageBox.Show("هل انت متأكد من انك تريد الحذف؟", "واى إن للبرمجيات", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.No)
                {
                    return;
                }

                int Id = Convert.ToInt32(TxtItemId.Text);
                ClsCo.DeleteItemsComapny(Id);
                MessageBox.Show("تم الحذف بنجاح", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                clear();
                loadData();
            }
            catch
            {
                return;
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("هل انت متأكد من انك تريد تعديل البيانات؟", "واى إن للبرمجيات", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.No)
                {
                    return;
                }
                if (TxtItemId.Text == string.Empty)
                {
                    MessageBox.Show("خانة رقم الصنف فارغة !!", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                ClsCo.UpdateItemsComapny(Convert.ToInt32(TxtItemId.Text), TxtItemCompany.Text, TxtPhone.Text, Txtadress.Text);
                MessageBox.Show("تم التعديل بنجاح", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
                clear();
            }
            catch
            {
                return;
            }
        }

        private void SearchUsers_TextChanged(object sender, EventArgs e)
        {

            try
            {
                this.DGV_company.DataSource = ClsCo.SearchAllItemsComapny(SearchUsers.Text);
            }
            catch
            {
                return;
            }
        }

        private void حذفهذاالسطرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnDel_Click(sender, e);
        }

        //private void حذفالكلToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Dt.Clear();
        //        Dgv.DataSource = null;
        //        CreateDataTable();
        //    }
        //    catch
        //    {
        //        return;
        //    }
        //}

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnEdit_Click(sender, e);
        }
    }
}