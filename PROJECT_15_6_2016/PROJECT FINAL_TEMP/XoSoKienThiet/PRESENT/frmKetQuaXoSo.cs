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
using DevExpress.XtraGrid.Views.Grid;

namespace XoSoKienThiet.PRESENT
{
    public partial class frmKetQuaXoSo : DevExpress.XtraEditors.XtraForm
    {
        DOTPHATHANH_BUS _DOTPHATHANH_BUS = null;
        GIAITHUONG_BUS _GIAITHUONG_BUS = null;
        LOAIVE_BUS _LOAIVE_BUS = null;
        KETQUAXOSO_BUS _KETQUAXOSO_BUS = null;
        CT_KETQUAXOSO_BUS _CT_KETQUAXOSO_BUS = null;
        DANHSACHSOTRUNG_BUS _DANHSACHSOTRUNG_BUS = null;
        string _MaLoaiVe = "", _MaDotPhatHanh = "";
        List<CT_KETQUAXOSO_VIEW> List_CT_KetQuaXoSo = null;
        public frmKetQuaXoSo()
        {
            InitializeComponent();
            _DOTPHATHANH_BUS = new DOTPHATHANH_BUS();
            _LOAIVE_BUS = new LOAIVE_BUS();
            _GIAITHUONG_BUS = new GIAITHUONG_BUS();
            _KETQUAXOSO_BUS = new KETQUAXOSO_BUS();
            _CT_KETQUAXOSO_BUS = new CT_KETQUAXOSO_BUS();
            _DANHSACHSOTRUNG_BUS = new DANHSACHSOTRUNG_BUS();
            List_CT_KetQuaXoSo = new List<CT_KETQUAXOSO_VIEW>();
        }

        private void frmKetQuaXoSo_Load(object sender, EventArgs e)
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

        private void lkDotPhatHanh_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                _MaDotPhatHanh = lkDotPhatHanh.Properties.GetDataSourceValue("MaDotPhatHanh", lkDotPhatHanh.ItemIndex).ToString();
                _NgayXoSo = lkDotPhatHanh.Properties.GetDataSourceValue("NgayXoSo", lkDotPhatHanh.ItemIndex).ToString();
                txtNgayXoSo.Text = string.Format("{0:dd/MM/yyyy}", Convert.ToDateTime(_NgayXoSo));

                XoSoKienThiet.DTO.XoSoKienThietDbContext dbContext = new XoSoKienThiet.DTO.XoSoKienThietDbContext();
                string MaDotPhatHanh = lkDotPhatHanh.Properties.GetDataSourceValue("MaDotPhatHanh", lkDotPhatHanh.ItemIndex).ToString();
            }
            catch (Exception)
            {
            }
        }

        private void lkLoaiVe_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                _MaLoaiVe = lkLoaiVe.Properties.GetDataSourceValue("MaLoaiVe", lkLoaiVe.ItemIndex).ToString();
                // Lấy danh sách chi tiết kết quả xổ số như trên , thực ra là đổ giải thưởng lên chi tiết kết quả xổ số
                var List_GiaiThuong = _GIAITHUONG_BUS.Select(_MaLoaiVe);

                #region #Hiển thị dữ liệu lên gridview
                foreach (var item in List_GiaiThuong)
                {
                    //Gán những thuộc tính có sẵn
                    CT_KETQUAXOSO_VIEW ct_ketquaxoso = new CT_KETQUAXOSO_VIEW();
                    ct_ketquaxoso.Ten = item.Ten;
                    ct_ketquaxoso.SoTienTrung = item.SoTienTrung;
                    ct_ketquaxoso.SoGiai = item.SoGiai;
                    ct_ketquaxoso.MaGiaiThuong = item.MaGiaiThuong;

                    // Tính thành tiền và số lượng nhận
                    ct_ketquaxoso.SoLuongVeTrung = item.SoGiai * 10;// 10 la test
                    ct_ketquaxoso.TongTien = ct_ketquaxoso.SoLuongVeTrung * item.SoTienTrung;
                    List_CT_KetQuaXoSo.Add(ct_ketquaxoso);
                }
                gcBASE.DataSource = List_CT_KetQuaXoSo;
                #endregion
            }
            catch (Exception)
            {
            }
           
        }
        private void gvBASE_InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            if (gvBASE.FocusedColumn.FieldName == "MaChiTietKQXS")
            {
                if (e.Value as String == "")
                {
                    e.ErrorText = "Số trúng không được rống";
                }
            }
        }
        public string _NgayXoSo { get; set; }

        private void gvBASE_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (gvBASE.FocusedColumn.FieldName == "MaChiTietKQXS")
            {
                if (e.Value as String == "")
                {
                    XtraMessageBox.Show("Số trúng không được rống");
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lkDotPhatHanh.ReadOnly = false;
            lkLoaiVe.ReadOnly = false;
            lkDotPhatHanh.EditValue = null;
            lkLoaiVe.EditValue = null;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string MaKetQuaXoSo = _KETQUAXOSO_BUS.Insert(_MaDotPhatHanh, _MaLoaiVe);
            string MaGiaiThuong, MaDanhSachVeTrung, SoLuongVeTrung, TongTien;
            MaGiaiThuong = MaDanhSachVeTrung = SoLuongVeTrung = TongTien = "";
            int i = 0;
            bool AllowInSert = false;
           for( i = 0; i < List_CT_KetQuaXoSo.Count; i++)
           {
                try
                {
                    AllowInSert = true;
                    string ListSoTrung = gvBASE.GetRowCellValue(i, gvBASE.Columns["MaChiTietKQXS"]).ToString();// cột để tạm điền số trúng vào
                }
                catch (Exception)
                {
                    AllowInSert = false;
                }
            }
            if (AllowInSert)
            {
                i = 0;
                foreach (var item in List_CT_KetQuaXoSo)
                {
                    MaGiaiThuong = item.MaGiaiThuong;
                    SoLuongVeTrung = item.SoLuongVeTrung.ToString();
                    TongTien = item.TongTien.ToString();
                    string MaCT_KQXS = _CT_KETQUAXOSO_BUS.Insert(MaKetQuaXoSo, MaGiaiThuong, SoLuongVeTrung, TongTien);
                    string ListSoTrung = gvBASE.GetRowCellValue(i, gvBASE.Columns["MaChiTietKQXS"]).ToString();// cột để tạm điền số trúng vào
                    string[] SoTrung = ListSoTrung.Split(',');
                    foreach (var item1 in SoTrung)
                    {
                        _DANHSACHSOTRUNG_BUS.Insert(MaCT_KQXS, item1.Trim());
                    }
                    i++;
                }
                XtraMessageBox.Show("Ghi nhận kết quả xổ số thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                XtraMessageBox.Show("Số trúng chưa được nhập đầy đủ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvBASE_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {

        }
    }
}