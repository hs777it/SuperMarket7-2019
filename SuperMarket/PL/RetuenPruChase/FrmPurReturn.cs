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
    public partial class FrmPurReturn : DevExpress.XtraEditors.XtraForm
    {
        Classes.ClsRetuenPruChase ClsRet = new Classes.ClsRetuenPruChase();
        public FrmPurReturn()
        {
            InitializeComponent();
            BtnAdd.Enabled = false;
            BtnEdit.SendToBack();
            txtBarCode.Focus();
            var dateNow = DateTime.Now;
            var date = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day);
            DateReturn.DateTime = dateNow;
            UserReturn.Text = Program.UserName;
            Status.Visible = false;
            StatusProv.Visible = false;
            BtnAprof.SendToBack();
        }
        private void clear()
        {
            txtId.Text = "";
            txtPurOrder_Id.Text = "";
            TxtOrg_Bill.Text = "";
            txtBarCode.Text = "";
            TxtIReturnName.Text = "";
            TxtReturnPrice.Text = "";
            TxtReturnUnitPrice.Text = "";
            TxtReturnQTE.Text = "";
            TxtReturnTotal.Text = "";
            txtSupName.Text = "";

            TxtNotes.Text = "";
            TxtAmounTAR.Text = "";
            var dateNow = DateTime.Now;
            var date = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day);
            DateReturn.DateTime = dateNow;
            UserReturn.Text = Program.UserName;

        }
        public void CalculateAmount()
        {
            try
            {
                if (TxtReturnPrice.Text != string.Empty && TxtReturnQTE.Text != string.Empty)
                {
                    //TxtAmount.Text = (Convert.ToDouble(PurItem_Price.Text) * Convert.ToDouble(PurItem_QTE.Text)).ToString();
                    double Price = Convert.ToDouble(TxtReturnPrice.Text);
                    double QTE = Convert.ToDouble(TxtReturnQTE.Text);
                    double REsult = Price * QTE;
                    TxtReturnTotal.Text = REsult.ToString();
                }

            }
            catch
            {
                return;
            }
        }
        public  void Calculate()
        {
            try
            {
                if (TxtReturnPrice.Text != string.Empty && TxtReturnQTE.Text != string.Empty)
                {
                    //TxtAmount.Text = (Convert.ToDouble(PurItem_Price.Text) * Convert.ToDouble(PurItem_QTE.Text)).ToString();
                    double Price = Convert.ToDouble(TxtReturnPrice.Text);
                    double QTE = Convert.ToDouble(TxtReturnQTE.Text);
                    double REsult = Price / QTE; ;
                    TxtReturnUnitPrice.Text = string.Format("{0:0.##}", REsult);
                    
                }

            }
            catch
            {
                return;
            }
        }
        private void BtnPurList_Click(object sender, EventArgs e)
        {
            PL.RetuenPruChase.FrmSelectListPur frm = new PL.RetuenPruChase.FrmSelectListPur();
            frm.loaddata();
            frm.ShowDialog();
            try
            {

                txtPurOrder_Id.Text = frm.DGV_Order.CurrentRow.Cells[0].Value.ToString();
                TxtOrg_Bill.Text = frm.DGV_Order.CurrentRow.Cells[1].Value.ToString();
                txtBarCode.Text = frm.DGV_Order.CurrentRow.Cells[2].Value.ToString();
                TxtIReturnName.Text = frm.DGV_Order.CurrentRow.Cells[3].Value.ToString();
                TxtReturnPrice.Text = frm.DGV_Order.CurrentRow.Cells[4].Value.ToString();
                TxtReturnQTE.Text = frm.DGV_Order.CurrentRow.Cells[5].Value.ToString();
                TxtReturnTotal.Text = frm.DGV_Order.CurrentRow.Cells[7].Value.ToString();
                TxtAmounTAR.Text = frm.DGV_Order.CurrentRow.Cells[8].Value.ToString();
                TxtReturnUnitPrice.Text = frm.DGV_Order.CurrentRow.Cells[10].Value.ToString();
                txtSupName.Text = frm.DGV_Order.CurrentRow.Cells[11].Value.ToString();
                Calculate();
                CalculateAmount();
                TxtNotes.Focus();
                
            }
            catch
            {
                return;
            }
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
                TxtReturnTotal.Focus();
            }
        }

        private void TxtReturnTotal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtAmounTAR.Focus();
            }
        }

        private void TxtAmounTAR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtReturnUnitPrice.Focus();
            }
        }

        private void TxtReturnUnitPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSupName.Focus();
            }
        }

        private void txtSupName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtNotes.Focus();
            }
        }

        private void TxtNotes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnAdd.Focus();
            }
        }

        private void TxtReturnQTE_TextChanged(object sender, EventArgs e)
        {
            CalculateAmount();
            Calculate();
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                txtId.Text = ClsRet.PurReturnItemsMaxId().Rows[0][0].ToString();
                BtnNew.Enabled = false;
                BtnAdd.Enabled = true;
            }
            catch
            {
                return;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    DataTable dt1 = new DataTable();
                    dt1 = ClsRet.VerifyPurReturnItems(txtPurOrder_Id.Text);

                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        if (dt1.Rows[0][0].ToString() == txtPurOrder_Id.Text)
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
                if (txtId.Text == string.Empty || txtPurOrder_Id.Text == string.Empty
                    || TxtIReturnName.Text == string.Empty || TxtReturnPrice.Text == string.Empty)
                {
                    MessageBox.Show("عفوا!! بعض الخانات فارغة يرجى التاكد", "تنبيه", MessageBoxButtons.OK,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    return;
                }

                try
                {
                    ClsRet.InsertPurReturnItems(Convert.ToInt32(txtId.Text), Convert.ToInt32(txtPurOrder_Id.Text), TxtOrg_Bill.Text, txtBarCode.Text,
                        TxtIReturnName.Text, Convert.ToDouble(TxtReturnPrice.Text), Convert.ToDouble(TxtReturnQTE.Text), Convert.ToDouble(TxtReturnTotal.Text),
                        TxtAmounTAR.Text, Convert.ToDouble(TxtReturnUnitPrice.Text), DateReturn.DateTime, txtSupName.Text, Status.Text, TxtNotes.Text, UserReturn.Text,
                        Convert.ToInt32(txtPurOrder_Id.Text));

                    MessageBox.Show("تمت عملية الحفظ بنجاح", "واى إن للبرمجيات", MessageBoxButtons.OK,
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

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dialog = MessageBox.Show("هل انت متأكد من انك تريد تعديل البيانات؟", "واى إن للبرمجيات", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (dialog == DialogResult.No)
                {
                    return;
                }

                if (txtId.Text == string.Empty || txtPurOrder_Id.Text == string.Empty
                   || TxtIReturnName.Text == string.Empty || TxtReturnPrice.Text == string.Empty)
                {
                    MessageBox.Show("عفوا!! بعض الخانات فارغة يرجى التاكد", "تنبيه", MessageBoxButtons.OK,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    return;
                }


                try
                {
                    ClsRet.UpdateurReturnItems(Convert.ToInt32(txtId.Text), Convert.ToInt32(txtPurOrder_Id.Text), TxtOrg_Bill.Text, txtBarCode.Text,
                           TxtIReturnName.Text, Convert.ToDouble(TxtReturnPrice.Text), Convert.ToDouble(TxtReturnQTE.Text), Convert.ToDouble(TxtReturnTotal.Text),
                           TxtAmounTAR.Text, Convert.ToDouble(TxtReturnUnitPrice.Text), DateReturn.DateTime, txtSupName.Text, Status.Text, TxtNotes.Text, UserReturn.Text,
                           Convert.ToInt32(txtPurOrder_Id.Text));

                    MessageBox.Show("تمت عملية التعديل بنجاح", "واى إن للبرمجيات", MessageBoxButtons.OK,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    clear();
                    PL.RetuenPruChase.FrmPurReturn frm = new PL.RetuenPruChase.FrmPurReturn();
                    frm.Text = "تعديل";
                    frm.BtnNew.Visible = false;
                    frm.BtnAdd.Visible = false;
                    //frm.BtnAdd.SendToBack();
                    frm.BtnEdit.Location = new Point(301, 19);
                    frm.BtnEdit.BringToFront();
                }
                catch
                {
                    MessageBox.Show("حدث خطأ اثناء اتمام العملية", "واى إن للبرمجيات", MessageBoxButtons.OK,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    return;
                }

            }
            catch
            {
                MessageBox.Show("حدث خطأ اثناء اتمام العملية", "واى إن للبرمجيات", MessageBoxButtons.OK,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }

        }

        private void BtnAprof_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtId.Text == string.Empty || txtPurOrder_Id.Text == string.Empty
                  || TxtIReturnName.Text == string.Empty || TxtReturnPrice.Text == string.Empty)
                {
                    MessageBox.Show("عفوا!! بعض الخانات فارغة يرجى التاكد", "تنبيه", MessageBoxButtons.OK,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    return;
                }

                try
                {
                    ClsRet.UpdateurReturnItemsQTE(txtBarCode.Text, Convert.ToDouble(TxtReturnQTE.Text));
                    ClsRet.UpdateurReturnItemsStatus(StatusProv.Text, Convert.ToInt32(txtId.Text));


                }
                catch
                {
                    MessageBox.Show("حدث خطأ اثناء اتمام العملية", "واى إن للبرمجيات", MessageBoxButtons.OK,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    return;
                }
                MessageBox.Show("تمت العملية بنجاح", "واى إن للبرمجيات", MessageBoxButtons.OK,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                clear();
            }
            catch
            {
                MessageBox.Show("حدث خطأ اثناء اتمام العملية", "واى إن للبرمجيات", MessageBoxButtons.OK,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }
        }

        private void TxtReturnQTE_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateAmount();
            Calculate();
        }

        private void txtBarCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBarCode.Text != string.Empty)
                {
                    DataTable dt = new DataTable();
                    dt = ClsRet.GatBarCode(txtBarCode.Text);

                    if (dt.Rows.Count > 0)
                    {
                        
                        txtPurOrder_Id.Text = dt.Rows[0][0].ToString();
                        TxtOrg_Bill.Text = dt.Rows[0][1].ToString();
                        txtBarCode.Text = dt.Rows[0][2].ToString();
                        TxtIReturnName.Text = dt.Rows[0][3].ToString();
                        TxtReturnPrice.Text = dt.Rows[0][4].ToString();
                        TxtReturnQTE.Text = dt.Rows[0][5].ToString();
                        TxtReturnTotal.Text = dt.Rows[0][7].ToString();
                        TxtAmounTAR.Text = dt.Rows[0][8].ToString();
                        TxtReturnUnitPrice.Text = dt.Rows[0][10].ToString();
                        txtSupName.Text = dt.Rows[0][11].ToString();
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
    }
    
}