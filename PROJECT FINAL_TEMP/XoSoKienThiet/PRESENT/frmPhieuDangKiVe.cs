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
using System.Data.Entity;
using XoSoKienThiet.BUS;

namespace XoSoKienThiet.PRESENT
{
    public partial class frmPhieuDangKiVe : DevExpress.XtraEditors.XtraForm
    {
        NHANVIEN_BUS _NHANVIEN_BUS = null;
        DOITAC_BUS _DOITAC_BUS = null;
        DOTPHATHANH_BUS _DOTPHATHANH_BUS = null;
        LOAIVE_BUS _LOAIVE_BUS = null;
        CT_PHIEUDANGKYVE_BUS _CT_PHIEUDANGKYVE_BUS = null;
        PHIEUDANGKYVE_BUS _PHIEUDANGKYVE_BUS = null;
        string _MaDotPhatHanh = "", _MaLoaiVe = "", _MaCongTy = "", _MaPhieuDangKy = "", _NgayLap = "";
        List<string> _ListMaCongTy, _ListMaDotPhatHanh, _ListLoaiVe; // dùng để lưu những bộ ba đã có trong chi tiết đợt phát hành
        public frmPhieuDangKiVe()
        {
            InitializeComponent();
            _NHANVIEN_BUS = new NHANVIEN_BUS();
            _DOITAC_BUS = new DOITAC_BUS();
            _DOTPHATHANH_BUS = new DOTPHATHANH_BUS();
            _LOAIVE_BUS = new LOAIVE_BUS();
            _CT_PHIEUDANGKYVE_BUS = new CT_PHIEUDANGKYVE_BUS();
            _PHIEUDANGKYVE_BUS = new PHIEUDANGKYVE_BUS();
            _ListMaCongTy = new List<string>();
            _ListLoaiVe = new List<string>();
            _ListMaDotPhatHanh = new List<string>();
        }

        private void rbtnLoaiDoiTac_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hiện đối tác đăng ký vé
            if (rbtnLoaiDoiTac.SelectedIndex == 0)
            {
                var ListDoiTac = _DOITAC_BUS.SelectYourCompany();
                lkTenDoiTac.Properties.DataSource = ListDoiTac;
                lkTenDoiTac.Properties.DisplayMember = "Ten";

                // Load công ty phát hành
                var ListCompany = _DOITAC_BUS.SelectNotYourCompany();
                lkCongTyPhatHanh.Properties.DataSource = ListCompany;
            }
            else
            {
                var ListDoiTac = _DOITAC_BUS.SelectAgency();
                lkTenDoiTac.Properties.DataSource = ListDoiTac;
                lkTenDoiTac.Properties.DisplayMember = "Ten";

                // Load công ty phát hành
                var ListCompany = _DOITAC_BUS.SelectCompany();
                lkCongTyPhatHanh.Properties.DataSource = ListCompany;
            }

        }

        private void frmDangKiVe_Load(object sender, EventArgs e)
        {
            var ListDoiTac = _DOITAC_BUS.SelectCompany();

            lkTenDoiTac.Properties.DataSource = ListDoiTac;
            lkTenDoiTac.Properties.DisplayMember = "Ten";

            lkTenDoiTac.Properties.ForceInitialize();
            lkTenDoiTac.Properties.PopulateColumns();

            lkTenDoiTac.Properties.Columns["MaDoiTac"].Visible = false;
            lkTenDoiTac.Properties.Columns["MaLoaiDoiTac"].Visible = false;
            lkTenDoiTac.Properties.Columns["TiLeHoaHong"].Visible = false;
            lkTenDoiTac.Properties.Columns["TiLeTieuThu"].Visible = false;
            lkTenDoiTac.Properties.Columns["CongNo"].Visible = false;

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
            lkCongTyPhatHanh.Properties.DisplayMember = "Ten";

            // Load công ty phát hành
            var ListCompany = _DOITAC_BUS.SelectNotYourCompany();
            lkCongTyPhatHanh.Properties.DataSource = ListCompany;

            lkCongTyPhatHanh.Properties.ForceInitialize();
            lkCongTyPhatHanh.Properties.PopulateColumns();

            lkCongTyPhatHanh.Properties.Columns["MaDoiTac"].Visible = false;
            lkCongTyPhatHanh.Properties.Columns["MaLoaiDoiTac"].Visible = false;
            lkCongTyPhatHanh.Properties.Columns["TiLeHoaHong"].Visible = false;
            lkCongTyPhatHanh.Properties.Columns["TiLeTieuThu"].Visible = false;
            lkCongTyPhatHanh.Properties.Columns["CongNo"].Visible = false;
        }

