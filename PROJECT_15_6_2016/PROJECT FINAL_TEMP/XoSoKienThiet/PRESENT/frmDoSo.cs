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
using System.Data.Entity;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.PRESENT
{
    public partial class frmDoSo : DevExpress.XtraEditors.XtraForm
    {

        DOTPHATHANH_BUS _DOTPHATHANH_BUS = null;
        LOAIVE_BUS _LOAIVE_BUS = null;
        KETQUAXOSO_BUS _KETQUAXOSO_BUS = null;
        public frmDoSo()
        {
            InitializeComponent();
            _DOTPHATHANH_BUS = new DOTPHATHANH_BUS();
            _LOAIVE_BUS = new LOAIVE_BUS();
            _KETQUAXOSO_BUS = new KETQUAXOSO_BUS();
        }

        private void frmDoSo_Load(object sender, EventArgs e)
        {
            #region #Lookup đợt phát hành
            var ListDotPhatHanh = _DOTPHATHANH_BUS.Select_Con_Company("DT00000001");
            lkNgayXoSo.Properties.DataSource = ListDotPhatHanh;
            lkNgayXoSo.Properties.DisplayMember = "NgayXoSo";
            lkNgayXoSo.Properties.ValueMember = "MaDotPhatHanh";

            lkNgayXoSo.Properties.ForceInitialize();
            lkNgayXoSo.Properties.PopulateColumns();

            lkNgayXoSo.Properties.Columns["MaCongTy"].Visible = false;
            #endregion

            //Sel_YourCompany
            #region #Lookup loại vé
            var ListLoaiVe = _LOAIVE_BUS.SelectYourCompany();
            lkLoaiVe.Properties.DataSource = ListLoaiVe;
            lkLoaiVe.Properties.DisplayMember = "MenhGia";
            lkLoaiVe.Properties.ValueMember = "MaLoaiVe";

            lkLoaiVe.Properties.ForceInitialize();
            lkLoaiVe.Properties.PopulateColumns();

            lkLoaiVe.Properties.Columns["MaCongTy"].Visible = false;
            #endregion
        }

        private void btnDoSo_Click(object sender, EventArgs e)
        {
            string MaDotPhatHanh = "", MaLoaiVe = "";
            try
            {
                MaDotPhatHanh = lkNgayXoSo.Properties.GetDataSourceValue("MaDotPhatHanh", lkNgayXoSo.ItemIndex).ToString();
            }
            catch (Exception)
            {
            }
            try
            {
                MaLoaiVe = lkLoaiVe.Properties.GetDataSourceValue("MaLoaiVe", lkLoaiVe.ItemIndex).ToString();
            }
            catch (Exception)
            {
            }
            string Error = _KETQUAXOSO_BUS.CheckBeforeSelect(MaDotPhatHanh, MaLoaiVe, txtSo.Text);
            if (Error == "")
            {
                gcBASE.DataSource = _KETQUAXOSO_BUS.Select(MaDotPhatHanh, MaLoaiVe, txtSo.Text);
            }
            else
            {
                XtraMessageBox.Show(Error, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
