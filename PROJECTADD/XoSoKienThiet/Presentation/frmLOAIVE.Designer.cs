namespace XoSoKienThiet.Presentation
{
    partial class frmLOAIVE
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
            this.dgvDanhLoaiVe = new System.Windows.Forms.DataGridView();
            this.ckbAdd = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btIns = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhLoaiVe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhLoaiVe
            // 
            this.dgvDanhLoaiVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhLoaiVe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ckbAdd});
            this.dgvDanhLoaiVe.Location = new System.Drawing.Point(65, 74);
            this.dgvDanhLoaiVe.Name = "dgvDanhLoaiVe";
            this.dgvDanhLoaiVe.Size = new System.Drawing.Size(430, 150);
            this.dgvDanhLoaiVe.TabIndex = 4;
            // 
            // ckbAdd
            // 
            this.ckbAdd.HeaderText = "";
            this.ckbAdd.Name = "ckbAdd";
            this.ckbAdd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ckbAdd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btIns
            // 
            this.btIns.Location = new System.Drawing.Point(210, 258);
            this.btIns.Name = "btIns";
            this.btIns.Size = new System.Drawing.Size(75, 23);
            this.btIns.TabIndex = 5;
            this.btIns.Text = "Thêm";
            this.btIns.UseVisualStyleBackColor = true;
            this.btIns.Click += new System.EventHandler(this.btIns_Click);
            // 
            // frmLOAIVE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 293);
            this.Controls.Add(this.btIns);
            this.Controls.Add(this.dgvDanhLoaiVe);
            this.Name = "frmLOAIVE";
            this.Text = "frmLOAIVE";
            this.Load += new System.EventHandler(this.frmLOAIVE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhLoaiVe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhLoaiVe;
        private System.Windows.Forms.Button btIns;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ckbAdd;
    }
}