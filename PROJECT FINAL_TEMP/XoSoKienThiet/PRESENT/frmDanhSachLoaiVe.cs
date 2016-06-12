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
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.PRESENT
{
    public partial class frmDanhSachLoaiVe : DevExpress.XtraEditors.XtraForm
    {
        DOITAC_BUS _DOITAC_BUS = null;
        LOAIVE_BUS _LOAIVE_BUS = null;
        string _MaCongTy = "";
        string _MaLoaiVe = "";
        int _Type = 0; //0: thêm, 1: sửa
        public frmDanhSachLoaiVe()
        {
            InitializeComponent();
            _DOITAC_BUS = new DOITAC_BUS();
            _LOAIVE_BUS = new LOAIVE_BUS();
        }

        private void lkTenCongTy_EditValueChanged(object sender, EventArgs e)
        {
            _MaCongTy = lkTenCongTy.GetColumnValue("MaDoiTac").ToString();
            gcBASE.DataSource = _LOAIVE_BUS.Select_Con_Company(_MaCongTy);
        }

        private void frmDanhSachLoaiVe_Load(object sender, EventArgs e)
        {
            var _ListCompany = _DOITAC_BUS.SelectCompany();
            lkTenCongTy.Properties.DataSource = _ListCompany;
            lkTenCongTy.Properties.DisplayMember = "Ten";

            lkTenCongTy.Properties.ForceInitialize();
            lkTenCongTy.Properties.PopulateColumns();

            lkTenCongTy.Properties.Columns["MaDoiTac"].Visible = false;
            lkTenCongTy.Properties.Columns["MaLoaiDoiTac"].Visible = false;
            lkTenCongTy.Properties.Columns["TiLeHoaHong"].Visible = false;
            lkTenCongTy.Properties.Columns["TiLeTieuThu"].Visible = false;
            lkTenCongTy.Properties.Columns["CongNo"].Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _Type = 0;
            txtMenhGiaVe.Text = "";
            txtMenhGiaVe.ReadOnly = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _Type = 1;
            txtMenhGiaVe.ReadOnly = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                _MaCongTy = lkTenCongTy.GetColumnValue("MaDoiTac").ToString();
            }
            catch (Exception)
            {
            }
            if (_Type == 0)
            {
                string Error = _LOAIVE_BUS.Insert_Update(_MaCongTy, txtMenhGiaVe.Text);
                if (Error == "")
                {
                    XtraMessageBox.Show("Thêm thành công.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gcBASE.DataSource = _LOAIVE_BUS.Select_Con_Company(_MaCongTy);
                }
                else
                {
                    XtraMessageBox.Show(Error, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string Error = _LOAIVE_BUS.Insert_Update(_MaCongTy, txtMenhGiaVe.Text, _MaLoaiVe);
                if (Error == "")
                {
                    XtraMessageBox.Show("Cập nhật thành công.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gcBASE.DataSource = _LOAIVE_BUS.Select_Con_Company(_MaCongTy);
                }
                else
                {
                    XtraMessageBox.Show(Error, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void gvBASE_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            txtMenhGiaVe.ReadOnly = true;
            _MaLoaiVe = gvBASE.GetRowCellValue(gvBASE.FocusedRowHandle, gvBASE.Columns["MaLoaiVe"]).ToString();
            txtMenhGiaVe.Text = _LOAIVE_BUS.GetPrice(_MaLoaiVe).ToString();
        }
    }
}