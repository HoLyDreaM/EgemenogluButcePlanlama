using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Sql;
using System.Data.SqlClient;

namespace EgemenOgluRaporlama.Butce
{
    public partial class ButceAnalizi : DevExpress.XtraEditors.XtraForm
    {
        public ButceAnalizi()
        {
            InitializeComponent();
        }

        public AnaForm anafrm { get; set; }
        int DonemAraligi;
        int DiziElemanlari = 1;
        int DiziElemanlari2;

        private string fn_ilKodu()
        {
            string q, q1;
            q = null;
            q1 = null;
            for (int i = 0; i < anafrm.lbIller.CheckedItems.Count; i++)
            {
                q1 = anafrm.lbIller.CheckedItems[i].ToString();
                q += "'" + q1 + "',";
            }

            if (!string.IsNullOrEmpty(q))
            {
                q = q.Substring(0, q.Length - 1);
            }
            else
            {
                q = null;
            }
            return q;
        }

        private string fn_smCek()
        {
            string _q, _q1;
            _q = null;
            _q1 = null;
            for (int i = 0; i < anafrm.lbSm.CheckedItems.Count; i++)
            {
                _q1 = anafrm.lbSm.CheckedItems[i].ToString();
                _q += "'" + _q1 + "',";
            }

            if (!string.IsNullOrEmpty(_q))
            {
                _q = _q.Substring(0, _q.Length - 1);
            }
            else
            {
                _q = null;
            }
            return _q;
        }

        private void ButceAnalizi_Load(object sender, EventArgs e)
        {
            tarih1.Text = "01.01." + DateTime.Now.Year.ToString();
            tarih2.Text = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month).ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString();
            cmbDonemAraligi.SelectedIndex = 0;
        }

