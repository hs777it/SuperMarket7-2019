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

namespace SuperMarket.PL.RetuenPruChase
{
    public partial class FrmSelectListPur : DevExpress.XtraEditors.XtraForm
    {
        Classes.ClsRetuenPruChase ClsRet = new Classes.ClsRetuenPruChase();
        public FrmSelectListPur()
        {
            InitializeComponent();
            loaddata();
        }
        public void loaddata()
        {
            try
            {
               
                this.DGV_Order.DataSource = ClsRet.GetAllReturnPurItems();
                DGV_Order.Columns[0].Visible = false;
                DGV_Order.Columns[6].Visible = false;
                DGV_Order.Columns[7].Visible = false;
                DGV_Order.Columns[8].Visible = false;
                DGV_Order.Columns[9].Visible = false;
            }
            catch
            {
                return;
            }
        }

        private void DGV_Order_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }
        private void searchall()
        {
            try
            {
                if(TxtSearch.Text=="")
                {
                    loaddata();
                }
                DataTable dt = new DataTable();
                dt = ClsRet.GetAllReturnPurItemsSearch(TxtSearch.Text);
                this.DGV_Order.DataSource = dt;
                DGV_Order.Columns[0].Visible = false;
                DGV_Order.Columns[6].Visible = false;
                DGV_Order.Columns[7].Visible = false;
                DGV_Order.Columns[8].Visible = false;
                DGV_Order.Columns[9].Visible = false;
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
    }
}