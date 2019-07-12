using System;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Text.RegularExpressions;
using SuperMarket.Properties;
using Microsoft.Win32;
using System.Management;
using System.IO;
using System.Net;
using System.Net.Mail;
using MetroFramework.Forms;
using System.Threading;

namespace SuperMarket.PL.License
{
    public partial class FrmLicense : DevExpress.XtraEditors.XtraForm
    {


        double Result, TResult;
        DateTime TrialTime, CalTime;
        RegistryKey Df = Registry.CurrentUser.OpenSubKey("SOFTWARE\\WhyInProtection", true);



        TextBox td = new TextBox();

        public FrmLicense()
        {
            InitializeComponent();
            try
            {

                TrialTime = DateTime.Now;
                CalTime = DateTime.Now.AddDays(30);
                if (!Settings.Default.IsChecked)
                {
                    RegistryKey Df = Registry.CurrentUser.CreateSubKey("SOFTWARE\\WhyInProtection");
                    Df = Registry.CurrentUser.OpenSubKey("SOFTWARE\\WhyInProtection", true);
                    Settings.Default.CalDate = CalTime;
                    Df.SetValue("Count", Classes.ClsEncryption.Encrypt(Settings.Default.CalDate.ToString()));
                    Settings.Default.Trial = TrialTime;
                    Settings.Default.IsChecked = true;
                    timer1.Enabled = true;
                    Settings.Default.Save();
                }
                else
                {
                    if (Settings.Default.Trial.Add(new TimeSpan(30, 0, 0, 0)) > DateTime.Now &&
                        DateTime.Now <= DateTime.Parse(Classes.ClsEncryption.Decrypt(Df.GetValue("Count").ToString())))

                    {
                        Settings.Default.IsTrial = true;
                        timer1.Enabled = true;
                        Settings.Default.Save();
                    }

                    else if (DateTime.Now >= DateTime.Parse(Df.GetValue("Count").ToString()))
                    {
                        MessageBox.Show("لقد تم تجاوز المدة التجريبية الممنوحة لك", "البرنامج", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        LabDays.Visible = false;
                        LabTrial1.Visible = false;
                        timer1.Enabled = false;
                        BuTrial.Enabled = false;
                        LabTrial.ForeColor = Color.Red;
                        LabTrial.Text = "لقد تم تجاوز المدة التجريبية الممنوحة لك";
                    }
                    else
                    {
                        MessageBox.Show("لقد تم تجاوز المدة التجريبية الممنوحة لك", "البرنامج", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        LabDays.Visible = false;
                        timer1.Enabled = false;
                        LabTrial1.Visible = false;
                        BuTrial.Enabled = false;
                        LabTrial.ForeColor = Color.Red;
                        LabTrial.Text = "لقد تم تجاوز المدة التجريبية الممنوحة لك";
                    }
                }
            }
            catch
            {

                return;
            }

        }

        void Calaculate()
        {
            if (TxSerial.Text != string.Empty && TxSerial1.Text != string.Empty &&
                TxSerial2.Text != string.Empty && TxSerial3.Text != string.Empty)
            {
                double tx = Convert.ToDouble(TxSerial.Text);
                double tx1 = Convert.ToDouble(TxSerial1.Text);
                double tx2 = Convert.ToDouble(TxSerial2.Text);
                double tx3 = Convert.ToDouble(TxSerial3.Text);
                Result = (tx + tx1) - (tx2 + tx3);
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

        private void BuLogin_Click(object sender, EventArgs e)
        {
            if (TxSerial.Text == string.Empty || TxSerial1.Text == string.Empty || TxSerial2.Text == string.Empty
                || TxSerial3.Text == string.Empty)
            {
                MessageBox.Show("عذرا اكتب السيريل أولا", "البرنامج", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Calaculate();

            if (Result == Convert.ToDouble(Classes.ClsEncryption.Decrypt(Settings.Default.KT.ToString())))
            {
                getUniqueID("C");
                td.Text = getUniqueID("C");

                if (td.Text != Classes.ClsEncryption.Decrypt(Settings.Default.GI))
                {
                    MessageBox.Show("غير مرخص لك إستخدام البرنامج", "البرنامج", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                else
                {
                    Settings.Default.M = TxSerial.Text;
                    Settings.Default.M1 = TxSerial1.Text;
                    Settings.Default.M2 = TxSerial2.Text;
                    Settings.Default.M3 = TxSerial3.Text;
                    MessageBox.Show("تم التسجيل بنجاح", "البرنامج", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Settings.Default.IsLicensed = true;
                    Settings.Default.Save();
                    PL.Main.FrmMain fm = new PL.Main.FrmMain();
                    this.Hide();
                    fm.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("رقم السيريل المدخل غير صحيح", "البرنامج", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TxSerial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void TxSerial_Validated(object sender, EventArgs e)
        {
            Regex r = new Regex("[0-9]{4}");
            Match m = r.Match(TxSerial.Text);
            if (TxSerial.Text != string.Empty)
            {
                if (!m.Success)
                {
                    //MessageBox.Show("الرجاء ادخال أربع مقاطع", "البرنامج", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxSerial.Focus();
                    return;
                }
            }

        }

        private void TxSerial1_Validated(object sender, EventArgs e)
        {
            Regex r = new Regex("[0-9]{4}");
            Match m = r.Match(TxSerial1.Text);
            if (TxSerial1.Text != string.Empty)
            {
                if (!m.Success)
                {
                    //MessageBox.Show("الرجاء ادخال أربع مقاطع", "البرنامج", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxSerial1.Focus();
                    return;
                }
            }

        }

        private void TxSerial2_Validated(object sender, EventArgs e)
        {
            Regex r = new Regex("[0-9]{4}");
            Match m = r.Match(TxSerial2.Text);
            if (TxSerial2.Text != string.Empty)
            {
                if (!m.Success)
                {
                    //MessageBox.Show("الرجاء ادخال أربع مقاطع", "البرنامج", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxSerial2.Focus();
                    return;
                }
            }

        }

        private void TxSerial3_Validated(object sender, EventArgs e)
        {
            Regex r = new Regex("[0-9]{4}");
            Match m = r.Match(TxSerial3.Text);
            if (TxSerial3.Text != string.Empty)
            {
                if (!m.Success)
                {
                    //MessageBox.Show("الرجاء ادخال أربع مقاطع", "البرنامج", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxSerial3.Focus();
                    return;
                }
            }

        }

        private void FLicense_Load(object sender, EventArgs e)
        {
            getUniqueID("C");
            td.Text = getUniqueID("C");
            if (Settings.Default.IsLicensed == true)
            {
                Setting_Calaculate();
                if (TResult == Convert.ToDouble(Classes.ClsEncryption.Decrypt(Settings.Default.KT.ToString())))
                {
                    if (td.Text != Classes.ClsEncryption.Decrypt(Settings.Default.GI))
                    {
                        Application.Exit();
                    }
                    timer1.Enabled = false;
                    PL.Main.FrmMain fm = new PL.Main.FrmMain();
                    this.Hide();
                    fm.ShowDialog();
                    Close();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                DateTime TotalTime = DateTime.Parse(Classes.ClsEncryption.Decrypt(Df.GetValue("Count").ToString()));
                TimeSpan Countdown = TotalTime - DateTime.Now;

                if (Countdown.TotalSeconds <= 0)
                {
                    timer1.Enabled = false;
                    LabDays.Visible = false;
                    LabTrial1.Visible = false;
                    BuTrial.Enabled = false;
                    LabTrial.ForeColor = Color.Red;
                    LabTrial.Text = "لقد تم تجاوز المدة التجريبية الممنوحة لك";
                }
                else
                {
                    LabDays.Text = Countdown.Days.ToString();
                }
            }
            catch
            {

                return;
            }

        }

        private void BuTrial_Click(object sender, EventArgs e)
        {
            if (Settings.Default.Trial.Add(new TimeSpan(30, 0, 0, 0)) > DateTime.Now)
            {
                Settings.Default.IsTrial = true;
                Settings.Default.Save();
                PL.Main.FrmMain fm = new PL.Main.FrmMain();
                this.Hide();
                fm.ShowDialog();
                this.Close();
            }
            else
            {
                timer1.Enabled = false;
                Application.Exit();
            }
        }

        private string getUniqueID(string drive)
        {
            if (drive == string.Empty)
            {
                foreach (DriveInfo compDrive in DriveInfo.GetDrives())
                {
                    if (compDrive.IsReady)
                    {
                        drive = compDrive.RootDirectory.ToString();
                        break;
                    }
                }
            }

            if (drive.EndsWith(":\\"))
            {
                drive = drive.Substring(0, drive.Length - 2);
            }

            string volumeSerial = getVolumeSerial(drive);
            string cpuID = getCPUID();

            return cpuID.Substring(13) + cpuID.Substring(1, 4) + volumeSerial + cpuID.Substring(4, 4);
        }



        private string getVolumeSerial(string drive)
        {
            ManagementObject disk = new ManagementObject(@"win32_logicaldisk.deviceid=""" + drive + @":""");
            disk.Get();

            string volumeSerial = disk["VolumeSerialNumber"].ToString();
            disk.Dispose();

            return volumeSerial;
        }

        private string getCPUID()
        {
            string cpuInfo = "";
            ManagementClass managClass = new ManagementClass("win32_processor");
            ManagementObjectCollection managCollec = managClass.GetInstances();

            foreach (ManagementObject managObj in managCollec)
            {
                if (cpuInfo == "")
                {
                    cpuInfo = managObj.Properties["processorID"].Value.ToString();
                    break;
                }
            }

            return cpuInfo;
        }
        //------------------------------------------------------------------------------------------+

        private string getUniqueIDC(string drive)
        {
            if (drive == string.Empty)
            {
                foreach (DriveInfo compDrive in DriveInfo.GetDrives())
                {
                    if (compDrive.IsReady)
                    {
                        drive = compDrive.RootDirectory.ToString();
                        break;
                    }
                }
            }

            if (drive.EndsWith(":\\"))
            {
                drive = drive.Substring(0, drive.Length - 2);
            }

            string volumeSerial = getVolumeSeriall(drive);
            string cpuID = getCPUIDD();

            return cpuID.Substring(13) + cpuID.Substring(1, 4) + volumeSerial + cpuID.Substring(4, 4);
        }



        private void FrmLicense_Load(object sender, EventArgs e)
        {

            

            // getUniqueIDC("C");
            TxGet.Text = getUniqueIDC("C");

            getUniqueID("C");
            td.Text = getUniqueID("C");
            if (Settings.Default.IsLicensed == true)
            {
                Setting_Calaculate();
                if (TResult == Convert.ToDouble(Classes.ClsEncryption.Decrypt(Settings.Default.KT.ToString())))
                {
                    if (td.Text != Classes.ClsEncryption.Decrypt(Settings.Default.GI))
                    {
                        Application.Exit();
                    }
                    timer1.Enabled = false;
                    PL.Main.FrmMain fm = new PL.Main.FrmMain();
                    this.Hide();
                    fm.ShowDialog();
                    Close();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            //To start:
            //progressBar1.Style = ProgressBarStyle.Marquee;
            //progressBar1.MarqueeAnimationSpeed = 20;

            //To stop:
            //progressBar1.Style = ProgressBarStyle.Continuous;
            //progressBar1.MarqueeAnimationSpeed = 0;
            try
            {
                string smtpAddress = "smtp.gmail.com";
                int portNumber = 587;
                bool enableSSL = true;

                string emailFrom = "hs.smartweb@gmail.com";
                string password = "eGypt@2ccd*44cc*851C;";
                string emailTo = "hs777it@gmail.com";
                string subject = Application.ProductName;
                string body = TxGet.Text;

                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(emailFrom);
                    mail.To.Add(emailTo);
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                    {
                        smtp.Credentials = new NetworkCredential(emailFrom, password);
                        smtp.EnableSsl = enableSSL;
                        smtp.Send(mail);
                        pictureBox1.Visible = true;
                        MessageBox.Show("تم الارسال");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("فشلت عملية الارسال");
                return;
            }
        }

        private void FrmLicense_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                PL.License.FrmRenew frm = new PL.License.FrmRenew();
                this.Hide();
                frm.ShowDialog();
                this.Close();

            }
        }

        private void BuTrial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                PL.License.FrmRenew frm = new PL.License.FrmRenew();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void BuLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                PL.License.FrmRenew frm = new PL.License.FrmRenew();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
        }


        private string getVolumeSeriall(string drive)
        {
            ManagementObject disk = new ManagementObject(@"win32_logicaldisk.deviceid=""" + drive + @":""");
            disk.Get();

            string volumeSerial = disk["VolumeSerialNumber"].ToString();
            disk.Dispose();

            return volumeSerial;
        }

        private string getCPUIDD()
        {
            string cpuInfo = "";
            ManagementClass managClass = new ManagementClass("win32_processor");
            ManagementObjectCollection managCollec = managClass.GetInstances();

            foreach (ManagementObject managObj in managCollec)
            {
                if (cpuInfo == "")
                {
                    cpuInfo = managObj.Properties["processorID"].Value.ToString();
                    break;
                }
            }

            return cpuInfo;
        }
    }
}
