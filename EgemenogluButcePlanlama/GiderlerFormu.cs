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

namespace EgemenOgluRaporlama
{
    public partial class GiderlerFormu : DevExpress.XtraEditors.XtraForm
    {
        public GiderlerFormu()
        {
            InitializeComponent();
        }
        public AnaForm anafrm { get; set; }
        private string fn_ilKodu()
        {
            string q, q1;
            q = null;
            q1 = null;
            for (int i = 0; i < anafrm.lbIller.CheckedItems.Count; i++)
            {
                q1 = anafrm.lbIller.CheckedItems[i].ToString();
                q += "'"+q1 + "',";
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
        private void ps_aramaYap(string ilKodlari,string smKod)
        {
            if (!string.IsNullOrEmpty(ilKodlari))
            {
                if (!string.IsNullOrEmpty(smKod))
                {
                    //string strYil,strYil1;
                    //strYil = Convert.ToString((int)spinEdit1.Value);
                    //strYil1 = Convert.ToString((int)spinEdit1.Value);

                    SqlConnection con = new SqlConnection(Properties.Settings.Default.Cs);
                    con.Open();
                    string q = ilKodlari;
                    string sorgu = " SELECT 'Gider' as tip, cha_belge_tarih,cha_kasa_hizkod as cha_kod, " +
                                  " cha_meblag, cha_aciklama, cha_evrakno_seri, cha_evrakno_sira, cha_belge_no,cha_karsisrmrkkodu as cha_srmrkkodu,dbo.fn_CarininIsminiBul(0,cha_kod) AS cariAdi, " +
                                  " dbo.fn_SorumlulukMerkeziAdiBul(cha_karsisrmrkkodu)as smAdi, " +
                           " cha_kasa_hizkod,dbo.fn_MasrafIsmi(cha_kasa_hizkod) masrafAdi, " +
                "CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN -1 * cha_meblag ELSE -1 * cha_aratoplam END),0) else 0 END AS Toplam, " +
                        //"CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(VARCHAR ,'" + strYil + "-01-01',23) AND CONVERT(VARCHAR ,'" + strYil + "-12-'+CAST(dbo.fn_AyKacGun(12, " + strYil + ")AS NVARCHAR),23)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN -1 * cha_meblag ELSE -1 * cha_aratoplam END),0) else 0 END AS Toplam, " +
                        //"CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(VARCHAR ,'" + strYil + "-01-01',23) AND CONVERT(VARCHAR ,'" + strYil + "-01-'+CAST(dbo.fn_AyKacGun(1, " + strYil + ")AS NVARCHAR),23)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN -1 * cha_meblag ELSE -1 * cha_aratoplam END),0) else 0 END AS Ocak, " +
                        //"CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(VARCHAR ,'" + strYil + "-02-01',23) AND CONVERT(VARCHAR ,'" + strYil + "-02-'+CAST(dbo.fn_AyKacGun(2, " + strYil + ")AS NVARCHAR),23)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN -1 * cha_meblag ELSE -1 * cha_aratoplam END),0) else 0 END AS subat, " +
                        //"CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(VARCHAR ,'" + strYil + "-03-01',23) AND CONVERT(VARCHAR ,'" + strYil + "-01-'+CAST( dbo.fn_AyKacGun(3, " + strYil + ")AS NVARCHAR),23)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN -1 * cha_meblag ELSE -1 * cha_aratoplam END),0) else 0 END AS mart, " +
                        //"CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(VARCHAR ,'" + strYil + "-04-01',23) AND CONVERT(VARCHAR ,'" + strYil + "-04-'+CAST( dbo.fn_AyKacGun(4, " + strYil + ")AS NVARCHAR),23)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN -1 * cha_meblag ELSE -1 * cha_aratoplam END),0) else 0 END AS nisan, " +
                        //"CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(VARCHAR ,'" + strYil + "-05-01',23) AND CONVERT(VARCHAR ,'" + strYil + "-05-'+CAST( dbo.fn_AyKacGun(5, " + strYil + ")AS NVARCHAR),23)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN -1 * cha_meblag ELSE -1 * cha_aratoplam END),0) else 0 END AS mayis, " +
                        //"CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(VARCHAR ,'" + strYil + "-06-01',23) AND CONVERT(VARCHAR ,'" + strYil + "-06-'+CAST( dbo.fn_AyKacGun(6, " + strYil + ")AS NVARCHAR),23)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN -1 * cha_meblag ELSE -1 * cha_aratoplam END),0) else 0 END AS haziran, " +
                        //"CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(VARCHAR ,'" + strYil + "-07-01',23) AND CONVERT(VARCHAR ,'" + strYil + "-07-'+CAST( dbo.fn_AyKacGun(7, " + strYil + ")AS NVARCHAR),23)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN -1 * cha_meblag ELSE -1 * cha_aratoplam END),0) else 0 END AS temmuz, " +
                        //"CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(VARCHAR ,'" + strYil + "-08-01',23) AND CONVERT(VARCHAR ,'" + strYil + "-08-'+CAST( dbo.fn_AyKacGun(8, " + strYil + ")AS NVARCHAR),23)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN -1 * cha_meblag ELSE -1 * cha_aratoplam END),0) else 0 END AS agustos, " +
                        //"CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(VARCHAR ,'" + strYil + "-09-01',23) AND CONVERT(VARCHAR ,'" + strYil + "-09-'+CAST( dbo.fn_AyKacGun(9, " + strYil + ")AS NVARCHAR),23)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN -1 * cha_meblag ELSE -1 * cha_aratoplam END),0) else 0 END AS eylul, " +
                        //"CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(VARCHAR ,'" + strYil + "-10-01',23) AND CONVERT(VARCHAR ,'" + strYil + "-10-'+CAST( dbo.fn_AyKacGun(10, " + strYil + ")AS NVARCHAR),23)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN -1 * cha_meblag ELSE -1 * cha_aratoplam END),0) else 0 END AS ekim, " +
                        //"CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(VARCHAR ,'" + strYil + "-11-01',23) AND CONVERT(VARCHAR ,'" + strYil + "-11-'+CAST( dbo.fn_AyKacGun(11, " + strYil + ")AS NVARCHAR),23)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN -1 * cha_meblag ELSE -1 * cha_aratoplam END),0) else 0 END AS kasim, " +
                        //"CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(VARCHAR ,'" + strYil + "-12-01',23) AND CONVERT(VARCHAR ,'" + strYil + "-12-'+CAST( dbo.fn_AyKacGun(12, " + strYil + ")AS NVARCHAR),23)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN -1 * cha_meblag ELSE -1 * cha_aratoplam END),0) else 0 END AS aralik, " +
                               " CASE left(cha_karsisrmrkkodu,2) " +
                           " WHEN '01' THEN 'ISTANBUL' " +
                           " WHEN '02' THEN 'BURSA' " +
                           " WHEN '03' THEN 'IZMIR' " +
                           " WHEN '04' THEN 'ADANA' " +
                           " WHEN '05' THEN 'ANKARA' " +
                           " ELSE (Case left(cha_karsisrmrkkodu,2) when '99' then 'YUNUS EGEMENOGLU'  when '00' then 'ORTAK CARİ İŞLEMLERİ' Else 'Tanımsız' END) END AS IL        " +
                           " from CARI_HESAP_HAREKETLERI " +
                          " WHERE cha_kasa_hizkod IN (SELECT his_kod FROM MASRAF_HESAPLARI WHERE left(his_isim,3)<>'840') " +
                           " and (cha_belge_tarih BETWEEN CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102))  And Left(cha_karsisrmrkkodu,2) in(" + q + ",'99'" + ")  AND cha_tip=1 and cha_karsisrmrkkodu in("+smKod+")" +
                           " GROUP BY cha_belge_tarih, cha_kod, cha_kasa_hizkod,cha_karsisrmrkkodu, " +
                                  " cha_aratoplam, cha_aciklama, cha_srmrkkodu,cha_evrakno_seri, cha_evrakno_sira, cha_belge_no,cha_satir_no,cha_cari_cins,cha_meblag " +

                    " Union " +

                    " SELECT 'Gider' as tip , cha_belge_tarih,cha_kod, " +
                                  " cha_meblag, cha_aciklama, cha_evrakno_seri, cha_evrakno_sira, cha_belge_no,cha_srmrkkodu,dbo.fn_CarininIsminiBul(0,cha_kod) AS cariAdi, " +
                                  " dbo.fn_SorumlulukMerkeziAdiBul(cha_srmrkkodu)as smAdi, " +
                           " cha_kasa_hizkod,dbo.fn_MasrafIsmi(cha_kod) masrafAdi, " +
                  "CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN -1 * cha_meblag ELSE -1 * cha_aratoplam END),0) else 0 END AS Toplam, " +
                        //"CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(VARCHAR ,'" + strYil + "-01-01',23) AND CONVERT(VARCHAR ,'" + strYil + "-12-'+CAST(dbo.fn_AyKacGun(12, " + strYil + ")AS NVARCHAR),23)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN  -1 * cha_meblag ELSE -1 * cha_aratoplam END),0) else 0 END AS Toplam, " +
                        //"CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(VARCHAR ,'" + strYil + "-01-01',23) AND CONVERT(VARCHAR ,'" + strYil + "-01-'+CAST(dbo.fn_AyKacGun(1, " + strYil + ")AS NVARCHAR),23)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN  -1 * cha_meblag ELSE -1 * cha_aratoplam END),0) else 0 END AS Ocak, " +
                        //"CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(VARCHAR ,'" + strYil + "-02-01',23) AND CONVERT(VARCHAR ,'" + strYil + "-02-'+CAST(dbo.fn_AyKacGun(2, " + strYil + ")AS NVARCHAR),23)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN  -1  * cha_meblag ELSE -1 * cha_aratoplam END),0) else 0 END AS subat, " +
                        //"CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(VARCHAR ,'" + strYil + "-03-01',23) AND CONVERT(VARCHAR ,'" + strYil + "-01-'+CAST( dbo.fn_AyKacGun(3, " + strYil + ")AS NVARCHAR),23)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN  -1 * cha_meblag ELSE -1 * cha_aratoplam END),0) else 0 END AS mart, " +
                        //"CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(VARCHAR ,'" + strYil + "-04-01',23) AND CONVERT(VARCHAR ,'" + strYil + "-04-'+CAST( dbo.fn_AyKacGun(4, " + strYil + ")AS NVARCHAR),23)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN  -1 * cha_meblag ELSE -1 * cha_aratoplam END),0) else 0 END AS nisan, " +
                        //"CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(VARCHAR ,'" + strYil + "-05-01',23) AND CONVERT(VARCHAR ,'" + strYil + "-05-'+CAST( dbo.fn_AyKacGun(5, " + strYil + ")AS NVARCHAR),23)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN  -1 * cha_meblag ELSE -1 * cha_aratoplam END),0) else 0 END AS mayis, " +
                        //"CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(VARCHAR ,'" + strYil + "-06-01',23) AND CONVERT(VARCHAR ,'" + strYil + "-06-'+CAST( dbo.fn_AyKacGun(6, " + strYil + ")AS NVARCHAR),23)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN  -1 * cha_meblag ELSE -1 * cha_aratoplam END),0) else 0 END AS haziran, " +
                        //"CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(VARCHAR ,'" + strYil + "-07-01',23) AND CONVERT(VARCHAR ,'" + strYil + "-07-'+CAST( dbo.fn_AyKacGun(7, " + strYil + ")AS NVARCHAR),23)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN  -1 * cha_meblag ELSE -1 * cha_aratoplam END),0) else 0 END AS temmuz, " +
                        //"CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(VARCHAR ,'" + strYil + "-08-01',23) AND CONVERT(VARCHAR ,'" + strYil + "-08-'+CAST( dbo.fn_AyKacGun(8, " + strYil + ")AS NVARCHAR),23)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN  -1 * cha_meblag ELSE -1 * cha_aratoplam END),0) else 0 END AS agustos, " +
                        //"CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(VARCHAR ,'" + strYil + "-09-01',23) AND CONVERT(VARCHAR ,'" + strYil + "-09-'+CAST( dbo.fn_AyKacGun(9, " + strYil + ")AS NVARCHAR),23)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN  -1 * cha_meblag ELSE -1 * cha_aratoplam END),0) else 0 END AS eylul, " +
                        //"CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(VARCHAR ,'" + strYil + "-10-01',23) AND CONVERT(VARCHAR ,'" + strYil + "-10-'+CAST( dbo.fn_AyKacGun(10, " + strYil + ")AS NVARCHAR),23)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN  -1 * cha_meblag ELSE -1 * cha_aratoplam END),0) else 0 END AS ekim, " +
                        //"CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(VARCHAR ,'" + strYil + "-11-01',23) AND CONVERT(VARCHAR ,'" + strYil + "-11-'+CAST( dbo.fn_AyKacGun(11, " + strYil + ")AS NVARCHAR),23)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN  -1 * cha_meblag ELSE -1 * cha_aratoplam END),0) else 0 END AS kasim, " +
                        //"CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(VARCHAR ,'" + strYil + "-12-01',23) AND CONVERT(VARCHAR ,'" + strYil + "-12-'+CAST( dbo.fn_AyKacGun(12, " + strYil + ")AS NVARCHAR),23)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN  -1 * cha_meblag ELSE -1 * cha_aratoplam END),0) else 0 END AS aralik, " +
                               " CASE left(cha_srmrkkodu,2) " +
                           " WHEN '01' THEN 'ISTANBUL' " +
                           " WHEN '02' THEN 'BURSA' " +
                           " WHEN '03' THEN 'IZMIR' " +
                           " WHEN '04' THEN 'ADANA' " +
                           " WHEN '05' THEN 'ANKARA' " +
                           " ELSE (Case left(cha_srmrkkodu,2) when '99' then 'YUNUS EGEMENOGLU'  when '00' then 'ORTAK CARİ İŞLEMLERİ' Else 'Tanımsız' END) END AS IL        " +
                           " from CARI_HESAP_HAREKETLERI " +
                          " WHERE cha_kod IN (SELECT his_kod FROM MASRAF_HESAPLARI WHERE left(his_isim,3)<>'840') " +
                           " and (cha_belge_tarih BETWEEN CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102))  And Left(cha_srmrkkodu,2) in(" + q + ",'99'" + ")  AND cha_tip=0 and cha_srmrkkodu in ("+smKod+")" +
                        //" and (cha_belge_tarih BETWEEN CONVERT(VARCHAR, '" + strYil + "-01-01', 23) AND CONVERT(VARCHAR, '" + strYil + "-12-'+CAST(dbo.fn_AyKacGun(12, " + strYil + ")AS NVARCHAR),23))  And Left(cha_srmrkkodu,2) in(" + q + ",'00','99'" + ")  AND cha_tip=0 " +
                           " GROUP BY cha_belge_tarih, cha_kod, cha_kasa_hizkod,cha_karsisrmrkkodu, " +
                                  " cha_aratoplam, cha_aciklama, cha_srmrkkodu,cha_evrakno_seri, cha_evrakno_sira, cha_belge_no,cha_satir_no,cha_cari_cins,cha_meblag " +

                    " Union " +//########################################################################################

                     "  SELECT 'Gelir' as tip,cha_belge_tarih,cha_kasa_hizkod as cha_kod, " +
                                   " cha_meblag, cha_aciklama, cha_evrakno_seri, cha_evrakno_sira, cha_belge_no,cha_karsisrmrkkodu as cha_srmrkkodu,dbo.fn_CarininIsminiBul(0,cha_kod) AS cariAdi,    " +
                                   " dbo.fn_SorumlulukMerkeziAdiBul(cha_karsisrmrkkodu)as smAdi,    " +
                            " cha_kasa_hizkod,(SELECT hh.hiz_isim FROM HIZMET_HESAPLARI hh WHERE hh.hiz_kod=cha_kasa_hizkod) masrafAdi, " +
                  "CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN  cha_meblag ELSE  cha_aratoplam END),0) else 0 END AS Toplam, " +
                        //"CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(VARCHAR ,'" + strYil + "-01-01',23) AND CONVERT(VARCHAR ,'" + strYil + "-12-'+CAST(dbo.fn_AyKacGun(12, " + strYil + ")AS NVARCHAR),23)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN  cha_meblag ELSE cha_aratoplam END),0) else 0 END AS Toplam, " +
                        //"CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(VARCHAR ,'" + strYil + "-01-01',23) AND CONVERT(VARCHAR ,'" + strYil + "-01-'+CAST(dbo.fn_AyKacGun(1, " + strYil + ")AS NVARCHAR),23)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN  cha_meblag ELSE cha_aratoplam END),0) else 0 END AS Ocak, " +
                        //"CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(VARCHAR ,'" + strYil + "-02-01',23) AND CONVERT(VARCHAR ,'" + strYil + "-02-'+CAST(dbo.fn_AyKacGun(2, " + strYil + ")AS NVARCHAR),23)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN  cha_meblag ELSE cha_aratoplam END),0) else 0 END AS subat, " +
                        //"CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(VARCHAR ,'" + strYil + "-03-01',23) AND CONVERT(VARCHAR ,'" + strYil + "-01-'+CAST( dbo.fn_AyKacGun(3, " + strYil + ")AS NVARCHAR),23)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN  cha_meblag ELSE cha_aratoplam END),0) else 0 END AS mart, " +
                        //"CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(VARCHAR ,'" + strYil + "-04-01',23) AND CONVERT(VARCHAR ,'" + strYil + "-04-'+CAST( dbo.fn_AyKacGun(4, " + strYil + ")AS NVARCHAR),23)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN  cha_meblag ELSE cha_aratoplam END),0) else 0 END AS nisan, " +
                        //"CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(VARCHAR ,'" + strYil + "-05-01',23) AND CONVERT(VARCHAR ,'" + strYil + "-05-'+CAST( dbo.fn_AyKacGun(5, " + strYil + ")AS NVARCHAR),23)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN  cha_meblag ELSE cha_aratoplam END),0) else 0 END AS mayis, " +
                        //"CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(VARCHAR ,'" + strYil + "-06-01',23) AND CONVERT(VARCHAR ,'" + strYil + "-06-'+CAST( dbo.fn_AyKacGun(6, " + strYil + ")AS NVARCHAR),23)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN  cha_meblag ELSE cha_aratoplam END),0) else 0 END AS haziran, " +
                        //"CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(VARCHAR ,'" + strYil + "-07-01',23) AND CONVERT(VARCHAR ,'" + strYil + "-07-'+CAST( dbo.fn_AyKacGun(7, " + strYil + ")AS NVARCHAR),23)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN  cha_meblag ELSE cha_aratoplam END),0) else 0 END AS temmuz, " +
                        //"CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(VARCHAR ,'" + strYil + "-08-01',23) AND CONVERT(VARCHAR ,'" + strYil + "-08-'+CAST( dbo.fn_AyKacGun(8, " + strYil + ")AS NVARCHAR),23)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN  cha_meblag ELSE cha_aratoplam END),0) else 0 END AS agustos, " +
                        //"CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(VARCHAR ,'" + strYil + "-09-01',23) AND CONVERT(VARCHAR ,'" + strYil + "-09-'+CAST( dbo.fn_AyKacGun(9, " + strYil + ")AS NVARCHAR),23)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN  cha_meblag ELSE cha_aratoplam END),0) else 0 END AS eylul, " +
                        //"CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(VARCHAR ,'" + strYil + "-10-01',23) AND CONVERT(VARCHAR ,'" + strYil + "-10-'+CAST( dbo.fn_AyKacGun(10, " + strYil + ")AS NVARCHAR),23)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN  cha_meblag ELSE cha_aratoplam END),0) else 0 END AS ekim, " +
                        //"CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(VARCHAR ,'" + strYil + "-11-01',23) AND CONVERT(VARCHAR ,'" + strYil + "-11-'+CAST( dbo.fn_AyKacGun(11, " + strYil + ")AS NVARCHAR),23)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN  cha_meblag ELSE cha_aratoplam END),0) else 0 END AS kasim, " +
                        //"CASE WHEN  (cha_belge_tarih BETWEEN CONVERT(VARCHAR ,'" + strYil + "-12-01',23) AND CONVERT(VARCHAR ,'" + strYil + "-12-'+CAST( dbo.fn_AyKacGun(12, " + strYil + ")AS NVARCHAR),23)) THEN isnull(SUM(CASE	WHEN cha_aratoplam = 0 THEN  cha_meblag ELSE cha_aratoplam END),0) else 0 END AS aralik, " +
                               " CASE left(cha_karsisrmrkkodu,2) " +
                           " WHEN '01' THEN 'ISTANBUL' " +
                           " WHEN '02' THEN 'BURSA' " +
                           " WHEN '03' THEN 'IZMIR' " +
                           " WHEN '04' THEN 'ADANA' " +
                           " WHEN '05' THEN 'ANKARA' " +
                           " ELSE (Case left(cha_karsisrmrkkodu,2) when '99' then 'YUNUS EGEMENOGLU'  when '00' then 'ORTAK CARİ İŞLEMLERİ' Else 'Tanımsız' END) END AS IL        " +
                           " from CARI_HESAP_HAREKETLERI " +
                          " WHERE cha_kasa_hizkod IN (SELECT hh.hiz_kod FROM HIZMET_HESAPLARI hh)  " +
                           " and (cha_belge_tarih BETWEEN CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102))  And Left(cha_karsisrmrkkodu,2) in(" + q + ",'99'" + ")  AND cha_tip=0 and cha_karsisrmrkkodu in("+smKod+")" +
                        //" and (cha_belge_tarih BETWEEN CONVERT(VARCHAR, '" + strYil + "-01-01', 23) AND CONVERT(VARCHAR, '" + strYil + "-12-'+CAST(dbo.fn_AyKacGun(12, " + strYil + ")AS NVARCHAR),23))  And Left(cha_karsisrmrkkodu,2) in(" + q + ",'00','99'" + ")  AND cha_tip=0 " +
                           " GROUP BY cha_belge_tarih, cha_kod, cha_kasa_hizkod,cha_karsisrmrkkodu, " +
                                  " cha_aratoplam, cha_aciklama, cha_srmrkkodu,cha_evrakno_seri, cha_evrakno_sira, cha_belge_no,cha_satir_no,cha_cari_cins,cha_meblag ";

                    SqlDataAdapter da = new SqlDataAdapter(sorgu, con);

                    dSRaporlama.giderler.Clear();
                    da.Fill(dSRaporlama.giderler);

                    gridControl1.DataSource = dSRaporlama.giderler;
                }
                else {
                    MessageBox.Show("Arama Kriteri Olarak {Sorumluluk Merkezi} Seçilmedi!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            else
            {
                MessageBox.Show("Arama Kriteri Olarak {il} Seçilmedi!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
                    gridControl1.ExportToExcelOld(raporKaydet.FileName);
                }
            }
        }

        private void GiderlerFormu_Load(object sender, EventArgs e)
        {
            tarih1.Text = "01.01." + DateTime.Now.Year.ToString();
            tarih2.Text = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month).ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.CollapseAllGroups();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ps_ciktiXls();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gridView1.OptionsView.ShowGroupPanel = true;
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gridView1.OptionsView.ShowGroupPanel = false;
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.BestFitColumns();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ExpandAllGroups();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ps_aramaYap(fn_ilKodu(),fn_smCek());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dSRaporlama.giderler.Clear();
        }
    }
}