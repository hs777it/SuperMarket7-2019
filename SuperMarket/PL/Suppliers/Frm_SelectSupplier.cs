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
    public partial class Frm_SelectSupplier : DevExpress.XtraEditors.XtraForm
    {
        Classes.ClsSuppliers ClsCat = new Classes.ClsSuppliers();
        public Frm_SelectSupplier()
        {
            InitializeComponent();
            DGvPreview();
        }
       public  void DGvPreview()
        {
            try
            {

                DGVSelectSupplier.DataSource = ClsCat.GetAllSuppliers();
                DGVSelectSupplier.Columns[0].Visible = false;
                //dataGridView1.Columns[1].Visible = false;
                DGVSelectSupplier.Columns[2].Visible = false;
                DGVSelectSupplier.Columns[3].Visible = false;
                DGVSelectSupplier.Columns[4].Visible = false;
                DGVSelectSupplier.Columns[5].Visible = false;
                DGVSelectSupplier.Columns[6].Visible = false;
                DGVSelectSupplier.Columns[7].Visible = false;
                DGVSelectSupplier.Columns[8].Visible = false;
                DGVSelectSupplier.Columns[9].Visible = false;
                DGVSelectSupplier.Columns[10].Visible = false;
                DGVSelectSupplier.Columns[11].Visible = false;
                DGVSelectSupplier.Columns[12].Visible = false;
                DGVSelectSupplier.Columns[13].Visible = false;

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

                this.DGVSelectSupplier.DataSource = ClsCat.SuppliersSearch(SearchUsers.Text);
                DGVSelectSupplier.Columns[0].Visible = false;
                DGVSelectSupplier.Columns[2].Visible = false;
                DGVSelectSupplier.Columns[3].Visible = false;
                DGVSelectSupplier.Columns[4].Visible = false;
                DGVSelectSupplier.Columns[5].Visible = false;
                DGVSelectSupplier.Columns[6].Visible = false;
                DGVSelectSupplier.Columns[7].Visible = false;
                DGVSelectSupplier.Columns[8].Visible = false;
                DGVSelectSupplier.Columns[9].Visible = false;
                DGVSelectSupplier.Columns[10].Visible = false;
                DGVSelectSupplier.Columns[11].Visible = false;
                DGVSelectSupplier.Columns[12].Visible = false;
                DGVSelectSupplier.Columns[13].Visible = false;
            }
            catch
            {
                return;
            }
        }

        private void إغلاقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Suppliers.Frm_AddSpplier frm = new PL.Suppliers.Frm_AddSpplier();
            frm.Show();
        }

        private void DGVSelectSupplier_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_SelectSupplier_Load(object sender, EventArgs e)
        {
           this. DGVSelectSupplier.DataSource = ClsCat.GetAllSuppliers();
            DGvPreview();
        }
    }
}