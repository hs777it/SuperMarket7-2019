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


namespace SuperMarket.Reports.cust
{
    public partial class FrmCustPrint : DevExpress.XtraEditors.XtraForm
    {
        public FrmCustPrint()
        {
            InitializeComponent();
            this.Width = 880;
            this.Height = Screen.PrimaryScreen.Bounds.Height - 50; //790
            this.StartPosition = FormStartPosition.CenterParent;
           
        }

        private void FrmCustPrint_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SuperMarket_DBDataSetCust.PrintSingleCustomer' table. You can move, or remove it, as needed.
            //this.PrintSingleCustomerTableAdapter.Fill(this.SuperMarket_DBDataSetCust.PrintSingleCustomer);
            // TODO: This line of code loads data into the 'SuperMarket_DBDataSetCust.PrintALLCustomer' table. You can move, or remove it, as needed.
            //this.PrintALLCustomerTableAdapter.Fill(this.SuperMarket_DBDataSetCust.PrintALLCustomer);
            // TODO: This line of code loads data into the 'SuperMarket_DBDataSetCust.PrintSingleCustomer' table. You can move, or remove it, as needed.

            //this.reportViewer1.RefreshReport();
            //this.reportViewer2.RefreshReport();

            //this.reportViewer1.RefreshReport();

        }
    }
}