        private void lkCongTyPhatHanh_EditValueChanged(object sender, EventArgs e)
        {
            lkDotPhatHanh.Text = "";
            lkDotPhatHanh.Properties.DataSource = null;

            lkLoaiVe.Text = "";
            lkLoaiVe.Properties.DataSource = null;
            lkDotPhatHanh.ReadOnly = false;
            try
            {
                _MaCongTy = lkCongTyPhatHanh.GetColumnValue("MaDoiTac").ToString();
                var _ListDotPhatHanh = _DOTPHATHANH_BUS.Select_Con_Company(_MaCongTy);
                lkDotPhatHanh.Properties.DataSource = _ListDotPhatHanh;
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
        }

        private void lkDotPhatHanh_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                lkLoaiVe.Text = "";
                lkLoaiVe.ReadOnly = false;

                _MaCongTy = lkCongTyPhatHanh.GetColumnValue("MaDoiTac").ToString();
                _MaDotPhatHanh = lkDotPhatHanh.GetColumnValue("MaDotPhatHanh").ToString();
                var ListLoaiVe = _LOAIVE_BUS.Select_Con_Company(_MaCongTy);
                lkLoaiVe.Properties.DataSource = ListLoaiVe;
                lkLoaiVe.Properties.DisplayMember = "MenhGia";
                lkLoaiVe.Properties.ValueMember = "MaLoaiVe";

                lkLoaiVe.Properties.ForceInitialize();
                lkLoaiVe.Properties.PopulateColumns();

                lkLoaiVe.Properties.Columns["MaCongTy"].Visible = false;
            }
            catch (Exception)
            {
                Console.WriteLine("Form phiếu đăng ký lkDPH ediit change value");
            }
        }

        private void lkLoaiVe_EditValueChanged(object sender, EventArgs e)
        {
            txtSoVeDangKy.ReadOnly = false;
            try
            {
                _MaLoaiVe = lkLoaiVe.GetColumnValue("MaLoaiVe").ToString();
                txtSoVeToiDa.Text = _CT_PHIEUDANGKYVE_BUS.GetAmountOfMaxRegisterTicket(lkTenDoiTac.GetColumnValue("MaDoiTac").ToString(),
                                                                                            _MaCongTy,
                                                                                            _MaDotPhatHanh,
                                                                                            _MaLoaiVe).ToString();
            }
            catch (Exception)
            {
            }
        }

        private void btnThemPhieu_Click(object sender, EventArgs e)
        {
            _MaPhieuDangKy = "";
            rbtnLoaiDoiTac.ReadOnly = false;
            lkTenDoiTac.ReadOnly = false;
            lkNguoiLap.ReadOnly = false;
            deNgayLap.ReadOnly = false;
            lkCongTyPhatHanh.ReadOnly = false;
            rbtnLoaiDoiTac.ReadOnly = false;
            lkDotPhatHanh.EditValue = null;
            btnLuu.Enabled = true;
            lkCongTyPhatHanh.EditValue = null;
            lkTenDoiTac.EditValue = null;
            lkNguoiLap.EditValue = null;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string Error = "";
            if (_MaPhieuDangKy != "")
            {
                bool DaDangKy = _CT_PHIEUDANGKYVE_BUS.CheckRegister(lkTenDoiTac.GetColumnValue("MaDoiTac").ToString(),
                                                                        _MaCongTy, _MaDotPhatHanh, _MaLoaiVe);
                if (DaDangKy == true)// đã đăng ký chi tiết vé
                {
                    MessageBox.Show("Loại vé đã được đăng ký", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Error = _CT_PHIEUDANGKYVE_BUS.Insert(_MaPhieuDangKy, _MaCongTy, _MaDotPhatHanh, _MaLoaiVe, txtSoVeToiDa.Text, txtSoVeDangKy.Text);
                    if (Error == "")
                    {
                        XtraMessageBox.Show("Thêm thành công.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(Error, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    var ListCT_DKV = _CT_PHIEUDANGKYVE_BUS.SelectView(_MaPhieuDangKy);
                    gcBASE.DataSource = ListCT_DKV;
                    var SoVeDK = from p in ListCT_DKV
                                 select p.SoVeDangKy;

                    txtTongSoVe.Text = (Convert.ToString(SoVeDK.Sum()));
                }
             

            }
            else
            {
                _NgayLap = deNgayLap.EditValue.ToString();

                Error = _PHIEUDANGKYVE_BUS.CheckErrorBeforeInsert(lkTenDoiTac.GetColumnValue("MaDoiTac").ToString(),
                                                           lkNguoiLap.GetColumnValue("MaNhanVien").ToString(),
                                                         _NgayLap,
                                                           txtTongSoVe.Text);

                if (Error == "")
                {
                   _MaPhieuDangKy = _PHIEUDANGKYVE_BUS.Insert(lkTenDoiTac.GetColumnValue("MaDoiTac").ToString(),
                                                           lkNguoiLap.GetColumnValue("MaNhanVien").ToString(),
                                                         _NgayLap,
                                                           txtTongSoVe.Text);
                    bool DaDangKy = _CT_PHIEUDANGKYVE_BUS.CheckRegister(lkTenDoiTac.GetColumnValue("MaDoiTac").ToString(),
                                                                       _MaCongTy, _MaDotPhatHanh, _MaLoaiVe);
                    if (DaDangKy == true)// đã đăng ký chi tiết vé
                    {
                        MessageBox.Show("Loại vé đã được đăng ký", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Error = _CT_PHIEUDANGKYVE_BUS.Insert(_MaPhieuDangKy, _MaCongTy, _MaDotPhatHanh, _MaLoaiVe, txtSoVeToiDa.Text, txtSoVeDangKy.Text);
                        if (Error == "")
                        {
                            XtraMessageBox.Show("Thêm thành công.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(Error, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show(Error, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                var ListCT_DKV = _CT_PHIEUDANGKYVE_BUS.SelectView(_MaPhieuDangKy);
                gcBASE.DataSource = ListCT_DKV;
                var SoVeDK = from p in ListCT_DKV
                             select p.SoVeDangKy;

                txtTongSoVe.Text = (Convert.ToString(SoVeDK.Sum()));

                rbtnLoaiDoiTac.ReadOnly = true;
                lkTenDoiTac.ReadOnly = true;
                lkNguoiLap.ReadOnly = true;
                deNgayLap.ReadOnly = true;
                btnThem.Enabled = true;
            }
        }
    }
}