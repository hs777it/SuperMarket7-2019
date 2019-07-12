using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace SuperMarket.PL.AboutSystem
{

    public partial class FrmSendEmail : DevExpress.XtraEditors.XtraForm
    {
        string FileName;
        bool IsSaved = true;
        bool Saved = false;
        public FrmSendEmail()
        {
            InitializeComponent();
        }

        private void RightAlignToolStripButton_Click(object sender, EventArgs e)
        {
            RichTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            RightAlignToolStripButton.Checked = true;
            CenterAlignToolStripButton.Checked = false;
            LeftAlignToolStripButton.Checked = false;
        }

        private void CenterAlignToolStripButton_Click(object sender, EventArgs e)
        {
            RichTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            CenterAlignToolStripButton.Checked = true;
            RightAlignToolStripButton.Checked = false;
            LeftAlignToolStripButton.Checked = false;
        }

        private void LeftAlignToolStripButton_Click(object sender, EventArgs e)
        {
            RichTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            LeftAlignToolStripButton.Checked = true;
            CenterAlignToolStripButton.Checked = false;
            RightAlignToolStripButton.Checked = false;
        }

        private void NewToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsSaved == false)
                {
                    switch (MessageBox.Show("هل تريد حفظ التغييرات ؟", "واى إن للبرمجيات", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                    {
                        case DialogResult.Yes:
                            SaveToolStripButton.PerformClick();
                            break;
                        case DialogResult.No:
                            break;
                        case DialogResult.Cancel:
                            return;
                    }
                }

                FileName = "NewSubject.rtf";
                RichTextBox1.Text = "";
                IsSaved = true;

            }
            catch            
            {
                return;
            }
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsSaved == false)
                {
                    if (Saved)
                    {
                        RichTextBox1.SaveFile(FileName);
                    }
                    else
                    {
                        SaveFileDialog1.FileName = FileName;
                        if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            FileName = SaveFileDialog1.FileName;
                            RichTextBox1.SaveFile(FileName);
                            IsSaved = true;
                            Saved = true;
                        }
                    }
                }
            }
            catch 
            {
                return;
            }
        }

        private void CopyToolStripButton_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(RichTextBox1.SelectedText))
            {
                RichTextBox1.Copy();
            }

        }

        private void CutToolStripButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(RichTextBox1.SelectedText))
            {
                RichTextBox1.Cut();
            }
        }

        private void PasteToolStripButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (Clipboard.ContainsText())
                {
                    RichTextBox1.Paste();
                }

            }
            catch 
            {
                return;
            }
        }

        private void UnderlineToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void ItalicToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                vUtility.SendEmail("hs777it@gmail.com", txtemail.Text, "", RichTextBox1.Text,"","");
                MessageBox.Show("تم الارسال");
                this.Cursor = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("فشلت عملية الارسال");
                return;
            }
            //using (MailMessage mail = new MailMessage())
            //{
            //    mail.From = new MailAddress("whyin4soft@gmail.com");
            //    mail.To.Add(txtemail.Text);
            //    mail.Subject = "  للبرمجيات";
            //    mail.Body = RichTextBox1.Text;
            //    mail.IsBodyHtml = true;
            //    //mail.Attachments.Add(new Attachment("C:\\SomeZip.zip"));

            //    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
            //    {
            //        smtp.Credentials = new NetworkCredential("whyin4soft@gmail.com", "3051999ni");
            //        smtp.EnableSsl = true;
            //        smtp.Send(mail);
            //        MessageBox.Show("تم الارسال");
            //    }
            //}

        }

        private void ImageToolStripButton_Click(object sender, EventArgs e)
        {

            //string Link = Interaction.InputBox("أدخل رابط الصورة");
            //if (string.IsNullOrEmpty(Link))
            //    return;
            //RichTextBox1.SelectedText = string.Format("[img]{0}[/img]", Link);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}