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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.EditForm.Helpers.Controls;

namespace XoSoKienThiet.PRESENT
{
    public partial class frmCoCauGiaiThuong : DevExpress.XtraEditors.XtraForm
    {
        LOAIVE_BUS _LOAIVE_BUS = null;
        GIAITHUONG_BUS _GIAITHUONG_BUS = null;
        string _MaLoaiVe = "";
        string _MaGiaiThuong = "";
        int _Type = 0;// 0-them, 1-sua
        public frmCoCauGiaiThuong()
        {
            InitializeComponent();
            _LOAIVE_BUS = new LOAIVE_BUS();
            _GIAITHUONG_BUS = new GIAITHUONG_BUS();
        }

        private void frmCoCauGiaiThuong_Load(object sender, EventArgs e)
        {
            var _ListLoaiVe = _LOAIVE_BUS.SelectYourCompany();
            lkLoaiVe.Properties.DataSource = _ListLoaiVe;
            lkLoaiVe.Properties.DisplayMember = "MenhGia";
            lkLoaiVe.Properties.ValueMember = "MaLoaiVe";

            lkLoaiVe.Properties.ForceInitialize();
            lkLoaiVe.Properties.PopulateColumns();

            lkLoaiVe.Properties.Columns["MaCongTy"].Visible = false;
        }
        private void lkLoaiVe_EditValueChanged(object sender, EventArgs e)
        {
            _MaLoaiVe = lkLoaiVe.GetColumnValue("MaLoaiVe").ToString();
            gcBASE.DataSource = _GIAITHUONG_BUS.Select(_MaLoaiVe);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            _Type = 0;
            txtSoGiai.ReadOnly = false;
            txtSoTienTrung.ReadOnly = false;
            txtTenGiai.ReadOnly = false;
            btnLuu.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _Type = 1;
            txtSoGiai.ReadOnly = false;
            txtSoTienTrung.ReadOnly = false;
            txtTenGiai.ReadOnly = false;
            btnLuu.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_Type == 0)
            {
                string Error = _GIAITHUONG_BUS.Insert_Update(_MaLoaiVe, txtTenGiai.Text, txtSoTienTrung.Text, txtSoGiai.Text);
                if (Error == "")
                {
                    XtraMessageBox.Show("Thêm thành công.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gcBASE.DataSource = _GIAITHUONG_BUS.Select(_MaLoaiVe);
                }
                else
                {
                    XtraMessageBox.Show(Error, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string Error = _GIAITHUONG_BUS.Insert_Update(_MaLoaiVe, txtTenGiai.Text, txtSoTienTrung.Text, txtSoGiai.Text, _MaGiaiThuong);
                if (Error == "")
                {
                    XtraMessageBox.Show("Cập nhật thành công.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gcBASE.DataSource = _GIAITHUONG_BUS.Select(_MaLoaiVe);
                }
                else
                {
                    XtraMessageBox.Show(Error, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void gvBASE_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            txtSoGiai.ReadOnly = true;
            txtSoTienTrung.ReadOnly = true;
            txtTenGiai.ReadOnly = true;
            btnLuu.Enabled = false;
            _MaGiaiThuong = gvBASE.GetRowCellValue(gvBASE.FocusedRowHandle, gvBASE.Columns["MaGiaiThuong"]).ToString();
            txtTenGiai.Text = gvBASE.GetRowCellValue(gvBASE.FocusedRowHandle, gvBASE.Columns["Ten"]).ToString();
            txtSoGiai.Text = gvBASE.GetRowCellValue(gvBASE.FocusedRowHandle, gvBASE.Columns["SoGiai"]).ToString();
            txtSoTienTrung.Text = gvBASE.GetRowCellValue(gvBASE.FocusedRowHandle, gvBASE.Columns["SoTienTrung"]).ToString();
        }

    }
}