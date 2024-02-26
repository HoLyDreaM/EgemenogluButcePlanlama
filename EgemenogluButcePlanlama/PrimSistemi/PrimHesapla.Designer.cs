namespace EgemenOgluRaporlama.PrimSistemi
{
    partial class PrimHesapla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrimHesapla));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnTemizle = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnHesapla = new DevExpress.XtraBars.BarButtonItem();
            this.btnKaydet = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDetayAc = new DevExpress.XtraBars.BarButtonItem();
            this.btnDetayKapat = new DevExpress.XtraBars.BarButtonItem();
            this.btnGrupAc = new DevExpress.XtraBars.BarButtonItem();
            this.btnGrupKapat = new DevExpress.XtraBars.BarButtonItem();
            this.btnGenislik = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.menu24x24 = new DevExpress.Utils.ImageCollection(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGetirenID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPerKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonelAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrupKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrupAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMusteriID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMusteriKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMusteriAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPiramidinBasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGetirenTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCalBaslamaTar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAramaTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrimOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaHizmetKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMeblag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHakettigiPrim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChaBelgeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChaAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEvrakSeri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEvrakNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonemAdi1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonemYili = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjeAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjeKod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSmKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSmAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEkAlan1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEkAlan2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEkAlan3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.primHareketleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSRaporlama = new EgemenOgluRaporlama.DSRaporlama();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtDonemSonu = new DevExpress.XtraEditors.TextEdit();
            this.txtDonemBasi = new DevExpress.XtraEditors.TextEdit();
            this.txtGrupAdi = new DevExpress.XtraEditors.GridLookUpEdit();
            this.primDonemTanimlariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonemAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonemBasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonemSonu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonemYil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtDonem = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDonemAdi = new DevExpress.XtraEditors.TextEdit();
            this.prim_DonemTanimlariTableAdapter = new EgemenOgluRaporlama.DSRaporlamaTableAdapters.prim_DonemTanimlariTableAdapter();
            this.tableAdapterManager = new EgemenOgluRaporlama.DSRaporlamaTableAdapters.TableAdapterManager();
            this.raporKaydet = new System.Windows.Forms.SaveFileDialog();
            this.primHareketleriTableAdapter = new EgemenOgluRaporlama.DSRaporlamaTableAdapters.primHareketleriTableAdapter();
            this.queryies1 = new EgemenOgluRaporlama.DSRaporlamaTableAdapters.Queryies();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu24x24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primHareketleriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRaporlama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonemSonu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonemBasi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primDonemTanimlariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonemAdi.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.btnHesapla,
            this.btnKaydet,
            this.barButtonItem2,
            this.barButtonItem1,
            this.btnDetayAc,
            this.btnDetayKapat,
            this.btnGrupAc,
            this.btnGrupKapat,
            this.btnGenislik});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTemizle, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHesapla, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnKaydet, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDetayAc, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDetayKapat, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGrupAc, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGrupKapat, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGenislik, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Caption = "Temizle";
            this.btnTemizle.Id = 0;
            this.btnTemizle.ImageIndex = 2;
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTemizle_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Sil";
            this.barButtonItem2.Id = 3;
            this.barButtonItem2.ImageIndex = 0;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Caption = "Hesapla";
            this.btnHesapla.Id = 1;
            this.btnHesapla.ImageIndex = 4;
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHesapla_ItemClick);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Caption = "Kaydet";
            this.btnKaydet.Id = 2;
            this.btnKaydet.ImageIndex = 3;
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Excele Aktar";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.ImageIndex = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick_1);
            // 
            // btnDetayAc
            // 
            this.btnDetayAc.Caption = "Detay Aç";
            this.btnDetayAc.Id = 5;
            this.btnDetayAc.ImageIndex = 5;
            this.btnDetayAc.Name = "btnDetayAc";
            this.btnDetayAc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDetayAc_ItemClick);
            // 
            // btnDetayKapat
            // 
            this.btnDetayKapat.Caption = "Detay Kapat";
            this.btnDetayKapat.Id = 6;
            this.btnDetayKapat.ImageIndex = 7;
            this.btnDetayKapat.Name = "btnDetayKapat";
            this.btnDetayKapat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDetayKapat_ItemClick);
            // 
            // btnGrupAc
            // 
            this.btnGrupAc.Caption = "Gruplamayı Aç";
            this.btnGrupAc.Id = 7;
            this.btnGrupAc.ImageIndex = 8;
            this.btnGrupAc.Name = "btnGrupAc";
            this.btnGrupAc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGrupAc_ItemClick);
            // 
            // btnGrupKapat
            // 
            this.btnGrupKapat.Caption = "Gruplamayı Kapat";
            this.btnGrupKapat.Id = 8;
            this.btnGrupKapat.ImageIndex = 9;
            this.btnGrupKapat.Name = "btnGrupKapat";
            this.btnGrupKapat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGrupKapat_ItemClick);
            // 
            // btnGenislik
            // 
            this.btnGenislik.Caption = "En Uygun Genişlik";
            this.btnGenislik.Id = 9;
            this.btnGenislik.ImageIndex = 6;
            this.btnGenislik.Name = "btnGenislik";
            this.btnGenislik.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGenislik_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1161, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 444);
            this.barDockControlBottom.Size = new System.Drawing.Size(1161, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 410);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1161, 34);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 410);
            // 
            // menu24x24
            // 
            this.menu24x24.ImageSize = new System.Drawing.Size(24, 24);
            this.menu24x24.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("menu24x24.ImageStream")));
            this.menu24x24.Images.SetKeyName(0, "Delete.png");
            this.menu24x24.Images.SetKeyName(1, "exporttoexcel.png");
            this.menu24x24.Images.SetKeyName(2, "Refresh.png");
            this.menu24x24.Images.SetKeyName(3, "Save.png");
            this.menu24x24.Images.SetKeyName(4, "1367982210_System Preferences.png");
            this.menu24x24.Images.SetKeyName(5, "ac.png");
            this.menu24x24.Images.SetKeyName(6, "bestfit.png");
            this.menu24x24.Images.SetKeyName(7, "kapa.png");
            this.menu24x24.Images.SetKeyName(8, "tumunuAc.png");
            this.menu24x24.Images.SetKeyName(9, "tumunuKapa.png");
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
            this.colGetirenID,
            this.colPerKodu,
            this.colPersonelAdi,
            this.colGrupKodu,
            this.colGrupAdi,
            this.colMusteriID,
            this.colMusteriKodu,
            this.colMusteriAdi,
            this.colPiramidinBasi,
            this.colGetirenTuru,
            this.colCalBaslamaTar,
            this.colAramaTarihi,
            this.colCariTarih,
            this.colPrimOrani,
            this.colKasaHizmetKodu,
            this.colMeblag,
            this.colHakettigiPrim,
            this.colChaBelgeNo,
            this.colChaAciklama,
            this.colEvrakSeri,
            this.colEvrakNo,
            this.colDonemAdi1,
            this.colDonemYili,
            this.colProjeAdi,
            this.colProjeKod,
            this.colSmKodu,
            this.colSmAdi,
            this.colEkAlan1,
            this.colEkAlan2,
            this.colEkAlan3});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "HakettigiPrim", this.colHakettigiPrim, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Meblag", this.colMeblag, "{0:n2}")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupedColumns = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colPersonelAdi, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colGetirenID
            // 
            this.colGetirenID.FieldName = "GetirenID";
            this.colGetirenID.Name = "colGetirenID";
            this.colGetirenID.OptionsColumn.AllowEdit = false;
            this.colGetirenID.Width = 70;
            // 
            // colPerKodu
            // 
            this.colPerKodu.FieldName = "PerKodu";
            this.colPerKodu.Name = "colPerKodu";
            this.colPerKodu.Visible = true;
            this.colPerKodu.VisibleIndex = 0;
            this.colPerKodu.Width = 134;
            // 
            // colPersonelAdi
            // 
            this.colPersonelAdi.FieldName = "PersonelAdi";
            this.colPersonelAdi.Name = "colPersonelAdi";
            this.colPersonelAdi.Visible = true;
            this.colPersonelAdi.VisibleIndex = 1;
            this.colPersonelAdi.Width = 206;
            // 
            // colGrupKodu
            // 
            this.colGrupKodu.FieldName = "GrupKodu";
            this.colGrupKodu.Name = "colGrupKodu";
            this.colGrupKodu.Width = 70;
            // 
            // colGrupAdi
            // 
            this.colGrupAdi.FieldName = "GrupAdi";
            this.colGrupAdi.Name = "colGrupAdi";
            this.colGrupAdi.Visible = true;
            this.colGrupAdi.VisibleIndex = 2;
            this.colGrupAdi.Width = 90;
            // 
            // colMusteriID
            // 
            this.colMusteriID.FieldName = "MusteriID";
            this.colMusteriID.Name = "colMusteriID";
            this.colMusteriID.Width = 71;
            // 
            // colMusteriKodu
            // 
            this.colMusteriKodu.FieldName = "MusteriKodu";
            this.colMusteriKodu.Name = "colMusteriKodu";
            this.colMusteriKodu.Visible = true;
            this.colMusteriKodu.VisibleIndex = 3;
            this.colMusteriKodu.Width = 125;
            // 
            // colMusteriAdi
            // 
            this.colMusteriAdi.FieldName = "MusteriAdi";
            this.colMusteriAdi.Name = "colMusteriAdi";
            this.colMusteriAdi.Visible = true;
            this.colMusteriAdi.VisibleIndex = 4;
            this.colMusteriAdi.Width = 213;
            // 
            // colPiramidinBasi
            // 
            this.colPiramidinBasi.FieldName = "PiramidinBasi";
            this.colPiramidinBasi.Name = "colPiramidinBasi";
            this.colPiramidinBasi.Width = 91;
            // 
            // colGetirenTuru
            // 
            this.colGetirenTuru.FieldName = "GetirenTuru";
            this.colGetirenTuru.Name = "colGetirenTuru";
            this.colGetirenTuru.Width = 83;
            // 
            // colCalBaslamaTar
            // 
            this.colCalBaslamaTar.FieldName = "CalBaslamaTar";
            this.colCalBaslamaTar.Name = "colCalBaslamaTar";
            this.colCalBaslamaTar.Width = 102;
            // 
            // colAramaTarihi
            // 
            this.colAramaTarihi.FieldName = "AramaTarihi";
            this.colAramaTarihi.Name = "colAramaTarihi";
            this.colAramaTarihi.OptionsColumn.ReadOnly = true;
            this.colAramaTarihi.Width = 85;
            // 
            // colCariTarih
            // 
            this.colCariTarih.Caption = "Tahsilat Tarihi";
            this.colCariTarih.FieldName = "CariTarih";
            this.colCariTarih.Name = "colCariTarih";
            this.colCariTarih.Visible = true;
            this.colCariTarih.VisibleIndex = 5;
            this.colCariTarih.Width = 76;
            // 
            // colPrimOrani
            // 
            this.colPrimOrani.DisplayFormat.FormatString = "%{0:n2}";
            this.colPrimOrani.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPrimOrani.FieldName = "PrimOrani";
            this.colPrimOrani.Name = "colPrimOrani";
            this.colPrimOrani.OptionsColumn.ReadOnly = true;
            this.colPrimOrani.Visible = true;
            this.colPrimOrani.VisibleIndex = 8;
            this.colPrimOrani.Width = 81;
            // 
            // colKasaHizmetKodu
            // 
            this.colKasaHizmetKodu.FieldName = "KasaHizmetKodu";
            this.colKasaHizmetKodu.Name = "colKasaHizmetKodu";
            this.colKasaHizmetKodu.Visible = true;
            this.colKasaHizmetKodu.VisibleIndex = 6;
            this.colKasaHizmetKodu.Width = 123;
            // 
            // colMeblag
            // 
            this.colMeblag.DisplayFormat.FormatString = "{0:n2}";
            this.colMeblag.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colMeblag.FieldName = "Meblag";
            this.colMeblag.Name = "colMeblag";
            this.colMeblag.OptionsColumn.ReadOnly = true;
            this.colMeblag.SummaryItem.DisplayFormat = "{0:n2}";
            this.colMeblag.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colMeblag.Visible = true;
            this.colMeblag.VisibleIndex = 7;
            this.colMeblag.Width = 63;
            // 
            // colHakettigiPrim
            // 
            this.colHakettigiPrim.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colHakettigiPrim.AppearanceCell.Options.UseFont = true;
            this.colHakettigiPrim.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colHakettigiPrim.AppearanceHeader.Options.UseFont = true;
            this.colHakettigiPrim.DisplayFormat.FormatString = "{0:n2}";
            this.colHakettigiPrim.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colHakettigiPrim.FieldName = "HakettigiPrim";
            this.colHakettigiPrim.GroupFormat.FormatString = "{0:n2}";
            this.colHakettigiPrim.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colHakettigiPrim.Name = "colHakettigiPrim";
            this.colHakettigiPrim.OptionsColumn.ReadOnly = true;
            this.colHakettigiPrim.SummaryItem.DisplayFormat = "{0:n2}";
            this.colHakettigiPrim.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colHakettigiPrim.Visible = true;
            this.colHakettigiPrim.VisibleIndex = 9;
            this.colHakettigiPrim.Width = 103;
            // 
            // colChaBelgeNo
            // 
            this.colChaBelgeNo.FieldName = "ChaBelgeNo";
            this.colChaBelgeNo.Name = "colChaBelgeNo";
            this.colChaBelgeNo.Visible = true;
            this.colChaBelgeNo.VisibleIndex = 10;
            this.colChaBelgeNo.Width = 94;
            // 
            // colChaAciklama
            // 
            this.colChaAciklama.FieldName = "ChaAciklama";
            this.colChaAciklama.Name = "colChaAciklama";
            this.colChaAciklama.Visible = true;
            this.colChaAciklama.VisibleIndex = 11;
            this.colChaAciklama.Width = 98;
            // 
            // colEvrakSeri
            // 
            this.colEvrakSeri.FieldName = "EvrakSeri";
            this.colEvrakSeri.Name = "colEvrakSeri";
            this.colEvrakSeri.Visible = true;
            this.colEvrakSeri.VisibleIndex = 12;
            this.colEvrakSeri.Width = 79;
            // 
            // colEvrakNo
            // 
            this.colEvrakNo.FieldName = "EvrakNo";
            this.colEvrakNo.Name = "colEvrakNo";
            this.colEvrakNo.Visible = true;
            this.colEvrakNo.VisibleIndex = 13;
            this.colEvrakNo.Width = 71;
            // 
            // colDonemAdi1
            // 
            this.colDonemAdi1.FieldName = "DonemAdi";
            this.colDonemAdi1.Name = "colDonemAdi1";
            this.colDonemAdi1.OptionsColumn.ReadOnly = true;
            this.colDonemAdi1.Visible = true;
            this.colDonemAdi1.VisibleIndex = 14;
            this.colDonemAdi1.Width = 83;
            // 
            // colDonemYili
            // 
            this.colDonemYili.FieldName = "DonemYili";
            this.colDonemYili.Name = "colDonemYili";
            this.colDonemYili.OptionsColumn.ReadOnly = true;
            this.colDonemYili.Visible = true;
            this.colDonemYili.VisibleIndex = 15;
            this.colDonemYili.Width = 81;
            // 
            // colProjeAdi
            // 
            this.colProjeAdi.FieldName = "ProjeAdi";
            this.colProjeAdi.Name = "colProjeAdi";
            this.colProjeAdi.Visible = true;
            this.colProjeAdi.VisibleIndex = 16;
            // 
            // colProjeKod
            // 
            this.colProjeKod.FieldName = "ProjeKod";
            this.colProjeKod.Name = "colProjeKod";
            this.colProjeKod.Visible = true;
            this.colProjeKod.VisibleIndex = 17;
            // 
            // colSmKodu
            // 
            this.colSmKodu.FieldName = "SmKodu";
            this.colSmKodu.Name = "colSmKodu";
            this.colSmKodu.Visible = true;
            this.colSmKodu.VisibleIndex = 18;
            // 
            // colSmAdi
            // 
            this.colSmAdi.FieldName = "SmAdi";
            this.colSmAdi.Name = "colSmAdi";
            this.colSmAdi.Visible = true;
            this.colSmAdi.VisibleIndex = 19;
            // 
            // colEkAlan1
            // 
            this.colEkAlan1.FieldName = "EkAlan1";
            this.colEkAlan1.Name = "colEkAlan1";
            this.colEkAlan1.Visible = true;
            this.colEkAlan1.VisibleIndex = 20;
            // 
            // colEkAlan2
            // 
            this.colEkAlan2.FieldName = "EkAlan2";
            this.colEkAlan2.Name = "colEkAlan2";
            this.colEkAlan2.Visible = true;
            this.colEkAlan2.VisibleIndex = 21;
            // 
            // colEkAlan3
            // 
            this.colEkAlan3.FieldName = "EkAlan3";
            this.colEkAlan3.Name = "colEkAlan3";
            this.colEkAlan3.Visible = true;
            this.colEkAlan3.VisibleIndex = 22;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.primHareketleriBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 73);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1161, 371);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // primHareketleriBindingSource
            // 
            this.primHareketleriBindingSource.DataMember = "primHareketleri";
            this.primHareketleriBindingSource.DataSource = this.dSRaporlama;
            // 
            // dSRaporlama
            // 
            this.dSRaporlama.DataSetName = "DSRaporlama";
            this.dSRaporlama.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtDonemSonu);
            this.panelControl1.Controls.Add(this.txtDonemBasi);
            this.panelControl1.Controls.Add(this.txtGrupAdi);
            this.panelControl1.Controls.Add(this.txtDonem);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 34);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1161, 39);
            this.panelControl1.TabIndex = 10;
            // 
            // txtDonemSonu
            // 
            this.txtDonemSonu.Location = new System.Drawing.Point(422, 7);
            this.txtDonemSonu.MenuManager = this.barManager1;
            this.txtDonemSonu.Name = "txtDonemSonu";
            this.txtDonemSonu.Properties.DisplayFormat.FormatString = "dd.MM.yyyy";
            this.txtDonemSonu.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDonemSonu.Properties.EditFormat.FormatString = "dd.MM.yyyy";
            this.txtDonemSonu.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDonemSonu.Properties.ReadOnly = true;
            this.txtDonemSonu.Size = new System.Drawing.Size(110, 20);
            this.txtDonemSonu.TabIndex = 79;
            // 
            // txtDonemBasi
            // 
            this.txtDonemBasi.Location = new System.Drawing.Point(306, 7);
            this.txtDonemBasi.MenuManager = this.barManager1;
            this.txtDonemBasi.Name = "txtDonemBasi";
            this.txtDonemBasi.Properties.DisplayFormat.FormatString = "dd.MM.yyyy";
            this.txtDonemBasi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtDonemBasi.Properties.EditFormat.FormatString = "dd.MM.yyyy";
            this.txtDonemBasi.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDonemBasi.Properties.ReadOnly = true;
            this.txtDonemBasi.Size = new System.Drawing.Size(116, 20);
            this.txtDonemBasi.TabIndex = 78;
            // 
            // txtGrupAdi
            // 
            this.txtGrupAdi.Location = new System.Drawing.Point(98, 7);
            this.txtGrupAdi.MenuManager = this.barManager1;
            this.txtGrupAdi.Name = "txtGrupAdi";
            this.txtGrupAdi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtGrupAdi.Properties.DataSource = this.primDonemTanimlariBindingSource;
            this.txtGrupAdi.Properties.DisplayMember = "DonemAdi";
            this.txtGrupAdi.Properties.NullText = "";
            this.txtGrupAdi.Properties.ValueMember = "DonemAdi";
            this.txtGrupAdi.Properties.View = this.gridLookUpEdit1View;
            this.txtGrupAdi.Size = new System.Drawing.Size(165, 20);
            this.txtGrupAdi.TabIndex = 77;
            this.txtGrupAdi.EditValueChanged += new System.EventHandler(this.txtGrupAdi_EditValueChanged);
            // 
            // primDonemTanimlariBindingSource
            // 
            this.primDonemTanimlariBindingSource.DataMember = "prim_DonemTanimlari";
            this.primDonemTanimlariBindingSource.DataSource = this.dSRaporlama;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colDonemAdi,
            this.colDonemBasi,
            this.colDonemSonu,
            this.colDonemYil});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsBehavior.Editable = false;
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ColumnAutoWidth = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 4;
            // 
            // colDonemAdi
            // 
            this.colDonemAdi.FieldName = "DonemAdi";
            this.colDonemAdi.Name = "colDonemAdi";
            this.colDonemAdi.Visible = true;
            this.colDonemAdi.VisibleIndex = 0;
            // 
            // colDonemBasi
            // 
            this.colDonemBasi.FieldName = "DonemBasi";
            this.colDonemBasi.Name = "colDonemBasi";
            this.colDonemBasi.Visible = true;
            this.colDonemBasi.VisibleIndex = 1;
            // 
            // colDonemSonu
            // 
            this.colDonemSonu.FieldName = "DonemSonu";
            this.colDonemSonu.Name = "colDonemSonu";
            this.colDonemSonu.Visible = true;
            this.colDonemSonu.VisibleIndex = 2;
            // 
            // colDonemYil
            // 
            this.colDonemYil.FieldName = "DonemYil";
            this.colDonemYil.Name = "colDonemYil";
            this.colDonemYil.Visible = true;
            this.colDonemYil.VisibleIndex = 3;
            // 
            // txtDonem
            // 
            this.txtDonem.Location = new System.Drawing.Point(263, 7);
            this.txtDonem.MenuManager = this.barManager1;
            this.txtDonem.Name = "txtDonem";
            this.txtDonem.Properties.ReadOnly = true;
            this.txtDonem.Size = new System.Drawing.Size(43, 20);
            this.txtDonem.TabIndex = 49;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl1.Location = new System.Drawing.Point(7, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(91, 20);
            this.labelControl1.TabIndex = 47;
            this.labelControl1.Text = "Dönem Seçimi";
            // 
            // txtDonemAdi
            // 
            this.txtDonemAdi.Location = new System.Drawing.Point(586, 162);
            this.txtDonemAdi.MenuManager = this.barManager1;
            this.txtDonemAdi.Name = "txtDonemAdi";
            this.txtDonemAdi.Properties.ReadOnly = true;
            this.txtDonemAdi.Size = new System.Drawing.Size(10, 20);
            this.txtDonemAdi.TabIndex = 80;
            // 
            // prim_DonemTanimlariTableAdapter
            // 
            this.prim_DonemTanimlariTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.gelirTablosuTableAdapter = null;
            this.tableAdapterManager.KASALARTableAdapter = null;
            this.tableAdapterManager.KullanicilarTableAdapter = null;
            this.tableAdapterManager.KurlarTableAdapter = null;
            this.tableAdapterManager.LookUpKullaniciTableAdapter = null;
            this.tableAdapterManager.prim_DonemTanimlariTableAdapter = this.prim_DonemTanimlariTableAdapter;
            this.tableAdapterManager.prim_GrupTanimlariTableAdapter = null;
            this.tableAdapterManager.prim_PrimGirisTableAdapter = null;
            this.tableAdapterManager.PrimOdemeleriTableAdapter = null;
            this.tableAdapterManager.TahsilatSureleriTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EgemenOgluRaporlama.DSRaporlamaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.YeniMusteriTableAdapter = null;
            // 
            // primHareketleriTableAdapter
            // 
            this.primHareketleriTableAdapter.ClearBeforeFill = true;
            // 
            // PrimHesapla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 444);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.txtDonemAdi);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "PrimHesapla";
            this.Text = "Prim Hesaplama";
            this.Load += new System.EventHandler(this.PrimHesapla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu24x24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primHareketleriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRaporlama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDonemSonu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonemBasi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primDonemTanimlariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonemAdi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnTemizle;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.BarButtonItem btnHesapla;
        private DevExpress.XtraBars.BarButtonItem btnKaydet;
        private DevExpress.XtraEditors.TextEdit txtDonem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GridLookUpEdit txtGrupAdi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DSRaporlama dSRaporlama;
        private System.Windows.Forms.BindingSource primDonemTanimlariBindingSource;
        private DSRaporlamaTableAdapters.prim_DonemTanimlariTableAdapter prim_DonemTanimlariTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colDonemAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colDonemBasi;
        private DevExpress.XtraGrid.Columns.GridColumn colDonemSonu;
        private DevExpress.XtraGrid.Columns.GridColumn colDonemYil;
        private DSRaporlamaTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit txtDonemSonu;
        private DevExpress.XtraEditors.TextEdit txtDonemBasi;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.SaveFileDialog raporKaydet;
        private DevExpress.Utils.ImageCollection menu24x24;
        private System.Windows.Forms.BindingSource primHareketleriBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colGetirenID;
        private DevExpress.XtraGrid.Columns.GridColumn colPerKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonelAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colMusteriID;
        private DevExpress.XtraGrid.Columns.GridColumn colMusteriKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colMusteriAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colPiramidinBasi;
        private DevExpress.XtraGrid.Columns.GridColumn colGetirenTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colCalBaslamaTar;
        private DevExpress.XtraGrid.Columns.GridColumn colAramaTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colCariTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colPrimOrani;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaHizmetKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colMeblag;
        private DevExpress.XtraGrid.Columns.GridColumn colHakettigiPrim;
        private DevExpress.XtraGrid.Columns.GridColumn colChaBelgeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colChaAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colEvrakSeri;
        private DevExpress.XtraGrid.Columns.GridColumn colEvrakNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDonemAdi1;
        private DevExpress.XtraGrid.Columns.GridColumn colDonemYili;
        private DSRaporlamaTableAdapters.primHareketleriTableAdapter primHareketleriTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtDonemAdi;
        private DSRaporlamaTableAdapters.Queryies queryies1;
        private DevExpress.XtraBars.BarButtonItem btnDetayAc;
        private DevExpress.XtraBars.BarButtonItem btnDetayKapat;
        private DevExpress.XtraBars.BarButtonItem btnGrupAc;
        private DevExpress.XtraBars.BarButtonItem btnGrupKapat;
        private DevExpress.XtraBars.BarButtonItem btnGenislik;
        private DevExpress.XtraGrid.Columns.GridColumn colProjeAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colProjeKod;
        private DevExpress.XtraGrid.Columns.GridColumn colSmKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colSmAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colEkAlan1;
        private DevExpress.XtraGrid.Columns.GridColumn colEkAlan2;
        private DevExpress.XtraGrid.Columns.GridColumn colEkAlan3;
    }
}