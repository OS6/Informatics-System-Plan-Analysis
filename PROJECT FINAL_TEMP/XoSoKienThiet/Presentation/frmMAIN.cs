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

namespace XoSoKienThiet.Presentation
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
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

        private void rbtnDangKyVe_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void rbtnNhanVe_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void rbtnTraVe_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void rbtnKeHoachPhatHanh_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void rbtnPhieuChi_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void rbtnPhieuNhanGiai_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void rbtnPhieuThanhToan_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void rbtnGhiNhanKQXS_ItemClick(object sender, ItemClickEventArgs e)
        {

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

        private void rbtnTinhHinhTieuThuDoiTac_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void rbtnCongNoDaiLy_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void rbtnBaoCaoLoiNhuan_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void rbtnKetQuaXoSo_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void rbtnQuyDinh_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void rbtnTiepNhanNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void rbtnDanhSachLoaiVe_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void rbtnCoCauGiaiThuong_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void rbtnThemMoi_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void rbtnCapNhat_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void rbtnPhanQuyen_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void rbtnAbout_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void rbtnHelp_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}