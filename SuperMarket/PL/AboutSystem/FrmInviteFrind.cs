using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;
namespace SuperMarket.PL.AboutSystem
{
    public partial class FrmInviteFrind : Form
    {
        public FrmInviteFrind()
        {
            InitializeComponent();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {

            try
            {

                string smtpAddress = "smtp.gmail.com";
                int portNumber = 587;
                bool enableSSL = true;

                string emailFrom = "hs.smartweb@gmail.com";
                string password = "45846c*-c;";
                string emailTo = txtemail.Text;
                string subject = "واى إن للبرمجيات";
                string body = textEdit1.Text;

                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(emailFrom);
                    mail.To.Add(emailTo);
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = true;
                    // Can set to false, if you are sending pure text.

                    
                    //mail.Attachments.Add(new Attachment("C:\\SomeZip.zip"));

                    using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                    {
                        smtp.Credentials = new NetworkCredential(emailFrom, password);
                        smtp.EnableSsl = enableSSL;
                        smtp.Send(mail);
                        MessageBox.Show("تم الارسال");

                    }
                }
            }
            catch 
            {
                MessageBox.Show("فشلت عملية الارسال");
                return;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
