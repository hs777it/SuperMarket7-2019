using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Data.SqlClient;
using System.Threading;
using System.IO;
using Tulpep.NotificationWindow;
using SuperMarket.Properties;
using Microsoft.Win32;
using DevExpress.XtraBars.Helpers;
using SuperMarket.Classes;


namespace SuperMarket.PL.Main
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        
        Classes.ClsStores ClsStore = new Classes.ClsStores();
        Classes.ClsItems ClsItem = new Classes.ClsItems();
        Classes.ClsSuppliers ClsCat = new Classes.ClsSuppliers();
        Classes.clsCustomers ClsCust = new Classes.clsCustomers();
        Classes.ClsPruChaseOrder ClsPru = new Classes.ClsPruChaseOrder();
        Classes.ClsReturnItems ClsRet = new Classes.ClsReturnItems();
        Classes.ClsSales ClsSales = new Classes.ClsSales();
        Classes.ClsReceiptVoucher ClsRV = new Classes.ClsReceiptVoucher();
        Classes.ClsRetuenPruChase ClsRetb = new Classes.ClsRetuenPruChase();
        Classes.ClsFinancialSupport Clsfs = new Classes.ClsFinancialSupport();
        Classes.ClsMain ClsMain = new Classes.ClsMain();
        Classes.ClsPos ClsPos = new Classes.ClsPos();
        Data.DataAccessLayer MyDBAccess = new Data.DataAccessLayer();

        //Single Instance
        private static FrmMain frm;
        static void frmClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FrmMain getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FrmMain();
                    frm.FormClosed += new FormClosedEventHandler(frmClosed);
                }
                return frm;
            }
        }

        public object XtraMessage { get; private set; }

        double TResult;
        public FrmMain()

        {
            bool firstInstance;
            // using Mutex
            Mutex mutex = new Mutex(true, "ProgramKey", out firstInstance);
            // Check Copy
            if (!firstInstance)
            {
                // add any procedure here 
                MessageBox.Show("البرنامج فى وضعية التشغيل");
                // if you want the close the second copy
                Close();
            }

            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.Skins.SkinManager.EnableMdiFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();

            if (frm == null)
            {
                frm = this;
            }
                


            SkinHelper.InitSkinGallery(skinRibbonGalleryBarItem2, true, false);
            SkinHelper.InitSkinGallery(galleryControl1, true, true);

            sumTotalSales();
            GetSum_PruchaseOrder();
            Sum_SalesOrderDetails_Today();
            UserName.Caption = Program.UserName;
            UserType.Caption = Program.UserType;
        }

        private void barBtnUserLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            PL.Users.Frm_Login frm = new PL.Users.Frm_Login();
            frm.ShowDialog();
        }
        private void btnUserSwitch_ItemClick(object sender, ItemClickEventArgs e)
        {
            // clear all
            // close all
            new Users.Frm_Login().ShowDialog();
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            PL.Users.Frm_Login frm = new PL.Users.Frm_Login();
            frm.ShowDialog();
        }
        private void barBtnSwitchUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            barButtonItem8.PerformClick();
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            //RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\WINREGISTRY");
            //key.SetValue("SkinName", DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName);
            //key.Close();

            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\WINREGISTRY");
            key.SetValue(Program.UserName, DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName);
            key.Close();

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //var key = Registry.GetValue(@"HKEY_CURRENT_USER\Software\WINREGISTRY", "SkinName", null);
            //if (key != null) DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = key.ToString();


            //var key = Registry.GetValue(@"HKEY_CURRENT_USER\Software\WINREGISTRY", Program.UserName,null);
            //if (key != null) DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = key.ToString();


            //RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\WINREGISTRY");
            //if (Registry.GetValue(@"HKEY_CURRENT_USER\Software\WINREGISTRY", "SkinName",null) != null)
            //    DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = key.GetValue("SkinName").ToString();
            //picLogo.Image = Properties.Resources.
            //picLogo.Image = Image.FromFile(@"~\Resources\bg.jpg"); 
            try
            {
                ////------------------ MainBackGround
                //this.BackgroundImage  = Image.FromFile(Properties.Settings.Default.SystemBackGround);
                //this.BackgroundImageLayout = ImageLayout.Stretch;
                //Properties.Settings.Default.Save();
                if (Settings.Default.IsLicensed == true)
                {
                    Setting_Calaculate();
                    if (TResult == Convert.ToDouble(Classes.ClsEncryption.Decrypt(Settings.Default.KT.ToString())))
                    {
                       return;
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                ////------------------------- Pages
                //this.Page2.Visible = false;
                //this.Page3.Visible = false;
                //this.Page4.Visible = false;
                //this.Page5.Visible = false;
                //this.Page6.Visible = false;
                ////------------------------- TabsRibbon
                //this.Ribbon1.Visible = false;
                //this.Ribbon2.Visible = false;
                //this.Ribbon3.Visible = false;
                //this.Ribbon4.Visible = false;
                //this.Ribbon5.Visible = false;
                //this.Ribbon6.Visible = false;
                //this.Ribbon7.Visible = false;
                //this.Ribbon8.Visible = false;
                //this.Ribbon9.Visible = false;
                //this.Ribbon10.Visible = false;
                //this.Ribbon11.Visible = false;
                //this.Ribbon12.Visible = false;
                //this.Ribbon13.Visible = false;
                //this.Ribbon14.Visible = false;
                //this.Ribbon15.Visible = false;
                ////------------------------- ButtomsMain
                //this.barButtonItem17.Enabled = false;
                //this.barButtonItem20.Enabled = false;
                //this.barButtonStore.Enabled = false;
                //this.barBCate.Enabled = false;
                //this.barButtonItem24.Enabled = false;
                //this.barButtonItem25.Enabled = false;
                //this.barButtonItem5.Enabled = false;
                //this.barButtonItem26.Enabled = false;
                //this.barButtonItem27.Enabled = false;
                //this.barButtonItem28.Enabled = false;
                //this.barButtonItem33.Enabled = false;
                //this.barButtonItem34.Enabled = false;
                //this.barButtonItem15.Enabled = false;
                //this.barButtonItem23.Enabled = false;
                //this.barButtonItem16.Enabled = false;
                //this.barButtonItem22.Enabled = false;
                //this.barButtonItem21.Enabled = false;
                //this.barButtonItem3.Enabled = false;
                //this.barButtonItem4.Enabled = false;
                //this.barButtonItem6.Enabled = false;
                //this.barButtonItem7.Enabled = false;
                //this.barButtonItem8.Enabled = false;
                //this.barButtonItem29.Enabled = false;
                //this.barButtonItem30.Enabled = false;
                //this.barButtonItem31.Enabled = false;
                //this.barButtonItem32.Enabled = false;
                //this.barButtonItem14.Enabled = false;
                //this.barButtonItem11.Enabled = false;
                //this.barButtonItem12.Enabled = false;
                //this.barButtonItem13.Enabled = false;
                //this.barButtonItem37.Enabled = false;
                //this.barButtonItem38.Enabled = false;
                //this.barButtonItem39.Enabled = false;
                //this.barButtonItem40.Enabled = false;
                //this. barButtonItem42.Enabled = false;

                ////------------------------- النافبار
                //this.navBarControl1.Visible = false;
                ////------------------------- الفوتر
                //this.ribbonStatusBar.Visible = false;

                //DbAttach();
                Sum_SalesOrderDetails_Today();

                new PL.Users.Frm_Login().ShowDialog();

            }
            catch
            {
                return;
            }
        }

        private void DbAttach()
        {
            try
            {
                string Patch = Application.StartupPath + "\\" + "SuperMarket_DB.mdf";
                SqlConnection con = new SqlConnection(@"Server=.\sqlexpress; AttachDbFilename = " + Patch + "; Database=SuperMarket_DB; Integrated Security=true");
                {
                    con.Open();
                }

            }
            catch
            {
                return;
            }
        }

        void Setting_Calaculate()
        {
            if (Settings.Default.M != string.Empty && Settings.Default.M1 != string.Empty &&
                Settings.Default.M2 != string.Empty && Settings.Default.M3 != string.Empty)
            {
                double tx = Convert.ToDouble(Settings.Default.M);
                double tx1 = Convert.ToDouble(Settings.Default.M1);
                double tx2 = Convert.ToDouble(Settings.Default.M2);
                double tx3 = Convert.ToDouble(Settings.Default.M3);
                TResult = (tx + tx1) - (tx2 + tx3);
            }
        }

        private void barBCate_ItemClick(object sender, ItemClickEventArgs e)
        {
            PL.FRM_CATEGORIES frm = new PL.FRM_CATEGORIES();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            PL.BackUp.FRM_RESTORE frm = new PL.BackUp.FRM_RESTORE();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            PL.BackUp.FrmBckupTime frm = new PL.BackUp.FrmBckupTime();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            PL.Users.Frm_Users  frm = new PL.Users.Frm_Users();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            PL.Suppliers.Frm_Suppliers  frm = new PL.Suppliers.Frm_Suppliers();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            PL.PruChaseOrder.Frn_PruChaseOrder frm = new PL.PruChaseOrder.Frn_PruChaseOrder();
            try
            {
                frm.PurOrder_Id.Text = ClsPru.PruChaseOrderMaxId().Rows[0][0].ToString();
                frm.BtnNew.Enabled = false;
                frm.BtnAdd.Enabled = true;
                frm.PurOrder_Desc.Focus();
                frm.PurOrder_Desc.Text = "فاتورة مشتريات رقم : " + frm.PurOrder_Id.Text;
                frm.PurSup_ID.Text = "1";
                frm.Sup_Name.Text = "بدون مورد";
            }
            catch
            {
                return;
            }

            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            PL.PruChaseOrder.Frm_PruChaseManger frm = new PL.PruChaseOrder.Frm_PruChaseManger();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            PL.Items.Frm_AddItems frm = new PL.Items.Frm_AddItems();
            try
            {
                frm.TxtItemId.Text = ClsItem.MaxItemId().Rows[0][0].ToString();
                frm.BtnAdd.Enabled = true;
                frm.BtnNew.Enabled = false;
            }
            catch
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            PL.Items.Frm_Items frm = new PL.Items.Frm_Items();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
            PL.Store.Frm_Stores frm = new PL.Store.Frm_Stores();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonStore_ItemClick(object sender, ItemClickEventArgs e)
        {
             PL.Stock.Frm_AddStock frm = new PL.Stock.Frm_AddStock();
            frm.MdiParent = this;
            try
            {
                frm.TxtSoreId.Text = ClsStore.UsersMaxId().Rows[0][0].ToString();
                
            }
            catch
            {
                return;
            }
            frm.Show();
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            PL.Customers.FrmCustomers frm = new PL.Customers.FrmCustomers();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
        {
            PL.Suppliers.Frm_AddSpplier frm = new PL.Suppliers.Frm_AddSpplier();
            try
            {
               frm.TxtSuppId.Text = ClsCat.SuppliersMaxId().Rows[0][0].ToString();
               frm.BtnNew.Enabled = false;
               frm. BtnAdd.Enabled = true;
            }
            catch
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e)
        {
            PL.Customers.FrmAddCustomers frm = new PL.Customers.FrmAddCustomers();
            try
            {
                frm.TxtCusId.Text = ClsCust.GetMaxCustomers().Rows[0][0].ToString();
                frm.BtnNew.Enabled = false;
                frm.BtnAdd.Enabled = true;
            }
            catch
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem24_ItemClick(object sender, ItemClickEventArgs e)
        {
            PL.Sales.FrmSales frm = new PL.Sales.FrmSales();
            try
            {
                frm.SalesOrder_Id.Text = ClsSales.SalesOrderMaxId().Rows[0][0].ToString();
                frm.VoucherCode.Text = ClsRV.GetMaxVoucher().Rows[0][0].ToString();
                frm.BtnNew.Enabled = false;
                frm.BtnAdd.Enabled = true;
                frm.SalesOrder_Desc.Text = "فاتورة مبيعات رقم : " + frm.SalesOrder_Id.Text;
                frm.Cust_ID.Text = "1";
                frm.Cust_Name.Text = "بدون عميل";
                frm.TxtBarCode.Focus();
            }
            catch
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem25_ItemClick(object sender, ItemClickEventArgs e)
        {
            PL.Sales.Frm_SalesManger frm = new PL.Sales.Frm_SalesManger();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
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
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem26_ItemClick(object sender, ItemClickEventArgs e)
        {
            PL.Return.FrmSalesReturnManger frm = new PL.Return.FrmSalesReturnManger();
            frm.MdiParent = this;
            frm.Show();
        }

        private void SalesI_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            PL.Sales.FrmSales frm = new PL.Sales.FrmSales();
            try
            {
                frm.SalesOrder_Id.Text = ClsSales.SalesOrderMaxId().Rows[0][0].ToString();
                frm.BtnNew.Enabled = false;
                frm.BtnAdd.Enabled = true;
                frm.SalesOrder_Desc.Text = "فاتورة مبيعات رقم : " + frm.SalesOrder_Id.Text;
                frm.Cust_ID.Text = "1";
                frm.Cust_Name.Text = "بدون عميل";
                frm.TxtBarCode.Focus();
            }
            catch
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void ReturnSales_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
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
            frm.MdiParent = this;
            frm.Show();
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            PL.PruChaseOrder.Frn_PruChaseOrder frm = new PL.PruChaseOrder.Frn_PruChaseOrder();
            try
            {
                frm.PurOrder_Id.Text = ClsPru.PruChaseOrderMaxId().Rows[0][0].ToString();
                frm.BtnNew.Enabled = false;
                frm.BtnAdd.Enabled = true;
                frm.PurOrder_Desc.Focus();
                frm.PurOrder_Desc.Text = "فاتورة مشتريات رقم : " + frm.PurOrder_Id.Text;
                frm.PurSup_ID.Text = "1";
                frm.Sup_Name.Text = "بدون مورد";
            }
            catch
            {
                return;
            }

            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem29_ItemClick(object sender, ItemClickEventArgs e)
        {
            PL.Sandat.FrmReceiptVoucher frm = new PL.Sandat.FrmReceiptVoucher();
            try
            {
                frm.VoucherCode.Text = ClsRV.GetMaxVoucher().Rows[0][0].ToString();
                frm.BtnSave.Enabled = true;
                frm.BtnNew.Enabled = false;
            }
            catch
            {
                return;
            }

            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem30_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            PL.Sandat.FrmFinancialSupportManager frm = new PL.Sandat.FrmFinancialSupportManager();
                     
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem31_ItemClick(object sender, ItemClickEventArgs e)
        {
            PL.Sandat.FrmFinancialSupport frm = new PL.Sandat.FrmFinancialSupport();
            try
            {
                frm.VoucherCode.Text = Clsfs.GetAllFinancialSupportaMax().Rows[0][0].ToString();
                frm.BtnSave.Enabled = true;
                frm.BtnNew.Enabled = false;
            }
            catch
            {
                return;
            }

            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem32_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            PL.Sandat.FrmReceiptVoucherManger frm = new PL.Sandat.FrmReceiptVoucherManger();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem27_ItemClick(object sender, ItemClickEventArgs e)
        {
            PL.RetuenPruChase.FrmPurReturn frm = new PL.RetuenPruChase.FrmPurReturn();
            try
            {
                frm.txtId.Text = ClsRetb.PurReturnItemsMaxId().Rows[0][0].ToString();
                frm.BtnNew.Enabled = false;
                frm.BtnAdd.Enabled = true;
            }
            catch
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem28_ItemClick(object sender, ItemClickEventArgs e)
        {
            PL.RetuenPruChase.FrmPurReturnManger frm = new PL.RetuenPruChase.FrmPurReturnManger();            
            frm.MdiParent = this;
            frm.Show();
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            PL.RetuenPruChase.FrmPurReturn frm = new PL.RetuenPruChase.FrmPurReturn();
            try
            {
                frm.txtId.Text = ClsRetb.PurReturnItemsMaxId().Rows[0][0].ToString();
                frm.BtnNew.Enabled = false;
                frm.BtnAdd.Enabled = true;
            }
            catch
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        public void sumTotalSales()
        {
            try
            {
                LabSalesTotal.Caption = ClsMain.GetSum_SalessOrderDetails().Rows[0][0].ToString()+"جنيهاً";
            
            }
            catch
            {
                return;
            }
        }
        public void sumTotalPosSales()
        {
            try
            {
                barStaticItem6.Caption = ClsPos.GetSum_Pos_Today().Rows[0][0].ToString() + "جنيهاً";

            }
            catch
            {
                return;
            }
        }
        public void GetSum_PruchaseOrder()
        {
            try
            {
                TotalPur.Caption = ClsMain.GetSum_PruchaseOrder().Rows[0][0].ToString() + "جنيهاً";

            }
            catch
            {
                return;
            }
        }
        public void Sum_SalesOrderDetails_Today()
        {
            try
            {
                TodaySales.Caption = ClsMain.GetSum_SalesOrderDetails_Today().Rows[0][0].ToString() + "جنيهاً";

            }
            catch
            {
                return;
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Sum_SalesOrderDetails_Today();
            sumTotalSales();
            sumTotalPosSales();
            GetSum_PruchaseOrder();
            UserName.Caption = Program.UserName;
            UserType.Caption = Program.UserType;
        }

        private void barButtonItem33_ItemClick(object sender, ItemClickEventArgs e)
        {
            PL.Sales.FrmSalesTraffic frm = new PL.Sales.FrmSalesTraffic();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem34_ItemClick(object sender, ItemClickEventArgs e)
        {
            PL.PruChaseOrder.FrmPurTraficc frm = new PL.PruChaseOrder.FrmPurTraficc();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            PL.BackUp.FRM_BACKUP frm = new PL.BackUp.FRM_BACKUP();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem39_ItemClick(object sender, ItemClickEventArgs e)
        {
            PL.Users.FrmPermissions frm = new PL.Users.FrmPermissions();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem38_ItemClick(object sender, ItemClickEventArgs e)
        {
            PL.IncInfo.FrmInc frm = new PL.IncInfo.FrmInc();
            frm.MdiParent = this;
            frm.Show();
        }
        
        private void barButtonItem37_ItemClick(object sender, ItemClickEventArgs e)
        {
            PL.Pos.Frm_pos frm = new PL.Pos.Frm_pos();
            try
            {
               frm.PosOrderId.Text = ClsPos.PosOrderMaxId().Rows[0][0].ToString();
               frm.BtnNew.Enabled = false;
              frm.BtnAdd.Enabled = true;
              //frm.TxtBarCode.Focus();

            }
            catch
            {
                return;
            }
            //frm.MdiParent = this;
            frm.ShowDialog();
        }

        private void barButtonItem40_ItemClick(object sender, ItemClickEventArgs e)
        {
            PL.IncInfo.PrintPos frm = new PL.IncInfo.PrintPos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem9_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            PL.AboutSystem.About frm = new PL.AboutSystem.About();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem35_ItemClick(object sender, ItemClickEventArgs e)
        {
            PL.AboutSystem.FrmInviteFrind frm = new PL.AboutSystem.FrmInviteFrind();
            frm.ShowDialog();
            //PL.AboutSystem.form1 frm = new PL.AboutSystem.About();
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                PL.Users.Frm_Login frm = new PL.Users.Frm_Login();
                frm.MdiParent = this;
                frm.Show();
            }

            if (e.KeyCode == Keys.F2)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.F3)
            {
                PL.AboutSystem.About frm = new PL.AboutSystem.About();
                frm.MdiParent = this;
                frm.Show();
            }
            if (e.KeyCode == Keys.F5)
            {
                PL.AboutSystem.frmGetShot frm = new PL.AboutSystem.frmGetShot();
                frm.pictureBox1.Image = frm.GetShot();
                frm.ShowDialog();
            }
        }
      
        private void barButtonItem36_ItemClick(object sender, ItemClickEventArgs e)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.Image = Image.FromFile(Properties.Settings.Default.Info);
            popup.TitleText = "واى إن للبرمجيات";
            popup.ContentText = "شكرا لاختيارك برمجيات واى إن ... سيتم تنبيهك اذا تم إصدار تحديثات للنظام";
            popup.Popup();

            PL.AboutSystem.FRMUpate frm = new PL.AboutSystem.FRMUpate();
            frm.ShowDialog();
        }

        private void FrmMain_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void FrmMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                PL.Users.Frm_Login frm = new PL.Users.Frm_Login();
                frm.MdiParent = this;
                frm.Show();
            }

            if (e.KeyCode == Keys.F2)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.F3)
            {
                PL.AboutSystem.About frm = new PL.AboutSystem.About();
                frm.MdiParent = this;
                frm.Show();
            }
            if (e.KeyCode == Keys.F5)
            {
                PL.AboutSystem.frmGetShot frm = new PL.AboutSystem.frmGetShot();
                frm.pictureBox1.Image = frm.GetShot();
                frm.ShowDialog();
            }
        }

        private void حذفالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void حذفهذاالسطرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.AboutSystem.frmGetShot frm = new PL.AboutSystem.frmGetShot();
            frm.pictureBox1.Image = frm.GetShot();
            frm.ShowDialog();
        }

        private void barButtonItem41_ItemClick(object sender, ItemClickEventArgs e)
        {
            PL.AboutSystem.FrmSendEmail frm = new PL.AboutSystem.FrmSendEmail();
            frm.ShowDialog();
        }

        private void barButtonItem42_ItemClick(object sender, ItemClickEventArgs e)
        {
            PL.Pos.FrmPosTraffic frm = new PL.Pos.FrmPosTraffic();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            PL.Items.Frm_Items frm = new PL.Items.Frm_Items();
            frm.MdiParent = this;
            frm.Text = "الاصناف والتقارير";
            frm.Show();
        }

        private void barCheckItem1_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            pnlSkins.Visible = (pnlSkins.Visible) ? false : true;
            pnlSkins.Size = new Size(390, 250);
            galleryControl1.Size = new Size(375, 235);
            galleryControl1.Visible = true;
            pnlSkins.Location = new Point(ribbon.Location.X+200,navBarControl1.Top);
        }



        const int WM_PARENTNOTIFY = 0x210;
        const int WM_LBUTTONDOWN = 0x201;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_LBUTTONDOWN || (m.Msg == WM_PARENTNOTIFY && (int)m.WParam == WM_LBUTTONDOWN))
            if (!pnlSkins.ClientRectangle.Contains(pnlSkins.PointToClient(Cursor.Position)))
            {
                barCheckItem1.Checked = false;
                pnlSkins.Hide();
            }
                    
            base.WndProc(ref m);
        }

        // for testing     
        private void btnTest_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form1 frm = new Form1();
            Helpers.CheckFormActive(frm, this);
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void navBarWebsite_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            System.Diagnostics.Process.Start("http://smartmedia-kw.com");
        }

        private void navBarPhone_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            pnlPhone.Left = navBarControl1.Location.X - navBarPhone.NavBar.Width;
            pnlPhone.Top = navBarControl1.Location.Y + navBarPhone.NavBar.Top;
            pnlPhone.Visible = !pnlPhone.Visible;
        }

        private void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            new Users.Frm_Exit().ShowDialog();
        }

        private void btnLock_ItemClick(object sender, ItemClickEventArgs e)
        {
            new PL.Users.frmLock().ShowDialog();
        }
    }
}

    
