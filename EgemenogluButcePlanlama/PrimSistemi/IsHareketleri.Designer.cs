namespace EgemenOgluRaporlama.PrimSistemi
{
    partial class IsHareketleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IsHareketleri));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colBitisTarihi = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.menu24x24 = new DevExpress.Utils.ImageCollection(this.components);
            this.raporKaydet = new System.Windows.Forms.SaveFileDialog();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnYenile = new DevExpress.XtraBars.BarButtonItem();
            this.btnYeni = new DevExpress.XtraBars.BarButtonItem();
            this.btnDuzenle = new DevExpress.XtraBars.BarButtonItem();
            this.btnSil = new DevExpress.XtraBars.BarButtonItem();
            this.btnExcel = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.musterininVerdigiIslerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSRaporlama = new EgemenOgluRaporlama.DSRaporlama();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCariKod = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCariUnvan1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCariUnvan2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSmKodu = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSmAdi = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colProjeKod = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colProjeAdi = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colProjeBaslamaTarihi = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colEkAlan1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colEkAlan2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colEkAlan3 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colGün = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.musterininVerdigiIslerTableAdapter = new EgemenOgluRaporlama.DSRaporlamaTableAdapters.MusterininVerdigiIslerTableAdapter();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.tableAdapterManager = new EgemenOgluRaporlama.DSRaporlamaTableAdapters.TableAdapterManager();
            this.queryies1 = new EgemenOgluRaporlama.DSRaporlamaTableAdapters.Queryies();
            ((System.ComponentModel.ISupportInitialize)(this.menu24x24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterininVerdigiIslerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRaporlama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // colBitisTarihi
            // 
            this.colBitisTarihi.Caption = "Son Tahsilat Kabul Tarihi";
            this.colBitisTarihi.FieldName = "BitisTarihi";
            this.colBitisTarihi.Name = "colBitisTarihi";
            this.colBitisTarihi.OptionsColumn.ReadOnly = true;
            this.colBitisTarihi.Visible = true;
            this.colBitisTarihi.Width = 135;
            // 
            // menu24x24
            // 
            this.menu24x24.ImageSize = new System.Drawing.Size(24, 24);
            this.menu24x24.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("menu24x24.ImageStream")));
            this.menu24x24.Images.SetKeyName(0, "Delete.png");
            this.menu24x24.Images.SetKeyName(1, "exporttoexcel.png");
            this.menu24x24.Images.SetKeyName(2, "Refresh.png");
            this.menu24x24.Images.SetKeyName(3, "Save.png");
            this.menu24x24.Images.SetKeyName(4, "1371994793_edit.png");
            this.menu24x24.Images.SetKeyName(5, "yeni.png");
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Images = this.menu24x24;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnYenile,
            this.btnYeni,
            this.btnDuzenle,
            this.btnSil,
            this.btnExcel});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnYenile, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnYeni, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDuzenle, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSil, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExcel, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnYenile
            // 
            this.btnYenile.Caption = "Yenile";
            this.btnYenile.Id = 0;
            this.btnYenile.ImageIndex = 2;
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnYenile_ItemClick);
            // 
            // btnYeni
            // 
            this.btnYeni.Caption = "Yeni";
            this.btnYeni.Id = 1;
            this.btnYeni.ImageIndex = 5;
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnYeni_ItemClick);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Caption = "Düzenle";
            this.btnDuzenle.Id = 2;
            this.btnDuzenle.ImageIndex = 4;
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDuzenle_ItemClick);
            // 
            // btnSil
            // 
            this.btnSil.Caption = "Sil";
            this.btnSil.Id = 3;
            this.btnSil.ImageIndex = 0;
            this.btnSil.Name = "btnSil";
            this.btnSil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSil_ItemClick);
            // 
            // btnExcel
            // 
            this.btnExcel.Caption = "Excele Aktar";
            this.btnExcel.Id = 4;
            this.btnExcel.ImageIndex = 1;
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExcel_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(889, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 459);
            this.barDockControlBottom.Size = new System.Drawing.Size(889, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 425);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(889, 34);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 425);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.musterininVerdigiIslerBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 34);
            this.gridControl1.MainView = this.bandedGridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(889, 425);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1});
            // 
            // musterininVerdigiIslerBindingSource
            // 
            this.musterininVerdigiIslerBindingSource.DataMember = "MusterininVerdigiIsler";
            this.musterininVerdigiIslerBindingSource.DataSource = this.dSRaporlama;
            // 
            // dSRaporlama
            // 
            this.dSRaporlama.DataSetName = "DSRaporlama";
            this.dSRaporlama.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Appearance.BandPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.bandedGridView1.Appearance.BandPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.bandedGridView1.Appearance.BandPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.bandedGridView1.Appearance.BandPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.bandedGridView1.Appearance.BandPanel.ForeColor = System.Drawing.Color.Black;
            this.bandedGridView1.Appearance.BandPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.bandedGridView1.Appearance.BandPanel.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.BandPanel.Options.UseBorderColor = true;
            this.bandedGridView1.Appearance.BandPanel.Options.UseFont = true;
            this.bandedGridView1.Appearance.BandPanel.Options.UseForeColor = true;
            this.bandedGridView1.Appearance.BandPanelBackground.BackColor = System.Drawing.Color.White;
            this.bandedGridView1.Appearance.BandPanelBackground.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.bandedGridView1.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.bandedGridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.bandedGridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.bandedGridView1.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.bandedGridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.bandedGridView1.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.bandedGridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.bandedGridView1.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.bandedGridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.bandedGridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.bandedGridView1.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.bandedGridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.bandedGridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.bandedGridView1.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.bandedGridView1.Appearance.Empty.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.bandedGridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.bandedGridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.EvenRow.Options.UseForeColor = true;
            this.bandedGridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.bandedGridView1.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.bandedGridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.bandedGridView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.bandedGridView1.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.bandedGridView1.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.bandedGridView1.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.bandedGridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.bandedGridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.bandedGridView1.Appearance.FilterPanel.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.FilterPanel.Options.UseForeColor = true;
            this.bandedGridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.bandedGridView1.Appearance.FixedLine.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.bandedGridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.bandedGridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.FocusedCell.Options.UseForeColor = true;
            this.bandedGridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.bandedGridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.bandedGridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.bandedGridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.bandedGridView1.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.bandedGridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.bandedGridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.bandedGridView1.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.bandedGridView1.Appearance.FooterPanel.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.bandedGridView1.Appearance.FooterPanel.Options.UseForeColor = true;
            this.bandedGridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.bandedGridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.bandedGridView1.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.bandedGridView1.Appearance.GroupButton.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.GroupButton.Options.UseBorderColor = true;
            this.bandedGridView1.Appearance.GroupButton.Options.UseForeColor = true;
            this.bandedGridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.bandedGridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.bandedGridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.bandedGridView1.Appearance.GroupFooter.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.bandedGridView1.Appearance.GroupFooter.Options.UseForeColor = true;
            this.bandedGridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.bandedGridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.bandedGridView1.Appearance.GroupPanel.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.GroupPanel.Options.UseForeColor = true;
            this.bandedGridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.bandedGridView1.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.bandedGridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.bandedGridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.bandedGridView1.Appearance.GroupRow.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.GroupRow.Options.UseBorderColor = true;
            this.bandedGridView1.Appearance.GroupRow.Options.UseFont = true;
            this.bandedGridView1.Appearance.GroupRow.Options.UseForeColor = true;
            this.bandedGridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.bandedGridView1.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.bandedGridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.bandedGridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.bandedGridView1.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.bandedGridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.bandedGridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.bandedGridView1.Appearance.HeaderPanelBackground.BackColor = System.Drawing.Color.White;
            this.bandedGridView1.Appearance.HeaderPanelBackground.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.bandedGridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.bandedGridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.bandedGridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.bandedGridView1.Appearance.HorzLine.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.bandedGridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.bandedGridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.OddRow.Options.UseForeColor = true;
            this.bandedGridView1.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.bandedGridView1.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.bandedGridView1.Appearance.Preview.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.Preview.Options.UseForeColor = true;
            this.bandedGridView1.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.bandedGridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.bandedGridView1.Appearance.Row.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.Row.Options.UseForeColor = true;
            this.bandedGridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.bandedGridView1.Appearance.RowSeparator.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.bandedGridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.bandedGridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.bandedGridView1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.bandedGridView1.Appearance.VertLine.Options.UseBackColor = true;
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colID,
            this.colCariKod,
            this.colCariUnvan1,
            this.colCariUnvan2,
            this.colSmKodu,
            this.colSmAdi,
            this.colProjeKod,
            this.colProjeAdi,
            this.colProjeBaslamaTarihi,
            this.colEkAlan1,
            this.colEkAlan2,
            this.colEkAlan3,
            this.colGün,
            this.colBitisTarihi});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colBitisTarihi;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition1.Expression = "[BitisTarihi] >  Now()";
            styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            styleFormatCondition2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic);
            styleFormatCondition2.Appearance.Options.UseBackColor = true;
            styleFormatCondition2.Appearance.Options.UseFont = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colBitisTarihi;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition2.Expression = "[BitisTarihi] <= Now()";
            this.bandedGridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2});
            this.bandedGridView1.GridControl = this.gridControl1;
            this.bandedGridView1.Name = "bandedGridView1";
            this.bandedGridView1.OptionsBehavior.Editable = false;
            this.bandedGridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.bandedGridView1.OptionsView.ColumnAutoWidth = false;
            this.bandedGridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.bandedGridView1.OptionsView.EnableAppearanceOddRow = true;
            this.bandedGridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "İşi Getiren Bilgileri";
            this.gridBand1.Columns.Add(this.colID);
            this.gridBand1.Columns.Add(this.colCariKod);
            this.gridBand1.Columns.Add(this.colCariUnvan1);
            this.gridBand1.Columns.Add(this.colCariUnvan2);
            this.gridBand1.Columns.Add(this.colSmKodu);
            this.gridBand1.Columns.Add(this.colSmAdi);
            this.gridBand1.MinWidth = 20;
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 312;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            // 
            // colCariKod
            // 
            this.colCariKod.FieldName = "CariKod";
            this.colCariKod.Name = "colCariKod";
            this.colCariKod.Visible = true;
            this.colCariKod.Width = 77;
            // 
            // colCariUnvan1
            // 
            this.colCariUnvan1.FieldName = "CariUnvan1";
            this.colCariUnvan1.Name = "colCariUnvan1";
            this.colCariUnvan1.Visible = true;
            this.colCariUnvan1.Width = 81;
            // 
            // colCariUnvan2
            // 
            this.colCariUnvan2.FieldName = "CariUnvan2";
            this.colCariUnvan2.Name = "colCariUnvan2";
            this.colCariUnvan2.Width = 81;
            // 
            // colSmKodu
            // 
            this.colSmKodu.FieldName = "SmKodu";
            this.colSmKodu.Name = "colSmKodu";
            this.colSmKodu.Visible = true;
            this.colSmKodu.Width = 77;
            // 
            // colSmAdi
            // 
            this.colSmAdi.FieldName = "SmAdi";
            this.colSmAdi.Name = "colSmAdi";
            this.colSmAdi.Visible = true;
            this.colSmAdi.Width = 77;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "İş Bilgileri";
            this.gridBand2.Columns.Add(this.colProjeKod);
            this.gridBand2.Columns.Add(this.colProjeAdi);
            this.gridBand2.Columns.Add(this.colProjeBaslamaTarihi);
            this.gridBand2.Columns.Add(this.colEkAlan1);
            this.gridBand2.Columns.Add(this.colEkAlan2);
            this.gridBand2.Columns.Add(this.colEkAlan3);
            this.gridBand2.Columns.Add(this.colGün);
            this.gridBand2.Columns.Add(this.colBitisTarihi);
            this.gridBand2.MinWidth = 20;
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.Width = 725;
            // 
            // colProjeKod
            // 
            this.colProjeKod.FieldName = "ProjeKod";
            this.colProjeKod.Name = "colProjeKod";
            this.colProjeKod.Visible = true;
            this.colProjeKod.Width = 78;
            // 
            // colProjeAdi
            // 
            this.colProjeAdi.FieldName = "ProjeAdi";
            this.colProjeAdi.Name = "colProjeAdi";
            this.colProjeAdi.Visible = true;
            this.colProjeAdi.Width = 78;
            // 
            // colProjeBaslamaTarihi
            // 
            this.colProjeBaslamaTarihi.FieldName = "ProjeBaslamaTarihi";
            this.colProjeBaslamaTarihi.Name = "colProjeBaslamaTarihi";
            this.colProjeBaslamaTarihi.Visible = true;
            this.colProjeBaslamaTarihi.Width = 122;
            // 
            // colEkAlan1
            // 
            this.colEkAlan1.FieldName = "EkAlan1";
            this.colEkAlan1.Name = "colEkAlan1";
            this.colEkAlan1.Visible = true;
            this.colEkAlan1.Width = 78;
            // 
            // colEkAlan2
            // 
            this.colEkAlan2.FieldName = "EkAlan2";
            this.colEkAlan2.Name = "colEkAlan2";
            this.colEkAlan2.Visible = true;
            this.colEkAlan2.Width = 78;
            // 
            // colEkAlan3
            // 
            this.colEkAlan3.FieldName = "EkAlan3";
            this.colEkAlan3.Name = "colEkAlan3";
            this.colEkAlan3.Visible = true;
            this.colEkAlan3.Width = 78;
            // 
            // colGün
            // 
            this.colGün.FieldName = "Gün";
            this.colGün.Name = "colGün";
            this.colGün.OptionsColumn.ReadOnly = true;
            this.colGün.Visible = true;
            this.colGün.Width = 78;
            // 
            // musterininVerdigiIslerTableAdapter
            // 
            this.musterininVerdigiIslerTableAdapter.ClearBeforeFill = true;
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.musterininVerdigiIslerBindingSource, "ID", true));
            this.txtID.Location = new System.Drawing.Point(23, 45);
            this.txtID.MenuManager = this.barManager1;
            this.txtID.Name = "txtID";
            this.txtID.Properties.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(10, 20);
            this.txtID.TabIndex = 9;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.gelirTablosuTableAdapter = null;
            this.tableAdapterManager.KASALARTableAdapter = null;
            this.tableAdapterManager.KullanicilarTableAdapter = null;
            this.tableAdapterManager.KurlarTableAdapter = null;
            this.tableAdapterManager.LookUpKullaniciTableAdapter = null;
            this.tableAdapterManager.prim_DonemTanimlariTableAdapter = null;
            this.tableAdapterManager.prim_GrupTanimlariTableAdapter = null;
            this.tableAdapterManager.prim_PrimGirisTableAdapter = null;
            this.tableAdapterManager.PrimOdemeleriTableAdapter = null;
            this.tableAdapterManager.TahsilatSureleriTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EgemenOgluRaporlama.DSRaporlamaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.YeniMusteriTableAdapter = null;
            // 
            // IsHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 459);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "IsHareketleri";
            this.Text = "İş Hareketleri";
            this.Load += new System.EventHandler(this.IsHareketleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menu24x24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterininVerdigiIslerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRaporlama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.ImageCollection menu24x24;
        private System.Windows.Forms.SaveFileDialog raporKaydet;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraBars.BarButtonItem btnYenile;
        private DevExpress.XtraBars.BarButtonItem btnYeni;
        private DevExpress.XtraBars.BarButtonItem btnDuzenle;
        private DevExpress.XtraBars.BarButtonItem btnSil;
        private DevExpress.XtraBars.BarButtonItem btnExcel;
        private DSRaporlama dSRaporlama;
        private System.Windows.Forms.BindingSource musterininVerdigiIslerBindingSource;
        private DSRaporlamaTableAdapters.MusterininVerdigiIslerTableAdapter musterininVerdigiIslerTableAdapter;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCariKod;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCariUnvan1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCariUnvan2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSmKodu;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSmAdi;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProjeKod;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProjeAdi;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProjeBaslamaTarihi;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colEkAlan1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colEkAlan2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colEkAlan3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colGün;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colBitisTarihi;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DSRaporlamaTableAdapters.TableAdapterManager tableAdapterManager;
        private DSRaporlamaTableAdapters.Queryies queryies1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
    }
}