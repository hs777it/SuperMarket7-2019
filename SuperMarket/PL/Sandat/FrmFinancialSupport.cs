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
    public partial class FrmFinancialSupport : DevExpress.XtraEditors.XtraForm
    {
        Classes.ClsSuppliers ClsCat = new Classes.ClsSuppliers();
        Classes.ClsFinancialSupport Clsfs = new Classes.ClsFinancialSupport();
        public FrmFinancialSupport()
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
            VoucherAmount.Text = "";
            VoucherAmountAr.Text = "";
            statement.Text = "";
            VoucherFrom.Text = "";
            var dateNow = DateTime.Now;
            var date = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day);
            VoucherDate.DateTime = dateNow;
            UserVoucher.Text = Program.UserName;
            TxtNewDofaa.Text = "";
            TxtNewDofaaAr.Text = "";
            txtBaqi.Text = "";
            txtBaqiAr.Text = "";
        }

       
        private void BtnNew_Click(object sender, EventArgs e)
        {
            VoucherCode.Text = Clsfs.GetAllFinancialSupportaMax().Rows[0][0].ToString();
            BtnSave.Enabled = true;
            BtnNew.Enabled = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (VoucherCode.Text == string.Empty || VoucherAmount.Text == string.Empty || VoucherFrom.Text == string.Empty)
                {
                    MessageBox.Show("برجاء اكمال الخانات اولاً !!", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                try
                {
                    if (radioButton1.Checked == true)
                    {
                        Clsfs.AddAllFinancialSupport(Convert.ToInt32(VoucherCode.Text), VoucherDate.DateTime, Convert.ToDouble(VoucherAmount.Text),
                   VoucherAmountAr.Text, "السيد / " + VoucherFrom.Text, statement.Text, UserVoucher.Text, Convert.ToDouble(TxtNewDofaa.Text), TxtNewDofaaAr.Text,
                   Convert.ToDouble(txtBaqi.Text), txtBaqiAr.Text);
                        MessageBox.Show("تم إضافة سند الصرف بنجاح", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    if (radioButton2.Checked == true)
                    {
                        Clsfs.AddAllFinancialSupport(Convert.ToInt32(VoucherCode.Text), VoucherDate.DateTime, Convert.ToDouble(VoucherAmount.Text),
                   VoucherAmountAr.Text, "السيد / " + CmbSuppliers.Text, statement.Text, UserVoucher.Text, Convert.ToDouble(TxtNewDofaa.Text), TxtNewDofaaAr.Text, Convert.ToDouble(txtBaqi.Text), txtBaqiAr.Text);
                        MessageBox.Show("تم إضافة سند الصرف بنجاح", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
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

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (VoucherCode.Text == string.Empty || VoucherAmount.Text == string.Empty || VoucherFrom.Text == string.Empty)
                {
                    MessageBox.Show("برجاء اكمال الخانات اولاً !!", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                Clsfs.UpdateAllFinancialSupport(Convert.ToInt32(VoucherCode.Text), VoucherDate.DateTime, Convert.ToDouble(VoucherAmount.Text),
                    VoucherAmountAr.Text, VoucherFrom.Text, statement.Text, UserVoucher.Text, Convert.ToDouble(TxtNewDofaa.Text), TxtNewDofaaAr.Text, Convert.ToDouble(txtBaqi.Text), txtBaqiAr.Text, Convert.ToInt32(VoucherCode.Text));
                MessageBox.Show("تم تعديل سند الصرف بنجاح", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            catch
            {
                return;
            }
        }

        private void VoucherAmount_TextChanged(object sender, EventArgs e)
        {
            SandatCalculateAmount();
            try
            {
               
                if (Convert.ToDouble(VoucherAmount.Text) > 0)
                {
                    ConvertNumbersToArabicAlphabet a = new ConvertNumbersToArabicAlphabet(VoucherAmount.Text);
                    VoucherAmountAr.Text = a.GetNumberAr();
                }
                else
                {
                    VoucherAmountAr.Text = "";
                }
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
        private void LoadComboBox()
        {
            try
            {
                this.CmbSuppliers.DataSource = Clsfs.GetAllSuppliers();
                this.CmbSuppliers.DisplayMember = "إسم المورد";
                this.CmbSuppliers.ValueMember = "المسلسل";
                this.CmbSuppliers.SelectedText = "اختر من القائمة";

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
                    CmbSuppliers.Visible = false;
                    VoucherFrom.Focus();
                }
                if (radioButton2.Checked == true)
                {
                    VoucherFrom.SendToBack();
                    VoucherFrom.Visible = false;
                    CmbSuppliers.Visible = true;
                    CmbSuppliers.BringToFront();
                    CmbSuppliers.SelectedIndex += 1;
                }
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
                if (Convert.ToDouble(txtBaqi.Text) > 0)
                {
                    SandatCalculateAmount();
                    ConvertNumbersToArabicAlphabet a = new ConvertNumbersToArabicAlphabet(txtBaqi.Text);
                    txtBaqiAr.Text = a.GetNumberAr();
                }
                else
                {
                    txtBaqiAr.Text = "";
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
                if (Convert.ToDouble(TxtNewDofaa.Text) > 0)
                {
                    ConvertNumbersToArabicAlphabet a = new ConvertNumbersToArabicAlphabet(TxtNewDofaa.Text);
                    TxtNewDofaaAr.Text = a.GetNumberAr();
                }
                else
                {
                    TxtNewDofaaAr.Text = "";
                }
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

        private void txtBaqi_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }
        }

        private void CmbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {               
                    DataTable dt = new DataTable();
                    dt = Clsfs.getDataForFinancialSupport("السيد / " + CmbSuppliers.Text);

                    if (dt.Rows.Count > 0)
                    {
                    VoucherCode.Text = dt.Rows[0][0].ToString();
                    CmbSuppliers.Text= dt.Rows[0][4].ToString();
                    VoucherAmount.Text = dt.Rows[0][9].ToString();
                    TxtNewDofaa.Text  = "0";
                    txtBaqi.Text = "0";
                    }


                
                
            }
            catch
            {
                return;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}