namespace EgemenOgluRaporlama.PrimSistemi
{
    partial class PiramitHareketleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PiramitHareketleri));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colSonIsKabulTarihi = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnSil = new DevExpress.XtraBars.BarButtonItem();
            this.btnExcelAktar = new DevExpress.XtraBars.BarButtonItem();
            this.btnDetayAc = new DevExpress.XtraBars.BarButtonItem();
            this.btnDetayKapat = new DevExpress.XtraBars.BarButtonItem();
            this.btnGrupAc = new DevExpress.XtraBars.BarButtonItem();
            this.btnGrupKapat = new DevExpress.XtraBars.BarButtonItem();
            this.btnEnUygunGenislik = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.menu24x24 = new DevExpress.Utils.ImageCollection(this.components);
            this.dSRaporlama = new EgemenOgluRaporlama.DSRaporlama();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.prim_PiramitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colMusteriRecID1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colMüşteriTürü = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colMüşteriKodu = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colMüşteriAdı = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colGetirenRecID1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colGetirenTürü = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colGetirenKodu = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colGetirenAdı = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCalismayaBaslamaTarihi1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colIsKabulGunSayisi = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGetirenRecID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGetirenTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMusteriRecID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMusteriTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCalismayaBaslamaTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKayitEden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKayitTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.prim_PiramitTableAdapter = new EgemenOgluRaporlama.DSRaporlamaTableAdapters.prim_PiramitTableAdapter();
            this.tableAdapterManager = new EgemenOgluRaporlama.DSRaporlamaTableAdapters.TableAdapterManager();
            this.raporKaydet = new System.Windows.Forms.SaveFileDialog();
            this.primHareketleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.primHareketleriTableAdapter = new EgemenOgluRaporlama.DSRaporlamaTableAdapters.primHareketleriTableAdapter();
            this.musteriIDTextBox = new System.Windows.Forms.TextBox();
            this.queryies1 = new EgemenOgluRaporlama.DSRaporlamaTableAdapters.Queryies();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu24x24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRaporlama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prim_PiramitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primHareketleriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // colSonIsKabulTarihi
            // 
            this.colSonIsKabulTarihi.Caption = "Son İş Kabul Tarihi";
            this.colSonIsKabulTarihi.FieldName = "SonIsKabulTarihi";
            this.colSonIsKabulTarihi.Name = "colSonIsKabulTarihi";
            this.colSonIsKabulTarihi.Visible = true;
            this.colSonIsKabulTarihi.Width = 123;
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
            this.btnSil,
            this.btnExcelAktar,
            this.btnDetayAc,
            this.btnDetayKapat,
            this.btnGrupAc,
            this.btnGrupKapat,
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
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSil, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExcelAktar, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDetayAc, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDetayKapat, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGrupAc, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGrupKapat, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEnUygunGenislik, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Yenile";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageIndex = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnSil
            // 
            this.btnSil.Caption = "Sil";
            this.btnSil.Id = 1;
            this.btnSil.ImageIndex = 9;
            this.btnSil.Name = "btnSil";
            this.btnSil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSil_ItemClick);
            // 
            // btnExcelAktar
            // 
            this.btnExcelAktar.Caption = "Excele Aktar";
            this.btnExcelAktar.Id = 2;
            this.btnExcelAktar.ImageIndex = 2;
            this.btnExcelAktar.Name = "btnExcelAktar";
            this.btnExcelAktar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExcelAktar_ItemClick);
            // 
            // btnDetayAc
            // 
            this.btnDetayAc.Caption = "Detay Aç";
            this.btnDetayAc.Id = 3;
            this.btnDetayAc.ImageIndex = 6;
            this.btnDetayAc.Name = "btnDetayAc";
            this.btnDetayAc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDetayAc_ItemClick);
            // 
            // btnDetayKapat
            // 
            this.btnDetayKapat.Caption = "Detay Kapat";
            this.btnDetayKapat.Id = 4;
            this.btnDetayKapat.ImageIndex = 5;
            this.btnDetayKapat.Name = "btnDetayKapat";
            this.btnDetayKapat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDetayKapat_ItemClick);
            // 
            // btnGrupAc
            // 
            this.btnGrupAc.Caption = "Gruplamayı Aç";
            this.btnGrupAc.Id = 5;
            this.btnGrupAc.ImageIndex = 3;
            this.btnGrupAc.Name = "btnGrupAc";
            this.btnGrupAc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGrupAc_ItemClick);
            // 
            // btnGrupKapat
            // 
            this.btnGrupKapat.Caption = "Gruplamayı Kapat";
            this.btnGrupKapat.Id = 6;
            this.btnGrupKapat.ImageIndex = 4;
            this.btnGrupKapat.Name = "btnGrupKapat";
            this.btnGrupKapat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGrupKapat_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1334, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 501);
            this.barDockControlBottom.Size = new System.Drawing.Size(1334, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 467);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1334, 34);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 467);
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
            this.menu24x24.Images.SetKeyName(8, "find.png");
            this.menu24x24.Images.SetKeyName(9, "Delete.png");
            // 
            // dSRaporlama
            // 
            this.dSRaporlama.DataSetName = "DSRaporlama";
            this.dSRaporlama.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.prim_PiramitBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 34);
            this.gridControl1.MainView = this.bandedGridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1334, 467);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1,
            this.gridView1});
            // 
            // prim_PiramitBindingSource
            // 
            this.prim_PiramitBindingSource.DataMember = "prim_Piramit";
            this.prim_PiramitBindingSource.DataSource = this.dSRaporlama;
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
            this.bandedGridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bandedGridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.bandedGridView1.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.bandedGridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.bandedGridView1.Appearance.HeaderPanel.Options.UseFont = true;
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
            this.colGetirenRecID1,
            this.colGetirenTürü,
            this.colMusteriRecID1,
            this.colMüşteriTürü,
            this.colCalismayaBaslamaTarihi1,
            this.colMüşteriKodu,
            this.colMüşteriAdı,
            this.colGetirenKodu,
            this.colGetirenAdı,
            this.colIsKabulGunSayisi,
            this.colSonIsKabulTarihi});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colSonIsKabulTarihi;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition1.Expression = "[SonIsKabulTarihi]  > Now()";
            styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            styleFormatCondition2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic);
            styleFormatCondition2.Appearance.Options.UseBackColor = true;
            styleFormatCondition2.Appearance.Options.UseFont = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colSonIsKabulTarihi;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition2.Expression = "[SonIsKabulTarihi]  <= Now()";
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
            this.gridBand1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand1.AppearanceHeader.Options.UseFont = true;
            this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridBand1.Caption = "Müşteri Bilgileri";
            this.gridBand1.Columns.Add(this.colMusteriRecID1);
            this.gridBand1.Columns.Add(this.colMüşteriTürü);
            this.gridBand1.Columns.Add(this.colMüşteriKodu);
            this.gridBand1.Columns.Add(this.colMüşteriAdı);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 445;
            // 
            // colMusteriRecID1
            // 
            this.colMusteriRecID1.Caption = "Müşteri ID";
            this.colMusteriRecID1.FieldName = "MusteriRecID";
            this.colMusteriRecID1.Name = "colMusteriRecID1";
            this.colMusteriRecID1.Width = 68;
            // 
            // colMüşteriTürü
            // 
            this.colMüşteriTürü.FieldName = "Müşteri Türü";
            this.colMüşteriTürü.Name = "colMüşteriTürü";
            this.colMüşteriTürü.Visible = true;
            this.colMüşteriTürü.Width = 91;
            // 
            // colMüşteriKodu
            // 
            this.colMüşteriKodu.FieldName = "Müşteri Kodu";
            this.colMüşteriKodu.Name = "colMüşteriKodu";
            this.colMüşteriKodu.OptionsColumn.ReadOnly = true;
            this.colMüşteriKodu.Visible = true;
            this.colMüşteriKodu.Width = 158;
            // 
            // colMüşteriAdı
            // 
            this.colMüşteriAdı.FieldName = "Müşteri Adı";
            this.colMüşteriAdı.Name = "colMüşteriAdı";
            this.colMüşteriAdı.OptionsColumn.ReadOnly = true;
            this.colMüşteriAdı.Visible = true;
            this.colMüşteriAdı.Width = 196;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand2.AppearanceHeader.Options.UseFont = true;
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridBand2.Caption = "Getiren Bilgileri";
            this.gridBand2.Columns.Add(this.colGetirenRecID1);
            this.gridBand2.Columns.Add(this.colGetirenTürü);
            this.gridBand2.Columns.Add(this.colGetirenKodu);
            this.gridBand2.Columns.Add(this.colGetirenAdı);
            this.gridBand2.Columns.Add(this.colCalismayaBaslamaTarihi1);
            this.gridBand2.Columns.Add(this.colIsKabulGunSayisi);
            this.gridBand2.Columns.Add(this.colSonIsKabulTarihi);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.Width = 835;
            // 
            // colGetirenRecID1
            // 
            this.colGetirenRecID1.Caption = "Getiren ID";
            this.colGetirenRecID1.FieldName = "GetirenRecID";
            this.colGetirenRecID1.Name = "colGetirenRecID1";
            this.colGetirenRecID1.Width = 78;
            // 
            // colGetirenTürü
            // 
            this.colGetirenTürü.FieldName = "Getiren Türü";
            this.colGetirenTürü.Name = "colGetirenTürü";
            this.colGetirenTürü.Visible = true;
            this.colGetirenTürü.Width = 90;
            // 
            // colGetirenKodu
            // 
            this.colGetirenKodu.FieldName = "Getiren Kodu";
            this.colGetirenKodu.Name = "colGetirenKodu";
            this.colGetirenKodu.OptionsColumn.ReadOnly = true;
            this.colGetirenKodu.Visible = true;
            this.colGetirenKodu.Width = 193;
            // 
            // colGetirenAdı
            // 
            this.colGetirenAdı.FieldName = "Getiren Adı";
            this.colGetirenAdı.Name = "colGetirenAdı";
            this.colGetirenAdı.OptionsColumn.ReadOnly = true;
            this.colGetirenAdı.Visible = true;
            this.colGetirenAdı.Width = 166;
            // 
            // colCalismayaBaslamaTarihi1
            // 
            this.colCalismayaBaslamaTarihi1.Caption = "Çalışmaya Başlama Tarihi";
            this.colCalismayaBaslamaTarihi1.FieldName = "CalismayaBaslamaTarihi";
            this.colCalismayaBaslamaTarihi1.Name = "colCalismayaBaslamaTarihi1";
            this.colCalismayaBaslamaTarihi1.Visible = true;
            this.colCalismayaBaslamaTarihi1.Width = 163;
            // 
            // colIsKabulGunSayisi
            // 
            this.colIsKabulGunSayisi.Caption = "Gün İçerisinde";
            this.colIsKabulGunSayisi.FieldName = "IsKabulGunSayisi";
            this.colIsKabulGunSayisi.Name = "colIsKabulGunSayisi";
            this.colIsKabulGunSayisi.Visible = true;
            this.colIsKabulGunSayisi.Width = 100;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colGetirenRecID,
            this.colGetirenTuru,
            this.colMusteriRecID,
            this.colMusteriTuru,
            this.colCalismayaBaslamaTarihi,
            this.colKayitEden,
            this.colKayitTarihi});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colGetirenRecID
            // 
            this.colGetirenRecID.FieldName = "GetirenRecID";
            this.colGetirenRecID.Name = "colGetirenRecID";
            this.colGetirenRecID.Visible = true;
            this.colGetirenRecID.VisibleIndex = 1;
            this.colGetirenRecID.Width = 92;
            // 
            // colGetirenTuru
            // 
            this.colGetirenTuru.FieldName = "GetirenTuru";
            this.colGetirenTuru.Name = "colGetirenTuru";
            this.colGetirenTuru.Visible = true;
            this.colGetirenTuru.VisibleIndex = 2;
            this.colGetirenTuru.Width = 82;
            // 
            // colMusteriRecID
            // 
            this.colMusteriRecID.FieldName = "MusteriRecID";
            this.colMusteriRecID.Name = "colMusteriRecID";
            this.colMusteriRecID.Visible = true;
            this.colMusteriRecID.VisibleIndex = 3;
            this.colMusteriRecID.Width = 92;
            // 
            // colMusteriTuru
            // 
            this.colMusteriTuru.FieldName = "MusteriTuru";
            this.colMusteriTuru.Name = "colMusteriTuru";
            this.colMusteriTuru.Visible = true;
            this.colMusteriTuru.VisibleIndex = 4;
            this.colMusteriTuru.Width = 82;
            // 
            // colCalismayaBaslamaTarihi
            // 
            this.colCalismayaBaslamaTarihi.FieldName = "CalismayaBaslamaTarihi";
            this.colCalismayaBaslamaTarihi.Name = "colCalismayaBaslamaTarihi";
            this.colCalismayaBaslamaTarihi.Visible = true;
            this.colCalismayaBaslamaTarihi.VisibleIndex = 5;
            this.colCalismayaBaslamaTarihi.Width = 141;
            // 
            // colKayitEden
            // 
            this.colKayitEden.FieldName = "KayitEden";
            this.colKayitEden.Name = "colKayitEden";
            this.colKayitEden.Visible = true;
            this.colKayitEden.VisibleIndex = 6;
            // 
            // colKayitTarihi
            // 
            this.colKayitTarihi.FieldName = "KayitTarihi";
            this.colKayitTarihi.Name = "colKayitTarihi";
            this.colKayitTarihi.Visible = true;
            this.colKayitTarihi.VisibleIndex = 7;
            // 
            // prim_PiramitTableAdapter
            // 
            this.prim_PiramitTableAdapter.ClearBeforeFill = true;
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
            // primHareketleriBindingSource
            // 
            this.primHareketleriBindingSource.DataMember = "primHareketleri";
            this.primHareketleriBindingSource.DataSource = this.dSRaporlama;
            // 
            // primHareketleriTableAdapter
            // 
            this.primHareketleriTableAdapter.ClearBeforeFill = true;
            // 
            // musteriIDTextBox
            // 
            this.musteriIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prim_PiramitBindingSource, "MusteriRecID", true));
            this.musteriIDTextBox.Location = new System.Drawing.Point(486, 247);
            this.musteriIDTextBox.Name = "musteriIDTextBox";
            this.musteriIDTextBox.ReadOnly = true;
            this.musteriIDTextBox.Size = new System.Drawing.Size(10, 21);
            this.musteriIDTextBox.TabIndex = 10;
            // 
            // PiramitHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 501);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.musteriIDTextBox);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "PiramitHareketleri";
            this.Text = "Müşteri Hareketleri";
            this.Load += new System.EventHandler(this.PiramitHareketleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu24x24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRaporlama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prim_PiramitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primHareketleriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DSRaporlama dSRaporlama;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource prim_PiramitBindingSource;
        private DSRaporlamaTableAdapters.prim_PiramitTableAdapter prim_PiramitTableAdapter;
        private DSRaporlamaTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colGetirenRecID;
        private DevExpress.XtraGrid.Columns.GridColumn colGetirenTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colMusteriRecID;
        private DevExpress.XtraGrid.Columns.GridColumn colMusteriTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colCalismayaBaslamaTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colKayitEden;
        private DevExpress.XtraGrid.Columns.GridColumn colKayitTarihi;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMusteriRecID1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMüşteriKodu;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMüşteriAdı;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colGetirenRecID1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colGetirenKodu;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colGetirenAdı;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCalismayaBaslamaTarihi1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMüşteriTürü;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colGetirenTürü;
        private DevExpress.XtraBars.BarButtonItem btnSil;
        private DevExpress.XtraBars.BarButtonItem btnExcelAktar;
        private DevExpress.XtraBars.BarButtonItem btnDetayAc;
        private DevExpress.XtraBars.BarButtonItem btnDetayKapat;
        private DevExpress.XtraBars.BarButtonItem btnGrupAc;
        private DevExpress.XtraBars.BarButtonItem btnGrupKapat;
        private DevExpress.XtraBars.BarButtonItem btnEnUygunGenislik;
        private DevExpress.Utils.ImageCollection menu24x24;
        private System.Windows.Forms.SaveFileDialog raporKaydet;
        private System.Windows.Forms.BindingSource primHareketleriBindingSource;
        private DSRaporlamaTableAdapters.primHareketleriTableAdapter primHareketleriTableAdapter;
        private System.Windows.Forms.TextBox musteriIDTextBox;
        private DSRaporlamaTableAdapters.Queryies queryies1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colIsKabulGunSayisi;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSonIsKabulTarihi;
    }
}