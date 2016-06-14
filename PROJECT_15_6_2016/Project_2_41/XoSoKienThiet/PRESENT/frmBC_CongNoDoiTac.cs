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
using XoSoKienThiet.DTO;


namespace XoSoKienThiet.Presentation
{
    public partial class frmBC_CongNoDoiTac : DevExpress.XtraEditors.XtraForm
    {
        string _MaLoaiDoiTac = "LDT0000001";
        DOITAC_BUS _DOITAC_BUS = null;
        public frmBC_CongNoDoiTac()
        {
            InitializeComponent();
            _DOITAC_BUS = new DOITAC_BUS();
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbtnLoaiDoiTac.SelectedIndex == 0)
            {
                _MaLoaiDoiTac = "LDT0000001";
            }
            else
            {
                _MaLoaiDoiTac = "LDT0000002";
            }
        }

        private void LoadDSCongNoDoiTac()
        {
            if (_MaLoaiDoiTac == "LDT0000001")
            {
                bindingGridView.DataSource = _DOITAC_BUS.SelectCompany();
            }
            else
            {
                bindingGridView.DataSource = _DOITAC_BUS.SelectAgency();
            }
        }

        private void btnNap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadDSCongNoDoiTac();
        }
        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rpCongNoDoiTac report = new rpCongNoDoiTac();
            report.DataSource = gvBASE.DataSource;
            ReportPrintTool designTool = new ReportPrintTool(report);
            designTool.ShowPreview();
            //gvBASE.ShowPrintPreview();
        }
    }
}