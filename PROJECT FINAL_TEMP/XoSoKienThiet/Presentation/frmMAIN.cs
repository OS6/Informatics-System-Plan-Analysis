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
            Form frm = this.KiemTraTonTai(typeof(frmHoSoDoiTac));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmHoSoDoiTac f = new frmHoSoDoiTac();
                f.Text = "Cập nhật đối tác";
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

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmDangKiVe));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmDangKiVe f = new frmDangKiVe();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmCoCauGiaiThuong));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmCoCauGiaiThuong f = new frmCoCauGiaiThuong();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmPhieuNhanVe));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmPhieuNhanVe f = new frmPhieuNhanVe();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmPhieuTraVe));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmPhieuTraVe f = new frmPhieuTraVe();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmPhieuThanhToan));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmPhieuThanhToan f = new frmPhieuThanhToan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmKetQuaXoSo));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmKetQuaXoSo f = new frmKetQuaXoSo();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}