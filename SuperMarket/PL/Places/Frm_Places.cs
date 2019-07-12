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

namespace SuperMarket.PL.Places
{
    public partial class Frm_Places : DevExpress.XtraEditors.XtraForm
    {
        Classes.ClsPlaces ClsP = new Classes.ClsPlaces();
        public Frm_Places()
        {
            InitializeComponent();
            loadData();
            CmbFloar.Focus();
        }
        private void loadData()
        {
            try
            {
                this.DGV_Places .DataSource = ClsP.GetAllPlaces();
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
                CmbFloar.Text = "";
                CmbPlaces.Text = "";
                CmbStand.Text = "";
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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtItemId.Text == string.Empty || CmbFloar.SelectedItem==null || CmbStand.SelectedItem == null ||CmbPlaces.SelectedItem == null )
                {
                    MessageBox.Show("برجاء اكمال الخانات اولاً !!", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                ClsP.InsertAllPlaces(Convert.ToInt32(TxtItemId.Text), CmbFloar.Text, CmbStand.Text, CmbPlaces.Text);
                MessageBox.Show("تم إضافة شركة الصنف بنجاح", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
                clear();
            }
            catch
            {
                return;
            }
        }

        private void Frm_Places_Load(object sender, EventArgs e)
        {
            loadData();
            try
            {
                for (int i = 0; i < this.DGV_Places.Rows.Count; i++)
                {

                    if (this.DGV_Places.Rows[i].Cells["رقم الصنف"].Value.ToString() == TxtItemId.Text)
                    {
                        MessageBox.Show("تم بالفعل إضافة مكان لهذا الصنف", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
               
                DialogResult dialog = MessageBox.Show("هل انت متأكد من انك تريد تعديل البيانات؟", "واى إن للبرمجيات", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.No)
                {
                    return;
                }
                if (TxtItemId.Text == string.Empty || CmbFloar.SelectedItem == null || CmbStand.SelectedItem == null || CmbPlaces.SelectedItem == null )
                {
                    MessageBox.Show("برجاء اكمال الخانات اولاً !!", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                
                ClsP.UpdateAllPlaces(Convert.ToInt32(TxtItemId.Text), CmbFloar.Text, CmbStand.Text, CmbPlaces.Text);
                MessageBox.Show("تم التعديل بنجاح", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
                clear();
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
                if (TxtItemId.Text == string.Empty )
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
                ClsP.DeletePlaces(Id);
                MessageBox.Show("تم الحذف بنجاح", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                clear();
                loadData();
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
                this.DGV_Places.DataSource = ClsP.SearchPlaces(SearchUsers.Text);
            }
            catch
            {
                return;
            }
        }

        private void DGV_Places_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                
                TxtItemId.Text = DGV_Places.CurrentRow.Cells[0].Value.ToString();
                CmbFloar.Text = DGV_Places.CurrentRow.Cells[1].Value.ToString();
                CmbStand.Text = DGV_Places.CurrentRow.Cells[2].Value.ToString();
                CmbPlaces.Text = DGV_Places.CurrentRow.Cells[3].Value.ToString();

            }
            catch
            {
                return;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            loadData();
            clear();
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