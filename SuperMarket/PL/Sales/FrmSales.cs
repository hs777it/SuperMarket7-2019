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
using System.IO;
using System.Globalization;
namespace SuperMarket.PL.Sales
{
    public partial class FrmSales : DevExpress.XtraEditors.XtraForm
    {
        Classes.ClsReceiptVoucher ClsRV = new Classes.ClsReceiptVoucher();
        Classes.ClsSales ClsSales = new Classes.ClsSales();
        Classes.ClsPlaces ClsP = new Classes.ClsPlaces();
        Classes.ClsItemCompany ClsCo = new Classes.ClsItemCompany();
        DataTable Dt = new DataTable();
        double Qt;
        string sumQty;
        public FrmSales()
        {
            InitializeComponent();
            var dateNow = DateTime.Now;
            SalesOrder_Date.DateTime = dateNow;
            User_SalesOrder.Text = Program.UserName;
            BtnAdd.Enabled = false;
            panelCust.Enabled = false;
            CreateDataTable();
            CalculateTotalAmount();
            SandatCalculateAmount();
            TxtBarCode.Focus();
            CMB_TSDID.SelectedIndex = 0;
        }
        void CalculateAmount()
        {
            try
            {
                if (TxtSalePrice.Text != string.Empty && TxtQTE.Text != string.Empty)
                {
                    //TxtAmount.Text = (Convert.ToDouble(PurItem_Price.Text) * Convert.ToDouble(PurItem_QTE.Text)).ToString();
                    double Price = Convert.ToDouble(TxtSalePrice.Text);
                    double QTE = Convert.ToDouble(TxtQTE.Text);
                    double REsult = Price * QTE;
                    TxtAmount.Text = REsult.ToString();
                }

            }
            catch
            {
                return;
            }
        }

