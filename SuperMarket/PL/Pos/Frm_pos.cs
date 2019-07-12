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
using System.Globalization;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;
namespace SuperMarket.PL.Pos
{
    public partial class Frm_pos : DevExpress.XtraEditors.XtraForm
    {
        Classes.ClsPosReturn clsPosR = new Classes.ClsPosReturn();
        Classes.ClsPos ClsPos = new Classes.ClsPos();
        Classes.ClsSales ClsSales = new Classes.ClsSales();
        Classes.ClsPlaces ClsP = new Classes.ClsPlaces();
        Classes.ClsItemCompany ClsCo = new Classes.ClsItemCompany();
        DataTable Dt = new DataTable();
        
        string sumQty;

        public Frm_pos()
        {
            InitializeComponent();
            var dateNow = DateTime.Now;
            SalesOrder_Date.DateTime = dateNow;
            UserName.Text = Program.UserName;
            UserType.Text = Program.UserType;
            CreateDataTable();
            CalculateTotalAmount();
            CalculateDisCount();
            CMB_TSDID.SelectedIndex = 0;
           

        }
        void BakiCalculateAmount()
        {
            try
            {
           
                    double madfoa = Convert.ToDouble(TxtMadfoa.Text);
                    double Amount = Convert.ToDouble((from DataGridViewRow row in DGV_salesOrder.Rows
                                                      where row.Cells[5].FormattedValue.ToString() != string.Empty
                                                      select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum().ToString());
                    double REsult = Amount - madfoa;
                   TxtBaqi.Text = REsult.ToString();
               


            }
            catch
            {
                return;
            }
        }
        private void Sum_Qty()
        {
            try
            {
                if (DGV_salesOrder.Rows.Count < 1)
                {
                    sumQty = "0";
                }
                else
                {
                    for (int i = 0; i < DGV_salesOrder.Rows.Count; i++)
                    {
                        sumQty =
                   (from DataGridViewRow row in DGV_salesOrder.Rows
                    where row.Cells[4].FormattedValue.ToString() != string.Empty
                    && DGV_salesOrder.Rows[i].Cells[0].Value.ToString() == row.Cells[0].FormattedValue.ToString()
                    select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
                    }
                }
            }
            catch
            {
                return;
            }
        }
        void CreateDataTable()
        {
            try
            {
                Dt.Columns.Add("رقم الصنف");
                Dt.Columns.Add("الباركود");
                Dt.Columns.Add("إسم الصنف");
                Dt.Columns.Add("السعر");
                Dt.Columns.Add("الكمية");               
                Dt.Columns.Add("الاجمالى");
                DGV_salesOrder.DataSource = Dt;

            }
            catch
            {
                return;
            }
        }

        void getdata()
        {
            try
            {
                try
                {
                    TxtItemId.Text = DGV_salesOrder.CurrentRow.Cells[0].Value.ToString();
                    TxtBarCode.Text = DGV_salesOrder.CurrentRow.Cells[1].Value.ToString();
                    TxtItemName.Text = DGV_salesOrder.CurrentRow.Cells[2].Value.ToString();
                    TxtSalePrice.Text = DGV_salesOrder.CurrentRow.Cells[3].Value.ToString();
                    TxtQTE.Text = DGV_salesOrder.CurrentRow.Cells[4].Value.ToString();
                    TxtTotal.Text = DGV_salesOrder.CurrentRow.Cells[5].Value.ToString();
                    DGV_salesOrder.Rows.RemoveAt(DGV_salesOrder.CurrentRow.Index);
                }
                catch
                {
                    return;
                }
            }
            catch
            {
                return;
            }
        }
        void clear()
        {
            TxtItemId.Text = "";
            TxtBarCode.Text = "";
            TxtItemName.Text = "";
            TxtUnitPrice .Text = "";
            TxtQTE.Text = "";
            TxtSalePrice.Text = "";
            TxtTotal.Text ="";
            var dateNow = DateTime.Now;
            SalesOrder_Date.DateTime = dateNow;
            UserName.Text = Program.UserName;
            UserType.Text = Program.UserType;
            TxtBarCode.Focus();
        }
        void ClearBoxes()
        {
            TxtTotalAr.Text = "";
            PosOrderId.Text = "";
            TxtTotal.Text = "";
            TxtDiscount.Text = "";
            TxtItemId.Text = "";
            TxtBarCode.Text = "";
            TxtItemName.Text = "";
            TxtUnitPrice.Text = "";
            TxtQTE.Text = "";
            TXT_TOTAL1.Text = "";
            TxtDiscount.Text = "";
            TXT_TOTAL_BILL.Text = "";
            TxtBaqi.Text = "";
            TxtMadfoa.Text = "";
            TxtSalePrice.Text = "";
            TxtTotal.Text = "";
            CMB_TSDID.SelectedIndex = 0;
            Dt.Clear();
            var dateNow = DateTime.Now;
            SalesOrder_Date.DateTime = dateNow;
            UserName.Text = Program.UserName;
            UserType.Text = Program.UserType;
            DGV_salesOrder.DataSource = null;
            BtnAdd.Enabled = false;
            BtnNew.Enabled = true;

            BtnNew.Focus();
        }

        void CalculateTotalAmount()
        {
            try
            {
                if (DGV_salesOrder.Rows.Count < 1)
                {
                    TXT_TOTAL1.Text = "0.0";
                }
                else
                {
                    for (int i = 0; i < DGV_salesOrder.Rows.Count; i++)
                    {
                      TXT_TOTAL1.Text =
                      (from DataGridViewRow row in DGV_salesOrder.Rows
                       where row.Cells[5].FormattedValue.ToString() != string.Empty
                       select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum().ToString();
                    }
                }
            }
            catch
            {
                return;
            }
        }
        void CalculateDisCount()
        {
            try
            {
                if (TXT_TOTAL1.Text != string.Empty && TxtDiscount.Text != string.Empty)
                {
                    double Amount = Convert.ToDouble(TXT_TOTAL1.Text);
                    double Des = Convert.ToDouble(TxtDiscount.Text);
                    double REsult = Amount - (Amount * (Des / 100));
                    TXT_TOTAL_BILL.Text = REsult.ToString();
                   
                }
                
            }
            catch
            {
                return;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void PurAdd_Click(object sender, EventArgs e)
        {
            try
            {

                if (ClsSales.VerifyItemsQty(Convert.ToInt32(TxtItemId.Text), Convert.ToDouble(TxtQTE.Text)).Rows.Count < 1)
                {
                    MessageBox.Show("الكمية المدخلة لهذا المنتج غير متاحة بالمخزن", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    clear();
                    return;

                }              
                for (int i = 0; i < DGV_salesOrder.Rows.Count; i++)
                {
                    if (DGV_salesOrder.Rows[i].Cells[0].Value.ToString() == TxtItemId.Text)
                    {

                        DGV_salesOrder.Rows[i].Cells[4].Value = Convert.ToDouble(DGV_salesOrder.Rows[i].Cells[4].Value) + Convert.ToDouble(TxtQTE.Text);
                        clear();
                        DGV_salesOrder.Rows[i].Cells[5].Value = Convert.ToDouble(DGV_salesOrder.Rows[i].Cells[3].Value) * Convert.ToDouble(DGV_salesOrder.Rows[i].Cells[4].Value);
                        clear();
                        TXT_TOTAL1.Text =
                      (from DataGridViewRow row in DGV_salesOrder.Rows
                       where row.Cells[5].FormattedValue.ToString() != string.Empty
                       select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum().ToString();

                    }

                }



                if (TxtItemName.Text == string.Empty || TxtUnitPrice.Text == string.Empty || TxtQTE.Text == string.Empty)
                {
                    return;
                }
                DataRow r = Dt.NewRow();
                r[0] = TxtItemId.Text;
                r[1] = TxtBarCode.Text;
                r[2] = TxtItemName.Text;
                r[3] = TxtUnitPrice.Text;
                r[4] = TxtQTE.Text;               
                r[5] = TxtTotal.Text;

                Dt.Rows.Add(r);
                DGV_salesOrder.DataSource = Dt;
                clear();
                CalculateTotalAmount();
                CalculateDisCount();
                TxtBarCode.Focus();
               
              
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
                PosOrderId.Text = ClsPos.PosOrderMaxId().Rows[0][0].ToString();
                BtnNew.Enabled = false;
                BtnAdd.Enabled = true;
                TxtBarCode.Focus();
               
            }
            catch
            {
                return;
            }
        }
        //void CalculateAmount()
        //{
        //    try
        //    {
        //        if (TxtSalePrice.Text != string.Empty && TxtQTE.Text != string.Empty)
        //        {
        //            //TxtAmount.Text = (Convert.ToDouble(PurItem_Price.Text) * Convert.ToDouble(PurItem_QTE.Text)).ToString();
        //            double Price = Convert.ToDouble(TxtSalePrice.Text);
        //            double QTE = Convert.ToDouble(TxtQTE.Text);
        //            double REsult = Price / QTE; ;
        //            TxtUnitPrice.Text = string.Format("{0:0.##}", REsult);
                    
        //        }

        //    }
        //    catch
        //    {
        //        return;
        //    }

        //}

 
        void CalculateAmountT()
        {
            try
            {
                if (TxtUnitPrice.Text != string.Empty && TxtQTE.Text != string.Empty)
                {
                    //TxtAmount.Text = (Convert.ToDouble(PurItem_Price.Text) * Convert.ToDouble(PurItem_QTE.Text)).ToString();
                    double Price = Convert.ToDouble(TxtUnitPrice.Text);
                    double QTE = Convert.ToDouble(TxtQTE.Text);
                    double REsult = Price * QTE;
                    TxtTotal.Text = REsult.ToString();
                }

            }
            catch
            {
                return;
            }
        }
        private void TxtBarCode_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (TxtBarCode.Text != string.Empty)
                {
                    DataTable dt = new DataTable();
                    dt = ClsSales.GatBarCodeSales(TxtBarCode.Text);

                    if (dt.Rows.Count > 0)
                    {
                        TxtItemId.Text = dt.Rows[0][0].ToString();
                        TxtBarCode.Text = dt.Rows[0][1].ToString();
                        TxtItemName.Text = dt.Rows[0][2].ToString();
                        TxtUnitPrice.Text = dt.Rows[0][5].ToString();
                        TxtQTE.Text = "1";
                       
                        PurAdd.Focus();
                        CalculateAmountT();
                        CalculateDisCount();

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

        private void Frm_pos_Load(object sender, EventArgs e)
        {
            CalculateTotalAmount();
            CalculateDisCount();
            CMB_TSDID.SelectedIndex = 0;
            //TxtBarCode.Focus();
           
        }

        private void TxtQTE_TextChanged(object sender, EventArgs e)
        {
            CalculateAmountT(); ;
        }

        private void DGV_salesOrder_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //CalculateTotalAmount();
        }

        private void DGV_salesOrder_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            //CalculateTotalAmount();
        }

        private void DGV_salesOrder_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            //CalculateTotalAmount();
        }

        private void DGV_salesOrder_Validated(object sender, EventArgs e)
        {
            //CalculateTotalAmount();
        }

        private void TxtDiscount_TextChanged(object sender, EventArgs e)
        {
            CalculateDisCount();
            if (TxtDiscount.Text == "")
            {
                TXT_TOTAL_BILL.Text = TXT_TOTAL1.Text;
            }
        }

        private void TXT_TOTAL1_TextChanged(object sender, EventArgs e)
        {
            CalculateDisCount();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                if (PosOrderId.Text == string.Empty  || DGV_salesOrder.Rows.Count < 1 ||  UserName.Text == string.Empty)
                {
                    MessageBox.Show("عفوا!! بعض الخانات فارغة يرجى التاكد", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ClsPos.Add_PosOrder(Convert.ToInt32(PosOrderId.Text), SalesOrder_Date.DateTime, UserName.Text,UserType.Text, Convert.ToDouble(TxtMadfoa.Text),
                   Convert.ToDouble(TxtMadfoa.Text), Convert.ToDouble(TXT_TOTAL1.Text), Convert.ToDouble(TxtDiscount.Text), Convert.ToDouble(TXT_TOTAL_BILL.Text), TxtTotalAr.Text,CMB_TSDID.Text);
                for (int i = 0; i < DGV_salesOrder.Rows.Count; i++)
                {
                    ClsPos.Add_PosOrderDetailes(Convert.ToInt32(DGV_salesOrder.Rows[i].Cells[0].Value.ToString()),
                                        Convert.ToInt32(PosOrderId.Text),
                                        DGV_salesOrder.Rows[i].Cells[1].Value.ToString(),
                                        DGV_salesOrder.Rows[i].Cells[2].Value.ToString(),
                                      Convert.ToDouble(DGV_salesOrder.Rows[i].Cells[3].Value.ToString()),
                                        Convert.ToDouble(DGV_salesOrder.Rows[i].Cells[4].Value),
                                       Convert.ToDouble(DGV_salesOrder.Rows[i].Cells[5].Value.ToString()));

                }
                MessageBox.Show("تمت عملية الحفظ بنجاح", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                int PRNT = Convert.ToInt32(Properties.Settings.Default.POS_PRINT_START);
                if (Convert.ToDouble(PRNT) == 1)
                {
                    PRINT_POS();
                    ClearBoxes();
                    BtnNew.Enabled = true;
                    BtnAdd.Enabled = false;
                }
                else
                {
                    ClearBoxes();
                    BtnNew.Enabled = true;
                    BtnAdd.Enabled = false;
                }

            }
            catch
            {
                return;
            }

            ClearBoxes();
            BtnNew.Enabled = true;
            BtnAdd.Enabled = false;


        }

        private void TXT_TOTAL_BILL_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ConvertNumbersToArabicAlphabet a = new ConvertNumbersToArabicAlphabet(TXT_TOTAL_BILL.Text);
                TxtTotalAr.Text = a.GetNumberAr();
            }
            catch
            {
                return;
            }
        }
        void PRINT_POS()
        {



            try
            {
                this.Cursor = Cursors.WaitCursor;
                int order_ID = Convert.ToInt32(PosOrderId.Text);
                ReportDocument rep_ill = new ReportDocument();
                string Patch = Application.StartupPath + "\\settings\\Print\\PosBill\\PosBill.rpt";
                rep_ill.Load(Patch);
                Reports.Frm_CrstalReport frm = new Reports.Frm_CrstalReport();
                rep_ill.SetDataSource(ClsPos.PrintPOsBill(order_ID));
                frm.crystalReportViewer1.ReportSource = rep_ill;
                rep_ill.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                rep_ill.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize;

                //frm.ShowDialog();

                rep_ill.PrintToPrinter(1, false, 0, 0);
                rep_ill.PrintOptions.PrinterName = Properties.Settings.Default.POS_PRINT;               
                this.Cursor = Cursors.Default;

               
                
              
            }
            catch 
            {
                MessageBox.Show("خطأ بعملية الطباعة", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
                return;
            }
        }

        private void CheckPosPrint_CheckedChanged(object sender, EventArgs e)
        {
            //if(CheckPosPrint.Checked==true)
            //{
            //    PRINT_POS();
            //}
        }

        private void Frm_pos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                BtnAdd_Click(sender, e);
            }

            if (e.KeyCode == Keys.F3)
            {
                simpleButton1_Click(sender, e);
            }
        }

        private void DGV_salesOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            getdata();
            CalculateTotalAmount();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                PL.PosReturn.FrmPosReturn frm = new PL.PosReturn.FrmPosReturn();
                frm.txtId.Text = clsPosR.ReturnItemsMaxId().Rows[0][0].ToString();
                frm.ShowDialog();
            }
            catch 
            {

                return;
            }
        }

        private void simpleButton1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                simpleButton1_Click(sender, e);
            }
        }

        private void BtnAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                BtnAdd_Click(sender, e);
            }
        }

        private void TxtMadfoa_TextChanged(object sender, EventArgs e)
        {
            BakiCalculateAmount();
        }
    }
   

}