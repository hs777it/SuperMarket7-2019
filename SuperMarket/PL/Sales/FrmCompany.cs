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

namespace SuperMarket.PL.Sales
{

    public partial class FrmCompany : DevExpress.XtraEditors.XtraForm
    {
        Classes.ClsItemCompany ClsCo = new Classes.ClsItemCompany();
        public FrmCompany()
        {
            InitializeComponent();
        }
    }
}