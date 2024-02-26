namespace EgemenOgluRaporlama.Butce
{
    partial class ButceAnalizi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ButceAnalizi));
            this.menu24x24 = new DevExpress.Utils.ImageCollection(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnButceGrafikselRapor = new DevExpress.XtraEditors.SimpleButton();
            this.cmbDonemAraligi = new System.Windows.Forms.ComboBox();
            this.lblDonemAraligi = new DevExpress.XtraEditors.LabelControl();
            this.tarih2 = new System.Windows.Forms.DateTimePicker();
            this.tarih1 = new System.Windows.Forms.DateTimePicker();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.grdButceAnalizi = new DevExpress.XtraGrid.GridControl();
            this.butceAnalizRaporuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsYeniRaporlar = new EgemenOgluRaporlama.dsYeniRaporlar();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBolge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSorumlulukMerkeziAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBelirlenenButceGelir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colButcelenenGelir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGerceklesenGelir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBelirlenenButceGider = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colButcelenenGider = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGerceklesenGider = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colButcelenenGerceklesenGelir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colButcelenenGerceklesenGider = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYuzdeGelirSapmasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYuzdeGiderSapmasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.butceAnalizRaporuTableAdapter = new EgemenOgluRaporlama.dsYeniRaporlarTableAdapters.ButceAnalizRaporuTableAdapter();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnTemizle = new DevExpress.XtraBars.BarButtonItem();
            this.btnSorgula = new DevExpress.XtraBars.BarButtonItem();
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
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.raporKaydet = new System.Windows.Forms.SaveFileDialog();
            this.dsYeniRaporlar1 = new EgemenOgluRaporlama.dsYeniRaporlar();
            this.tblButceRaporAnaliziBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblButceRaporAnaliziTableAdapter = new EgemenOgluRaporlama.dsYeniRaporlarTableAdapters.tblButceRaporAnaliziTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.menu24x24)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdButceAnalizi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.butceAnalizRaporuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsYeniRaporlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsYeniRaporlar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblButceRaporAnaliziBindingSource)).BeginInit();
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
            this.panel1.Controls.Add(this.btnButceGrafikselRapor);
            this.panel1.Controls.Add(this.cmbDonemAraligi);
            this.panel1.Controls.Add(this.lblDonemAraligi);
            this.panel1.Controls.Add(this.tarih2);
            this.panel1.Controls.Add(this.tarih1);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 27);
            this.panel1.TabIndex = 25;
            // 
            // btnButceGrafikselRapor
            // 
            this.btnButceGrafikselRapor.Location = new System.Drawing.Point(487, 4);
            this.btnButceGrafikselRapor.Name = "btnButceGrafikselRapor";
            this.btnButceGrafikselRapor.Size = new System.Drawing.Size(152, 19);
            this.btnButceGrafikselRapor.TabIndex = 41;
            this.btnButceGrafikselRapor.Text = "Grafiksel Raporu Görüntüle";
            this.btnButceGrafikselRapor.Click += new System.EventHandler(this.btnButceGrafikselRapor_Click);
            // 
            // cmbDonemAraligi
            // 
            this.cmbDonemAraligi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDonemAraligi.FormattingEnabled = true;
            this.cmbDonemAraligi.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbDonemAraligi.Location = new System.Drawing.Point(405, 2);
            this.cmbDonemAraligi.Name = "cmbDonemAraligi";
            this.cmbDonemAraligi.Size = new System.Drawing.Size(75, 21);
            this.cmbDonemAraligi.TabIndex = 40;
            // 
            // lblDonemAraligi
            // 
            this.lblDonemAraligi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDonemAraligi.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblDonemAraligi.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.lblDonemAraligi.Location = new System.Drawing.Point(318, 4);
            this.lblDonemAraligi.Name = "lblDonemAraligi";
            this.lblDonemAraligi.Size = new System.Drawing.Size(82, 20);
            this.lblDonemAraligi.TabIndex = 39;
            this.lblDonemAraligi.Text = "Dönem Aralığı";
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
            // grdButceAnalizi
            // 
            this.grdButceAnalizi.DataSource = this.butceAnalizRaporuBindingSource;
            this.grdButceAnalizi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdButceAnalizi.Location = new System.Drawing.Point(0, 61);
            this.grdButceAnalizi.MainView = this.gridView1;
            this.grdButceAnalizi.Name = "grdButceAnalizi";
            this.grdButceAnalizi.Size = new System.Drawing.Size(986, 425);
            this.grdButceAnalizi.TabIndex = 26;
            this.grdButceAnalizi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // butceAnalizRaporuBindingSource
            // 
            this.butceAnalizRaporuBindingSource.DataMember = "ButceAnalizRaporu";
            this.butceAnalizRaporuBindingSource.DataSource = this.dsYeniRaporlar;
            // 
            // dsYeniRaporlar
            // 
            this.dsYeniRaporlar.DataSetName = "dsYeniRaporlar";
            this.dsYeniRaporlar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.gridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gridView1.Appearance.GroupPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView1.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.Preview.Options.UseBackColor = true;
            this.gridView1.Appearance.Preview.Options.UseForeColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBolge,
            this.colSorumlulukMerkeziAdi,
            this.colYil,
            this.colBelirlenenButceGelir,
            this.colButcelenenGelir,
            this.colGerceklesenGelir,
            this.colBelirlenenButceGider,
            this.colButcelenenGider,
            this.colGerceklesenGider,
            this.colButcelenenGerceklesenGelir,
            this.colButcelenenGerceklesenGider,
            this.colYuzdeGelirSapmasi,
            this.colYuzdeGiderSapmasi});
            this.gridView1.GridControl = this.grdButceAnalizi;
            this.gridView1.GroupCount = 2;
            this.gridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BelirlenenButceGelir", this.colBelirlenenButceGelir, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ButcelenenGelir", this.colButcelenenGelir, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GerceklesenGelir", this.colGerceklesenGelir, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BelirlenenButceGider", this.colBelirlenenButceGider, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ButcelenenGider", this.colButcelenenGider, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GerceklesenGider", this.colGerceklesenGider, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ButcelenenGerceklesenGelir", this.colButcelenenGerceklesenGelir, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ButcelenenGerceklesenGider", this.colButcelenenGerceklesenGider, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "YuzdeGelirSapmasi", this.colYuzdeGelirSapmasi, "%{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "YuzdeGiderSapmasi", this.colYuzdeGiderSapmasi, "%{0:n2}")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colBolge, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSorumlulukMerkeziAdi, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colBolge
            // 
            this.colBolge.FieldName = "Bolge";
            this.colBolge.Name = "colBolge";
            this.colBolge.OptionsColumn.ReadOnly = true;
            this.colBolge.Visible = true;
            this.colBolge.VisibleIndex = 0;
            // 
            // colSorumlulukMerkeziAdi
            // 
            this.colSorumlulukMerkeziAdi.FieldName = "SorumlulukMerkeziAdi";
            this.colSorumlulukMerkeziAdi.Name = "colSorumlulukMerkeziAdi";
            this.colSorumlulukMerkeziAdi.OptionsColumn.ReadOnly = true;
            this.colSorumlulukMerkeziAdi.Visible = true;
            this.colSorumlulukMerkeziAdi.VisibleIndex = 0;
            this.colSorumlulukMerkeziAdi.Width = 100;
            // 
            // colYil
            // 
            this.colYil.FieldName = "Yil";
            this.colYil.Name = "colYil";
            this.colYil.OptionsColumn.ReadOnly = true;
            this.colYil.Visible = true;
            this.colYil.VisibleIndex = 0;
            this.colYil.Width = 95;
            // 
            // colBelirlenenButceGelir
            // 
            this.colBelirlenenButceGelir.DisplayFormat.FormatString = "n2";
            this.colBelirlenenButceGelir.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colBelirlenenButceGelir.FieldName = "BelirlenenButceGelir";
            this.colBelirlenenButceGelir.Name = "colBelirlenenButceGelir";
            this.colBelirlenenButceGelir.OptionsColumn.ReadOnly = true;
            this.colBelirlenenButceGelir.SummaryItem.DisplayFormat = "{0:n2}";
            this.colBelirlenenButceGelir.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colBelirlenenButceGelir.Visible = true;
            this.colBelirlenenButceGelir.VisibleIndex = 1;
            this.colBelirlenenButceGelir.Width = 112;
            // 
            // colButcelenenGelir
            // 
            this.colButcelenenGelir.DisplayFormat.FormatString = "n2";
            this.colButcelenenGelir.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colButcelenenGelir.FieldName = "ButcelenenGelir";
            this.colButcelenenGelir.Name = "colButcelenenGelir";
            this.colButcelenenGelir.OptionsColumn.ReadOnly = true;
            this.colButcelenenGelir.SummaryItem.DisplayFormat = "{0:n2}";
            this.colButcelenenGelir.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colButcelenenGelir.Visible = true;
            this.colButcelenenGelir.VisibleIndex = 2;
            this.colButcelenenGelir.Width = 111;
            // 
            // colGerceklesenGelir
            // 
            this.colGerceklesenGelir.DisplayFormat.FormatString = "n2";
            this.colGerceklesenGelir.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colGerceklesenGelir.FieldName = "GerceklesenGelir";
            this.colGerceklesenGelir.Name = "colGerceklesenGelir";
            this.colGerceklesenGelir.OptionsColumn.ReadOnly = true;
            this.colGerceklesenGelir.SummaryItem.DisplayFormat = "{0:n2}";
            this.colGerceklesenGelir.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colGerceklesenGelir.Visible = true;
            this.colGerceklesenGelir.VisibleIndex = 3;
            this.colGerceklesenGelir.Width = 118;
            // 
            // colBelirlenenButceGider
            // 
            this.colBelirlenenButceGider.DisplayFormat.FormatString = "n2";
            this.colBelirlenenButceGider.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colBelirlenenButceGider.FieldName = "BelirlenenButceGider";
            this.colBelirlenenButceGider.Name = "colBelirlenenButceGider";
            this.colBelirlenenButceGider.OptionsColumn.ReadOnly = true;
            this.colBelirlenenButceGider.SummaryItem.DisplayFormat = "{0:n2}";
            this.colBelirlenenButceGider.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colBelirlenenButceGider.Visible = true;
            this.colBelirlenenButceGider.VisibleIndex = 4;
            this.colBelirlenenButceGider.Width = 143;
            // 
            // colButcelenenGider
            // 
            this.colButcelenenGider.DisplayFormat.FormatString = "n2";
            this.colButcelenenGider.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colButcelenenGider.FieldName = "ButcelenenGider";
            this.colButcelenenGider.Name = "colButcelenenGider";
            this.colButcelenenGider.OptionsColumn.ReadOnly = true;
            this.colButcelenenGider.SummaryItem.DisplayFormat = "{0:n2}";
            this.colButcelenenGider.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colButcelenenGider.Visible = true;
            this.colButcelenenGider.VisibleIndex = 5;
            this.colButcelenenGider.Width = 112;
            // 
            // colGerceklesenGider
            // 
            this.colGerceklesenGider.DisplayFormat.FormatString = "n2";
            this.colGerceklesenGider.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colGerceklesenGider.FieldName = "GerceklesenGider";
            this.colGerceklesenGider.Name = "colGerceklesenGider";
            this.colGerceklesenGider.OptionsColumn.ReadOnly = true;
            this.colGerceklesenGider.SummaryItem.DisplayFormat = "{0:n2}";
            this.colGerceklesenGider.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colGerceklesenGider.Visible = true;
            this.colGerceklesenGider.VisibleIndex = 6;
            this.colGerceklesenGider.Width = 112;
            // 
            // colButcelenenGerceklesenGelir
            // 
            this.colButcelenenGerceklesenGelir.DisplayFormat.FormatString = "n2";
            this.colButcelenenGerceklesenGelir.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colButcelenenGerceklesenGelir.FieldName = "ButcelenenGerceklesenGelir";
            this.colButcelenenGerceklesenGelir.Name = "colButcelenenGerceklesenGelir";
            this.colButcelenenGerceklesenGelir.OptionsColumn.ReadOnly = true;
            this.colButcelenenGerceklesenGelir.SummaryItem.DisplayFormat = "{0:n2}";
            this.colButcelenenGerceklesenGelir.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colButcelenenGerceklesenGelir.Visible = true;
            this.colButcelenenGerceklesenGelir.VisibleIndex = 7;
            this.colButcelenenGerceklesenGelir.Width = 112;
            // 
            // colButcelenenGerceklesenGider
            // 
            this.colButcelenenGerceklesenGider.DisplayFormat.FormatString = "n2";
            this.colButcelenenGerceklesenGider.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colButcelenenGerceklesenGider.FieldName = "ButcelenenGerceklesenGider";
            this.colButcelenenGerceklesenGider.Name = "colButcelenenGerceklesenGider";
            this.colButcelenenGerceklesenGider.OptionsColumn.ReadOnly = true;
            this.colButcelenenGerceklesenGider.SummaryItem.DisplayFormat = "{0:n2}";
            this.colButcelenenGerceklesenGider.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colButcelenenGerceklesenGider.Visible = true;
            this.colButcelenenGerceklesenGider.VisibleIndex = 8;
            this.colButcelenenGerceklesenGider.Width = 112;
            // 
            // colYuzdeGelirSapmasi
            // 
            this.colYuzdeGelirSapmasi.DisplayFormat.FormatString = "n2";
            this.colYuzdeGelirSapmasi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colYuzdeGelirSapmasi.FieldName = "YuzdeGelirSapmasi";
            this.colYuzdeGelirSapmasi.Name = "colYuzdeGelirSapmasi";
            this.colYuzdeGelirSapmasi.OptionsColumn.ReadOnly = true;
            this.colYuzdeGelirSapmasi.SummaryItem.DisplayFormat = "{0:n2}";
            this.colYuzdeGelirSapmasi.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colYuzdeGelirSapmasi.Visible = true;
            this.colYuzdeGelirSapmasi.VisibleIndex = 9;
            this.colYuzdeGelirSapmasi.Width = 109;
            // 
            // colYuzdeGiderSapmasi
            // 
            this.colYuzdeGiderSapmasi.DisplayFormat.FormatString = "n2";
            this.colYuzdeGiderSapmasi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colYuzdeGiderSapmasi.FieldName = "YuzdeGiderSapmasi";
            this.colYuzdeGiderSapmasi.Name = "colYuzdeGiderSapmasi";
            this.colYuzdeGiderSapmasi.OptionsColumn.ReadOnly = true;
            this.colYuzdeGiderSapmasi.SummaryItem.DisplayFormat = "{0:n2}";
            this.colYuzdeGiderSapmasi.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colYuzdeGiderSapmasi.Visible = true;
            this.colYuzdeGiderSapmasi.VisibleIndex = 10;
            this.colYuzdeGiderSapmasi.Width = 137;
            // 
            // butceAnalizRaporuTableAdapter
            // 
            this.butceAnalizRaporuTableAdapter.ClearBeforeFill = true;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Images = this.menu24x24;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnTemizle,
            this.btnSorgula,
            this.barButtonItem3,
            this.btnExcelAktar,
            this.btnDetayAc,
            this.btnDetayKapat,
            this.btnGrupAc,
            this.btnGrupKapat,
            this.btnEnUygunGenislik});
            this.barManager1.MainMenu = this.bar3;
            this.barManager1.MaxItemId = 10;
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTemizle, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSorgula, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExcelAktar, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDetayAc, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDetayKapat, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGrupAc, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGrupKapat, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEnUygunGenislik, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
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
            this.btnExcelAktar.Id = 3;
            this.btnExcelAktar.ImageIndex = 2;
            this.btnExcelAktar.Name = "btnExcelAktar";
            this.btnExcelAktar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExcelAktar_ItemClick);
            // 
            // btnDetayAc
            // 
            this.btnDetayAc.Caption = "Detay Aç";
            this.btnDetayAc.Id = 4;
            this.btnDetayAc.ImageIndex = 5;
            this.btnDetayAc.Name = "btnDetayAc";
            this.btnDetayAc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDetayAc_ItemClick);
            // 
            // btnDetayKapat
            // 
            this.btnDetayKapat.Caption = "Detay Kapat";
            this.btnDetayKapat.Id = 6;
            this.btnDetayKapat.ImageIndex = 6;
            this.btnDetayKapat.Name = "btnDetayKapat";
            this.btnDetayKapat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDetayKapat_ItemClick);
            // 
            // btnGrupAc
            // 
            this.btnGrupAc.Caption = "Gruplamayı Aç";
            this.btnGrupAc.Id = 7;
            this.btnGrupAc.ImageIndex = 3;
            this.btnGrupAc.Name = "btnGrupAc";
            this.btnGrupAc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGrupAc_ItemClick);
            // 
            // btnGrupKapat
            // 
            this.btnGrupKapat.Caption = "Gruplamayı Kapat";
            this.btnGrupKapat.Id = 8;
            this.btnGrupKapat.ImageIndex = 4;
            this.btnGrupKapat.Name = "btnGrupKapat";
            this.btnGrupKapat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGrupKapat_ItemClick);
            // 
            // btnEnUygunGenislik
            // 
            this.btnEnUygunGenislik.Caption = "En Uygun Genişlik";
            this.btnEnUygunGenislik.Id = 9;
            this.btnEnUygunGenislik.ImageIndex = 7;
            this.btnEnUygunGenislik.Name = "btnEnUygunGenislik";
            this.btnEnUygunGenislik.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEnUygunGenislik_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(986, 34);
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
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 452);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(986, 34);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 452);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // dsYeniRaporlar1
            // 
            this.dsYeniRaporlar1.DataSetName = "dsYeniRaporlar";
            this.dsYeniRaporlar1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblButceRaporAnaliziBindingSource
            // 
            this.tblButceRaporAnaliziBindingSource.DataMember = "tblButceRaporAnalizi";
            this.tblButceRaporAnaliziBindingSource.DataSource = this.dsYeniRaporlar1;
            // 
            // tblButceRaporAnaliziTableAdapter
            // 
            this.tblButceRaporAnaliziTableAdapter.ClearBeforeFill = true;
            // 
            // ButceAnalizi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 486);
            this.Controls.Add(this.grdButceAnalizi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ButceAnalizi";
            this.Text = "Bütçe Analizi";
            this.Load += new System.EventHandler(this.ButceAnalizi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menu24x24)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdButceAnalizi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.butceAnalizRaporuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsYeniRaporlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsYeniRaporlar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblButceRaporAnaliziBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.ImageCollection menu24x24;
        private DevExpress.XtraGrid.GridControl grdButceAnalizi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker tarih2;
        private System.Windows.Forms.DateTimePicker tarih1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private dsYeniRaporlar dsYeniRaporlar;
        private System.Windows.Forms.BindingSource butceAnalizRaporuBindingSource;
        private dsYeniRaporlarTableAdapters.ButceAnalizRaporuTableAdapter butceAnalizRaporuTableAdapter;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnTemizle;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnSorgula;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraGrid.Columns.GridColumn colBolge;
        private DevExpress.XtraGrid.Columns.GridColumn colSorumlulukMerkeziAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colYil;
        private DevExpress.XtraGrid.Columns.GridColumn colBelirlenenButceGelir;
        private DevExpress.XtraGrid.Columns.GridColumn colButcelenenGelir;
        private DevExpress.XtraGrid.Columns.GridColumn colGerceklesenGelir;
        private DevExpress.XtraGrid.Columns.GridColumn colBelirlenenButceGider;
        private DevExpress.XtraGrid.Columns.GridColumn colButcelenenGider;
        private DevExpress.XtraGrid.Columns.GridColumn colGerceklesenGider;
        private DevExpress.XtraGrid.Columns.GridColumn colButcelenenGerceklesenGelir;
        private DevExpress.XtraGrid.Columns.GridColumn colButcelenenGerceklesenGider;
        private DevExpress.XtraGrid.Columns.GridColumn colYuzdeGelirSapmasi;
        private DevExpress.XtraGrid.Columns.GridColumn colYuzdeGiderSapmasi;
        private DevExpress.XtraBars.BarButtonItem btnExcelAktar;
        private DevExpress.XtraBars.BarButtonItem btnDetayAc;
        private DevExpress.XtraBars.BarButtonItem btnDetayKapat;
        private DevExpress.XtraBars.BarButtonItem btnGrupAc;
        private DevExpress.XtraBars.BarButtonItem btnGrupKapat;
        private DevExpress.XtraBars.BarButtonItem btnEnUygunGenislik;
        private System.Windows.Forms.SaveFileDialog raporKaydet;
        private System.Windows.Forms.ComboBox cmbDonemAraligi;
        private DevExpress.XtraEditors.LabelControl lblDonemAraligi;
        private dsYeniRaporlar dsYeniRaporlar1;
        private System.Windows.Forms.BindingSource tblButceRaporAnaliziBindingSource;
        private dsYeniRaporlarTableAdapters.tblButceRaporAnaliziTableAdapter tblButceRaporAnaliziTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnButceGrafikselRapor;
        //private System.Windows.Forms.BindingSource tblButceRaporAnaliziBindingSource;
        //private dsYeniRaporlarTableAdapters.tblButceRaporAnaliziTableAdapter tblButceRaporAnaliziTableAdapter;

    }
}