namespace EgemenOgluRaporlama
{
    partial class GirisFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisFormu));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDurum1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDurum = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnBaglan = new DevExpress.XtraEditors.SimpleButton();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.lookUpKullaniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSRaporlama = new EgemenOgluRaporlama.DSRaporlama();
            this.kullanicilarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.kullanicilarTableAdapter = new EgemenOgluRaporlama.DSRaporlamaTableAdapters.KullanicilarTableAdapter();
            this.ConRapor = new System.Data.SqlClient.SqlConnection();
            this.lookUpKullaniciTableAdapter = new EgemenOgluRaporlama.DSRaporlamaTableAdapters.LookUpKullaniciTableAdapter();
            this.txtSirket = new DevExpress.XtraEditors.ButtonEdit();
            this.txtKullanici = new DevExpress.XtraEditors.ButtonEdit();
            this.txtServer = new DevExpress.XtraEditors.ButtonEdit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpKullaniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRaporlama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSirket.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanici.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Black";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl1.Location = new System.Drawing.Point(26, 113);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 20);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Server Adı";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl2.Location = new System.Drawing.Point(26, 137);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 20);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Şirket Adı";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDurum1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 284);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(276, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblDurum1
            // 
            this.lblDurum1.Name = "lblDurum1";
            this.lblDurum1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(28, 17);
            this.toolStripStatusLabel1.Text = "       ";
            // 
            // lblDurum
            // 
            this.lblDurum.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.lblDurum.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.lblDurum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Strikeout);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(4, 17);
            // 
            // btnBaglan
            // 
            this.btnBaglan.Location = new System.Drawing.Point(108, 211);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(141, 23);
            this.btnBaglan.TabIndex = 4;
            this.btnBaglan.Text = "Bağlan";
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl3.Location = new System.Drawing.Point(26, 161);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(82, 20);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Kullanıcı";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl4.Location = new System.Drawing.Point(26, 185);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(82, 20);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "Şifre";
            // 
            // txtSifre
            // 
            this.txtSifre.EditValue = "";
            this.txtSifre.Location = new System.Drawing.Point(108, 185);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Properties.PasswordChar = '#';
            this.txtSifre.Size = new System.Drawing.Size(142, 20);
            this.txtSifre.TabIndex = 3;
            this.txtSifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSifre_KeyDown);
            // 
            // lookUpKullaniciBindingSource
            // 
            this.lookUpKullaniciBindingSource.DataMember = "LookUpKullanici";
            this.lookUpKullaniciBindingSource.DataSource = this.dSRaporlama;
            // 
            // dSRaporlama
            // 
            this.dSRaporlama.DataSetName = "DSRaporlama";
            this.dSRaporlama.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullanicilarBindingSource
            // 
            this.kullanicilarBindingSource.DataMember = "Kullanicilar";
            this.kullanicilarBindingSource.DataSource = this.dSRaporlama;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::EgemenOgluRaporlama.Properties.Resources.yeni_logo1;
            this.pictureEdit1.Location = new System.Drawing.Point(26, 9);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(224, 90);
            this.pictureEdit1.TabIndex = 0;
            // 
            // kullanicilarTableAdapter
            // 
            this.kullanicilarTableAdapter.ClearBeforeFill = true;
            // 
            // ConRapor
            // 
            this.ConRapor.FireInfoMessageEventOnUserErrors = false;
            // 
            // lookUpKullaniciTableAdapter
            // 
            this.lookUpKullaniciTableAdapter.ClearBeforeFill = true;
            // 
            // txtSirket
            // 
            this.txtSirket.Location = new System.Drawing.Point(108, 137);
            this.txtSirket.Name = "txtSirket";
            this.txtSirket.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtSirket.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtSirket_Properties_ButtonClick);
            this.txtSirket.Size = new System.Drawing.Size(141, 20);
            this.txtSirket.TabIndex = 1;
            this.txtSirket.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSirket_KeyDown);
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(108, 161);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtKullanici.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtKullanici_Properties_ButtonClick);
            this.txtKullanici.Size = new System.Drawing.Size(142, 20);
            this.txtKullanici.TabIndex = 2;
            this.txtKullanici.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKullanici_KeyDown);
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(108, 113);
            this.txtServer.Name = "txtServer";
            this.txtServer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtServer.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtServer_Properties_ButtonClick);
            this.txtServer.Size = new System.Drawing.Size(141, 20);
            this.txtServer.TabIndex = 0;
            this.txtServer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtServer_KeyDown);
            // 
            // GirisFormu
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Red;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 306);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.txtSirket);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnBaglan);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Blue";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GirisFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris Formu";
            this.Load += new System.EventHandler(this.GirisFormu_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpKullaniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRaporlama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSirket.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanici.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblDurum;
        private DevExpress.XtraEditors.SimpleButton btnBaglan;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        public DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private DSRaporlama dSRaporlama;
        private System.Windows.Forms.BindingSource kullanicilarBindingSource;
        private DSRaporlamaTableAdapters.KullanicilarTableAdapter kullanicilarTableAdapter;
        private System.Data.SqlClient.SqlConnection ConRapor;
        private System.Windows.Forms.BindingSource lookUpKullaniciBindingSource;
        private DSRaporlamaTableAdapters.LookUpKullaniciTableAdapter lookUpKullaniciTableAdapter;
        private System.Windows.Forms.ToolStripStatusLabel lblDurum1;
        public DevExpress.XtraEditors.ButtonEdit txtSirket;
        public DevExpress.XtraEditors.ButtonEdit txtKullanici;
        public DevExpress.XtraEditors.ButtonEdit txtServer;



    }
}