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
namespace XoSoKienThiet.PRESENT
{
    public partial class frmTiepNhanNhanVien : DevExpress.XtraEditors.XtraForm
    {
        BOPHAN_BUS _BOPHAN_BUS = null;
        CHUCVU_BUS _CHUCVU_BUS = null;
        NHANVIEN_BUS _NHANVIEN_BUS = null;
        COCAUTOCHUC_BUS _COCAUTOCHUC_BUS = null;
        string _MaNhanVien = "";
        int _Type = 0; //0: thêm, 1: sửa
        public frmTiepNhanNhanVien()
        {
            InitializeComponent();
            _BOPHAN_BUS = new BOPHAN_BUS();
            _CHUCVU_BUS = new CHUCVU_BUS();
            _COCAUTOCHUC_BUS = new COCAUTOCHUC_BUS();
            _NHANVIEN_BUS = new NHANVIEN_BUS();
            gcBASE.DataSource = _NHANVIEN_BUS.SelectView();
            gvBASE.BestFitColumns();
        }

        private void frmTiepNhanNhanVien_Load(object sender, EventArgs e)
        {
            var ListBoPhan = _BOPHAN_BUS.Select();
            var ListChucVu = _CHUCVU_BUS.Select();

            lkBoPhan.Properties.DataSource = ListBoPhan;
            lkBoPhan.Properties.DisplayMember = "TenBoPhan";

            lkBoPhan.Properties.ForceInitialize();
            lkBoPhan.Properties.PopulateColumns();

            lkBoPhan.Properties.Columns["MaBoPhan"].Visible = false;
            lkBoPhan.Properties.Columns["MaQuanLy"].Visible = false;

            lkChucVu.Properties.DataSource = ListChucVu;
            lkChucVu.Properties.DisplayMember = "TenChucVu";

            lkChucVu.Properties.ForceInitialize();
            lkChucVu.Properties.PopulateColumns();

            lkChucVu.Properties.Columns["MaChucVu"].Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _Type = 0;
            _MaNhanVien = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtSoDienThoai.Text = "";
            txtTenNhanVien.Text = "";
            lkBoPhan.EditValue = "";
            lkChucVu.EditValue = "";
            txtDiaChi.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtSoDienThoai.ReadOnly = false;
            txtTenNhanVien.ReadOnly = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _Type = 1;
            txtDiaChi.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtSoDienThoai.ReadOnly = false;
            txtTenNhanVien.ReadOnly = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string MaChucVu = "", MaBoPhan = "", MaCoCauToChuc = "";
            try
            {
                MaBoPhan = lkBoPhan.GetColumnValue("MaBoPhan").ToString();
            }
            catch (Exception) { }
            try
            {
                MaChucVu = lkChucVu.GetColumnValue("MaChucVu").ToString();
            }
            catch (Exception) { }
            try
            {
                MaCoCauToChuc = _COCAUTOCHUC_BUS.GetID(MaBoPhan, MaChucVu);
            }
            catch (Exception) { }
            if (_Type == 0)
            {
                string Error = _NHANVIEN_BUS.Insert_Update(MaCoCauToChuc, txtTenNhanVien.Text, txtSoDienThoai.Text, txtDiaChi.Text, txtEmail.Text);
                if (Error == "")
                {
                    XtraMessageBox.Show("Thêm thành công.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gcBASE.DataSource = _NHANVIEN_BUS.SelectView();
                }
                else
                {
                    XtraMessageBox.Show(Error, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string _Error = _NHANVIEN_BUS.Insert_Update(MaCoCauToChuc, txtTenNhanVien.Text, txtSoDienThoai.Text, txtDiaChi.Text, txtEmail.Text, _MaNhanVien);
                if (_Error == "")
                {
                    XtraMessageBox.Show("Cập nhật thành công.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gcBASE.DataSource = _NHANVIEN_BUS.SelectView();
                }
                else
                {
                    XtraMessageBox.Show(_Error, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void gvBASE_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            txtDiaChi.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtSoDienThoai.ReadOnly = true;
            txtTenNhanVien.ReadOnly = true;
            _MaNhanVien = gvBASE.GetRowCellValue(gvBASE.FocusedRowHandle, gvBASE.Columns["MaNhanVien"]).ToString();
            txtTenNhanVien.Text = gvBASE.GetRowCellValue(gvBASE.FocusedRowHandle, gvBASE.Columns["Ten"]).ToString();
            txtSoDienThoai.Text = gvBASE.GetRowCellValue(gvBASE.FocusedRowHandle, gvBASE.Columns["SDT"]).ToString();
            txtEmail.Text = gvBASE.GetRowCellValue(gvBASE.FocusedRowHandle, gvBASE.Columns["Email"]).ToString();
            txtDiaChi.Text = gvBASE.GetRowCellValue(gvBASE.FocusedRowHandle, gvBASE.Columns["DiaChi"]).ToString();
            lkChucVu.Text = gvBASE.GetRowCellValue(gvBASE.FocusedRowHandle, gvBASE.Columns["TenChucVu"]).ToString();
            lkBoPhan.Text = gvBASE.GetRowCellValue(gvBASE.FocusedRowHandle, gvBASE.Columns["TenBoPhan"]).ToString();
        }
    }
}