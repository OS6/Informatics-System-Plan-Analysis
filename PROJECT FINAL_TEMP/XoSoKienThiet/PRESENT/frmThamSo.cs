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

namespace XoSoKienThiet.PRESENT
{
    public partial class frmThamSo : DevExpress.XtraEditors.XtraForm
    {
        THAMSO_BUS _THAMSO_BUS = null;
        public frmThamSo()
        {
            InitializeComponent();
            _THAMSO_BUS = new THAMSO_BUS();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtTileTieuThuDat.ReadOnly = false;
            txtTiLeTienTraItNhat.ReadOnly = false;
            txtTiLeHoaHongLanDau.ReadOnly = false;
            txtTiLeHoaHongTang.ReadOnly = false;
            txtTiLeHoaHongGiam.ReadOnly = false;
            txtHanTraVe.ReadOnly = false;
            txtSoNgayNhanGiai.ReadOnly = false;
            txtSoDotGanDay.ReadOnly = false;
            txtChietKhauGiaTriGiaTang.ReadOnly = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string Error = _THAMSO_BUS.Update(txtTileTieuThuDat.Text,
                                                txtTiLeTienTraItNhat.Text,
                                                txtTiLeHoaHongLanDau.Text,
                                                txtTiLeHoaHongTang.Text,
                                                txtTiLeHoaHongGiam.Text,
                                                txtHanTraVe.Text,
                                                txtSoNgayNhanGiai.Text,
                                                txtSoDotGanDay.Text,
                                                txtChietKhauGiaTriGiaTang.Text);
            if(Error == "")
            {
                XtraMessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var item = _THAMSO_BUS.Select();
                txtTileTieuThuDat.Text = item.TiLeTieuThuDat.ToString();
                txtTiLeTienTraItNhat.Text = item.TiLeTienItNhatTra.ToString();
                txtTiLeHoaHongLanDau.Text = item.TiLeHoaHongLanDau.ToString();
                txtTiLeHoaHongTang.Text = item.TiLeHoaHongTang.ToString();
                txtTiLeHoaHongGiam.Text = item.TiLeHoaHongGiam.ToString();
                txtHanTraVe.Text = item.HanTraVe.ToString();
                txtSoNgayNhanGiai.Text = item.SoNgayNhanGiai.ToString();
                txtSoDotGanDay.Text = item.SoDotGanDay.ToString();
                txtChietKhauGiaTriGiaTang.Text = item.ChietKhauGiaTriGiaTang.ToString();
            }
            else
            {
                XtraMessageBox.Show(Error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtTileTieuThuDat.ReadOnly = true;
            txtTiLeTienTraItNhat.ReadOnly = true;
            txtTiLeHoaHongLanDau.ReadOnly = true;
            txtTiLeHoaHongTang.ReadOnly = true;
            txtTiLeHoaHongGiam.ReadOnly = true;
            txtHanTraVe.ReadOnly = true;
            txtSoNgayNhanGiai.ReadOnly = true;
            txtSoDotGanDay.ReadOnly = true;
            txtChietKhauGiaTriGiaTang.ReadOnly = true;
        }

        private void frmThamSo_Load(object sender, EventArgs e)
        {
            var item = _THAMSO_BUS.Select();
            txtTileTieuThuDat.Text = item.TiLeTieuThuDat.ToString();
            txtTiLeTienTraItNhat.Text = item.TiLeTienItNhatTra.ToString();
            txtTiLeHoaHongLanDau.Text = item.TiLeHoaHongLanDau.ToString();
            txtTiLeHoaHongTang.Text = item.TiLeHoaHongTang.ToString();
            txtTiLeHoaHongGiam.Text = item.TiLeHoaHongGiam.ToString();
            txtHanTraVe.Text = item.HanTraVe.ToString();
            txtSoNgayNhanGiai.Text = item.SoNgayNhanGiai.ToString();
            txtSoDotGanDay.Text = item.SoDotGanDay.ToString();
            txtChietKhauGiaTriGiaTang.Text = item.ChietKhauGiaTriGiaTang.ToString();
        }
    }
}