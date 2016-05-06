namespace XoSoKienThiet.Presentation
{
    partial class frmDANHSACHLOAIVE
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
            this.btIns = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCongTyPhatHanh = new System.Windows.Forms.ComboBox();
            this.dgvDanhSachLoaiVe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLoaiVe)).BeginInit();
            this.SuspendLayout();
            // 
            // btIns
            // 
            this.btIns.Location = new System.Drawing.Point(84, 226);
            this.btIns.Name = "btIns";
            this.btIns.Size = new System.Drawing.Size(75, 23);
            this.btIns.TabIndex = 0;
            this.btIns.Text = "Thêm";
            this.btIns.UseVisualStyleBackColor = true;
            this.btIns.Click += new System.EventHandler(this.btIns_Click);
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(291, 226);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(75, 23);
            this.btDel.TabIndex = 2;
            this.btDel.Text = "Xóa";
            this.btDel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Công ty phát hành";
            // 
            // cbCongTyPhatHanh
            // 
            this.cbCongTyPhatHanh.FormattingEnabled = true;
            this.cbCongTyPhatHanh.Location = new System.Drawing.Point(149, 13);
            this.cbCongTyPhatHanh.Name = "cbCongTyPhatHanh";
            this.cbCongTyPhatHanh.Size = new System.Drawing.Size(121, 21);
            this.cbCongTyPhatHanh.TabIndex = 4;
            // 
            // dgvDanhSachLoaiVe
            // 
            this.dgvDanhSachLoaiVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachLoaiVe.Location = new System.Drawing.Point(105, 59);
            this.dgvDanhSachLoaiVe.Name = "dgvDanhSachLoaiVe";
            this.dgvDanhSachLoaiVe.Size = new System.Drawing.Size(240, 150);
            this.dgvDanhSachLoaiVe.TabIndex = 5;
            // 
            // frmDANHSACHLOAIVE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 261);
            this.Controls.Add(this.dgvDanhSachLoaiVe);
            this.Controls.Add(this.cbCongTyPhatHanh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btIns);
            this.Name = "frmDANHSACHLOAIVE";
            this.Text = "frmDANHSACHLOAIVE";
            this.Load += new System.EventHandler(this.frmDANHSACHLOAIVE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLoaiVe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btIns;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCongTyPhatHanh;
        private System.Windows.Forms.DataGridView dgvDanhSachLoaiVe;
    }
}