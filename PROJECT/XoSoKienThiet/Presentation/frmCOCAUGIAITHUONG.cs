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
    public partial class frmCOCAUGIAITHUONG : Form
    {
        LOAIVE_BUS _LOAIVE_BUS = null;
        GIAITHUONG_BUS _GIAITHUONG_BUS = null;
        public frmCOCAUGIAITHUONG()
        {
            InitializeComponent();
            _LOAIVE_BUS = new LOAIVE_BUS();
            _GIAITHUONG_BUS = new GIAITHUONG_BUS();
        }

        private void frmCOCAUGIAITHUONG_Load(object sender, EventArgs e)
        {
            Load_cbLoaiVe();
        }

        public void Load_cbLoaiVe()
        {
            cbLoaiVe.DataSource = _LOAIVE_BUS.Select().Select(model => model.MenhGia).ToList();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string _MaLoaiVe, _Ten, _SoTienTrung, _SoGiai;
            for(int i =0 ; i < dgvCoCauGiaiThuong.Rows.Count -1; i++)
            {
                _MaLoaiVe = _LOAIVE_BUS.GetID(cbLoaiVe.Text);
                _Ten = Convert.ToString(dgvCoCauGiaiThuong.Rows[i].Cells[1].Value);
                _SoTienTrung = Convert.ToString(dgvCoCauGiaiThuong.Rows[i].Cells[2].Value);
                _SoGiai = Convert.ToString(dgvCoCauGiaiThuong.Rows[i].Cells[3].Value);

                string KT = _GIAITHUONG_BUS.Insert(_MaLoaiVe, _Ten, _SoTienTrung, _SoGiai);
                if(KT != "")
                {
                    KT = "Lỗi dòng thứ " + (i+1).ToString() + "\n" + KT;
                    MessageBox.Show(KT, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
