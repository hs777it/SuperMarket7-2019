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

namespace SuperMarket.PL.PosReturn
{
    public partial class FrmSelectListPosSales : DevExpress.XtraEditors.XtraForm
    {
        Classes.ClsPosReturn clsPosR = new Classes.ClsPosReturn();
        public FrmSelectListPosSales()
        {
            InitializeComponent();
            loaddata();
        }
        private void loaddata()
        {
            try
            {
                this.DGV_Order.DataSource = clsPosR.GetAllReturnSales();
            }
            catch
            {
                return;
            }
        }
        private void searchall()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = clsPosR.GetAllReturnSearch(TxtSearch.Text);
                this.DGV_Order.DataSource = dt;
            }
            catch
            {
                return;
            }
        }
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            searchall();
        }

        private void DGV_Order_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }
    }
}