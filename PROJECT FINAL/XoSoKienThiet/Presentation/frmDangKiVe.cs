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
        string _MaDotPhatHanh = "", _MaLoaiVe = "", _MaCongTy = "" ;
        int _SoVeDangKiToiDa;
        CT_PHIEUDANGKYVE_BUS _CT_PHIEUDANGKYVE_BUS = null;
        public frmDangKiVe()
        {
            InitializeComponent();

            _NHANVIEN_BUS = new NHANVIEN_BUS();
            _DOITAC_BUS = new DOITAC_BUS();
            _DOTPHATHANH_BUS = new DOTPHATHANH_BUS();
            _LOAIVE_BUS = new LOAIVE_BUS();
            _CT_PHIEUDANGKYVE_BUS = new CT_PHIEUDANGKYVE_BUS();
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
            if (gvBASE.FocusedColumn.FieldName == "MaCongTy")
            {
                _MaCongTy = e.Value.ToString();
                var _ListDotPhatHanh = _DOTPHATHANH_BUS.Select();
                repositoryItemLookUpEdit2.DataSource = _ListDotPhatHanh;
                repositoryItemLookUpEdit2.DisplayMember = "NgayPhatHanh";
                gvBASE.Columns["MaDotPhatHanh"].ColumnEdit = repositoryItemLookUpEdit2;


                var _ListLoaiVe = _LOAIVE_BUS.Select_Con_Company(e.Value.ToString());
                repositoryItemLookUpEdit3.DataSource = _ListLoaiVe;
                repositoryItemLookUpEdit3.DisplayMember = "MenhGia";
                gvBASE.Columns["MaLoaiVe"].ColumnEdit = repositoryItemLookUpEdit3;
            }

            if (gvBASE.FocusedColumn.FieldName == "MaDotPhatHanh")
            {
                _MaDotPhatHanh = e.Value.ToString();
            }

            if (gvBASE.FocusedColumn.FieldName == "MaLoaiVe")
            {
                _MaLoaiVe = e.Value.ToString();
                _SoVeDangKiToiDa = _CT_PHIEUDANGKYVE_BUS.GetAmountOfMaxRegisterTicket(cbTenDoiTac.SelectedValue.ToString(),
                                                                                            _MaCongTy,
                                                                                            _MaDotPhatHanh,
                                                                                            _MaLoaiVe);
                gvBASE.SetRowCellValue(gvBASE.FocusedRowHandle, gvBASE.Columns["SoVeDangKyToiDa"], _SoVeDangKiToiDa);
                
            }

            if (gvBASE.FocusedColumn.FieldName == "SoVeDangKy")
            {
                int sovedangky = 0;
                if (!Int32.TryParse(e.Value as String, out sovedangky))
                {
                    e.Valid = false;
                    e.ErrorText = "Số vé đăng ký là số nguyên dương";
                }
                else
                {
                    if (sovedangky > _SoVeDangKiToiDa)
                    {
                        e.Valid = false;
                        e.ErrorText = "Số vé đăng ký không lớn hơn số vé đăng ký tối đa";
                    }
                }
            }
        }

        private void gcBASE_Load(object sender, EventArgs e)
        {

            var _ListCompany = _DOITAC_BUS.SelectCompany();
            repositoryItemLookUpEdit1.DataSource = _ListCompany;
            repositoryItemLookUpEdit1.DisplayMember = "Ten";
            repositoryItemLookUpEdit1.ValueMember = "MaDoiTac";
            gvBASE.Columns["MaCongTy"].ColumnEdit = repositoryItemLookUpEdit1;
        }
   

    }
}