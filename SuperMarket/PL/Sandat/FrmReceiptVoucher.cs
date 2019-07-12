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

namespace SuperMarket.PL.Sandat
{
    public partial class FrmReceiptVoucher : DevExpress.XtraEditors.XtraForm
    {
        Classes.ClsReceiptVoucher ClsRV = new Classes.ClsReceiptVoucher();
        public FrmReceiptVoucher()
        {
            InitializeComponent();
            var dateNow = DateTime.Now;
            var date = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day);
            VoucherDate.DateTime = dateNow;
            UserVoucher.Text = Program.UserName;
            LoadComboBox();
            SandatCalculateAmount();
        }
        void clear()
        {
           VoucherCode.Text = "";
            VoucherRNum.Text = "";
            VoucherAmount.Text = "";
            VoucherAmountAr.Text = "";
            statement.Text = "";
            VoucherFrom.Text ="";
            var dateNow = DateTime.Now;
            var date = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day);
            VoucherDate.DateTime = dateNow;
            UserVoucher.Text = Program.UserName;
            VoucherCode.Text = "";
            TxtNewDofaa.Text = "";
            TxtNewDofaaAr.Text = "";
            txtBaqi.Text = "";
            txtBaqiAr.Text = "";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (VoucherCode.Text == string.Empty || VoucherRNum.Text == string.Empty || VoucherAmount.Text  == string.Empty || VoucherFrom.Text == string.Empty)
                {
                    MessageBox.Show("برجاء اكمال الخانات اولاً !!", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
               
                if (radioButton1.Checked == true)
                {
                    ClsRV.AddVoucher(Convert.ToInt32(VoucherCode.Text), VoucherRNum.Text, VoucherDate.DateTime, Convert.ToDouble(VoucherAmount.Text),
                     VoucherAmountAr.Text, "السيد / " + VoucherFrom.Text, statement.Text, UserVoucher.Text, Convert.ToDouble(TxtNewDofaa.Text),TxtNewDofaaAr.Text, Convert.ToDouble(txtBaqi.Text ),txtBaqiAr.Text);
                    MessageBox.Show("تم إضافة سند الصرف بنجاح", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                if (radioButton2.Checked == true)
                {
                    ClsRV.AddVoucher(Convert.ToInt32(VoucherCode.Text), VoucherRNum.Text, VoucherDate.DateTime, Convert.ToDouble(VoucherAmount.Text),
                    VoucherAmountAr.Text, "السيد / " + CmbCust.Text, statement.Text, UserVoucher.Text, Convert.ToDouble(TxtNewDofaa.Text), TxtNewDofaaAr.Text, Convert.ToDouble(txtBaqi.Text), txtBaqiAr.Text);
                    MessageBox.Show("تم إضافة سند الصرف بنجاح", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
            }
            catch
            {
                return;
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            VoucherCode.Text = ClsRV.GetMaxVoucher().Rows[0][0].ToString();
            BtnSave.Enabled = true;
            BtnNew.Enabled = false;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VoucherAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ConvertNumbersToArabicAlphabet a = new ConvertNumbersToArabicAlphabet(VoucherAmount.Text);
                VoucherAmountAr.Text = a.GetNumberAr();
            }
            catch
            {
                return;
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (VoucherCode.Text == string.Empty || VoucherRNum.Text == string.Empty || VoucherAmount.Text == string.Empty || VoucherFrom.Text == string.Empty)
                {
                    MessageBox.Show("برجاء اكمال الخانات اولاً !!", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                ClsRV.UpdateVoucher(Convert.ToInt32(VoucherCode.Text), VoucherRNum.Text, VoucherDate.DateTime, Convert.ToDouble(VoucherAmount.Text),
                    VoucherAmountAr.Text,VoucherFrom.Text, statement.Text, UserVoucher.Text, Convert.ToDouble(TxtNewDofaa.Text), TxtNewDofaaAr.Text, Convert.ToDouble(txtBaqi.Text), txtBaqiAr.Text, Convert.ToInt32(VoucherCode.Text));
                MessageBox.Show("تم تعديل سند الصرف بنجاح", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();

            }
            catch
            {
                return;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked == true)
                {
                    VoucherFrom.BringToFront();
                    VoucherFrom.Visible = true;
                    CmbCust.Visible = false;
                    VoucherFrom.Focus();
                }
                if (radioButton2.Checked == true)
                {
                    VoucherFrom.SendToBack();
                    VoucherFrom.Visible = false;
                    CmbCust.Visible = true;
                    CmbCust.BringToFront();
                    CmbCust.SelectedIndex+= 1;
                }
            }
            catch 
            {

                return;
            }
        }
        private void LoadComboBox()
        {
            try
            {
                this.CmbCust.DataSource = ClsRV.GetAllCustomers();
                this.CmbCust.DisplayMember = "إسم العميل";
                this.CmbCust.ValueMember = "م";
                this.CmbCust.SelectedText = "اختر من القائمة";

            }
            catch
            {
                return;
            }
        }

        private void txtBaqi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SandatCalculateAmount();
                ConvertNumbersToArabicAlphabet a = new ConvertNumbersToArabicAlphabet(txtBaqi.Text);
                txtBaqiAr.Text = a.GetNumberAr();
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

                double madfoa = Convert.ToDouble(TxtNewDofaa.Text);
                double Amount = Convert.ToDouble(VoucherAmount.Text);
                double REsult = Convert.ToDouble(Amount) - Convert.ToDouble(madfoa);
                txtBaqi.Text = REsult.ToString("0.00");

            }
            catch
            {
                return;
            }
        }
        private void TxtNewDofaa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SandatCalculateAmount();
                ConvertNumbersToArabicAlphabet a = new ConvertNumbersToArabicAlphabet(TxtNewDofaa.Text);
                TxtNewDofaaAr.Text = a.GetNumberAr();
            }
            catch
            {
                return;
            }
        }

        private void VoucherAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }
        }

        private void TxtNewDofaa_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }
        }

        private void CmbCust_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CmbCust.Text != string.Empty)
                {
                    DataTable dt = new DataTable();
                    dt = ClsRV.getDataForReceiptVoucher("السيد / " + CmbCust.Text);

                    if (dt.Rows.Count > 0)
                    {
                        VoucherCode.Text = dt.Rows[0][0].ToString();
                        VoucherRNum.Text= dt.Rows[0][1].ToString();
                        CmbCust.Text= dt.Rows[0][5].ToString();
                        VoucherAmount.Text = dt.Rows[0][10].ToString();
                        TxtNewDofaa.Text = "0";
                        txtBaqi.Text = "0";
                    }


                }

            }
            catch
            {
                return;
            }
        }
    }
    
}