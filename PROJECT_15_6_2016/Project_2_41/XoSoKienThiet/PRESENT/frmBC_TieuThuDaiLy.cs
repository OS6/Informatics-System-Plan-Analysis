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
using System.Data.Entity;
using XoSoKienThiet.BUS;
using XoSoKienThiet.REPORT;
using DevExpress.XtraReports.UI;

namespace XoSoKienThiet.PRESENT
{
    public partial class frmBC_TieuThuDaiLy : DevExpress.XtraEditors.XtraForm
    {
        DOITAC_BUS _DOITAC_BUS = null;
        rptTieuThuDaiLy _Report = null;
        ReportPrintTool _Tool = null;
        bool _InPhieu = false;
        public frmBC_TieuThuDaiLy()
        {
            InitializeComponent();
            _DOITAC_BUS = new DOITAC_BUS();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            try
            {
                var List = _DOITAC_BUS.SelectAgency();
                foreach (var item in List)
                {
                    item.TiLeTieuThu = Math.Round(_DOITAC_BUS.GetPercentagenDot(item.MaDoiTac, Convert.ToInt32(txtSoDotPhatHanh.Text)), 2);
                }
                gcBASE.DataSource = List;

                _Report = new rptTieuThuDaiLy();
                _Report.DataSource = List;
                _InPhieu = true;
            }
            catch (Exception)
            {

            }
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            //gvBASE.Export
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

        private void frmBC_TieuThuDaiLy_Load(object sender, EventArgs e)
        {
            //gvBASE.Columns["MaDoiTac"].Visible = false;
            gvBASE.Columns["MaLoaiDoiTac"].Visible = false;
            gvBASE.Columns["TiLeHoaHong"].Visible = false;
            gvBASE.Columns["CongNo"].Visible = false;
            gvBASE.Columns["SDT"].Visible = false;
            gvBASE.Columns["Email"].Visible = false;
            gvBASE.Columns["DiaChi"].Visible = false;
        }
    }
}