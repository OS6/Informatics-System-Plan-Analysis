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
using XoSoKienThiet.BUS;

namespace XoSoKienThiet.PRESENT
{
    public partial class frmPhieuNhanGiai : DevExpress.XtraEditors.XtraForm
    {
        DOTPHATHANH_BUS _DOTPHATHANH_BUS = null;
        LOAIVE_BUS _LOAIVE_BUS = null;
        GIAITHUONG_BUS _GIAITHUONG_BUS = null;
        NHANVIEN_BUS _NHANVIEN_BUS = null;
        PHIEUNHANGIAI_BUS _PHIEUNHANGIAI_BUS = null;
        decimal _SoTienTrungThuong = 0;
        public frmPhieuNhanGiai()
        {
            InitializeComponent();
            _DOTPHATHANH_BUS = new DOTPHATHANH_BUS();
            _LOAIVE_BUS = new LOAIVE_BUS();
            _GIAITHUONG_BUS = new GIAITHUONG_BUS();
            _NHANVIEN_BUS = new NHANVIEN_BUS();
            _PHIEUNHANGIAI_BUS = new PHIEUNHANGIAI_BUS();
        }

        private void frmPhieuNhanGiai_Load(object sender, EventArgs e)
        {
            try
            {
                var ListDotPhatHanh = _DOTPHATHANH_BUS.Select_Your_Company();
                lkDotPhatHanh.Properties.DataSource = ListDotPhatHanh;
                lkDotPhatHanh.Properties.DisplayMember = "NgayPhatHanh";
                lkDotPhatHanh.Properties.ValueMember = "MaDotPhatHanh";

                lkDotPhatHanh.Properties.ForceInitialize();
                lkDotPhatHanh.Properties.PopulateColumns();

                lkDotPhatHanh.Properties.Columns["NgayXoSo"].Visible = false;
                lkDotPhatHanh.Properties.Columns["GioXoSo"].Visible = false;
            }
            catch (Exception)
            {
            }
            // #Load danh sách nhân viên
            var _ListNhanVien = _NHANVIEN_BUS.Select();
            lkNguoiLap.Properties.DataSource = _ListNhanVien;
            lkNguoiLap.Properties.DisplayMember = "Ten";
            lkNguoiLap.Properties.ValueMember = "MaNhanVien";

            lkNguoiLap.Properties.ForceInitialize();
            lkNguoiLap.Properties.PopulateColumns();

            lkNguoiLap.Properties.Columns["MaCoCauToChuc"].Visible = false;
            lkNguoiLap.Properties.Columns["DiaChi"].Visible = false;
            lkNguoiLap.Properties.Columns["Email"].Visible = false;
            lkNguoiLap.Properties.Columns["SDT"].Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lkDotPhatHanh.ReadOnly = false;
            lkLoaiVe.ReadOnly = false;
            lkGiaiThuong.ReadOnly = false;
            lkNguoiLap.ReadOnly = false;
            deNgayLap.ReadOnly = false;
            txtSoVeTrung.ReadOnly = false;
            txtNguoiNhanGiai.ReadOnly = false;
            txtSoDienThoai.ReadOnly = false;
            txtSoCMND.ReadOnly = false;

            txtSoVeTrung.Text = "";
            txtSoTienTrungThuong.Text = "";
            txtSoTienDongThue.Text = "";
            txtSoTienNhanDuoc.Text = "";
            txtNguoiNhanGiai.Text = "";
            txtSoDienThoai.Text = "";
            txtSoCMND.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string DotPhatHanh = "", NgayLap = "", NguoiLap = "", LoaiVe = "", GiaiThuong = "";
            try
            {
                DotPhatHanh = lkDotPhatHanh.GetColumnValue("MaDotPhatHanh").ToString();
                LoaiVe = lkLoaiVe.GetColumnValue("MaLoaiVe").ToString();
                GiaiThuong = lkGiaiThuong.GetColumnValue("MaGiaiThuong").ToString();
                NgayLap = deNgayLap.Text;
                NguoiLap = lkNguoiLap.GetColumnValue("MaNhanVien").ToString();
            }
            catch (Exception)
            {
            }
            string Error = _PHIEUNHANGIAI_BUS.Insert(DotPhatHanh, LoaiVe, GiaiThuong, _SoTienTrungThuong.ToString(), (_SoTienTrungThuong * (decimal)0.1).ToString(), (_SoTienTrungThuong * (decimal)0.9).ToString(), NguoiLap, NgayLap, txtNguoiNhanGiai.Text, txtSoDienThoai.Text, txtSoCMND.Text);
            if (Error != "")
            {
                XtraMessageBox.Show(Error, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                XtraMessageBox.Show("Thêm thành công.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lkDotPhatHanh_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtNgayXoSo.Text = string.Format("{0:dd/MM/yyyy}", Convert.ToDateTime(lkDotPhatHanh.Properties.GetDataSourceValue("NgayXoSo", lkDotPhatHanh.ItemIndex).ToString()));

                XoSoKienThiet.DTO.XoSoKienThietDbContext dbContext = new XoSoKienThiet.DTO.XoSoKienThietDbContext();
                string MaDotPhatHanh = lkDotPhatHanh.Properties.GetDataSourceValue("MaDotPhatHanh", lkDotPhatHanh.ItemIndex).ToString();
            }
            catch (Exception)
            {
            }
            lkLoaiVe.Text = "";
            lkLoaiVe.Properties.DataSource = null;
            lkLoaiVe.ReadOnly = false;

            var ListLoaiVe = _LOAIVE_BUS.SelectYourCompany();
            lkLoaiVe.Properties.DataSource = ListLoaiVe;
            lkLoaiVe.Properties.DisplayMember = "MenhGia";
            lkLoaiVe.Properties.ValueMember = "MaLoaiVe";

            lkLoaiVe.Properties.ForceInitialize();
            lkLoaiVe.Properties.PopulateColumns();

            lkLoaiVe.Properties.Columns["MaCongTy"].Visible = false;
        }

        private void lkLoaiVe_EditValueChanged(object sender, EventArgs e)
        {
            lkGiaiThuong.Properties.DataSource = _GIAITHUONG_BUS.Select(lkLoaiVe.GetColumnValue("MaLoaiVe").ToString());
            lkGiaiThuong.Properties.DisplayMember = "Ten";
            lkGiaiThuong.Properties.ValueMember = "MaGiaiThuong";

            lkGiaiThuong.Properties.ForceInitialize();
            lkGiaiThuong.Properties.PopulateColumns();

            lkGiaiThuong.Properties.Columns["SoGiai"].Visible = false;
            lkGiaiThuong.Properties.Columns["SoTienTrung"].Visible = false;
            lkGiaiThuong.Properties.Columns["TongTienTrung"].Visible = false;
            lkGiaiThuong.Properties.Columns["MaLoaiVe"].Visible = false;
        }

        private void lkGiaiThuong_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                _SoTienTrungThuong = Convert.ToDecimal(lkGiaiThuong.GetColumnValue("SoTienTrung"));
                txtSoTienTrungThuong.Text = string.Format("{0:N0}", _SoTienTrungThuong);
                txtSoTienDongThue.Text = string.Format("{0:N0}", _SoTienTrungThuong * (decimal)0.1);
                txtSoTienNhanDuoc.Text = string.Format("{0:N0}", _SoTienTrungThuong * (decimal)0.9);
            }
            catch (Exception)
            {
            }
        }
    }
}