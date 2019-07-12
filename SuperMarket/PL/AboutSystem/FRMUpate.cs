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

namespace SuperMarket.PL.AboutSystem
{
    public partial class FRMUpate : DevExpress.XtraEditors.XtraForm
    {
        Classes.ClsAutoUpdate update = new Classes.ClsAutoUpdate();
        public FRMUpate()
        {
            InitializeComponent();
        }


        /*
         https://archive.codeplex.com/?p=autoupdater
         https://github.com/ravibpatel/AutoUpdater.NET
         https://www.codeproject.com/Articles/19623/Adding-automatic-updates-to-your-program-Part-1
        */
        private void FRMUpate_Load(object sender, EventArgs e)
        {

            try
            {
                labelControl1.Text = "V" + Classes.ClsAutoUpdate.Check4Update(1.1m); //Application.ProductVersion
                
            }
            catch
            {

                return;
            }
            
        }
    }
}