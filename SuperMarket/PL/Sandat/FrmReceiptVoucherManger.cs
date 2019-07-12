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

namespace SuperMarket.PL.Sandat
{
    public partial class FrmReceiptVoucherManger : DevExpress.XtraEditors.XtraForm
    {
        Classes.ClsReceiptVoucher ClsRV = new Classes.ClsReceiptVoucher();
        public FrmReceiptVoucherManger()
        {
            InitializeComponent();
            StData();
        }
        private void StData()
        {
            try
            {
                DGV_PruChaseOrder.DataSource = ClsRV.GetAllVoucher();
            }
            catch
            {
                return;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            PL.Sandat.FrmReceiptVoucher frm = new PL.Sandat.FrmReceiptVoucher();
            frm.Text = "تعديل سند الصرف";
            frm.BtnNew.Visible = false;
            frm.BtnSave.Visible = false;
            //frm.BtnAdd.SendToBack();
            frm.BtnEdit.Location = new Point(151, 244);
            frm.BtnEdit.BringToFront();
            try
            {
                frm.VoucherCode.Text = this.DGV_PruChaseOrder.CurrentRow.Cells[0].Value.ToString();
                frm.VoucherRNum.Text = this.DGV_PruChaseOrder.CurrentRow.Cells[1].Value.ToString();
                frm.VoucherDate.Text = this.DGV_PruChaseOrder.CurrentRow.Cells[2].Value.ToString();
                frm.VoucherAmount.Text = this.DGV_PruChaseOrder.CurrentRow.Cells[3].Value.ToString();
                frm.VoucherAmountAr.Text = this.DGV_PruChaseOrder.CurrentRow.Cells[4].Value.ToString();
                frm.VoucherFrom.Text = this.DGV_PruChaseOrder.CurrentRow.Cells[5].Value.ToString();
                frm.statement.Text = this.DGV_PruChaseOrder.CurrentRow.Cells[6].Value.ToString();
                frm.UserVoucher.Text = this.DGV_PruChaseOrder.CurrentRow.Cells[7].Value.ToString();
                frm.ShowDialog();
                StData();
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
                DialogResult dialog = MessageBox.Show("هل انت متأكد من انك تريد الحذف ؟", "واى إن للبرمجيات", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.No)
                {
                    return;
                }


                int Id = Convert.ToInt32(this.DGV_PruChaseOrder.CurrentRow.Cells[0].Value.ToString());

                ClsRV.DeleteVoucher(Id);
                MessageBox.Show("تمت عملية الحذف بنجاح", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StData();

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
                Reports.sanadat.PrintVoucher report = new Reports.sanadat.PrintVoucher();
                int order_ID = Convert.ToInt32(this.DGV_PruChaseOrder.CurrentRow.Cells[0].Value.ToString());
                report.SetParameterValue("@ID", order_ID);
                Reports.Frm_CrstalReport frm = new Reports.Frm_CrstalReport();
                frm.crystalReportViewer1.ReportSource = report;
                frm.ShowDialog();
                this.Cursor = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("خطأ بعملية الطباعة", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
                return;
            }
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            simpleButton1_Click(sender, e);
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnDelete_Click(sender, e);
        }

        private void طباعةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnPrintSingle_Click(sender, e);
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            PL.Sandat.FrmReceiptVoucher frm = new PL.Sandat.FrmReceiptVoucher();
            try
            {
                frm.VoucherCode.Text = ClsRV.GetMaxVoucher().Rows[0][0].ToString();
                frm.BtnSave.Enabled = true;
                frm.BtnNew.Enabled = false;
            }
            catch
            {
                return;
            }


            frm.ShowDialog();
        }
        private void SearchAll()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = ClsRV.SearchVoucher(TxtSearch.Text);
                DGV_PruChaseOrder.DataSource = dt;
            }
            catch
            {
                return;
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchAll();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            PL.Sandat.FrmReceiptVoucher frm = new PL.Sandat.FrmReceiptVoucher();
            frm.Text = "تعديل سند الصرف";
            frm.BtnNew.Visible = false;
            frm.BtnSave.Visible = false;
            //frm.BtnAdd.SendToBack();
            frm.BtnEdit.Location = new Point(152, 311);
            frm.BtnEdit.BringToFront();
            try
            {
                frm.VoucherCode.Text = this.DGV_PruChaseOrder.CurrentRow.Cells[0].Value.ToString();
                frm.VoucherRNum.Text = this.DGV_PruChaseOrder.CurrentRow.Cells[1].Value.ToString();
                frm.VoucherDate.Text = this.DGV_PruChaseOrder.CurrentRow.Cells[2].Value.ToString();
                frm.VoucherAmount.Text = this.DGV_PruChaseOrder.CurrentRow.Cells[3].Value.ToString();
                frm.VoucherAmountAr.Text = this.DGV_PruChaseOrder.CurrentRow.Cells[4].Value.ToString();
                frm.VoucherFrom.Text = this.DGV_PruChaseOrder.CurrentRow.Cells[5].Value.ToString();
                frm.statement.Text = this.DGV_PruChaseOrder.CurrentRow.Cells[6].Value.ToString();
                frm.UserVoucher.Text = this.DGV_PruChaseOrder.CurrentRow.Cells[7].Value.ToString();
                frm.TxtNewDofaa.Text = this.DGV_PruChaseOrder.CurrentRow.Cells[8].Value.ToString();
                frm.TxtNewDofaaAr.Text = this.DGV_PruChaseOrder.CurrentRow.Cells[9].Value.ToString();
                frm.txtBaqi.Text = this.DGV_PruChaseOrder.CurrentRow.Cells[10].Value.ToString();
                frm.txtBaqiAr.Text = this.DGV_PruChaseOrder.CurrentRow.Cells[11].Value.ToString();
                frm.ShowDialog();
                StData();
            }
            catch
            {
                return;
            }
        }

        private void BtnNew_Click_1(object sender, EventArgs e)
        {
            PL.Sandat.FrmReceiptVoucher frm = new PL.Sandat.FrmReceiptVoucher();
            try
            {
                frm.VoucherCode.Text = ClsRV.GetMaxVoucher().Rows[0][0].ToString();
                frm.BtnSave.Enabled = true;
                frm.BtnNew.Enabled = false;
            }
            catch
            {
                return;
            }

            frm.ShowDialog();
            StData();
        }

        private void BtnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("هل انت متأكد من انك تريد الحذف ؟", "واى إن للبرمجيات", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.No)
                {
                    return;
                }


                int Id = Convert.ToInt32(this.DGV_PruChaseOrder.CurrentRow.Cells[0].Value.ToString());

                ClsRV.DeleteVoucher(Id);
                MessageBox.Show("تمت عملية الحذف بنجاح", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StData();

            }
            catch
            {
                return;
            }
        }

        private void BtnPrintSingle_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Reports.sanadat.PrintVoucher report = new Reports.sanadat.PrintVoucher();
                int order_ID = Convert.ToInt32(this.DGV_PruChaseOrder.CurrentRow.Cells[0].Value.ToString());
                report.SetParameterValue("@ID", order_ID);
                Reports.Frm_CrstalReport frm = new Reports.Frm_CrstalReport();
                frm.crystalReportViewer1.ReportSource = report;
                frm.ShowDialog();
                this.Cursor = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("خطأ بعملية الطباعة", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
                return;
            }
        }

        private void BtnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}