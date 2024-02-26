namespace EgemenOgluRaporlama
{
    partial class Bilanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bilanco));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colmuh_hesap_kod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbosluk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmuh_hesap_isim1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmuh_hesap_isim2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colborc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colalacak = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbakiye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmuh_hesapisim22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.raporKaydet = new System.Windows.Forms.SaveFileDialog();
            this.menu24x24 = new DevExpress.Utils.ImageCollection(this.components);
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
            this.bilancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSRaporlama = new EgemenOgluRaporlama.DSRaporlama();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmuh_hesap_kod1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmuh_hesap_isim11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colborc1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colalacak1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbakiye1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bilancoTableAdapter = new EgemenOgluRaporlama.DSRaporlamaTableAdapters.bilancoTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtFirmaSec = new DevExpress.XtraEditors.ButtonEdit();
            this.dahil950 = new DevExpress.XtraEditors.CheckEdit();
            this.tarih2 = new System.Windows.Forms.DateTimePicker();
            this.tarih1 = new System.Windows.Forms.DateTimePicker();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bilancoaktifBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bilanco_aktifTableAdapter = new EgemenOgluRaporlama.DSRaporlamaTableAdapters.bilanco_aktifTableAdapter();
            this.bilancopasifBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bilanco_pasifTableAdapter = new EgemenOgluRaporlama.DSRaporlamaTableAdapters.bilanco_pasifTableAdapter();
            this.fIRMALARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fIRMALARTableAdapter = new EgemenOgluRaporlama.DSRaporlamaTableAdapters.FIRMALARTableAdapter();
            this.tableAdapterManager = new EgemenOgluRaporlama.DSRaporlamaTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.menu24x24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRaporlama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirmaSec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dahil950.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilancoaktifBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilancopasifBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fIRMALARBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // colmuh_hesap_kod
            // 
            this.colmuh_hesap_kod.Caption = "Hesap Kodu";
            this.colmuh_hesap_kod.FieldName = "muh_hesap_kod";
            this.colmuh_hesap_kod.Name = "colmuh_hesap_kod";
            this.colmuh_hesap_kod.Visible = true;
            this.colmuh_hesap_kod.VisibleIndex = 0;
            this.colmuh_hesap_kod.Width = 70;
            // 
            // colbosluk
            // 
            this.colbosluk.Caption = " ";
            this.colbosluk.FieldName = "bosluk";
            this.colbosluk.Name = "colbosluk";
            this.colbosluk.Visible = true;
            this.colbosluk.VisibleIndex = 5;
            this.colbosluk.Width = 38;
            // 
            // colmuh_hesap_isim1
            // 
            this.colmuh_hesap_isim1.Caption = "Aktif Grup - Hesap Adı";
            this.colmuh_hesap_isim1.FieldName = "muh_hesap_isim1";
            this.colmuh_hesap_isim1.Name = "colmuh_hesap_isim1";
            this.colmuh_hesap_isim1.Visible = true;
            this.colmuh_hesap_isim1.VisibleIndex = 1;
            this.colmuh_hesap_isim1.Width = 184;
            // 
            // colmuh_hesap_isim2
            // 
            this.colmuh_hesap_isim2.FieldName = "muh_hesap_isim2";
            this.colmuh_hesap_isim2.Name = "colmuh_hesap_isim2";
            // 
            // colborc
            // 
            this.colborc.Caption = "Borc";
            this.colborc.DisplayFormat.FormatString = "n2";
            this.colborc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colborc.FieldName = "borc";
            this.colborc.Name = "colborc";
            this.colborc.OptionsColumn.ReadOnly = true;
            this.colborc.Visible = true;
            this.colborc.VisibleIndex = 2;
            this.colborc.Width = 76;
            // 
            // colalacak
            // 
            this.colalacak.Caption = "Alacak";
            this.colalacak.DisplayFormat.FormatString = "n2";
            this.colalacak.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colalacak.FieldName = "alacak";
            this.colalacak.Name = "colalacak";
            this.colalacak.OptionsColumn.ReadOnly = true;
            this.colalacak.Visible = true;
            this.colalacak.VisibleIndex = 3;
            this.colalacak.Width = 69;
            // 
            // colbakiye
            // 
            this.colbakiye.Caption = "Bakiye";
            this.colbakiye.DisplayFormat.FormatString = "n2";
            this.colbakiye.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colbakiye.FieldName = "bakiye";
            this.colbakiye.Name = "colbakiye";
            this.colbakiye.OptionsColumn.ReadOnly = true;
            this.colbakiye.Visible = true;
            this.colbakiye.VisibleIndex = 4;
            this.colbakiye.Width = 71;
            // 
            // colmuh_hesapisim22
            // 
            this.colmuh_hesapisim22.FieldName = "muh_hesapisim22";
            this.colmuh_hesapisim22.Name = "colmuh_hesapisim22";
            this.colmuh_hesapisim22.Width = 89;
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
            this.barManager1.MaxItemId = 9;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageIndex = 0;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Excele Aktar";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.ImageIndex = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Detay Aç";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.ImageIndex = 5;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Detay Kapat";
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.ImageIndex = 6;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Gruplamayı Aç";
            this.barButtonItem6.Id = 6;
            this.barButtonItem6.ImageIndex = 3;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Gruplamayı Kapat";
            this.barButtonItem7.Id = 7;
            this.barButtonItem7.ImageIndex = 4;
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "En Uygun Genişlik";
            this.barButtonItem8.Id = 8;
            this.barButtonItem8.ImageIndex = 7;
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1017, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 471);
            this.barDockControlBottom.Size = new System.Drawing.Size(1017, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 437);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1017, 34);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 437);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bilancoBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 61);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1017, 410);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bilancoBindingSource
            // 
            this.bilancoBindingSource.DataMember = "bilanco";
            this.bilancoBindingSource.DataSource = this.dSRaporlama;
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
            this.colmuh_hesap_kod,
            this.colmuh_hesap_isim1,
            this.colmuh_hesap_isim2,
            this.colborc,
            this.colalacak,
            this.colbakiye,
            this.colbosluk,
            this.colmuh_hesap_kod1,
            this.colmuh_hesap_isim11,
            this.colmuh_hesapisim22,
            this.colborc1,
            this.colalacak1,
            this.colbakiye1});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(80)))), ((int)(((byte)(77)))));
            styleFormatCondition1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(80)))), ((int)(((byte)(77)))));
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Appearance.Options.UseBorderColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colmuh_hesap_kod;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition1.Expression = "[muh_hesap_kod]==\' \'";
            styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Gray;
            styleFormatCondition2.Appearance.BorderColor = System.Drawing.Color.Gray;
            styleFormatCondition2.Appearance.Options.UseBackColor = true;
            styleFormatCondition2.Appearance.Options.UseBorderColor = true;
            styleFormatCondition2.Column = this.colbosluk;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition2.Expression = "Len([bosluk])==0";
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colmuh_hesap_kod1
            // 
            this.colmuh_hesap_kod1.Caption = "Hesap Kodu";
            this.colmuh_hesap_kod1.FieldName = "muh_hesap_kod1";
            this.colmuh_hesap_kod1.Name = "colmuh_hesap_kod1";
            this.colmuh_hesap_kod1.Visible = true;
            this.colmuh_hesap_kod1.VisibleIndex = 6;
            this.colmuh_hesap_kod1.Width = 90;
            // 
            // colmuh_hesap_isim11
            // 
            this.colmuh_hesap_isim11.Caption = "Pasif Grup - Hesap Adı";
            this.colmuh_hesap_isim11.FieldName = "muh_hesap_isim11";
            this.colmuh_hesap_isim11.Name = "colmuh_hesap_isim11";
            this.colmuh_hesap_isim11.Visible = true;
            this.colmuh_hesap_isim11.VisibleIndex = 7;
            this.colmuh_hesap_isim11.Width = 164;
            // 
            // colborc1
            // 
            this.colborc1.Caption = "Borc";
            this.colborc1.DisplayFormat.FormatString = "n2";
            this.colborc1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colborc1.FieldName = "borc1";
            this.colborc1.Name = "colborc1";
            this.colborc1.OptionsColumn.ReadOnly = true;
            this.colborc1.Visible = true;
            this.colborc1.VisibleIndex = 8;
            this.colborc1.Width = 71;
            // 
            // colalacak1
            // 
            this.colalacak1.Caption = "Alacak";
            this.colalacak1.DisplayFormat.FormatString = "n2";
            this.colalacak1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colalacak1.FieldName = "alacak1";
            this.colalacak1.Name = "colalacak1";
            this.colalacak1.OptionsColumn.ReadOnly = true;
            this.colalacak1.Visible = true;
            this.colalacak1.VisibleIndex = 9;
            this.colalacak1.Width = 74;
            // 
            // colbakiye1
            // 
            this.colbakiye1.Caption = "Bakiye";
            this.colbakiye1.DisplayFormat.FormatString = "n2";
            this.colbakiye1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colbakiye1.FieldName = "bakiye1";
            this.colbakiye1.Name = "colbakiye1";
            this.colbakiye1.OptionsColumn.ReadOnly = true;
            this.colbakiye1.Visible = true;
            this.colbakiye1.VisibleIndex = 10;
            // 
            // bilancoTableAdapter
            // 
            this.bilancoTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.txtFirmaSec);
            this.panel1.Controls.Add(this.dahil950);
            this.panel1.Controls.Add(this.tarih2);
            this.panel1.Controls.Add(this.tarih1);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 27);
            this.panel1.TabIndex = 25;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl2.Location = new System.Drawing.Point(321, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 20);
            this.labelControl2.TabIndex = 41;
            this.labelControl2.Text = "Firma Seçimi";
            // 
            // txtFirmaSec
            // 
            this.txtFirmaSec.Location = new System.Drawing.Point(403, 4);
            this.txtFirmaSec.MenuManager = this.barManager1;
            this.txtFirmaSec.Name = "txtFirmaSec";
            this.txtFirmaSec.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtFirmaSec.Properties.ReadOnly = true;
            this.txtFirmaSec.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit1_Properties_ButtonClick);
            this.txtFirmaSec.Size = new System.Drawing.Size(141, 20);
            this.txtFirmaSec.TabIndex = 30;
            // 
            // dahil950
            // 
            this.dahil950.Location = new System.Drawing.Point(552, 4);
            this.dahil950.MenuManager = this.barManager1;
            this.dahil950.Name = "dahil950";
            this.dahil950.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dahil950.Properties.Appearance.Options.UseFont = true;
            this.dahil950.Properties.Caption = "950 Dahil";
            this.dahil950.Size = new System.Drawing.Size(75, 19);
            this.dahil950.TabIndex = 35;
            // 
            // tarih2
            // 
            this.tarih2.Font = new System.Drawing.Font("Tahoma", 8F);
            this.tarih2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tarih2.Location = new System.Drawing.Point(196, 4);
            this.tarih2.Name = "tarih2";
            this.tarih2.Size = new System.Drawing.Size(114, 20);
            this.tarih2.TabIndex = 27;
            // 
            // tarih1
            // 
            this.tarih1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.tarih1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tarih1.Location = new System.Drawing.Point(85, 4);
            this.tarih1.Name = "tarih1";
            this.tarih1.Size = new System.Drawing.Size(107, 20);
            this.tarih1.TabIndex = 26;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl1.Location = new System.Drawing.Point(3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 20);
            this.labelControl1.TabIndex = 25;
            this.labelControl1.Text = "Tarih Aralığı";
            // 
            // bilancoaktifBindingSource
            // 
            this.bilancoaktifBindingSource.DataMember = "bilanco_aktif";
            this.bilancoaktifBindingSource.DataSource = this.dSRaporlama;
            // 
            // bilanco_aktifTableAdapter
            // 
            this.bilanco_aktifTableAdapter.ClearBeforeFill = true;
            // 
            // bilancopasifBindingSource
            // 
            this.bilancopasifBindingSource.DataMember = "bilanco_pasif";
            this.bilancopasifBindingSource.DataSource = this.dSRaporlama;
            // 
            // bilanco_pasifTableAdapter
            // 
            this.bilanco_pasifTableAdapter.ClearBeforeFill = true;
            // 
            // fIRMALARBindingSource
            // 
            this.fIRMALARBindingSource.DataMember = "FIRMALAR";
            this.fIRMALARBindingSource.DataSource = this.dSRaporlama;
            // 
            // fIRMALARTableAdapter
            // 
            this.fIRMALARTableAdapter.ClearBeforeFill = true;
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
            // Bilanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 471);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bilanco";
            this.Text = "Bilanco";
            this.Load += new System.EventHandler(this.Bilanco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menu24x24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRaporlama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtFirmaSec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dahil950.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilancoaktifBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilancopasifBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fIRMALARBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog raporKaydet;
        private DevExpress.Utils.ImageCollection menu24x24;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DSRaporlama dSRaporlama;
        private System.Windows.Forms.BindingSource bilancoBindingSource;
        private DSRaporlamaTableAdapters.bilancoTableAdapter bilancoTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colmuh_hesap_kod;
        private DevExpress.XtraGrid.Columns.GridColumn colmuh_hesap_isim1;
        private DevExpress.XtraGrid.Columns.GridColumn colmuh_hesap_isim2;
        private DevExpress.XtraGrid.Columns.GridColumn colborc;
        private DevExpress.XtraGrid.Columns.GridColumn colalacak;
        private DevExpress.XtraGrid.Columns.GridColumn colbakiye;
        private DevExpress.XtraGrid.Columns.GridColumn colbosluk;
        private DevExpress.XtraGrid.Columns.GridColumn colmuh_hesap_kod1;
        private DevExpress.XtraGrid.Columns.GridColumn colmuh_hesap_isim11;
        private DevExpress.XtraGrid.Columns.GridColumn colmuh_hesapisim22;
        private DevExpress.XtraGrid.Columns.GridColumn colborc1;
        private DevExpress.XtraGrid.Columns.GridColumn colalacak1;
        private DevExpress.XtraGrid.Columns.GridColumn colbakiye1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker tarih2;
        private System.Windows.Forms.DateTimePicker tarih1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource bilancoaktifBindingSource;
        private DSRaporlamaTableAdapters.bilanco_aktifTableAdapter bilanco_aktifTableAdapter;
        private System.Windows.Forms.BindingSource bilancopasifBindingSource;
        private DSRaporlamaTableAdapters.bilanco_pasifTableAdapter bilanco_pasifTableAdapter;
        private DevExpress.XtraEditors.CheckEdit dahil950;
        private System.Windows.Forms.BindingSource fIRMALARBindingSource;
        private DSRaporlamaTableAdapters.FIRMALARTableAdapter fIRMALARTableAdapter;
        private DSRaporlamaTableAdapters.TableAdapterManager tableAdapterManager;
        public DevExpress.XtraEditors.ButtonEdit txtFirmaSec;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}