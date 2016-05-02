using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XoSoKienThiet.BUS;

namespace XoSoKienThiet.Presentation
{
    public partial class frmPHIEUNHANVE : Form
    {
        DOITAC_BUS _DOITAC_BUS = null;
        LOAIVE_BUS _LOAIVE_BUS = null;
        NHANVIEN_BUS _NHANVIEN_BUS = null;
        PHIEUNHANVE_BUS _PHIEUNHANVE_BUS = null;
        public frmPHIEUNHANVE()
        {
            InitializeComponent();
            _DOITAC_BUS = new DOITAC_BUS();
            _LOAIVE_BUS = new LOAIVE_BUS();
            _NHANVIEN_BUS = new NHANVIEN_BUS();
            _PHIEUNHANVE_BUS = new PHIEUNHANVE_BUS();
        }
        private void rbtDaiLy_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtDaiLy.Checked == true)
            {
                lbDoiTac.Text = "Đại lý";
            }
            else
            {
                lbDoiTac.Text = "Đối tác";
            }
            Load_cbDoiTac();
        }

        public void Load_cbDoiTac()
        {
            cbDoiTac.ResetText();
            if(rbtCongTy.Checked == true)
            {
                cbDoiTac.DataSource = _DOITAC_BUS.SelectCompany().Select(model => model.Ten).ToList();
            }
            if(rbtDaiLy.Checked == true)
            {
                cbDoiTac.DataSource = _DOITAC_BUS.SelectAgency().Select(model => model.Ten).ToList();
            }
        }
        public void Load_cbNhanVien()
        {
            cbNguoiLap.DataSource = _NHANVIEN_BUS.Select().Select(model => model.MaNhanVien).ToList();
        }
        private void rbtCongTy_CheckedChanged(object sender, EventArgs e)
        {
            cbDoiTac.ResetText();
            if (rbtCongTy.Checked == true)
            {
                lbDoiTac.Text = "Công ty";
            }
            else
            {
                lbDoiTac.Text = "Đối tác";
            }
            Load_cbDoiTac();
        }

        public void Load_dgvDanhSachLoaiVe()
        {
            DataGridViewComboBoxColumn cbCongTy = new DataGridViewComboBoxColumn();
            cbCongTy.DataSource = _DOITAC_BUS.Select().Select(model => model.Ten).ToList();
            cbCongTy.HeaderText = "Công ty";

            DataGridViewComboBoxColumn cbDotPhatHanh = new DataGridViewComboBoxColumn();
            cbDotPhatHanh.HeaderText = "Đợt phát hành";

            DataGridViewComboBoxColumn cbLoaiVe = new DataGridViewComboBoxColumn();
            cbLoaiVe.DataSource = _LOAIVE_BUS.Select().Select(model => model.MenhGia).ToList();
            cbLoaiVe.HeaderText = "Loại vé";

            dgvDanhSachLoaiVe.Columns.Insert(1, cbCongTy);
            dgvDanhSachLoaiVe.Columns.Insert(2, cbDotPhatHanh);
            dgvDanhSachLoaiVe.Columns.Insert(3, cbLoaiVe);
        }
        private void frmPHIEUNHANVE_Load(object sender, EventArgs e)
        {
            Load_cbNhanVien();
            Load_dgvDanhSachLoaiVe();
            // xu ly cap nhat tu dong phan chi tiet ve dang ki, ve nhan ???
        }

        private void btIns_Click(object sender, EventArgs e)
        {
            string _MaPhieuNhanVe = _PHIEUNHANVE_BUS.Insert(
                cbDoiTac.Text,
                txtTongSoTien.Text,
                dtpNgayLap.Text,
                cbNguoiLap.Text,
                txtTongTien.Text);
        }
    }
}
