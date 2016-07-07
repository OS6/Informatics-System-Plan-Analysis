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
    public partial class frmCapNhatTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        DANGNHAP_BUS _DANGNHAP_BUS = null;
        public frmCapNhatTaiKhoan()
        {
            InitializeComponent();
            _DANGNHAP_BUS = new DANGNHAP_BUS();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMatKhauCu.Text == "" || txtMatKhauMoi.Text == "" || txtNhapLaiMatKhau.Text == "")
            {
                lblNoti.ForeColor = Color.Red;
                lblNoti.Text = "Chưa nhập đầy đủ thông tin.";
            }
            else
            {
                if (txtMatKhauCu.Text != TAIKHOAN.Pass)
                {
                    lblNoti.ForeColor = Color.Red;
                    lblNoti.Text = "Mật khẩu cũ sai.";
                }
                else
                {
                    if (txtMatKhauMoi.Text != txtNhapLaiMatKhau.Text)
                    {
                        lblNoti.ForeColor = Color.Red;
                        lblNoti.Text = "Nhập lại mật khẩu không đúng.";
                    }
                    else
                    {
                        if (txtMatKhauCu.Text == TAIKHOAN.Pass && txtMatKhauMoi.Text == txtNhapLaiMatKhau.Text)
                        {
                            lblNoti.ForeColor = Color.Green;
                            lblNoti.Text = "Cập nhật mật khẩu thành công.";
                            _DANGNHAP_BUS.Update(TAIKHOAN.ID,  txtMatKhauMoi.Text);
                        }
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}