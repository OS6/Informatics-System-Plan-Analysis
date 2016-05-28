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

namespace XoSoKienThiet.Presentation
{
    public partial class frmDangKiVe : DevExpress.XtraEditors.XtraForm
    {
        NHANVIEN_BUS _NHANVIEN_BUS = null;
        DOITAC_BUS _DOITAC_BUS = null;
        DOTPHATHANH_BUS _DOTPHATHANH_BUS = null;
        LOAIVE_BUS _LOAIVE_BUS = null;
        public frmDangKiVe()
        {
            InitializeComponent();

            _NHANVIEN_BUS = new NHANVIEN_BUS();
            _DOITAC_BUS = new DOITAC_BUS();
            _DOTPHATHANH_BUS = new DOTPHATHANH_BUS();
            _LOAIVE_BUS = new LOAIVE_BUS();
        }

        private void frmDangKiVe_Load(object sender, EventArgs e)
        {
            var _ListAgency = _DOITAC_BUS.SelectAgency();
            cbTenDoiTac.DataSource = _ListAgency;
            cbTenDoiTac.DisplayMember = "Ten";
            cbTenDoiTac.ValueMember = "MaDoiTac";
        }

        private void gvBASE_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gvBASE.FocusedColumn.FieldName == "SoVeDangKy")
            {
                int menhgia = 0;
                if (!Int32.TryParse(e.Value as String, out menhgia))
                {
                    e.Valid = false;
                    e.ErrorText = "Số vé đăng ký là số nguyên dương";
                }
            }
        }

        private void gvBASE_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (gvBASE.FocusedColumn.FieldName == "MaCongTy")
            {

            }
            if(gvBASE.FocusedColumn.FieldName == "DotPhatHanh")
            {
                if(e.Value != null)
                {

                }
                else
                {

                }
            }
        }

        private void gcBASE_Load(object sender, EventArgs e)
        {

            var _ListCompany = _DOITAC_BUS.SelectCompany();
            repositoryItemLookUpEdit1.DataSource = _ListCompany;
            repositoryItemLookUpEdit1.DisplayMember = "Ten";
            repositoryItemLookUpEdit1.ValueMember = "MaDoiTac";
            gvBASE.Columns[0].ColumnEdit = repositoryItemLookUpEdit1;
            repositoryItemLookUpEdit1.EditValueChanged += new EventHandler(repositoryItemLookUpEdit1_EditValueChanged);
        }
        void repositoryItemLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            string value = (sender as LookUpEdit).EditValue.ToString();

            var _ListDotPhatHanh = _DOTPHATHANH_BUS.Select();
            repositoryItemLookUpEdit2.DataSource = _ListDotPhatHanh;
            repositoryItemLookUpEdit2.DisplayMember = "NgayPhatHanh";
            gvBASE.Columns[1].ColumnEdit = repositoryItemLookUpEdit2;


            var _ListLoaiVe = _LOAIVE_BUS.Select_Con_Company(value);
            repositoryItemLookUpEdit3.DataSource = _ListLoaiVe;
            repositoryItemLookUpEdit3.DisplayMember = "MenhGia";
            gvBASE.Columns[2].ColumnEdit = repositoryItemLookUpEdit3;
        }


    }
}