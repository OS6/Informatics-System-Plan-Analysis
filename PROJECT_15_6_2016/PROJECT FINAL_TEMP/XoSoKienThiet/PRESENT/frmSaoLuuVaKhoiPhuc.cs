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
using System.Data.SqlClient;

namespace XoSoKienThiet.PRESENT
{
    public partial class frmSaoLuuVaKhoiPhuc : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection con = new SqlConnection(XoSoKienThiet.Properties.Settings.Default.XoSoKienThietConnectionString);
        public frmSaoLuuVaKhoiPhuc()
        {
            InitializeComponent();
        }

        private void btnBrowse1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtSaoLuu.Text = dlg.SelectedPath;
                btnSaoLuu.Enabled = true;
            }
        }

        private void btnSaoLuu_Click(object sender, EventArgs e)
        {
            string database = con.Database.ToString();
            try
            {
                if (txtSaoLuu.Text == string.Empty)
                {
                    XtraMessageBox.Show("Vui lòng chọn lại đường dẫn", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string cmd = "BACKUP DATABASE [" + database + "] TO DISK='" + txtSaoLuu.Text + "\\" + "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".bak'";

                    using (SqlCommand command = new SqlCommand(cmd, con))
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }
                        command.ExecuteNonQuery();
                        con.Close();
                        XtraMessageBox.Show("Database đã được sao lưu.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnSaoLuu.Enabled = false;
                    }
                }
            }
            catch
            {
            }
        }

        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup files|*.bak";
            dlg.Title = "Khôi phục CSDL";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtKhoiPhuc.Text = dlg.FileName;
                btnKhoiPhuc.Enabled = true;
            }
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            string database = con.Database.ToString();
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            try
            {
                string sqlStmt2 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand bu2 = new SqlCommand(sqlStmt2, con);
                bu2.ExecuteNonQuery();

                string sqlStmt3 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + txtKhoiPhuc.Text + "'WITH REPLACE;";
                SqlCommand bu3 = new SqlCommand(sqlStmt3, con);
                bu3.ExecuteNonQuery();

                string sqlStmt4 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand bu4 = new SqlCommand(sqlStmt4, con);
                bu4.ExecuteNonQuery();

                XtraMessageBox.Show("Database đã được khôi phục.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi không thể khôi phục\n" + ex.ToString(), "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}