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

    public partial class frmPlaces : DevExpress.XtraEditors.XtraForm
    {
        Classes.ClsPlaces ClsP = new Classes.ClsPlaces();
        public frmPlaces()
        {
            InitializeComponent();
        }
        
    }
}