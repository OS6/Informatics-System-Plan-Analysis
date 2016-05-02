namespace XoSoKienThiet.Presentation
{
    partial class frmDOITAC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTiLeHoaHong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.cbLoaiDoiTac = new System.Windows.Forms.ComboBox();
            this.btSua = new System.Windows.Forms.Button();
            this.dGVDanhSachDoiTac = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaDoiTac = new System.Windows.Forms.TextBox();
            this.btXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachDoiTac)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(428, 87);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(100, 20);
            this.txtDiaChi.TabIndex = 1;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(92, 166);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(100, 20);
            this.txtSDT.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(428, 43);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(92, 127);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(100, 20);
            this.txtTen.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Loại đối tác";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "SĐT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email";
            // 
            // txtTiLeHoaHong
            // 
            this.txtTiLeHoaHong.Location = new System.Drawing.Point(428, 127);
            this.txtTiLeHoaHong.Name = "txtTiLeHoaHong";
            this.txtTiLeHoaHong.Size = new System.Drawing.Size(100, 20);
            this.txtTiLeHoaHong.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(347, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tỉ lệ hoa hồng";
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(34, 436);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 12;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // cbLoaiDoiTac
            // 
            this.cbLoaiDoiTac.FormattingEnabled = true;
            this.cbLoaiDoiTac.Location = new System.Drawing.Point(92, 86);
            this.cbLoaiDoiTac.Name = "cbLoaiDoiTac";
            this.cbLoaiDoiTac.Size = new System.Drawing.Size(100, 21);
            this.cbLoaiDoiTac.TabIndex = 13;
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(244, 436);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 23);
            this.btSua.TabIndex = 14;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // dGVDanhSachDoiTac
            // 
            this.dGVDanhSachDoiTac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDanhSachDoiTac.Location = new System.Drawing.Point(15, 221);
            this.dGVDanhSachDoiTac.Name = "dGVDanhSachDoiTac";
            this.dGVDanhSachDoiTac.Size = new System.Drawing.Size(809, 150);
            this.dGVDanhSachDoiTac.TabIndex = 15;
            this.dGVDanhSachDoiTac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVDanhSachDoiTac_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Mã đối tác";
            // 
            // txtMaDoiTac
            // 
            this.txtMaDoiTac.Enabled = false;
            this.txtMaDoiTac.Location = new System.Drawing.Point(92, 46);
            this.txtMaDoiTac.Name = "txtMaDoiTac";
            this.txtMaDoiTac.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtMaDoiTac.Size = new System.Drawing.Size(100, 20);
            this.txtMaDoiTac.TabIndex = 17;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(449, 435);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 18;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // frmDOITAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 471);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.txtMaDoiTac);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dGVDanhSachDoiTac);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.cbLoaiDoiTac);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTiLeHoaHong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtDiaChi);
            this.Name = "frmDOITAC";
            this.Text = "ĐỐI TÁC";
            this.Load += new System.EventHandler(this.frmDOITAC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachDoiTac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTiLeHoaHong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.ComboBox cbLoaiDoiTac;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.DataGridView dGVDanhSachDoiTac;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaDoiTac;
        private System.Windows.Forms.Button btXoa;

    }
}