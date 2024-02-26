using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;
using System.Diagnostics;

namespace EgemenOgluRaporlama
{
    public partial class AnaForm : DevExpress.XtraEditors.XtraForm
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        iniOku.iniOku iniOku = new iniOku.iniOku(Application.StartupPath+@"\LoginSettings.ini");
        iniOku.iniOku uzakIni;

        private Thread tRemoteVersiyonCek;
        private Thread tRemoteClietVersiyon;

        #region Form Tanımları ; Finans ve Ayarlar
        
        LikiditeFormu frmkLikidite;
        KasaHarekleriFormu frmKasaHareketleri;
        BankaHareketleriFormu frmBankaHareket;
        GiderlerFormu frmGiderler;
        MuvekkilUcretleriFormu frmMuvekkil;
        PersonelAvanslariFormu frmPersonelAvans;
        Ayarlar.KullaniciTanimlariFormu frmKullanicilar;
        Ayarlar.guncelleme frmGuncelleme;
        Ayarlar.GrupTanimlari frmGrupTanimlari;
        Ayarlar.PersoneleGrupAtama frmPersoneleGrupAtama;
        Ayarlar.DonemTanimlari frmDonemTanimlari;
        Ayarlar.prim_PrimMusterilerIcinAySayilari frmMusterilerIcinAySayilari;
        Ayarlar.TahsilatSureleri frmTahsilatSureleri;
        CekSenet frmCeksenet;
        Kurlar frmKur;
        GelirTablosu frmGelir;
        bg frmBg;
        Bilanco frmBilanco;
        muvekkilAlacaklari frmMuvekkilAlacaklari;
        muvekkilMasraflari frmMuvekkilMasraflari;
        
