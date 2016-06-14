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
    public partial class frmDotPhatHanh : DevExpress.XtraEditors.XtraForm
    {
        DOITAC_BUS _DOITAC_BUS = null;
        DOTPHATHANH_BUS _DOTPHATHANH_BUS = null;
        public frmDotPhatHanh()
        {
            InitializeComponent();
            _DOITAC_BUS = new DOITAC_BUS();
            _DOTPHATHANH_BUS = new DOTPHATHANH_BUS();
        }

        private void frmDotPhatHanh_Load(object sender, EventArgs e)
        {
            lkCongTyPhatHanh.Properties.DataSource = _DOITAC_BUS.SelectCompany();
            lkCongTyPhatHanh.Properties.DisplayMember = "Ten";
            lkCongTyPhatHanh.Properties.ValueMember = "MaDoiTac";

            lkCongTyPhatHanh.Properties.ForceInitialize();
            lkCongTyPhatHanh.Properties.PopulateColumns();

            lkCongTyPhatHanh.Properties.Columns["MaDoiTac"].Visible = false;
            lkCongTyPhatHanh.Properties.Columns["MaLoaiDoiTac"].Visible = false;
            lkCongTyPhatHanh.Properties.Columns["TiLeHoaHong"].Visible = false;
            lkCongTyPhatHanh.Properties.Columns["TiLeTieuThu"].Visible = false;
            lkCongTyPhatHanh.Properties.Columns["CongNo"].Visible = false;
        }

        private void lkCongTyPhatHanh_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                gcBASE.DataSource = _DOTPHATHANH_BUS.Select_Con_Company(lkCongTyPhatHanh.GetColumnValue("MaDoiTac").ToString());
            }
            catch (Exception)
            {
                
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lkCongTyPhatHanh.ReadOnly = false;
            deNgayXoSo.ReadOnly = false;
            deNgayPhatHanh.ReadOnly = false;
            txtGioXoSo.ReadOnly = false;
            txtGioXoSo.Text = "";
            lkCongTyPhatHanh.EditValue = null;
            deNgayPhatHanh.Text = null;
            deNgayXoSo.Text = null;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                _DOTPHATHANH_BUS.Insert(deNgayPhatHanh.Text, deNgayXoSo.Text, txtGioXoSo.Text, lkCongTyPhatHanh.GetColumnValue("MaDoiTac").ToString());
                XtraMessageBox.Show("Thêm thành công.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gcBASE.DataSource = _DOTPHATHANH_BUS.Select_Con_Company(lkCongTyPhatHanh.GetColumnValue("MaDoiTac").ToString());
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Thông tin nhập không đúng.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}