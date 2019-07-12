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
    public partial class Frm_Suppliers : DevExpress.XtraEditors.XtraForm
    {
        Classes.ClsSuppliers  ClsCat = new Classes.ClsSuppliers();
        public Frm_Suppliers()
        {
            InitializeComponent();
            
            TxtSuppId.Visible = false;
            BtnAdd.Enabled = false;
            BtnEdit.Enabled = false;
            BtnDel.Enabled = false;
            UserName.Text = Program.UserName;
            DGvPreview();
            var dateNow = DateTime.Now;
            var date = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day);
            DateSupp.DateTime = dateNow;
        }

        void clear()
        {
            
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
            var dateNow = DateTime.Now;
            DateSupp.DateTime = dateNow;
            credit.Text = "0";
            debit.Text = "0";
        }

        void DGvPreview()
        {
            try
            {

                dataGridView1.DataSource = ClsCat.GetAllSuppliers();
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].Visible = false;
                dataGridView1.Columns[11].Visible = false;
                dataGridView1.Columns[12].Visible = false;
                dataGridView1.Columns[13].Visible = false;

                //dataGridView1.RowHeadersWidth = 100;
                //dataGridView1.Columns[0].Width = 99;
                //dataGridView1.Columns[1].Width = 199;
                //dataGridView1.Columns[2].Width = 85;
                //dataGridView1.Columns[4].Width = 93;

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

        private void TxtSuppName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtPhone .Focus();
            }
        }

        private void TxtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtCompany .Focus();
            }
        }

        private void TxtCompany_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtAddress .Focus();
            }
        }

        private void TxtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtF .Focus();
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
                TxtW.Focus();
            }
        }

        private void TxtW_KeyDown(object sender, KeyEventArgs e)
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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
           

            try

            {
                if (TxtSuppId.Text == string.Empty || TxtSuppName.Text == string.Empty || TxtPhone.Text == string.Empty
           || TxtCompany.Text == string.Empty || TxtAddress.Text == string.Empty || TxtNotes.Text == string.Empty)
                {
                    return;
                }

                ClsCat.SuppliersAdd (Convert.ToInt32(TxtSuppId.Text), TxtSuppName.Text,TxtPhone.Text,TxtCompany.Text,
                TxtAddress.Text,TxtNotes.Text,TxtF.Text,TxtT.Text,TxtW.Text,TxtE.Text, DateSupp.DateTime,UserName.Text, Convert.ToDouble(credit.Text), Convert.ToDouble(debit.Text));
                MessageBox.Show("تم إضافة المورد بنجاح", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void TxtNotes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnAdd_Click(sender,e);
            }
        }

        private void Frm_Suppliers_Load(object sender, EventArgs e)
        {
            TxtSuppName.Focus();
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

        private void button1_Click(object sender, EventArgs e)
        {
            UserName.Text = Program.UserName;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               
                TxtSuppId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                TxtSuppName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                TxtPhone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                TxtCompany.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                TxtAddress.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                TxtNotes.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                TxtF.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                TxtT.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                TxtW.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                TxtE.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                DateSupp.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                UserName.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                BtnNew.Enabled = true;
                BtnAdd.Enabled = false;
                BtnEdit.Enabled = true;
                BtnDel.Enabled = true;
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
                if (TxtSuppName.Text=="بدون مورد")
                {
                    MessageBox.Show("خطأ! لايمكنك تعديل احدى مكونات النظام ", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                if (TxtSuppId.Text == string.Empty | TxtSuppName.Text == string.Empty | TxtPhone.Text == string.Empty
                | TxtCompany.Text == string.Empty | TxtAddress.Text == string.Empty | TxtNotes.Text == string.Empty)
                {
                    return;
                }

                DialogResult dialog = MessageBox.Show("هل انت متأكد من انك تريد تعديل البيانات؟", "واى إن للبرمجيات", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.No)
                {
                    return;
                }
                int Id = Convert.ToInt32(TxtSuppId.Text);
                ClsCat .SuppliersEdite (TxtSuppName.Text, TxtPhone.Text, TxtCompany.Text,
                TxtAddress.Text, TxtNotes.Text, TxtF.Text, TxtT.Text, TxtW.Text, TxtE.Text, DateSupp.DateTime, UserName.Text, Id, Convert.ToDouble(credit.Text), Convert.ToDouble(debit.Text));
                MessageBox.Show("تم تعديل البيانات بنجاح", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (TxtSuppName.Text == "بدون مورد")
                {
                    MessageBox.Show("خطأ! لايمكنك حذف احدى مكونات النظام ", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                DialogResult dialog = MessageBox.Show("هل انت متأكد من انك تريد الحذف ؟", "واى إن للبرمجيات", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.No)
                {
                    return;
                }
                int Id = Convert.ToInt32(TxtSuppId.Text);
                ClsCat.SuppliersDelete(Id);
                MessageBox.Show("تمت عملية الحذف بنجاح", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void SearchUsers_TextChanged(object sender, EventArgs e)
        {
            try
            {
           
                this.dataGridView1.DataSource = ClsCat.SuppliersSearch(SearchUsers.Text);            
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].Visible = false;
                dataGridView1.Columns[11].Visible = false;
                dataGridView1.Columns[12].Visible = false;
                dataGridView1.Columns[13].Visible = false;
            }
            catch
            {
                return;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                int id;
                id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
                Reports.SuppliersPrint.SuppliersPrintMicro fm = new Reports.SuppliersPrint.SuppliersPrintMicro();
                fm.PrintSingleSuppliersTableAdapter.Fill(fm.SuperMarket_DBDataSet.PrintSingleSuppliers, id);
                //fm.reportViewer1.RefreshReport();
                //fm.reportViewer1.BringToFront();
                //fm.reportViewer2.SendToBack();
                fm.ShowDialog();
                this.Cursor = Cursors.Default;

            }
            catch
            {
                
                return;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Reports.SuppliersPrint.SuppliersPrintMicro fm = new Reports.SuppliersPrint.SuppliersPrintMicro();
                fm.PrintALLSuppliersTableAdapter.Fill(fm.SuperMarket_DBDataSet.PrintALLSuppliers);
                //fm.reportViewer2.RefreshReport();
                //fm.reportViewer2.BringToFront();
                //fm.reportViewer1.SendToBack();
                fm.ShowDialog();
                this.Cursor = Cursors.Default;

            }
            catch
            {

                return;
            }
        }

        private void SearchUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                if (dataGridView1.CurrentRow.Cells[1].Value.ToString() == "بدون مورد")
                {
                    MessageBox.Show("خطأ! لايمكنك تعديل احدى مكونات النظام ", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                TxtSuppId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                TxtSuppName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                TxtPhone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                TxtCompany.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                TxtAddress.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                TxtNotes.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                TxtF.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                TxtT.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                TxtW.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                TxtE.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                DateSupp.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                UserName.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                BtnNew.Enabled = true;
                BtnAdd.Enabled = false;
                BtnEdit.Enabled = true;
                BtnDel.Enabled = true;
            }
            catch
            {
                return;
            }
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Cells[1].Value.ToString() == "بدون مورد")
                {
                    MessageBox.Show("خطأ! لايمكنك حذف احدى مكونات النظام ", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                DialogResult dialog = MessageBox.Show("هل انت متأكد من انك تريد الحذف ؟", "واى إن للبرمجيات", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.No)
                {
                    return;
                }
                int Id = Convert.ToInt32(TxtSuppId.Text);
                ClsCat.SuppliersDelete(Id);
                MessageBox.Show("تمت عملية الحذف بنجاح", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void طباعةالموردToolStripMenuItem_Click(object sender, EventArgs e)
        {
            simpleButton2_Click(sender, e);
        }
    }
}