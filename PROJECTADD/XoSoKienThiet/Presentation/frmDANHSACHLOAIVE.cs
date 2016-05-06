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
    public partial class frmDANHSACHLOAIVE : Form
    {
        DANHSACHLOAIVE_BUS _DANHSACHLOAIVE_BUS = null;
        DOITAC_BUS _DOITAC_BUS = null;
        public frmDANHSACHLOAIVE()
        {
            InitializeComponent();
            _DANHSACHLOAIVE_BUS = new DANHSACHLOAIVE_BUS();
            _DOITAC_BUS = new DOITAC_BUS();
        }

        public void Load_cbCongTyPhatHanh()
        {
            cbCongTyPhatHanh.DataSource = _DANHSACHLOAIVE_BUS.SelectCompany().Select(model => model.Ten).ToList();
            //string _MaCongTy = _DOITAC_BUS.GetMaDoiTac(cbCongTyPhatHanh.Text);
            //Load_dgvDanhSachLoaiVe(_MaCongTy);
        }

        public void Load_dgvDanhSachLoaiVe(string madoitac)
        {
            dgvDanhSachLoaiVe.DataSource = _DANHSACHLOAIVE_BUS.Select(madoitac);
        }

        private void frmDANHSACHLOAIVE_Load(object sender, EventArgs e)
        {
            Load_cbCongTyPhatHanh();
        }

        private void btIns_Click(object sender, EventArgs e)
        {
            frmLOAIVE frm = new frmLOAIVE(_DOITAC_BUS.GetMaDoiTac(cbCongTyPhatHanh.Text));
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            // them loai ve cho cong ty, giao dien nhu nao la hop ly???
        }
    }
}
