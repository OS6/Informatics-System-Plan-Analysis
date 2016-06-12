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

namespace XoSoKienThiet.PRESENT
{
    public partial class frmTraCuuCongNo : DevExpress.XtraEditors.XtraForm
    {
        DOITAC_BUS _DOITAC_BUS = null;
        public frmTraCuuCongNo()
        {
            InitializeComponent();
            _DOITAC_BUS = new DOITAC_BUS();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            if (rbtnLoaiDoiTac.SelectedIndex == 0)
            {
                gcBASE.DataSource = _DOITAC_BUS.Select();
            }
            if (rbtnLoaiDoiTac.SelectedIndex == 1)
            {
                gcBASE.DataSource = _DOITAC_BUS.SelectCompany();
            }
            if (rbtnLoaiDoiTac.SelectedIndex == 2)
            {
                gcBASE.DataSource = _DOITAC_BUS.SelectAgency();
            }
            try
            {
                gcBASE.DataSource = _DOITAC_BUS.Select(lkTenDoiTac.GetColumnValue("MaDoiTac").ToString());
            }
            catch (Exception)
            {
            }
        }

        private void rbtnLoaiDoiTac_SelectedIndexChanged(object sender, EventArgs e)
        {
            lkTenDoiTac.EditValue = null;
            if (rbtnLoaiDoiTac.SelectedIndex == 1)
            {
                lkTenDoiTac.Properties.DataSource = _DOITAC_BUS.SelectCompany();
            }
            else
            {
                if (rbtnLoaiDoiTac.SelectedIndex == 2)
                {
                    lkTenDoiTac.Properties.DataSource = _DOITAC_BUS.SelectAgency();
                }
                else
                {
                    lkTenDoiTac.Properties.DataSource = _DOITAC_BUS.Select();
                }
            }
        }

        private void frmTraCuuCongNo_Load(object sender, EventArgs e)
        {
            rbtnLoaiDoiTac.SelectedIndex = 0;
            lkTenDoiTac.Properties.DataSource = _DOITAC_BUS.Select();
            lkTenDoiTac.Properties.DisplayMember = "Ten";
            lkTenDoiTac.Properties.ValueMember = "MaDoiTac";

            lkTenDoiTac.Properties.ForceInitialize();
            lkTenDoiTac.Properties.PopulateColumns();

            lkTenDoiTac.Properties.Columns["MaDoiTac"].Visible = false;
            lkTenDoiTac.Properties.Columns["MaLoaiDoiTac"].Visible = false;
            lkTenDoiTac.Properties.Columns["TiLeHoaHong"].Visible = false;
            lkTenDoiTac.Properties.Columns["TiLeTieuThu"].Visible = false;
            lkTenDoiTac.Properties.Columns["CongNo"].Visible = false;
        }
    }
}