        private void ps_ButceAnalizi(string ilKodlari, string smKod)
        {
            if (!string.IsNullOrEmpty(ilKodlari))
            {
                if (!string.IsNullOrEmpty(smKod))
                {
                    DonemAraligi = Convert.ToInt32(cmbDonemAraligi.SelectedItem);

                    SqlConnection con = new SqlConnection(Properties.Settings.Default.Cs);
                    con.Open();
                    string q = ilKodlari;
                    string sorgu = "CREATE TABLE #Gelir( " +
                                   "Tip NVARCHAR(20), " +
                                   "BelgeTarihi DATETIME, " +
                                   "CariKod NVARCHAR(50), " +
                                   "Meblag NUMERIC(21,2), " +
                                   "Aciklama NVARCHAR(500), " +
                                   "EvrakSeri NVARCHAR(25), " +
                                   "EvrakSira NVARCHAR(25), " +
                                   "BelgeNo NVARCHAR(50), " +
                                   "SorumlulukKodu NVARCHAR(25), " +
                                   "CariAdi NVARCHAR(500), " +
                                   "SorumlulukMerkeziAdi NVARCHAR(50), " +
                                   "KasaKodu NVARCHAR(50), " +
                                   "MasrafAdi NVARCHAR(500), " +
                                   "Toplam NUMERIC(21,2), " +
                                   "IL NVARCHAR(50) " +
                                   ") " +
                                   "CREATE TABLE #GIDER ( " +
                                   "Tip NVARCHAR(20), " +
                                   "BelgeTarihi DATETIME, " +
                                   "CariKod NVARCHAR(50), " +
                                   "Meblag NUMERIC(21,2), " +
                                   "Aciklama NVARCHAR(500), " +
                                   "EvrakSeri NVARCHAR(25), " +
                                   "EvrakSira NVARCHAR(25), " +
                                   "BelgeNo NVARCHAR(50), " +
                                   "SorumlulukKodu NVARCHAR(25), " +
                                   "CariAdi NVARCHAR(500), " +
                                   "SorumlulukMerkeziAdi NVARCHAR(50), " +
                                   "KasaKodu NVARCHAR(50), " +
                                   "MasrafAdi NVARCHAR(500), " +
                                   "Toplam NUMERIC(21,2), " +
                                   "Bolge NVARCHAR(50) " +
                                   ") " +
                                   "CREATE TABLE #SorumlulukAdlari( " +
                                   "SorumlulukMerkeziAdi NVARCHAR(150), " +
                                   "SorumlulukKodlari NVARCHAR(100), " +
                                   ") " +
                                   "CREATE TABLE #GelirToplam( " +
                                   "Toplam NUMERIC(18,2), " +
                                   "SrmKodu NVARCHAR(50) " +
                                   ") " +
                                   "CREATE TABLE #GiderToplam( " +
                                   "Toplam NUMERIC(18,2), " +
                                   "SrmKodu NVARCHAR(50) " +
                                   ") " +
                        //"--Sorumluluk Merkezi
                                   "INSERT INTO #SorumlulukAdlari " +
                                   "SELECT * FROM(SELECT som_isim AS SorumlulukMerkeziAdi,som_kod AS SorumlulukKodlari FROM SORUMLULUK_MERKEZLERI " +
                                   "WHERE som_kod IN(" + smKod + ")) AS TBL2 " +
                        //"--Gider
                                   "INSERT INTO #GIDER " +
                                   "SELECT 'Gider' as tip , cha_belge_tarih,cha_kod, " +
                                  " cha_meblag, cha_aciklama, cha_evrakno_seri, cha_evrakno_sira, cha_belge_no,cha_srmrkkodu,dbo.fn_CarininIsminiBul(0,cha_kod) AS cariAdi, " +
                                  " dbo.fn_SorumlulukMerkeziAdiBul(cha_srmrkkodu)as smAdi, " +
                           " cha_kasa_hizkod,dbo.fn_MasrafIsmi(cha_kod) masrafAdi, " +
                  "CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN (CASE WHEN dbo.fn_CariHarTip(dbo.fn_CariharBorcAlacak(0,cha_tip,cha_tpoz,cha_cari_cins))='Alacak' THEN 1 ELSE -1 END) * cha_meblag ELSE (CASE WHEN dbo.fn_CariHarTip(dbo.fn_CariharBorcAlacak(0,cha_tip,cha_tpoz,cha_cari_cins))='Alacak' THEN 1 ELSE -1 END) * cha_aratoplam END),0) else 0 END AS Toplam, " +
                               " CASE left(cha_srmrkkodu,2) " +
                           " WHEN '01' THEN 'ISTANBUL' " +
                           " WHEN '02' THEN 'BURSA' " +
                           " WHEN '03' THEN 'IZMIR' " +
                           " WHEN '04' THEN 'ADANA' " +
                           " WHEN '05' THEN 'ANKARA' " +
                           " WHEN '06' THEN 'ANTALYA' " +
                           " ELSE (Case left(cha_srmrkkodu,2) when '99' then 'YUNUS EGEMENOGLU'  when '00' then 'ORTAK CARİ İŞLEMLERİ' Else 'Tanımsız' END) END AS IL        " +
                           " from CARI_HESAP_HAREKETLERI " +
                          " WHERE cha_kod IN (SELECT his_kod FROM MASRAF_HESAPLARI WHERE left(his_isim,3)<>'840')  AND cha_kod<>'' AND cha_cari_cins=5" +// AND cha_kod<>'' AND cha_cari_cins=5
                           " and (cha_belge_tarih BETWEEN CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102))  And Left(cha_srmrkkodu,2) in(" + q + ",'99',''" + ")  AND cha_srmrkkodu in (" + smKod + ")" +
                           " GROUP BY cha_belge_tarih, cha_kod, cha_kasa_hizkod,cha_karsisrmrkkodu, " +
                                  " cha_aratoplam, cha_aciklama, cha_srmrkkodu,cha_evrakno_seri, cha_evrakno_sira, cha_belge_no,cha_satir_no,cha_cari_cins,cha_meblag " +
                        //"--Gelir "+
                                   "INSERT INTO #Gelir " +
                                   "SELECT 'Gelir' as tip , cha_belge_tarih,cha_kod, " +
                                  " cha_meblag, cha_aciklama, cha_evrakno_seri, cha_evrakno_sira, cha_belge_no,cha_srmrkkodu,dbo.fn_CarininIsminiBul(0,cha_kod) AS cariAdi, " +
                                  " dbo.fn_SorumlulukMerkeziAdiBul(cha_srmrkkodu)as smAdi, " +
                           " cha_kasa_hizkod,dbo.fn_HizmetIsmi(cha_kod) masrafAdi, " +
                  "CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN  (CASE WHEN dbo.fn_CariHarTip(dbo.fn_CariharBorcAlacak(0,cha_tip,cha_tpoz,cha_cari_cins))='Alacak' THEN -1 ELSE 1 END) * cha_meblag ELSE (CASE WHEN dbo.fn_CariHarTip(dbo.fn_CariharBorcAlacak(0,cha_tip,cha_tpoz,cha_cari_cins))='Alacak' THEN -1 ELSE 1 END) * cha_aratoplam END),0) else 0 END AS Toplam, " +
                               " CASE left(cha_srmrkkodu,2) " +
                           " WHEN '01' THEN 'ISTANBUL' " +
                           " WHEN '02' THEN 'BURSA' " +
                           " WHEN '03' THEN 'IZMIR' " +
                           " WHEN '04' THEN 'ADANA' " +
                           " WHEN '05' THEN 'ANKARA' " +
                           " WHEN '06' THEN 'ANTALYA' " +
                           " ELSE (Case left(cha_srmrkkodu,2) when '99' then 'YUNUS EGEMENOGLU'  when '00' then 'ORTAK CARİ İŞLEMLERİ' Else 'Tanımsız' END) END AS IL        " +
                           " from CARI_HESAP_HAREKETLERI " +
                          " WHERE cha_kod IN (SELECT hh.hiz_kod FROM HIZMET_HESAPLARI hh)  AND cha_kod<>'' AND cha_cari_cins=3" +// AND cha_kod<>'' AND cha_cari_cins=5
                           " and (cha_belge_tarih BETWEEN CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102))  And Left(cha_srmrkkodu,2) in(" + q + ",'99',''" + ")  AND cha_srmrkkodu in (" + smKod + ")" +
                           " GROUP BY cha_belge_tarih, cha_kod, cha_kasa_hizkod,cha_karsisrmrkkodu, " +
                          " cha_aratoplam, cha_aciklama, cha_srmrkkodu,cha_evrakno_seri, cha_evrakno_sira, cha_belge_no,cha_satir_no,cha_cari_cins,cha_meblag " +

                    " Union " +//########################################################################################

                            " SELECT 'Gelir' as tip , cha_belge_tarih,cha_kasa_hizkod as cha_kod, " +
                          " cha_meblag, cha_aciklama, cha_evrakno_seri, cha_evrakno_sira, cha_belge_no,cha_srmrkkodu,dbo.fn_CarininIsminiBul(0,cha_kod) AS cariAdi, " +
                          " dbo.fn_SorumlulukMerkeziAdiBul(cha_srmrkkodu)as smAdi, " +
                   " cha_kasa_hizkod,dbo.fn_HizmetIsmi(cha_kasa_hizkod) masrafAdi, " +
            "CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN  (CASE WHEN dbo.fn_CariHarTip(dbo.fn_CariharBorcAlacak(0,cha_tip,cha_tpoz,cha_cari_cins))='Alacak' THEN -1 ELSE 1 END) * cha_meblag ELSE (CASE WHEN dbo.fn_CariHarTip(dbo.fn_CariharBorcAlacak(0,cha_tip,cha_tpoz,cha_cari_cins))='Alacak' THEN -1 ELSE 1 END) * cha_aratoplam END),0) else 0 END AS Toplam, " +
                       " CASE left(cha_srmrkkodu,2) " +
                   " WHEN '01' THEN 'ISTANBUL' " +
                   " WHEN '02' THEN 'BURSA' " +
                   " WHEN '03' THEN 'IZMIR' " +
                   " WHEN '04' THEN 'ADANA' " +
                   " WHEN '05' THEN 'ANKARA' " +
                   " WHEN '06' THEN 'ANTALYA' " +
                   " ELSE (Case left(cha_srmrkkodu,2) when '99' then 'YUNUS EGEMENOGLU'  when '00' then 'ORTAK CARİ İŞLEMLERİ' Else 'Tanımsız' END) END AS IL        " +
                   " from CARI_HESAP_HAREKETLERI " +
                  " WHERE cha_kasa_hizkod IN (SELECT hh.hiz_kod FROM HIZMET_HESAPLARI hh)  AND cha_kod<>'' AND cha_kasa_hizmet=3" +//(cha_kasa_hizmet=3) and (cha_kasa_hizkod<>'')
                   " and (cha_belge_tarih BETWEEN CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102))  And Left(cha_srmrkkodu,2) in(" + q + ",'99',''" + ")  AND cha_srmrkkodu in (" + smKod + ")" +
                   " GROUP BY cha_belge_tarih, cha_kod, cha_kasa_hizkod,cha_karsisrmrkkodu, " +
                          " cha_aratoplam, cha_aciklama, cha_srmrkkodu,cha_evrakno_seri, cha_evrakno_sira, cha_belge_no,cha_satir_no,cha_cari_cins,cha_meblag " +

                                   "INSERT INTO #GelirToplam " +
                                   "SELECT SUM(Toplam) AS Toplam,#Gelir.SorumlulukKodu FROM #Gelir " +
                                   "GROUP BY #Gelir.SorumlulukKodu " +

                                   "INSERT INTO #GiderToplam " +
                                   "SELECT SUM(Toplam) AS Toplam,#GIDER.SorumlulukKodu FROM #GIDER " +
                                   "GROUP BY #GIDER.SorumlulukKodu " +

                                   "SELECT TBL.Bolge,TBL.SorumlulukMerkeziAdi,TBL.Yil,TBL.BelirlenenButceGelir,TBL.ButcelenenGelir, " +
                                   "ISNULL(TBL.GerceklesenGelir,0) AS GerceklesenGelir,TBL.BelirlenenButceGider, " +
                                   "TBL.ButcelenenGider,ISNULL(TBL.GerceklesenGider,0) AS GerceklesenGider, " +
                                   "ISNULL(TBL.ButcelenenGerceklesenGelir,0) AS ButcelenenGerceklesenGelir, " +
                                   "ISNULL(TBL.ButcelenenGerceklesenGider,0) AS ButcelenenGerceklesenGider, " +
                                   "CONVERT(DECIMAL(21,2),ISNULL(TBL.YuzdeGelirSapmasi,0)) AS YuzdeGelirSapmasi, " +
                                   "CONVERT(DECIMAL(21,2),ISNULL(TBL.YuzdeGiderSapmasi,0)) AS YuzdeGiderSapmasi FROM( " +
                                   "SELECT SrmMrkAdi AS Bolge,#SorumlulukAdlari.SorumlulukMerkeziAdi AS SorumlulukMerkeziAdi,Yil,ButceGelir AS BelirlenenButceGelir, " +
                                   "CONVERT(DECIMAL(18,2),(ButceGelir/12*" + DonemAraligi + ")) AS ButcelenenGelir, " +
                                   "(#GelirToplam.Toplam) AS GerceklesenGelir, " +
                                   "ButceGider AS BelirlenenButceGider, " +
                                   "CONVERT(DECIMAL(18,2),(ButceGider/12*" + DonemAraligi + ")) AS ButcelenenGider, " +
                                   "-1*(#GiderToplam.Toplam) AS GerceklesenGider,-1*(CONVERT(DECIMAL(18,2),(ButceGelir/12*" + DonemAraligi + "))-( " +
                                   "(#GelirToplam.Toplam))) AS ButcelenenGerceklesenGelir,(CONVERT(DECIMAL(18,2),(ButceGider/12*" + DonemAraligi + "))-( " +
                                   "-1*#GiderToplam.Toplam)) AS ButcelenenGerceklesenGider,( " +
                                   "((#GelirToplam.Toplam) " +
                                   "-CONVERT(DECIMAL(18,2),(ButceGelir/12*" + DonemAraligi + ")))/(CONVERT(DECIMAL(18,2),(ButceGelir/12*" + DonemAraligi + "))) " +
                                   ")AS YuzdeGelirSapmasi,-1*( " +
                                   "((#GiderToplam.Toplam) " +
                                   "-CONVERT(DECIMAL(18,2),(ButceGider/12*" + DonemAraligi + ")))/(CONVERT(DECIMAL(18,2),(ButceGider/12*" + DonemAraligi + "))) " +
                                   ") AS YuzdeGiderSapmasi " +
                                    "FROM EgemenogluRaporlama.dbo.Butce   " +
                                    "INNER JOIN #SorumlulukAdlari ON SrmMrkKodu=#SorumlulukAdlari.SorumlulukKodlari " +
                                   " LEFT JOIN #GelirToplam ON SrmMrkKodu=#GelirToplam.SrmKodu " +
                                    "LEFT JOIN #GiderToplam ON SrmMrkKodu=#GiderToplam.SrmKodu " +
                                   ") AS TBL  " +

                                   "DROP TABLE #Gelir " +
                                   "DROP TABLE #GIDER " +
                                   "DROP TABLE #SorumlulukAdlari " +
                                   "DROP TABLE #GelirToplam " +
                                   "DROP TABLE #GiderToplam";

                    SqlDataAdapter da = new SqlDataAdapter(sorgu, con);
                    dsYeniRaporlar.ButceAnalizRaporu.Clear();
                    da.Fill(dsYeniRaporlar.ButceAnalizRaporu);
                    grdButceAnalizi.DataSource = dsYeniRaporlar.ButceAnalizRaporu;
                }
                else
                {
                    MessageBox.Show("Arama Kriteri Olarak {Sorumluluk Merkezi} Seçilmedi!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            else
            {
                MessageBox.Show("Arama Kriteri Olarak {il} Seçilmedi!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnTemizle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dsYeniRaporlar.ButceAnalizRaporu.Clear();
        }

        private void ps_ciktiXls()
        {
            if (gridView1.RowCount > 0)
            {
                raporKaydet.Title = "Rapor Kaydet!";
                raporKaydet.DefaultExt = "Rapor Kaydet";
                raporKaydet.Filter = "Excel Dosyaları (*.xls)|*.xls";

                DialogResult = raporKaydet.ShowDialog();
                if (DialogResult == DialogResult.OK || DialogResult == DialogResult.Yes)
                {
                    grdButceAnalizi.ExportToExcelOld(raporKaydet.FileName);
                }
            }
        }

        private void btnExcelAktar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ps_ciktiXls();
        }

        private void btnDetayAc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ExpandAllGroups();
        }

        private void btnDetayKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.CollapseAllGroups();
        }

        private void btnGrupAc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gridView1.OptionsView.ShowGroupPanel = true;
        }

        private void btnGrupKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gridView1.OptionsView.ShowGroupPanel = false;
        }

