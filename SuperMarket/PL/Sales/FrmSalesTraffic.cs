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
    public partial class FrmSalesTraffic : DevExpress.XtraEditors.XtraForm
    {
        Classes.ClsMain ClsMain = new Classes.ClsMain();
        public FrmSalesTraffic()
        {
            InitializeComponent();
            var dateNow = DateTime.Now;
            DateFrom.DateTime = dateNow;
            DateTo.DateTime = dateNow;
            BetweenSales();
        }

        private void textEdit14_Properties_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BetweenSales()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = ClsMain.BetweenSales(DateFrom.DateTime, DateTo.DateTime);
                this.DGV_Sales.DataSource = dt;
                Total_Amount.Text =
                        (from DataGridViewRow row in DGV_Sales.Rows
                         where row.Cells[4].FormattedValue.ToString() != string.Empty
                         select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
            }
            catch
            {
                return;
            }
        }

        private void DateFrom_EditValueChanged(object sender, EventArgs e)
        {
            BetweenSales();
        }

        private void Total_Amount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ConvertNumbersToArabicAlphabet a = new ConvertNumbersToArabicAlphabet(Total_Amount.Text);
                Total_Amount_Ar.Text = a.GetNumberAr();
            }
            catch
            {
                return;
            }
        }
    }
}