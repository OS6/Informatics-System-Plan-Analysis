namespace XoSoKienThiet
{
    partial class frmBASE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBASE));
            this.barButtonManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barActionButton = new DevExpress.XtraBars.Bar();
            this.barbtnReload = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnSave = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnClose = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barButtonManager)).BeginInit();
            this.SuspendLayout();
            // 
            // barButtonManager
            // 
            this.barButtonManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barActionButton});
            this.barButtonManager.DockControls.Add(this.barDockControlTop);
            this.barButtonManager.DockControls.Add(this.barDockControlBottom);
            this.barButtonManager.DockControls.Add(this.barDockControlLeft);
            this.barButtonManager.DockControls.Add(this.barDockControlRight);
            this.barButtonManager.Form = this;
            this.barButtonManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barbtnReload,
            this.barbtnAdd,
            this.barbtnEdit,
            this.barbtnDelete,
            this.barbtnSave,
            this.barbtnClose});
            this.barButtonManager.MaxItemId = 6;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(702, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 553);
            this.barDockControlBottom.Size = new System.Drawing.Size(702, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 514);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(702, 39);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 514);
            // 
            // barActionButton
            // 
            this.barActionButton.BarName = "Tools";
            this.barActionButton.DockCol = 0;
            this.barActionButton.DockRow = 0;
            this.barActionButton.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barActionButton.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barbtnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barbtnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barbtnEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barbtnDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barbtnSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barbtnClose, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barActionButton.OptionsBar.AllowQuickCustomization = false;
            this.barActionButton.OptionsBar.DrawDragBorder = false;
            this.barActionButton.OptionsBar.UseWholeRow = true;
            this.barActionButton.Text = "Tools";
            // 
            // barbtnReload
            // 
            this.barbtnReload.Caption = "Nạp";
            this.barbtnReload.Glyph = ((System.Drawing.Image)(resources.GetObject("barbtnReload.Glyph")));
            this.barbtnReload.Id = 0;
            this.barbtnReload.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barbtnReload.LargeGlyph")));
            this.barbtnReload.Name = "barbtnReload";
            // 
            // barbtnAdd
            // 
            this.barbtnAdd.Caption = "Thêm";
            this.barbtnAdd.Glyph = ((System.Drawing.Image)(resources.GetObject("barbtnAdd.Glyph")));
            this.barbtnAdd.Id = 1;
            this.barbtnAdd.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barbtnAdd.LargeGlyph")));
            this.barbtnAdd.Name = "barbtnAdd";
            // 
            // barbtnEdit
            // 
            this.barbtnEdit.Caption = "Sửa";
            this.barbtnEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("barbtnEdit.Glyph")));
            this.barbtnEdit.Id = 2;
            this.barbtnEdit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barbtnEdit.LargeGlyph")));
            this.barbtnEdit.Name = "barbtnEdit";
            // 
            // barbtnDelete
            // 
            this.barbtnDelete.Caption = "Xóa";
            this.barbtnDelete.Glyph = ((System.Drawing.Image)(resources.GetObject("barbtnDelete.Glyph")));
            this.barbtnDelete.Id = 3;
            this.barbtnDelete.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barbtnDelete.LargeGlyph")));
            this.barbtnDelete.Name = "barbtnDelete";
            // 
            // barbtnSave
            // 
            this.barbtnSave.Caption = "Lưu";
            this.barbtnSave.Glyph = ((System.Drawing.Image)(resources.GetObject("barbtnSave.Glyph")));
            this.barbtnSave.Id = 4;
            this.barbtnSave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barbtnSave.LargeGlyph")));
            this.barbtnSave.Name = "barbtnSave";
            // 
            // barbtnClose
            // 
            this.barbtnClose.Caption = "Đóng";
            this.barbtnClose.Glyph = ((System.Drawing.Image)(resources.GetObject("barbtnClose.Glyph")));
            this.barbtnClose.Id = 5;
            this.barbtnClose.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barbtnClose.LargeGlyph")));
            this.barbtnClose.Name = "barbtnClose";
            // 
            // frmBASE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 553);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmBASE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BASE";
            ((System.ComponentModel.ISupportInitialize)(this.barButtonManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barButtonManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        protected DevExpress.XtraBars.Bar barActionButton;
        private DevExpress.XtraBars.BarButtonItem barbtnReload;
        private DevExpress.XtraBars.BarButtonItem barbtnAdd;
        private DevExpress.XtraBars.BarButtonItem barbtnEdit;
        private DevExpress.XtraBars.BarButtonItem barbtnDelete;
        private DevExpress.XtraBars.BarButtonItem barbtnSave;
        private DevExpress.XtraBars.BarButtonItem barbtnClose;
    }
}

