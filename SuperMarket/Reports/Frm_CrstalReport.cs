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
using CrystalDecisions.Windows.Forms;
using System.Diagnostics;
using SuperMarket.Classes;

namespace SuperMarket.Reports
{
    public partial class Frm_CrstalReport : DevExpress.XtraEditors.XtraForm
    {
        public Frm_CrstalReport()
        {
            InitializeComponent();
            this.Width= 880;
            this.Height= Screen.PrimaryScreen.Bounds.Height - 50; //790
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void Frm_CrstalReport_Load(object sender, EventArgs e)
        {
            Helpers.HideTabControl(crystalReportViewer1);
        }



    }
}