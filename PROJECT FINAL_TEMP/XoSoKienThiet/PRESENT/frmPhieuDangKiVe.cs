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
using XoSoKienThiet.REPORT;
using DevExpress.XtraReports.UI;

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
        bool LoaiDoiTac = false; // bằng true là đại lý đang đăng ký công ty, ngược lại là công ty đăng ký với các công ty cung ứng khác
        bool _InPhieu = false;
        rptIn_PhieuDangKiVe _Report = null;
        ReportPrintTool _Tool = null;
        public frmPhieuDangKiVe()
        {
            InitializeComponent();
            _NHANVIEN_BUS = new NHANVIEN_BUS();
            _DOITAC_BUS = new DOITAC_BUS();
            _DOTPHATHANH_BUS = new DOTPHATHANH_BUS();
            _LOAIVE_BUS = new LOAIVE_BUS();
            _CT_PHIEUDANGKYVE_BUS = new CT_PHIEUDANGKYVE_BUS();
            _PHIEUDANGKYVE_BUS = new PHIEUDANGKYVE_BUS();
        }

        private void rbtnLoaiDoiTac_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hiện đối tác đăng ký vé
            if (rbtnLoaiDoiTac.SelectedIndex == 0)
            {
                LoaiDoiTac = false;
                var ListDoiTac = _DOITAC_BUS.SelectYourCompany();
                lkTenDoiTac.Properties.DataSource = ListDoiTac;
                lkTenDoiTac.Properties.DisplayMember = "Ten";

                // Load công ty phát hành
                var ListCompany = _DOITAC_BUS.SelectNotYourCompany();
                lkCongTyPhatHanh.Properties.DataSource = ListCompany;
            }
            else
            {
                LoaiDoiTac = true;
                var ListDoiTac = _DOITAC_BUS.SelectAgency();
                lkTenDoiTac.Properties.DataSource = ListDoiTac;
                lkTenDoiTac.Properties.DisplayMember = "Ten";

                // Load công ty phát hành
                var ListCompany = _DOITAC_BUS.SelectCompany();
                lkCongTyPhatHanh.Properties.DataSource = ListCompany;
            }

            // clear thông tin phiếu đăng ký
            lkTenDoiTac.EditValue = null;
            lkNguoiLap.EditValue = null;
            deNgayLap.Text = "";
            txtTongSoVe.Text = "0";
            lkCongTyPhatHanh.EditValue = null;
            lkLoaiVe.EditValue = null;
            lkDotPhatHanh.EditValue = null;

        }

        private void frmDangKiVe_Load(object sender, EventArgs e)
        {

            var ListDoiTac = _DOITAC_BUS.SelectYourCompany();

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

            // thông tin chi tiết phiếu đăng ký, ẩn
            AllowInputCT_PhieuDangKy(false);
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

            if(LoaiDoiTac == true) // đại lý đăng ký
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
            else
            {
                txtSoVeDangKy.ReadOnly = true;
                try
                {
                    _MaLoaiVe = lkLoaiVe.GetColumnValue("MaLoaiVe").ToString();
                    txtSoVeDangKy.Text = txtSoVeToiDa.Text = _CT_PHIEUDANGKYVE_BUS.CaculateAmountofTickRegister(_MaCongTy, _MaDotPhatHanh, _MaLoaiVe).ToString();
                }
                catch (Exception)
                {
                }
            }
        }

        void AllowInputPhieuNhanVe(bool IsOpen) // mở ra cho phép nhập thông tin vào các control trong phiếu đăng ký vé
        {
            if(IsOpen == true)
            {
                rbtnLoaiDoiTac.ReadOnly = false;
                lkTenDoiTac.ReadOnly = false;
                lkNguoiLap.ReadOnly = false;
                deNgayLap.ReadOnly = false;
                rbtnLoaiDoiTac.ReadOnly = false;
                btnLuu.Enabled = true;

                lkTenDoiTac.EditValue = null;
                lkNguoiLap.EditValue = null;
                deNgayLap.Text = "";
                txtTongSoVe.Text = "0";
            }
            else
            {
                rbtnLoaiDoiTac.ReadOnly = true;
                lkTenDoiTac.ReadOnly = true;
                lkNguoiLap.ReadOnly = true;
                deNgayLap.ReadOnly = true;
                btnThem.Enabled = true;
            }
        }
        void AllowInputCT_PhieuDangKy(bool IsOpen)   // thông tin chi tiết phiếu đăng ký
        {
            if(IsOpen == true)
            {
                lkCongTyPhatHanh.EditValue = null;
                lkDotPhatHanh.EditValue = null;
                lkLoaiVe.EditValue = null;
                txtSoVeDangKy.Text = "";
                txtSoVeToiDa.Text = "";

                lkCongTyPhatHanh.ReadOnly = false;
                lkDotPhatHanh.ReadOnly = false;
                lkLoaiVe.ReadOnly = false;
                txtSoVeDangKy.ReadOnly = false;
            }
            else
            {
                lkCongTyPhatHanh.ReadOnly = true;
                lkDotPhatHanh.ReadOnly = true;
                lkLoaiVe.ReadOnly = true;
                txtSoVeDangKy.ReadOnly = true;
                txtSoVeToiDa.ReadOnly = true;
            }
        }
        private void btnThemPhieu_Click(object sender, EventArgs e)
        {
            _MaPhieuDangKy = "";
            _InPhieu = false;
            gcBASE.DataSource = null;
            AllowInputPhieuNhanVe(true);
            AllowInputCT_PhieuDangKy(true);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // thông tin chi tiết phiếu đăng ký
            AllowInputCT_PhieuDangKy(true);
            _InPhieu = false;
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
                    XtraMessageBox.Show("Loại vé đã được đăng ký", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Error = _CT_PHIEUDANGKYVE_BUS.Insert(_MaPhieuDangKy, _MaCongTy, _MaDotPhatHanh, _MaLoaiVe, txtSoVeToiDa.Text, txtSoVeDangKy.Text);
                    if (Error == "")
                    {
                        XtraMessageBox.Show("Thêm thành công.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        AllowInputCT_PhieuDangKy(false);
                    }
                    else
                    {
                        XtraMessageBox.Show(Error, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    var ListCT_DKV = _CT_PHIEUDANGKYVE_BUS.SelectView(_MaPhieuDangKy);
                    gcBASE.DataSource = ListCT_DKV;
                    var SoVeDK = from p in ListCT_DKV
                                 select p.SoVeDangKy;

                    txtTongSoVe.Text = (Convert.ToString(SoVeDK.Sum()));
                    _PHIEUDANGKYVE_BUS.Update(_MaPhieuDangKy,Convert.ToInt32( SoVeDK.Sum()));
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
                        XtraMessageBox.Show("Loại vé đã được đăng ký", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Error = _CT_PHIEUDANGKYVE_BUS.Insert(_MaPhieuDangKy, _MaCongTy, _MaDotPhatHanh, _MaLoaiVe, txtSoVeToiDa.Text, txtSoVeDangKy.Text);
                        if (Error == "")
                        {
                            XtraMessageBox.Show("Thêm thành công.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            AllowInputPhieuNhanVe(false);
                            AllowInputCT_PhieuDangKy(false);
                        }
                        else
                        {
                            XtraMessageBox.Show(Error, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show(Error, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                var ListCT_DKV = _CT_PHIEUDANGKYVE_BUS.SelectView(_MaPhieuDangKy);
                gcBASE.DataSource = ListCT_DKV;
                var SoVeDK = from p in ListCT_DKV
                             select p.SoVeDangKy;

                txtTongSoVe.Text = (Convert.ToString(SoVeDK.Sum()));
                _PHIEUDANGKYVE_BUS.Update(_MaPhieuDangKy, Convert.ToInt32(SoVeDK.Sum()));
            }

            _InPhieu = true;
            _Report = new rptIn_PhieuDangKiVe();
            _Report.DataSource = gcBASE.DataSource;
            
             
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (!_InPhieu)
            {
                XtraMessageBox.Show("Phải điền thông tin đầy đủ và lưu phiếu trước khi in!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _Report.rptLabelTenDoiTac.Text = "Tên đối tác: " + lkTenDoiTac.GetColumnValue("Ten").ToString();
                _Report.rptLabelNgay.Text = "Tp. Hồ Chí Minh, ngày " + DateTime.Now.Day.ToString() + " tháng " + DateTime.Now.Month.ToString() + " năm " + DateTime.Now.Year.ToString();
                _Report.rptLabelTongSoVe.Text = "Tổng số vé: "+txtTongSoVe.Text;
                _Tool = new ReportPrintTool(_Report);
                _Tool.ShowPreview();
            }
        }
    }
}