        private void frmGuncelleAC()
        {
            if (frmGuncelleme == null || frmGuncelleme.IsDisposed)
            {
                frmGuncelleme = new Ayarlar.guncelleme();
                frmGuncelleme.Owner = this;
                frmGuncelleme.MdiParent = this;
                //frmGuncelleme.anafrm = this;
                frmGuncelleme.Show();
            }
            else
            {
                frmGuncelleme.Activate();
            }
        }
        private void likiditeAc() {
            if (frmkLikidite == null || frmkLikidite.IsDisposed)
            {
                frmkLikidite = new LikiditeFormu();
                frmkLikidite.Owner = this;
                frmkLikidite.MdiParent = this;
                frmkLikidite.anafrm = this;
                frmkLikidite.Show();
            }
            else {
                frmkLikidite.Activate();
            }
        }
        private void kasaHarekleriAc()
        {
            if (frmKasaHareketleri == null || frmKasaHareketleri.IsDisposed)
            {
                frmKasaHareketleri = new KasaHarekleriFormu();
                frmKasaHareketleri.Owner = this;
                frmKasaHareketleri.MdiParent = this;
                frmKasaHareketleri.anafrm = this;
                frmKasaHareketleri.Show();
            }
            else
            {
                frmKasaHareketleri.Activate();
            }
        }
        private void bankaHareketleriAC()
        {
            if (frmBankaHareket == null || frmBankaHareket.IsDisposed)
            {
                frmBankaHareket = new BankaHareketleriFormu();
                frmBankaHareket.Owner = this;
                frmBankaHareket.anafrm = this;
                frmBankaHareket.MdiParent = this;
                frmBankaHareket.Show();
            }
            else
            {
                frmBankaHareket.Activate();
            }
        }
        private void perSoneleAvansAc()
        {
            if (frmPersonelAvans == null || frmPersonelAvans.IsDisposed)
            {
                frmPersonelAvans = new PersonelAvanslariFormu();
                frmPersonelAvans.Owner = this;
                frmPersonelAvans.MdiParent = this;
                frmPersonelAvans.anafrm = this;
                frmPersonelAvans.Show();
            }
            else
            {
                frmPersonelAvans.Activate();
            }
        }
        private void muvekkilAc()
        {
            if (frmMuvekkil == null || frmMuvekkil.IsDisposed)
            {
                frmMuvekkil = new MuvekkilUcretleriFormu();
                frmMuvekkil.Owner = this;
                frmMuvekkil.MdiParent = this;
                frmMuvekkil.anafrm = this;
                frmMuvekkil.Show();
            }
            else
            {
                frmMuvekkil.Activate();
            }
        }
        private void giderleriAc()
        {
            if (frmGiderler == null || frmGiderler.IsDisposed)
            {
                frmGiderler = new GiderlerFormu();
                frmGiderler.Owner = this;
                frmGiderler.MdiParent = this;
                frmGiderler.anafrm = this;
                frmGiderler.Show();
            }
            else
            {
                frmGiderler.Activate();
            }
        }
        private void kullanicilariAc() {
            if (frmKullanicilar == null || frmKullanicilar.IsDisposed)
            {
                frmKullanicilar = new Ayarlar.KullaniciTanimlariFormu();
                frmKullanicilar.Owner = this;
                frmKullanicilar.MdiParent = this;
                frmKullanicilar.Show();
            }
            else
            {
                frmKullanicilar.Activate();
            }
        }
        private void cekSenetAc() {
            if (frmCeksenet == null || frmCeksenet.IsDisposed)
            {
                frmCeksenet = new CekSenet();
                frmCeksenet.Owner = this;
                frmCeksenet.anaFrm = this;
                frmCeksenet.MdiParent = this;
                frmCeksenet.Show();
            }
            else
            {
                frmCeksenet.Activate();
            }
        }
        private void kurlarAc()
        {
            if (frmKur == null || frmKur.IsDisposed)
            {
                frmKur = new Kurlar();
                frmKur.Owner = this;
                frmKur.MdiParent = this;
                //frmKur.anafrm = this;
                frmKur.Show();
            }
            else
            {
                frmKur.Activate();
            }
        }
        private void gelirAc()
        {
            if (frmGelir == null || frmGelir.IsDisposed)
            {
                frmGelir = new GelirTablosu();
                frmGelir.Owner = this;
                frmGelir.MdiParent = this;
                //frmGelir.anafrm = this;
                frmGelir.Show();
            }
            else
            {
                frmGelir.Activate();
            }
        }
        private void bilancoAc()
        {
            if (frmBilanco == null || frmBilanco.IsDisposed)
            {
                frmBilanco = new Bilanco();
                frmBilanco.Owner = this;
                frmBilanco.MdiParent = this;
                //frmGelir.anafrm = this;
                frmBilanco.Show();
            }
            else
            {
                frmBilanco.Activate();
            }
        }
        private void bgAc() {
            if (frmBg == null || frmBg.IsDisposed)
            {
                frmBg = new bg();
                frmBg.Owner = this;
                frmBg.MdiParent = this;
                //frmGelir.anafrm = this;
                frmBg.Show();
            }
            else
            {
                frmBg.Activate();
            }
        }
        private void frmMuvekkilAlacaklariAc()
        {
            if (frmMuvekkilAlacaklari == null || frmMuvekkilAlacaklari.IsDisposed)
            {
                frmMuvekkilAlacaklari = new muvekkilAlacaklari();
                frmMuvekkilAlacaklari.Owner = this;
                frmMuvekkilAlacaklari.MdiParent = this;
                frmMuvekkilAlacaklari.anaFrm = this;
                frmMuvekkilAlacaklari.Show();
            }
            else
            {
                frmMuvekkilAlacaklari.Activate();
            }
        }
        private void muvekkilMasraflariAc()
        {
            if (frmMuvekkilMasraflari == null || frmMuvekkilMasraflari.IsDisposed)
            {
                frmMuvekkilMasraflari = new muvekkilMasraflari();
                frmMuvekkilMasraflari.Owner = this;
                frmMuvekkilMasraflari.MdiParent = this;
                frmMuvekkilMasraflari.anafrm = this;
                frmMuvekkilMasraflari.Show();
            }
            else
            {
                frmMuvekkilMasraflari.Activate();
            }
        }
        private void grupTanimlariAc()
        {
            if (frmGrupTanimlari == null || frmGrupTanimlari.IsDisposed)
            {
                frmGrupTanimlari = new Ayarlar.GrupTanimlari();
                frmGrupTanimlari.Owner = this;
                frmGrupTanimlari.MdiParent = this;
                //frmGrupTanimlari.anafrm = this;
                frmGrupTanimlari.Show();
            }
            else
            {
                frmGrupTanimlari.Activate();
            }
        }
        private void personeleGrupAtamaAc()
        {
            if (frmPersoneleGrupAtama == null || frmPersoneleGrupAtama.IsDisposed)
            {
                frmPersoneleGrupAtama = new Ayarlar.PersoneleGrupAtama();
                frmPersoneleGrupAtama.Owner = this;
                frmPersoneleGrupAtama.MdiParent = this;
                frmPersoneleGrupAtama.Show();
            }
            else
            {
                frmPersoneleGrupAtama.Activate();
            }
        }
        private void donemTanimlariAc() {
            if (frmDonemTanimlari == null || frmDonemTanimlari.IsDisposed)
            {
                frmDonemTanimlari = new Ayarlar.DonemTanimlari();
                frmDonemTanimlari.Owner = this;
                frmDonemTanimlari.MdiParent = this;
                frmDonemTanimlari.Show();
            }
            else
            {
                frmDonemTanimlari.Activate();
            }
        }
        private void musterilerIcinAySayilariAc()
        {
            if (frmMusterilerIcinAySayilari == null || frmMusterilerIcinAySayilari.IsDisposed)
            {
                frmMusterilerIcinAySayilari = new Ayarlar.prim_PrimMusterilerIcinAySayilari();
                frmMusterilerIcinAySayilari.Owner = this;
                frmMusterilerIcinAySayilari.MdiParent = this;
                frmMusterilerIcinAySayilari.Show();
            }
            else
            {
                frmMusterilerIcinAySayilari.Activate();
            }
        }
        private void tahsilatSureleriAc()
        {
            if (frmTahsilatSureleri == null || frmTahsilatSureleri.IsDisposed)
            {
                frmTahsilatSureleri = new Ayarlar.TahsilatSureleri();
                frmTahsilatSureleri.Owner = this;
                frmTahsilatSureleri.MdiParent = this;
                frmTahsilatSureleri.Show();
            }
            else
            {
                frmTahsilatSureleri.Activate();
            }
        }

        #endregion

        #region Bütçe Tanımları ve Izinleri

        Butce.ButceModulu frmButceModulu;
        Butce.ButceAnalizi frmButceAnaliz;

        
        Boolean _Butce1;
        Boolean _Butce;

        public Boolean IButceKontrolu
        {
            get { return _Butce; }
            set
            {
                _Butce = value;
                ribbonButce.Visible = _Butce;
            }

        }

