namespace EgemenOgluRaporlama
{
    partial class GiderlerFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiderlerFormu));
            this.menu24x24 = new DevExpress.Utils.ImageCollection(this.components);
            this.raporKaydet = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tarih2 = new System.Windows.Forms.DateTimePicker();
            this.tarih1 = new System.Windows.Forms.DateTimePicker();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.giderlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSRaporlama = new EgemenOgluRaporlama.DSRaporlama();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coltip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcha_belge_tarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcha_kod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcha_meblag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcha_aciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcha_evrakno_seri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcha_evrakno_sira = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcha_srmrkkodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsmAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmasrafAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOcak = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsubat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnisan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmayis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhaziran = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltemmuz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colagustos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coleylul = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colekim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkasim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaralik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.giderlerTableAdapter = new EgemenOgluRaporlama.DSRaporlamaTableAdapters.giderlerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.menu24x24)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBindingSource)).BeginInit();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.tarih2);
            this.panel1.Controls.Add(this.tarih1);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 27);
            this.panel1.TabIndex = 24;
            // 
            // tarih2
            // 
            this.tarih2.Font = new System.Drawing.Font("Tahoma", 8F);
            this.tarih2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tarih2.Location = new System.Drawing.Point(198, 4);
            this.tarih2.Name = "tarih2";
            this.tarih2.Size = new System.Drawing.Size(114, 20);
            this.tarih2.TabIndex = 38;
            // 
            // tarih1
            // 
            this.tarih1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.tarih1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tarih1.Location = new System.Drawing.Point(88, 4);
            this.tarih1.Name = "tarih1";
            this.tarih1.Size = new System.Drawing.Size(107, 20);
            this.tarih1.TabIndex = 37;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl2.Location = new System.Drawing.Point(6, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 20);
            this.labelControl2.TabIndex = 36;
            this.labelControl2.Text = "Tarih Aralığı";
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
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem3, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem4, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem5, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem6, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem7, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem8, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Temizle";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageIndex = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Sorgula";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageIndex = 0;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Excele Aktar";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageIndex = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Detay Aç";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.ImageIndex = 5;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Detay Kapat";
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.ImageIndex = 6;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Gruplamayı Aç";
            this.barButtonItem6.Id = 5;
            this.barButtonItem6.ImageIndex = 3;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Gruplamayı Kapat";
            this.barButtonItem7.Id = 6;
            this.barButtonItem7.ImageIndex = 4;
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "En Uygun Genişlik";
            this.barButtonItem8.Id = 7;
            this.barButtonItem8.ImageIndex = 7;
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(986, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 486);
            this.barDockControlBottom.Size = new System.Drawing.Size(986, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 454);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(986, 32);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 454);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.giderlerBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 59);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(986, 427);
            this.gridControl1.TabIndex = 30;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // giderlerBindingSource
            // 
            this.giderlerBindingSource.DataMember = "giderler";
            this.giderlerBindingSource.DataSource = this.dSRaporlama;
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
            this.coltip,
            this.colcha_belge_tarih,
            this.colcha_kod,
            this.colcha_meblag,
            this.colcha_aciklama,
            this.colcha_evrakno_seri,
            this.colcha_evrakno_sira,
            this.colcha_srmrkkodu,
            this.colsmAdi,
            this.colmasrafAdi,
            this.colToplam,
            this.colOcak,
            this.colsubat,
            this.colmart,
            this.colnisan,
            this.colmayis,
            this.colhaziran,
            this.coltemmuz,
            this.colagustos,
            this.coleylul,
            this.colekim,
            this.colkasim,
            this.colaralik,
            this.colIL});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 4;
            this.gridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Toplam", this.colToplam, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Ocak", this.colOcak, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "subat", this.colsubat, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "mart", this.colmart, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "nisan", this.colnisan, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "mayis", this.colmayis, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "haziran", this.colhaziran, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "temmuz", this.coltemmuz, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "agustos", this.colagustos, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "eylul", this.coleylul, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ekim", this.colekim, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "kasim", this.colkasim, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "aralik", this.colaralik, "{0:n2}")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIL, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.coltip, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colmasrafAdi, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colsmAdi, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // coltip
            // 
            this.coltip.Caption = "Tip";
            this.coltip.FieldName = "tip";
            this.coltip.Name = "coltip";
            this.coltip.Visible = true;
            this.coltip.VisibleIndex = 19;
            // 
            // colcha_belge_tarih
            // 
            this.colcha_belge_tarih.Caption = "Belge Tarihi";
            this.colcha_belge_tarih.FieldName = "cha_belge_tarih";
            this.colcha_belge_tarih.Name = "colcha_belge_tarih";
            this.colcha_belge_tarih.Visible = true;
            this.colcha_belge_tarih.VisibleIndex = 0;
            this.colcha_belge_tarih.Width = 104;
            // 
            // colcha_kod
            // 
            this.colcha_kod.Caption = "Cari Kod";
            this.colcha_kod.FieldName = "cha_kod";
            this.colcha_kod.Name = "colcha_kod";
            this.colcha_kod.Visible = true;
            this.colcha_kod.VisibleIndex = 1;
            this.colcha_kod.Width = 85;
            // 
            // colcha_meblag
            // 
            this.colcha_meblag.Caption = "Meglag";
            this.colcha_meblag.FieldName = "cha_meblag";
            this.colcha_meblag.Name = "colcha_meblag";
            this.colcha_meblag.Width = 76;
            // 
            // colcha_aciklama
            // 
            this.colcha_aciklama.Caption = "Açıklama";
            this.colcha_aciklama.FieldName = "cha_aciklama";
            this.colcha_aciklama.Name = "colcha_aciklama";
            this.colcha_aciklama.Visible = true;
            this.colcha_aciklama.VisibleIndex = 2;
            this.colcha_aciklama.Width = 144;
            // 
            // colcha_evrakno_seri
            // 
            this.colcha_evrakno_seri.Caption = "Evrak Seri";
            this.colcha_evrakno_seri.FieldName = "cha_evrakno_seri";
            this.colcha_evrakno_seri.Name = "colcha_evrakno_seri";
            this.colcha_evrakno_seri.Visible = true;
            this.colcha_evrakno_seri.VisibleIndex = 5;
            this.colcha_evrakno_seri.Width = 104;
            // 
            // colcha_evrakno_sira
            // 
            this.colcha_evrakno_sira.Caption = "Evrak No";
            this.colcha_evrakno_sira.FieldName = "cha_evrakno_sira";
            this.colcha_evrakno_sira.Name = "colcha_evrakno_sira";
            this.colcha_evrakno_sira.Visible = true;
            this.colcha_evrakno_sira.VisibleIndex = 6;
            this.colcha_evrakno_sira.Width = 104;
            // 
            // colcha_srmrkkodu
            // 
            this.colcha_srmrkkodu.Caption = "SM Kodu";
            this.colcha_srmrkkodu.FieldName = "cha_srmrkkodu";
            this.colcha_srmrkkodu.Name = "colcha_srmrkkodu";
            this.colcha_srmrkkodu.Visible = true;
            this.colcha_srmrkkodu.VisibleIndex = 3;
            this.colcha_srmrkkodu.Width = 91;
            // 
            // colsmAdi
            // 
            this.colsmAdi.Caption = "SM Adi";
            this.colsmAdi.FieldName = "smAdi";
            this.colsmAdi.Name = "colsmAdi";
            this.colsmAdi.OptionsColumn.ReadOnly = true;
            // 
            // colmasrafAdi
            // 
            this.colmasrafAdi.Caption = "Masraf Adi";
            this.colmasrafAdi.FieldName = "masrafAdi";
            this.colmasrafAdi.Name = "colmasrafAdi";
            this.colmasrafAdi.OptionsColumn.ReadOnly = true;
            this.colmasrafAdi.Width = 92;
            // 
            // colToplam
            // 
            this.colToplam.Caption = "Bakiye";
            this.colToplam.DisplayFormat.FormatString = "n2";
            this.colToplam.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colToplam.FieldName = "Toplam";
            this.colToplam.Name = "colToplam";
            this.colToplam.OptionsColumn.ReadOnly = true;
            this.colToplam.SummaryItem.DisplayFormat = "{0:n2}";
            this.colToplam.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colToplam.Visible = true;
            this.colToplam.VisibleIndex = 4;
            // 
            // colOcak
            // 
            this.colOcak.Caption = "Ocak";
            this.colOcak.DisplayFormat.FormatString = "n2";
            this.colOcak.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colOcak.FieldName = "Ocak";
            this.colOcak.Name = "colOcak";
            this.colOcak.OptionsColumn.ReadOnly = true;
            this.colOcak.SummaryItem.DisplayFormat = "{0:n2}";
            this.colOcak.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            // 
            // colsubat
            // 
            this.colsubat.Caption = "Şubat";
            this.colsubat.DisplayFormat.FormatString = "n2";
            this.colsubat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colsubat.FieldName = "subat";
            this.colsubat.Name = "colsubat";
            this.colsubat.OptionsColumn.ReadOnly = true;
            this.colsubat.SummaryItem.DisplayFormat = "{0:n2}";
            this.colsubat.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            // 
            // colmart
            // 
            this.colmart.Caption = "Mart";
            this.colmart.DisplayFormat.FormatString = "n2";
            this.colmart.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colmart.FieldName = "mart";
            this.colmart.Name = "colmart";
            this.colmart.OptionsColumn.ReadOnly = true;
            this.colmart.SummaryItem.DisplayFormat = "{0:n2}";
            this.colmart.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            // 
            // colnisan
            // 
            this.colnisan.Caption = "Nisan";
            this.colnisan.DisplayFormat.FormatString = "n2";
            this.colnisan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colnisan.FieldName = "nisan";
            this.colnisan.Name = "colnisan";
            this.colnisan.OptionsColumn.ReadOnly = true;
            this.colnisan.SummaryItem.DisplayFormat = "{0:n2}";
            this.colnisan.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            // 
            // colmayis
            // 
            this.colmayis.Caption = "Mayıs";
            this.colmayis.DisplayFormat.FormatString = "n2";
            this.colmayis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colmayis.FieldName = "mayis";
            this.colmayis.Name = "colmayis";
            this.colmayis.OptionsColumn.ReadOnly = true;
            this.colmayis.SummaryItem.DisplayFormat = "{0:n2}";
            this.colmayis.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            // 
            // colhaziran
            // 
            this.colhaziran.Caption = "Haziran";
            this.colhaziran.DisplayFormat.FormatString = "n2";
            this.colhaziran.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colhaziran.FieldName = "haziran";
            this.colhaziran.Name = "colhaziran";
            this.colhaziran.OptionsColumn.ReadOnly = true;
            this.colhaziran.SummaryItem.DisplayFormat = "{0:n2}";
            this.colhaziran.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            // 
            // coltemmuz
            // 
            this.coltemmuz.Caption = "Temmuz";
            this.coltemmuz.DisplayFormat.FormatString = "n2";
            this.coltemmuz.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.coltemmuz.FieldName = "temmuz";
            this.coltemmuz.Name = "coltemmuz";
            this.coltemmuz.OptionsColumn.ReadOnly = true;
            this.coltemmuz.SummaryItem.DisplayFormat = "{0:n2}";
            this.coltemmuz.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            // 
            // colagustos
            // 
            this.colagustos.Caption = "Ağustos";
            this.colagustos.DisplayFormat.FormatString = "n2";
            this.colagustos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colagustos.FieldName = "agustos";
            this.colagustos.Name = "colagustos";
            this.colagustos.OptionsColumn.ReadOnly = true;
            this.colagustos.SummaryItem.DisplayFormat = "{0:n2}";
            this.colagustos.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            // 
            // coleylul
            // 
            this.coleylul.Caption = "Eylül";
            this.coleylul.DisplayFormat.FormatString = "n2";
            this.coleylul.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.coleylul.FieldName = "eylul";
            this.coleylul.Name = "coleylul";
            this.coleylul.OptionsColumn.ReadOnly = true;
            this.coleylul.SummaryItem.DisplayFormat = "{0:n2}";
            this.coleylul.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            // 
            // colekim
            // 
            this.colekim.Caption = "Ekim";
            this.colekim.DisplayFormat.FormatString = "n2";
            this.colekim.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colekim.FieldName = "ekim";
            this.colekim.Name = "colekim";
            this.colekim.OptionsColumn.ReadOnly = true;
            this.colekim.SummaryItem.DisplayFormat = "{0:n2}";
            this.colekim.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            // 
            // colkasim
            // 
            this.colkasim.Caption = "Kasım";
            this.colkasim.DisplayFormat.FormatString = "n2";
            this.colkasim.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colkasim.FieldName = "kasim";
            this.colkasim.Name = "colkasim";
            this.colkasim.OptionsColumn.ReadOnly = true;
            this.colkasim.SummaryItem.DisplayFormat = "{0:n2}";
            this.colkasim.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            // 
            // colaralik
            // 
            this.colaralik.Caption = "Aralık";
            this.colaralik.DisplayFormat.FormatString = "n2";
            this.colaralik.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colaralik.FieldName = "aralik";
            this.colaralik.Name = "colaralik";
            this.colaralik.OptionsColumn.ReadOnly = true;
            this.colaralik.SummaryItem.DisplayFormat = "{0:n2}";
            this.colaralik.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            // 
            // colIL
            // 
            this.colIL.Caption = "İL";
            this.colIL.FieldName = "IL";
            this.colIL.Name = "colIL";
            this.colIL.OptionsColumn.ReadOnly = true;
            // 
            // giderlerTableAdapter
            // 
            this.giderlerTableAdapter.ClearBeforeFill = true;
            // 
            // GiderlerFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 486);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GiderlerFormu";
            this.Text = "Giderler";
            this.Load += new System.EventHandler(this.GiderlerFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menu24x24)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRaporlama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.ImageCollection menu24x24;
        private System.Windows.Forms.SaveFileDialog raporKaydet;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DSRaporlama dSRaporlama;
        private System.Windows.Forms.BindingSource giderlerBindingSource;
        private DSRaporlamaTableAdapters.giderlerTableAdapter giderlerTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colcha_belge_tarih;
        private DevExpress.XtraGrid.Columns.GridColumn colcha_kod;
        private DevExpress.XtraGrid.Columns.GridColumn colcha_meblag;
        private DevExpress.XtraGrid.Columns.GridColumn colcha_aciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colcha_evrakno_seri;
        private DevExpress.XtraGrid.Columns.GridColumn colcha_evrakno_sira;
        private DevExpress.XtraGrid.Columns.GridColumn colcha_srmrkkodu;
        private DevExpress.XtraGrid.Columns.GridColumn colsmAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colmasrafAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colToplam;
        private DevExpress.XtraGrid.Columns.GridColumn colOcak;
        private DevExpress.XtraGrid.Columns.GridColumn colsubat;
        private DevExpress.XtraGrid.Columns.GridColumn colmart;
        private DevExpress.XtraGrid.Columns.GridColumn colnisan;
        private DevExpress.XtraGrid.Columns.GridColumn colmayis;
        private DevExpress.XtraGrid.Columns.GridColumn colhaziran;
        private DevExpress.XtraGrid.Columns.GridColumn coltemmuz;
        private DevExpress.XtraGrid.Columns.GridColumn colagustos;
        private DevExpress.XtraGrid.Columns.GridColumn coleylul;
        private DevExpress.XtraGrid.Columns.GridColumn colekim;
        private DevExpress.XtraGrid.Columns.GridColumn colkasim;
        private DevExpress.XtraGrid.Columns.GridColumn colaralik;
        private DevExpress.XtraGrid.Columns.GridColumn colIL;
        private DevExpress.XtraGrid.Columns.GridColumn coltip;
        private System.Windows.Forms.DateTimePicker tarih2;
        private System.Windows.Forms.DateTimePicker tarih1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}