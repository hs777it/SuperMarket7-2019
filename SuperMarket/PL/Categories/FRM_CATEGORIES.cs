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

namespace SuperMarket.PL
{
    public partial class FRM_CATEGORIES : DevExpress.XtraEditors.XtraForm
    {
        Classes.ClsCategory ClsCat = new Classes.ClsCategory();

        public FRM_CATEGORIES()
        {
            InitializeComponent();
            TxtId.Visible = false;
            BtnAdd.Enabled = false;
            BtnEdit.Enabled = false;
            BtnDel.Enabled = false;
            DGvPreview();
            
        }

        private void FRM_CATEGORIES_Load(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                TxtId.Text = ClsCat.CategoryMaxId().Rows[0][0].ToString();
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
            try
            {
                ClsCat.AddCategory(Convert.ToInt32(TxtId.Text), TxtName.Text);
                MessageBox.Show("تم إضافة إسم المجموعة بنجاح", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnNew.Enabled = true ;
                BtnAdd.Enabled = false ;
                TxtId.Text = "";
                TxtName.Text = "";
                DGvPreview();
            }
            catch
            {
                return;
            }
        }

        void DGvPreview()
        {
            try
            {
                DgvCat.DataSource = ClsCat.GetAllCategory();
            }
            catch
            {
                return;
            }
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("هل انت متأكد من انك تريد تعديل المجموعة؟", "واى إن للبرمجيات", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No)
            {
                return;
            }

            try
            {
                int Id = Convert.ToInt32(TxtId.Text );
                ClsCat.updateCategory(TxtName.Text, Id);
                MessageBox.Show("تم تعديل إسم المجموعة بنجاح", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnEdit.Enabled = false;
                BtnDel.Enabled = false;
                TxtId.Text = "";
                TxtName.Text = "";
                DGvPreview();
            }
            catch
            {
                return;
            }
        }

        private void DgvCat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtId.Text = DgvCat.CurrentRow.Cells[0].Value.ToString();
                TxtName.Text = DgvCat.CurrentRow.Cells[1].Value.ToString();

            }
            catch
            {
                return;
            }
        }

        private void TxtName_EditValueChanged(object sender, EventArgs e)
        {
            if(TxtName.Text !=string.Empty )
            {
                BtnEdit.Enabled = true;
                BtnDel.Enabled = true;
            }
            else
            {
                BtnEdit.Enabled = false ;
                BtnDel.Enabled = false ;
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("هل انت متأكد من انك تريد حذف المجموعة؟", "واى إن للبرمجيات", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No )
            {
                return;
            }

            try
            {
                int Id = Convert.ToInt32(TxtId.Text);
                ClsCat.deleteCategory(Id);
                MessageBox.Show("تم حذف إسم المجموعة بنجاح", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);

                BtnEdit.Enabled = false;
                BtnDel.Enabled = false;
                TxtId.Text = "";
                TxtName.Text = "";
                DGvPreview();
            }
            catch
            {
                return;
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