        public Boolean IButceKontrolu1
        {
            get { return _Butce1; }
            set
            {
                _Butce1 = value;
                ribonButceTanimlama.Visible = _Butce1;
            }

        }

        private void frmButceAc()
        {
            if (frmButceModulu == null || frmButceModulu.IsDisposed)
            {
                frmButceModulu = new Butce.ButceModulu();
                frmButceModulu.Owner = this;
                frmButceModulu.MdiParent = this;
                frmButceModulu.anafrm = this;
                frmButceModulu.Show();
            }
            else
            {
                frmButceModulu.Activate();
            }
        }

        private void frmButceAnaliziAc()
        {
            if (frmButceAnaliz == null || frmButceAnaliz.IsDisposed)
            {
                frmButceAnaliz = new Butce.ButceAnalizi();
                frmButceAnaliz.Owner = this;
                frmButceAnaliz.MdiParent = this;
                frmButceAnaliz.anafrm = this;
                frmButceAnaliz.Show();
            }
            else
            {
                frmButceAnaliz.Activate();
            }
        }

        #endregion

        #region İzin Tanımları ; Finans ve Ayarlar
        string _AdiSoyadi;
        string _KullaniciAdi;
        Boolean _ILikidite;
        Boolean _IKasaHarket;
        Boolean _IBankaHareket;
        Boolean _IPersonelAvans;
        Boolean _IMuvekkil;
        Boolean _IGiderler;
        Boolean _IKullaniciAyari;
        Boolean _IGelirTablosu;
        Boolean _IBilanco;
        Boolean _IMuvekkilAlacaklari;
        Boolean _ImuvekkilMasraflari;
        Boolean _ICekSenet;
        Boolean _IFinans;   
        Boolean _IAyarlar;

        public Boolean IAyarlar
        {
            get { return _IAyarlar; }
            set { _IAyarlar = value;
            ribonPageAyarlar.Visible = _IAyarlar;
            }
        }   
        public Boolean IFinans
        {
            get { return _IFinans; }
            set { _IFinans = value;
            ribonPageFinans.Visible = _IFinans;
            }
        }
        public Boolean ICekSenet
        {
            get { return _ICekSenet; }
            set { _ICekSenet = value;
            ribonCeksenet.Visible = _ICekSenet;
            }
        }
        public Boolean ImuvekkilMasraflari
        {
            get { return _ImuvekkilMasraflari; }
            set
            {
                _ImuvekkilMasraflari = value;
                ribonKasalarArasi.Visible = _ImuvekkilMasraflari;
            }
        }
        public Boolean IMuvekkilAlacaklari
        {
            get { return _IMuvekkilAlacaklari; }
            set { _IMuvekkilAlacaklari = value;
            ribonEmanetKasa.Visible =_IMuvekkilAlacaklari;
            }
        }
        public Boolean IBilanco
        {
            get { return _IBilanco; }
            set { _IBilanco = value;
            ribonBilanco.Visible= _IBilanco;
            }
        }
        public Boolean IGelirTablosu
        {
            get { return _IGelirTablosu; }
            set { _IGelirTablosu = value;
            ribonGelirTablosu.Visible = _IGelirTablosu;
            }
        }
        public Boolean IKullaniciAyari
        {
            get { return _IKullaniciAyari; }
            set { _IKullaniciAyari = value;
            ribonKullanici.Visible= _IKullaniciAyari;
            }
        }

        public string KullaniciAdi
        {
            get { return _KullaniciAdi; }
            set { _KullaniciAdi = value; }
        }
        public string AdiSoyadi
        {
            get { return _AdiSoyadi; }
            set { _AdiSoyadi = value;
            lblKullaniciAdi.Text = _AdiSoyadi;
            }
        }
        public Boolean IGiderler
        {
            get { return _IGiderler;}
            set { _IGiderler = value;
            ribonGider.Visible = _IGiderler;
            }
        }
        public Boolean IMuvekkil
        {
            get { return _IMuvekkil; }
            set { _IMuvekkil = value;
            ribonMuvekkil.Visible = _IMuvekkil;
            }
        }
        public Boolean IPersonelAvans
        {
            get { return _IPersonelAvans; }
            set
            {
                _IPersonelAvans = value;
               ribonPersonel.Visible=_IPersonelAvans; 
            }
        }
        public Boolean IBankaHareket
        {
            get { return _IBankaHareket; }
            set { _IBankaHareket = value;
            ribonBanka.Visible= _IBankaHareket;
            }
        }
        public Boolean IKasaHarket
        {
            get { return _IKasaHarket; }
            set { _IKasaHarket = value;
            ribonKasa.Visible = _IKasaHarket;
            }
        }
        public Boolean ILikidite
        {
            get { return _ILikidite; }
            set { _ILikidite = value;
             ribonLikidite.Visible = _ILikidite;
            }
        }

        //public

        #endregion

        #region Form Tanımları ; İnsan Kaynakları
        InsanKaynaklari.gunlukGiris frmGunlukGiris;
        InsanKaynaklari.gunlukGirisCikis frmGunlukGirisCikis;
        InsanKaynaklari.tariheGore frmTariheGore;
        InsanKaynaklari.degisiklikYapilanlar frmDegisiklikYapilanlar;
        InsanKaynaklari.haftalikGirisCikis frmHaftalikGirisCikis;
        InsanKaynaklari.aylikGirisCikis frmAylikGirisCikis;
    
