namespace XoSoKienThiet.PRESENT
{
    partial class frmTraCuuCongNo
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
            this.panelHeader = new DevExpress.XtraEditors.PanelControl();
            this.lbHeader = new DevExpress.XtraEditors.LabelControl();
            this.groupInfo = new DevExpress.XtraEditors.GroupControl();
            this.lcInfo = new DevExpress.XtraLayout.LayoutControl();
            this.lkTenDoiTac = new DevExpress.XtraEditors.LookUpEdit();
            this.btnHienThi = new DevExpress.XtraEditors.SimpleButton();
            this.rbtnLoaiDoiTac = new DevExpress.XtraEditors.RadioGroup();
            this.lcgInfo = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ssRight = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator2 = new DevExpress.XtraLayout.SimpleSeparator();
            this.layoutControlItem0 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupBASE = new DevExpress.XtraEditors.GroupControl();
            this.gcBASE = new DevExpress.XtraGrid.GridControl();
            this.gvBASE = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaDoiTac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaLoaiDoiTac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTiLeHoaHong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTiLeTieuThu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCongNo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelHeader)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupInfo)).BeginInit();
            this.groupInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcInfo)).BeginInit();
            this.lcInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkTenDoiTac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnLoaiDoiTac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBASE)).BeginInit();
            this.groupBASE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBASE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBASE)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.lbHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(982, 50);
            this.panelHeader.TabIndex = 15;
            // 
            // lbHeader
            // 
            this.lbHeader.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.Appearance.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbHeader.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbHeader.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHeader.Location = new System.Drawing.Point(2, 2);
            this.lbHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(978, 46);
            this.lbHeader.TabIndex = 1;
            this.lbHeader.Text = "TRA CỨU CÔNG NỢ ĐỐI TÁC";
            // 
            // groupInfo
            // 
            this.groupInfo.Controls.Add(this.lcInfo);
            this.groupInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupInfo.Location = new System.Drawing.Point(0, 50);
            this.groupInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(982, 102);
            this.groupInfo.TabIndex = 16;
            this.groupInfo.Text = "Thông tin công nợ";
            // 
            // lcInfo
            // 
            this.lcInfo.Controls.Add(this.lkTenDoiTac);
            this.lcInfo.Controls.Add(this.btnHienThi);
            this.lcInfo.Controls.Add(this.rbtnLoaiDoiTac);
            this.lcInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcInfo.Location = new System.Drawing.Point(2, 25);
            this.lcInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lcInfo.Name = "lcInfo";
            this.lcInfo.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(942, 402, 947, 692);
            this.lcInfo.Root = this.lcgInfo;
            this.lcInfo.Size = new System.Drawing.Size(978, 75);
            this.lcInfo.TabIndex = 0;
            this.lcInfo.Text = "layoutControl1";
            // 
            // lkTenDoiTac
            // 
            this.lkTenDoiTac.Location = new System.Drawing.Point(442, 16);
            this.lkTenDoiTac.Name = "lkTenDoiTac";
            this.lkTenDoiTac.Properties.AutoHeight = false;
            this.lkTenDoiTac.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkTenDoiTac.Properties.NullText = "";
            this.lkTenDoiTac.Size = new System.Drawing.Size(413, 43);
            this.lkTenDoiTac.StyleController = this.lcInfo;
            this.lkTenDoiTac.TabIndex = 10;
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(861, 16);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(98, 43);
            this.btnHienThi.StyleController = this.lcInfo;
            this.btnHienThi.TabIndex = 5;
            this.btnHienThi.Text = "Tìm kiếm";
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // rbtnLoaiDoiTac
            // 
            this.rbtnLoaiDoiTac.Location = new System.Drawing.Point(101, 19);
            this.rbtnLoaiDoiTac.Name = "rbtnLoaiDoiTac";
            this.rbtnLoaiDoiTac.Properties.Columns = 3;
            this.rbtnLoaiDoiTac.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Tất cả"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Công ty"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Đại lý")});
            this.rbtnLoaiDoiTac.Size = new System.Drawing.Size(253, 40);
            this.rbtnLoaiDoiTac.StyleController = this.lcInfo;
            this.rbtnLoaiDoiTac.TabIndex = 9;
            this.rbtnLoaiDoiTac.SelectedIndexChanged += new System.EventHandler(this.rbtnLoaiDoiTac_SelectedIndexChanged);
            // 
            // lcgInfo
            // 
            this.lcgInfo.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgInfo.GroupBordersVisible = false;
            this.lcgInfo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ssRight,
            this.simpleSeparator1,
            this.layoutControlItem1,
            this.simpleSeparator2,
            this.layoutControlItem0,
            this.layoutControlItem2});
            this.lcgInfo.Location = new System.Drawing.Point(0, 0);
            this.lcgInfo.Name = "Root";
            this.lcgInfo.OptionsItemText.TextToControlDistance = 4;
            this.lcgInfo.Size = new System.Drawing.Size(978, 75);
            this.lcgInfo.TextVisible = false;
            // 
            // ssRight
            // 
            this.ssRight.AllowHotTrack = false;
            this.ssRight.Location = new System.Drawing.Point(0, 3);
            this.ssRight.Name = "ssRight";
            this.ssRight.Size = new System.Drawing.Size(3, 46);
            this.ssRight.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(949, 0);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(3, 49);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnHienThi;
            this.layoutControlItem1.Location = new System.Drawing.Point(845, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(64, 33);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(104, 49);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // simpleSeparator2
            // 
            this.simpleSeparator2.AllowHotTrack = false;
            this.simpleSeparator2.Location = new System.Drawing.Point(0, 0);
            this.simpleSeparator2.Name = "simpleSeparator2";
            this.simpleSeparator2.Size = new System.Drawing.Size(344, 3);
            // 
            // layoutControlItem0
            // 
            this.layoutControlItem0.Control = this.rbtnLoaiDoiTac;
            this.layoutControlItem0.CustomizationFormText = "Loại đối tác: ";
            this.layoutControlItem0.Location = new System.Drawing.Point(3, 3);
            this.layoutControlItem0.MinSize = new System.Drawing.Size(138, 33);
            this.layoutControlItem0.Name = "layoutControlItem0";
            this.layoutControlItem0.Size = new System.Drawing.Size(341, 46);
            this.layoutControlItem0.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem0.Text = "Loại đối tác: ";
            this.layoutControlItem0.TextSize = new System.Drawing.Size(78, 17);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.lkTenDoiTac;
            this.layoutControlItem2.Location = new System.Drawing.Point(344, 0);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(138, 28);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(501, 49);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "Tên đối tác: ";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(78, 17);
            // 
            // groupBASE
            // 
            this.groupBASE.Controls.Add(this.gcBASE);
            this.groupBASE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBASE.Location = new System.Drawing.Point(0, 152);
            this.groupBASE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBASE.Name = "groupBASE";
            this.groupBASE.Size = new System.Drawing.Size(982, 451);
            this.groupBASE.TabIndex = 37;
            this.groupBASE.Text = "Danh sách công nợ đối tác";
            // 
            // gcBASE
            // 
            this.gcBASE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcBASE.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcBASE.Location = new System.Drawing.Point(2, 25);
            this.gcBASE.MainView = this.gvBASE;
            this.gcBASE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcBASE.Name = "gcBASE";
            this.gcBASE.Size = new System.Drawing.Size(978, 424);
            this.gcBASE.TabIndex = 1;
            this.gcBASE.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBASE});
            // 
            // gvBASE
            // 
            this.gvBASE.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaDoiTac,
            this.colMaLoaiDoiTac,
            this.colTen,
            this.colDiaChi,
            this.colSDT,
            this.colEmail,
            this.colTiLeHoaHong,
            this.colTiLeTieuThu,
            this.colCongNo});
            this.gvBASE.GridControl = this.gcBASE;
            this.gvBASE.Name = "gvBASE";
            this.gvBASE.OptionsBehavior.Editable = false;
            // 
            // colMaDoiTac
            // 
            this.colMaDoiTac.Caption = "Mã đối tác";
            this.colMaDoiTac.FieldName = "MaDoiTac";
            this.colMaDoiTac.Name = "colMaDoiTac";
            this.colMaDoiTac.Visible = true;
            this.colMaDoiTac.VisibleIndex = 0;
            // 
            // colMaLoaiDoiTac
            // 
            this.colMaLoaiDoiTac.FieldName = "MaLoaiDoiTac";
            this.colMaLoaiDoiTac.Name = "colMaLoaiDoiTac";
            // 
            // colTen
            // 
            this.colTen.Caption = "Tên";
            this.colTen.FieldName = "Ten";
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 1;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Caption = "Địa chỉ";
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 2;
            // 
            // colSDT
            // 
            this.colSDT.Caption = "Số điện thoại";
            this.colSDT.FieldName = "SDT";
            this.colSDT.Name = "colSDT";
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 3;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 4;
            // 
            // colTiLeHoaHong
            // 
            this.colTiLeHoaHong.Caption = "Tỉ lệ hoa hồng";
            this.colTiLeHoaHong.FieldName = "TiLeHoaHong";
            this.colTiLeHoaHong.Name = "colTiLeHoaHong";
            this.colTiLeHoaHong.Visible = true;
            this.colTiLeHoaHong.VisibleIndex = 5;
            // 
            // colTiLeTieuThu
            // 
            this.colTiLeTieuThu.FieldName = "TiLeTieuThu";
            this.colTiLeTieuThu.Name = "colTiLeTieuThu";
            // 
            // colCongNo
            // 
            this.colCongNo.Caption = "Công nợ";
            this.colCongNo.FieldName = "CongNo";
            this.colCongNo.Name = "colCongNo";
            this.colCongNo.Visible = true;
            this.colCongNo.VisibleIndex = 6;
            // 
            // frmTraCuuCongNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.groupBASE);
            this.Controls.Add(this.groupInfo);
            this.Controls.Add(this.panelHeader);
            this.Name = "frmTraCuuCongNo";
            this.Text = "Tra cứu công nợ đối tác";
            this.Load += new System.EventHandler(this.frmTraCuuCongNo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelHeader)).EndInit();
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupInfo)).EndInit();
            this.groupInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcInfo)).EndInit();
            this.lcInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lkTenDoiTac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnLoaiDoiTac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBASE)).EndInit();
            this.groupBASE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcBASE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBASE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelHeader;
        private DevExpress.XtraEditors.LabelControl lbHeader;
        private DevExpress.XtraEditors.GroupControl groupInfo;
        private DevExpress.XtraLayout.LayoutControl lcInfo;
        private DevExpress.XtraEditors.SimpleButton btnHienThi;
        private DevExpress.XtraLayout.LayoutControlGroup lcgInfo;
        private DevExpress.XtraLayout.SimpleSeparator ssRight;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator2;
        private DevExpress.XtraEditors.GroupControl groupBASE;
        private DevExpress.XtraGrid.GridControl gcBASE;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBASE;
        private DevExpress.XtraEditors.RadioGroup rbtnLoaiDoiTac;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem0;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDoiTac;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLoaiDoiTac;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colTiLeHoaHong;
        private DevExpress.XtraGrid.Columns.GridColumn colTiLeTieuThu;
        private DevExpress.XtraGrid.Columns.GridColumn colCongNo;
        private DevExpress.XtraEditors.LookUpEdit lkTenDoiTac;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}