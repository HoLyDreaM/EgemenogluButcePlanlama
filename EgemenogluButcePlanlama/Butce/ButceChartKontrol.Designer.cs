namespace EgemenOgluRaporlama.Butce
{
    partial class ButceChartKontrol
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel2 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel3 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel4 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel5 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ButceChartKontrol));
            this.tblButceRaporAnaliziBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsYeniRaporlar = new EgemenOgluRaporlama.dsYeniRaporlar();
            this.tblButceRaporAnaliziTableAdapter = new EgemenOgluRaporlama.dsYeniRaporlarTableAdapters.tblButceRaporAnaliziTableAdapter();
            this.chartButceAnalizi = new DevExpress.XtraCharts.ChartControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnYazdir = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.menu24x24 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tblButceRaporAnaliziBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsYeniRaporlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartButceAnalizi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu24x24)).BeginInit();
            this.SuspendLayout();
            // 
            // tblButceRaporAnaliziBindingSource
            // 
            this.tblButceRaporAnaliziBindingSource.DataMember = "tblButceRaporAnalizi";
            this.tblButceRaporAnaliziBindingSource.DataSource = this.dsYeniRaporlar;
            // 
            // dsYeniRaporlar
            // 
            this.dsYeniRaporlar.DataSetName = "dsYeniRaporlar";
            this.dsYeniRaporlar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblButceRaporAnaliziTableAdapter
            // 
            this.tblButceRaporAnaliziTableAdapter.ClearBeforeFill = true;
            // 
            // chartButceAnalizi
            // 
            this.chartButceAnalizi.DataSource = this.tblButceRaporAnaliziBindingSource;
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartButceAnalizi.Diagram = xyDiagram1;
            this.chartButceAnalizi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartButceAnalizi.Legend.Padding.Bottom = 3;
            this.chartButceAnalizi.Legend.Padding.Left = 3;
            this.chartButceAnalizi.Legend.Padding.Right = 3;
            this.chartButceAnalizi.Legend.Padding.Top = 3;
            this.chartButceAnalizi.Legend.VerticalIndent = 3;
            this.chartButceAnalizi.Location = new System.Drawing.Point(0, 39);
            this.chartButceAnalizi.Name = "chartButceAnalizi";
            series1.ArgumentDataMember = "Bolge";
            sideBySideBarSeriesLabel1.Border.Visible = false;
            sideBySideBarSeriesLabel1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Empty;
            sideBySideBarSeriesLabel1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            sideBySideBarSeriesLabel1.LineVisible = true;
            sideBySideBarSeriesLabel1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            sideBySideBarSeriesLabel1.TextOrientation = DevExpress.XtraCharts.TextOrientation.BottomToTop;
            series1.Label = sideBySideBarSeriesLabel1;
            series1.Name = "Bütçelenen Gelir";
            series1.ValueDataMembersSerializable = "ButcelenenGelir";
            series2.ArgumentDataMember = "Bolge";
            sideBySideBarSeriesLabel2.Border.Visible = false;
            sideBySideBarSeriesLabel2.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Empty;
            sideBySideBarSeriesLabel2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            sideBySideBarSeriesLabel2.LineVisible = true;
            sideBySideBarSeriesLabel2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            sideBySideBarSeriesLabel2.TextOrientation = DevExpress.XtraCharts.TextOrientation.BottomToTop;
            series2.Label = sideBySideBarSeriesLabel2;
            series2.Name = "Bütçelenen Gider";
            series2.ValueDataMembersSerializable = "ButcelenenGider";
            series3.ArgumentDataMember = "Bolge";
            sideBySideBarSeriesLabel3.Border.Visible = false;
            sideBySideBarSeriesLabel3.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Empty;
            sideBySideBarSeriesLabel3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            sideBySideBarSeriesLabel3.LineVisible = true;
            sideBySideBarSeriesLabel3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            sideBySideBarSeriesLabel3.TextOrientation = DevExpress.XtraCharts.TextOrientation.BottomToTop;
            series3.Label = sideBySideBarSeriesLabel3;
            series3.Name = "Gerçekleşen Gelir";
            series3.ValueDataMembersSerializable = "GerceklesenGelir";
            series4.ArgumentDataMember = "Bolge";
            sideBySideBarSeriesLabel4.Border.Visible = false;
            sideBySideBarSeriesLabel4.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Empty;
            sideBySideBarSeriesLabel4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            sideBySideBarSeriesLabel4.LineVisible = true;
            sideBySideBarSeriesLabel4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            sideBySideBarSeriesLabel4.TextOrientation = DevExpress.XtraCharts.TextOrientation.BottomToTop;
            series4.Label = sideBySideBarSeriesLabel4;
            series4.Name = "Gerçekleşen Gider";
            series4.ValueDataMembersSerializable = "GerceklesenGider";
            this.chartButceAnalizi.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2,
        series3,
        series4};
            sideBySideBarSeriesLabel5.LineVisible = true;
            this.chartButceAnalizi.SeriesTemplate.Label = sideBySideBarSeriesLabel5;
            this.chartButceAnalizi.Size = new System.Drawing.Size(986, 447);
            this.chartButceAnalizi.TabIndex = 0;
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
            this.btnYazdir});
            this.barManager1.MaxItemId = 1;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnYazdir, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnYazdir
            // 
            this.btnYazdir.Caption = "Yazdir";
            this.btnYazdir.Id = 0;
            this.btnYazdir.ImageIndex = 8;
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnYazdir_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(986, 39);
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
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 447);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(986, 39);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 447);
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
            this.menu24x24.Images.SetKeyName(8, "Printer.png");
            // 
            // ButceChartKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 486);
            this.Controls.Add(this.chartButceAnalizi);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "ButceChartKontrol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bütçe Grafiksel Rapor Analizi";
            this.Load += new System.EventHandler(this.ButceChartKontrol_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButceChartKontrol_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tblButceRaporAnaliziBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsYeniRaporlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartButceAnalizi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu24x24)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private dsYeniRaporlarTableAdapters.tblButceRaporAnaliziTableAdapter tblButceRaporAnaliziTableAdapter;
        private dsYeniRaporlar dsYeniRaporlar;
        private System.Windows.Forms.BindingSource tblButceRaporAnaliziBindingSource;
        private DevExpress.XtraCharts.ChartControl chartButceAnalizi;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.Utils.ImageCollection menu24x24;
        private DevExpress.XtraBars.BarButtonItem btnYazdir;
    }
}