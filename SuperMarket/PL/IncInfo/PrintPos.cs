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

namespace SuperMarket.PL.IncInfo
{
    public partial class PrintPos : DevExpress.XtraEditors.XtraForm
    {
        public PrintPos()
        {
            InitializeComponent();
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.POS_PRINT = TXT_NAME_PRINT.Text;
                Int32 PRNT;
                if (CH_PRINT.Checked == false)
                {
                    PRNT = 0;
                    Properties.Settings.Default.POS_PRINT_START = Convert.ToString(PRNT);
                }
                else
                {
                    PRNT = 1;
                    Properties.Settings.Default.POS_PRINT_START = Convert.ToString(PRNT);
                }
                Properties.Settings.Default.Save();
                MessageBox.Show("تمت عملية الحفظ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                return;
            }

        }

        private void PrintPos_Load(object sender, EventArgs e)
        {
            try
            {
                TXT_NAME_PRINT.Text = Properties.Settings.Default.POS_PRINT;
                int PRNT = Convert.ToInt32(Properties.Settings.Default.POS_PRINT_START);
                if (Convert.ToDouble(PRNT) == 0)
                {
                    CH_PRINT.Checked = false;

                }
                else
                {
                    CH_PRINT.Checked = true;
                }

            }
            catch
            {
                return;
            }
        }
    }
}