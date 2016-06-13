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
using XoSoKienThiet.REPORT;
using DevExpress.XtraReports.UI;

namespace XoSoKienThiet.PRESENT
{
    public partial class frmBC_DoanThuTheoDPH : DevExpress.XtraEditors.XtraForm
    {
        BAOCAODOANHTHUTHEODOTPHATHANH_BUS _BAOCAODOANHTHUTHEODOTPHATHANH_BUS = null;
        DOTPHATHANH_BUS _DOTPHATHANH_BUS = null;
        bool _InPhieu = false;
        rptDoanThuTheoDPH _Report = null;
        ReportPrintTool _Tool = null;
        public frmBC_DoanThuTheoDPH()
        {
            InitializeComponent();
            _BAOCAODOANHTHUTHEODOTPHATHANH_BUS = new BAOCAODOANHTHUTHEODOTPHATHANH_BUS();
            _DOTPHATHANH_BUS = new DOTPHATHANH_BUS();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string MaDotPhatHanh = "";
            decimal GT;
            try
            {
                MaDotPhatHanh = Convert.ToString(lkDotPhatHanh.Properties.GetDataSourceValue("MaDotPhatHanh", lkDotPhatHanh.ItemIndex));
            }
            catch (Exception)
            {
            }
            if (MaDotPhatHanh == "")
            {
                XtraMessageBox.Show("Bạn chưa chọn đợt phát hành", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _Report = new rptDoanThuTheoDPH();
                var BaoCaoDot = _BAOCAODOANHTHUTHEODOTPHATHANH_BUS.Select(MaDotPhatHanh);
                GT = (decimal)BaoCaoDot.TongThu;
                txtTongThu.Text = GT.ToString("N0");
                GT = (decimal)BaoCaoDot.TongChi;
                txtTongChi.Text = GT.ToString("N0");
                GT = (decimal)BaoCaoDot.LoiNhuan;
                txtLoiNhuan.Text = GT.ToString("N0");
                GT = (decimal)BaoCaoDot.CongQuy;
                txtCongQuy.Text = GT.ToString("N0");
            }
            _Report.rptMaDotPhatHanh.Text = "Mã đợt phát hành: " + MaDotPhatHanh + ", ngày phát hành: " + lkDotPhatHanh.Properties.GetDataSourceValue("NgayPhatHanh", lkDotPhatHanh.ItemIndex);
            _Report.rptTongThu.Text = "Tổng thu : " + txtTongThu.Text + " VND";
            _Report.rptTongChi.Text = "Tổng chi : " + txtTongChi.Text + " VND";
            _Report.rptLoiNhuan.Text = "Lợi nhuận : " + txtLoiNhuan.Text + " VND";
            _Report.rptCongQuy.Text = "Công quỹ : " + txtCongQuy.Text + " VND";
            _InPhieu = true;
        }

        private void frmBC_DoanThuTheoDPH_Load(object sender, EventArgs e)
        {
            #region #Lookup đợt phát hành
            var ListDotPhatHanh = _DOTPHATHANH_BUS.Select_Con_Company("DT00000001");
            lkDotPhatHanh.Properties.DataSource = ListDotPhatHanh;
            lkDotPhatHanh.Properties.DisplayMember = "MaDotPhatHanh";
            lkDotPhatHanh.Properties.ValueMember = "MaDotPhatHanh";

            lkDotPhatHanh.Properties.ForceInitialize();
            lkDotPhatHanh.Properties.PopulateColumns();

            lkDotPhatHanh.Properties.Columns["MaCongTy"].Visible = false;
            #endregion
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (!_InPhieu)
            {
                XtraMessageBox.Show("Phải điền thông tin đầy đủ và lưu phiếu trước khi in!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                _Report.rptLabelNgay.Text = "Tp. Hồ Chí Minh, ngày " + DateTime.Now.Day.ToString() + " tháng " + DateTime.Now.Month.ToString() + " năm " + DateTime.Now.Year.ToString();
                _Tool = new ReportPrintTool(_Report);
                _Tool.ShowPreview();
            }
        }
    }
}