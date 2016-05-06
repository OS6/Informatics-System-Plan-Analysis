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
    public partial class frmLOAIVE : Form
    {
        private DANHSACHLOAIVE_BUS _DANHSACHLOAIVE_BUS = null;
        LOAIVE_BUS _LOAIVE_BUS = null;
        private string _MaCongTy;
        public frmLOAIVE(string macongty)
        {
            InitializeComponent();
            _MaCongTy = macongty;
            _DANHSACHLOAIVE_BUS = new DANHSACHLOAIVE_BUS();
            _LOAIVE_BUS = new LOAIVE_BUS();
        }

        private void frmLOAIVE_Load(object sender, EventArgs e)
        {
            Load_dgvDanhSachLoaiVe();
        }

        // Danh sach loai ve khong thuoc danh sach loai ve cua cong ty do
        public void Load_dgvDanhSachLoaiVe()
        {
            dgvDanhLoaiVe.DataSource = _DANHSACHLOAIVE_BUS.GetTypeofTicketnotInCompany(_MaCongTy);
        }
        private void btIns_Click(object sender, EventArgs e)
        {
            int KT = 0;
            for(int i = 0; i < dgvDanhLoaiVe.Rows.Count; i++)
            {
                if(Convert.ToBoolean(dgvDanhLoaiVe.Rows[i].Cells[0].Value) == true)
                {
                    KT = _DANHSACHLOAIVE_BUS.Insert(_MaCongTy, Convert.ToString(dgvDanhLoaiVe.Rows[i].Cells[1].Value));
                }
            }
            if(KT < 0)
            {
                MessageBox.Show("Lỗi hệ thống", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Thêm thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
