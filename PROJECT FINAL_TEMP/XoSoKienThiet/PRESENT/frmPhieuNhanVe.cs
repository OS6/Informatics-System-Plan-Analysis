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
using XoSoKienThiet.REPORT;
using DevExpress.XtraReports.UI;

namespace XoSoKienThiet.PRESENT
{
    public partial class frmPhieuNhanVe : DevExpress.XtraEditors.XtraForm
    {

        NHANVIEN_BUS _NHANVIEN_BUS = null;
        CT_PHIEUDANGKYVE_BUS _CT_PHIEUDANGKYVE_BUS = null;
        DOITAC_BUS _DOITAC_BUS = null;
        CT_PHIEUNHANVE_BUS _CT_PHIEUNHANVE_BUS = null;
        LOAIVE_BUS _LOAIVE_BUS = null;
        PHIEUNHANVE_BUS _PHIEUNHANVE_BUS = null;
        PHIEUDANGKYVE_BUS _PHIEUDANGKYVE_BUS = null;
        string _MaPhieuNhanVe = "";
        string _MaPhieuDangKy = "";
        int _Type = 0;
        bool _InPhieu = false;
        rptIn_PhieuNhanVe _Report = null;
        ReportPrintTool _Tool = null;
        public frmPhieuNhanVe()
        {
            InitializeComponent();
            _NHANVIEN_BUS = new NHANVIEN_BUS();
            _CT_PHIEUDANGKYVE_BUS = new CT_PHIEUDANGKYVE_BUS();
            _DOITAC_BUS = new DOITAC_BUS();
            _CT_PHIEUNHANVE_BUS = new CT_PHIEUNHANVE_BUS();
            _LOAIVE_BUS = new LOAIVE_BUS();
            _PHIEUNHANVE_BUS = new PHIEUNHANVE_BUS();
            _PHIEUDANGKYVE_BUS = new PHIEUDANGKYVE_BUS();

            #region #Hiển thị txtTenDoiTac theo MaPhieuDangKy
            XoSoKienThiet.DTO.XoSoKienThietDbContext dbContext = new XoSoKienThiet.DTO.XoSoKienThietDbContext();
            dbContext.PHIEUDANGKYVE_DOITAC_VIEWs.Load();
            bindingMaPhieuDangKy.DataSource = dbContext.PHIEUDANGKYVE_DOITAC_VIEWs.Local.ToBindingList();
            #endregion
            //dbContext.CT_PHIEUNHANVE_VIEW.Load();
            //gcBASE.DataSource = dbContext.CT_PHIEUNHANVE_VIEW.Local.ToBindingList();
        }

