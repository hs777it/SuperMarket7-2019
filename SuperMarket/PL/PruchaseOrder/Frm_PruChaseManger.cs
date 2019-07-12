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

namespace SuperMarket.PL.PruChaseOrder
{
    public partial class Frm_PruChaseManger : DevExpress.XtraEditors.XtraForm
    {
        Classes.ClsPruChaseOrder ClsPru = new Classes.ClsPruChaseOrder();
        int id;
        public Frm_PruChaseManger()
        {
            InitializeComponent();
            StData();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            PL.PruChaseOrder.Frn_PruChaseOrder frm =new PL.PruChaseOrder.Frn_PruChaseOrder();
            try
            {
                frm.PurOrder_Id.Text = ClsPru.PruChaseOrderMaxId().Rows[0][0].ToString();
                frm.BtnNew.Enabled = false;
                frm.BtnAdd.Enabled = true;
                frm.PurOrder_Desc.Focus();
                frm.PurOrder_Desc.Text = "فاتورة مشتريات جديدة ";
                frm.PurSup_ID.Text = "1";
                frm.Sup_Name.Text = "بدون مورد";
            }
            catch
            {
                return;
            }
            frm.ShowDialog();
            this.Close();
        }

        private void StData()
        {
            try
            {
                DGV_PruChaseOrder.DataSource = ClsPru.GetAllPurshceManger();
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
                    ClsPru.DeletePurBill(id);
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

        private void BtnPrintSingle_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Reports.Purchase.OnePruchaseBill report = new Reports.Purchase.OnePruchaseBill();
                int id = Convert.ToInt32(this.DGV_PruChaseOrder.CurrentRow.Cells[0].Value.ToString());
                report.SetDataSource(ClsPru.PrintOne(id));
                Reports.Frm_CrstalReport frm = new Reports.Frm_CrstalReport();
                frm.crystalReportViewer1.ReportSource = report;
                frm.ShowDialog();
                this.Cursor = Cursors.Default;
            }
            catch 
            {
                MessageBox.Show("خطأ بعملية الطباعة" , "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

        }

        private void BtnPrintAll_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Reports.Purchase.AllPruchaseBill report = new Reports.Purchase.AllPruchaseBill();
                report.SetDataSource(ClsPru.PrintAllPuchase());
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

    }
}