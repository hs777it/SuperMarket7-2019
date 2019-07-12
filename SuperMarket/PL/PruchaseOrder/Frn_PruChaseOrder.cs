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
using System.Data.SqlClient;

namespace SuperMarket.PL.PruChaseOrder
{
    public partial class Frn_PruChaseOrder : DevExpress.XtraEditors.XtraForm
    {
        Classes.ClsPruChaseOrder ClsPru = new Classes.ClsPruChaseOrder();
        DataTable Dt = new DataTable();
        Classes.ClsFinancialSupport Clsfs = new Classes.ClsFinancialSupport();
        void CalculateAmount()
        {
            try
            {
                if (PurItem_Price.Text != string.Empty && PurItem_QTE.Text != string.Empty)
                {
                    //double Price = Convert.ToDouble(PurItem_Price.Text);
                    //double QTE = Convert.ToDouble(PurItem_QTE.Text);
                    //double REsult = Price / QTE; ;
                    //TxtUnitPrice.Text = REsult.ToString("0.00");
                    //TxtAmount.Text = Price.ToString("0.00");

                    TxtUnitPrice.Text = TxtAmount.Text = 
                        (Convert.ToDouble(PurItem_Price.Text) / Convert.ToDouble(PurItem_QTE.Text)).ToString("0.00");
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
                if (DGV_PruChaseOrder.Rows.Count < 1)
                {
                    Total_Amount.Text = "0.00";
                }
                else
                {
                    Total_Amount.Text =
                        (from DataGridViewRow row in DGV_PruChaseOrder.Rows
                         where row.Cells[6].FormattedValue.ToString() != string.Empty
                         select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString("0.00");
                }
            }
            catch
            {
                return;
            }
        }

        void clear()
        {
            TxtRecived.Text = "";
            BarCode.Text = "";
            PurItem_Name.Text = "";
            PurItem_Price.Text = "";
            PurItem_QTE.Text = "";
            TxtUnitPrice.Text = "";
            TxtAmount.Text = "";
            TxtRecived.Focus();
        }
        void ClearBoxes()
        {
            PurOrder_Id.Text = "";
            PurOrder_Desc.Text = "";
            PurSup_ID.Text = "1";
            Sup_Name.Text = "بدون مورد";
            Sup_Phone.Text = "";
            credit.Text = "";
            debit.Text = "";
            BTnBrowese.Focus();
            TxtRecived.Text = "";
            BarCode.Text = "";
            PurItem_Name.Text = "";
            PurItem_Price.Text = "";
            PurItem_QTE.Text = "";
            TxtUnitPrice.Text = "";
            TxtAmount.Text = "";
            Total_Amount.Text = "";
            Total_Amount_Ar.Text = "";
            Dt.Clear();
            DGV_PruChaseOrder.DataSource = null;
            BtnAdd.Enabled = false;
            BtnNew.Enabled = true;

            BtnNew.Focus();
        }

        void getdata()
        {
            try
            {
                TxtRecived.Text = DGV_PruChaseOrder.CurrentRow.Cells[0].Value.ToString();
                BarCode.Text = DGV_PruChaseOrder.CurrentRow.Cells[1].Value.ToString();
                PurItem_Name.Text = DGV_PruChaseOrder.CurrentRow.Cells[2].Value.ToString();
                PurItem_Price.Text = DGV_PruChaseOrder.CurrentRow.Cells[3].Value.ToString();
                PurItem_QTE.Text = DGV_PruChaseOrder.CurrentRow.Cells[4].Value.ToString();
                TxtUnitPrice.Text = DGV_PruChaseOrder.CurrentRow.Cells[5].Value.ToString();
                TxtAmount.Text = DGV_PruChaseOrder.CurrentRow.Cells[6].Value.ToString();
                DGV_PruChaseOrder.Rows.RemoveAt(DGV_PruChaseOrder.CurrentRow.Index);
            }
            catch
            {
                return;
            }
        }

        void CreateDataTable()
        {
            Dt.Columns.Add("رقم الايصال");
            Dt.Columns.Add("الباركود");
            Dt.Columns.Add("إسم الصنف");
            Dt.Columns.Add("سعر الشراء");
            Dt.Columns.Add("الكمية");
            Dt.Columns.Add("سعر الوحدة");
            Dt.Columns.Add("المبلغ ");

            DGV_PruChaseOrder.DataSource = Dt;

            //Add ButtonColumn To DataGridView
            /*  DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
              btn.HeaderText = "اختيار منتج";
              btn.Text = "البحث";
              btn.UseColumnTextForButtonValue = true;
              DGV_PruChaseOrder.Columns.Insert(0,btn); */
        }

        //void ResizeDGV()
        //{
        //    this.DGV_PruChaseOrder.RowHeadersWidth = 86;
        //    this.DGV_PruChaseOrder.Columns[0].Width = 99;
        //    this.DGV_PruChaseOrder.Columns[1].Width = 199;
        //    this.DGV_PruChaseOrder.Columns[2].Width = 85;
        //    this.DGV_PruChaseOrder.Columns[3].Width = 93;
        //    this.DGV_PruChaseOrder.Columns[4].Width = 85;
        //    this.DGV_PruChaseOrder.Columns[5].Width = 93;
        //    this.DGV_PruChaseOrder.Columns[6].Width = 121;

        //}


        public Frn_PruChaseOrder()
        {
            InitializeComponent();
            CreateDataTable();
            CalculateTotalAmount();
            //ResizeDGV();
            User_PurOrder.Text = Program.UserName;
            BtnAdd.Enabled = false;
            CMB_TSDID.SelectedIndex = 0;
            BtnNew.Focus();
            panelSupp.Enabled = false;
            //Status.Visible = false;
            var dateNow = DateTime.Now;
            var date = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day);
            PurOrder_Date.DateTime = dateNow;
        }

        private void Frn_PruChaseOrder_Load(object sender, EventArgs e)
        {


        }

        private void textEdit14_Properties_EditValueChanged(object sender, EventArgs e)
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

        private void textEdit14_TextChanged(object sender, EventArgs e)
        {
            var TotalAmount = Convert.ToDouble(Total_Amount.Text);
            try
            {
                ConvertNumbersToArabicAlphabet a = new ConvertNumbersToArabicAlphabet(TotalAmount.ToString());
                Total_Amount_Ar.Text = a.GetNumberAr();
            }
            catch
            {
                return;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            PL.Suppliers.Frm_SelectSupplier frm = new PL.Suppliers.Frm_SelectSupplier();
            frm.ShowDialog();
            try
            {


                PurSup_ID.Text = frm.DGVSelectSupplier.CurrentRow.Cells[0].Value.ToString();
                Sup_Name.Text = frm.DGVSelectSupplier.CurrentRow.Cells[1].Value.ToString();
                Sup_Phone.Text = frm.DGVSelectSupplier.CurrentRow.Cells[2].Value.ToString();
                credit.Text = frm.DGVSelectSupplier.CurrentRow.Cells[12].Value.ToString();
                debit.Text = frm.DGVSelectSupplier.CurrentRow.Cells[13].Value.ToString();

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
                //if (ClsPru.(PurOrder_Id.Text, Convert.ToDouble(PurItem_QTE.Text)).Rows.Count < 1)
                //{
                //    MessageBox.Show("الكمية المدخلة لهذا المنتج غير متاحة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    return;

                //}

                //for (int i = 0; i < DGV_PruChaseOrder.Rows.Count; i++)
                //{
                //    //if (DGV_PruChaseOrder.Rows[i].Cells[0].Value.ToString() == txtIDproduct.Text)
                //    if (DGV_PruChaseOrder.Rows[i].Cells[0].Value.ToString() == PurItem_Name.Text)
                //    {
                //        MessageBox.Show("هذا المنتج تم إدخاله مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //        return;
                //    }

                    if (PurItem_Name.Text == string.Empty || PurItem_Price.Text == string.Empty || PurItem_QTE.Text == string.Empty
                   || TxtUnitPrice.Text == string.Empty || TxtAmount.Text == string.Empty)
                {
                    return;
                }
                DataRow r = Dt.NewRow();
                r[0] = TxtRecived.Text;
                r[1] = BarCode.Text;
                r[2] = PurItem_Name.Text;
                r[3] = PurItem_Price.Text;
                r[4] = PurItem_QTE.Text;
                r[5] = TxtUnitPrice.Text;
                r[6] = TxtAmount.Text;

                Dt.Rows.Add(r);
                DGV_PruChaseOrder.DataSource = Dt;
                clear();
                Total_Amount.Text =
                   (from DataGridViewRow row in DGV_PruChaseOrder.Rows
                    where row.Cells[6].FormattedValue.ToString() != string.Empty
                    select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString("0.00");

                //}
            }

            catch
            {
                return;
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                PurOrder_Id.Text = ClsPru.PruChaseOrderMaxId().Rows[0][0].ToString();
                VoucherCode.Text = Clsfs.GetAllFinancialSupportaMax().Rows[0][0].ToString();
                BtnNew.Enabled = false;
                BtnAdd.Enabled = true;
                PurOrder_Desc.Focus();
                PurOrder_Desc.Text = "فاتورة مشتريات رقم : " + PurOrder_Id.Text;
                PurSup_ID.Text = "1";
                Sup_Name.Text = "بدون مورد";
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
                if (PurOrder_Id.Text == string.Empty || User_PurOrder.Text == string.Empty || DGV_PruChaseOrder.Rows.Count < 1 || PurOrder_Desc.Text == string.Empty || PurSup_ID.Text == string.Empty)
                {
                    MessageBox.Show("برجاء اكمال كافة الحقول!!", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    if (CMB_TSDID.Text == "نقدي")
                    {

                        //إضافة معلومات الفاتورة
                        ClsPru.Add_PruChaseOrder(Convert.ToInt32(PurOrder_Id.Text), PurOrder_Date.DateTime, PurOrder_Desc.Text,
                        Convert.ToInt32(PurSup_ID.Text), User_PurOrder.Text);

                        //إضافة المنتجات المدخلة
                        for (int i = 0; i < DGV_PruChaseOrder.Rows.Count; i++)
                        {
                            ClsPru.InsertPruchaseOrderDetailes(
                                Convert.ToInt32(PurOrder_Id.Text),
                                DGV_PruChaseOrder.Rows[i].Cells[0].Value.ToString(),
                                DGV_PruChaseOrder.Rows[i].Cells[1].Value.ToString(),
                                DGV_PruChaseOrder.Rows[i].Cells[2].Value.ToString(),
                                Convert.ToDouble(DGV_PruChaseOrder.Rows[i].Cells[3].Value.ToString()),
                                Convert.ToDouble(DGV_PruChaseOrder.Rows[i].Cells[4].Value.ToString()),
                                Convert.ToDouble(DGV_PruChaseOrder.Rows[i].Cells[6].Value.ToString()),
                                Convert.ToDouble(Total_Amount.Text),
                                Total_Amount_Ar.Text, Status.Text,
                                Convert.ToDouble(DGV_PruChaseOrder.Rows[i].Cells[5].Value.ToString()));
                        }
                    }

                    if (CMB_TSDID.Text == "آجل")
                    {
                        Clsfs.AddAllFinancialSupport(Convert.ToInt32(VoucherCode.Text),PurOrder_Date.DateTime, Convert.ToDouble(Total_Amount.Text),
                        Total_Amount_Ar.Text, "السيد / " + Sup_Name.Text, "سند دفع تابع لفاتورة مشتريات رقم :" + VoucherCode.Text,
                        User_PurOrder.Text, Convert.ToDouble(txtmadfoa.Text),NewDofaaAr.Text, Convert.ToDouble(txtmotbqi.Text), txtBaqiAr.Text);
                          

                        //إضافة معلومات الفاتورة
                        ClsPru.Add_PruChaseOrder(Convert.ToInt32(PurOrder_Id.Text), PurOrder_Date.DateTime, PurOrder_Desc.Text,
                        Convert.ToInt32(PurSup_ID.Text), User_PurOrder.Text);

                        //إضافة المنتجات المدخلة
                        for (int i = 0; i < DGV_PruChaseOrder.Rows.Count; i++)
                        {
                            ClsPru.InsertPruchaseOrderDetailes(
                                Convert.ToInt32(PurOrder_Id.Text),
                                DGV_PruChaseOrder.Rows[i].Cells[0].Value.ToString(),
                                DGV_PruChaseOrder.Rows[i].Cells[1].Value.ToString(),
                                DGV_PruChaseOrder.Rows[i].Cells[2].Value.ToString(),
                               Convert.ToDouble(DGV_PruChaseOrder.Rows[i].Cells[3].Value.ToString()),
                                Convert.ToDouble(DGV_PruChaseOrder.Rows[i].Cells[4].Value.ToString()),
                               Convert.ToDouble(DGV_PruChaseOrder.Rows[i].Cells[6].Value.ToString()),
                                Convert.ToDouble(Total_Amount.Text),
                                Total_Amount_Ar.Text, Status.Text,
                                Convert.ToDouble(DGV_PruChaseOrder.Rows[i].Cells[5].Value.ToString()));

                        }


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    //return;
                }


                MessageBox.Show("تمت عملية الحفظ بنجاح", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    if (MessageBox.Show("هل تريد طباعة هذة الفاتورة؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Cursor = Cursors.WaitCursor;
                        Reports.Purchase.OnePruchaseBill report = new Reports.Purchase.OnePruchaseBill();
                        int order_ID = Convert.ToInt32(PurOrder_Id.Text);
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

                    return;
                }


                ClearBoxes();
                BtnNew.Enabled = true;
                BtnAdd.Enabled = false;
            }
            catch
            {
                return;
            }
        }

        private void PurOrder_Desc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PurAdd.Focus();
            }
        }

        private void WithOutSup_CheckedChanged(object sender, EventArgs e)
        {
            panelSupp.Enabled = false;
            PurSup_ID.Text = "1";
            Sup_Name.Text = "بدون مورد";
        }

        private void WithSupp_CheckedChanged(object sender, EventArgs e)
        {
            panelSupp.Enabled = true;
        }

        private void PurItem_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }
        }

        private void PurItem_Price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && PurItem_Price.Text != string.Empty)
            {
                PurItem_QTE.Focus();
            }
        }

        private void PurItem_Price_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateAmount();
            CalculateTotalAmount();
        }

