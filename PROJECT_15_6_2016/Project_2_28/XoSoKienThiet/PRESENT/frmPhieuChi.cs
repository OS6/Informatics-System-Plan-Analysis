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
    public partial class frmPhieuChi : DevExpress.XtraEditors.XtraForm
    {
        DOTPHATHANH_BUS _DOTPHATHANH_BUS = null;
        BOPHAN_BUS _BOPHAN_BUS = null;
        NHANVIEN_BUS _NHANVIEN_BUS = null;
        PHIEUCHI_BUS _PHIEUCHI_BUS = null;
        public frmPhieuChi()
        {
            InitializeComponent();
            _DOTPHATHANH_BUS = new DOTPHATHANH_BUS();
            _BOPHAN_BUS = new BOPHAN_BUS();
            _NHANVIEN_BUS = new NHANVIEN_BUS();
            _PHIEUCHI_BUS = new PHIEUCHI_BUS();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string MaDotPhatHanh = lkDotPhatHanh.Properties.GetDataSourceValue("MaDotPhatHanh", lkDotPhatHanh.ItemIndex).ToString();
            string MaBoPhan = lkDonViNhan.Properties.GetDataSourceValue("MaBoPhan", lkDonViNhan.ItemIndex).ToString();
            string MaNhanVien = lkNguoiLap.Properties.GetDataSourceValue("MaNhanVien", lkNguoiLap.ItemIndex).ToString();
            _PHIEUCHI_BUS.Insert(MaDotPhatHanh, MaBoPhan, MaNhanVien,deNgayLap.Text, txtNoiDungChi.Text, txtSoTienChi.Text);
        }

        private void frmPhieuChi_Load(object sender, EventArgs e)
        {
            // Load lkDotPhatHanh
            var ListDotPhatHanh = _DOTPHATHANH_BUS.Select_Your_Company();
            lkDotPhatHanh.Properties.DataSource = ListDotPhatHanh;
            lkDotPhatHanh.Properties.DisplayMember = "MaDotPhatHanh";
            lkDotPhatHanh.Properties.ValueMember = "MaDotPhatHanh";

            lkDotPhatHanh.Properties.ForceInitialize();
            lkDotPhatHanh.Properties.PopulateColumns();

            lkDotPhatHanh.Properties.Columns["MaCongTy"].Visible = false;

            // Load lk bộ phận
            var ListBoPhan = _BOPHAN_BUS.Select();

            lkDonViNhan.Properties.DataSource = ListBoPhan;
            lkDonViNhan.Properties.DisplayMember = "TenBoPhan";

            lkDonViNhan.Properties.ForceInitialize();
            lkDonViNhan.Properties.PopulateColumns();

            lkDonViNhan.Properties.Columns["MaBoPhan"].Visible = false;
            lkDonViNhan.Properties.Columns["MaQuanLy"].Visible = false;

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
            lkDonViNhan.ReadOnly = false;
            deNgayLap.ReadOnly = false;
            lkNguoiLap.ReadOnly = false;
            txtNoiDungChi.ReadOnly = false;
            txtSoTienChi.ReadOnly = false;
            txtSoTienChi.Text = "0";
            txtNoiDungChi.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string DonViNhan = "", DotPhatHanh = "", NguoiLap = "", NgayLap = "";
            try
            {
                DonViNhan = lkDonViNhan.GetColumnValue("MaBoPhan").ToString();
            }
            catch (Exception)
            {
            }
            try
            {
                DotPhatHanh = lkDotPhatHanh.GetColumnValue("MaDotPhatHanh").ToString();
            }
            catch (Exception)
            {
            }
            try
            {
                NguoiLap = lkNguoiLap.GetColumnValue("MaNhanVien").ToString();
            }
            catch (Exception)
            {
            }
            try
            {
                NgayLap = deNgayLap.EditValue.ToString();
            }
            catch (Exception)
            {
            }
            string Error = _PHIEUCHI_BUS.Insert(DotPhatHanh, DonViNhan, NguoiLap, NgayLap, txtNoiDungChi.Text, txtSoTienChi.Text);
            if (Error != "")
            {
                XtraMessageBox.Show(Error, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                XtraMessageBox.Show("Thêm thành công.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}