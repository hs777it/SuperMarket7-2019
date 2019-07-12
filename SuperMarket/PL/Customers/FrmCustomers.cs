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
    public partial class FrmCustomers : DevExpress.XtraEditors.XtraForm
    {
        Classes.clsCustomers ClsCust = new Classes.clsCustomers();
        public FrmCustomers()
        {
            InitializeComponent();
            TxtCusId.Visible = false;
            BtnAdd.Enabled = false;
            BtnEdit.Enabled = false;
            BtnDel.Enabled = false;
            UserName.Text = Program.UserName;
            DGvPreview();
            var dateNow = DateTime.Now;
            var date = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day);
            DateSupp.DateTime = dateNow;
            TxtCusName.Focus();
        }
        void clear()
        {
            var dateNow = DateTime.Now;
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

        void DGvPreview()
        {
            try
            {

                DGV_Cust.DataSource = ClsCust.GetAllCustomers();
                DGV_Cust.Columns[3].Visible = false;
                DGV_Cust.Columns[5].Visible = false;
                DGV_Cust.Columns[6].Visible = false;
                DGV_Cust.Columns[7].Visible = false;
                DGV_Cust.Columns[8].Visible = false;
                DGV_Cust.Columns[9].Visible = false;
                DGV_Cust.Columns[10].Visible = false;
                DGV_Cust.Columns[11].Visible = false;
                DGV_Cust.Columns[12].Visible = false;
                DGV_Cust.Columns[13].Visible = false;

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

                ClsCust.CustomersAdd(Convert.ToInt32(TxtCusId.Text), TxtCusName.Text, TxtPhone.Text,  TxtF.Text,
                    TxtT.Text, TxtE.Text, TxtNotes.Text, TxtCompany.Text, TxtAddress.Text,DateSupp.DateTime, UserName.Text, Convert.ToDouble(credit.Text), Convert.ToDouble(debit.Text));
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

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtCusName.Text == "بدون عميل")
                {
                    MessageBox.Show("خطأ! لايمكنك تعديل احدى مكونات النظام ", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                if (TxtCusId.Text == string.Empty | TxtCusName.Text == string.Empty | TxtPhone.Text == string.Empty
                | TxtCompany.Text == string.Empty | TxtAddress.Text == string.Empty | TxtNotes.Text == string.Empty)
                {
                    return;
                }

                DialogResult dialog = MessageBox.Show("هل انت متأكد من انك تريد تعديل البيانات؟", "واى إن للبرمجيات", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.No)
                {
                    return;
                }
                int Id = Convert.ToInt32(TxtCusId.Text);

                ClsCust.CustomersEdite(TxtCusName.Text, TxtPhone.Text, TxtF.Text,
                    TxtT.Text, TxtE.Text, TxtNotes.Text, TxtCompany.Text, TxtAddress.Text, DateSupp.DateTime, UserName.Text, Id,
                    Convert.ToDouble(credit.Text), Convert.ToDouble(debit.Text));
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
                if (TxtCusName.Text == "بدون عميل")
                {
                    MessageBox.Show("خطأ! لايمكنك حذف احدى مكونات النظام ", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                DialogResult dialog = MessageBox.Show("هل انت متأكد من انك تريد الحذف ؟", "واى إن للبرمجيات", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.No)
                {
                    return;
                }
                int Id = Convert.ToInt32(TxtCusId.Text);
                ClsCust.CustomersDelete(Id);
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

        private void DGV_Cust_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                TxtCusId.Text = DGV_Cust.CurrentRow.Cells[0].Value.ToString();
                TxtCusName.Text = DGV_Cust.CurrentRow.Cells[1].Value.ToString();
                TxtPhone.Text = DGV_Cust.CurrentRow.Cells[2].Value.ToString();
                TxtCompany.Text = DGV_Cust.CurrentRow.Cells[7].Value.ToString();
                TxtAddress.Text = DGV_Cust.CurrentRow.Cells[8].Value.ToString();
                TxtNotes.Text = DGV_Cust.CurrentRow.Cells[6].Value.ToString();
                TxtF.Text = DGV_Cust.CurrentRow.Cells[3].Value.ToString();
                TxtT.Text = DGV_Cust.CurrentRow.Cells[4].Value.ToString();
                TxtE.Text = DGV_Cust.CurrentRow.Cells[5].Value.ToString();
                DateSupp.Text = DGV_Cust.CurrentRow.Cells[9].Value.ToString();
                UserName.Text = DGV_Cust.CurrentRow.Cells[10].Value.ToString();
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

        private void SearchUsers_TextChanged(object sender, EventArgs e)
        {
            try
            {

                this.DGV_Cust.DataSource = ClsCust.CustomersSearch(SearchUsers.Text);
                DGV_Cust.Columns[8].Visible = false;
                DGV_Cust.Columns[9].Visible = false;
                DGV_Cust.Columns[10].Visible = false;
                DGV_Cust.Columns[11].Visible = false;
                DGV_Cust.Columns[12].Visible = false;
                DGV_Cust.Columns[13].Visible = false;
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

        private void SinglePrint_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                int id;
                id = Convert.ToInt32(this.DGV_Cust.CurrentRow.Cells[0].Value);
                Reports.cust.FrmCustPrint fm = new Reports.cust.FrmCustPrint();
                fm.PrintSingleCustomerTableAdapter.Fill(fm.SuperMarket_DBDataSetCust.PrintSingleCustomer, id);
                fm.reportViewer1.RefreshReport();
                fm.reportViewer1.BringToFront();
                fm.reportViewer2.SendToBack();
                fm.ShowDialog();
                this.Cursor = Cursors.Default;

            }
            catch
            {

                return;
            }
        }

        private void AllPrint_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Reports.cust.FrmCustPrint fm = new Reports.cust.FrmCustPrint();
                fm.PrintALLCustomerTableAdapter.Fill(fm.SuperMarket_DBDataSetCust.PrintALLCustomer);
                fm.reportViewer2.RefreshReport();
                fm.reportViewer2.BringToFront();
                fm.reportViewer1.SendToBack();
                fm.ShowDialog();
                this.Cursor = Cursors.Default;

            }
            catch
            {

                return;
            }
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                if (DGV_Cust.CurrentRow.Cells[1].Value.ToString() == "بدون عميل")
                {
                    MessageBox.Show("خطأ! لايمكنك تعديل احدى مكونات النظام ", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                TxtCusId.Text = DGV_Cust.CurrentRow.Cells[0].Value.ToString();
                TxtCusName.Text = DGV_Cust.CurrentRow.Cells[1].Value.ToString();
                TxtPhone.Text = DGV_Cust.CurrentRow.Cells[2].Value.ToString();
                TxtCompany.Text = DGV_Cust.CurrentRow.Cells[7].Value.ToString();
                TxtAddress.Text = DGV_Cust.CurrentRow.Cells[8].Value.ToString();
                TxtNotes.Text = DGV_Cust.CurrentRow.Cells[6].Value.ToString();
                TxtF.Text = DGV_Cust.CurrentRow.Cells[3].Value.ToString();
                TxtT.Text = DGV_Cust.CurrentRow.Cells[4].Value.ToString();
                TxtE.Text = DGV_Cust.CurrentRow.Cells[5].Value.ToString();
                DateSupp.Text = DGV_Cust.CurrentRow.Cells[9].Value.ToString();
                UserName.Text = DGV_Cust.CurrentRow.Cells[10].Value.ToString();
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
                if (DGV_Cust.CurrentRow.Cells[1].Value.ToString() == "بدون عميل")
                {
                    MessageBox.Show("خطأ! لايمكنك حذف احدى مكونات النظام ", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                DialogResult dialog = MessageBox.Show("هل انت متأكد من انك تريد الحذف ؟", "واى إن للبرمجيات", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.No)
                {
                    return;
                }
                int Id = Convert.ToInt32(DGV_Cust.CurrentRow.Cells[0].Value.ToString());
                ClsCust.CustomersDelete(Id);
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

        private void طباعةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                int id;
                id = Convert.ToInt32(this.DGV_Cust.CurrentRow.Cells[0].Value);
                Reports.cust.FrmCustPrint fm = new Reports.cust.FrmCustPrint();
                fm.PrintSingleCustomerTableAdapter.Fill(fm.SuperMarket_DBDataSetCust.PrintSingleCustomer, id);
                fm.reportViewer1.RefreshReport();
                fm.reportViewer1.BringToFront();
                fm.reportViewer2.SendToBack();
                fm.ShowDialog();
                this.Cursor = Cursors.Default;

            }
            catch
            {

                return;
            }
        }
    }
}