        private void gunlukGirisAc() {
            if (frmGunlukGiris == null || frmGunlukGiris.IsDisposed)
            {
                frmGunlukGiris = new InsanKaynaklari.gunlukGiris();
                frmGunlukGiris.anaFrm = this;
                frmGunlukGiris._IKayitDuzenleme = _IKayitDuzenleme;
                frmGunlukGiris.IGiris_OtoYenileme = _IGiris_OtoYenileme;
                frmGunlukGiris.Owner = this;
                frmGunlukGiris.MdiParent = this;
                frmGunlukGiris.Show();
            }
            else {
                frmGunlukGiris.Activate();
            }
        }
        private void gunlukGirisCikisAc() {
            if (frmGunlukGirisCikis == null || frmGunlukGirisCikis.IsDisposed)
            {
                frmGunlukGirisCikis = new InsanKaynaklari.gunlukGirisCikis();
                frmGunlukGirisCikis.anaFrm = this;
                frmGunlukGirisCikis.Owner = this;
                frmGunlukGirisCikis._IKayitDuzenleme = _IKayitDuzenleme;
                frmGunlukGirisCikis._IDepartmanlar = _IFiltreYetkisi;
                frmGunlukGirisCikis.IGirisCikis_OtoYenileme = _IGirisCikis_OtoYenileme;
                frmGunlukGirisCikis.MdiParent = this;
                frmGunlukGirisCikis.Show();
            }
            else
            {
                frmGunlukGirisCikis.Activate();
            }
        }
        private void tariheGoreAc()
        {
            if (frmTariheGore == null || frmTariheGore.IsDisposed)
            {
                frmTariheGore = new InsanKaynaklari.tariheGore();
                frmTariheGore.anaFrm = this;
                frmTariheGore.Owner = this;
                frmTariheGore._IDepartmanlar = _IFiltreYetkisi;
                frmTariheGore.MdiParent = this;
                frmTariheGore.Show();
            }
            else
            {
                frmTariheGore.Activate();
            }
        }
        private void degisiklikYapilanlarAc() {
            if (frmDegisiklikYapilanlar == null || frmDegisiklikYapilanlar.IsDisposed)
            {
                frmDegisiklikYapilanlar = new InsanKaynaklari.degisiklikYapilanlar();
                frmDegisiklikYapilanlar.Owner = this;
                frmDegisiklikYapilanlar.MdiParent = this;
                frmDegisiklikYapilanlar.Show();
            }
            else
            {
                frmDegisiklikYapilanlar.Activate();
            }
        }
        private void haftalikGirisCikis()
        {
            if (frmHaftalikGirisCikis == null || frmHaftalikGirisCikis.IsDisposed)
            {
                frmHaftalikGirisCikis = new InsanKaynaklari.haftalikGirisCikis();
                frmHaftalikGirisCikis.anaFrm = this;
                frmHaftalikGirisCikis.Owner = this;
                frmHaftalikGirisCikis.MdiParent = this;
                frmHaftalikGirisCikis.Show();
            }
            else
            {
                frmHaftalikGirisCikis.Activate();
            }
        }
        private void aylikGirisCikis()
        {
            if (frmAylikGirisCikis == null || frmAylikGirisCikis.IsDisposed)
            {
                frmAylikGirisCikis = new InsanKaynaklari.aylikGirisCikis();
                frmAylikGirisCikis.anaFrm = this;
                frmAylikGirisCikis.Owner = this;
                frmAylikGirisCikis.MdiParent = this;
                frmAylikGirisCikis.Show();
            }
            else
            {
                frmAylikGirisCikis.Activate();
            }
        }
        #endregion
        #region İzin Tanımları ; İnsan Kaynakları
        Boolean _IInsanKaynaklari;
        Boolean _IKayitDuzenleme;
        Boolean _IGiris;
        Boolean _IGiris_OtoYenileme;
        Boolean _IGirisCikis;
        Boolean _IGirisCikis_OtoYenileme;
        Boolean _IGirisCikisTarihAraligi;
        Boolean _IGirisCikisHaftalik;
        Boolean _IGirisCikisAylik;
        Boolean _IGirisCikisDegisiklikler;
        string _IFiltreYetkisi;
        string _IilFiltreYetkisi;
        string _ISmerkeziFiltreYetkisi;
        Boolean _IGuncelleme;
        Boolean _YeniIs;