        void SandatCalculateAmount()
        {
            try
            {
                if (CMB_TSDID.SelectedIndex==0)
                {
                    txtmadfoa.Text = "0";
                    txtmotbqi.Text = "0";
                }
                else
                {
                    double madfoa = Convert.ToDouble(txtmadfoa.Text);
                    double Amount = Convert.ToDouble((from DataGridViewRow row in DGV_salesOrder.Rows
                                                      where row.Cells[7].FormattedValue.ToString() != string.Empty
                                                      select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum().ToString());
                    double REsult = Amount - madfoa;
                    txtmotbqi.Text = REsult.ToString();
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
                if (TxtAmount.Text != string.Empty && TxtDiscount.Text != string.Empty)
                {
                    double Amount = Convert.ToDouble(TxtAmount.Text);
                    double Des = Convert.ToDouble(TxtDiscount.Text);
                    double REsult = Amount - (Amount * (Des / 100));
                    TxtTotal.Text = REsult.ToString();
                }
            }
            catch
            {
                return;
            }
        }
        void CalculateTotalAmount()
        {
            try
            {
                if (DGV_salesOrder.Rows.Count < 1)
                {
                    Total_Amount.Text = "";
                }
                else
                {
                    Total_Amount.Text =
                        (from DataGridViewRow row in DGV_salesOrder.Rows
                         where row.Cells[7].FormattedValue.ToString() != string.Empty
                         select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum().ToString();
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
                Dt.Columns.Add("سعر البيع");
                Dt.Columns.Add("الكمية");
                Dt.Columns.Add("المبلغ");
                Dt.Columns.Add("الخصم");
                Dt.Columns.Add("الاجمالى");
                DGV_salesOrder.DataSource = Dt;

            }
            catch
            {
                return;
            }



        }
        //void ResizeDGV()
        //{
        //    try
        //    {

        //        this.DGV_salesOrder.RowHeadersWidth = 86;
        //        this.DGV_salesOrder.Columns[0].Width = 10;
        //        this.DGV_salesOrder.Columns[1].Width = 199;
        //        this.DGV_salesOrder.Columns[2].Width = 85;
        //        this.DGV_salesOrder.Columns[3].Width = 93;
        //        this.DGV_salesOrder.Columns[4].Width = 85;
        //        this.DGV_salesOrder.Columns[5].Width = 93;
        //        this.DGV_salesOrder.Columns[6].Width = 121;
        //    }
        //    catch
        //    {
        //        return;
        //    }


        //}

        void clear()
        {
            TxtItemId.Text = "";
            TxtBarCode.Text = "";
            TxtItemName.Text = "";
            TxtSalePrice.Text = "";
            TxtQTE.Text = "";
            TxtAmount.Text = "";
            TxtTotal.Text = "";
            TxtDiscount.Text = "";
            TxtItemId.Focus();
           
        }
        void ClearBoxes()
        {
            SalesOrder_Id.Text = "";
            SalesOrder_Desc.Text = "";
            Cust_ID.Text = "1";
            Cust_Name.Text = "بدون عميل";
            Cust_Phone.Text = "";
            credit.Text = "";
            debit.Text = "";
            VoucherCode.Text = "";
            txtmotbqi.Text = "";
            txtmadfoa.Text = "";
            NewDofaaAr.Text = "";
            txtBaqiAr.Text = "";
            BTnBrowese.Focus();
            TxtItemId.Text = "";
            TxtBarCode.Text = "";
            TxtItemName.Text = "";
            TxtSalePrice.Text = "";
            TxtQTE.Text = "";
            TxtAmount.Text = "";
            TxtDiscount.Text = "";
            Total_Amount.Text = "";
            Total_Amount_Ar.Text = "";
            Dt.Clear();
            DGV_salesOrder.DataSource = null;
            BtnAdd.Enabled = false;
            BtnNew.Enabled = true;

            BtnNew.Focus();
        }
        private void textEdit14_Properties_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void BTnBrowese_Click(object sender, EventArgs e)
        {
            PL.Customers.Frm_SelectCistomers frm = new PL.Customers.Frm_SelectCistomers();
            frm.ShowDialog();
            try
            {            
                Cust_ID.Text = frm.DGVSelectCustomers.CurrentRow.Cells[0].Value.ToString();
                Cust_Name.Text = frm.DGVSelectCustomers.CurrentRow.Cells[1].Value.ToString();
                Cust_Phone.Text = frm.DGVSelectCustomers.CurrentRow.Cells[2].Value.ToString();
                credit.Text = frm.DGVSelectCustomers.CurrentRow.Cells[11].Value.ToString();
                debit.Text = frm.DGVSelectCustomers.CurrentRow.Cells[12].Value.ToString();

            }
            catch
            {
                return;
            }
        }

        private void TxtItems_Click(object sender, EventArgs e)
        {


            PL.Sales.FrmItemList frm = new PL.Sales.FrmItemList();
            frm.ShowDialog();

            try
            {
                TxtItemId.Text = frm.DGVSelectIems.CurrentRow.Cells[0].Value.ToString();
                TxtBarCode.Text = frm.DGVSelectIems.CurrentRow.Cells[1].Value.ToString();
                TxtItemName.Text = frm.DGVSelectIems.CurrentRow.Cells[2].Value.ToString();
                TxtSalePrice.Text = frm.DGVSelectIems.CurrentRow.Cells[5].Value.ToString();
                Qt = Convert.ToDouble(frm.DGVSelectIems.CurrentRow.Cells[6].Value.ToString());
                TxtQTE.Text = "1";
                TxtDiscount.Text = frm.DGVSelectIems.CurrentRow.Cells[7].Value.ToString();
                PurAdd.Focus();
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
                SalesOrder_Id.Text = ClsSales.SalesOrderMaxId().Rows[0][0].ToString();
                VoucherCode.Text = ClsRV.GetMaxVoucher().Rows[0][0].ToString();

                BtnNew.Enabled = false;
                BtnAdd.Enabled = true;
                TxtBarCode.Focus();
                SalesOrder_Desc.Text = "فاتورة مبيعات جديدة " + SalesOrder_Id.Text;
                Cust_ID.Text = "1";
                Cust_Name.Text = "بدون عميل";
            }
            catch
            {
                return;
            }
        }

        private void WithSupp_CheckedChanged(object sender, EventArgs e)
        {
            panelCust.Enabled = true;
            Cust_ID.Text = "";
            Cust_Name.Text = "";
            Cust_Phone.Text = "";
            credit.Text = "";
            debit.Text = "";

        }

        private void WithOutSup_CheckedChanged(object sender, EventArgs e)
        {
            panelCust.Enabled = false;
            Cust_ID.Text = "1";
            Cust_Name.Text = "بدون عميل";
            Cust_Phone.Text = "";
            credit.Text = "";
            debit.Text = "";
        }

        private void Total_Amount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SandatCalculateAmount();
                ConvertNumbersToArabicAlphabet a = new ConvertNumbersToArabicAlphabet(Total_Amount.Text);
                Total_Amount_Ar.Text = a.GetNumberAr();
            }
            catch
            {
                return;
            }
        }

        private void TxtSalePrice_TextChanged(object sender, EventArgs e)
        {
            CalculateAmount();
        }

        private void TxtQTE_EditValueChanged(object sender, EventArgs e)
        {
            CalculateAmount();
        }

        private void TxtSalePrice_EditValueChanged(object sender, EventArgs e)
        {
            CalculateAmount();
        }

        private void TxtQTE_TextChanged(object sender, EventArgs e)
        {
            CalculateAmount();
        }

        private void TxtDiscount_EditValueChanged(object sender, EventArgs e)
        {
            CalculateDisCount();
        }

        private void TxtAmount_EditValueChanged(object sender, EventArgs e)
        {
            CalculateDisCount();
        }

        private void TxtAmount_TextChanged(object sender, EventArgs e)
        {
            CalculateDisCount();
        }

        private void TxtDiscount_TextChanged(object sender, EventArgs e)
        {
            CalculateDisCount();
        }

        private void مكانالصنفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Sales.frmPlaces frm = new PL.Sales.frmPlaces();
            try
            {
                if (TxtItemId.Text != string.Empty)
                {
                    int id = Convert.ToInt32(TxtItemId.Text);
                    DataTable dt = new DataTable();
                    dt = ClsP.GetAllPlacesForSales(id);

                    if (dt.Rows.Count > 0)
                    {
                        frm.TxtItemId.Text = dt.Rows[0][0].ToString();
                        frm.CmbFloar.Text = dt.Rows[0][1].ToString();
                        frm.CmbStand.Text = dt.Rows[0][2].ToString();
                        frm.CmbPlaces.Text = dt.Rows[0][3].ToString();
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("عفوا!! لم يتم إدخال مكان للصنف ", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                    }


                }

            }
            catch
            {
                return;
            }

        }

        private void شركةالصنفToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PL.Sales.FrmCompany frm = new PL.Sales.FrmCompany();
            try
            {
                if (TxtItemId.Text != string.Empty)
                {
                    int id = Convert.ToInt32(TxtItemId.Text);
                    DataTable dt = new DataTable();
                    dt = ClsCo.GetAllCompanyForSales(id);

                    if (dt.Rows.Count > 0)
                    {
                        frm.TxtItemId.Text = dt.Rows[0][0].ToString();
                        frm.TxtItemCompany.Text = dt.Rows[0][1].ToString();
                        frm.TxtPhone.Text = dt.Rows[0][2].ToString();
                        frm.Txtadress.Text = dt.Rows[0][3].ToString();
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("عفوا!! لم يتم إدخال شركة للصنف ", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                    }


                }

            }
            catch
            {
                return;
            }

        }

        private void مكانالصنفToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PL.Sales.frmPlaces frm = new PL.Sales.frmPlaces();
            try
            {
                if (DGV_salesOrder.CurrentRow.Cells[0].Value.ToString() != string.Empty)
                {
                    int id = Convert.ToInt32(DGV_salesOrder.CurrentRow.Cells[0].Value.ToString());
                    DataTable dt = new DataTable();
                    dt = ClsP.GetAllPlacesForSales(id);

                    if (dt.Rows.Count > 0)
                    {
                        frm.TxtItemId.Text = dt.Rows[0][0].ToString();
                        frm.CmbFloar.Text = dt.Rows[0][1].ToString();
                        frm.CmbStand.Text = dt.Rows[0][2].ToString();
                        frm.CmbPlaces.Text = dt.Rows[0][3].ToString();
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("عفوا!! لم يتم إدخال مكان للصنف ", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                    }


                }

            }
            catch
            {
                return;
            }
        }

        private void شركةالصنفToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            PL.Sales.FrmCompany frm = new PL.Sales.FrmCompany();
            try
            {
                if (DGV_salesOrder.CurrentRow.Cells[0].Value.ToString() != string.Empty)
                {
                    int id = Convert.ToInt32(DGV_salesOrder.CurrentRow.Cells[0].Value.ToString());
                    DataTable dt = new DataTable();
                    dt = ClsCo.GetAllCompanyForSales(id);

                    if (dt.Rows.Count > 0)
                    {
                        frm.TxtItemId.Text = dt.Rows[0][0].ToString();
                        frm.TxtItemCompany.Text = dt.Rows[0][1].ToString();
                        frm.TxtPhone.Text = dt.Rows[0][2].ToString();
                        frm.Txtadress.Text = dt.Rows[0][3].ToString();
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("عفوا!! لم يتم إدخال شركة للصنف ", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                    }


                }

            }
            catch
            {
                return;
            }
        }

        private void حذفهذاالسطرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DGV_salesOrder.Rows.RemoveAt(DGV_salesOrder.CurrentRow.Index);
                CalculateTotalAmount();
            }
            catch
            {
                return;
            }
        }

