namespace EgemenOgluRaporlama.InsanKaynaklari
{
    partial class gunlukGiris
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gunlukGiris));
            this.colp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kayıtDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ikgunlukListeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSRaporlama = new EgemenOgluRaporlama.DSRaporlama();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmpNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdiSoyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartman = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgKapisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgGC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgGCs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgTip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgDegTar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgDegYap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgEskiTar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgEventNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coliUserSlot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ik_gunlukListeTableAdapter = new EgemenOgluRaporlama.DSRaporlamaTableAdapters.ik_gunlukListeTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.txtZaman = new System.Windows.Forms.NumericUpDown();
            this.oto = new System.Windows.Forms.CheckBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gEventNumTextBox = new System.Windows.Forms.TextBox();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.menu24x24 = new DevExpress.Utils.ImageCollection(this.components);
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.raporKaydet = new System.Windows.Forms.SaveFileDialog();
            this.timerPb = new System.Windows.Forms.Timer(this.components);
            this.tableAdapterManager = new EgemenOgluRaporlama.DSRaporlamaTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ikgunlukListeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRaporlama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZaman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu24x24)).BeginInit();
            this.SuspendLayout();
            // 
            // colp
            // 
            this.colp.Caption = "gPuan";
            this.colp.FieldName = "p";
            this.colp.Name = "colp";
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.DataSource = this.ikgunlukListeBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 62);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1102, 427);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtDüzenleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(146, 26);
            // 
            // kayıtDüzenleToolStripMenuItem
            // 
            this.kayıtDüzenleToolStripMenuItem.Name = "kayıtDüzenleToolStripMenuItem";
            this.kayıtDüzenleToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.kayıtDüzenleToolStripMenuItem.Text = "Kayıt Düzenle";
            this.kayıtDüzenleToolStripMenuItem.Click += new System.EventHandler(this.kayıtDüzenleToolStripMenuItem_Click);
            // 
            // ikgunlukListeBindingSource
            // 
            this.ikgunlukListeBindingSource.DataMember = "ik_gunlukListe";
            this.ikgunlukListeBindingSource.DataSource = this.dSRaporlama;
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
            this.colEmpNum,
            this.colAdiSoyadi,
            this.colil,
            this.colDepartman,
            this.colSaat,
            this.colgKapisi,
            this.colgGC,
            this.colgGCs,
            this.colgAciklama,
            this.colgTip,
            this.colgDegTar,
            this.colgDegYap,
            this.colgEskiTar,
            this.colgEventNum,
            this.colp,
            this.colgTarihi,
            this.coliUserSlot});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(681, 459, 216, 199);
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.White;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colp;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition1.Expression = "[p] == 1";
            styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            styleFormatCondition2.Appearance.Options.UseBackColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colp;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition2.Expression = "[p] >= 2";
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.VertScrollTipFieldName = "AdiSoyadi";
            // 
            // colEmpNum
            // 
            this.colEmpNum.Caption = "ID";
            this.colEmpNum.FieldName = "EmpNum";
            this.colEmpNum.Name = "colEmpNum";
            this.colEmpNum.Visible = true;
            this.colEmpNum.VisibleIndex = 0;
            this.colEmpNum.Width = 76;
            // 
            // colAdiSoyadi
            // 
            this.colAdiSoyadi.AppearanceHeader.Options.UseTextOptions = true;
            this.colAdiSoyadi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAdiSoyadi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAdiSoyadi.Caption = "Adı ve Soyadı";
            this.colAdiSoyadi.FieldName = "AdiSoyadi";
            this.colAdiSoyadi.Name = "colAdiSoyadi";
            this.colAdiSoyadi.OptionsColumn.ReadOnly = true;
            this.colAdiSoyadi.Visible = true;
            this.colAdiSoyadi.VisibleIndex = 1;
            this.colAdiSoyadi.Width = 95;
            // 
            // colil
            // 
            this.colil.Caption = "İL";
            this.colil.FieldName = "il";
            this.colil.Name = "colil";
            this.colil.Visible = true;
            this.colil.VisibleIndex = 2;
            this.colil.Width = 104;
            // 
            // colDepartman
            // 
            this.colDepartman.Caption = "Departman";
            this.colDepartman.FieldName = "Departman";
            this.colDepartman.Name = "colDepartman";
            this.colDepartman.Visible = true;
            this.colDepartman.VisibleIndex = 3;
            this.colDepartman.Width = 95;
            // 
            // colSaat
            // 
            this.colSaat.Caption = "Giriş Saati";
            this.colSaat.FieldName = "Saat";
            this.colSaat.Name = "colSaat";
            this.colSaat.Visible = true;
            this.colSaat.VisibleIndex = 4;
            this.colSaat.Width = 76;
            // 
            // colgKapisi
            // 
            this.colgKapisi.Caption = "Giriş Kapısı";
            this.colgKapisi.FieldName = "gKapisi";
            this.colgKapisi.Name = "colgKapisi";
            this.colgKapisi.Visible = true;
            this.colgKapisi.VisibleIndex = 5;
            this.colgKapisi.Width = 237;
            // 
            // colgGC
            // 
            this.colgGC.Caption = "GC";
            this.colgGC.FieldName = "gGC";
            this.colgGC.Name = "colgGC";
            // 
            // colgGCs
            // 
            this.colgGCs.Caption = "GC Sayisal";
            this.colgGCs.FieldName = "gGCs";
            this.colgGCs.Name = "colgGCs";
            // 
            // colgAciklama
            // 
            this.colgAciklama.Caption = "Açıklama";
            this.colgAciklama.FieldName = "gAciklama";
            this.colgAciklama.Name = "colgAciklama";
            this.colgAciklama.Visible = true;
            this.colgAciklama.VisibleIndex = 6;
            this.colgAciklama.Width = 229;
            // 
            // colgTip
            // 
            this.colgTip.Caption = "Hareket Durumu";
            this.colgTip.FieldName = "gTip";
            this.colgTip.Name = "colgTip";
            this.colgTip.Width = 103;
            // 
            // colgDegTar
            // 
            this.colgDegTar.Caption = "gDeğişiklik Tarihi";
            this.colgDegTar.FieldName = "gDegTar";
            this.colgDegTar.Name = "colgDegTar";
            this.colgDegTar.Width = 105;
            // 
            // colgDegYap
            // 
            this.colgDegYap.Caption = "gDeğişiklikYapan";
            this.colgDegYap.FieldName = "gDegYap";
            this.colgDegYap.Name = "colgDegYap";
            this.colgDegYap.Width = 105;
            // 
            // colgEskiTar
            // 
            this.colgEskiTar.Caption = "gEskiTarihi";
            this.colgEskiTar.FieldName = "gEskiTar";
            this.colgEskiTar.Name = "colgEskiTar";
            // 
            // colgEventNum
            // 
            this.colgEventNum.Caption = "gEventNum";
            this.colgEventNum.FieldName = "gEventNum";
            this.colgEventNum.Name = "colgEventNum";
            this.colgEventNum.Width = 80;
            // 
            // colgTarihi
            // 
            this.colgTarihi.DisplayFormat.FormatString = "dd.MM.yyyy HH:mm:ss";
            this.colgTarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colgTarihi.FieldName = "gTarihi";
            this.colgTarihi.Name = "colgTarihi";
            // 
            // coliUserSlot
            // 
            this.coliUserSlot.FieldName = "iUserSlot";
            this.coliUserSlot.Name = "coliUserSlot";
            // 
            // ik_gunlukListeTableAdapter
            // 
            this.ik_gunlukListeTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pb1);
            this.panel1.Controls.Add(this.txtZaman);
            this.panel1.Controls.Add(this.oto);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.tarih);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1102, 28);
            this.panel1.TabIndex = 25;
            // 
            // pb1
            // 
            this.pb1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pb1.Location = new System.Drawing.Point(875, 0);
            this.pb1.Name = "pb1";
            this.pb1.Properties.ShowTitle = true;
            this.pb1.Properties.Step = 1;
            this.pb1.Size = new System.Drawing.Size(227, 28);
            this.pb1.TabIndex = 38;
            // 
            // txtZaman
            // 
            this.txtZaman.Location = new System.Drawing.Point(321, 4);
            this.txtZaman.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtZaman.Name = "txtZaman";
            this.txtZaman.Size = new System.Drawing.Size(100, 21);
            this.txtZaman.TabIndex = 35;
            this.txtZaman.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // oto
            // 
            this.oto.AutoSize = true;
            this.oto.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.oto.Location = new System.Drawing.Point(426, 6);
            this.oto.Name = "oto";
            this.oto.Size = new System.Drawing.Size(56, 17);
            this.oto.TabIndex = 32;
            this.oto.Text = "Başla";
            this.oto.UseVisualStyleBackColor = true;
            this.oto.CheckedChanged += new System.EventHandler(this.oto_CheckedChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl2.Location = new System.Drawing.Point(204, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(117, 20);
            this.labelControl2.TabIndex = 28;
            this.labelControl2.Text = "Oto. Yenile(Dakika)";
            // 
            // tarih
            // 
            this.tarih.Font = new System.Drawing.Font("Tahoma", 8F);
            this.tarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tarih.Location = new System.Drawing.Point(86, 4);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(107, 20);
            this.tarih.TabIndex = 27;
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
            this.labelControl1.Text = "Tarih";
            // 
            // gEventNumTextBox
            // 
            this.gEventNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ikgunlukListeBindingSource, "gEventNum", true));
            this.gEventNumTextBox.Location = new System.Drawing.Point(492, 173);
            this.gEventNumTextBox.Name = "gEventNumTextBox";
            this.gEventNumTextBox.ReadOnly = true;
            this.gEventNumTextBox.Size = new System.Drawing.Size(10, 21);
            this.gEventNumTextBox.TabIndex = 40;
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
            this.barButtonItem8,
            this.barButtonItem9});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem3, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem4, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem5, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem7, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem6, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Gruplamayı Aç";
            this.barButtonItem7.Id = 7;
            this.barButtonItem7.ImageIndex = 3;
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Gruplamayı Kapat";
            this.barButtonItem6.Id = 6;
            this.barButtonItem6.ImageIndex = 4;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1102, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 489);
            this.barDockControlBottom.Size = new System.Drawing.Size(1102, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 455);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1102, 34);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 455);
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
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "barButtonItem9";
            this.barButtonItem9.Id = 9;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // timerPb
            // 
            this.timerPb.Interval = 1000;
            this.timerPb.Tick += new System.EventHandler(this.timerPb_Tick);
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
            // gunlukGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 489);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.gEventNumTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "gunlukGiris";
            this.Text = "Günlük Giriş Raporu";
            this.Load += new System.EventHandler(this.gunlukGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ikgunlukListeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRaporlama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZaman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu24x24)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource ikgunlukListeBindingSource;
        private DSRaporlama dSRaporlama;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpNum;
        private DevExpress.XtraGrid.Columns.GridColumn colAdiSoyadi;
        private DevExpress.XtraGrid.Columns.GridColumn colil;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartman;
        private DevExpress.XtraGrid.Columns.GridColumn colgKapisi;
        private DevExpress.XtraGrid.Columns.GridColumn colgGC;
        private DevExpress.XtraGrid.Columns.GridColumn colgGCs;
        private DevExpress.XtraGrid.Columns.GridColumn colgAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colgTip;
        private DevExpress.XtraGrid.Columns.GridColumn colgDegTar;
        private DevExpress.XtraGrid.Columns.GridColumn colgDegYap;
        private DevExpress.XtraGrid.Columns.GridColumn colgEskiTar;
        private DevExpress.XtraGrid.Columns.GridColumn colgEventNum;
        private DSRaporlamaTableAdapters.ik_gunlukListeTableAdapter ik_gunlukListeTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.Utils.ImageCollection menu24x24;
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
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private System.Windows.Forms.DateTimePicker tarih;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colp;
        private DevExpress.XtraGrid.Columns.GridColumn colSaat;
        private System.Windows.Forms.SaveFileDialog raporKaydet;
        private System.Windows.Forms.CheckBox oto;
        private System.Windows.Forms.NumericUpDown txtZaman;
        private System.Windows.Forms.Timer timerPb;
        private DevExpress.XtraEditors.ProgressBarControl pb1;
        private DSRaporlamaTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colgTarihi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kayıtDüzenleToolStripMenuItem;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private System.Windows.Forms.TextBox gEventNumTextBox;
        private DevExpress.XtraGrid.Columns.GridColumn coliUserSlot;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;


    }
}