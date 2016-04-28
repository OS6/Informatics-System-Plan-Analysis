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
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.Presentation
{
    public partial class frmDOITAC : Form
    {
        DOITAC_BUS _DOITAC_BUS = null;
        LOAIDOITAC_BUS _LOAIDOITAC_BUS = null;
        public frmDOITAC()
        {
            InitializeComponent();
            _DOITAC_BUS = new DOITAC_BUS();
            _LOAIDOITAC_BUS = new LOAIDOITAC_BUS();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string _MaLoaiDoiTac = _LOAIDOITAC_BUS.GetMaLoaiDoiTac(cbLoaiDoiTac.Text);
            string KT = _DOITAC_BUS.Insert_Update(_MaLoaiDoiTac,
                                        txtTen.Text,
                                        txtDiaChi.Text,
                                        txtSDT.Text,
                                        txtEmail.Text,
                                        txtTiLeHoaHong.Text);
            if (KT != "")
            {
                MessageBox.Show(KT, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Thêm thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Load_dGVDanhSachDoiTac();
            }
        }

       void Load_cbLoaiNguoiDung()
        {
            cbLoaiDoiTac.DataSource = _LOAIDOITAC_BUS.Select().Select(model => model.Ten).ToList();
        }

       private void frmDOITAC_Load(object sender, EventArgs e)
       {
           Load_cbLoaiNguoiDung();
           Load_dGVDanhSachDoiTac();
       }

        private void Load_dGVDanhSachDoiTac()
        {
            dGVDanhSachDoiTac.DataSource = _DOITAC_BUS.Select();
        }
       private void dGVDanhSachDoiTac_CellClick(object sender, DataGridViewCellEventArgs e)
       {
           

           txtMaDoiTac.Text = Convert.ToString(dGVDanhSachDoiTac.CurrentRow.Cells[0].Value);
           cbLoaiDoiTac.Text = _LOAIDOITAC_BUS.GetTenDoiTac((Convert.ToString(dGVDanhSachDoiTac.CurrentRow.Cells[1].Value)));
           txtTen.Text = Convert.ToString(dGVDanhSachDoiTac.CurrentRow.Cells[2].Value);
           txtEmail.Text = Convert.ToString(dGVDanhSachDoiTac.CurrentRow.Cells[3].Value);
           txtDiaChi.Text = Convert.ToString(dGVDanhSachDoiTac.CurrentRow.Cells[4].Value);
           txtSDT.Text = Convert.ToString(dGVDanhSachDoiTac.CurrentRow.Cells[5].Value);
           txtTiLeHoaHong.Text = Convert.ToString(dGVDanhSachDoiTac.CurrentRow.Cells[6].Value);
       }

       private void btSua_Click(object sender, EventArgs e)
       {
           string _MaLoaiDoiTac = _LOAIDOITAC_BUS.GetMaLoaiDoiTac(cbLoaiDoiTac.Text);
           string KT  = _DOITAC_BUS.Insert_Update(_MaLoaiDoiTac,
                                        txtTen.Text,
                                        txtDiaChi.Text,
                                        txtSDT.Text,
                                        txtEmail.Text,
                                        txtTiLeHoaHong.Text,
                                        txtMaDoiTac.Text);
           if (KT != "")
           {
               MessageBox.Show(KT, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           else
           {
               MessageBox.Show("Sửa thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
               Load_dGVDanhSachDoiTac();
           }
       }

       private void btXoa_Click(object sender, EventArgs e)
       {
           int KT = _DOITAC_BUS.Delete(txtMaDoiTac.Text);
           if (KT  >0)
           {
               MessageBox.Show("Xóa thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
               Load_dGVDanhSachDoiTac();
           }
           else
           {
               MessageBox.Show("Không xóa được", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
       }



    }
}
