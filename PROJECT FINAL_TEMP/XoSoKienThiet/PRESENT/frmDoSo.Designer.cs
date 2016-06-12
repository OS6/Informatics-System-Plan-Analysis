namespace XoSoKienThiet.PRESENT
{
    partial class frmDoSo
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
            this.components = new System.ComponentModel.Container();
            this.panelHeader = new DevExpress.XtraEditors.PanelControl();
            this.lbHeader = new DevExpress.XtraEditors.LabelControl();
            this.groupBASE = new DevExpress.XtraEditors.GroupControl();
            this.gcBASE = new DevExpress.XtraGrid.GridControl();
            this.gvBASE = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.bindingGridview = new System.Windows.Forms.BindingSource(this.components);
            this.groupInfo = new DevExpress.XtraEditors.GroupControl();
            this.lcInfo = new DevExpress.XtraLayout.LayoutControl();
            this.btnDoSo = new System.Windows.Forms.Button();
            this.txtSo = new DevExpress.XtraEditors.TextEdit();
            this.lkLoaiVe = new DevExpress.XtraEditors.LookUpEdit();
            this.lkNgayXoSo = new DevExpress.XtraEditors.LookUpEdit();
            this.lcgInfo = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ssLeft = new DevExpress.XtraLayout.SimpleSeparator();
            this.ssRight = new DevExpress.XtraLayout.SimpleSeparator();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.panelHeader)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBASE)).BeginInit();
            this.groupBASE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBASE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBASE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupInfo)).BeginInit();
            this.groupInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcInfo)).BeginInit();
            this.lcInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkLoaiVe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkNgayXoSo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.lbHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 50);
            this.panelHeader.TabIndex = 14;
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
            this.lbHeader.Size = new System.Drawing.Size(996, 46);
            this.lbHeader.TabIndex = 1;
            this.lbHeader.Text = "DÒ SỐ";
            // 
            // groupBASE
            // 
            this.groupBASE.Controls.Add(this.gcBASE);
            this.groupBASE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBASE.Location = new System.Drawing.Point(0, 170);
            this.groupBASE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBASE.Name = "groupBASE";
            this.groupBASE.Size = new System.Drawing.Size(1000, 433);
            this.groupBASE.TabIndex = 28;
            this.groupBASE.Text = "Kết quả dò số";
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
            this.gcBASE.Size = new System.Drawing.Size(996, 406);
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
            // groupInfo
            // 
            this.groupInfo.Controls.Add(this.lcInfo);
            this.groupInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupInfo.Location = new System.Drawing.Point(0, 50);
            this.groupInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(1000, 120);
            this.groupInfo.TabIndex = 27;
            this.groupInfo.Text = "Thông tin dò số";
            // 
            // lcInfo
            // 
            this.lcInfo.Controls.Add(this.btnDoSo);
            this.lcInfo.Controls.Add(this.txtSo);
            this.lcInfo.Controls.Add(this.lkLoaiVe);
            this.lcInfo.Controls.Add(this.lkNgayXoSo);
            this.lcInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcInfo.Location = new System.Drawing.Point(2, 25);
            this.lcInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lcInfo.Name = "lcInfo";
            this.lcInfo.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(924, 240, 947, 692);
            this.lcInfo.Root = this.lcgInfo;
            this.lcInfo.Size = new System.Drawing.Size(996, 93);
            this.lcInfo.TabIndex = 0;
            this.lcInfo.Text = "layoutControl1";
            // 
            // btnDoSo
            // 
            this.btnDoSo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDoSo.Location = new System.Drawing.Point(901, 16);
            this.btnDoSo.Name = "btnDoSo";
            this.btnDoSo.Size = new System.Drawing.Size(79, 61);
            this.btnDoSo.TabIndex = 19;
            this.btnDoSo.Text = "Dò Số";
            this.btnDoSo.UseVisualStyleBackColor = true;
            this.btnDoSo.Click += new System.EventHandler(this.btnDoSo_Click);
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(95, 16);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(305, 22);
            this.txtSo.StyleController = this.lcInfo;
            this.txtSo.TabIndex = 18;
            // 
            // lkLoaiVe
            // 
            this.lkLoaiVe.Location = new System.Drawing.Point(95, 44);
            this.lkLoaiVe.Name = "lkLoaiVe";
            this.lkLoaiVe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkLoaiVe.Properties.DisplayMember = "MaPhieuDangKy";
            this.lkLoaiVe.Properties.NullText = "";
            this.lkLoaiVe.Properties.Tag = "<Null>";
            this.lkLoaiVe.Properties.ValueMember = "MaPhieuDangKy";
            this.lkLoaiVe.Size = new System.Drawing.Size(305, 22);
            this.lkLoaiVe.StyleController = this.lcInfo;
            this.lkLoaiVe.TabIndex = 17;
            // 
            // lkNgayXoSo
            // 
            this.lkNgayXoSo.Location = new System.Drawing.Point(485, 16);
            this.lkNgayXoSo.Name = "lkNgayXoSo";
            this.lkNgayXoSo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkNgayXoSo.Properties.DisplayFormat.FormatString = "d";
            this.lkNgayXoSo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.lkNgayXoSo.Properties.EditFormat.FormatString = "d";
            this.lkNgayXoSo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.lkNgayXoSo.Properties.NullText = "";
            this.lkNgayXoSo.Size = new System.Drawing.Size(410, 22);
            this.lkNgayXoSo.StyleController = this.lcInfo;
            this.lkNgayXoSo.TabIndex = 15;
            // 
            // lcgInfo
            // 
            this.lcgInfo.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgInfo.GroupBordersVisible = false;
            this.lcgInfo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ssLeft,
            this.ssRight,
            this.layoutControlItem6,
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem4,
            this.simpleSeparator1});
            this.lcgInfo.Location = new System.Drawing.Point(0, 0);
            this.lcgInfo.Name = "Root";
            this.lcgInfo.OptionsItemText.TextToControlDistance = 4;
            this.lcgInfo.Size = new System.Drawing.Size(996, 93);
            this.lcgInfo.TextVisible = false;
            // 
            // ssLeft
            // 
            this.ssLeft.AllowHotTrack = false;
            this.ssLeft.Location = new System.Drawing.Point(557, 56);
            this.ssLeft.Name = "ssLeft";
            this.ssLeft.Size = new System.Drawing.Size(328, 11);
            // 
            // ssRight
            // 
            this.ssRight.AllowHotTrack = false;
            this.ssRight.Location = new System.Drawing.Point(0, 56);
            this.ssRight.Name = "ssRight";
            this.ssRight.Size = new System.Drawing.Size(557, 11);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.lkLoaiVe;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(390, 28);
            this.layoutControlItem6.Text = "Loại vé:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(75, 17);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.lkNgayXoSo;
            this.layoutControlItem2.Location = new System.Drawing.Point(390, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(495, 28);
            this.layoutControlItem2.Text = "Ngày xổ số:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(75, 17);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtSo;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(390, 28);
            this.layoutControlItem1.Text = "Số cần dò:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(75, 17);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnDoSo;
            this.layoutControlItem4.Location = new System.Drawing.Point(885, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(85, 67);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 87;
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(390, 28);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(495, 28);
            // 
            // frmDoSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 603);
            this.Controls.Add(this.groupBASE);
            this.Controls.Add(this.groupInfo);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDoSo";
            this.Text = "Dò số";
            this.Load += new System.EventHandler(this.frmDoSo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelHeader)).EndInit();
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBASE)).EndInit();
            this.groupBASE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcBASE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBASE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupInfo)).EndInit();
            this.groupInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcInfo)).EndInit();
            this.lcInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkLoaiVe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkNgayXoSo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelHeader;
        private DevExpress.XtraEditors.LabelControl lbHeader;
        private DevExpress.XtraEditors.GroupControl groupBASE;
        private DevExpress.XtraGrid.GridControl gcBASE;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBASE;
        private DevExpress.XtraEditors.GroupControl groupInfo;
        private DevExpress.XtraLayout.LayoutControl lcInfo;
        private DevExpress.XtraEditors.TextEdit txtSo;
        private DevExpress.XtraEditors.LookUpEdit lkLoaiVe;
        private DevExpress.XtraLayout.LayoutControlGroup lcgInfo;
        private DevExpress.XtraLayout.SimpleSeparator ssLeft;
        private DevExpress.XtraLayout.SimpleSeparator ssRight;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.BindingSource bindingGridview;
        private System.Windows.Forms.Button btnDoSo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.LookUpEdit lkNgayXoSo;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
    }
}