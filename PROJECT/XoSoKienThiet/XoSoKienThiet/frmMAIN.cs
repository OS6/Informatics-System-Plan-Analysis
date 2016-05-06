using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Localization;
using DevExpress.XtraBars.Helpers;

namespace XoSoKienThiet
{
    public partial class frmMAIN : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMAIN()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTIEPNHANDAILY frm = new frmTIEPNHANDAILY();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            
        }

        private void frmMAIN_Load(object sender, EventArgs e)
        {
            BarLocalizer.Active = new BarLocalizer();
            SkinHelper.InitSkinGallery(ribbonGalleryBarItem1, true);
        }
    }
}