        private void حذفالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Dt.Clear();
                DGV_salesOrder.DataSource = null;
                CreateDataTable();
            }
            catch
            {
                return;
            }
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getdata();
            CalculateTotalAmount();
        }
        void getdata()
        {
            try
            {
                TxtItemId.Text = DGV_salesOrder.CurrentRow.Cells[0].Value.ToString();
                TxtBarCode.Text = DGV_salesOrder.CurrentRow.Cells[1].Value.ToString();
                TxtItemName.Text = DGV_salesOrder.CurrentRow.Cells[2].Value.ToString();
                TxtSalePrice.Text = DGV_salesOrder.CurrentRow.Cells[3].Value.ToString();
                TxtQTE.Text = DGV_salesOrder.CurrentRow.Cells[4].Value.ToString();
                TxtAmount.Text = DGV_salesOrder.CurrentRow.Cells[5].Value.ToString();
                TxtDiscount.Text = DGV_salesOrder.CurrentRow.Cells[6].Value.ToString();
                TxtTotal.Text = DGV_salesOrder.CurrentRow.Cells[7].Value.ToString();
                DGV_salesOrder.Rows.RemoveAt(DGV_salesOrder.CurrentRow.Index);
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
                        TxtSalePrice.Text = dt.Rows[0][5].ToString();
                        TxtQTE.Text = "1";
                        TxtDiscount.Text = dt.Rows[0][7].ToString();
                        PurAdd.Focus();
                       
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

        private void PurAdd_Click(object sender, EventArgs e)
        {
            try
            {



                if (ClsSales.VerifyItemsQty(Convert.ToInt32(TxtItemId.Text), Convert.ToDouble(TxtQTE.Text)).Rows.Count < 1)
                {
                    MessageBox.Show("الكمية المدخلة لهذا المنتج غير متاحة بالمخزن" + Environment.NewLine + "كمية الصنف الحالية الموجودة بالمخزن هى :" + Qt.ToString(), "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    clear();
                    return;

                }

              
                try
                {
                    for (int i = 0; i < DGV_salesOrder.Rows.Count; i++)
                    {
                        if (DGV_salesOrder.Rows[i].Cells[0].Value.ToString() == TxtItemId.Text)
                        {
                            clear();
                            MessageBox.Show("هذا المنتج تم إدخاله مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }

                    }
                }
                catch
                {
                    return;
                }

                if (TxtItemName.Text == string.Empty || TxtSalePrice.Text == string.Empty || TxtQTE.Text == string.Empty)
                {
                    return;
                }
                DataRow r = Dt.NewRow();
                r[0] = TxtItemId.Text;
                r[1] = TxtBarCode.Text;
                r[2] = TxtItemName.Text;
                r[3] = TxtSalePrice.Text;
                r[4] = TxtQTE.Text;
                r[5] = TxtAmount.Text;
                r[6] = TxtDiscount.Text;
                r[7] = TxtTotal.Text;

                Dt.Rows.Add(r);
                DGV_salesOrder.DataSource = Dt;
                clear();
                TxtBarCode.Focus();
                Tablesum();
                //Sum_Qty();
                //}
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

                if (SalesOrder_Id.Text == string.Empty || SalesOrder_Desc.Text == string.Empty || DGV_salesOrder.Rows.Count < 1 || Cust_Name.Text == string.Empty
                    || Cust_ID.Text == string.Empty || User_SalesOrder.Text == string.Empty)
                {
                    MessageBox.Show("عفوا!! بعض الخانات فارغة يرجى التاكد", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (CMB_TSDID.Text == "نقدى")
                {


                    ClsSales.Add_SalesOrder(Convert.ToInt32(SalesOrder_Id.Text), SalesOrder_Date.DateTime, SalesOrder_Desc.Text, Convert.ToInt32(Cust_ID.Text), User_SalesOrder.Text);
                    for (int i = 0; i < DGV_salesOrder.Rows.Count; i++)
                    {
                        ClsSales.AddSalesOrderDetailes(Convert.ToInt32(DGV_salesOrder.Rows[i].Cells[0].Value.ToString()),
                                            Convert.ToInt32(SalesOrder_Id.Text),
                                            DGV_salesOrder.Rows[i].Cells[1].Value.ToString(),
                                            DGV_salesOrder.Rows[i].Cells[2].Value.ToString(),
                                            Convert.ToDouble(DGV_salesOrder.Rows[i].Cells[3].Value.ToString()),
                                            Convert.ToDouble(DGV_salesOrder.Rows[i].Cells[4].Value),
                                            Convert.ToDouble(DGV_salesOrder.Rows[i].Cells[6].Value.ToString()),
                                           Convert.ToDouble(DGV_salesOrder.Rows[i].Cells[7].Value.ToString()),
                                           Convert.ToDouble(Total_Amount.Text),
                                            Total_Amount_Ar.Text);

                    }
                }
                if (CMB_TSDID.Text == "آجل")
                {
                    ClsRV.AddVoucher(Convert.ToInt32(VoucherCode.Text), "رقم سند الاستلام :  " + VoucherCode.Text, SalesOrder_Date.DateTime, Convert.ToDouble(Total_Amount.Text),
                 Total_Amount_Ar.Text, "السيد / " + Cust_Name.Text, "سند قبض تابع لفاتورة مبيعات رقم :" + VoucherCode.Text, User_SalesOrder.Text, Convert.ToDouble(txtmadfoa.Text),
                 NewDofaaAr.Text, Convert.ToDouble(txtmotbqi.Text), txtBaqiAr.Text);



                 //   ClsRV.AddVoucher(Convert.ToInt32(VoucherCode.Text),VoucherCode.Text, SalesOrder_Date.DateTime, Convert.ToDouble(Total_Amount.Text),
                 //Total_Amount_Ar.Text, "السيد / " + Cust_Name.Text, VoucherCode.Text, User_SalesOrder.Text, Convert.ToDouble(txtmadfoa),
                 //NewDofaaAr.Text, Convert.ToDouble(txtmotbqi.Text), txtBaqiAr.Text);

                ClsSales.Add_SalesOrder(Convert.ToInt32(SalesOrder_Id.Text), SalesOrder_Date.DateTime, SalesOrder_Desc.Text, Convert.ToInt32(Cust_ID.Text), User_SalesOrder.Text);
                    for (int i = 0; i < DGV_salesOrder.Rows.Count; i++)
                    {
                        ClsSales.AddSalesOrderDetailes(Convert.ToInt32(DGV_salesOrder.Rows[i].Cells[0].Value.ToString()),
                                            Convert.ToInt32(SalesOrder_Id.Text),
                                            DGV_salesOrder.Rows[i].Cells[1].Value.ToString(),
                                            DGV_salesOrder.Rows[i].Cells[2].Value.ToString(),
                                            Convert.ToDouble(DGV_salesOrder.Rows[i].Cells[3].Value.ToString()),
                                            Convert.ToDouble(DGV_salesOrder.Rows[i].Cells[4].Value),
                                            Convert.ToDouble(DGV_salesOrder.Rows[i].Cells[6].Value.ToString()),
                                            Convert.ToDouble(DGV_salesOrder.Rows[i].Cells[7].Value.ToString()),
                                            Convert.ToDouble(Total_Amount.Text),
                                            Total_Amount_Ar.Text);

                    }

                }
                MessageBox.Show("تمت عملية الحفظ بنجاح", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    if (MessageBox.Show("هل تريد طباعة هذة الفاتورة؟", "واى إن للبرمجيات", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Cursor = Cursors.WaitCursor;
                        Reports.SalesBill.OneSaleBill report = new Reports.SalesBill.OneSaleBill();
                        int order_ID = Convert.ToInt32(SalesOrder_Id.Text);
                        report.SetParameterValue("@ID", order_ID);
                        Reports.Frm_CrstalReport frm = new Reports.Frm_CrstalReport();
                        frm.crystalReportViewer1.ReportSource = report;
                        frm.ShowDialog();
                        this.Cursor = Cursors.Default;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ بعملية الطباعة" + ex.ToString(), "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Cursor = Cursors.Default;
                    return;
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

        private void TxtBarCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (TxtBarCode.Text == string.Empty)
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        TxtItems_Click(sender, e);
                    }
                }
                else
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        PurAdd_Click(sender, e);
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void TxtQTE_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (TxtQTE.Text == string.Empty)
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        TxtItems_Click(sender, e);
                    }
                }
                else
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        PurAdd_Click(sender, e);
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void TxtDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (TxtDiscount.Text == string.Empty)
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        TxtItems_Click(sender, e);
                    }
                }
                else
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        PurAdd_Click(sender, e);
                    }
                }
            }
            catch
            {
                return;
            }
        }
        private void Tablesum()
        {
            try
            {
                if (DGV_salesOrder.Rows.Count < 1)
                {
                    Total_Amount.Text = "";
                }
                else
                {
                    Total_Amount.Text =
                   (from DataGridViewRow row in DGV_salesOrder.Rows
                    where row.Cells[7].FormattedValue.ToString() != string.Empty
                    select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum().ToString();
                }
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

        private void DGV_salesOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            getdata();
            CalculateTotalAmount();
        }

        private void TxtQTE_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }
        }

        private void TxtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }
        }

        private void FrmSales_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtmadfoa_TextChanged(object sender, EventArgs e)
        {
            SandatCalculateAmount();
          
            try
            {
                if (txtmadfoa.Text == string.Empty)
                {
                    txtmadfoa.Text = "";
                    txtmotbqi.Text = "";
                }
                ConvertNumbersToArabicAlphabet a = new ConvertNumbersToArabicAlphabet(txtmadfoa.Text);
                NewDofaaAr.Text = a.GetNumberAr();
            }
            catch
            {
                return;
            }
        }

        private void txtmotbqi_TextChanged(object sender, EventArgs e)
        {
         
            try
            {
                ConvertNumbersToArabicAlphabet a = new ConvertNumbersToArabicAlphabet(txtmotbqi.Text);
                txtBaqiAr.Text = a.GetNumberAr();
            }
            catch
            {
                return;
            }
        }

        private void CMB_TSDID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CMB_TSDID.SelectedIndex == 1)
                {
                    VoucherCode.Text = ClsRV.GetMaxVoucher().Rows[0][0].ToString();
                    SandatCalculateAmount();
                    txtmadfoa.Enabled = true;
                    txtmotbqi.Enabled = true;
                    WithSupp.Checked = true;
                }
                else
                {
                    txtmadfoa.Enabled = false;
                    txtmotbqi.Enabled = false;
                    WithOutSup.Checked = true;
                }
            }
            catch 
            {

                return;
            }
        }

        private void txtmadfoa_EditValueChanged(object sender, EventArgs e)
        {
            SandatCalculateAmount();
        }

        private void txtmadfoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }
        }
    }
    }
