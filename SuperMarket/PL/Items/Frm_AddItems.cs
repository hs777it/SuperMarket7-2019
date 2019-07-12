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

namespace SuperMarket.PL.Items
{
    public partial class Frm_AddItems : DevExpress.XtraEditors.XtraForm
    {
        Classes.ClsStores ClsStore = new Classes.ClsStores();
        Classes.ClsCategory ClsCat = new Classes.ClsCategory();
        Classes.ClsItems ClsItems = new Classes.ClsItems();
        Classes.ClsPruChaseOrder ClsPru = new Classes.ClsPruChaseOrder();
        PL.Items.Frm_Items frm = new PL.Items.Frm_Items();

        public  int id;
        public Frm_AddItems()
        {
            InitializeComponent();
            LoadComboBox();
            BtnAdd.Enabled = false;
            Status.Visible = false;
            panel1.SendToBack();
            BtnEdit.SendToBack();
            var dateNow = DateTime.Now;
            var date = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day);
            DateAdded.DateTime = dateNow;
        }
        private void LoadData()
        {
            try
            {

                this.DGV_PruChaseOrder.DataSource = ClsPru.GetAllPruchaseOrderDetailes();

                DGV_PruChaseOrder.Columns[0].Visible = false;
                DGV_PruChaseOrder.Columns[1].Visible = false;
                DGV_PruChaseOrder.Columns[2].Visible = false;
                DGV_PruChaseOrder.Columns[4].Visible = false;
                DGV_PruChaseOrder.Columns[5].Visible = false;
                DGV_PruChaseOrder.Columns[6].Visible = false;
                DGV_PruChaseOrder.Columns[7].Visible = false;
                DGV_PruChaseOrder.Columns[8].Visible = false;
                DGV_PruChaseOrder.Columns[10].Visible = false;
                DGV_PruChaseOrder.Columns[11].Visible = false;
                DGV_PruChaseOrder.Columns[12].Visible = false;

            }
            catch
            {
                return;
            }
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
               this.Close();
        }

