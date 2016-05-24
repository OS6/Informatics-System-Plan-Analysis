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
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;

namespace XoSoKienThiet.Presentation
{
    public partial class frmMAIN : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMAIN()
        {
            InitializeComponent();
        }

        private Form KiemTraTonTai(Type formType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == formType)
                {
                    return f;
                }
            }
            return null;
        }

        private void barbtnHoSoDoiTac_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmHoSoDoiTac));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmHoSoDoiTac f = new frmHoSoDoiTac();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmDanhSachLoaiVe));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmDanhSachLoaiVe f = new frmDanhSachLoaiVe();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmTiepNhanNhanVien));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmTiepNhanNhanVien f = new frmTiepNhanNhanVien();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}