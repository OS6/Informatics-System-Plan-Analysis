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

namespace XoSoKienThiet.Presentation
{
    public class b
    {
        public b()
        { }

        public string a { get; set; }
    }
    public partial class frmTest : DevExpress.XtraEditors.XtraForm
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            
            gridView1.SetRowCellValue(0, gridView1.Columns[0], 0);
        }

    }
}