        public Boolean YeniIs
        {
            get { return _YeniIs; }
            set { _YeniIs = value; ribbonYeniIs.Visible = YeniIs;}
        }
        public Boolean IGuncelleme
        {
            get { return _IGuncelleme; }
            set { _IGuncelleme = value;
            ribbonGuncelleme.Visible = _IGuncelleme;
            }
        }
        public Boolean IGirisCikis_OtoYenileme
        {
            get { return _IGirisCikis_OtoYenileme; }
            set { _IGirisCikis_OtoYenileme = value; }
        }
        public Boolean IGiris_OtoYenileme
        {
            get { return _IGiris_OtoYenileme; }
            set { _IGiris_OtoYenileme = value; }
        }
        public string IilFiltreYetkisi
        {
            get { return _IilFiltreYetkisi; }
            set { _IilFiltreYetkisi = value; }
        }
        public string  IFiltreYetkisi
        {
            get { return _IFiltreYetkisi; }
            set { _IFiltreYetkisi = value; }
        }
        public string ISmerkeziFiltreYetkisi
        {
            get { return _ISmerkeziFiltreYetkisi; }
            set { _ISmerkeziFiltreYetkisi = value; }
        }
        public Boolean IGirisCikisDegisiklikler
        {
            get { return _IGirisCikisDegisiklikler; }
            set { _IGirisCikisDegisiklikler = value;
            ribbonPagebtnDegisiklik.Visible = _IGirisCikisDegisiklikler;
            }
        }
        public Boolean IGirisCikisAylik
        {
            get { return _IGirisCikisAylik; }
            set { _IGirisCikisAylik = value;
            ribbonPagebtnAylik.Visible = _IGirisCikisAylik;
            }
        }
        public Boolean IGirisCikisHaftalik
        {
            get { return _IGirisCikisHaftalik; }
            set { _IGirisCikisHaftalik = value;
            ribbonPagebtnHaftalik.Visible = _IGirisCikisHaftalik;
            }
        }
        public Boolean IGirisCikisTarihAraligi
        {
            get { return _IGirisCikisTarihAraligi; }
            set { _IGirisCikisTarihAraligi = value;
            ribbonPagebtnTariheGore.Visible = _IGirisCikisTarihAraligi;
            }
        }
        public Boolean IGiris
        {
            get { return _IGiris; }
            set { _IGiris = value;
            ribbonPagebtnGunlukGirisler.Visible = _IGiris;
            }
        }
        public Boolean IGirisCikis
        {
            get { return _IGirisCikis; }
            set { _IGirisCikis = value;
            ribbonPagebtnGunlukGirisCikis.Visible = _IGirisCikis;
            }
        }
        public Boolean IKayitDuzenleme
        {
            get { return _IKayitDuzenleme; }
            set { _IKayitDuzenleme = value;
            }
        }
        public Boolean IInsanKaynaklari
        {
            get { return _IInsanKaynaklari; }
            set
            {
                _IInsanKaynaklari = value;
                rpInsanKaynaklari.Visible = _IInsanKaynaklari;
            }
        }

        #endregion

        #region Form Tanımları ; Prim Sistemi
        PrimSistemi.PiramitHareketleri frmPiramitHareketleri;
        PrimSistemi.YeniMusteri frmYebiMusteri;
        PrimSistemi.PrimHesapla frmPrimHesapla;
        PrimSistemi.PrimGiris frmPrimGiris;
        PrimSistemi.Rapor frmPrimRaporu;
        PrimSistemi.Rapor1 frmPrimRaporu1;
        PrimSistemi.IsHareketleri frmIsHareketleri;

        private void frmPiramitHareketleriAc()
        {
            if (frmPiramitHareketleri == null || frmPiramitHareketleri.IsDisposed)
            {
                frmPiramitHareketleri = new PrimSistemi.PiramitHareketleri();
                frmPiramitHareketleri.Owner = this;
                frmPiramitHareketleri.MdiParent = this;
                frmPiramitHareketleri.Show();
            }
            else
            {
                frmPiramitHareketleri.Activate();
            }
        }
        private void frmYeniMusteriAc()
        {
            if (frmYebiMusteri == null || frmYebiMusteri.IsDisposed)
            {
                frmYebiMusteri = new PrimSistemi.YeniMusteri();
                frmYebiMusteri.Owner = this;
                frmYebiMusteri.MdiParent = this;
                frmYebiMusteri.Show();
            }
            else
            {
                frmYebiMusteri.Activate();
            }
        }
        private void frmPrimHesaplaAc() {
            if (frmPrimHesapla == null || frmPrimHesapla.IsDisposed)
            {
                frmPrimHesapla = new PrimSistemi.PrimHesapla();
                frmPrimHesapla.Owner = this;
                frmPrimHesapla.MdiParent = this;
                frmPrimHesapla.Show();
            }
            else
            {
                frmPrimHesapla.Activate();
            }
        }
        private void frmPrimGirisAc()
        {
            if (frmPrimGiris == null || frmPrimGiris.IsDisposed)
            {
                frmPrimGiris = new PrimSistemi.PrimGiris();
                frmPrimGiris.Owner = this;
                frmPrimGiris.MdiParent = this;
                frmPrimGiris.Show();
            }
            else
            {
                frmPrimGiris.Activate();
            }
        }
        private void frmPrimRaporuAc()
        {
            if (frmPrimRaporu == null || frmPrimRaporu.IsDisposed)
            {
                frmPrimRaporu = new PrimSistemi.Rapor();
                frmPrimRaporu.Owner = this;
                frmPrimRaporu.MdiParent = this;
                frmPrimRaporu.Show();
            }
            else
            {
                frmPrimRaporu.Activate();
            }
        }
        private void frmPrimRaporu1Ac()
        {
            if (frmPrimRaporu1 == null || frmPrimRaporu1.IsDisposed)
            {
                frmPrimRaporu1 = new PrimSistemi.Rapor1();
                frmPrimRaporu1.Owner = this;
                frmPrimRaporu1.MdiParent = this;
                frmPrimRaporu1.Show();
            }
            else
            {
                frmPrimRaporu1.Activate();
            }
        }
        private void frmIsHareketleriAc() { 
            if (frmIsHareketleri == null || frmIsHareketleri.IsDisposed)
            {
                frmIsHareketleri = new PrimSistemi.IsHareketleri();
                frmIsHareketleri.Owner = this;
                frmIsHareketleri.MdiParent = this;
                frmIsHareketleri.Show();
            }
            else
            {
                frmIsHareketleri.Activate();
            }
        }
        #endregion
        #region İzin Tanımları ; Prim Sistemi
        Boolean _IMenuPrim;
        Boolean _IGrupVePrim;
        Boolean _IPersoneleGrupAtama;
        Boolean _IDonemTanimlari;
        Boolean _ITahsilatSuresi;
        Boolean _IYeniMusteri;
        Boolean _IPrimGirisi;
        Boolean _IMusteriHareketleri;
        Boolean _IPrimHesaplama;
        Boolean _IPrimRaporu;
        Boolean _IPrimRapor1;
        Boolean _ITahsilatSuresi1;

