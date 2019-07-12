using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket.Reports.SuppliersPrint
{
    public partial class SuppliersPrintMicro : Form
    {
        public SuppliersPrintMicro()
        {
            InitializeComponent();
            this.Width = 880;
            this.Height = Screen.PrimaryScreen.Bounds.Height - 50; //790
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void SuppliersPrintMicro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SuperMarket_DBDataSet.PrintALLSuppliers' table. You can move, or remove it, as needed.
            //this.PrintALLSuppliersTableAdapter.Fill(this.SuperMarket_DBDataSet.PrintALLSuppliers);
            // TODO: This line of code loads data into the 'SuperMarket_DBDataSet.PrintSingleSuppliers' table. You can move, or remove it, as needed.
            //this.PrintSingleSuppliersTableAdapter.Fill(this.SuperMarket_DBDataSet.PrintSingleSuppliers);

            //this.reportViewer1.RefreshReport();
        }
    }
}
