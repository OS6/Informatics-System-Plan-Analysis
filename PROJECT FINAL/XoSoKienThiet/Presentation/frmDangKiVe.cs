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

namespace XoSoKienThiet.Presentation
{
    public partial class frmDangKiVe : DevExpress.XtraEditors.XtraForm
    {
        NHANVIEN_BUS _NHANVIEN_BUS = null;
        DOITAC_BUS _DOITAC_BUS = null;
        DOTPHATHANH_BUS _DOTPHATHANH_BUS = null;
        LOAIVE_BUS _LOAIVE_BUS = null;
        CT_PHIEUDANGKYVE_BUS _CT_PHIEUDANGKYVE_BUS = null;
        PHIEUDANGKYVE_BUS _PHIEUDANGKYVE_BUS = null;
        string _MaDotPhatHanh = "", _MaLoaiVe = "", _MaCongTy = "", _MaPhieuDangKy = "";
        int _SoVeDangKiToiDa, _SoVeDangKy;
        List<string> _ListMaCongTy, _ListMaDotPhatHanh, _ListLoaiVe; // dùng để lưu những bộ ba đã có trong chi tiết đợt phát hành
        public frmDangKiVe()
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

        private void frmDangKiVe_Load(object sender, EventArgs e)
        {
            var _ListAgency = _DOITAC_BUS.SelectAgency();
            cbTenDoiTac.DataSource = _ListAgency;
            cbTenDoiTac.DisplayMember = "Ten";
            cbTenDoiTac.ValueMember = "MaDoiTac";

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

        private void gvBASE_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gvBASE.FocusedColumn.FieldName == "MaCongTy")
            {
                _MaCongTy = e.Value.ToString();
                var _ListDotPhatHanh = _DOTPHATHANH_BUS.Select();
                repositoryItemLookUpEdit2.DataSource = _ListDotPhatHanh;
                repositoryItemLookUpEdit2.DisplayMember = "NgayPhatHanh";
                repositoryItemLookUpEdit2.ValueMember = "MaDotPhatHanh";
                gvBASE.Columns["MaDotPhatHanh"].ColumnEdit = repositoryItemLookUpEdit2;


                var _ListLoaiVe = _LOAIVE_BUS.Select_Con_Company(e.Value.ToString());
                repositoryItemLookUpEdit3.DataSource = _ListLoaiVe;
                repositoryItemLookUpEdit3.DisplayMember = "MenhGia";
                repositoryItemLookUpEdit3.ValueMember = "MaLoaiVe";
                gvBASE.Columns["MaLoaiVe"].ColumnEdit = repositoryItemLookUpEdit3;
            }

            if (gvBASE.FocusedColumn.FieldName == "MaDotPhatHanh")
            {
                _MaDotPhatHanh = e.Value.ToString();
            }

            if (gvBASE.FocusedColumn.FieldName == "MaLoaiVe")
            {
                _MaLoaiVe = e.Value.ToString();
                _SoVeDangKiToiDa = _CT_PHIEUDANGKYVE_BUS.GetAmountOfMaxRegisterTicket(cbTenDoiTac.SelectedValue.ToString(),
                                                                                            _MaCongTy,
                                                                                            _MaDotPhatHanh,
                                                                                            _MaLoaiVe);
                gvBASE.SetRowCellValue(gvBASE.FocusedRowHandle, gvBASE.Columns["SoVeDangKyToiDa"], _SoVeDangKiToiDa);
            }

            if (gvBASE.FocusedColumn.FieldName == "SoVeDangKy")
            {
                _SoVeDangKy = 0;
                if (!Int32.TryParse(e.Value as String, out _SoVeDangKy))
                {
                    e.Valid = false;
                    e.ErrorText = "Số vé đăng ký là số nguyên dương";
                }
                else
                {
                    if (_SoVeDangKy > _SoVeDangKiToiDa)
                    {
                        e.Valid = false;
                        e.ErrorText = "Số vé đăng ký không lớn hơn số vé đăng ký tối đa";
                    }
                }
            }
        }

        void Load_gvBase()
        {
            gvBASE.Columns.Clear(); // clear dong vua them
            var _ListCTPhieuDangKy = _CT_PHIEUDANGKYVE_BUS.Select(_MaPhieuDangKy);
            bindingSource1.DataSource = _ListCTPhieuDangKy;
            int tongsove = 0;
            foreach(var item in _ListCTPhieuDangKy)
            {
                tongsove += int.Parse(item.SoVeDangKy.ToString());
            }
            txtTongSoVe.Text = tongsove.ToString();

            var _ListCompany = _DOITAC_BUS.SelectCompany().Where(x => !_ListMaCongTy.Any(x1=>x1.ToString() == x.MaDoiTac));
            repositoryItemLookUpEdit1.DataSource = _ListCompany;
            repositoryItemLookUpEdit1.DisplayMember = "Ten";
            repositoryItemLookUpEdit1.ValueMember = "MaDoiTac";
            gvBASE.Columns["MaCongTy"].ColumnEdit = repositoryItemLookUpEdit1;
            gvBASE.Columns["MaChiTietPhieuDangKy"].Visible = false;
            gvBASE.Columns["MaPhieuDangKy"].Visible = false;


        }
        private void gcBASE_Load(object sender, EventArgs e)
        {
            Load_gvBase();
        }

        void Add_List(string macongty, string madotphathanh, string maloaive)
        {
            _ListMaCongTy.Add(macongty);
            _ListMaDotPhatHanh.Add(madotphathanh);
            _ListLoaiVe.Add(maloaive);
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_MaPhieuDangKy != "")
            {
                _CT_PHIEUDANGKYVE_BUS.Insert(_MaPhieuDangKy, _MaCongTy, _MaDotPhatHanh, _MaLoaiVe, _SoVeDangKiToiDa.ToString(), _SoVeDangKy.ToString());
            }
            else
            {
                string _Error = _PHIEUDANGKYVE_BUS.CheckErrorBeforeInsert(cbTenDoiTac.SelectedValue.ToString(),
                                                            lkNguoiLap.GetColumnValue("MaNhanVien").ToString(),
                                                            deNgayLap.SelectedText,
                                                            txtTongSoVe.Text);
                if (_Error == "")
                {
                    _MaPhieuDangKy = _PHIEUDANGKYVE_BUS.Insert(cbTenDoiTac.SelectedValue.ToString(),
                                                           lkNguoiLap.GetColumnValue("MaNhanVien").ToString(),
                                                           deNgayLap.SelectedText,
                                                           txtTongSoVe.Text);
                    _CT_PHIEUDANGKYVE_BUS.Insert(_MaPhieuDangKy, _MaCongTy, _MaDotPhatHanh, _MaLoaiVe, _SoVeDangKiToiDa.ToString(), _SoVeDangKy.ToString());
                }
                else
                {
                    MessageBox.Show(_Error, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Load_gvBase();
        }

        private void gcBASE_Validating(object sender, CancelEventArgs e)
        {

        }

        private void gvBASE_InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            if (gvBASE.FocusedColumn.FieldName == "SoVeDangKy")
            {
                if (e.Value as String == "")
                {
                    e.ErrorText = "Số vé đăng ký không được rống";
                }
            }
        }
    }
}