        public Boolean IGrupVePrim
        {
            get { return _IGrupVePrim; }
            set { _IGrupVePrim = value; ribbonGrupVePrimTanimlari.Visible = _IGrupVePrim; }
        }    
        public Boolean IPersoneleGrupAtama
        {
            get { return _IPersoneleGrupAtama; }
            set { _IPersoneleGrupAtama = value; ribbonPerGrupAtama.Visible = _IPersoneleGrupAtama;}
        }
        public Boolean IDonemTanimlari
        {
            get { return _IDonemTanimlari; }
            set { _IDonemTanimlari = value; ribbonDonemTanimlari.Visible = _IDonemTanimlari;}
        }
        public Boolean ITahsilatSuresi
        {
            get { return _ITahsilatSuresi; }
            set { _ITahsilatSuresi = value; ribbonTahsilatSuresi.Visible = _ITahsilatSuresi;}
        }
        public Boolean IYeniMusteri
        {
            get { return _IYeniMusteri; }
            set { _IYeniMusteri = value; ribbonYeniMusteri.Visible = _IYeniMusteri;}
        }
        public Boolean IPrimGirisi
        {
            get { return _IPrimGirisi; }
            set { _IPrimGirisi = value; ribbonPrimGirisi.Visible = IPrimGirisi;}
        }
        public Boolean IMusteriHareketleri
        {
            get { return _IMusteriHareketleri; }
            set { _IMusteriHareketleri = value; ribbonMusteriHareketleri.Visible = _IMusteriHareketleri; }
        }
        public Boolean IPrimHesaplama
        {
            get { return _IPrimHesaplama; }
            set { _IPrimHesaplama = value; ribbonPrimHesaplama.Visible = _IPrimHesaplama; }
        }
        public Boolean IPrimRaporu
        {
            get { return _IPrimRaporu; }
            set { _IPrimRaporu = value; ribbonPrimRaporu.Visible = _IPrimRaporu; }
        }
        public Boolean IMenuPrim
        {
            get { return _IMenuPrim; }
            set { _IMenuPrim = value; ribbonPagePrimSistemi.Visible = IMenuPrim; }
        }
        public Boolean IPrimRapor1
        {
            get { return _IPrimRapor1; }
            set { _IPrimRapor1 = value; ribbonPagePrimRaporu1.Visible = _IPrimRapor1; }
        }
        public Boolean ITahsilatSuresi1
        {
            get { return _ITahsilatSuresi1; }
            set { _ITahsilatSuresi1 = value; ribbonTahsilatSuresi1.Visible = _ITahsilatSuresi1; }
        }
        
        #endregion
      
        private double _euro;
        public double euro
        {
            get { return _euro; }
            set { _euro = value; }
        }
        public double dolar
        {
            get { return _dolar; }
            set { _dolar = value; }
        }

        private double _dolar;

        private void ps_IlleriDoldur(){
            //lbIller.Items.Add("01", "ISTANBUL");//01 
            //lbIller.Items.Add("02", "BURSA");//02
            //lbIller.Items.Add("03", "IZMIR");//03
            //lbIller.Items.Add("04", "ADANA");//04
            //lbIller.Items.Add("05", "ANKARA");//05
            if (!string.IsNullOrEmpty(_IilFiltreYetkisi))
            {
                string[] ilParcala = _IilFiltreYetkisi.Split(',');
                string[] ilAdiveKodu = null;
                string ilAdi = null;
                string ilKodu = null;
                foreach (var item in ilParcala)
                {
                    ilAdiveKodu = item.Split(':');
                    ilAdi = ilAdiveKodu[0].TrimStart().TrimEnd();
                    ilKodu = ilAdiveKodu[1].TrimStart().TrimEnd();
                    _ilFiltre += "'" + ilAdiveKodu[0] + "',";
                    lbIller.Items.Add(ilKodu, ilAdi);
                }
                _ilFiltre = _ilFiltre.Substring(0, _ilFiltre.Length - 1);// insan kaynakları tarihe göre aramada filtre için kullanılcak
            }
            lbIller.CheckAll();
            }
        private void ps_DepartmanlariDoldur() {
            if (!string.IsNullOrEmpty(_IilFiltreYetkisi))
            {
                string[] departmanlar = _IFiltreYetkisi.Split(',');
                foreach (var item in departmanlar)
                {
                    lbDepartmanlar.Items.Add("0", item.ToString().TrimStart().TrimEnd());
                }
            }
            lbDepartmanlar.CheckAll();
        }
        private void ps_SorumlulukMermeziDoldur() {
                string[] ilParcala = _ISmerkeziFiltreYetkisi.Split(',');
                string[] smAdiveSmKodu = null;
                string smAdi = null;
                string smKodu = null;
                foreach (var item in ilParcala)
                {
                    smAdiveSmKodu = item.Split(':');
                    smAdi = smAdiveSmKodu[1].TrimStart().TrimEnd();
                    smKodu = smAdiveSmKodu[0].TrimStart().TrimEnd();
                    lbSm.Items.Add(smKodu, "<"+smKodu+">"+smAdi);
                }
                lbSm.CheckAll();
        }

