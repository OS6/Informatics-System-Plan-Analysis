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
    public partial class frmBC_DoanThuTheoDPH : DevExpress.XtraEditors.XtraForm
    {
        BAOCAODOANHTHUTHEODOTPHATHANH_BUS _BAOCAODOANHTHUTHEODOTPHATHANH_BUS = null;
        DOTPHATHANH_BUS _DOTPHATHANH_BUS = null;
        public frmBC_DoanThuTheoDPH()
        {
            InitializeComponent();
            _BAOCAODOANHTHUTHEODOTPHATHANH_BUS = new BAOCAODOANHTHUTHEODOTPHATHANH_BUS();
            _DOTPHATHANH_BUS = new DOTPHATHANH_BUS();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string MaDotPhatHanh = "";
            try
            {
                MaDotPhatHanh = Convert.ToString(lkDotPhatHanh.Properties.GetDataSourceValue("MaDotPhatHanh", lkDotPhatHanh.ItemIndex));
            }
            catch (Exception)
            {
            }
            if (MaDotPhatHanh == "")
            {
                XtraMessageBox.Show("Bạn chưa chọn đợt phát hành", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var BaoCaoDot  = _BAOCAODOANHTHUTHEODOTPHATHANH_BUS.Select(MaDotPhatHanh);
                txtTongThu.Text = BaoCaoDot.TongThu.ToString();
                txtTongChi.Text = BaoCaoDot.TongChi.ToString();
                txtLoiNhuan.Text = BaoCaoDot.LoiNhuan.ToString();
                txtCongQuy.Text = BaoCaoDot.CongQuy.ToString();
            }  
        }

        private void frmBC_DoanThuTheoDPH_Load(object sender, EventArgs e)
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
        }

    }
}