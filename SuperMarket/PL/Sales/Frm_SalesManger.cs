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
    public partial class Frm_SalesManger : DevExpress.XtraEditors.XtraForm
    {
        Classes.ClsSales ClsSales = new Classes.ClsSales();
        Classes.ClsPlaces ClsP = new Classes.ClsPlaces();
        Classes.ClsItemCompany ClsCo = new Classes.ClsItemCompany();
        int id;
        public Frm_SalesManger()
        {
            InitializeComponent();
            StData();
        }
        private void StData()
        {
            try
            {
                DGV_PruChaseOrder.DataSource = ClsSales.GetAllSalesManger();
            }
            catch
            {
                return;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد فعلا حذف الفاتورة؟", "واى إن للبرمجيات", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    id = Convert.ToInt32(DGV_PruChaseOrder.CurrentRow.Cells[0].Value.ToString());
                    ClsSales.DeleteSalesBill(id);
                    StData();
                    MessageBox.Show("تمت عملية الحذف بنجاح", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StData();
                }
                else
                {
                    MessageBox.Show("تم إلغاء عملية الحذف", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                return;
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            PL.Sales.FrmSales frm = new PL.Sales.FrmSales();
            try
            {
                frm.SalesOrder_Id.Text = ClsSales.SalesOrderMaxId().Rows[0][0].ToString();
                frm.BtnNew.Enabled = false;
                frm.BtnAdd.Enabled = true;
                frm.SalesOrder_Desc.Text = "فاتورة مبيعات رقم : " + frm.SalesOrder_Id.Text;
                frm.Cust_ID.Text = "1";
                frm.Cust_Name.Text = "بدون عميل";
                frm.TxtBarCode.Focus();
            }
            catch
            {
                return;
            }
            
            frm.ShowDialog();
            this.Close();
        }

        private void BtnPrintSingle_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Reports.SalesBill.OneSaleBill report = new Reports.SalesBill.OneSaleBill();
                int id = Convert.ToInt32(this.DGV_PruChaseOrder.CurrentRow.Cells[0].Value.ToString());
                report.SetDataSource(ClsSales.PrintOne(id));
                Reports.Frm_CrstalReport frm = new Reports.Frm_CrstalReport();
                frm.crystalReportViewer1.ReportSource = report;
                frm.ShowDialog();
                this.Cursor = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("خطأ بعملية الطباعة", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnDelete_Click(sender, e);
        }

        private void طباعةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnPrintSingle_Click(sender, e);
        }

        private void BtnPrintAll_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Reports.SalesBill.AllSalesBill report = new Reports.SalesBill.AllSalesBill();
                report.SetDataSource(ClsSales.PrintAllSalesBill());
                Reports.Frm_CrstalReport frm = new Reports.Frm_CrstalReport();
                frm.crystalReportViewer1.ReportSource = report;
                frm.ShowDialog();
                this.Cursor = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("خطأ بعملية الطباعة", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
        }
    }
}