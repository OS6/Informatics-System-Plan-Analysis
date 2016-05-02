namespace XoSoKienThiet.Presentation
{
    partial class frmCOCAUGIAITHUONG
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
            this.cbLoaiVe = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCoCauGiaiThuong = new System.Windows.Forms.DataGridView();
            this.btSave = new System.Windows.Forms.Button();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaiThuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienTrung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoGiai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTienTrung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoCauGiaiThuong)).BeginInit();
            this.SuspendLayout();
            // 
            // cbLoaiVe
            // 
            this.cbLoaiVe.FormattingEnabled = true;
            this.cbLoaiVe.Location = new System.Drawing.Point(150, 13);
            this.cbLoaiVe.Name = "cbLoaiVe";
            this.cbLoaiVe.Size = new System.Drawing.Size(121, 21);
            this.cbLoaiVe.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại vé";
            // 
            // dgvCoCauGiaiThuong
            // 
            this.dgvCoCauGiaiThuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoCauGiaiThuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.GiaiThuong,
            this.SoTienTrung,
            this.SoGiai,
            this.TongTienTrung});
            this.dgvCoCauGiaiThuong.Location = new System.Drawing.Point(43, 71);
            this.dgvCoCauGiaiThuong.Name = "dgvCoCauGiaiThuong";
            this.dgvCoCauGiaiThuong.Size = new System.Drawing.Size(431, 150);
            this.dgvCoCauGiaiThuong.TabIndex = 2;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(126, 226);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 3;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // GiaiThuong
            // 
            this.GiaiThuong.HeaderText = "Giải thưởng";
            this.GiaiThuong.Name = "GiaiThuong";
            // 
            // SoTienTrung
            // 
            this.SoTienTrung.HeaderText = "Số tiền trúng";
            this.SoTienTrung.Name = "SoTienTrung";
            // 
            // SoGiai
            // 
            this.SoGiai.HeaderText = "Số giải";
            this.SoGiai.Name = "SoGiai";
            // 
            // TongTienTrung
            // 
            this.TongTienTrung.HeaderText = "Tổng tiền trúng";
            this.TongTienTrung.Name = "TongTienTrung";
            this.TongTienTrung.ReadOnly = true;
            // 
            // frmCOCAUGIAITHUONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 261);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.dgvCoCauGiaiThuong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLoaiVe);
            this.Name = "frmCOCAUGIAITHUONG";
            this.Text = "frmCOCAUGIAITHUONG";
            this.Load += new System.EventHandler(this.frmCOCAUGIAITHUONG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoCauGiaiThuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLoaiVe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCoCauGiaiThuong;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaiThuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTienTrung;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoGiai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTienTrung;
    }
}