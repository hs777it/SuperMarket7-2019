using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Xprema_BarCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtProduct_TextChanged(object sender, EventArgs e)
        {
            if (txtProduct.Text == "")
            {
                PicBarCode.Image = null;
                txtBarCode.Text = "";
            }
            else
            {
                // الرقم لن يتكرر بتاتا لأنه يعتمد على الوقت والتاريخ الحالى
                txtBarCode.Text = _BarCode.GenerateBarCode(PicBarCode);
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            txtProduct.Focus();
        }
    }
}
