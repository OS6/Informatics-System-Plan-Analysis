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
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.Presentation
{
    public partial class frmKeHoachPhatHanhVe : DevExpress.XtraEditors.XtraForm
    {
        CT_KEHOACHPHATHANH_BUS _CT_KEHOACHPHATHANH_BUS = null;
        KEHOACHPHATHANH_BUS _KEHOACHPHATHANH_BUS = null;
        DOTPHATHANH_BUS _DOTPHATHANH_BUS = null;
        List<CT_KEHOACHPHATHANH_VIEW> ListCT;
        DOITAC_BUS _DOITAC_BUS = null;
        public frmKeHoachPhatHanhVe()
        {
            _CT_KEHOACHPHATHANH_BUS = new CT_KEHOACHPHATHANH_BUS();
            _KEHOACHPHATHANH_BUS = new KEHOACHPHATHANH_BUS();
            _DOTPHATHANH_BUS = new DOTPHATHANH_BUS();
            _DOITAC_BUS = new DOITAC_BUS();
            InitializeComponent();
        }

        private void lkDotPhatHanh_EditValueChanged(object sender, EventArgs e)
        {
            ListCT = _KEHOACHPHATHANH_BUS.Select(lkDotPhatHanh.GetColumnValue("MaDotPhatHanh").ToString());

            bindingGridView.DataSource = ListCT;

            var TongSoVe = from p in ListCT
                           select p.SoVePhatHanhThucTe;
            txtTongSoVe.Text =  TongSoVe.Sum().ToString();
        }

        private void frmKeHoachPhatHanhVe_Load(object sender, EventArgs e)
        {
            #region #Lookup đợt phát hành
            var ListDotPhatHanh = _DOTPHATHANH_BUS.Select();
            lkDotPhatHanh.Properties.DataSource = ListDotPhatHanh;
            lkDotPhatHanh.Properties.DisplayMember = "MaDotPhatHanh";
            lkDotPhatHanh.Properties.ValueMember = "MaDotPhatHanh";

            lkDotPhatHanh.Properties.ForceInitialize();
            lkDotPhatHanh.Properties.PopulateColumns();

            lkDotPhatHanh.Properties.Columns["MaCongTy"].Visible = false;
            #endregion
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             string MaDotPhatHanh = lkDotPhatHanh.Properties.GetDataSourceValue("MaDotPhatHanh", lkDotPhatHanh.ItemIndex).ToString();
             string MaKeHoach = _KEHOACHPHATHANH_BUS.Insert(MaDotPhatHanh, txtTongSoVe.Text);
            foreach (var item in ListCT)
            {
                _CT_KEHOACHPHATHANH_BUS.Insert(MaKeHoach, item.MaLoaiVe, item.SoVePhatHanhDuKien.ToString(), item.SoVePhatHanhThucTe.ToString());
            }
        }
    }
}