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
using System.Net;
using System.Net.Mail;
using System.IO;
namespace SuperMarket.PL.AboutSystem
{
    public partial class frmGetShot : DevExpress.XtraEditors.XtraForm
    {

        public frmGetShot()
        {
            InitializeComponent();
        }
        public Bitmap GetShot()
        {
            // Shot size = screen size
            Size shotSize = Screen.PrimaryScreen.Bounds.Size;

            // the upper left point in the screen to start shot
            // 0,0 to get the shot from upper left point
            Point upperScreenPoint = new Point(0, 0);

            // the upper left point in the image to put the shot
            Point upperDestinationPoint = new Point(0, 0);

            // create image to get the shot in it
            Bitmap shot = new Bitmap(shotSize.Width, shotSize.Height);

            // new Graphics instance 
            Graphics graphics = Graphics.FromImage(shot);

            // get the shot by Graphics class 
            graphics.CopyFromScreen(upperScreenPoint, upperDestinationPoint, shotSize);

            // return the image
            return shot;
        }

        private void حفظالصورةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();

            sv.Filter = "PNG|*.png";
            if (sv.ShowDialog() == DialogResult.OK)
            { pictureBox1.Image.Save(sv.FileName, pictureBox1.Image.RawFormat); }
        }

        private void إغلاقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void إرسالالصورةللمبرمجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                string smtpAddress = "smtp.gmail.com";
                int portNumber = 587;
                bool enableSSL = true;

                string emailFrom = "whyin4soft@gmail.com";
                string password = "3051999ni";
                string emailTo = "islam4soft@gmail.com";
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

                    SaveFileDialog sv = new SaveFileDialog();

                    sv.Filter = "PNG|*.png";
                    if (sv.ShowDialog() == DialogResult.OK)
                    { pictureBox1.Image.Save(sv.FileName, pictureBox1.Image.RawFormat); }


                    mail.Attachments.Add(new Attachment(sv.FileName));
                    

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

    }
}
