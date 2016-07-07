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
    public partial class frmHoSoDoiTac : DevExpress.XtraEditors.XtraForm
    {
        DOITAC_BUS _DOITAC_BUS = null;
        string _MaLoaiDoiTac = "LDT0000001";
        int _Type = 0; //0: thêm, 1: sửa
        string _MaDoiTac = "";
        public frmHoSoDoiTac()
        {
            InitializeComponent();
            _DOITAC_BUS = new DOITAC_BUS();
            gcBASE.DataSource = _DOITAC_BUS.Select();
            gvBASE.BestFitColumns();
        }

        private void rbtnLoaiDoiTac_Click(object sender, EventArgs e)
        {
            if (rbtnLoaiDoiTac.SelectedIndex == 0)
            {
                _MaLoaiDoiTac = "LDT0000001";
            }
            else
            {
                _MaLoaiDoiTac = "LDT0000002";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _Type = 0;
            _MaDoiTac = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtSoDienThoai.Text = "";
            txtTenDoiTac.Text = "";
            txtDiaChi.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtSoDienThoai.ReadOnly = false;
            txtTenDoiTac.ReadOnly = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _Type = 1;
            txtDiaChi.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtSoDienThoai.ReadOnly = false;
            txtTenDoiTac.ReadOnly = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_Type == 0)
            {
                string _Error = _DOITAC_BUS.Insert_Update(_MaLoaiDoiTac, txtTenDoiTac.Text, txtDiaChi.Text, txtSoDienThoai.Text, txtEmail.Text);
                if (_Error == "")
                {
                    XtraMessageBox.Show("Thêm thành công.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gcBASE.DataSource = _DOITAC_BUS.Select();
                }
                else
                {
                    XtraMessageBox.Show(_Error, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string _Error = _DOITAC_BUS.Insert_Update(_MaLoaiDoiTac, txtTenDoiTac.Text, txtDiaChi.Text, txtSoDienThoai.Text, txtEmail.Text, _MaDoiTac);
                if (_Error == "")
                {
                    XtraMessageBox.Show("Cập nhật thành công.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gcBASE.DataSource = _DOITAC_BUS.Select();
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
            txtTenDoiTac.ReadOnly = true;
            _MaDoiTac = gvBASE.GetRowCellValue(gvBASE.FocusedRowHandle, gvBASE.Columns["MaDoiTac"]).ToString();
            txtTenDoiTac.Text = _DOITAC_BUS.GetTenDoiTac(gvBASE.GetRowCellValue(gvBASE.FocusedRowHandle, gvBASE.Columns["MaDoiTac"]).ToString());
            txtSoDienThoai.Text = gvBASE.GetRowCellValue(gvBASE.FocusedRowHandle, gvBASE.Columns["SDT"]).ToString();
            txtEmail.Text = gvBASE.GetRowCellValue(gvBASE.FocusedRowHandle, gvBASE.Columns["Email"]).ToString();
            txtDiaChi.Text = gvBASE.GetRowCellValue(gvBASE.FocusedRowHandle, gvBASE.Columns["DiaChi"]).ToString();
        }
    }
}