        public void kurCek()
        {
            try
            {
            dolarYaz("Merkez Bankasından Kontrol Ediliyor...");
            XmlTextReader rdr = new XmlTextReader("http://www.tcmb.gov.tr/kurlar/today.xml");

            XmlDocument myxml = new XmlDocument();
           
            myxml.Load(rdr);
            
            XmlNode tarih = myxml.SelectSingleNode("/Tarih_Date/@Tarih");
            XmlNodeList mylist = myxml.SelectNodes("/Tarih_Date/Currency");
            XmlNodeList kod = myxml.SelectNodes("/Tarih_Date/Currency/@Kod");
            XmlNodeList doviz_alis = myxml.SelectNodes("/Tarih_Date/Currency/ForexBuying");
            int x = 19;

            for (int i = 0; i < x; i++)
            {
                if (kod.Item(i).InnerText.ToString() == "USD")
                {
                   dolar= Convert.ToDouble(doviz_alis.Item(i).InnerText.ToString().Replace(".",","));

                }
                else if (kod.Item(i).InnerText.ToString() == "EUR")
                {
                    euro = Convert.ToDouble(doviz_alis.Item(i).InnerText.ToString().Replace(".", ","));
                }     
            }
            euorYaz(euro.ToString());
            dolarYaz(dolar.ToString());
            }
            catch
            {
                dolarYaz("Kurlar Çekilemedi!");                
            }
        }
        public void kurGetir() {
            this.kurlarTableAdapter.Fill(this.dSRaporlama.Kurlar);
            string aciklama="";
            try
            {
                foreach (DataRow item in dSRaporlama.Kurlar.Rows)
                {
                    if (item[0].ToString() == "USD")
                    {
                        
                        dolar = Convert.ToDouble(item[1]);
                        aciklama = item[2].ToString();
                    }
                    else if (item[0].ToString() == "EURO")
                    {
                        euro = Convert.ToDouble(item[1]);
                    }
                }
                lbldolar.Text = "$: "+ dolar.ToString();
                lbleuro.Text = "€: " + euro.ToString();// +"  -  " + aciklama;
            }
            catch (Exception ex)
            {
                dolar = 0;
                euro = 0;
            }      
        }

        private delegate void _euroYaz(string d);
        private void euorYaz(string d) {
            if(this.InvokeRequired){
                this.Invoke(new _euroYaz(euorYaz), d);
            }
             lbleuro.Text = "€" + d;
        }
         