        private void TxtBarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtItemName.Focus();
            }
        }

        private void TxtItemName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtSalePrice.Focus();
            }
        }

        private void TxtSalePrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtPurPrice.Focus();
            }
        }

        private void TxtPurPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtQTE.Focus();
            }
        }

        private void TxtQTE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtDiscount.Focus();
            }
        }

        private void TxtDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnAdd_Click(sender, e);
            }
        }
       
        
        public  void clear()
        {
            TxtItemId.Text = "";
            TxtItemName.Text = "";
            TxtBarCode.Text = "";
            TxtPurPrice.Text = "";
            TxtSalePrice.Text = "";
            TxtQTE.Text = "";
            TxtDiscount.Text = "";
            Cmb_CatID.SelectedItem = null;
            CmbStock.SelectedItem = null;
            var dateNow = DateTime.Now;
            var date = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day);
            DateAdded.DateTime = dateNow;
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
           

            try

            {

                if (TxtItemId.Text == string.Empty || TxtItemName.Text == string.Empty || TxtBarCode.Text == string.Empty
         || TxtPurPrice.Text == string.Empty || TxtSalePrice.Text == string.Empty || TxtQTE.Text == string.Empty
         || TxtDiscount.Text == string.Empty || Cmb_CatID.SelectedItem == null || CmbStock.SelectedItem == null)
                {
                    MessageBox.Show("بعض الخانات فارغة !!", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                ClsItems.InsertItems(Convert.ToInt32(TxtItemId.Text), TxtBarCode.Text, TxtItemName.Text, DateAdded.DateTime , Convert.ToDouble(TxtPurPrice.Text),
                   Convert.ToDouble(TxtSalePrice.Text), Convert.ToDouble(TxtQTE.Text), Convert.ToDouble(TxtDiscount.Text), Convert.ToInt32(Cmb_CatID.SelectedIndex +1), 
                    Convert.ToInt32(CmbStock.SelectedIndex + 1));
                MessageBox.Show("تم إضافة الصنف بنجاح", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnNew.Enabled = true;
                BtnNew.Focus();
                BtnAdd.Enabled = false;
                
                try
                {
                    ClsItems.UdateStatus(Status.Text,TxtItemName.Text);
                    clear();
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

        private void TxtQTE_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }
        }

        private void TxtSalePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }
        }

        private void TxtPurPrice_KeyPress(object sender, KeyPressEventArgs e)
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

        public  void show()
        {
            try
            {
                
                TxtBarCode.Text = DGV_PruChaseOrder.CurrentRow.Cells[2].Value.ToString();
                TxtItemName.Text = DGV_PruChaseOrder.CurrentRow.Cells[3].Value.ToString();
                TxtPurPrice.Text = DGV_PruChaseOrder.CurrentRow.Cells[10].Value.ToString();
                TxtQTE.Text = DGV_PruChaseOrder.CurrentRow.Cells[5].Value.ToString();
                id = Convert.ToInt32(DGV_PruChaseOrder.CurrentRow.Cells[0].Value.ToString());

            }
            catch
            {
                return;
            }
        }
        private void BtnPurList_Click(object sender, EventArgs e)
        {
           try
            {

                //PL.PruChaseOrder.Frm_PruChaseList frm = new PL.PruChaseOrder.Frm_PruChaseList();                          
                //frm.Show();
                ////show();

                //TxtBarCode.Text = frm.DGV_PruChaseOrder.CurrentRow.Cells[2].Value.ToString();
                //TxtItemName.Text = frm.DGV_PruChaseOrder.CurrentRow.Cells[3].Value.ToString();
                //TxtPurPrice.Text = frm.DGV_PruChaseOrder.CurrentRow.Cells[10].Value.ToString();
                //TxtQTE.Text = frm.DGV_PruChaseOrder.CurrentRow.Cells[5].Value.ToString();
                //id = Convert.ToDouble(frm.DGV_PruChaseOrder.CurrentRow.Cells[0].Value.ToString());
                LoadData();
                panel1.BringToFront ();


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
                this.Cmb_CatID.DataSource = ClsCat.GetAllCategory();
                this.Cmb_CatID.DisplayMember = "اسم المجموعة"; 
                this.Cmb_CatID.ValueMember = "رقم المجموعة";
                this.Cmb_CatID.SelectedText = "اختر من القائمة";

                //------------------------------------------------------------

                this.CmbStock.DataSource = ClsStore.GetAllStores();
                this.CmbStock.DisplayMember = "إسم المخزن";
                this.CmbStock.ValueMember = "رقم المخزن";
                this.CmbStock.SelectedText = "اختر من القائمة";

            }
            catch
            {
                return;
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            TxtItemId.Text = ClsItems.MaxItemId().Rows[0][0].ToString();
            BtnAdd.Enabled = true;
            BtnNew.Enabled = false;
        }

        private void Frm_AddItems_Load(object sender, EventArgs e)
        {
          
        }

        private void DGV_PruChaseOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.DGV_PruChaseOrder.CurrentRow.Cells[9].Value.ToString() == "الفاتورة مضافة")
                {
                    MessageBox.Show("هذا الصنف تم إضافته مسبقا", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return;
                }

                panel1.SendToBack();
            }
            catch
            {
                return;
            }
        }

        private void DGV_PruChaseOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.DGV_PruChaseOrder.CurrentRow.Cells[9].Value.ToString() == "الفاتورة مضافة")
                {
                    MessageBox.Show("هذا الصنف تم إضافته مسبقا", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return;
                }
                show();
                panel1.SendToBack();
                //BtnClose.BringToFront();
            }
            catch
            {
                return;
            }
            //show();
            //panel1.SendToBack();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try

            {

                DialogResult dialog = MessageBox.Show("هل انت متأكد من انك تريد تعديل البيانات؟", "واى إن للبرمجيات", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.No)
                {
                    return;
                }
                if (TxtItemId.Text == string.Empty || TxtItemName.Text == string.Empty || TxtBarCode.Text == string.Empty
                  || TxtPurPrice.Text == string.Empty || TxtSalePrice.Text == string.Empty || TxtQTE.Text == string.Empty
                  || TxtDiscount.Text == string.Empty || Cmb_CatID.SelectedItem == null)
                {
                    MessageBox.Show("بعض الخانات فارغة !!", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                ClsItems.updateItems(Convert.ToInt32(TxtItemId.Text), TxtBarCode.Text, TxtItemName.Text, DateAdded.DateTime, Convert.ToDouble(TxtPurPrice.Text),
                    Convert.ToDouble(TxtSalePrice.Text), Convert.ToDouble(TxtQTE.Text), Convert.ToDouble(TxtDiscount.Text), Convert.ToInt32(Cmb_CatID.SelectedValue ), Convert.ToInt32(CmbStock.SelectedIndex + 1));
                MessageBox.Show("تم تعديل الصنف بنجاح", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnNew.Visible = false;
                BtnAdd.Visible = false;
                BtnEdit.Location = new Point(299, 19);
                BtnEdit.BringToFront();
                clear();
               
            }
            catch
            {
                return;
            }
        }

        private void BtmClos_Click(object sender, EventArgs e)
        {
            panel1.SendToBack();
        }

        private void Frm_AddItems_Leave(object sender, EventArgs e)
        {
            try
            {
                PL.Items.Frm_Items frm = new PL.Items.Frm_Items();
                frm.DGV_Items.DataSource = ClsItems.GatAllItems();
            }
            catch
            {
                return;
            }
        }
    }
}