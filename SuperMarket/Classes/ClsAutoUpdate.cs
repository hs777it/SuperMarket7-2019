using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
namespace SuperMarket.Classes
{
    class ClsAutoUpdate
    {
        class data
        {
            public decimal  Version { get; set; }
            public string DownloadLink { get; set; }
            public string message { get; set; }
            public string ChangeLog { get; set; }
            public bool  IsClose { get; set; }
        }
        static WebClient wb = new WebClient();
        static void Close() { Process.GetCurrentProcess().Kill(); }

        public static decimal Check4Update(decimal curentVersion)
        {
            try
            {
                data mydata = new JavaScriptSerializer().Deserialize<data>(wb.DownloadString("http://whyin4soft.yoo7.com/h3-page"));

                if (!mydata.IsClose)
                {
                    MessageBox.Show(mydata.message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Process.GetCurrentProcess().Kill();
                }
                if (mydata.Version > curentVersion)
                {
                    if (MessageBox.Show(string.Format("تحديث جديد متاح..!\nالاصدار القديم : {0}\nالاصدار الجديد : {1}\n\nالتحديثات :\n{2}", curentVersion, mydata.Version, mydata.ChangeLog), "", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    {
                        SaveFileDialog opn = new SaveFileDialog { FileName = "Whyin4soft", Filter = "RAR|*.rar" };
                        if (opn.ShowDialog() == DialogResult.OK)
                        {
                            wb.DownloadFile(mydata.DownloadLink, opn.FileName);
                            MessageBox.Show(" تم تحميل التحديث");
                            Close();
                        }
                        else
                        {
                            Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("عفواً! لايمكنك إستخدام هذا الاصدار يجب عليك تحديث النظام", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            catch
            {
                MessageBox.Show("عفواً! الجهاز غير متصل بالانترنت");Close();

            }
            return curentVersion;
        }
                          
    }
}
