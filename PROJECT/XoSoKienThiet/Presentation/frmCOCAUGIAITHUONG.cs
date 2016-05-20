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
            cbLoaiVe.DataSource = _LOAIVE_BUS.SelectYourCompany();
            cbLoaiVe.DisplayMember = "MenhGia";
            cbLoaiVe.ValueMember = "MaLoaiVe";
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string _MaLoaiVe, _Ten, _SoTienTrung, _SoGiai;

            for (int i = 0; i < dgvCoCauGiaiThuong.Rows.Count - 1; i++)
            {
                _MaLoaiVe = cbLoaiVe.SelectedValue.ToString();
                _Ten = Convert.ToString(dgvCoCauGiaiThuong.Rows[i].Cells[1].Value);
                _SoTienTrung = Convert.ToString(dgvCoCauGiaiThuong.Rows[i].Cells[2].Value);
                _SoGiai = Convert.ToString(dgvCoCauGiaiThuong.Rows[i].Cells[3].Value);
                _GIAITHUONG_BUS.Insert(_MaLoaiVe, _Ten, _SoTienTrung, _SoGiai);
            }
            MessageBox.Show("Thêm thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvCoCauGiaiThuong_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvCoCauGiaiThuong.Rows[e.RowIndex -1].Cells[0].Value = e.RowIndex;
        }

        private void dgvCoCauGiaiThuong_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (dgvCoCauGiaiThuong.Rows[e.RowIndex].Cells[3].Value != null && dgvCoCauGiaiThuong.Rows[e.RowIndex].Cells[2] != null)
                {
                    string _Ten, _sError = "", _sErrorAll = "", _SoTienTrung, _SoGiai;
                    _sErrorAll = ""; // chạy lại vòng for format lỗi lại từ đầu
                    _Ten = Convert.ToString(dgvCoCauGiaiThuong.Rows[e.RowIndex].Cells[1].Value);
                    _SoTienTrung = Convert.ToString(dgvCoCauGiaiThuong.Rows[e.RowIndex].Cells[2].Value);
                    _SoGiai = Convert.ToString(dgvCoCauGiaiThuong.Rows[e.RowIndex].Cells[3].Value);

                    _sError = _GIAITHUONG_BUS.CheckErrorBeforeInsert(_Ten, _SoTienTrung, _SoGiai);
                    if (_sError != "")
                    {
                        _sErrorAll += "Lỗi dòng " + (e.RowIndex + 1).ToString() + ": " + _sError + "\n";
                        MessageBox.Show(_sErrorAll, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dgvCoCauGiaiThuong.Rows[e.RowIndex].Cells[4].Value = int.Parse(_SoGiai) * int.Parse(_SoTienTrung);
                    }

                }
            }
        }

    }
}
