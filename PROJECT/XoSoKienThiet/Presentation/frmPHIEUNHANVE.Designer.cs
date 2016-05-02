namespace XoSoKienThiet.Presentation
{
    partial class frmPHIEUNHANVE
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
            this.cbDoiTac = new System.Windows.Forms.ComboBox();
            this.txtTongSoTien = new System.Windows.Forms.TextBox();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lbDoiTac = new System.Windows.Forms.Label();
            this.cbNguoiLap = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachLoaiVe = new System.Windows.Forms.DataGridView();
            this.rbtCongTy = new System.Windows.Forms.RadioButton();
            this.rbtDaiLy = new System.Windows.Forms.RadioButton();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btIns = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLoaiVe)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDoiTac
            // 
            this.cbDoiTac.FormattingEnabled = true;
            this.cbDoiTac.Location = new System.Drawing.Point(164, 19);
            this.cbDoiTac.Name = "cbDoiTac";
            this.cbDoiTac.Size = new System.Drawing.Size(121, 21);
            this.cbDoiTac.TabIndex = 0;
            // 
            // txtTongSoTien
            // 
            this.txtTongSoTien.Enabled = false;
            this.txtTongSoTien.Location = new System.Drawing.Point(164, 56);
            this.txtTongSoTien.Name = "txtTongSoTien";
            this.txtTongSoTien.Size = new System.Drawing.Size(100, 20);
            this.txtTongSoTien.TabIndex = 1;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Location = new System.Drawing.Point(164, 94);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayLap.TabIndex = 2;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(164, 171);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(100, 20);
            this.txtTongTien.TabIndex = 3;
            // 
            // lbDoiTac
            // 
            this.lbDoiTac.AutoSize = true;
            this.lbDoiTac.Location = new System.Drawing.Point(41, 27);
            this.lbDoiTac.Name = "lbDoiTac";
            this.lbDoiTac.Size = new System.Drawing.Size(41, 13);
            this.lbDoiTac.TabIndex = 5;
            this.lbDoiTac.Text = "Đối tác";
            // 
            // cbNguoiLap
            // 
            this.cbNguoiLap.FormattingEnabled = true;
            this.cbNguoiLap.Location = new System.Drawing.Point(164, 129);
            this.cbNguoiLap.Name = "cbNguoiLap";
            this.cbNguoiLap.Size = new System.Drawing.Size(121, 21);
            this.cbNguoiLap.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tổng số vé";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ngày lập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Người lập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tổng tiền";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDoiTac);
            this.groupBox1.Controls.Add(this.lbDoiTac);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTongSoTien);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Controls.Add(this.cbNguoiLap);
            this.groupBox1.Controls.Add(this.dtpNgayLap);
            this.groupBox1.Location = new System.Drawing.Point(21, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 197);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDanhSachLoaiVe);
            this.groupBox2.Location = new System.Drawing.Point(21, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(789, 162);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách loại vé";
            // 
            // dgvDanhSachLoaiVe
            // 
            this.dgvDanhSachLoaiVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachLoaiVe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.SoLuongNhan,
            this.ThanhTien,
            this.SoLuongDK});
            this.dgvDanhSachLoaiVe.Location = new System.Drawing.Point(7, 28);
            this.dgvDanhSachLoaiVe.Name = "dgvDanhSachLoaiVe";
            this.dgvDanhSachLoaiVe.Size = new System.Drawing.Size(776, 128);
            this.dgvDanhSachLoaiVe.TabIndex = 0;
            // 
            // rbtCongTy
            // 
            this.rbtCongTy.AutoSize = true;
            this.rbtCongTy.Location = new System.Drawing.Point(642, 13);
            this.rbtCongTy.Name = "rbtCongTy";
            this.rbtCongTy.Size = new System.Drawing.Size(61, 17);
            this.rbtCongTy.TabIndex = 14;
            this.rbtCongTy.TabStop = true;
            this.rbtCongTy.Text = "Công ty";
            this.rbtCongTy.UseVisualStyleBackColor = true;
            this.rbtCongTy.CheckedChanged += new System.EventHandler(this.rbtCongTy_CheckedChanged);
            // 
            // rbtDaiLy
            // 
            this.rbtDaiLy.AutoSize = true;
            this.rbtDaiLy.Location = new System.Drawing.Point(519, 12);
            this.rbtDaiLy.Name = "rbtDaiLy";
            this.rbtDaiLy.Size = new System.Drawing.Size(51, 17);
            this.rbtDaiLy.TabIndex = 15;
            this.rbtDaiLy.TabStop = true;
            this.rbtDaiLy.Text = "Đại lý";
            this.rbtDaiLy.UseVisualStyleBackColor = true;
            this.rbtDaiLy.CheckedChanged += new System.EventHandler(this.rbtDaiLy_CheckedChanged);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // SoLuongNhan
            // 
            this.SoLuongNhan.HeaderText = "Số lượng nhận";
            this.SoLuongNhan.Name = "SoLuongNhan";
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // SoLuongDK
            // 
            this.SoLuongDK.HeaderText = "Số lượng đăng ký";
            this.SoLuongDK.Name = "SoLuongDK";
            // 
            // btIns
            // 
            this.btIns.Location = new System.Drawing.Point(244, 467);
            this.btIns.Name = "btIns";
            this.btIns.Size = new System.Drawing.Size(75, 23);
            this.btIns.TabIndex = 16;
            this.btIns.Text = "Thêm";
            this.btIns.UseVisualStyleBackColor = true;
            this.btIns.Click += new System.EventHandler(this.btIns_Click);
            // 
            // frmPHIEUNHANVE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 520);
            this.Controls.Add(this.btIns);
            this.Controls.Add(this.rbtDaiLy);
            this.Controls.Add(this.rbtCongTy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPHIEUNHANVE";
            this.Text = "PHIẾU NHẬN VÉ";
            this.Load += new System.EventHandler(this.frmPHIEUNHANVE_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLoaiVe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDoiTac;
        private System.Windows.Forms.TextBox txtTongSoTien;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lbDoiTac;
        private System.Windows.Forms.ComboBox cbNguoiLap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDanhSachLoaiVe;
        private System.Windows.Forms.RadioButton rbtCongTy;
        private System.Windows.Forms.RadioButton rbtDaiLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongDK;
        private System.Windows.Forms.Button btIns;
    }
}