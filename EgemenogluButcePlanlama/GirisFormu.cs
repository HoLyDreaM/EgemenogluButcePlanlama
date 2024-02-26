using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace EgemenOgluRaporlama
{
    public partial class GirisFormu : DevExpress.XtraEditors.XtraForm
    {
        public GirisFormu()
        {
            InitializeComponent();
        }
        AnaForm frmAnafrm;
        Ayarlar.lookUpKullanici frmLookUpKullanici;
        Ayarlar.lookUpSirket frmLookUpSirket;
        Ayarlar.lookUpSqlServer frmLookUpSql;
        private string version;
        iniOku.iniOku iniOku = new iniOku.iniOku(Application.StartupPath+"\\LoginSettings.ini");
        public string srv1, vt1;
      
        #region "Sifrele_Şifreçöz"
        static public string Sifrele(string veri)
        {
            byte[] veriByteDizisi = System.Text.ASCIIEncoding.ASCII.GetBytes(veri);
            string sifrelenmisVeri = System.Convert.ToBase64String(veriByteDizisi);
            return sifrelenmisVeri;
        }
        static public string Coz(string cozVeri)
        {
            byte[] cozByteDizi = System.Convert.FromBase64String(cozVeri);
            string orjinalVeri = System.Text.ASCIIEncoding.ASCII.GetString(cozByteDizi);
            return orjinalVeri;
        }
        #endregion

        private void btnBaglan_Click(object sender, EventArgs e)
        {
            sqlConnection1.Close();
            sqlConnection1.ConnectionString = "Data Source=" + txtServer.Text + ";Initial Catalog=" + txtSirket.Text + ";Integrated Security=True";

            ConRapor.Close();
            ConRapor.ConnectionString = "Data Source=" + txtServer.Text + ";Initial Catalog=EgemenogluRaporlama;Integrated Security=True";        
            try
            {
                sqlConnection1.Open();

                if (ConRapor.State == ConnectionState.Closed)
                ConRapor.Open();
                
                Properties.Settings.Default["Cs"] = sqlConnection1.ConnectionString;
                Properties.Settings.Default["CsRaporlama"] = ConRapor.ConnectionString;

                Properties.Settings.Default["CsInsanKaynaklari"] = "Data Source=" + srv1 + ";Initial Catalog=EgemenogluGirisCikis;Integrated Security=SSPI;Connection Timeout=3600;Pooling=True;Asynchronous Processing=True";

                this.kullanicilarTableAdapter.GetUser(dSRaporlama.Kullanicilar,txtKullanici.Text,txtSifre.Text);
                if (dSRaporlama.Kullanicilar.Count > 0)
                {
                    iniOku.IniYaz("Ayar", "Server", txtServer.Text);
                    iniOku.IniYaz("Ayar", "Sirket", txtSirket.Text);
 
                    frmAnafrm = new AnaForm();
                    Program.ac.MainForm = frmAnafrm;
                    frmAnafrm.AdiSoyadi = dSRaporlama.Kullanicilar.Rows[0]["AdiSoyadi"].ToString();
                    //########################## Finans Raporu  İzinleri #################################
                    frmAnafrm.IFinans = (Boolean)dSRaporlama.Kullanicilar.Rows[0]["IMenuFinans"];
                    frmAnafrm.ILikidite = (Boolean)dSRaporlama.Kullanicilar.Rows[0]["ILikidite"];
                    frmAnafrm.IKasaHarket = (Boolean)dSRaporlama.Kullanicilar.Rows[0]["IKasaHareketleri"];
                    frmAnafrm.IBankaHareket = (Boolean)dSRaporlama.Kullanicilar.Rows[0]["IBankaHaraketleri"];
                    frmAnafrm.IPersonelAvans = (Boolean)dSRaporlama.Kullanicilar.Rows[0]["IPersonelAvanslari"];
                    frmAnafrm.IGiderler = (Boolean)dSRaporlama.Kullanicilar.Rows[0]["IGiderler"];
                    frmAnafrm.IMuvekkil = (Boolean)dSRaporlama.Kullanicilar.Rows[0]["IMuvekkil"];
                    frmAnafrm.IKullaniciAyari = (Boolean)dSRaporlama.Kullanicilar.Rows[0]["IKullanici"];
                    frmAnafrm.IBilanco = (Boolean)dSRaporlama.Kullanicilar.Rows[0]["IBilanco"];
                    frmAnafrm.IGelirTablosu = (Boolean)dSRaporlama.Kullanicilar.Rows[0]["IGelir"];
                    frmAnafrm.IMuvekkilAlacaklari = (Boolean)dSRaporlama.Kullanicilar.Rows[0]["IEmanetKasa"];
                    frmAnafrm.ImuvekkilMasraflari = (Boolean)dSRaporlama.Kullanicilar.Rows[0]["IKasalarArasi"];
                    frmAnafrm.ICekSenet = (Boolean)dSRaporlama.Kullanicilar.Rows[0]["ICekSenet"];
                    //########################## İnsan Kaynakları Raporu  İzinleri ######################
                    frmAnafrm.IInsanKaynaklari =(Boolean)dSRaporlama.Kullanicilar.Rows[0]["IMenuInsanKaynaklari"];  
                    frmAnafrm.IGiris = (Boolean)dSRaporlama.Kullanicilar.Rows[0]["IGiris"];
                    frmAnafrm.IGirisCikis = (Boolean)dSRaporlama.Kullanicilar.Rows[0]["IGirisCikis"];
                    frmAnafrm.IGirisCikisAylik = (Boolean)dSRaporlama.Kullanicilar.Rows[0]["IGirisCikisAylik"];
                    frmAnafrm.IGirisCikisHaftalik = (Boolean)dSRaporlama.Kullanicilar.Rows[0]["IGirisCikisHaftalik"];
                    frmAnafrm.IGirisCikisTarihAraligi = (Boolean)dSRaporlama.Kullanicilar.Rows[0]["IGirisCikisTarihAraligi"];
                    frmAnafrm.IGirisCikisDegisiklikler = (Boolean)dSRaporlama.Kullanicilar.Rows[0]["IGirisCikisDegisiklikler"];
                    frmAnafrm.IKayitDuzenleme = (Boolean)dSRaporlama.Kullanicilar.Rows[0]["IKayitDuzenleme"];
                    frmAnafrm.IFiltreYetkisi = (string)dSRaporlama.Kullanicilar.Rows[0]["IFiltreYetkisi"].ToString().Trim();
                    frmAnafrm.IilFiltreYetkisi = (string)dSRaporlama.Kullanicilar.Rows[0]["IIlFiltreYetkisi"].ToString().Trim();
                    frmAnafrm.IGiris_OtoYenileme = (Boolean)dSRaporlama.Kullanicilar.Rows[0]["IGiris_OtoYenile"];
                    frmAnafrm.IGirisCikis_OtoYenileme = (Boolean)dSRaporlama.Kullanicilar.Rows[0]["IGirisCikis_OtoYenile"];
                    frmAnafrm.IGuncelleme = (Boolean)dSRaporlama.Kullanicilar.Rows[0]["IGuncelleme"];
                    frmAnafrm.ISmerkeziFiltreYetkisi = (string)dSRaporlama.Kullanicilar.Rows[0]["ISmerkeziFiltreYetkisi"];
                    //########################## Prim Sistemi #######################################
                    frmAnafrm.IGrupVePrim = (Boolean)dSRaporlama.Kullanicilar.Rows[0]["IGrupVePrim"];
                    frmAnafrm.IGrupVePrim = (Boolean)dSRaporlama.Kullanicilar.Rows[0]["IGrupVePrim"];
                    frmAnafrm.IPersoneleGrupAtama = (Boolean)dSRaporlama.Kullanicilar.Rows[0]["IPersoneleGrupAtama"];
                    frmAnafrm.IDonemTanimlari = (Boolean)dSRaporlama.Kullanicilar.Rows[0]["IDonemTanimlari"];
                    frmAnafrm.ITahsilatSuresi = (Boolean)dSRaporlama.Kullanicilar.Rows[0]["ITahsilatSuresi"]; //#NOT:Tahsilat sürelerini cari kartların sektör kısmında tanımladığımız için bu menüye gerek kalmadı
                    frmAnafrm.IYeniMusteri = (Boolean)dSRaporlama.Kullanicilar.Rows[0]["IYeniMusteri"];
                    frmAnafrm.IPrimGirisi = (Boolean)dSRaporlama.Kullanicilar.Rows[0]["IPrimGirisi"];
                    frmAnafrm.IMusteriHareketleri = (Boolean)dSRaporlama.Kullanicilar.Rows[0]["IMusteriHareketleri"];
                    frmAnafrm.IPrimHesaplama = (Boolean)dSRaporlama.Kullanicilar.Rows[0]["IPrimHesaplama"];
                    frmAnafrm.IPrimRaporu = (Boolean)dSRaporlama.Kullanicilar.Rows[0]["IPrimRaporu"];
                    frmAnafrm.IPrimRapor1 = (Boolean)dSRaporlama.Kullanicilar.Rows[0]["IPrimRaporu1"];
                    frmAnafrm.ITahsilatSuresi1 =(Boolean)dSRaporlama.Kullanicilar.Rows[0]["ITahsilatSuresi1"];
                    frmAnafrm.YeniIs = (Boolean)dSRaporlama.Kullanicilar.Rows[0]["IYeniIs"];
                    frmAnafrm.IButceKontrolu = (Boolean)dSRaporlama.Kullanicilar.Rows[0]["IButce"];
                    frmAnafrm.IButceKontrolu1 = (Boolean)dSRaporlama.Kullanicilar.Rows[0]["IButce1"]; 

                    //###############################################################################
                    frmAnafrm.IAyarlar = (Boolean)dSRaporlama.Kullanicilar.Rows[0]["IMenuAyarlar"];
                    frmAnafrm.lblSirket.Text = txtSirket.Text;
                    frmAnafrm.Versiyon = version;
                    this.Close();
                    frmAnafrm.Show();
                }
                else
                {
                    lblDurum1.Text = "Hatalı Kullanıcı Girişi!";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                lblDurum1.Text = "Bağlantı Sağlanamadı!"; 
            }
            sqlConnection1.Close();
        }
      
        private void GirisFormu_Load(object sender, EventArgs e)
        {
            txtServer.Focus();
            
            try
            {
                txtServer.Text = iniOku.IniOku("Ayar", "Server");
                txtSirket.Text = iniOku.IniOku("Ayar", "Sirket");
                version = iniOku.IniOku("Ayar", "version");
                srv1 = iniOku.IniOku("Ayar", "server1");
                vt1 = iniOku.IniOku("Ayar", "vt1");
            }
            catch (Exception)
            {
                MessageBox.Show(".Ini Dosyası Okunamadı!");
            }
        }

        private void txtKullanici_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                Properties.Settings.Default["CsRaporlama"] = "Data Source=" + txtServer.Text + ";Initial Catalog=EgemenogluRaporlama;Integrated Security=True";
                frmLookUpKullanici = new Ayarlar.lookUpKullanici();
                frmLookUpKullanici.frmGiris = this;
                frmLookUpKullanici.ShowDialog(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void txtSirket_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                Properties.Settings.Default["v14"] = "Data Source=" + txtServer.Text + ";Initial Catalog=MikroDB_V14;Integrated Security=True";
                frmLookUpSirket = new Ayarlar.lookUpSirket();
                frmLookUpSirket.frmGiris = this;
                frmLookUpSirket.ShowDialog(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void txtServer_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmLookUpSql = new Ayarlar.lookUpSqlServer();
            frmLookUpSql.frmGiris = this;
            frmLookUpSql.ShowDialog(); 
        }

        private void txtServer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                txtSirket.Focus();
            }
        }

        private void txtSirket_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtKullanici.Focus();
            }
        }

        private void txtKullanici_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSifre.Focus();
            }
        }

        private void txtSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBaglan_Click(sender,e);
            }
        }

    }
}