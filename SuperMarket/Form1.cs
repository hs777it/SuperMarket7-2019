using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vUtility.SendEmail("hs777it@gmail.com", "hs777it@gmail.com,hs.smartweb@gmail.com", "New ____________", "<h1>موضوع جديد جدا</h1>","حسين سعد");
            MessageBox.Show("Test");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Random rnd = new Random();
            //int no = rnd.Next(1, 20);
            Random rnd = new Random((int)DateTime.Now.Ticks);
            string[] coupon = new string[20];
            for (int i = 0; i < coupon.Length; i++)
            {
                coupon[i] = vUtility.GenerateCoupon(10, rnd);
            }
            //Console.WriteLine(String.Join("-", coupon));
            //MessageBox.Show(string.Join(Environment.NewLine, coupon));
            MessageBox.Show(string.Join("\n", coupon));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(vUtility.GenerateCoupon(10, Environment.NewLine));
            //MessageBox.Show(vUtility.GenerateCoupon(5, 7, Environment.NewLine));


            //string random = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789".Random(16);


            


        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (char.IsDigit(e.KeyChar) == true || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == Convert.ToChar(Keys.Delete))
            //{
            //    e.Handled = true;
            //}

           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //vUtility.SendEmail("hs777it@gmail.com", "hs777it@gmail.com", "New Subject", "body", null,"حسين سعد");




            MessageBox.Show(vSecurity.MD5Serial("eee"));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\‫012.mp3");
            player.Play();
        }
    }
}