        private void PurItem_QTE_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }
        }

        private void PurItem_QTE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && PurItem_QTE.Text != string.Empty)
            {
                PurAdd_Click(sender, e);
            }
        }

        private void PurItem_QTE_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateAmount();
            CalculateTotalAmount();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Org_Bill_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BarCode.Focus();
            }
        }

        private void BarCode_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                PurItem_Name.Focus();
            }
        }

        private void PurItem_Name_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                PurItem_Price.Focus();
            }
        }

        private void DGV_PruChaseOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            getdata();
        }

        private void حذفهذاالسطرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DGV_PruChaseOrder.Rows.RemoveAt(DGV_PruChaseOrder.CurrentRow.Index);
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
                DGV_PruChaseOrder.DataSource = null;
                CreateDataTable();
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
                if (CMB_TSDID.SelectedIndex == 0)
                {
                    txtmadfoa.Text = "0";
                    txtmotbqi.Text = "0";
                }
                else
                {
                    double madfoa = Convert.ToDouble(txtmadfoa.Text);
                    double Amount = Convert.ToDouble((from DataGridViewRow row in DGV_PruChaseOrder.Rows
                                                      where row.Cells[6].FormattedValue.ToString() != string.Empty
                                                      select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString());
                    double REsult = Amount - madfoa;
                    txtmotbqi.Text = REsult.ToString();
                }


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

        private void DGV_PruChaseOrder_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalculateTotalAmount();
        }

        private void CMB_TSDID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CMB_TSDID.SelectedIndex == 1)
                {
                    VoucherCode.Text = Clsfs.GetAllFinancialSupportaMax().Rows[0][0].ToString();
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
                ConvertNumbersToArabicAlphabet madfoa = new ConvertNumbersToArabicAlphabet(txtmadfoa.Text);
                ConvertNumbersToArabicAlphabet motbqi = new ConvertNumbersToArabicAlphabet(txtmotbqi.Text);

                
                NewDofaaAr.Text = madfoa.GetNumberAr();
                txtBaqiAr.Text = motbqi.GetNumberAr();
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
    }
}