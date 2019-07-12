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
    public partial class Frm_SelectCistomers : DevExpress.XtraEditors.XtraForm
    {
        Classes.clsCustomers ClsCust = new Classes.clsCustomers();
        public Frm_SelectCistomers()
        {
            InitializeComponent();
            DGvPreview();
        }
        void DGvPreview()
        {
            try
            {

                DGVSelectCustomers.DataSource = ClsCust.GetAllCustomers();
                DGVSelectCustomers.Columns[3].Visible = false;
                DGVSelectCustomers.Columns[5].Visible = false;
                DGVSelectCustomers.Columns[6].Visible = false;
                DGVSelectCustomers.Columns[7].Visible = false;
                DGVSelectCustomers.Columns[8].Visible = false;
                DGVSelectCustomers.Columns[9].Visible = false;
                DGVSelectCustomers.Columns[10].Visible = false;
                DGVSelectCustomers.Columns[11].Visible = false;
                DGVSelectCustomers.Columns[12].Visible = false;
                DGVSelectCustomers.Columns[13].Visible = false;

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

        private void DGVSelectCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

                this.Close();
          
        }

        private void إغلاقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Customers.FrmAddCustomers frm = new PL.Customers.FrmAddCustomers();
            try
            {
                frm.TxtCusId.Text = ClsCust.GetMaxCustomers().Rows[0][0].ToString();
                frm.BtnNew.Enabled = false;
                frm.BtnAdd.Enabled = true;
            }
            catch
            {
                return;
            }
        }

        private void SearchCust_TextChanged(object sender, EventArgs e)
        {
            try
            {

                this.DGVSelectCustomers.DataSource = ClsCust.CustomersSearch(SearchCust.Text);
                DGVSelectCustomers.Columns[8].Visible = false;
                DGVSelectCustomers.Columns[9].Visible = false;
                DGVSelectCustomers.Columns[10].Visible = false;
                DGVSelectCustomers.Columns[11].Visible = false;
                DGVSelectCustomers.Columns[12].Visible = false;
                DGVSelectCustomers.Columns[13].Visible = false;
            }
            catch
            {
                return;
            }
        }
    }
}