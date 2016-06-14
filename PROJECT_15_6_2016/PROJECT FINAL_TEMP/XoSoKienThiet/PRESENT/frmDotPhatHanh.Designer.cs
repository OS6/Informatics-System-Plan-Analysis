namespace XoSoKienThiet.PRESENT
{
    partial class frmDotPhatHanh
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
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.deNgayXoSo = new DevExpress.XtraEditors.DateEdit();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.deNgayPhatHanh = new DevExpress.XtraEditors.DateEdit();
            this.lkCongTyPhatHanh = new DevExpress.XtraEditors.LookUpEdit();
            this.txtGioXoSo = new DevExpress.XtraEditors.TextEdit();
            this.lcgInfo = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupBASE = new DevExpress.XtraEditors.GroupControl();
            this.gcBASE = new DevExpress.XtraGrid.GridControl();
            this.gvBASE = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelHeader)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupInfo)).BeginInit();
            this.groupInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcInfo)).BeginInit();
            this.lcInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayXoSo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayXoSo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayPhatHanh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayPhatHanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkCongTyPhatHanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGioXoSo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBASE)).BeginInit();
            this.groupBASE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBASE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBASE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
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
            this.panelHeader.TabIndex = 17;
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
            this.lbHeader.Text = "ĐỢT PHÁT HÀNH";
            // 
            // groupInfo
            // 
            this.groupInfo.Controls.Add(this.lcInfo);
            this.groupInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupInfo.Location = new System.Drawing.Point(0, 50);
            this.groupInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(982, 123);
            this.groupInfo.TabIndex = 18;
            this.groupInfo.Text = "Thông tin đợt phát hành";
            // 
            // lcInfo
            // 
            this.lcInfo.Controls.Add(this.btnLuu);
            this.lcInfo.Controls.Add(this.deNgayXoSo);
            this.lcInfo.Controls.Add(this.btnThem);
            this.lcInfo.Controls.Add(this.deNgayPhatHanh);
            this.lcInfo.Controls.Add(this.lkCongTyPhatHanh);
            this.lcInfo.Controls.Add(this.txtGioXoSo);
            this.lcInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcInfo.Location = new System.Drawing.Point(2, 25);
            this.lcInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lcInfo.Name = "lcInfo";
            this.lcInfo.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(593, 382, 947, 692);
            this.lcInfo.Root = this.lcgInfo;
            this.lcInfo.Size = new System.Drawing.Size(978, 96);
            this.lcInfo.TabIndex = 0;
            this.lcInfo.Text = "layoutControl1";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(852, 16);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(110, 50);
            this.btnLuu.StyleController = this.lcInfo;
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // deNgayXoSo
            // 
            this.deNgayXoSo.EditValue = null;
            this.deNgayXoSo.Location = new System.Drawing.Point(508, 16);
            this.deNgayXoSo.Name = "deNgayXoSo";
            this.deNgayXoSo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayXoSo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayXoSo.Properties.ReadOnly = true;
            this.deNgayXoSo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.deNgayXoSo.Size = new System.Drawing.Size(235, 22);
            this.deNgayXoSo.StyleController = this.lcInfo;
            this.deNgayXoSo.TabIndex = 11;
            // 
            // btnThem
            // 
            this.btnThem.AllowFocus = false;
            this.btnThem.Location = new System.Drawing.Point(749, 16);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 50);
            this.btnThem.StyleController = this.lcInfo;
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // deNgayPhatHanh
            // 
            this.deNgayPhatHanh.EditValue = null;
            this.deNgayPhatHanh.Location = new System.Drawing.Point(133, 44);
            this.deNgayPhatHanh.Name = "deNgayPhatHanh";
            this.deNgayPhatHanh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayPhatHanh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayPhatHanh.Properties.ReadOnly = true;
            this.deNgayPhatHanh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.deNgayPhatHanh.Size = new System.Drawing.Size(252, 22);
            this.deNgayPhatHanh.StyleController = this.lcInfo;
            this.deNgayPhatHanh.TabIndex = 10;
            // 
            // lkCongTyPhatHanh
            // 
            this.lkCongTyPhatHanh.Location = new System.Drawing.Point(133, 16);
            this.lkCongTyPhatHanh.Name = "lkCongTyPhatHanh";
            this.lkCongTyPhatHanh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkCongTyPhatHanh.Properties.NullText = "";
            this.lkCongTyPhatHanh.Properties.PopupFormMinSize = new System.Drawing.Size(600, 0);
            this.lkCongTyPhatHanh.Properties.ReadOnly = true;
            this.lkCongTyPhatHanh.Size = new System.Drawing.Size(252, 22);
            this.lkCongTyPhatHanh.StyleController = this.lcInfo;
            this.lkCongTyPhatHanh.TabIndex = 9;
            this.lkCongTyPhatHanh.EditValueChanged += new System.EventHandler(this.lkCongTyPhatHanh_EditValueChanged);
            // 
            // txtGioXoSo
            // 
            this.txtGioXoSo.EditValue = "";
            this.txtGioXoSo.Location = new System.Drawing.Point(508, 44);
            this.txtGioXoSo.Name = "txtGioXoSo";
            this.txtGioXoSo.Properties.ReadOnly = true;
            this.txtGioXoSo.Size = new System.Drawing.Size(235, 22);
            this.txtGioXoSo.StyleController = this.lcInfo;
            this.txtGioXoSo.TabIndex = 7;
            // 
            // lcgInfo
            // 
            this.lcgInfo.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgInfo.GroupBordersVisible = false;
            this.lcgInfo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.lcgInfo.Location = new System.Drawing.Point(0, 0);
            this.lcgInfo.Name = "Root";
            this.lcgInfo.OptionsItemText.TextToControlDistance = 4;
            this.lcgInfo.Size = new System.Drawing.Size(978, 96);
            this.lcgInfo.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 56);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(952, 14);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lkCongTyPhatHanh;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(375, 28);
            this.layoutControlItem1.Text = "Công ty phát hành: ";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(113, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.deNgayPhatHanh;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(375, 28);
            this.layoutControlItem2.Text = "Ngày phát hành: ";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(113, 16);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnThem;
            this.layoutControlItem5.Location = new System.Drawing.Point(733, 0);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(52, 33);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(103, 56);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnLuu;
            this.layoutControlItem6.Location = new System.Drawing.Point(836, 0);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(40, 33);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(116, 56);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.deNgayXoSo;
            this.layoutControlItem3.Location = new System.Drawing.Point(375, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(358, 28);
            this.layoutControlItem3.Text = "Ngày xổ số: ";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(113, 17);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtGioXoSo;
            this.layoutControlItem4.Location = new System.Drawing.Point(375, 28);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(358, 28);
            this.layoutControlItem4.Text = "Giờ xổ số: ";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(113, 17);
            // 
            // groupBASE
            // 
            this.groupBASE.Controls.Add(this.gcBASE);
            this.groupBASE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBASE.Location = new System.Drawing.Point(0, 173);
            this.groupBASE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBASE.Name = "groupBASE";
            this.groupBASE.Size = new System.Drawing.Size(982, 430);
            this.groupBASE.TabIndex = 43;
            this.groupBASE.Text = "Danh sách đợt phát hành ";
            // 
            // gcBASE
            // 
            this.gcBASE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcBASE.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcBASE.Location = new System.Drawing.Point(2, 25);
            this.gcBASE.MainView = this.gvBASE;
            this.gcBASE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcBASE.Name = "gcBASE";
            this.gcBASE.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gcBASE.Size = new System.Drawing.Size(978, 403);
            this.gcBASE.TabIndex = 0;
            this.gcBASE.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBASE});
            // 
            // gvBASE
            // 
            this.gvBASE.GridControl = this.gcBASE;
            this.gvBASE.Name = "gvBASE";
            this.gvBASE.OptionsBehavior.Editable = false;
            this.gvBASE.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // frmDotPhatHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.groupBASE);
            this.Controls.Add(this.groupInfo);
            this.Controls.Add(this.panelHeader);
            this.Name = "frmDotPhatHanh";
            this.Text = "Đợt phát hành";
            this.Load += new System.EventHandler(this.frmDotPhatHanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelHeader)).EndInit();
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupInfo)).EndInit();
            this.groupInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcInfo)).EndInit();
            this.lcInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deNgayXoSo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayXoSo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayPhatHanh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayPhatHanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkCongTyPhatHanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGioXoSo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBASE)).EndInit();
            this.groupBASE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcBASE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBASE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelHeader;
        private DevExpress.XtraEditors.LabelControl lbHeader;
        private DevExpress.XtraEditors.GroupControl groupInfo;
        private DevExpress.XtraLayout.LayoutControl lcInfo;
        private DevExpress.XtraEditors.LookUpEdit lkCongTyPhatHanh;
        private DevExpress.XtraEditors.TextEdit txtGioXoSo;
        private DevExpress.XtraLayout.LayoutControlGroup lcgInfo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.GroupControl groupBASE;
        private DevExpress.XtraGrid.GridControl gcBASE;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBASE;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.DateEdit deNgayXoSo;
        private DevExpress.XtraEditors.DateEdit deNgayPhatHanh;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}