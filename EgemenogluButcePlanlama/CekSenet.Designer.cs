namespace EgemenOgluRaporlama
{
    partial class CekSenet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CekSenet));
            this.menu24x24 = new DevExpress.Utils.ImageCollection(this.components);
            this.raporKaydet = new System.Windows.Forms.SaveFileDialog();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnTemizle = new DevExpress.XtraBars.BarButtonItem();
            this.btnSorgula = new DevExpress.XtraBars.BarButtonItem();
            this.btnExcelAktar = new DevExpress.XtraBars.BarButtonItem();
            this.btnTumunuAc = new DevExpress.XtraBars.BarButtonItem();
            this.btnTumunuKapat = new DevExpress.XtraBars.BarButtonItem();
            this.btnGrupAc = new DevExpress.XtraBars.BarButtonItem();
            this.btnGrupKapa = new DevExpress.XtraBars.BarButtonItem();
            this.btnEnUygunGenislik = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tarih2 = new System.Windows.Forms.DateTimePicker();
            this.tarih1 = new System.Windows.Forms.DateTimePicker();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.cekSenetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSRaporlama = new EgemenOgluRaporlama.DSRaporlama();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colİL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTİPİ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSMKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSMAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSONPOZİSYON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFERANS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colÇEKNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVADETARİHİ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUTAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colORJ_TUTAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colÖDENEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDÖVİZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDÖVİZKURU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKALANMİKTAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGÜN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cekSenetTableAdapter = new EgemenOgluRaporlama.DSRaporlamaTableAdapters.CekSenetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.menu24x24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cekSenetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRaporlama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu24x24
            // 
            this.menu24x24.ImageSize = new System.Drawing.Size(24, 24);
            this.menu24x24.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("menu24x24.ImageStream")));
            this.menu24x24.Images.SetKeyName(0, "search.png");
            this.menu24x24.Images.SetKeyName(1, "Refresh.png");
            this.menu24x24.Images.SetKeyName(2, "exporttoexcel.png");
            this.menu24x24.Images.SetKeyName(3, "tumunuAc.png");
            this.menu24x24.Images.SetKeyName(4, "tumunuKapa.png");
            this.menu24x24.Images.SetKeyName(5, "ac.png");
            this.menu24x24.Images.SetKeyName(6, "kapa.png");
            this.menu24x24.Images.SetKeyName(7, "bestfit.png");
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
            this.btnTemizle,
            this.btnSorgula,
            this.btnExcelAktar,
            this.btnTumunuAc,
            this.btnTumunuKapat,
            this.btnGrupAc,
            this.btnGrupKapa,
            this.btnEnUygunGenislik});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(90, 149);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTemizle, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSorgula, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExcelAktar, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTumunuAc, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTumunuKapat, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGrupAc, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGrupKapa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEnUygunGenislik, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Caption = "Temizle";
            this.btnTemizle.Id = 0;
            this.btnTemizle.ImageIndex = 1;
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTemizle_ItemClick);
            // 
            // btnSorgula
            // 
            this.btnSorgula.Caption = "Sorgula";
            this.btnSorgula.Id = 1;
            this.btnSorgula.ImageIndex = 0;
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSorgula_ItemClick);
            // 
            // btnExcelAktar
            // 
            this.btnExcelAktar.Caption = "Excele Aktar";
            this.btnExcelAktar.Id = 2;
            this.btnExcelAktar.ImageIndex = 2;
            this.btnExcelAktar.Name = "btnExcelAktar";
            this.btnExcelAktar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExcelAktar_ItemClick);
            // 
            // btnTumunuAc
            // 
            this.btnTumunuAc.Caption = "Detay Aç";
            this.btnTumunuAc.Id = 3;
            this.btnTumunuAc.ImageIndex = 5;
            this.btnTumunuAc.Name = "btnTumunuAc";
            this.btnTumunuAc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTumunuAc_ItemClick);
            // 
            // btnTumunuKapat
            // 
            this.btnTumunuKapat.Caption = "Detay Kapat";
            this.btnTumunuKapat.Id = 4;
            this.btnTumunuKapat.ImageIndex = 6;
            this.btnTumunuKapat.Name = "btnTumunuKapat";
            this.btnTumunuKapat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTumunuKapat_ItemClick);
            // 
            // btnGrupAc
            // 
            this.btnGrupAc.Caption = "Gruplamayı Aç";
            this.btnGrupAc.Id = 5;
            this.btnGrupAc.ImageIndex = 3;
            this.btnGrupAc.Name = "btnGrupAc";
            this.btnGrupAc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGrupAc_ItemClick);
            // 
            // btnGrupKapa
            // 
            this.btnGrupKapa.Caption = "Gruplamayı Kapat";
            this.btnGrupKapa.Id = 6;
            this.btnGrupKapa.ImageIndex = 4;
            this.btnGrupKapa.Name = "btnGrupKapa";
            this.btnGrupKapa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGrupKapa_ItemClick);
            // 
            // btnEnUygunGenislik
            // 
            this.btnEnUygunGenislik.Caption = "En Uygun Genişlik";
            this.btnEnUygunGenislik.Id = 7;
            this.btnEnUygunGenislik.ImageIndex = 7;
            this.btnEnUygunGenislik.Name = "btnEnUygunGenislik";
            this.btnEnUygunGenislik.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEnUygunGenislik_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1036, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 472);
            this.barDockControlBottom.Size = new System.Drawing.Size(1036, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 438);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1036, 34);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 438);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tarih2);
            this.panel2.Controls.Add(this.tarih1);
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1036, 27);
            this.panel2.TabIndex = 24;
            // 
            // tarih2
            // 
            this.tarih2.Font = new System.Drawing.Font("Tahoma", 8F);
            this.tarih2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tarih2.Location = new System.Drawing.Point(195, 4);
            this.tarih2.Name = "tarih2";
            this.tarih2.Size = new System.Drawing.Size(111, 20);
            this.tarih2.TabIndex = 27;
            // 
            // tarih1
            // 
            this.tarih1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.tarih1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tarih1.Location = new System.Drawing.Point(87, 4);
            this.tarih1.Name = "tarih1";
            this.tarih1.Size = new System.Drawing.Size(107, 20);
            this.tarih1.TabIndex = 26;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl1.Location = new System.Drawing.Point(4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 20);
            this.labelControl1.TabIndex = 25;
            this.labelControl1.Text = "Vade Tarihi";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.cekSenetBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 61);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1036, 411);
            this.gridControl1.TabIndex = 26;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // cekSenetBindingSource
            // 
            this.cekSenetBindingSource.DataMember = "CekSenet";
            this.cekSenetBindingSource.DataSource = this.dSRaporlama;
            // 
            // dSRaporlama
            // 
            this.dSRaporlama.DataSetName = "DSRaporlama";
            this.dSRaporlama.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView1.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Empty.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gridView1.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView1.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView1.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView1.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gridView1.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView1.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gridView1.Appearance.Preview.Options.UseBackColor = true;
            this.gridView1.Appearance.Preview.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseForeColor = true;
            this.gridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gridView1.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colİL,
            this.colTİPİ,
            this.colSMKodu,
            this.colSMAdi,
            this.colSONPOZİSYON,
            this.colREFERANS,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.colÇEKNO,
            this.colVADETARİHİ,
            this.colTUTAR,
            this.colORJ_TUTAR,
            this.colÖDENEN,
            this.colDÖVİZ,
            this.colDÖVİZKURU,
            this.colKALANMİKTAR,
            this.colGÜN});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 2;
            this.gridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TUTAR", this.colTUTAR, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ÖDENEN", this.colÖDENEN, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KALAN MİKTAR", this.colKALANMİKTAR, "{0:n2}")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colİL, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSONPOZİSYON, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colİL
            // 
            this.colİL.FieldName = "İL";
            this.colİL.Name = "colİL";
            this.colİL.OptionsColumn.ReadOnly = true;
            // 
            // colTİPİ
            // 
            this.colTİPİ.FieldName = "TİPİ";
            this.colTİPİ.Name = "colTİPİ";
            this.colTİPİ.OptionsColumn.ReadOnly = true;
            this.colTİPİ.Visible = true;
            this.colTİPİ.VisibleIndex = 0;
            // 
            // colSMKodu
            // 
            this.colSMKodu.FieldName = "SM Kodu";
            this.colSMKodu.Name = "colSMKodu";
            // 
            // colSMAdi
            // 
            this.colSMAdi.FieldName = "SM Adi";
            this.colSMAdi.Name = "colSMAdi";
            this.colSMAdi.OptionsColumn.ReadOnly = true;
            this.colSMAdi.Visible = true;
            this.colSMAdi.VisibleIndex = 1;
            // 
            // colSONPOZİSYON
            // 
            this.colSONPOZİSYON.FieldName = "SON POZİSYON";
            this.colSONPOZİSYON.Name = "colSONPOZİSYON";
            this.colSONPOZİSYON.OptionsColumn.ReadOnly = true;
            this.colSONPOZİSYON.Width = 113;
            // 
            // colREFERANS
            // 
            this.colREFERANS.FieldName = "REFERANS";
            this.colREFERANS.Name = "colREFERANS";
            this.colREFERANS.Visible = true;
            this.colREFERANS.VisibleIndex = 3;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "C/H Kod";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "C/H Adı";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "Ilk Pozisyon C/H Kod";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 6;
            this.gridColumn3.Width = 135;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "lk Pozisyon C/H Adı";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 7;
            this.gridColumn4.Width = 127;
            // 
            // colÇEKNO
            // 
            this.colÇEKNO.FieldName = "ÇEK NO";
            this.colÇEKNO.Name = "colÇEKNO";
            this.colÇEKNO.Visible = true;
            this.colÇEKNO.VisibleIndex = 8;
            // 
            // colVADETARİHİ
            // 
            this.colVADETARİHİ.FieldName = "VADE TARİHİ";
            this.colVADETARİHİ.Name = "colVADETARİHİ";
            this.colVADETARİHİ.Visible = true;
            this.colVADETARİHİ.VisibleIndex = 2;
            this.colVADETARİHİ.Width = 92;
            // 
            // colTUTAR
            // 
            this.colTUTAR.Caption = "TL Tutar";
            this.colTUTAR.DisplayFormat.FormatString = "n2";
            this.colTUTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colTUTAR.FieldName = "TUTAR";
            this.colTUTAR.Name = "colTUTAR";
            this.colTUTAR.Visible = true;
            this.colTUTAR.VisibleIndex = 9;
            // 
            // colORJ_TUTAR
            // 
            this.colORJ_TUTAR.Caption = "Orjinal Tutar";
            this.colORJ_TUTAR.DisplayFormat.FormatString = "n2";
            this.colORJ_TUTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colORJ_TUTAR.FieldName = "ORJ_TUTAR";
            this.colORJ_TUTAR.Name = "colORJ_TUTAR";
            this.colORJ_TUTAR.Visible = true;
            this.colORJ_TUTAR.VisibleIndex = 10;
            this.colORJ_TUTAR.Width = 90;
            // 
            // colÖDENEN
            // 
            this.colÖDENEN.DisplayFormat.FormatString = "n2";
            this.colÖDENEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colÖDENEN.FieldName = "ÖDENEN";
            this.colÖDENEN.Name = "colÖDENEN";
            this.colÖDENEN.Visible = true;
            this.colÖDENEN.VisibleIndex = 11;
            // 
            // colDÖVİZ
            // 
            this.colDÖVİZ.FieldName = "DÖVİZ";
            this.colDÖVİZ.Name = "colDÖVİZ";
            this.colDÖVİZ.OptionsColumn.ReadOnly = true;
            this.colDÖVİZ.Visible = true;
            this.colDÖVİZ.VisibleIndex = 12;
            // 
            // colDÖVİZKURU
            // 
            this.colDÖVİZKURU.FieldName = "DÖVİZ KURU";
            this.colDÖVİZKURU.Name = "colDÖVİZKURU";
            this.colDÖVİZKURU.Width = 83;
            // 
            // colKALANMİKTAR
            // 
            this.colKALANMİKTAR.DisplayFormat.FormatString = "n2";
            this.colKALANMİKTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colKALANMİKTAR.FieldName = "KALAN MİKTAR";
            this.colKALANMİKTAR.Name = "colKALANMİKTAR";
            this.colKALANMİKTAR.OptionsColumn.ReadOnly = true;
            this.colKALANMİKTAR.Visible = true;
            this.colKALANMİKTAR.VisibleIndex = 13;
            this.colKALANMİKTAR.Width = 103;
            // 
            // colGÜN
            // 
            this.colGÜN.FieldName = "GÜN";
            this.colGÜN.Name = "colGÜN";
            this.colGÜN.OptionsColumn.ReadOnly = true;
            this.colGÜN.Visible = true;
            this.colGÜN.VisibleIndex = 14;
            // 
            // cekSenetTableAdapter
            // 
            this.cekSenetTableAdapter.ClearBeforeFill = true;
            // 
            // CekSenet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 472);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CekSenet";
            this.Text = "Çek - Senet";
            this.Load += new System.EventHandler(this.CekSenet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menu24x24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cekSenetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRaporlama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.ImageCollection menu24x24;
        private System.Windows.Forms.SaveFileDialog raporKaydet;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnTemizle;
        private DevExpress.XtraBars.BarButtonItem btnSorgula;
        private DevExpress.XtraBars.BarButtonItem btnExcelAktar;
        private DevExpress.XtraBars.BarButtonItem btnTumunuAc;
        private DevExpress.XtraBars.BarButtonItem btnTumunuKapat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnGrupAc;
        private DevExpress.XtraBars.BarButtonItem btnGrupKapa;
        private DevExpress.XtraBars.BarButtonItem btnEnUygunGenislik;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker tarih2;
        private System.Windows.Forms.DateTimePicker tarih1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DSRaporlama dSRaporlama;
        private System.Windows.Forms.BindingSource cekSenetBindingSource;
        private DSRaporlamaTableAdapters.CekSenetTableAdapter cekSenetTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colİL;
        private DevExpress.XtraGrid.Columns.GridColumn colTİPİ;
        private DevExpress.XtraGrid.Columns.GridColumn colSMKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colSMAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colSONPOZİSYON;
        private DevExpress.XtraGrid.Columns.GridColumn colREFERANS;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colÇEKNO;
        private DevExpress.XtraGrid.Columns.GridColumn colVADETARİHİ;
        private DevExpress.XtraGrid.Columns.GridColumn colTUTAR;
        private DevExpress.XtraGrid.Columns.GridColumn colÖDENEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDÖVİZ;
        private DevExpress.XtraGrid.Columns.GridColumn colDÖVİZKURU;
        private DevExpress.XtraGrid.Columns.GridColumn colKALANMİKTAR;
        private DevExpress.XtraGrid.Columns.GridColumn colGÜN;
        private DevExpress.XtraGrid.Columns.GridColumn colORJ_TUTAR;
    }
}