        private delegate void _dolarYaz(string d);
        private void dolarYaz(string d)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new _dolarYaz(dolarYaz), d);
            }
            lbldolar.Text = "$"+d;
        }

        private string _versiyon;
        public string Versiyon
        {
            get { return _versiyon; }
            set { _versiyon = value; }
        }

        private string _gelenVersion;
        public string GelenVersion
        {
            get { return _gelenVersion; }
            set { _gelenVersion = value; }
        }

        private string _aciklama;
        public string Aciklama
        {
            get { return _aciklama; }
            set { _aciklama = value; }
        }

        private string _dosyalar;
        public string Dosyalar
        {
            get { return _dosyalar; }
            set { _dosyalar = value; }
        }

        public string _ilFiltre;// insan kaynakları tarihe göre aramada filtre için kullanılcak
        delegate  void dlg_alert(string mesaj);
        private void ps_alert(string mesaj) {
            if (base.InvokeRequired)
            {
                base.Invoke(new dlg_alert(ps_alert),mesaj);
            }
            else
            {
                DevExpress.XtraBars.Alerter.AlertInfo ai = new DevExpress.XtraBars.Alerter.AlertInfo("Yeni Güncelleme!",mesaj);
                alertControl1.Show(this, ai);
            }
        }

        DataSet ds;
        private void ps_remoteVersiyonCek(){
            try
            {
                ds = new DataSet("guncelleme");
                ds.ReadXml("http://editorgroup.net/Projeler/EgemenogluFinansalRaporlama/version.xml");

                GelenVersion = ds.Tables[0].Rows[0]["Versiyon"].ToString();
                Aciklama = ds.Tables[0].Rows[0]["Aciklama"].ToString();
                Dosyalar = ds.Tables[0].Rows[0]["Dosya"].ToString();

                if (Versiyon!=GelenVersion)
                {
                    ps_alert(Aciklama);
                    //Process.Start(Application.StartupPath + "\\programGuncelleme.exe");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme kontrolü hatası:"+ex.Message.ToString());
            }
        }
        private void ps_threadremoteVersiyonCek()
        {
            tRemoteVersiyonCek = new Thread(new ThreadStart(ps_remoteVersiyonCek));
            tRemoteVersiyonCek.Start();
        }

        private void ps_clientVersiyonCek()
        {
            try
            {
                uzakIni = new global::iniOku.iniOku(iniOku.IniOku("Ayar", "InıYolu") +@"\LoginSettings.ini");

                GelenVersion = uzakIni.IniOku("Ayar","Version");
                Aciklama = GelenVersion.ToString() +" Versiyonu Bulundu!" ;
                Dosyalar = "EgemenogluRaporlama.exe";

                
                if (Versiyon != GelenVersion && !string.IsNullOrEmpty(GelenVersion))
                {
                    ps_alert(Aciklama);
                    //Process.Start(Application.StartupPath + "\\programGuncelleme.exe");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme kontrolü hatası:" + ex.Message.ToString());
            }
        }
        private void ps_threadtUzakVersiyon() {
            tRemoteClietVersiyon = new Thread(new ThreadStart(ps_threadtUzakVersiyon));
            tRemoteClietVersiyon.Start();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
           
            if (IFinans)
            {
                panelDepartmanlar.Hide();
                panelSm.Show();
                dockPanel2.Text = "Sorumluluk Merkezleri";
            }
            else if (IInsanKaynaklari)
            {
                panelDepartmanlar.Show();
                panelSm.Hide();
            }
            else {
                panelDepartmanlar.Hide();
                panelSm.Hide();
            }
         

            if (_IGuncelleme)
            {
                try
                {
                    if (iniOku.IniOku("Ayar", "GuncellemeTuru") == "0")
                    {
                        ps_threadremoteVersiyonCek();
                    }
                    else
                    {
                        ps_clientVersiyonCek();// ps_threadtUzakVersiyon();
                    }
              
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                
            }
            
            kurGetir();
            bgAc();
            try
            {
                ps_IlleriDoldur();
                ps_DepartmanlariDoldur();
                ps_SorumlulukMermeziDoldur();
            }
            catch (Exception)
            {
            }
         
            timer1.Start();
            lblSignature.Caption = "Copyright © EditörSoft || Erkan AKIN";
        }

        private void btnLikidite_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            likiditeAc();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            muvekkilAc();
        }

        private void btnBankaHareketleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bankaHareketleriAC();
        }

        private void btnPersonemMasraflari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            perSoneleAvansAc();
        }

        private void btnGiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            giderleriAc();
        }

        private void btnKullaniciTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            kullanicilariAc();
        }

        private void btnKasaHaraketleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            kasaHarekleriAc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbIller.CheckAll();
        }

        private void btnTumunuIptalEt_Click(object sender, EventArgs e)
        {
            lbIller.UnCheckAll();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblZaman.Text =Convert.ToString(DateTime.Now);
        }

        private void btnCeksenet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cekSenetAc();
        }

        private void toolStripStatusLabel5_Click(object sender, EventArgs e)
        {
            //kurlarAc();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(dolar.ToString());
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gelirAc();
        }

        private void btnBilanco_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bilancoAc();
        }

        private void btnKasalarArasiBorc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            muvekkilMasraflariAc();
        }

        private void btnEmanetKasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMuvekkilAlacaklariAc();
        }

        private void btnGunlukGirisler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gunlukGirisAc();
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gunlukGirisCikisAc();
        }

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tariheGoreAc();
        }

        private void btnTumunuSecDepart_Click(object sender, EventArgs e)
        {
            lbDepartmanlar.CheckAll();
        }

        private void btnTumunuIptalEtDepart_Click(object sender, EventArgs e)
        {
            lbDepartmanlar.UnCheckAll();
        }

        private void btnDegisiklik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            degisiklikYapilanlarAc();
        }

        private void btnHaftalik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            haftalikGirisCikis();
        }

        private void btnAylik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            aylikGirisCikis();
        }

        private void kurlarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kurlarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSRaporlama);

        }

        private void barButtonItem1_ItemClick_2(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmGuncelleAC();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbSm.CheckAll();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            lbSm.UnCheckAll();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {
            try
            {
                short pageIndex;
                pageIndex = (short)ribbonControl1.SelectedPage.PageIndex;

                switch (pageIndex)
                {
                    case 0:
                        panelDepartmanlar.Hide();
                        panelSm.Show();
                        dockPanel2.Text = "Sorumluluk Merkezleri";
                        break;

                    case 1:
                        panelDepartmanlar.Show();
                        panelSm.Hide();

                        dockPanel2.Text = "Departmanlar";
                        break;
                }
            }
            catch
            {
            } 
        }

        private void btnPiramitHareketleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPiramitHareketleriAc();
        }

        private void btnZincirEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmYeniMusteriAc();
        }

        private void btnPrimHesapla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPrimHesaplaAc();
        }

        private void btnGrupTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grupTanimlariAc();
        }

        private void btnPersoneleGrupAta_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            personeleGrupAtamaAc();
        }

        private void barButtonItem2_ItemClick_2(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            donemTanimlariAc();
        }

        private void btnTahsilatSuresi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            musterilerIcinAySayilariAc();
        }

        private void btnPrimGirisi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPrimGirisAc();
        }

        private void btnPrimRaporu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPrimRaporuAc();
        }

        private void barButtonItem2_ItemClick_3(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPrimRaporu1Ac();
        }

        private void barButtonItem2_ItemClick_4(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tahsilatSureleriAc();
        }

        private void btnYeniIs_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmIsHareketleriAc();
        }

        private void btnButceTanimla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmButceAc();
        }

        private void btnButce_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmButceAnaliziAc();
        }  
    }
}