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
    public partial class frmPhieuThanhToan : DevExpress.XtraEditors.XtraForm
    {
        DOITAC_BUS _DOITAC_BUS = null;
        NHANVIEN_BUS _NHANVIEN_BUS = null;
        DOTPHATHANH_BUS _DOTPHATHANH_BUS = null;
        PHIEUTHANHTOAN_BUS _PHIEUTHANHTOAN_BUS = null;
        public frmPhieuThanhToan()
        {
            InitializeComponent();
            _DOITAC_BUS = new DOITAC_BUS();
            _NHANVIEN_BUS = new NHANVIEN_BUS();
            _DOTPHATHANH_BUS = new DOTPHATHANH_BUS();
            _PHIEUTHANHTOAN_BUS = new PHIEUTHANHTOAN_BUS();
        }

        private void frmPhieuThanhToan_Load(object sender, EventArgs e)
        {
            #region #Lookup tên đối tác
            var ListCompany = _DOITAC_BUS.SelectCompany();
            lkTenDoiTac.Properties.DataSource = ListCompany;
            lkTenDoiTac.Properties.DisplayMember = "Ten";
            lkTenDoiTac.Properties.ValueMember = "MaDoiTac";

            lkTenDoiTac.Properties.ForceInitialize();
            lkTenDoiTac.Properties.PopulateColumns();

            lkTenDoiTac.Properties.Columns["MaDoiTac"].Visible = false;
            lkTenDoiTac.Properties.Columns["MaLoaiDoiTac"].Visible = false;
            lkTenDoiTac.Properties.Columns["TiLeHoaHong"].Visible = false;
            lkTenDoiTac.Properties.Columns["TiLeTieuThu"].Visible = false;
            lkTenDoiTac.Properties.Columns["CongNo"].Visible = false;
            #endregion

            #region #Lookup đợt phát hành
            var ListDotPhatHanh = _DOTPHATHANH_BUS.Select();
            lkDotPhatHanh.Properties.DataSource = ListDotPhatHanh;
            lkDotPhatHanh.Properties.DisplayMember = "MaDotPhatHanh";
            lkDotPhatHanh.Properties.ValueMember = "MaDotPhatHanh";

            lkDotPhatHanh.Properties.ForceInitialize();
            lkDotPhatHanh.Properties.PopulateColumns();

            lkDotPhatHanh.Properties.Columns["MaCongTy"].Visible = false;
            #endregion

            #region #Lookup nhân viên
            var ListNhanVien = _NHANVIEN_BUS.Select();
            lkNguoiLap.Properties.DataSource = ListNhanVien;
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

        private void rbtnLoaiDoiTac_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbtnLoaiDoiTac.SelectedIndex == 0)
            {
                var ListCompany = _DOITAC_BUS.SelectCompany();
                lkTenDoiTac.Properties.DataSource = ListCompany;
            }
            else
            {
                var ListAgency = _DOITAC_BUS.SelectAgency();
                lkTenDoiTac.Properties.DataSource = ListAgency;
            }
        }

        private void lkTenDoiTac_EditValueChanged(object sender, EventArgs e)
        {
            txtTienNo.Text = _DOITAC_BUS.GetDebt(lkTenDoiTac.GetColumnValue("MaDoiTac").ToString()).ToString();
        }

        private void txtTienTra_EditValueChanged(object sender, EventArgs e)
        {
            if (txtTienTra.Text.Length > 0)
            {
                try
                {
                    Convert.ToInt32(txtTienTra.Text);
                    txtTienConLai.Text = (Convert.ToInt32(txtTienNo.Text) - Convert.ToInt32(txtTienTra.Text)).ToString();
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Số tiền nhập vào không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                txtTienConLai.Text = "0";
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           string Error =  _PHIEUTHANHTOAN_BUS.Insert(lkTenDoiTac.GetColumnValue("MaDoiTac").ToString(),
                lkDotPhatHanh.GetColumnValue("MaDotPhatHanh").ToString(),
                txtTienNo.Text,
                txtTienTra.Text,
                txtTienConLai.Text,
                deNgayLap.Text,
                lkNguoiLap.GetColumnValue("MaNhanVien").ToString(),
                txtTenNguoiNop.Text,
                txtSoDienThoai.Text,
                txtDiaChi.Text,
                txtEmail.Text
                );
            if(Error != "")
            {
                MessageBox.Show(Error);
            }
            else
            {
                MessageBox.Show("Thêm thành công");
            }
        }
    }
}