        private void frmPhieuNhanVe_Load(object sender, EventArgs e)
        {
            #region #Load danh sách nhân viên
            var _ListNhanVien = _NHANVIEN_BUS.Select();
            lkNguoiLap.Properties.DataSource = _ListNhanVien;
            lkNguoiLap.Properties.DisplayMember = "Ten";
            lkNguoiLap.Properties.ValueMember = "MaNhanVien";

            lkNguoiLap.Properties.ForceInitialize();
            lkNguoiLap.Properties.PopulateColumns();

            lkNguoiLap.Properties.Columns["MaCoCauToChuc"].Visible = false;
            lkNguoiLap.Properties.Columns["DiaChi"].Visible = false;
            lkNguoiLap.Properties.Columns["Email"].Visible = false;
            lkNguoiLap.Properties.Columns["SDT"].Visible = false;
            #endregion

        }
        void LoadgcBASE() // load danh sách loại vé đăng ký mà chưa nhận nếu phiếu đăng ký là của đại lý
        // load danh sách phiếu đã đăng ký chưa nhận của rồi điền số vé nhận vào nếu là công ty      
        {

            try
            {
                txtTenDoiTac.Text = lkMaPhieuDangKy.Properties.GetDataSourceValue("Ten", lkMaPhieuDangKy.ItemIndex).ToString();
                _MaPhieuDangKy = lkMaPhieuDangKy.Properties.GetDataSourceValue("MaPhieuDangKy", lkMaPhieuDangKy.ItemIndex).ToString();
                string MaPhieuDangKy = lkMaPhieuDangKy.Properties.GetDataSourceValue("MaPhieuDangKy", lkMaPhieuDangKy.ItemIndex).ToString();
                // Lấy danh sách chi tiết phiếu đăng ký có mã phiếu đăng ký như trên
                List<CT_PHIEUDANGKYVE_VIEW> List_CT_PDKC = _CT_PHIEUDANGKYVE_BUS.SelectViewNotReCeive(_MaPhieuDangKy);
                List<CT_PHIEUNHANVE_VIEW> List_CT_PhieuNhanVe = new List<CT_PHIEUNHANVE_VIEW>();
                int SoVeNhan = 0, MenhGia;
                float TiLeHoaHong;
                decimal ThanhTien = 0;

                #region #Hiển thị dữ liệu lên gridview
                foreach (var item in List_CT_PDKC)
                {
                    //Gán những thuộc tính có sẵn
                    CT_PHIEUNHANVE_VIEW phieunhanve_view = new CT_PHIEUNHANVE_VIEW();
                    phieunhanve_view.MaDoiTac = item.MaDoiTac;
                    phieunhanve_view.MaDotPhatHanh = item.MaDotPhatHanh;
                    phieunhanve_view.MaLoaiVe = item.MaLoaiVe;
                    phieunhanve_view.Ten = item.Ten;
                    phieunhanve_view.NgayPhatHanh = item.NgayPhatHanh;
                    phieunhanve_view.MenhGia = item.MenhGia;
                    phieunhanve_view.SoLuongDangKy = item.SoVeDangKy;
                    List_CT_PhieuNhanVe.Add(phieunhanve_view);

                    if (_PHIEUDANGKYVE_BUS.IsYourCompany(_MaPhieuDangKy) == true)
                    {
                        // do nothing
                        gvBASE.Columns["SoLuongNhan"].OptionsColumn.AllowEdit = true;
                    }
                    else
                    {
                        // Tính thành tiền và số lượng nhận
                        if (_DOITAC_BUS.IsYourCompany(item.MaDoiTac) == false)
                        {
                            try
                            {
                                SoVeNhan = Convert.ToInt32(item.SoVeDangKy * _CT_PHIEUNHANVE_BUS.PercentageAmountofTicketReceive(item.MaDoiTac, item.MaDotPhatHanh, item.MaLoaiVe));
                            }
                            catch (Exception)
                            {
                                XtraMessageBox.Show("Loại vé chưa được nhận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            SoVeNhan = Convert.ToInt32(item.SoVeDangKy * _DOITAC_BUS.GetPercentageConsume(lkMaPhieuDangKy.Properties.GetDataSourceValue("MaDoiTac", lkMaPhieuDangKy.ItemIndex).ToString()));
                        }
                        TiLeHoaHong = _DOITAC_BUS.GetPercentage(lkMaPhieuDangKy.Properties.GetDataSourceValue("MaDoiTac", lkMaPhieuDangKy.ItemIndex).ToString());
                        MenhGia = _LOAIVE_BUS.GetPrice(item.MaLoaiVe);
                        ThanhTien = Convert.ToDecimal(TiLeHoaHong * MenhGia * SoVeNhan);
                        phieunhanve_view.SoLuongNhan = SoVeNhan;
                        phieunhanve_view.ThanhTien = ThanhTien;
                    }
                }
                gcBASE.DataSource = List_CT_PhieuNhanVe;
                #endregion
                int i = 0;
                foreach (var item in List_CT_PhieuNhanVe)
                {
                    gvBASE.SetRowCellValue(i, gvBASE.Columns["DaTra"], false);
                    i++;
                }
            }
            catch (Exception)
            {
            }
        }
        private void lkMaPhieuDangKy_EditValueChanged(object sender, EventArgs e)
        {
            LoadgcBASE();
        }


        private void gvBASE_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            int SoLuongNhan = 0;
            float ThanhTien = 0;
            if (gvBASE.FocusedColumn.FieldName == "DaTra")
            {
                if (e.Value.ToString() == "True")
                {
                    gvBASE.SetRowCellValue(gvBASE.FocusedRowHandle, gvBASE.Columns["DaTra"], true);
                    SoLuongNhan = Convert.ToInt32(gvBASE.GetRowCellValue(gvBASE.FocusedRowHandle, gvBASE.Columns["SoLuongNhan"]));
                    ThanhTien = Convert.ToInt32(gvBASE.GetRowCellValue(gvBASE.FocusedRowHandle, gvBASE.Columns["ThanhTien"]));
                }
                else
                {
                    gvBASE.SetRowCellValue(gvBASE.FocusedRowHandle, gvBASE.Columns["DaTra"], false);
                    Convert.ToInt32(gvBASE.GetRowCellValue(gvBASE.FocusedRowHandle, gvBASE.Columns["SoLuongNhan"]));
                    SoLuongNhan = -Convert.ToInt32(gvBASE.GetRowCellValue(gvBASE.FocusedRowHandle, gvBASE.Columns["SoLuongNhan"]));
                    ThanhTien = -Convert.ToInt32(gvBASE.GetRowCellValue(gvBASE.FocusedRowHandle, gvBASE.Columns["ThanhTien"]));
                }
            }
            txtTongSoVe.Text = (Convert.ToInt32(txtTongSoVe.Text) + SoLuongNhan).ToString();
            txtTongSoTien.Text = (Convert.ToInt32(txtTongSoTien.Text) + ThanhTien).ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _Type = 0;
            _InPhieu = false;
            //lkMaPhieuDangKy.ReadOnly = false;
            //deNgayLap.ReadOnly = false;
            //lkNguoiLap.ReadOnly = false;
            txtTenDoiTac.Text = "";
            txtTongSoTien.Text = "0";
            txtTongSoVe.Text = "0";
            var list = _CT_PHIEUDANGKYVE_BUS.SelectViewNotReCeive(_MaPhieuDangKy);
            List<CT_PHIEUNHANVE_VIEW> List_CT_PhieuNhanVe = new List<CT_PHIEUNHANVE_VIEW>();
            foreach (var item in list)
            {
                CT_PHIEUNHANVE_VIEW phieunhanve_view = new CT_PHIEUNHANVE_VIEW();
                phieunhanve_view.MaDoiTac = item.MaDoiTac;
                phieunhanve_view.MaDotPhatHanh = item.MaDotPhatHanh;
                phieunhanve_view.MaLoaiVe = item.MaLoaiVe;
                phieunhanve_view.Ten = item.Ten;
                phieunhanve_view.NgayPhatHanh = item.NgayPhatHanh;
                phieunhanve_view.MenhGia = item.MenhGia;
                phieunhanve_view.SoLuongDangKy = item.SoVeDangKy;
                List_CT_PhieuNhanVe.Add(phieunhanve_view);
            }
            gcBASE.DataSource = List_CT_PhieuNhanVe;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            _Type = 1;
            gcBASE.DataSource = _CT_PHIEUNHANVE_BUS.SelectReCeiveView(_MaPhieuNhanVe);
            gvBASE.Columns["DaTra"].Visible = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_PHIEUDANGKYVE_BUS.IsYourCompany(_MaPhieuDangKy) == true)
            {
                DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn thêm phiếu nhận vé ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                List<CT_PHIEUNHANVE_VIEW> List_CT_PhieuTraVe = new List<CT_PHIEUNHANVE_VIEW>();
                if (result == DialogResult.Yes)
                {
                    string NguoiLap = "";
                    if (_MaPhieuNhanVe == "")
                    {
                        try
                        {
                            NguoiLap = lkNguoiLap.EditValue.ToString();
                        }
                        catch (Exception)
                        {
                        }
                        string Error = _PHIEUNHANVE_BUS.CheckBeforeInsert(_MaPhieuDangKy, txtTongSoVe.Text, deNgayLap.Text, lkNguoiLap.GetColumnValue("MaNhanVien").ToString(), txtTongSoTien.Text);
                        if (Error != "")
                        {
                            XtraMessageBox.Show(Error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            _MaPhieuNhanVe = _PHIEUNHANVE_BUS.Insert(_MaPhieuDangKy, txtTongSoVe.Text, deNgayLap.Text, lkNguoiLap.GetColumnValue("MaNhanVien").ToString(), txtTongSoTien.Text);
                        }
                        var DataInGV = (List<CT_PHIEUNHANVE_VIEW>)gvBASE.DataSource;
                        int i = 0;
                        foreach (var item in DataInGV)
                        {
                            if (gvBASE.GetRowCellValue(i, gvBASE.Columns["DaTra"]).ToString() == "True")
                            {
                                _CT_PHIEUNHANVE_BUS.Insert(_MaPhieuNhanVe, item.MaDoiTac, item.MaDotPhatHanh, item.MaLoaiVe, item.SoLuongDangKy.ToString(), item.SoLuongNhan.ToString(), item.ThanhTien.ToString());
                                List_CT_PhieuTraVe.Add(item);
                                _CT_PHIEUDANGKYVE_BUS.UpdateDaNhan(_MaPhieuDangKy, item.MaDoiTac, item.MaDotPhatHanh, item.MaLoaiVe);
                            }
                            i++;
                        }
                    }
                    else
                    {
                        var DataInGV = (List<CT_PHIEUNHANVE_VIEW>)gvBASE.DataSource;
                        int i = 0;
                        foreach (var item in DataInGV)
                        {
                            if (gvBASE.GetRowCellValue(i, gvBASE.Columns["DaTra"]).ToString() == "True")
                            {
                                _CT_PHIEUNHANVE_BUS.Insert(_MaPhieuNhanVe, item.MaDoiTac, item.MaDotPhatHanh, item.MaLoaiVe, item.SoLuongDangKy.ToString(), item.SoLuongNhan.ToString(), item.ThanhTien.ToString());
                                List_CT_PhieuTraVe.Add(item);
                                _CT_PHIEUDANGKYVE_BUS.UpdateDaNhan(_MaPhieuDangKy, item.MaDoiTac, item.MaDotPhatHanh, item.MaLoaiVe);
                            }
                            i++;
                        }
                    }
                    gcBASE.DataSource = List_CT_PhieuTraVe;
                    gvBASE.Columns["DaTra"].Visible = false;
                }
            }
            else
            {
                if (_Type == 0)
                {
                    DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn thêm phiếu nhận vé ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    List<CT_PHIEUNHANVE_VIEW> List_CT_PhieuNhanVe = new List<CT_PHIEUNHANVE_VIEW>();
                    if (result == DialogResult.Yes)
                    {
                        string NguoiLap = "";
                        if (_MaPhieuNhanVe == "")
                        {
                            try
                            {
                                NguoiLap = lkNguoiLap.EditValue.ToString();
                            }
                            catch (Exception)
                            {
                            }
                            string Error = _PHIEUNHANVE_BUS.CheckBeforeInsert(_MaPhieuDangKy, txtTongSoVe.Text, deNgayLap.Text, NguoiLap, txtTongSoTien.Text);
                            if (Error != "")
                            {
                                XtraMessageBox.Show(Error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                _MaPhieuNhanVe = _PHIEUNHANVE_BUS.Insert(_MaPhieuDangKy, txtTongSoVe.Text, deNgayLap.Text, NguoiLap, txtTongSoTien.Text);
                                lkMaPhieuDangKy.ReadOnly = true;
                                deNgayLap.ReadOnly = true;
                                lkNguoiLap.ReadOnly = true;
                            }

                            var DataInGV = (List<CT_PHIEUNHANVE_VIEW>)gvBASE.DataSource;
                            int i = 0;
                            decimal TongTien = 0;
                            int TongSoVe = 0;
                            foreach (var item in DataInGV)
                            {
                                if (gvBASE.GetRowCellValue(i, gvBASE.Columns["DaTra"]).ToString() == "True")
                                {
                                    _CT_PHIEUNHANVE_BUS.Insert(_MaPhieuNhanVe, item.MaDoiTac, item.MaDotPhatHanh, item.MaLoaiVe, item.SoLuongDangKy.ToString(), item.SoLuongNhan.ToString(), item.ThanhTien.ToString());
                                    _CT_PHIEUDANGKYVE_BUS.UpdateDaNhan(_MaPhieuDangKy, item.MaDoiTac, item.MaDotPhatHanh, item.MaLoaiVe);
                                    List_CT_PhieuNhanVe.Add(item);
                                    TongTien += item.ThanhTien.Value;
                                    TongSoVe += item.SoLuongNhan.Value;
                                }
                                i++;
                            }
                            txtTongSoTien.Text = TongTien.ToString();
                            txtTongSoVe.Text = TongSoVe.ToString();
                        }
                        _DOITAC_BUS.Update_Debt(lkMaPhieuDangKy.Properties.GetDataSourceValue("MaDoiTac", lkMaPhieuDangKy.ItemIndex).ToString(), txtTongSoTien.Text);
                        gcBASE.DataSource = List_CT_PhieuNhanVe;
                        gvBASE.Columns["DaTra"].Visible = false;
                    }
                }
                else
                {
                    List<CT_PHIEUNHANVE_VIEW> List_CT_PhieuNhanVe = new List<CT_PHIEUNHANVE_VIEW>();
                    var DataInGV = (List<CT_PHIEUNHANVE_VIEW>)gvBASE.DataSource;
                    int i = 0;
                    decimal TongTien = 0;
                    int TongSoVe = 0;
                    foreach (var item in DataInGV)
                    {
                        if (gvBASE.GetRowCellValue(i, gvBASE.Columns["DaTra"]).ToString() == "True")
                        {
                            _CT_PHIEUNHANVE_BUS.Delete(item.MaChiTietPhieuNhan, _MaPhieuNhanVe, _MaPhieuDangKy, item.MaDoiTac, item.MaDotPhatHanh, item.MaLoaiVe, item.SoLuongDangKy.ToString(), item.SoLuongNhan.ToString(), item.ThanhTien.ToString());
                            List_CT_PhieuNhanVe.Add(item);
                            TongTien += item.ThanhTien.Value;
                            TongSoVe += item.SoLuongNhan.Value;
                        }
                        i++;
                    }
                    txtTongSoTien.Text = TongTien.ToString();
                    txtTongSoVe.Text = TongSoVe.ToString();
                    gcBASE.DataSource = _CT_PHIEUNHANVE_BUS.SelectReCeiveView(_MaPhieuNhanVe);
                }
            }
            _InPhieu = true;
            _Report = new rptIn_PhieuNhanVe();
            _Report.DataSource = gcBASE.DataSource;
        }

        private void btnThemPhieu_Click(object sender, EventArgs e)
        {
            lkMaPhieuDangKy.EditValue = null;
            deNgayLap.Text = "";
            lkNguoiLap.EditValue = null;
            txtTongSoVe.Text = "0";
            txtTongSoTien.Text = "0";
            lkMaPhieuDangKy.ReadOnly = false;
            deNgayLap.ReadOnly = false;
            lkNguoiLap.ReadOnly = false;
            txtTenDoiTac.Text = "";
            gvBASE.Columns["DaTra"].Visible = true;
            gcBASE.DataSource = null;
        }

        private void gvBASE_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

        }

        private void gvBASE_CellValueChanging_1(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (gvBASE.FocusedColumn.FieldName == "SoLuongNhan")
            {
                try
                {
                    int MenhGia;
                    float TiLeHoaHong;
                    decimal ThanhTien = 0;
                    TiLeHoaHong = _DOITAC_BUS.GetPercentage(Convert.ToString(gvBASE.GetRowCellValue(gvBASE.FocusedRowHandle, gvBASE.Columns["MaDoiTac"])));
                    MenhGia = _LOAIVE_BUS.GetPrice(Convert.ToString(gvBASE.GetRowCellValue(gvBASE.FocusedRowHandle, gvBASE.Columns["MaLoaiVe"])));
                    ThanhTien = Convert.ToDecimal(TiLeHoaHong * MenhGia * Convert.ToInt32(e.Value.ToString()));
                    gvBASE.SetRowCellValue(gvBASE.FocusedRowHandle, gvBASE.Columns["ThanhTien"], ThanhTien);
                }
                catch (Exception)
                {
                    gvBASE.SetRowCellValue(gvBASE.FocusedRowHandle, gvBASE.Columns["ThanhTien"], 0);
                }
                int TongSoLuongNhan = 0, TongSoTien = 0;
                for (int i = 0; i < gvBASE.RowCount; i++)
                {
                    if (i != gvBASE.FocusedRowHandle )
                    {
                        try
                        {
                            TongSoLuongNhan += Convert.ToInt32(gvBASE.GetRowCellValue(i, gvBASE.Columns["SoLuongNhan"]));
                            TongSoTien += Convert.ToInt32(gvBASE.GetRowCellValue(i, gvBASE.Columns["ThanhTien"]));
                        }
                        catch
                        {
                            // bắt lỗi khi giá trị ở cột đó null
                        }
                    }

                }
                if (e.Value != "" )
                {
                    try
                    {
                        if (Convert.ToInt32(e.Value) <=  Convert.ToInt32(gvBASE.GetRowCellValue(gvBASE.FocusedRowHandle, gvBASE.Columns["SoLuongDangKy"]))) // thỏa điều kiện thì mới cộng tổng
                        {
                            TongSoLuongNhan += Convert.ToInt32(e.Value);
                            TongSoTien += Convert.ToInt32(gvBASE.GetRowCellValue(gvBASE.FocusedRowHandle, gvBASE.Columns["ThanhTien"]));
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
                txtTongSoVe.Text = TongSoLuongNhan.ToString();
                txtTongSoTien.Text = TongSoTien.ToString();

            }
            if (gvBASE.FocusedColumn.FieldName == "DaTra")
            {
                if (e.Value.ToString() == "True")
                {
                    txtTongSoVe.Text = (Convert.ToInt32(txtTongSoVe.Text) + Convert.ToInt32(gvBASE.GetRowCellValue(gvBASE.FocusedRowHandle, gvBASE.Columns["SoLuongNhan"]))).ToString();
                    txtTongSoTien.Text = (Convert.ToInt32(txtTongSoTien.Text) + Convert.ToInt32(gvBASE.GetRowCellValue(gvBASE.FocusedRowHandle, gvBASE.Columns["ThanhTien"]))).ToString();
                }
                else
                {
                    txtTongSoVe.Text = (Convert.ToInt32(txtTongSoVe.Text) - Convert.ToInt32(gvBASE.GetRowCellValue(gvBASE.FocusedRowHandle, gvBASE.Columns["SoLuongNhan"]))).ToString();
                    txtTongSoTien.Text = (Convert.ToInt32(txtTongSoTien.Text) - Convert.ToInt32(gvBASE.GetRowCellValue(gvBASE.FocusedRowHandle, gvBASE.Columns["ThanhTien"]))).ToString();
                }
            }

        }

        private void gvBASE_InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            if (gvBASE.FocusedColumn.FieldName == "SoLuongNhan")
            {
                if (e.Value as String == "")
                {
                    e.ErrorText = "Số vé nhận không được rỗng";
                }
            }
        }

        private void gvBASE_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gvBASE.FocusedColumn.FieldName == "SoLuongNhan")
            {
                int SoVeNhan = 0;
                if (!Int32.TryParse(e.Value as String, out SoVeNhan))
                {
                    e.Valid = false;
                    e.ErrorText = "Số vé nhận là số nguyên dương";
                }
                else
                {
                    if (SoVeNhan > Convert.ToInt32(gvBASE.GetRowCellValue(gvBASE.FocusedRowHandle, gvBASE.Columns["SoLuongDangKy"])))
                    {
                        e.Valid = false;
                        e.ErrorText = "Số vé nhận không lớn hơn số vé đăng ký";
                    }
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (!_InPhieu)
            {
                XtraMessageBox.Show("Phải điền thông tin đầy đủ và lưu phiếu trước khi in!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _Report.rptLabelTenDoiTac.Text = "Tên đối tác: " + txtTenDoiTac.Text;
                _Report.rptLabelNgay.Text = "Tp. Hồ Chí Minh, ngày " + DateTime.Now.Day.ToString() + " tháng " + DateTime.Now.Month.ToString() + " năm " + DateTime.Now.Year.ToString();
                _Report.rptLabelTongSoVe.Text = "Tổng số vé: " + txtTongSoVe.Text;
                _Report.rptLabelTongSoTien.Text = "Tổng số tiền: " + txtTongSoTien.Text;
                _Tool = new ReportPrintTool(_Report);
                _Tool.ShowPreview();
            }
        }
    }
}
