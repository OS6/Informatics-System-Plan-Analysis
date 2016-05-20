using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;

namespace XoSoKienThiet.Presentation
{
    public partial class frmMAIN : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMAIN()
        {
            InitializeComponent();
        }

        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            //tắt tab đang hiện trên màn hình
            ClosePageButtonEventArgs arg = e as ClosePageButtonEventArgs;
            (arg.Page as XtraTabPage).PageVisible = false;
        }

        private void barbtnHoSoDoiTac_ItemClick(object sender, ItemClickEventArgs e)
        {
            ucHoSoDoiTac myUserControl = new ucHoSoDoiTac();
            myUserControl.Dock = DockStyle.Fill;
            XtraTabPage myTabPage = new XtraTabPage();//Create new tabpage
            myTabPage.Text = "Hồ sơ đối tác"; //đặt tên cho page đó hiển thị ở tab
            myTabPage.Controls.Add(myUserControl);
            xtraTabControl1.TabPages.Add(myTabPage);
        }
    }
}