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
using DevExpress.XtraBars.Helpers;

namespace SuperMarket.PL.Skins
{
    public partial class XtraFormSkins : DevExpress.XtraEditors.XtraForm
    {

        PL.Main.FrmMain frm = new Main.FrmMain();
        public XtraFormSkins()
        {
            InitializeComponent();
            SkinHelper.InitSkinGallery(galleryControl1, true,true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}