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
using Tulpep.NotificationWindow;
using Microsoft.Win32;
using System.IO;
using SuperMarket.Classes;
using DevExpress.XtraBars.Ribbon;
using SuperMarket.PL.Main;

namespace SuperMarket.PL.Users
{
    public partial class Frm_Login : DevExpress.XtraEditors.XtraForm
    {

        Classes.ClsUsers ClsUsers = new Classes.ClsUsers();
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            try
            {
                TxtUserName.Text = Helpers.user;
                TxtUserPass.Text = Helpers.pass;
            }
            catch { return; }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtUserPass.Focus();
            }
        }

        private void TxtUserPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin_Click(sender, e);
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtUserName.Text == string.Empty || TxtUserPass.Text == string.Empty) return;
            DataTable Dt = ClsUsers.LOGIN(TxtUserName.Text, TxtUserPass.Text);
            if (Dt.Rows.Count > 0)
            {
                this.Close();
                Dt.Dispose();
                //---------------- Pages
                FrmMain.getMainForm.Page2.Visible = true;
                FrmMain.getMainForm.Page3.Visible = true;
                FrmMain.getMainForm.Page4.Visible = true;
                FrmMain.getMainForm.Page5.Visible = true;
                FrmMain.getMainForm.Page6.Visible = true;
                ////-----------------TabsRibbon
                FrmMain.getMainForm.RibbonBasic.Enabled = (bool)Dt.Rows[0]["RibbonBasic"];
                FrmMain.getMainForm.RibbonPurchaes.Enabled = (bool)Dt.Rows[0]["RibbonPurchaes"];
                FrmMain.getMainForm.RibbonSales.Enabled = (bool)Dt.Rows[0]["RibbonSales"];
                FrmMain.getMainForm.RibbonPurchaseReturn.Enabled = (bool)Dt.Rows[0]["RibbonPurchaseReturn"];
                FrmMain.getMainForm.RibbonSalesReturn.Enabled = (bool)Dt.Rows[0]["RibbonSalesReturn"];
                FrmMain.getMainForm.RibbonActions.Enabled = (bool)Dt.Rows[0]["RibbonActions"];
                FrmMain.getMainForm.RibbonCustomers.Enabled = (bool)Dt.Rows[0]["RibbonCustomers"];
                FrmMain.getMainForm.RibbonSuppliers.Enabled = (bool)Dt.Rows[0]["RibbonSuppliers"];
                FrmMain.getMainForm.RibbonStoresCategories.Enabled = (bool)Dt.Rows[0]["RibbonStoresCategories"];
                FrmMain.getMainForm.RibbonItems.Enabled = (bool)Dt.Rows[0]["RibbonItems"];
                FrmMain.getMainForm.RibbonBarcode.Enabled = (bool)Dt.Rows[0]["RibbonBarcode"];
                FrmMain.getMainForm.RibbonReceiptVoucher.Enabled = (bool)Dt.Rows[0]["RibbonReceiptVoucher"];
                FrmMain.getMainForm.RibbonPaymentVoucher.Enabled = (bool)Dt.Rows[0]["RibbonPaymentVoucher"];
                FrmMain.getMainForm.RibbonUsersManage.Enabled = (bool)Dt.Rows[0]["RibbonUsersManage"];
                FrmMain.getMainForm.RibbonDatabase.Enabled = (bool)Dt.Rows[0]["RibbonDatabase"];
                ////----------------ButtomsMain
                FrmMain.getMainForm.btnCompany.Enabled = (bool)Dt.Rows[0]["btnCompany"];
                FrmMain.getMainForm.btnPOSSettings.Enabled = (bool)Dt.Rows[0]["btnPOSSettings"];
                //// =-=-=-= =-=-=-= =-=-=-= المبيعات والمشتريات =-=-=-= =-=-=-= =-=-=-= ////
                FrmMain.getMainForm.btnPurchaseOrder.Enabled = (bool)Dt.Rows[0]["btnPurchaseOrder"];
                FrmMain.getMainForm.btnPurchaseManage.Enabled = (bool)Dt.Rows[0]["btnPurchaseManage"];
                FrmMain.getMainForm.btnAddStore.Enabled = (bool)Dt.Rows[0]["btnAddStore"];
                FrmMain.getMainForm.btnCategories.Enabled = (bool)Dt.Rows[0]["btnCategories"];
                FrmMain.getMainForm.btnSales.Enabled = (bool)Dt.Rows[0]["btnSales"];
                FrmMain.getMainForm.btnSalesManage.Enabled = (bool)Dt.Rows[0]["btnSalesManage"];
                FrmMain.getMainForm.btnSalesReturn.Enabled = (bool)Dt.Rows[0]["btnSalesReturn"];
                FrmMain.getMainForm.btnSalesReturnManage.Enabled = (bool)Dt.Rows[0]["btnSalesReturnManage"];
                FrmMain.getMainForm.btnPurchaseReturn.Enabled = (bool)Dt.Rows[0]["btnPurchaseReturn"];
                FrmMain.getMainForm.btnPurchaseReturnManage.Enabled = (bool)Dt.Rows[0]["btnPurchaseReturnManage"];
                FrmMain.getMainForm.btnSalesAction.Enabled = (bool)Dt.Rows[0]["btnSalesAction"];
                FrmMain.getMainForm.btnPurchaseAction.Enabled = (bool)Dt.Rows[0]["btnPurchaseAction"];
                /////// =-=-=-= =-=-=-= =-=-=-= العملاء و الموردين =-=-=-= =-=-=-= =-=-=-= ////
                FrmMain.getMainForm.btnCustomers.Enabled = (bool)Dt.Rows[0]["btnCustomers"];
                FrmMain.getMainForm.btnAddCustomer.Enabled = (bool)Dt.Rows[0]["btnAddCustomer"];
                FrmMain.getMainForm.btnSuppliers.Enabled = (bool)Dt.Rows[0]["btnSuppliers"];
                FrmMain.getMainForm.btnAddSupplier.Enabled = (bool)Dt.Rows[0]["btnAddSupplier"];
                /////// =-=-=-= =-=-=-= =-=-=-= العملاء و الموردين =-=-=-= =-=-=-= =-=-=-= ////
                FrmMain.getMainForm.btnStores.Enabled = (bool)Dt.Rows[0]["btnStores"];
                FrmMain.getMainForm.btnAddItem.Enabled = (bool)Dt.Rows[0]["btnAddItem"];
                FrmMain.getMainForm.btnItems.Enabled = (bool)Dt.Rows[0]["btnItems"];
                FrmMain.getMainForm.btnItemsReports.Enabled = (bool)Dt.Rows[0]["btnItemsReports"];
                FrmMain.getMainForm.btnReceiptVoucher.Enabled = (bool)Dt.Rows[0]["btnReceiptVoucher"];
                FrmMain.getMainForm.btnPaymentVoucherManage.Enabled = (bool)Dt.Rows[0]["btnPaymentVoucherManage"];
                FrmMain.getMainForm.btnPaymentVoucher.Enabled = (bool)Dt.Rows[0]["btnPaymentVoucher"];
                FrmMain.getMainForm.btnReceiptVoucherManage.Enabled = (bool)Dt.Rows[0]["btnReceiptVoucherManage"];
                FrmMain.getMainForm.btnPOS.Enabled = (bool)Dt.Rows[0]["btnPOS"];
                FrmMain.getMainForm.btnPOSAction.Enabled = (bool)Dt.Rows[0]["btnPOSAction"];
                /////// =-=-=-= =-=-=-= =-=-=-= إعدادات النظام =-=-=-= =-=-=-= =-=-=-= ////
                FrmMain.getMainForm.btnUsers.Enabled = (bool)Dt.Rows[0]["btnUsers"];
                FrmMain.getMainForm.btnBackup.Enabled = (bool)Dt.Rows[0]["btnBackup"];
                FrmMain.getMainForm.btnRestore.Enabled = (bool)Dt.Rows[0]["btnRestore"];
                FrmMain.getMainForm.btnAutoBackup.Enabled = (bool)Dt.Rows[0]["btnAutoBackup"];
                FrmMain.getMainForm.btnPermissions.Enabled = (bool)Dt.Rows[0]["btnPermissions"];
                ////--------------------navBar
                FrmMain.getMainForm.navBarControl1.Enabled = true;
                ////------------- footer statusBar
                FrmMain.getMainForm.ribbonStatusBar.Enabled = true;

                //FrmMain.getMainForm.barButtonItem7.Enabled = (bool)Dt.Rows[0]["M41"];
                //FrmMain.getMainForm.barButtonItem8.Enabled = (bool)Dt.Rows[0]["M42"];
            }
            else
            {
                MessageBox.Show("بيانات المستخدم غير صحيحة !!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FrmMain.getMainForm.UserName.Caption = Program.UserName = Dt.Rows[0]["UserFullName"].ToString();
            FrmMain.getMainForm.UserType.Caption = Program.UserType = Dt.Rows[0]["UserType"].ToString();

            PopupNotifier popup = new PopupNotifier();
            //Path.GetDirectoryName(Application.ExecutablePath);
            //Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            //popup.Image = Image.FromFile(Properties.Settings.Default.Info);
            try
            {
                popup.Image = Image.FromFile(@"\\info.png");
            }
            catch { }
            popup.TitleText = "النظام";
            popup.ContentText = " شكرا لاختيارك برمجيات ... مرحبا بك " + Program.UserName;
            popup.Popup();

            object key = Registry.GetValue(@"HKEY_CURRENT_USER\Software\WINREGISTRY", Program.UserName, null);
            if (key != null) DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = key.ToString();

            FrmMain.getMainForm.barBtnUserLogin.Enabled = false;
            FrmMain.getMainForm.btnUserSwitch.Enabled = true;




      #region

            //if (Dt.Rows[0]["UserType"].ToString() == "مدير النظام")
            //{
            //    //---------------- Pages
            //    //PL.Main.FrmMain.getMainForm.Page2.Visible = true;
            //    //PL.Main.FrmMain.getMainForm.Page3.Visible = true;
            //    //PL.Main.FrmMain.getMainForm.Page4.Visible = true;
            //    //PL.Main.FrmMain.getMainForm.Page5.Visible = true;
            //    //PL.Main.FrmMain.getMainForm.Page6.Visible = true;
            //    ////-----------------TabsRibbon
            //    //PL.Main.FrmMain.getMainForm.Ribbon1.Visible = true;
            //    //PL.Main.FrmMain.getMainForm.Ribbon2.Visible = true;
            //    //PL.Main.FrmMain.getMainForm.Ribbon3.Visible = true;
            //    //PL.Main.FrmMain.getMainForm.Ribbon4.Visible = true;
            //    //PL.Main.FrmMain.getMainForm.Ribbon5.Visible = true;
            //    //PL.Main.FrmMain.getMainForm.Ribbon6.Visible = true;
            //    //PL.Main.FrmMain.getMainForm.Ribbon7.Visible = true;
            //    //PL.Main.FrmMain.getMainForm.Ribbon8.Visible = true;
            //    //PL.Main.FrmMain.getMainForm.Ribbon9.Visible = true;
            //    //PL.Main.FrmMain.getMainForm.Ribbon10.Visible = true;
            //    //PL.Main.FrmMain.getMainForm.Ribbon11.Visible = true;
            //    //PL.Main.FrmMain.getMainForm.Ribbon12.Visible = true;
            //    //PL.Main.FrmMain.getMainForm.Ribbon13.Visible = true;
            //    //PL.Main.FrmMain.getMainForm.Ribbon14.Visible = true;
            //    //PL.Main.FrmMain.getMainForm.Ribbon15.Visible = true;
            //    ////----------------ButtomsMain
            //    //PL.Main.FrmMain.getMainForm.barButtonItem17.Enabled = true;
            //    //PL.Main.FrmMain.getMainForm.barButtonItem20.Enabled = true;
            //    //PL.Main.FrmMain.getMainForm.barButtonStore.Enabled = true;
            //    //PL.Main.FrmMain.getMainForm.barBCate.Enabled = true;
            //    //PL.Main.FrmMain.getMainForm.barButtonItem24.Enabled = true;
            //    //PL.Main.FrmMain.getMainForm.barButtonItem25.Enabled = true;
            //    //PL.Main.FrmMain.getMainForm.barButtonItem5.Enabled = true;
            //    //PL.Main.FrmMain.getMainForm.barButtonItem26.Enabled = true;
            //    //PL.Main.FrmMain.getMainForm.barButtonItem27.Enabled = true;
            //    //PL.Main.FrmMain.getMainForm.barButtonItem28.Enabled = true;
            //    //PL.Main.FrmMain.getMainForm.barButtonItem33.Enabled = true;
            //    //PL.Main.FrmMain.getMainForm.barButtonItem34.Enabled = true;
            //    //PL.Main.FrmMain.getMainForm.barButtonItem15.Enabled = true;
            //    //PL.Main.FrmMain.getMainForm.barButtonItem23.Enabled = true;
            //    //PL.Main.FrmMain.getMainForm.barButtonItem16.Enabled = true;
            //    //PL.Main.FrmMain.getMainForm.barButtonItem22.Enabled = true;
            //    //PL.Main.FrmMain.getMainForm.barButtonItem21.Enabled = true;
            //    //PL.Main.FrmMain.getMainForm.barButtonItem3.Enabled = true;
            //    //PL.Main.FrmMain.getMainForm.barButtonItem4.Enabled = true;
            //    //PL.Main.FrmMain.getMainForm.barButtonItem6.Enabled = true;
            //    //PL.Main.FrmMain.getMainForm.barButtonItem7.Enabled = true;
            //    //PL.Main.FrmMain.getMainForm.barButtonItem8.Enabled = true;
            //    //PL.Main.FrmMain.getMainForm.barButtonItem29.Enabled = true;
            //    //PL.Main.FrmMain.getMainForm.barButtonItem30.Enabled = true;
            //    //PL.Main.FrmMain.getMainForm.barButtonItem31.Enabled = true;
            //    //PL.Main.FrmMain.getMainForm.barButtonItem32.Enabled = true;
            //    //PL.Main.FrmMain.getMainForm.barButtonItem14.Enabled = true;
            //    //PL.Main.FrmMain.getMainForm.barButtonItem11.Enabled = true;
            //    //PL.Main.FrmMain.getMainForm.barButtonItem12.Enabled = true;
            //    //PL.Main.FrmMain.getMainForm.barButtonItem13.Enabled = true;
            //    //PL.Main.FrmMain.getMainForm.barButtonItem37.Enabled = true;
            //    //PL.Main.FrmMain.getMainForm.barButtonItem38.Enabled = true;
            //    //PL.Main.FrmMain.getMainForm.barButtonItem39.Enabled = true;
            //    //PL.Main.FrmMain.getMainForm.barButtonItem40.Enabled = true;
            //    //PL.Main.FrmMain.getMainForm.barButtonItem42.Enabled = true;

            //    ////--------------------navBar
            //    //PL.Main.FrmMain.getMainForm.navBarControl1.Visible = true;

            //    ////------------- footer statusBar
            //    //PL.Main.FrmMain.getMainForm.ribbonStatusBar.Visible = true ;

            //    //Program.UserName = Dt.Rows[0]["UserFullName"].ToString();
            //    //Program.UserType = Dt.Rows[0]["UserType"].ToString();

            //    //PopupNotifier popup = new PopupNotifier();
            //    //popup.Image = Image.FromFile(Properties.Settings.Default.Info);
            //    //popup.TitleText = "";
            //    //popup.ContentText = " شكرا لاختيارك برمجيات واى إن ... مرحبا بك " + Program.UserName;
            //    //popup.Popup();

            //    //object key = Registry.GetValue(@"HKEY_CURRENT_USER\Software\WINREGISTRY", Program.UserName, null);
            //    //if (key != null) DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = key.ToString();

            //    //this.Close();
            //}
            //else if (Dt.Rows[0]["UserType"].ToString() == "مشرف")
            //{
            //    //---------------- Pages
            //    PL.Main.FrmMain.getMainForm.Page2.Visible = true;
            //    PL.Main.FrmMain.getMainForm.Page3.Visible = false;
            //    PL.Main.FrmMain.getMainForm.Page4.Visible = true;
            //    PL.Main.FrmMain.getMainForm.Page5.Visible = false;
            //    PL.Main.FrmMain.getMainForm.Page6.Visible = false;
            //    //-----------------TabsRibbon
            //    PL.Main.FrmMain.getMainForm.RibbonPurchaes.Visible = true;
            //    PL.Main.FrmMain.getMainForm.RibbonSales.Visible = true;
            //    PL.Main.FrmMain.getMainForm.RibbonSalesReturn.Visible = true;
            //    PL.Main.FrmMain.getMainForm.RibbonPurchaseReturn.Visible = true;
            //    PL.Main.FrmMain.getMainForm.RibbonActions.Visible = true;
            //    PL.Main.FrmMain.getMainForm.RibbonCustomers.Visible = false;
            //    PL.Main.FrmMain.getMainForm.RibbonSuppliers.Visible = false;
            //    PL.Main.FrmMain.getMainForm.RibbonStoresCategories.Visible = true;
            //    PL.Main.FrmMain.getMainForm.RibbonItems.Visible = true;
            //    PL.Main.FrmMain.getMainForm.RibbonBarcode.Visible = true;
            //    PL.Main.FrmMain.getMainForm.RibbonReceiptVoucher.Visible = false;
            //    PL.Main.FrmMain.getMainForm.RibbonPaymentVoucher.Visible = false;
            //    PL.Main.FrmMain.getMainForm.RibbonUsersManage.Visible = false;
            //    PL.Main.FrmMain.getMainForm.RibbonDatabase.Visible = false;
            //    PL.Main.FrmMain.getMainForm.RibbonBasic.Visible = false;
            //    //----------------ButtomsMain
            //    PL.Main.FrmMain.getMainForm.btnPurchaseOrder.Enabled = true;
            //    PL.Main.FrmMain.getMainForm.btnPurchaseManage.Enabled = true;
            //    PL.Main.FrmMain.getMainForm.btnAddStore.Enabled = true;
            //    PL.Main.FrmMain.getMainForm.btnCategories.Enabled = true;
            //    PL.Main.FrmMain.getMainForm.btnSales.Enabled = true;
            //    PL.Main.FrmMain.getMainForm.btnSalesManage.Enabled = true;
            //    PL.Main.FrmMain.getMainForm.btnSalesReturn.Enabled = true;
            //    PL.Main.FrmMain.getMainForm.btnSalesReturnManage.Enabled = true;
            //    PL.Main.FrmMain.getMainForm.btnPurchaseReturn.Enabled = true;
            //    PL.Main.FrmMain.getMainForm.btnPurchaseReturnManage.Enabled = true;
            //    PL.Main.FrmMain.getMainForm.btnSalesAction.Enabled = true;
            //    PL.Main.FrmMain.getMainForm.btnPurchaseAction.Enabled = true;
            //    PL.Main.FrmMain.getMainForm.btnCustomers.Enabled = false;
            //    PL.Main.FrmMain.getMainForm.btnAddCustomer.Enabled = false;
            //    PL.Main.FrmMain.getMainForm.btnSuppliers.Enabled = false;
            //    PL.Main.FrmMain.getMainForm.btnAddSupplier.Enabled = false;
            //    PL.Main.FrmMain.getMainForm.btnStores.Enabled = true;
            //    PL.Main.FrmMain.getMainForm.btnAddItem.Enabled = true;
            //    PL.Main.FrmMain.getMainForm.btnItems.Enabled = true;
            //    PL.Main.FrmMain.getMainForm.btnItemsReports.Enabled = true;
            //    PL.Main.FrmMain.getMainForm.barButtonItem7.Enabled = true;
            //    PL.Main.FrmMain.getMainForm.barButtonItem8.Enabled = true;
            //    PL.Main.FrmMain.getMainForm.btnReceiptVoucher.Enabled = false;
            //    PL.Main.FrmMain.getMainForm.btnPaymentVoucherManage.Enabled = false;
            //    PL.Main.FrmMain.getMainForm.btnPaymentVoucher.Enabled = false;
            //    PL.Main.FrmMain.getMainForm.btnReceiptVoucherManage.Enabled = false;
            //    PL.Main.FrmMain.getMainForm.btnUsers.Enabled = false;
            //    PL.Main.FrmMain.getMainForm.btnBackup.Enabled = false;
            //    PL.Main.FrmMain.getMainForm.btnRestore.Enabled = false;
            //    PL.Main.FrmMain.getMainForm.btnAutoBackup.Enabled = false;
            //    PL.Main.FrmMain.getMainForm.btnPOS.Enabled = false;
            //    PL.Main.FrmMain.getMainForm.btnCompany.Enabled = false;
            //    PL.Main.FrmMain.getMainForm.btnPermissions.Enabled = false;
            //    PL.Main.FrmMain.getMainForm.btnPOSAction.Enabled = false;


            //    ////--------------------النافبار

            //    //PL.Main.FrmMain.getMainForm.navBarControl1.Visible = true;
            //    ////------------- الفوتر

            //    //PL.Main.FrmMain.getMainForm.ribbonStatusBar.Visible = true;

            //    //Program.UserName = Dt.Rows[0]["UserFullName"].ToString();
            //    //Program.UserType = Dt.Rows[0]["UserType"].ToString();

            //    //PopupNotifier popup = new PopupNotifier();
            //    //popup.Image = Image.FromFile(Properties.Settings.Default.Info);
            //    //popup.TitleText = "واى إن للبرمجيات";
            //    //popup.ContentText = " شكرا لاختيارك برمجيات واى إن ... مرحبا بك " + Program.UserName;
            //    //popup.Popup();

            //    //object key = Registry.GetValue(@"HKEY_CURRENT_USER\Software\WINREGISTRY", Program.UserName, null);
            //    //if (key != null) DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = key.ToString();

            //    //this.Close();
            //}
            //else if (Dt.Rows[0]["UserType"].ToString() == "كاشير")
            //{
            //    //---------------- Pages
            //    PL.Main.FrmMain.getMainForm.Page2.Visible = true;
            //    PL.Main.FrmMain.getMainForm.Page3.Visible = false;
            //    PL.Main.FrmMain.getMainForm.Page4.Visible = false;
            //    PL.Main.FrmMain.getMainForm.Page5.Visible = false;
            //    PL.Main.FrmMain.getMainForm.Page6.Visible = false;
            //    //-----------------TabsRibbon
            //    PL.Main.FrmMain.getMainForm.RibbonPurchaes.Visible = false;
            //    PL.Main.FrmMain.getMainForm.RibbonSales.Visible = true;
            //    PL.Main.FrmMain.getMainForm.RibbonSalesReturn.Visible = true;
            //    PL.Main.FrmMain.getMainForm.RibbonPurchaseReturn.Visible = false;
            //    PL.Main.FrmMain.getMainForm.RibbonActions.Visible = false;
            //    PL.Main.FrmMain.getMainForm.RibbonCustomers.Visible = false;
            //    PL.Main.FrmMain.getMainForm.RibbonSuppliers.Visible = false;
            //    PL.Main.FrmMain.getMainForm.RibbonStoresCategories.Visible = true;
            //    PL.Main.FrmMain.getMainForm.RibbonItems.Visible = true;
            //    PL.Main.FrmMain.getMainForm.RibbonBarcode.Visible = true;
            //    PL.Main.FrmMain.getMainForm.RibbonReceiptVoucher.Visible = false;
            //    PL.Main.FrmMain.getMainForm.RibbonPaymentVoucher.Visible = false;
            //    PL.Main.FrmMain.getMainForm.RibbonUsersManage.Visible = false;
            //    PL.Main.FrmMain.getMainForm.RibbonDatabase.Visible = false;
            //    PL.Main.FrmMain.getMainForm.RibbonBasic.Visible = false;
            //    //----------------ButtomsMain
            //    PL.Main.FrmMain.getMainForm.btnPurchaseOrder.Enabled = false;
            //    PL.Main.FrmMain.getMainForm.btnPurchaseManage.Enabled = false;
            //    PL.Main.FrmMain.getMainForm.btnAddStore.Enabled = true;
            //    PL.Main.FrmMain.getMainForm.btnCategories.Enabled = true;
            //    PL.Main.FrmMain.getMainForm.btnSales.Enabled = true;
            //    PL.Main.FrmMain.getMainForm.btnSalesManage.Enabled = false;
            //    PL.Main.FrmMain.getMainForm.btnSalesReturn.Enabled = true;
            //    PL.Main.FrmMain.getMainForm.btnSalesReturnManage.Enabled = true;
            //    PL.Main.FrmMain.getMainForm.btnPurchaseReturn.Enabled = true;
            //    PL.Main.FrmMain.getMainForm.btnPurchaseReturnManage.Enabled = true;
            //    PL.Main.FrmMain.getMainForm.btnSalesAction.Enabled = true;
            //    PL.Main.FrmMain.getMainForm.btnPurchaseAction.Enabled = true;
            //    PL.Main.FrmMain.getMainForm.btnCustomers.Enabled = false;
            //    PL.Main.FrmMain.getMainForm.btnAddCustomer.Enabled = false;
            //    PL.Main.FrmMain.getMainForm.btnSuppliers.Enabled = false;
            //    PL.Main.FrmMain.getMainForm.btnAddSupplier.Enabled = false;
            //    PL.Main.FrmMain.getMainForm.btnStores.Enabled = false;
            //    PL.Main.FrmMain.getMainForm.btnAddItem.Enabled = false;
            //    PL.Main.FrmMain.getMainForm.btnItems.Enabled = false;
            //    PL.Main.FrmMain.getMainForm.btnItemsReports.Enabled = false;
            //    PL.Main.FrmMain.getMainForm.barButtonItem7.Enabled = false;
            //    PL.Main.FrmMain.getMainForm.barButtonItem8.Enabled = false;
            //    PL.Main.FrmMain.getMainForm.btnReceiptVoucher.Enabled = false;
            //    PL.Main.FrmMain.getMainForm.btnPaymentVoucherManage.Enabled = false;
            //    PL.Main.FrmMain.getMainForm.btnPaymentVoucher.Enabled = false;
            //    PL.Main.FrmMain.getMainForm.btnReceiptVoucherManage.Enabled = false;
            //    PL.Main.FrmMain.getMainForm.btnUsers.Enabled = false;
            //    PL.Main.FrmMain.getMainForm.btnBackup.Enabled = false;
            //    PL.Main.FrmMain.getMainForm.btnRestore.Enabled = false;
            //    PL.Main.FrmMain.getMainForm.btnAutoBackup.Enabled = false;
            //    PL.Main.FrmMain.getMainForm.btnPOS.Enabled = false;
            //    PL.Main.FrmMain.getMainForm.btnCompany.Enabled = false;
            //    PL.Main.FrmMain.getMainForm.btnPermissions.Enabled = false;
            //    PL.Main.FrmMain.getMainForm.btnPOSAction.Enabled = false;

            //    ////--------------------النافبار

            //    //PL.Main.FrmMain.getMainForm.navBarControl1.Visible = true;
            //    ////------------- الفوتر

            //    //PL.Main.FrmMain.getMainForm.ribbonStatusBar.Visible = false;

            //    //Program.UserName = Dt.Rows[0]["UserFullName"].ToString();
            //    //Program.UserType = Dt.Rows[0]["UserType"].ToString();

            //    //PopupNotifier popup = new PopupNotifier();
            //    //popup.Image = Image.FromFile(Properties.Settings.Default.Info);
            //    //popup.TitleText = "واى إن للبرمجيات";
            //    //popup.IsRightToLeft = true;
            //    //popup.ContentText = " شكرا لاختيارك برمجيات واى إن ... مرحبا بك " + Program.UserName;
            //    //popup.Popup();

            //    //object key = Registry.GetValue(@"HKEY_CURRENT_USER\Software\WINREGISTRY", Program.UserName, null);
            //    //if (key != null) DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = key.ToString();

            //    //this.Close();
            //}
            #endregion

            #region Update code
            //if (Dt.Rows.Count > 0)
            //{
            //foreach (RibbonControl page in PL.Main.FrmMain.getMainForm.Ribbon.Pages)
            //{
            //    page.Visible = (bool)Dt.Rows[0][1];
            //}
            //    PL.Main.FrmMain.getMainForm.Page2.Visible = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.Page3.Visible = (bool)Dt.Rows[0]["M2"];
            //    PL.Main.FrmMain.getMainForm.Page4.Visible = (bool)Dt.Rows[0]["M3"];
            //    PL.Main.FrmMain.getMainForm.Page5.Visible = (bool)Dt.Rows[0]["M4"];
            //    PL.Main.FrmMain.getMainForm.Page6.Visible = (bool)Dt.Rows[0]["M5"];
            //    //-----------------TabsRibbon
            //    PL.Main.FrmMain.getMainForm.Ribbon1.Visible = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.Ribbon2.Visible = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.Ribbon3.Visible = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.Ribbon4.Visible = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.Ribbon5.Visible = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.Ribbon6.Visible = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.Ribbon7.Visible = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.Ribbon8.Visible = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.Ribbon9.Visible = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.Ribbon10.Visible = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.Ribbon11.Visible = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.Ribbon12.Visible = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.Ribbon13.Visible = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.Ribbon14.Visible = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.Ribbon15.Visible = (bool)Dt.Rows[0]["M1"];
            //    //----------------ButtomsMain
            //    PL.Main.FrmMain.getMainForm.barButtonItem17.Enabled = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.barButtonItem20.Enabled = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.barButtonStore.Enabled = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.barBCate.Enabled = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.barButtonItem24.Enabled = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.barButtonItem25.Enabled = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.barButtonItem5.Enabled = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.barButtonItem26.Enabled = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.barButtonItem27.Enabled = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.barButtonItem28.Enabled = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.barButtonItem33.Enabled = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.barButtonItem34.Enabled = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.barButtonItem15.Enabled = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.barButtonItem23.Enabled = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.barButtonItem16.Enabled = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.barButtonItem22.Enabled = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.barButtonItem21.Enabled = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.barButtonItem3.Enabled = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.barButtonItem4.Enabled = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.barButtonItem6.Enabled = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.barButtonItem7.Enabled = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.barButtonItem8.Enabled = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.barButtonItem29.Enabled = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.barButtonItem30.Enabled = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.barButtonItem31.Enabled = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.barButtonItem32.Enabled = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.barButtonItem14.Enabled = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.barButtonItem11.Enabled = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.barButtonItem12.Enabled = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.barButtonItem13.Enabled = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.barButtonItem37.Enabled = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.barButtonItem38.Enabled = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.barButtonItem39.Enabled = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.barButtonItem40.Enabled = (bool)Dt.Rows[0]["M1"];
            //    PL.Main.FrmMain.getMainForm.barButtonItem42.Enabled = (bool)Dt.Rows[0]["M1"];
            //}
            #endregion



        }

        private void checkRemember_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkRemember.Checked == true)
                {
                    Properties.Settings.Default.UserName = TxtUserName.Text;
                    Properties.Settings.Default.pass = TxtUserPass.Text;
                    Properties.Settings.Default.Save();
                }
            }
            catch{ return; }
        }


    }
}


