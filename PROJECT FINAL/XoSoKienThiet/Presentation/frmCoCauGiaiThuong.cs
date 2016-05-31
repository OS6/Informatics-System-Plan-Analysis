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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.EditForm.Helpers.Controls;

namespace XoSoKienThiet.Presentation
{
    public partial class frmCoCauGiaiThuong : DevExpress.XtraEditors.XtraForm
    {
        LOAIVE_BUS _LOAIVE_BUS = null;
        GIAITHUONG_BUS _GIAITHUONG_BUS = null;
        string _TenGiai, _SoTienTrung, _SoGiai, _TongTien;
        public frmCoCauGiaiThuong()
        {
            InitializeComponent();
            _LOAIVE_BUS = new LOAIVE_BUS();
            _GIAITHUONG_BUS = new GIAITHUONG_BUS();
        }

        private void frmCoCauGiaiThuong_Load(object sender, EventArgs e)
        {
            var _ListLoaiVe = _LOAIVE_BUS.SelectYourCompany();
            lkLoaiVe.Properties.DataSource = _ListLoaiVe;
            lkLoaiVe.Properties.DisplayMember = "MenhGia";
            lkLoaiVe.Properties.ValueMember = "MaLoaiVe";

            lkLoaiVe.Properties.ForceInitialize();
            lkLoaiVe.Properties.PopulateColumns();

            lkLoaiVe.Properties.Columns["MaCongty"].Visible = false;
        }


        #region Thay đổi button text thành tiếng việt
        private void gvBASE_ShowingPopupEditForm(object sender, ShowingPopupEditFormEventArgs e)
        {
            if (gvBASE.FocusedColumn.FieldName == "SoTienTrung")
            {
                MessageBox.Show("So tien trung");
            }
            foreach (Control control in e.EditForm.Controls)
            {
                if (!(control is EditFormContainer))
                {
                    continue;
                }
                foreach (Control nestedControl in control.Controls)
                {
                    if (!(nestedControl is PanelControl))
                    {
                        continue;
                    }
                    foreach (Control button in nestedControl.Controls)
                    {
                        if (button is SimpleButton)
                        {
                            var simpleButton = button as SimpleButton;
                            ChangeButtonCaption(simpleButton);
                            ChangeButtonSize(simpleButton);
                        }
                    }
                }
            }
        }
        private static void ChangeButtonCaption(SimpleButton btn)
        {
            var newUpdateBtnText = "Lưu";
            var newCancelBtnText = "Hủy";
            var btnText = btn.Text;
            switch (btnText)
            {
                case "Update":
                    btn.Text = newUpdateBtnText;
                    break;
                case "Cancel":
                    btn.Text = newCancelBtnText;
                    break;
            }
        }
        private static void ChangeButtonSize(SimpleButton btn)
        {
            btn.CalcBestSize();
        }
        #endregion

        private void gvBASE_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
             int _SoTienTrung = 0;
            int _SoGiai = 0;
            int _TongTien = 0;
            if (gvBASE.FocusedColumn.FieldName == "SoTienTrung")
            {
                if (!Int32.TryParse(e.Value as String, out _SoTienTrung))
                {
                    e.Valid = false;
                    e.ErrorText = "Số tiền trúng là số nguyên dương";
                }
                else
                {
                    this._SoTienTrung = _SoTienTrung.ToString();
                }
            }
            if (gvBASE.FocusedColumn.FieldName == "SoGiai")
            {
                
                if (!Int32.TryParse(e.Value as String, out _SoGiai))
                {
                    e.Valid = false;
                    e.ErrorText = "Số giải là số nguyên dương";
                }
                else
                {
                    this._SoGiai = _SoGiai.ToString();
                }
            }
            if(this._SoGiai != null && this._SoTienTrung != null)
            {
                _TongTien = Convert.ToInt32(this._SoTienTrung) * Convert.ToInt32(this._SoGiai);
                this._TongTien = _TongTien.ToString();
                gvBASE.SetRowCellValue(gvBASE.FocusedRowHandle, gvBASE.Columns["TongTienTrung"], this._TongTien);
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(lkLoaiVe.GetColumnValue("MaLoaiVe") == null)
            {
                MessageBox.Show("Bạn chưa chọn loại vé!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(gvBASE.DataRowCount < 1)
            {
                MessageBox.Show("Bạn chưa điền thông tin giải thưởng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string _MaLoaiVe = lkLoaiVe.GetColumnValue("MaLoaiVe").ToString();
                _GIAITHUONG_BUS.Insert(_MaLoaiVe,
                                        _SoTienTrung,
                                        _SoGiai,
                                        _TongTien);
                gvBASE.Columns.Clear();
                var _ListGiaiThuong = _GIAITHUONG_BUS.Select(_MaLoaiVe);
                bindingSource1.DataSource = _ListGiaiThuong;
            }
        }

        private void gvBASE_InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            if (gvBASE.FocusedColumn.FieldName == "SoTienTrung")
            {
                if (e.Value as String == "")
                {
                    e.ErrorText = "Số tiền trúng không được rống";
                }
            }
            if (gvBASE.FocusedColumn.FieldName == "SoGiai")
            {
                if (e.Value as String == "")
                {
                    e.ErrorText = "Số giải không được rống";
                }
            }
        }

    }
}