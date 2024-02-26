namespace EgemenOgluRaporlama
{
    partial class MuvekkilUcretleriFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MuvekkilUcretleriFormu));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.muvekkillerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSRaporlama = new EgemenOgluRaporlama.DSRaporlama();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcha_belge_tarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcha_kod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcha_aciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcha_srmrkkodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcariAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSm_adi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoviz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcha_d_kur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbakiye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cold_bakiye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cole_bakiye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcha_kasa_hizkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhesapIsmi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.menu24x24 = new DevExpress.Utils.ImageCollection(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnTemizle = new DevExpress.XtraBars.BarButtonItem();
            this.btnSorgula = new DevExpress.XtraBars.BarButtonItem();
            this.btnExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnTumunuAc = new DevExpress.XtraBars.BarButtonItem();
            this.btnTumunuKapat = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tarih2 = new System.Windows.Forms.DateTimePicker();
            this.tarih1 = new System.Windows.Forms.DateTimePicker();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.raporKaydet = new System.Windows.Forms.SaveFileDialog();
            this.muvekkillerTableAdapter = new EgemenOgluRaporlama.DSRaporlamaTableAdapters.muvekkillerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muvekkillerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRaporlama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu24x24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.muvekkillerBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gridControl1.Location = new System.Drawing.Point(0, 61);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1362, 421);
            this.gridControl1.TabIndex = 14;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // muvekkillerBindingSource
            // 
            this.muvekkillerBindingSource.DataMember = "muvekkiller";
            this.muvekkillerBindingSource.DataSource = this.dSRaporlama;
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
            this.colIL,
            this.colcha_belge_tarih,
            this.colcha_kod,
            this.colcha_aciklama,
            this.colcha_srmrkkodu,
            this.colcariAdi,
            this.colSm_adi,
            this.colDoviz,
            this.colcha_d_kur,
            this.colbakiye,
            this.cold_bakiye,
            this.cole_bakiye,
            this.colcha_kasa_hizkod,
            this.colhesapIsmi});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 2;
            this.gridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "bakiye", this.colbakiye, "{0:n2}TL"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "d_bakiye", this.cold_bakiye, "{0:n2}USD"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "e_bakiye", this.cole_bakiye, "{0:n2}EURO")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIL, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSm_adi, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colIL
            // 
            this.colIL.Caption = "İL";
            this.colIL.FieldName = "IL";
            this.colIL.Name = "colIL";
            this.colIL.Width = 46;
            // 
            // colcha_belge_tarih
            // 
            this.colcha_belge_tarih.Caption = "Belge Tarihi";
            this.colcha_belge_tarih.FieldName = "cha_belge_tarih";
            this.colcha_belge_tarih.Name = "colcha_belge_tarih";
            this.colcha_belge_tarih.Visible = true;
            this.colcha_belge_tarih.VisibleIndex = 0;
            this.colcha_belge_tarih.Width = 88;
            // 
            // colcha_kod
            // 
            this.colcha_kod.Caption = "Müvekkil Kodu";
            this.colcha_kod.FieldName = "cha_kod";
            this.colcha_kod.Name = "colcha_kod";
            this.colcha_kod.Visible = true;
            this.colcha_kod.VisibleIndex = 10;
            this.colcha_kod.Width = 123;
            // 
            // colcha_aciklama
            // 
            this.colcha_aciklama.Caption = "Açıklama";
            this.colcha_aciklama.FieldName = "cha_aciklama";
            this.colcha_aciklama.Name = "colcha_aciklama";
            this.colcha_aciklama.Visible = true;
            this.colcha_aciklama.VisibleIndex = 2;
            this.colcha_aciklama.Width = 251;
            // 
            // colcha_srmrkkodu
            // 
            this.colcha_srmrkkodu.Caption = "SM Kodu";
            this.colcha_srmrkkodu.FieldName = "cha_srmrkkodu";
            this.colcha_srmrkkodu.Name = "colcha_srmrkkodu";
            this.colcha_srmrkkodu.Visible = true;
            this.colcha_srmrkkodu.VisibleIndex = 3;
            this.colcha_srmrkkodu.Width = 70;
            // 
            // colcariAdi
            // 
            this.colcariAdi.Caption = "Müvekkil Adı";
            this.colcariAdi.FieldName = "cariAdi";
            this.colcariAdi.Name = "colcariAdi";
            this.colcariAdi.OptionsColumn.ReadOnly = true;
            this.colcariAdi.Visible = true;
            this.colcariAdi.VisibleIndex = 4;
            this.colcariAdi.Width = 312;
            // 
            // colSm_adi
            // 
            this.colSm_adi.Caption = "Departman";
            this.colSm_adi.FieldName = "Sm_adi";
            this.colSm_adi.Name = "colSm_adi";
            this.colSm_adi.OptionsColumn.ReadOnly = true;
            this.colSm_adi.Width = 180;
            // 
            // colDoviz
            // 
            this.colDoviz.Caption = "Doviz";
            this.colDoviz.FieldName = "Doviz";
            this.colDoviz.Name = "colDoviz";
            this.colDoviz.OptionsColumn.ReadOnly = true;
            this.colDoviz.Visible = true;
            this.colDoviz.VisibleIndex = 5;
            this.colDoviz.Width = 53;
            // 
            // colcha_d_kur
            // 
            this.colcha_d_kur.Caption = "Kur";
            this.colcha_d_kur.DisplayFormat.FormatString = "{0:n2}";
            this.colcha_d_kur.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colcha_d_kur.FieldName = "cha_d_kur";
            this.colcha_d_kur.Name = "colcha_d_kur";
            this.colcha_d_kur.OptionsColumn.ReadOnly = true;
            this.colcha_d_kur.Visible = true;
            this.colcha_d_kur.VisibleIndex = 6;
            this.colcha_d_kur.Width = 41;
            // 
            // colbakiye
            // 
            this.colbakiye.Caption = "Bakiye {TL}";
            this.colbakiye.DisplayFormat.FormatString = "{0:n2}TL";
            this.colbakiye.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colbakiye.FieldName = "bakiye";
            this.colbakiye.Name = "colbakiye";
            this.colbakiye.OptionsColumn.ReadOnly = true;
            this.colbakiye.SummaryItem.DisplayFormat = "{0:n2}";
            this.colbakiye.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colbakiye.Visible = true;
            this.colbakiye.VisibleIndex = 7;
            this.colbakiye.Width = 90;
            // 
            // cold_bakiye
            // 
            this.cold_bakiye.Caption = "Bakiye {$}";
            this.cold_bakiye.DisplayFormat.FormatString = "{0:n2}$";
            this.cold_bakiye.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.cold_bakiye.FieldName = "d_bakiye";
            this.cold_bakiye.Name = "cold_bakiye";
            this.cold_bakiye.OptionsColumn.ReadOnly = true;
            this.cold_bakiye.SummaryItem.DisplayFormat = "{0:n2}";
            this.cold_bakiye.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.cold_bakiye.Visible = true;
            this.cold_bakiye.VisibleIndex = 8;
            this.cold_bakiye.Width = 84;
            // 
            // cole_bakiye
            // 
            this.cole_bakiye.Caption = "Bakiye {€}";
            this.cole_bakiye.DisplayFormat.FormatString = "{0:n2}€";
            this.cole_bakiye.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.cole_bakiye.FieldName = "e_bakiye";
            this.cole_bakiye.Name = "cole_bakiye";
            this.cole_bakiye.OptionsColumn.ReadOnly = true;
            this.cole_bakiye.SummaryItem.DisplayFormat = "{0:n2}";
            this.cole_bakiye.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.cole_bakiye.Visible = true;
            this.cole_bakiye.VisibleIndex = 9;
            this.cole_bakiye.Width = 84;
            // 
            // colcha_kasa_hizkod
            // 
            this.colcha_kasa_hizkod.Caption = "Hesap Kodu";
            this.colcha_kasa_hizkod.FieldName = "cha_kasa_hizkod";
            this.colcha_kasa_hizkod.Name = "colcha_kasa_hizkod";
            this.colcha_kasa_hizkod.Visible = true;
            this.colcha_kasa_hizkod.VisibleIndex = 11;
            this.colcha_kasa_hizkod.Width = 101;
            // 
            // colhesapIsmi
            // 
            this.colhesapIsmi.Caption = "Hesap Adı";
            this.colhesapIsmi.FieldName = "hesapIsmi";
            this.colhesapIsmi.Name = "colhesapIsmi";
            this.colhesapIsmi.Visible = true;
            this.colhesapIsmi.VisibleIndex = 1;
            this.colhesapIsmi.Width = 184;
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
            this.btnExcel,
            this.btnTumunuAc,
            this.btnTumunuKapat,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTemizle, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSorgula, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExcel, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTumunuAc, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTumunuKapat, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem3, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            // btnExcel
            // 
            this.btnExcel.Caption = "Excele Aktar";
            this.btnExcel.Id = 2;
            this.btnExcel.ImageIndex = 2;
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExcel_ItemClick);
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
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Gruplamayı Aç";
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.ImageIndex = 3;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Gruplamayı Kapat";
            this.barButtonItem2.Id = 6;
            this.barButtonItem2.ImageIndex = 4;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "En Uygun Genişlik";
            this.barButtonItem3.Id = 7;
            this.barButtonItem3.ImageIndex = 7;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1362, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 482);
            this.barDockControlBottom.Size = new System.Drawing.Size(1362, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 448);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1362, 34);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 448);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tarih2);
            this.panel1.Controls.Add(this.tarih1);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1362, 27);
            this.panel1.TabIndex = 23;
            // 
            // tarih2
            // 
            this.tarih2.Font = new System.Drawing.Font("Tahoma", 8F);
            this.tarih2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tarih2.Location = new System.Drawing.Point(199, 4);
            this.tarih2.Name = "tarih2";
            this.tarih2.Size = new System.Drawing.Size(114, 20);
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
            this.labelControl1.Text = "Tarih Aralığı";
            // 
            // muvekkillerTableAdapter
            // 
            this.muvekkillerTableAdapter.ClearBeforeFill = true;
            // 
            // MuvekkilUcretleriFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 482);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MuvekkilUcretleriFormu";
            this.Text = "Müvekkil Ücretleri";
            this.Load += new System.EventHandler(this.MuvekkilUcretleriFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muvekkillerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRaporlama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu24x24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Utils.ImageCollection menu24x24;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnTemizle;
        private DevExpress.XtraBars.BarButtonItem btnSorgula;
        private DevExpress.XtraBars.BarButtonItem btnExcel;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnTumunuAc;
        private DevExpress.XtraBars.BarButtonItem btnTumunuKapat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker tarih2;
        private System.Windows.Forms.DateTimePicker tarih1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.SaveFileDialog raporKaydet;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DSRaporlama dSRaporlama;
        private System.Windows.Forms.BindingSource muvekkillerBindingSource;
        private DSRaporlamaTableAdapters.muvekkillerTableAdapter muvekkillerTableAdapter;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraGrid.Columns.GridColumn colcha_belge_tarih;
        private DevExpress.XtraGrid.Columns.GridColumn colcha_kod;
        private DevExpress.XtraGrid.Columns.GridColumn colcha_aciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colcha_srmrkkodu;
        private DevExpress.XtraGrid.Columns.GridColumn colcariAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colSm_adi;
        private DevExpress.XtraGrid.Columns.GridColumn colDoviz;
        private DevExpress.XtraGrid.Columns.GridColumn colcha_d_kur;
        private DevExpress.XtraGrid.Columns.GridColumn colbakiye;
        private DevExpress.XtraGrid.Columns.GridColumn cold_bakiye;
        private DevExpress.XtraGrid.Columns.GridColumn cole_bakiye;
        private DevExpress.XtraGrid.Columns.GridColumn colIL;
        private DevExpress.XtraGrid.Columns.GridColumn colcha_kasa_hizkod;
        private DevExpress.XtraGrid.Columns.GridColumn colhesapIsmi;
    }
}