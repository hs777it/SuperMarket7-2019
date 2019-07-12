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

namespace SuperMarket.PL.Sales
{
    public partial class FrmItemList : DevExpress.XtraEditors.XtraForm
    {
        Classes.ClsItems ClsItem = new Classes.ClsItems();
        public FrmItemList()
        {
            InitializeComponent();           
            LoadData();
            TxtSearch.Focus();
           
        }
        private void LoadData()
        {
            try
            {
                DGVSelectIems.DataSource = ClsItem.GatAllItems();
                //DGVSelectIems.Columns[0].Visible = false;
                DGVSelectIems.Columns[1].Visible = false;
                //DGVSelectIems.Columns[2].Visible = false;
                DGVSelectIems.Columns[3].Visible = false;
                DGVSelectIems.Columns[4].Visible = false;
                //DGVSelectIems.Columns[5].Visible = false;
                //DGVSelectIems.Columns[6].Visible = false;
                DGVSelectIems.Columns[7].Visible = false;
                //DGVSelectIems.Columns[8].Visible = false;
                DGVSelectIems.Columns[9].Visible = false;
                DGVSelectIems.Columns[10].Visible = false;
                DGVSelectIems.Columns[11].Visible = false;
                DGVSelectIems.Columns[12].Visible = false;
                DGVSelectIems.Columns[13].Visible = false;
            }
            catch
            {
                return;
            }
        }
        private void SearchAll()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = ClsItem.SearchItems(TxtSearch.Text);
                DGVSelectIems.DataSource = dt;
            }
            catch
            {
                return;
            }
        }
        private void DGVSelectIems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchAll();
        }

        private void FrmItemList_Leave(object sender, EventArgs e)
        {

            
        }
    }
}