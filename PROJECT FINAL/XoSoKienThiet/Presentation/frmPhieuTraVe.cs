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

namespace XoSoKienThiet.Presentation
{
    public partial class frmPhieuTraVe : DevExpress.XtraEditors.XtraForm
    {
        DOITAC_BUS _DOITAC_BUS = null;
        NHANVIEN_BUS _NHANVIEN_BUS = null;
        public frmPhieuTraVe()
        {
            InitializeComponent();
            _DOITAC_BUS = new DOITAC_BUS();
            _NHANVIEN_BUS = new NHANVIEN_BUS();
        }

        private void frmPhieuTraVe_Load(object sender, EventArgs e)
        {
            #region Init lookup tên đối tác
            var _ListCompany = _DOITAC_BUS.SelectCompany();
            lkMaPhieuNhanVe.Properties.DataSource = _ListCompany;

            lkMaPhieuNhanVe.Properties.DisplayMember = "Ten";
            lkMaPhieuNhanVe.Properties.ValueMember = "MaDoiTac";

            //tùy chỉnh lookup - hiển thị mã, tên, địa chỉ, sdt
            lkMaPhieuNhanVe.Properties.ForceInitialize();
            lkMaPhieuNhanVe.Properties.PopulateColumns();

            lkMaPhieuNhanVe.Properties.Columns["MaLoaiDoiTac"].Visible = false;
            lkMaPhieuNhanVe.Properties.Columns["Email"].Visible = false;
            lkMaPhieuNhanVe.Properties.Columns["TiLeHoaHong"].Visible = false;
            lkMaPhieuNhanVe.Properties.Columns["TiLeTieuThu"].Visible = false;
            lkMaPhieuNhanVe.Properties.Columns["CongNo"].Visible = false;
            #endregion

            #region Init lookup nhân viên
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
            #endregion

        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

    }
}