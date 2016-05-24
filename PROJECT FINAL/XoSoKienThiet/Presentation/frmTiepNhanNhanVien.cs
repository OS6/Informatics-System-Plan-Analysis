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
using System.Data.Entity;
namespace XoSoKienThiet.Presentation
{
    public partial class frmTiepNhanNhanVien : DevExpress.XtraEditors.XtraForm
    {
        BOPHAN_BUS _BOPHAN_BUS = null;
        CHUCVU_BUS _CHUCVU_BUS = null;
        NHANVIEN_BUS _NHANVIEN_BUS = null;
        COCAUTOCHUC_BUS _COCAUTOCHUC_BUS = null;
        public frmTiepNhanNhanVien()
        {
            InitializeComponent();
            _BOPHAN_BUS = new BOPHAN_BUS();
            _CHUCVU_BUS = new CHUCVU_BUS();
            _COCAUTOCHUC_BUS = new COCAUTOCHUC_BUS();
            _NHANVIEN_BUS = new NHANVIEN_BUS();

            XoSoKienThiet.DTO.XoSoKienThietDbContext dbContext = new XoSoKienThiet.DTO.XoSoKienThietDbContext();
            dbContext.NHANVIENs.Load();
            bindingSource1.DataSource = dbContext.NHANVIENs.Local.ToBindingList();
        }

        private void frmTiepNhanNhanVien_Load(object sender, EventArgs e)
        {
            var _ListBoPhan = _BOPHAN_BUS.Select();
            var _ListChucVu = _CHUCVU_BUS.Select();

            lkBoPhan.Properties.DataSource = _ListBoPhan;
            lkBoPhan.Properties.DisplayMember = "TenBoPhan";

            lkBoPhan.Properties.ForceInitialize();
            lkBoPhan.Properties.PopulateColumns();

            lkBoPhan.Properties.Columns["MaBoPhan"].Visible = false;
            lkBoPhan.Properties.Columns["MaQuanLy"].Visible = false;

            lkChucVu.Properties.DataSource = _ListChucVu;
            lkChucVu.Properties.DisplayMember = "TenChucVu";

            lkChucVu.Properties.ForceInitialize();
            lkChucVu.Properties.PopulateColumns();

            lkChucVu.Properties.Columns["MaChucVu"].Visible = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string _MaBoPhan  = lkBoPhan.GetColumnValue("MaBoPhan").ToString();
            string _MaChucVu = lkChucVu.GetColumnValue("MaChucVu").ToString();

            string _MaCoCauToChuc = _COCAUTOCHUC_BUS.GetID(_MaBoPhan, _MaChucVu);
            string _Error = _NHANVIEN_BUS.Insert(_MaCoCauToChuc, txtTenNhanVien.Text, txtSoDienThoai.Text, txtDiaChi.Text, txtEmail.Text);
            if(_Error == "")
            {
                MessageBox.Show("Thêm nhân viên thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bindingSource1.DataSource = _NHANVIEN_BUS.Select();
            }
            else
            {
                MessageBox.Show(_Error, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}