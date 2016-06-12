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
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {

        DANGNHAP_BUS _DANGNHAP_BUS = null;

        public frmDangNhap()
        {
            InitializeComponent();
            _DANGNHAP_BUS = new DANGNHAP_BUS();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            var result = _DANGNHAP_BUS.GetMaBoPhan(txtTaiKhoan.Text, txtMatKhau.Text);
            if (result != null)
            {
                this.Hide();
                frmMain F = new frmMain(result.TenNhanVien.TrimEnd(), result.MaBoPhan.TrimEnd(), result.TenBoPhan.TrimEnd());
                F.Show();
                TAIKHOAN.Username = txtTaiKhoan.Text;
                TAIKHOAN.Pass = txtMatKhau.Text;
                TAIKHOAN.ID = result.ID;
            }
            else
            {
                lblTinhTrang.Text = "Tài khoản hoặc mật khẩu sai.";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTaiKhoan_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            lblTinhTrang.Text = "";
        }

        private void txtMatKhau_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            lblTinhTrang.Text = "";
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter))
                btnDangNhap_Click(sender,e);
        }
    }
    public static class TAIKHOAN
    {
        public static string Username { get; set; }
        public static string Pass { get; set; }
        public static int ID { get; set; }

    }
}