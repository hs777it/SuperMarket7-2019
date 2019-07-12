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

namespace SuperMarket.PL.Items
{
    

    public partial class Frm_Items : DevExpress.XtraEditors.XtraForm
    {
        Classes.ClsItems ClsItem = new Classes.ClsItems();

        public int id;
        public Frm_Items()
        {
            InitializeComponent();
            LoadData();
            Status.Visible = false;
        }
        private void LoadData()
        {
           try
            {
                DGV_Items.DataSource = ClsItem.GatAllItems();
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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            PL.Items.Frm_AddItems frm = new PL.Items.Frm_AddItems();
            try
            {
                frm.TxtItemId.Text = ClsItem.MaxItemId().Rows[0][0].ToString();
                frm.BtnAdd.Enabled = true;
                frm.BtnNew.Enabled = false;
                frm.ShowDialog();
                LoadData();
            }
            catch
            {
                return;
            }
            

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            PL.Items.Frm_AddItems frm = new PL.Items.Frm_AddItems();
            frm.Text = "تعديل صنف";
            frm.BtnNew.Visible = false;
            frm.BtnAdd.Visible  = false ;
            //frm.BtnAdd.SendToBack();
            frm.BtnEdit.Location = new Point( 299, 19);
            frm.BtnEdit.BringToFront();
        try
            {
                frm.TxtItemId.Text = this.DGV_Items.CurrentRow.Cells[0].Value.ToString();
                frm.TxtBarCode.Text = this.DGV_Items.CurrentRow.Cells[1].Value.ToString();
                frm.TxtItemName.Text = this.DGV_Items.CurrentRow.Cells[2].Value.ToString();
                frm.DateAdded.Text = this.DGV_Items.CurrentRow.Cells[3].Value.ToString();
                frm.TxtPurPrice.Text = this.DGV_Items.CurrentRow.Cells[4].Value.ToString();
                frm.TxtSalePrice.Text = this.DGV_Items.CurrentRow.Cells[5].Value.ToString();
                frm.TxtQTE.Text = this.DGV_Items.CurrentRow.Cells[6].Value.ToString();
                frm.TxtDiscount.Text = this.DGV_Items.CurrentRow.Cells[7].Value.ToString();
                frm.Cmb_CatID.Text = this.DGV_Items.CurrentRow.Cells[8].Value.ToString();
                frm.ShowDialog();
                LoadData();
            }
            catch
            {
                return;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnPreview_Click(object sender, EventArgs e)
        {

            PL.Items.Frm_AddItems frm = new PL.Items.Frm_AddItems();
            frm.Text = "معاينة الصنف";
            frm.BtnNew.Visible = false;
            frm.BtnAdd.Visible = false;
            frm.BtnEdit.Visible = false;
            frm.BtnPurList.Visible = false;
            try
            {
                frm.TxtItemId.Text = this.DGV_Items.CurrentRow.Cells[0].Value.ToString();
                frm.TxtBarCode.Text = this.DGV_Items.CurrentRow.Cells[1].Value.ToString();
                frm.TxtItemName.Text = this.DGV_Items.CurrentRow.Cells[2].Value.ToString();
                frm.DateAdded.Text = this.DGV_Items.CurrentRow.Cells[3].Value.ToString();
                frm.TxtPurPrice.Text = this.DGV_Items.CurrentRow.Cells[4].Value.ToString();
                frm.TxtSalePrice.Text = this.DGV_Items.CurrentRow.Cells[5].Value.ToString();
                frm.TxtQTE.Text = this.DGV_Items.CurrentRow.Cells[6].Value.ToString();
                frm.TxtDiscount.Text = this.DGV_Items.CurrentRow.Cells[7].Value.ToString();
                frm.Cmb_CatID.Text = this.DGV_Items.CurrentRow.Cells[8].Value.ToString();
                frm.ShowDialog();
                LoadData();
            }
            catch
            {
                return;
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            try
            {               
                DialogResult dialog = MessageBox.Show("هل انت متأكد من انك تريد الحذف ؟", "واى إن للبرمجيات", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.No)
                {
                    return;
                }
                try
                {
                    ClsItem.UdateStatus(Status.Text, this.DGV_Items.CurrentRow.Cells[2].Value.ToString());
                }
                catch
                {
                    return;
                }
                int Id = Convert.ToInt32(this.DGV_Items.CurrentRow.Cells[0].Value.ToString());
               
                ClsItem.DeletItmes(Id);
                MessageBox.Show("تمت عملية الحذف بنجاح", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
              
                LoadData();

            }
            catch
            {
                return;
            }
        }

        private void BtnAddCompany_Click(object sender, EventArgs e)
        {
            PL.Items.Frm_ItemCompany frm = new PL.Items.Frm_ItemCompany();
            try
            {
                frm.TxtItemId.Text = this.DGV_Items.CurrentRow.Cells[0].Value.ToString();              
                frm.ShowDialog();
            }
            catch
            {
                return;
            }
        }

        private void BtnAddPlace_Click(object sender, EventArgs e)
        {
            PL.Places.Frm_Places frm = new PL.Places.Frm_Places();
            try
            {
                frm.TxtItemId.Text = this.DGV_Items.CurrentRow.Cells[0].Value.ToString();
                frm.ShowDialog();
            }
            catch
            {
                return;
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Reports.items.SinglItemPrint report = new Reports.items.SinglItemPrint();
                int order_ID = Convert.ToInt32(this.DGV_Items.CurrentRow.Cells[0].Value.ToString());
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

        private void BtnPintAll_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Reports.items.ItemPrintAll report = new Reports.items.ItemPrintAll();
                report.SetDataSource(ClsItem.GatAllItemsPrintAll());
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

        private void SearchUsers_TextChanged(object sender, EventArgs e)
        {

            try
            {
                this.DGV_Items.DataSource = ClsItem.SearchItems(SearchUsers.Text);
            }
            catch
            {
                return;
            }
        }

        private void Frm_Items_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void تعديلالصنفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnEdit_Click(sender, e);
        }

        private void حذفالصنفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnDel_Click(sender, e);
        }

        private void معاينةالصنفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnPreview_Click(sender, e);
        }

        private void إضافةشركةللصنفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnAddCompany_Click(sender, e);
        }

        private void إضافةمكانللصنفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnAddPlace_Click(sender, e);
        }

        private void طباعةالصنفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnPrint_Click(sender, e);
        }
    }
}