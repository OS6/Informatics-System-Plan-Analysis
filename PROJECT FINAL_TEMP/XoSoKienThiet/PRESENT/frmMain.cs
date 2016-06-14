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

namespace XoSoKienThiet.PRESENT
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain(string tennhanvien, string mabophan, string tenbophan)
        {
            InitializeComponent();
            barUser.Caption = tennhanvien + " - " + tenbophan;
            switch (mabophan)
            {
                case "BP00000001":
                    pgLapKeHoach.Enabled = false;
                    pgGhiKQXS.Enabled = false;
                    pgTiepNhanDoiTac.Enabled = false;
                    pgQuyDinh.Enabled = false;
                    pgQuanLyNhanVien.Enabled = false;
                    pgQuyDinhVe.Enabled = false;
                    break;
                case "BP00000002":
                    pgChiTieu.Enabled = false;
                    pgGhiKQXS.Enabled = false;
                    pgTiepNhanDoiTac.Enabled = false;
                    pgQuyDinh.Enabled = false;
                    pgQuanLyNhanVien.Enabled = false;
                    pgQuyDinhVe.Enabled = false;
                    break;
                case "BP00000003":
                    pgLapKeHoach.Enabled = false;
                    pgChiTieu.Enabled = false;
                    pgTiepNhanDoiTac.Enabled = false;
                    pgDoiTac.Enabled = false;
                    pgCongTy.Enabled = false;
                    pgQuyDinh.Enabled = false;
                    pgQuanLyNhanVien.Enabled = false;
                    pgQuyDinhVe.Enabled = false;
                    break;
                default:
                    break;
            }
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

        private void rbtnDangKyVe_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmPhieuDangKiVe));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmPhieuDangKiVe f = new frmPhieuDangKiVe();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void rbtnNhanVe_ItemClick(object sender, ItemClickEventArgs e)
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

        private void rbtnTraVe_ItemClick(object sender, ItemClickEventArgs e)
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

        private void rbtnKeHoachPhatHanh_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmKeHoachPhatHanhVe));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmKeHoachPhatHanhVe f = new frmKeHoachPhatHanhVe();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void rbtnPhieuChi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmPhieuChi));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmPhieuChi f = new frmPhieuChi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void rbtnPhieuNhanGiai_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void rbtnPhieuThanhToan_ItemClick(object sender, ItemClickEventArgs e)
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

        private void rbtnGhiKetQuaXS_ItemClick(object sender, ItemClickEventArgs e)
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

        private void rbtnHoSoDoiTac_ItemClick(object sender, ItemClickEventArgs e)
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

        private void rbtnTinhHinhTieuThuDaiLy_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmBC_TieuThuDaiLy));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmBC_TieuThuDaiLy f = new frmBC_TieuThuDaiLy();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void rbtnCongNoDaiLy_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmTraCuuCongNo));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmTraCuuCongNo f = new frmTraCuuCongNo();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void rbtnBaoCaoDoanThuTheoDot_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmBC_DoanThuTheoDPH));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmBC_DoanThuTheoDPH f = new frmBC_DoanThuTheoDPH();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void rbtnBaoCaoDoanThuTheoThang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmBC_DoanThuTheoThang));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmBC_DoanThuTheoThang f = new frmBC_DoanThuTheoThang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void rbtnBaoCaoDoanThuTheoNam_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmBC_DoanhThuTheoNam));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmBC_DoanhThuTheoNam f = new frmBC_DoanhThuTheoNam();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void rbtnKetQuaXoSo_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmDoSo));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmDoSo f = new frmDoSo();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void rbtnQuyDinh_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void rbtnTiepNhanNhanVien_ItemClick(object sender, ItemClickEventArgs e)
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

        private void rbtnDanhSachLoaiVe_ItemClick(object sender, ItemClickEventArgs e)
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

        private void rbtnCoCauGiaiThuong_ItemClick(object sender, ItemClickEventArgs e)
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

        private void rbtnThemMoi_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void rbtnCapNhat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmCapNhatTaiKhoan));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmCapNhatTaiKhoan f = new frmCapNhatTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void rbtnDotPhatHanh_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmDotPhatHanh));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmDotPhatHanh f = new frmDotPhatHanh();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void rbtnSaoLuuKhoiPhuc_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmSaoLuuVaKhoiPhuc));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmSaoLuuVaKhoiPhuc f = new frmSaoLuuVaKhoiPhuc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void rbtnAbout_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void rbtnHelp_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}