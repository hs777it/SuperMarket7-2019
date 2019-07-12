using CrystalDecisions.Windows.Forms;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket.Classes
{
    class Helpers
    {
        public static string user = Properties.Settings.Default.UserName;
        public static string pass = Properties.Settings.Default.pass;

          public static void CheckFormActive(XtraForm frm, XtraForm main)
        {
            //XtraForm3 frm = new XtraForm3();
            if ((Application.OpenForms[frm.Name] as XtraForm) != null)
            {
                Application.OpenForms[frm.Name].Activate();
                Application.OpenForms[frm.Name].WindowState = FormWindowState.Normal;
            }
            else
            {
                frm.LookAndFeel.UseDefaultLookAndFeel = false;
                frm.LookAndFeel.SetSkinStyle(main.LookAndFeel.SkinName);
                frm.MdiParent = main;
                frm.Show();
            }
        }

        public static void HideTabControl(CrystalReportViewer crystalReportViewer)
        {
            Debug.Assert(crystalReportViewer.ReportSource != null, "you have to set the ReportSource first");
            foreach (Control ctrl in crystalReportViewer.Controls)
            {
                if (ctrl is PageView)
                {
                    PageView pv = (PageView)ctrl;
                    foreach (Control c2 in pv.Controls)
                    {
                        if (c2 is TabControl)
                        {
                            TabControl tc = (TabControl)c2;
                            tc.ItemSize = new Size(0, 1);
                            tc.SizeMode = TabSizeMode.Fixed;
                        }
                    }
                }
            }
        }
    }
}
