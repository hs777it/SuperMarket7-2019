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

namespace SuperMarket.PL.Return
{
    public partial class FrmSalesReturnManger : DevExpress.XtraEditors.XtraForm
    {
        Classes.ClsReturnItems ClsRet = new Classes.ClsReturnItems();

        public FrmSalesReturnManger()
        {
            InitializeComponent();
            loaddata();
            TxtSearch.Text = "";
            TxtSearch.Focus();

        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            PL.Return.FrmAddReturn frm = new PL.Return.FrmAddReturn();
            try
            {
                frm.txtId.Text = ClsRet.ReturnItemsMaxId().Rows[0][0].ToString();
                frm.BtnNew.Enabled = false;
                frm.BtnAdd.Enabled = true;
            }
            catch
            {
                return;
            }
            
            frm.ShowDialog();
            this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void loaddata()
        {
            try
            {
                this.DGV_SalesOrder.DataSource = ClsRet.GetAllReturnSales();

                DGV_SalesOrder.Columns[5].Visible = false;
                DGV_SalesOrder.Columns[8].Visible = false;
                DGV_SalesOrder.Columns[9].Visible = false;
                //DGV_SalesOrder.Columns[10].Visible = false;
                DGV_SalesOrder.Columns[11].Visible = false;
                DGV_SalesOrder.Columns[12].Visible = false;
                DGV_SalesOrder.Columns[13].Visible = false;
                DGV_SalesOrder.Columns[14].Visible = false;
            }
            catch
            {
                return;
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            PL.Return.FrmAddReturn frm = new PL.Return.FrmAddReturn();
            
            frm.Text = "تعديل";
            frm.BtnNew.Visible = false;
            frm.BtnAdd.Visible = false;
            frm.BtnAprof.Visible = false;
            //frm.BtnAdd.SendToBack();
            frm.BtnEdit.Location = new Point(301, 19);
            frm.BtnEdit.BringToFront();
            try
            {
                frm.txtId.Text = DGV_SalesOrder.CurrentRow.Cells[0].Value.ToString();
                frm.txtOrderId.Text = DGV_SalesOrder.CurrentRow.Cells[1].Value.ToString();
                frm.txtBarCode.Text = DGV_SalesOrder.CurrentRow.Cells[2].Value.ToString();
                frm.TxtIReturnName.Text = DGV_SalesOrder.CurrentRow.Cells[3].Value.ToString();
                frm.TxtReturnPrice.Text = DGV_SalesOrder.CurrentRow.Cells[4].Value.ToString();
                frm.TxtReturnQTE.Text = DGV_SalesOrder.CurrentRow.Cells[6].Value.ToString();
                frm.TxtReturnDiscount.Text = DGV_SalesOrder.CurrentRow.Cells[5].Value.ToString();
                frm.TxtAmount.Text =  DGV_SalesOrder.CurrentRow.Cells[4].Value.ToString();
                frm.TxtReturnTotal.Text = DGV_SalesOrder.CurrentRow.Cells[7].Value.ToString();
                frm.DateReturn.Text = DGV_SalesOrder.CurrentRow.Cells[8].Value.ToString();
                frm.UserReturn.Text = DGV_SalesOrder.CurrentRow.Cells[9].Value.ToString();
                frm.TxtNotes.Text = DGV_SalesOrder.CurrentRow.Cells[11].Value.ToString();
                frm.TxtAmounTAR.Text = DGV_SalesOrder.CurrentRow.Cells[12].Value.ToString();
                frm.TxtItemId.Text = DGV_SalesOrder.CurrentRow.Cells[13].Value.ToString();
                frm.CalculateDisCount();
                frm.CalculateAmount();
                frm.ShowDialog();
                loaddata();
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
                DialogResult dialog = MessageBox.Show("هل انت متأكد من انك تريد الحذف ؟", "واى إن للبرمجيات", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (dialog == DialogResult.No)
                {
                    return;
                }

                int Id = Convert.ToInt32(DGV_SalesOrder.CurrentRow.Cells[0].Value.ToString());
                ClsRet.DeleteReturnSales(Id);
                MessageBox.Show("تمت عملية الحذف بنجاح", "واى إن للبرمجيات", MessageBoxButtons.OK,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

              
                loaddata();
            }
            catch
            {
                return;
            }
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnEdit_Click(sender, e);
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnDelete_Click(sender, e);
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.DGV_SalesOrder.DataSource = ClsRet.SearchReturnSales(TxtSearch.Text);
            }
            catch
            {
                return;
            }
        }

        private void BtnAprof_Click(object sender, EventArgs e)
        {
            PL.Return.FrmAddReturn frm = new PL.Return.FrmAddReturn();
            frm.Text = "معاينة وإسترجاع";
            frm.BtnNew.Visible = false;
            frm.BtnAdd.Visible = false;
            frm.BtnOrderList.Visible = false;
            frm.BtnAprof.Location = new Point(301, 19);
            frm.BtnEdit.Visible = false;
            frm.BtnAprof.BringToFront();
            try
            {
                frm.txtId.Text = DGV_SalesOrder.CurrentRow.Cells[0].Value.ToString();
                frm.txtOrderId.Text = DGV_SalesOrder.CurrentRow.Cells[1].Value.ToString();
                frm.txtBarCode.Text = DGV_SalesOrder.CurrentRow.Cells[2].Value.ToString();
                frm.TxtIReturnName.Text = DGV_SalesOrder.CurrentRow.Cells[3].Value.ToString();
                frm.TxtReturnPrice.Text = DGV_SalesOrder.CurrentRow.Cells[4].Value.ToString();
                frm.TxtReturnQTE.Text = DGV_SalesOrder.CurrentRow.Cells[6].Value.ToString();
                frm.TxtReturnDiscount.Text = DGV_SalesOrder.CurrentRow.Cells[5].Value.ToString();
                frm.TxtAmount.Text = DGV_SalesOrder.CurrentRow.Cells[4].Value.ToString();
                frm.TxtReturnTotal.Text = DGV_SalesOrder.CurrentRow.Cells[7].Value.ToString();
                frm.DateReturn.Text = DGV_SalesOrder.CurrentRow.Cells[8].Value.ToString();
                frm.UserReturn.Text = DGV_SalesOrder.CurrentRow.Cells[9].Value.ToString();
                frm.TxtNotes.Text = DGV_SalesOrder.CurrentRow.Cells[11].Value.ToString();
                frm.TxtAmounTAR.Text = DGV_SalesOrder.CurrentRow.Cells[12].Value.ToString();
                frm.TxtItemId.Text = DGV_SalesOrder.CurrentRow.Cells[13].Value.ToString();
                frm.CalculateDisCount();
                frm.CalculateAmount();
                if(this.DGV_SalesOrder.CurrentRow.Cells[10].Value.ToString()== "تم استرجاعة للاصناف")
                {
                    MessageBox.Show("هذا الصنف تم استرجاعة وإضافة الكمية للمخزن مسبقا", "واى إن للبرمجيات", MessageBoxButtons.OK,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
               
                    return;
                }
                frm.ShowDialog();
                loaddata();
            }
            catch
            {
                return;
            }

        }

        private void إسترجاعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Return.FrmAddReturn frm = new PL.Return.FrmAddReturn();
            frm.Text = "معاينة وإسترجاع";
            frm.BtnNew.Visible = false;
            frm.BtnAdd.Visible = false;
            frm.BtnOrderList.Visible = false;
            frm.BtnAprof.Location = new Point(301, 19);
            frm.BtnEdit.Visible = false;
            frm.BtnAprof.BringToFront();
            try
            {
                frm.txtId.Text = DGV_SalesOrder.CurrentRow.Cells[0].Value.ToString();
                frm.txtOrderId.Text = DGV_SalesOrder.CurrentRow.Cells[1].Value.ToString();
                frm.txtBarCode.Text = DGV_SalesOrder.CurrentRow.Cells[2].Value.ToString();
                frm.TxtIReturnName.Text = DGV_SalesOrder.CurrentRow.Cells[3].Value.ToString();
                frm.TxtReturnPrice.Text = DGV_SalesOrder.CurrentRow.Cells[4].Value.ToString();
                frm.TxtReturnQTE.Text = DGV_SalesOrder.CurrentRow.Cells[6].Value.ToString();
                frm.TxtReturnDiscount.Text = DGV_SalesOrder.CurrentRow.Cells[5].Value.ToString();
                frm.TxtAmount.Text = DGV_SalesOrder.CurrentRow.Cells[4].Value.ToString();
                frm.TxtReturnTotal.Text = DGV_SalesOrder.CurrentRow.Cells[7].Value.ToString();
                frm.DateReturn.Text = DGV_SalesOrder.CurrentRow.Cells[8].Value.ToString();
                frm.UserReturn.Text = DGV_SalesOrder.CurrentRow.Cells[9].Value.ToString();
                frm.TxtNotes.Text = DGV_SalesOrder.CurrentRow.Cells[11].Value.ToString();
                frm.TxtAmounTAR.Text = DGV_SalesOrder.CurrentRow.Cells[12].Value.ToString();
                frm.TxtItemId.Text = DGV_SalesOrder.CurrentRow.Cells[13].Value.ToString();
                frm.CalculateDisCount();
                frm.CalculateAmount();
                if (this.DGV_SalesOrder.CurrentRow.Cells[10].Value.ToString() == "تم استرجاعة للاصناف")
                {
                    MessageBox.Show("هذا الصنف تم استرجاعة وإضافة الكمية للمخزن مسبقا", "واى إن للبرمجيات", MessageBoxButtons.OK,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

                    return;
                }
                frm.ShowDialog();
                loaddata();
            }
            catch
            {
                return;
            }

        }
    }
}