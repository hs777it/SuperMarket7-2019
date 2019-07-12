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

    public partial class FrmPosReturn : DevExpress.XtraEditors.XtraForm
    {
        //Classes.ClsPos ClsPos = new Classes.ClsPos();
        //Classes.ClsSales ClsSales = new Classes.ClsSales();
        //Classes.ClsPlaces ClsP = new Classes.ClsPlaces();
        //Classes.ClsItemCompany ClsCo = new Classes.ClsItemCompany();
        Classes.ClsPosReturn clsPosR = new Classes.ClsPosReturn();
        DataTable Dt = new DataTable();

        public FrmPosReturn()
        {
            InitializeComponent();
            txtBarCode.Focus();
            var dateNow = DateTime.Now;
            var date = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day);
            DateReturn.DateTime = dateNow;
            UserReturn.Text = Program.UserName;
            Status.Visible = false;
            StatusProv.Visible = false;
            BtnAprof.SendToBack();
        }
        public void CalculateAmount()
        {
            try
            {
                if (TxtReturnPrice.Text != string.Empty && TxtReturnQTE.Text != string.Empty)
                {

                    double Price = Convert.ToDouble(TxtReturnPrice.Text);
                    double QTE = Convert.ToDouble(TxtReturnQTE.Text);
                    double REsult = Price * QTE;
                    TxtAmount.Text = REsult.ToString();

                }

            }
            catch
            {
                return;
            }
        }
        public void CalculateDisCount()
        {
            try
            {
                if (TxtAmount.Text != string.Empty && TxtReturnDiscount.Text != string.Empty)
                {
                    double Amount = Convert.ToDouble(TxtAmount.Text);
                    double Des = Convert.ToDouble(TxtReturnDiscount.Text);
                    double REsult = Amount - (Amount * (Des / 100));
                    TxtReturnTotal.Text = REsult.ToString();
                }
            }
            catch
            {
                return;
            }
        }
        private void clear()
        {
            txtId.Text = "";
            txtOrderId.Text = "";
            TxtItemId.Text = "";
            txtBarCode.Text = "";
            TxtIReturnName.Text = "";
            TxtReturnPrice.Text = "";
            TxtReturnDiscount.Text = "";
            TxtReturnQTE.Text = "";
            TxtReturnTotal.Text = "";
            TxtAmount.Text = "";

            TxtNotes.Text = "";
            TxtAmounTAR.Text = "";
            var dateNow = DateTime.Now;
            var date = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day);
            DateReturn.DateTime = dateNow;
            UserReturn.Text = Program.UserName;

        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtIReturnName.Focus();
            }
        }

        private void TxtIReturnName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtReturnPrice.Focus();
            }
        }

        private void TxtReturnPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtReturnQTE.Focus();
            }
        }

        private void TxtReturnQTE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtReturnDiscount.Focus();
            }
        }

        private void TxtReturnDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtReturnTotal.Focus();
            }
        }

        private void TxtReturnTotal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtNotes.Focus();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    DataTable dt1 = new DataTable();
                    dt1 = clsPosR.VerifyReturnSales(txtOrderId.Text);

                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        if (dt1.Rows[0][0].ToString() == txtOrderId.Text)
                        {
                            clear();
                            MessageBox.Show("تم بالفعل استرجاع هذة الفاتورة مسبقا يرجى التاكد من بيانات الفاتورة", "تنبيه", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                            return;
                        }

                    }
                }
                catch
                {
                    return;
                }
                if (txtId.Text == string.Empty || txtOrderId.Text == string.Empty
                    || TxtIReturnName.Text == string.Empty || TxtAmount.Text == string.Empty)
                {
                    MessageBox.Show("عفوا!! بعض الخانات فارغة يرجى التاكد", "تنبيه", MessageBoxButtons.OK,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    return;
                }

                try
                {
                    clsPosR.InsertReturnItems(Convert.ToInt32(txtId.Text), Convert.ToInt32(txtOrderId.Text), txtBarCode.Text, TxtIReturnName.Text,
                       Convert.ToDouble(TxtReturnPrice.Text), Convert.ToDouble(TxtReturnDiscount.Text), Convert.ToDouble(TxtReturnQTE.Text), Convert.ToDouble(TxtReturnTotal.Text),
                        DateReturn.DateTime, UserReturn.Text, Status.Text, TxtNotes.Text, TxtAmounTAR.Text, Convert.ToInt32(TxtItemId.Text));

                    clsPosR.UpdateReturnSalesQTE(Convert.ToInt32(TxtItemId.Text), Convert.ToDouble(TxtReturnQTE.Text));
                    clsPosR.UpdateReturn_Status(StatusProv.Text, Convert.ToInt32(txtId.Text));

                    MessageBox.Show(" تمت عملية الحفظ بنجاح وإسترجاع الكمية للمخزن", "واى إن للبرمجيات", MessageBoxButtons.OK,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    clear();
                }
                catch
                {
                    MessageBox.Show("حدث خطأ اثناء اتمام العملية", "واى إن للبرمجيات", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    return;
                }

            }
            catch
            {
                MessageBox.Show("حدث خطأ اثناء اتمام العملية", "واى إن للبرمجيات", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }

        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                txtId.Text = clsPosR.ReturnItemsMaxId().Rows[0][0].ToString();
                BtnNew.Enabled = false;
                BtnAdd.Enabled = true;
            }
            catch
            {
                return;
            }
        }

        private void txtBarCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBarCode.Text != string.Empty)
                {
                    DataTable dt = new DataTable();
                    dt = clsPosR.GatBarCode(txtBarCode.Text);

                    if (dt.Rows.Count > 0)
                    {
                        TxtItemId.Text = dt.Rows[0][0].ToString();
                        txtOrderId.Text = dt.Rows[0][1].ToString();
                        txtBarCode.Text = dt.Rows[0][2].ToString();
                        TxtIReturnName.Text = dt.Rows[0][3].ToString();
                        TxtReturnPrice.Text = dt.Rows[0][4].ToString();
                        TxtReturnQTE.Text = dt.Rows[0][5].ToString();
                        TxtReturnDiscount.Text = dt.Rows[0][6].ToString();
                        TxtAmount.Text = dt.Rows[0][7].ToString();
                        TxtReturnTotal.Text = dt.Rows[0][8].ToString();
                        TxtNotes.Focus();
                    }


                }
                //else
                //{
                //    return;
                //}
            }
            catch
            {
                return;
            }
        }

        private void BtnOrderList_Click(object sender, EventArgs e)
        {
            PL.PosReturn.FrmSelectListPosSales frm = new PL.PosReturn.FrmSelectListPosSales();
            frm.ShowDialog();
            try
            {
                TxtItemId.Text = frm.DGV_Order.CurrentRow.Cells[0].Value.ToString();
                txtOrderId.Text = frm.DGV_Order.CurrentRow.Cells[1].Value.ToString();
                txtBarCode.Text = frm.DGV_Order.CurrentRow.Cells[2].Value.ToString();
                TxtIReturnName.Text = frm.DGV_Order.CurrentRow.Cells[3].Value.ToString();
                TxtReturnPrice.Text = frm.DGV_Order.CurrentRow.Cells[4].Value.ToString();
                TxtReturnQTE.Text = frm.DGV_Order.CurrentRow.Cells[5].Value.ToString();
                TxtReturnDiscount.Text = "0";
                TxtAmount.Text = frm.DGV_Order.CurrentRow.Cells[6].Value.ToString();
                //TxtReturnTotal.Text = frm.DGV_Order.CurrentRow.Cells[8].Value.ToString();
                //TxtAmounTAR.Text = frm.DGV_Order.CurrentRow.Cells[9].Value.ToString();
                CalculateDisCount();
                CalculateAmount();
                TxtNotes.Focus();

            }
            catch
            {
                return;
            }
        }

        private void TxtReturnQTE_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateDisCount();
            CalculateAmount();
        }

        private void TxtAmount_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateDisCount();
            CalculateAmount();
        }

        private void TxtReturnDiscount_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateDisCount();
            CalculateAmount();
        }

        private void TxtReturnPrice_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateDisCount();
            CalculateAmount();

        }

        private void TxtReturnTotal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ConvertNumbersToArabicAlphabet a = new ConvertNumbersToArabicAlphabet(TxtReturnTotal.Text);
                TxtAmounTAR.Text = a.GetNumberAr();
            }
            catch
            {
                return;
            }
        }
    }
}