        private void btnEnUygunGenislik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.BestFitColumns();
        }

        private void btnSorgula_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ps_ButceAnalizi(fn_ilKodu(), fn_smCek());
                
                this.tblButceRaporAnaliziTableAdapter.RaporClear();

                #region Cart Kontrolü İçin Verileri Hazırlıyoruz

                decimal ButcelenenGelir = 0;
                decimal GerceklesenGelir = 0;
                decimal ButcelenenGider = 0;
                decimal GerceklesenGider = 0;
                decimal YuzdeGelirSapmasi = 0;
                decimal YuzdeGiderSapmasi = 0;
                string SrmMrkz = "";
                string[] BolgeElemanlari = new string[DiziElemanlari];
                bool BolgeDurumu = false;
                string Bolge1 = "";
                string Bolge3 = "";
                int SatirSayisi = 0;

                foreach (DataRow dr in dsYeniRaporlar.ButceAnalizRaporu.Rows)
                {
                    Bolge1 = dr["Bolge"].ToString();
                    Bolge3 = dsYeniRaporlar.ButceAnalizRaporu.Rows[SatirSayisi][0].ToString();

                    if (Bolge1 != Bolge3)
                        BolgeDurumu = false;

                    for (int i = 0; i < dsYeniRaporlar.ButceAnalizRaporu.Rows.Count; i++)
                    {
                        Bolge3 = dsYeniRaporlar.ButceAnalizRaporu.Rows[i][0].ToString();

                        if (Bolge1 == Bolge3 && BolgeDurumu == false)
                        {
                            DiziElemanlari2 = DiziElemanlari;
                            DiziElemanlari2 = DiziElemanlari - 1;

                            BolgeElemanlari[DiziElemanlari2] = Bolge1;


                            DiziElemanlari++;
                            DiziElemanlari2 = DiziElemanlari;

                            Array.Resize(ref BolgeElemanlari, DiziElemanlari2);
                            SatirSayisi = i;
                            BolgeDurumu = true;
                        }
                    }
                }

                for (int b = 0; b < BolgeElemanlari.Length; b++)
                {
                    string KontrolBolge = BolgeElemanlari[b];

                    if (KontrolBolge == null)
                    {
                        Array.Resize(ref BolgeElemanlari, BolgeElemanlari.Length - 1);
                    }
                }

                for (int c = 0; c < BolgeElemanlari.Length; c++)
                {
                    string Bolge = BolgeElemanlari[c];

                    for (int i = 0; i < dsYeniRaporlar.ButceAnalizRaporu.Rows.Count; i++)
                    {
                        string Bolge2 = dsYeniRaporlar.ButceAnalizRaporu.Rows[i][0].ToString();

                        if (Bolge == Bolge2)
                        {
                            ButcelenenGelir += Convert.ToDecimal(dsYeniRaporlar.ButceAnalizRaporu.Rows[i][4].ToString());
                            GerceklesenGelir += Convert.ToDecimal(dsYeniRaporlar.ButceAnalizRaporu.Rows[i][5].ToString());
                            ButcelenenGider += Convert.ToDecimal(dsYeniRaporlar.ButceAnalizRaporu.Rows[i][7].ToString());
                            GerceklesenGider += Convert.ToDecimal(dsYeniRaporlar.ButceAnalizRaporu.Rows[i][8].ToString());
                        }
                    }

                    this.tblButceRaporAnaliziTableAdapter.ButceRaporEkle(Bolge, ButcelenenGelir, GerceklesenGelir, ButcelenenGider,GerceklesenGider);

                    ButcelenenGelir = 0;
                    GerceklesenGelir = 0;
                    ButcelenenGider = 0;
                    GerceklesenGider = 0;

                }

                for (int i = 0; i < dsYeniRaporlar.ButceAnalizRaporu.Rows.Count; i++)
                {
                    ButcelenenGelir += Convert.ToDecimal(dsYeniRaporlar.ButceAnalizRaporu.Rows[i][4].ToString());
                    GerceklesenGelir += Convert.ToDecimal(dsYeniRaporlar.ButceAnalizRaporu.Rows[i][5].ToString());
                    ButcelenenGider += Convert.ToDecimal(dsYeniRaporlar.ButceAnalizRaporu.Rows[i][7].ToString());
                    GerceklesenGider += Convert.ToDecimal(dsYeniRaporlar.ButceAnalizRaporu.Rows[i][8].ToString());
                }

                this.tblButceRaporAnaliziTableAdapter.ButceRaporEkle("Genel Toplam", ButcelenenGelir, GerceklesenGelir, ButcelenenGider, GerceklesenGider);
                
                ButcelenenGelir = 0;
                GerceklesenGelir = 0;
                ButcelenenGider = 0;
                GerceklesenGider = 0;
                DiziElemanlari = 1;

                #endregion

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnButceGrafikselRapor_Click(object sender, EventArgs e)
        {
            Butce.ButceChartKontrol frmButceChart = new Butce.ButceChartKontrol();

            frmButceChart.ShowDialog();
        }
    }
}