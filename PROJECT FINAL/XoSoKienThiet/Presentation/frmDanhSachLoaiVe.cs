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
using System.Data.Entity;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.Presentation
{
    public partial class frmDanhSachLoaiVe : DevExpress.XtraEditors.XtraForm
    {
        DOITAC_BUS _DOITAC_BUS = null;
        LOAIVE_BUS _LOAIVE_BUS = null;
        public frmDanhSachLoaiVe()
        {
            InitializeComponent();
            _DOITAC_BUS = new DOITAC_BUS();
            _LOAIVE_BUS = new LOAIVE_BUS();
        }

      

        public void Load_dvLoaiVe()
        {
            string _MaCongTy = lkTenCongTy.GetColumnValue("MaDoiTac").ToString();

            var _ListKindofTicket = _LOAIVE_BUS.Select_Con_Company(_MaCongTy).ToList();

            bindingSource1.DataSource = _ListKindofTicket;
            gcBASE.DataSource = bindingSource1;
        }
        private void lkTenCongTy_EditValueChanged(object sender, EventArgs e)
        {
            Load_dvLoaiVe();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (lkTenCongTy.ItemIndex < 0)
            {
                MessageBox.Show("Chọn công ty!");
            }
            else
            {
                string _MenhGia = gvBASE.GetFocusedRowCellValue("MenhGia").ToString();
                string _MaCongTy = lkTenCongTy.GetColumnValue("MaDoiTac").ToString();
                _LOAIVE_BUS.Insert(_MaCongTy, _MenhGia);
                Load_dvLoaiVe();
            }

        }

        private void gvBASE_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gvBASE.FocusedColumn.FieldName == "MenhGia")
            {
                int menhgia = 0;
                if (!Int32.TryParse(e.Value as String, out menhgia))
                {
                    e.Valid = false;
                    e.ErrorText = "Mệnh giá phải là số nguyên dương";
                }
            }
        }

        private void gvBASE_InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            if (gvBASE.FocusedColumn.FieldName == "MenhGia")
            {
                if (e.Value as String == "")
                {
                    e.ErrorText = "Mệnh giá không được rống";
                }
            }
        }

        private void frmDanhSachLoaiVe_Load_1(object sender, EventArgs e)
        {
            var _ListCompany = _DOITAC_BUS.SelectCompany();
            lkTenCongTy.Properties.DataSource = _ListCompany;
            lkTenCongTy.Properties.DisplayMember = "Ten";

            lkTenCongTy.Properties.ForceInitialize();
            lkTenCongTy.Properties.PopulateColumns();

            lkTenCongTy.Properties.Columns["MaDoiTac"].Visible = false;
            lkTenCongTy.Properties.Columns["MaLoaiDoiTac"].Visible = false;
            lkTenCongTy.Properties.Columns["TiLeHoaHong"].Visible = false;
            lkTenCongTy.Properties.Columns["TiLeTieuThu"].Visible = false;
            lkTenCongTy.Properties.Columns["CongNo"].Visible = false;
        }

    }
}