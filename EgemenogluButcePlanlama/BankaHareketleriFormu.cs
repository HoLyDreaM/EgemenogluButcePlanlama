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
    public partial class BankaHareketleriFormu : DevExpress.XtraEditors.XtraForm
    {
        public BankaHareketleriFormu()
        {
            InitializeComponent();
        }
        public AnaForm anafrm { get; set; }

        private string fn_tumIlleriCek() {
            string _q, _q1;
            _q = null;
            _q1 = null;
            for (int i = 0; i < anafrm.lbIller.Items.Count; i++)
            {
                _q1 = anafrm.lbIller.GetItemValue(i).ToString();
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
        private void ps_bankaDoldur(string q) {
            if (!string.IsNullOrEmpty(q))
            {
                string sorgu = "SELECT ban_kod, ban_ismi, ban_sube, ban_hesapno, CASE ban_doviz_cinsi WHEN 0 THEN 'TL' WHEN 1 THEN 'USD' WHEN 2 THEN 'EURO' ELSE 'Tanimsiz' END AS Cinsi, ban_RECno FROM BANKALAR " +
                               " WHERE SUBSTRING(ban_kod,11,2) IN (" + q + ") " +
                               " order by ban_kod ";

                using (SqlConnection con1 = new SqlConnection(Properties.Settings.Default["Cs"].ToString()))
                {
                    con1.Open();
                    using (SqlDataAdapter da1 = new SqlDataAdapter(sorgu, con1))
                    {
                        da1.Fill(dSRaporlama.BANKALAR);
                    }

                }
            }
        }

        private void ps_aramaYap(double _euro, double _dolar)
        {
            if (!string.IsNullOrEmpty(bankaKodu.Text))
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.Cs);
                con.Open();

                string sorgu =//102.01.16.001.01.01  
                    "  SELECT cha_srmrkkodu,dbo.fn_SorumlulukMerkeziAdiBul(cha_srmrkkodu) AS sMerkezi,cha_aciklama, " +
                    "   isnull(CASE cha_d_cins  WHEN 0 THEN " +
                    "   sum(CASE cha_tip WHEN 0 then cha_meblag ELSE 0 end) " +
                    "   WHEN 1 THEN     " +
                    "   sum(CASE cha_tip WHEN 0 then cha_meblag * (case " + _dolar.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _dolar.ToString().Replace(",", ".") + " END) ELSE 0 end) " +
                    "   WHEN 2 THEN     " +
                    "   sum(CASE cha_tip WHEN 0 then cha_meblag * (case " + _euro.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _euro.ToString().Replace(",", ".") + " END) ELSE 0 end) " +
                    "   END ,0) AS a, " +

                    "   CASE cha_d_cins  WHEN 0 THEN  " +
                    "   sum(CASE cha_tip WHEN 1 then cha_meblag ELSE 0 end)       " +
                      "   WHEN 1 THEN  " +
                    "   sum(CASE cha_tip WHEN 1 then cha_meblag * (case " + _dolar.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _dolar.ToString().Replace(",", ".") + " END) ELSE 0 end)   " +
                      "   WHEN 2 THEN  " +
                    "   sum(CASE cha_tip WHEN 1 then cha_meblag * (case " + _euro.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _euro.ToString().Replace(",", ".") + " END) ELSE 0 end) END  AS b ,   " +

                    "  	CASE cha_d_cins  WHEN 0 THEN  " +
                    "   (sum(CASE cha_tip WHEN 0 then cha_meblag  ELSE 0 end)  -      " +
                    "   sum(CASE cha_tip WHEN 1 then cha_meblag ELSE 0 end)) " +
                     "    WHEN 1 THEN " +
                    "   (sum(CASE cha_tip WHEN 0 then cha_meblag * (case " + _dolar.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _dolar.ToString().Replace(",", ".") + " END) ELSE 0 end)  -  " +
                    "    sum(CASE cha_tip WHEN 1 then cha_meblag * (case " + _dolar.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _dolar.ToString().Replace(",", ".") + " END) ELSE 0 end))  " +
                     "    WHEN 2 THEN " +
                    "   (sum(CASE cha_tip WHEN 0 then cha_meblag * (case " + _euro.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _euro.ToString().Replace(",", ".") + " END) ELSE 0 end)  -  " +
                    "    sum(CASE cha_tip WHEN 1 then cha_meblag * (case " + _euro.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _euro.ToString().Replace(",", ".") + " END) ELSE 0 end)) end AS c,  " +

                     //  --$ bakite
                      " isnull(CASE  WHEN cha_d_cins = 1 THEN  " +
                      " sum(CASE cha_tip WHEN 0 then cha_meblag  ELSE 0 end) END,0)  AS dolar_a, " +

                      " isnull(CASE  WHEN cha_d_cins = 1 THEN  " +
                      " sum(CASE cha_tip WHEN 1 then cha_meblag  ELSE 0 end) END,0)  AS dolar_b,   " +

                      " isnull(CASE  WHEN cha_d_cins = 1 THEN  " +
                      " (sum(CASE cha_tip WHEN 0 then cha_meblag  ELSE 0 end)  - " +
                      "  sum(CASE cha_tip WHEN 1 then cha_meblag  ELSE 0 end)) End ,0) AS dolar_c,   " +

                      // --€ bakite
                      " isnull(CASE  WHEN cha_d_cins = 2 THEN  " +
                      " sum(CASE cha_tip WHEN 0 then cha_meblag  ELSE 0 end) END,0)  AS euro_a, " +

                      " isnull(CASE  WHEN cha_d_cins = 2 THEN  " +
                      " sum(CASE cha_tip WHEN 1 then cha_meblag  ELSE 0 end) END,0)  AS euro_b,  " +

                      " isnull(CASE  WHEN cha_d_cins = 2 THEN  " +
                      " (sum(CASE cha_tip WHEN 0 then cha_meblag  ELSE 0 end)  - " +
                      " sum(CASE cha_tip WHEN 1 then cha_meblag  ELSE 0 end)) End,0)  AS euro_c, " +

                    " cha_evrakno_seri, cha_evrakno_sira, cha_belge_tarih,cha_belge_no,cha_kod,   " +
              
                    " dbo.fn_CarininIsminiBul(cha_cari_cins,cha_kod) AS karsiHesapAdi," +
                          "  CASE	cha_d_cins    " +
                          "  WHEN 0 THEN 'TL'   " +
                          "  WHEN 1 THEN 'USD'   " +
                          "  WHEN 2 THEN 'EURO'  " +
                          "  ELSE 'Tanimsiz'   " +
                          "  END AS doviz       " +
                          "  ,cha_d_kur,   " +
                           " CASE substring(cha_kod,11,2)   " +
                    " WHEN '04' THEN 'ADANA' " +
                    " WHEN '05' THEN 'ANKARA'  " +
                    " when '02' THEN 'BURSA'  " +
                    " WHEN '01' THEN 'İSTANBUL'  " +
                    " WHEN '03' THEN 'İZMİR' " +
                    " ELSE 'Tanımsız'   " +
                    " END AS il   " +
                    " FROM CARI_HESAP_HAREKETLERI   " +
                        " WHERE     (cha_kod = '" + bankaKodu.Text + "')   " +
                             "  AND (cha_belge_tarih BETWEEN   CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND   " +
                              " CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102))  " +//And cha_evrak_tip in('35','8','33','58')
                         " GROUP BY cha_srmrkkodu, cha_aciklama, cha_d_cins,cha_evrakno_seri,   " +
                         " cha_evrakno_sira, cha_belge_tarih,cha_belge_no,cha_d_cins,cha_d_kur,cha_kod,cha_kasa_hizkod,cha_cari_cins    " +

                          " Union  "+

                     "  SELECT cha_srmrkkodu,dbo.fn_SorumlulukMerkeziAdiBul(cha_srmrkkodu) AS sMerkezi,cha_aciklama,   " +
                    "   isnull(CASE cha_d_cins  WHEN 0 THEN " +
                    "   sum(CASE cha_tip WHEN 1 then cha_meblag ELSE 0 end) " +
                    "   WHEN 1 THEN     " +
                    "   sum(CASE cha_tip WHEN 1 then cha_meblag * (case " + _dolar.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _dolar.ToString().Replace(",", ".") + " END) ELSE 0 end) " +
                    "   WHEN 2 THEN     " +
                    "   sum(CASE cha_tip WHEN 1 then cha_meblag * (case " + _euro.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _euro.ToString().Replace(",", ".") + " END) ELSE 0 end) " +
                    "   END ,0) AS a, " +

                    "   CASE cha_d_cins  WHEN 0 THEN  " +
                    "   sum(CASE cha_tip WHEN 0 then cha_meblag ELSE 0 end)       " +
                      "   WHEN 1 THEN  " +
                    "   sum(CASE cha_tip WHEN 0 then cha_meblag * (case " + _dolar.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _dolar.ToString().Replace(",", ".") + " END) ELSE 0 end)   " +
                      "   WHEN 2 THEN  " +
                    "   sum(CASE cha_tip WHEN 0 then cha_meblag * (case " + _euro.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _euro.ToString().Replace(",", ".") + " END) ELSE 0 end) END  AS b ,   " +

                    "  	CASE cha_d_cins  WHEN 0 THEN  " +
                    "   (sum(CASE cha_tip WHEN 1 then cha_meblag  ELSE 0 end)  -      " +
                    "   sum(CASE cha_tip WHEN 0 then cha_meblag ELSE 0 end)) " +
                     "    WHEN 1 THEN " +
                    "   (sum(CASE cha_tip WHEN 1 then cha_meblag * (case " + _dolar.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _dolar.ToString().Replace(",", ".") + " END) ELSE 0 end)  -  " +
                    "    sum(CASE cha_tip WHEN 0 then cha_meblag * (case " + _dolar.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _dolar.ToString().Replace(",", ".") + " END) ELSE 0 end))  " +
                     "    WHEN 2 THEN " +
                    "   (sum(CASE cha_tip WHEN 1 then cha_meblag * (case " + _euro.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _euro.ToString().Replace(",", ".") + " END) ELSE 0 end)  -  " +
                    "    sum(CASE cha_tip WHEN 0 then cha_meblag * (case " + _euro.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _euro.ToString().Replace(",", ".") + " END) ELSE 0 end)) end AS c,  " +

                       //--$ bakite
                      " isnull(CASE  WHEN cha_d_cins = 1 THEN  " +
                      " sum(CASE cha_tip WHEN 1 then cha_meblag  ELSE 0 end) END,0)  AS dolar_a, " +

                      " isnull(CASE  WHEN cha_d_cins = 1 THEN  " +
                      " sum(CASE cha_tip WHEN 0 then cha_meblag  ELSE 0 end) END,0)  AS dolar_b,   " +

                      "isnull( CASE  WHEN cha_d_cins = 1 THEN  " +
                      " (sum(CASE cha_tip WHEN 1 then cha_meblag  ELSE 0 end)  - " +
                      " sum(CASE cha_tip WHEN 0 then cha_meblag  ELSE 0 end)) End,0)  AS dolar_c,   " +

                       //--€ bakite
                      "isnull( CASE  WHEN cha_d_cins = 2 THEN  " +
                      " sum(CASE cha_tip WHEN 1 then cha_meblag  ELSE 0 end) END,0)  AS euro_a, " +

                      "isnull( CASE  WHEN cha_d_cins = 2 THEN  " +
                      " sum(CASE cha_tip WHEN 0 then cha_meblag  ELSE 0 end) END,0)  AS euro_b,  " +

                      "isnull( CASE  WHEN cha_d_cins = 2 THEN  " +
                      " (sum(CASE cha_tip WHEN 1 then cha_meblag  ELSE 0 end)  - " +
                      " sum(CASE cha_tip WHEN 0 then cha_meblag  ELSE 0 end)) End,0)  AS euro_c,   " +
                         "   cha_evrakno_seri, cha_evrakno_sira, cha_belge_tarih,cha_belge_no,cha_kod,  " +

                    " dbo.fn_CarininIsminiBul(cha_cari_cins,cha_kod) AS karsiHesapAdi," +
                          "  CASE	cha_d_cins    " +
                          "  WHEN 0 THEN 'TL'   " + 
                          "  WHEN 1 THEN 'USD'   " +
                          "  WHEN 2 THEN 'EURO'   " +
                          "  ELSE 'Tanimsiz'   " +
                          "  END AS doviz       " +
                          "  ,cha_d_kur,   " +
                          "  CASE substring(cha_kasa_hizkod,11,2)   " +
                    " WHEN '04' THEN 'ADANA' " +
                    " WHEN '05' THEN 'ANKARA' " +
                    " when '02' THEN 'BURSA' " +
                    " WHEN '01' THEN 'İSTANBUL' " +
                    " WHEN '03' THEN 'İZMİR' " +
                    " ELSE 'Tanımsız'   " +
                    " END AS il   " +
                    " FROM CARI_HESAP_HAREKETLERI   " +
                        " WHERE     (cha_kasa_hizkod = '" + bankaKodu.Text + "')   " +
                              " AND (cha_belge_tarih BETWEEN  CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND   " +
                              "  CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102))   " +// And  cha_evrak_tip in('35','33','29','58','8')
                          " GROUP BY cha_srmrkkodu, cha_aciklama, cha_d_cins,cha_evrakno_seri,   " +
                         " cha_evrakno_sira, cha_belge_tarih,cha_belge_no,cha_d_cins,cha_d_kur,cha_kod,cha_kasa_hizkod,cha_cari_cins ";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, con);

                dSRaporlama.BankaHareketleri.Clear();
                da.Fill(dSRaporlama.BankaHareketleri);

                gridControl1.DataSource = dSRaporlama.BankaHareketleri;          
            }
            else
            {
                MessageBox.Show("Arama Kriteri Olarak {BankaKodu} Seçilmedi!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
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
        private void ps_aramaYap_IleGore(string ilKodlari,string smKodlari,double _dolar,double _euro)
        {
            if (!string.IsNullOrEmpty(ilKodlari))
            {
                if (!string.IsNullOrEmpty(ilKodlari))
                {
                    SqlConnection con = new SqlConnection(Properties.Settings.Default.Cs);
                    con.Open();

                    string sorgu =
                        @" SELECT cha_srmrkkodu,dbo.fn_SorumlulukMerkeziAdiBul(cha_srmrkkodu) AS sMerkezi,cha_aciklama, " +
                        "   isnull(CASE cha_d_cins  WHEN 0 THEN " +
                        "   sum(CASE cha_tip WHEN 0 then cha_meblag ELSE 0 end) " +
                        "   WHEN 1 THEN     " +
                        "   sum(CASE cha_tip WHEN 0 then cha_meblag * (case " + _dolar.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _dolar.ToString().Replace(",", ".") + " END) ELSE 0 end) " +
                        "   WHEN 2 THEN     " +
                        "   sum(CASE cha_tip WHEN 0 then cha_meblag * (case " + _euro.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _euro.ToString().Replace(",", ".") + " END) ELSE 0 end) " +
                        "   END ,0) AS a, " +

                        "   CASE cha_d_cins  WHEN 0 THEN  " +
                        "   sum(CASE cha_tip WHEN 1 then cha_meblag ELSE 0 end)       " +
                          "   WHEN 1 THEN  " +
                        "   sum(CASE cha_tip WHEN 1 then cha_meblag * (case " + _dolar.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _dolar.ToString().Replace(",", ".") + " END) ELSE 0 end)   " +
                          "   WHEN 2 THEN  " +
                        "   sum(CASE cha_tip WHEN 1 then cha_meblag * (case " + _euro.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _euro.ToString().Replace(",", ".") + " END) ELSE 0 end) END  AS b ,   " +

                        "  	CASE cha_d_cins  WHEN 0 THEN  " +
                        "   (sum(CASE cha_tip WHEN 0 then cha_meblag  ELSE 0 end)  -      " +
                        "   sum(CASE cha_tip WHEN 1 then cha_meblag ELSE 0 end)) " +
                         "    WHEN 1 THEN " +
                        "   (sum(CASE cha_tip WHEN 0 then cha_meblag * (case " + _dolar.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _dolar.ToString().Replace(",", ".") + " END) ELSE 0 end)  -  " +
                        "    sum(CASE cha_tip WHEN 1 then cha_meblag * (case " + _dolar.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _dolar.ToString().Replace(",", ".") + " END) ELSE 0 end))  " +
                         "    WHEN 2 THEN " +
                        "   (sum(CASE cha_tip WHEN 0 then cha_meblag * (case " + _euro.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _euro.ToString().Replace(",", ".") + " END) ELSE 0 end)  -  " +
                        "    sum(CASE cha_tip WHEN 1 then cha_meblag * (case " + _euro.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _euro.ToString().Replace(",", ".") + " END) ELSE 0 end)) end AS c,  " +


                         //  --$ bakite
                          " isnull(CASE  WHEN cha_d_cins = 1 THEN  " +
                          " sum(CASE cha_tip WHEN 0 then cha_meblag  ELSE 0 end) END,0)  AS dolar_a, " +

                          " isnull(CASE  WHEN cha_d_cins = 1 THEN  " +
                          " sum(CASE cha_tip WHEN 1 then cha_meblag  ELSE 0 end) END,0)  AS dolar_b,   " +

                          " isnull(CASE  WHEN cha_d_cins = 1 THEN  " +
                          " (sum(CASE cha_tip WHEN 0 then cha_meblag  ELSE 0 end)  - " +
                          "  sum(CASE cha_tip WHEN 1 then cha_meblag  ELSE 0 end)) End ,0) AS dolar_c,   " +

                          // --€ bakite
                          " isnull(CASE  WHEN cha_d_cins = 2 THEN  " +
                          " sum(CASE cha_tip WHEN 0 then cha_meblag  ELSE 0 end) END,0)  AS euro_a, " +

                          " isnull(CASE  WHEN cha_d_cins = 2 THEN  " +
                          " sum(CASE cha_tip WHEN 1 then cha_meblag  ELSE 0 end) END,0)  AS euro_b,  " +

                          " isnull(CASE  WHEN cha_d_cins = 2 THEN  " +
                          " (sum(CASE cha_tip WHEN 0 then cha_meblag  ELSE 0 end)  - " +
                          " sum(CASE cha_tip WHEN 1 then cha_meblag  ELSE 0 end)) End,0)  AS euro_c, " +
                        " cha_evrakno_seri, cha_evrakno_sira, cha_belge_tarih,cha_belge_no,cha_kod,  " +

                      " dbo.fn_CarininIsminiBul(cha_cari_cins,cha_kod) as karsiHesapAdi ," +
                              " CASE	cha_d_cins   " +
                              " WHEN 0 THEN 'TL'  " +
                              " WHEN 1 THEN 'USD'  " +
                              " WHEN 2 THEN 'EURO'  " +
                              " ELSE 'Tanimsiz'  " +
                              " END AS doviz      " +
                              " ,cha_d_kur,  " +

                       " CASE substring(cha_kod,11,2)  " +//left(cha_srmrkkodu,2)
                       " WHEN '04' THEN 'ADANA' " +
                       " WHEN '05' THEN 'ANKARA' " +
                       " when '02' THEN 'BURSA' " +
                       " WHEN '01' THEN 'İSTANBUL' " +
                       " WHEN '03' THEN 'İZMİR' " +
                       " Else 'Tanımsız' " +
                       " END AS il  " +

                      "  FROM CARI_HESAP_HAREKETLERI  " +
                            "   WHERE        cha_kod IN (SELECT ban_kod FROM BANKALAR " +
                      " WHERE SUBSTRING(ban_kod,11,2) IN (" + ilKodlari + ")) " +
                            " AND (cha_belge_tarih BETWEEN CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND  " +
                            " CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102))  and cha_srmrkkodu in("+smKodlari+")" +
                       " GROUP BY cha_srmrkkodu, cha_aciklama, cha_d_cins,cha_evrakno_seri,cha_cari_cins , " +
                       " cha_evrakno_sira, cha_belge_tarih,cha_belge_no,cha_d_cins,cha_d_kur,cha_kasa_hizkod,cha_kod  " +

                    " Union " +//#################################################################################################################

                    " SELECT  cha_karsisrmrkkodu as cha_srmrkkodu ,dbo.fn_SorumlulukMerkeziAdiBul(cha_karsisrmrkkodu) AS sMerkezi,cha_aciklama, " +
                        "   isnull(CASE cha_d_cins  WHEN 0 THEN " +
                        "   sum(CASE cha_tip WHEN 1 then cha_meblag ELSE 0 end) " +
                        "   WHEN 1 THEN     " +
                        "   sum(CASE cha_tip WHEN 1 then cha_meblag * (case " + _dolar.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _dolar.ToString().Replace(",", ".") + " END) ELSE 0 end) " +
                        "   WHEN 2 THEN     " +
                        "   sum(CASE cha_tip WHEN 1 then cha_meblag * (case " + _euro.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _euro.ToString().Replace(",", ".") + " END) ELSE 0 end) " +
                        "   END ,0) AS a, " +

                        "   CASE cha_d_cins  WHEN 0 THEN  " +
                        "   sum(CASE cha_tip WHEN 0 then cha_meblag ELSE 0 end)       " +
                          "   WHEN 1 THEN  " +
                        "   sum(CASE cha_tip WHEN 0 then cha_meblag * (case " + _dolar.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _dolar.ToString().Replace(",", ".") + " END) ELSE 0 end)   " +
                          "   WHEN 2 THEN  " +
                        "   sum(CASE cha_tip WHEN 0 then cha_meblag * (case " + _euro.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _euro.ToString().Replace(",", ".") + " END) ELSE 0 end) END  AS b ,   " +

                        "  	CASE cha_d_cins  WHEN 0 THEN  " +
                        "   (sum(CASE cha_tip WHEN 1 then cha_meblag  ELSE 0 end)  -      " +
                        "   sum(CASE cha_tip WHEN 0 then cha_meblag ELSE 0 end)) " +
                         "    WHEN 1 THEN " +
                        "   (sum(CASE cha_tip WHEN 1 then cha_meblag * (case " + _dolar.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _dolar.ToString().Replace(",", ".") + " END) ELSE 0 end)  -  " +
                        "    sum(CASE cha_tip WHEN 0 then cha_meblag * (case " + _dolar.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _dolar.ToString().Replace(",", ".") + " END) ELSE 0 end))  " +
                         "    WHEN 2 THEN " +
                        "   (sum(CASE cha_tip WHEN 1 then cha_meblag * (case " + _euro.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _euro.ToString().Replace(",", ".") + " END) ELSE 0 end)  -  " +
                        "    sum(CASE cha_tip WHEN 0 then cha_meblag * (case " + _euro.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _euro.ToString().Replace(",", ".") + " END) ELSE 0 end)) end AS c,  " +


                         //  --$ bakite
                          " isnull(CASE  WHEN cha_d_cins = 1 THEN  " +
                          " sum(CASE cha_tip WHEN 0 then cha_meblag  ELSE 0 end) END,0)  AS dolar_a, " +

                          " isnull(CASE  WHEN cha_d_cins = 1 THEN  " +
                          " sum(CASE cha_tip WHEN 1 then cha_meblag  ELSE 0 end) END,0)  AS dolar_b,   " +

                          " isnull(CASE  WHEN cha_d_cins = 1 THEN  " +
                          " (sum(CASE cha_tip WHEN 0 then cha_meblag  ELSE 0 end)  - " +
                          "  sum(CASE cha_tip WHEN 1 then cha_meblag  ELSE 0 end)) End ,0) AS dolar_c,   " +

                          // --€ bakite
                          " isnull(CASE  WHEN cha_d_cins = 2 THEN  " +
                          " sum(CASE cha_tip WHEN 0 then cha_meblag  ELSE 0 end) END,0)  AS euro_a, " +

                          " isnull(CASE  WHEN cha_d_cins = 2 THEN  " +
                          " sum(CASE cha_tip WHEN 1 then cha_meblag  ELSE 0 end) END,0)  AS euro_b,  " +

                          " isnull(CASE  WHEN cha_d_cins = 2 THEN  " +
                          " (sum(CASE cha_tip WHEN 0 then cha_meblag  ELSE 0 end)  - " +
                          " sum(CASE cha_tip WHEN 1 then cha_meblag  ELSE 0 end)) End,0)  AS euro_c, " +
                     " cha_evrakno_seri, cha_evrakno_sira, cha_belge_tarih,cha_belge_no,cha_kod,  " +

                    " dbo.fn_CarininIsminiBul(cha_cari_cins,cha_kod) as karsiHesapAdi, " +

                           " CASE	cha_d_cins   " +
                           " WHEN 0 THEN 'TL'  " +
                           " WHEN 1 THEN 'USD'  " +
                           " WHEN 2 THEN 'EURO'  " +
                           " ELSE 'Tanimsiz'  " +
                           " END AS doviz      " +
                           " ,cha_d_kur,  " +

                    " CASE substring(cha_kasa_hizkod,11,2)  " +
                    " WHEN '04' THEN 'ADANA' " +
                    " WHEN '05' THEN 'ANKARA' " +
                    " when '02' THEN 'BURSA' " +
                    " WHEN '01' THEN 'İSTANBUL' " +
                    " WHEN '03' THEN 'İZMİR' " +
                    " Else 'Tanımsız' " +
                    " END AS il  " +

                   " FROM CARI_HESAP_HAREKETLERI  " +
                   "   WHERE        cha_kasa_hizkod IN (SELECT ban_kod FROM BANKALAR " +
                   " WHERE SUBSTRING(ban_kod,11,2) IN (" + ilKodlari + ")) " +
                   " AND (cha_belge_tarih BETWEEN CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND  " +
                   "  CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102))  and cha_karsisrmrkkodu in("+smKodlari+")" +
                   " GROUP BY cha_karsisrmrkkodu, cha_aciklama, cha_d_cins,cha_evrakno_seri,cha_cari_cins,  " +
                   " cha_evrakno_sira, cha_belge_tarih,cha_belge_no,cha_d_cins,cha_d_kur,cha_kasa_hizkod,cha_kod  ";

                    SqlDataAdapter da = new SqlDataAdapter(sorgu, con);

                    dSRaporlama.BankaHareketleri.Clear();
                    da.Fill(dSRaporlama.BankaHareketleri);

                    gridControl1.DataSource = dSRaporlama.BankaHareketleri;
                }
                else {
                    MessageBox.Show("Arama Kriteri Olarak {Sorumluluk Merkezi} Seçilmedi!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Arama Kriteri Olarak {İL} Seçilmedi!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void BankaHareketleriFormu_Load(object sender, EventArgs e)
        {
            ps_bankaDoldur(fn_tumIlleriCek());
            //this.bANKALARTableAdapter.Fill(this.dSRaporlama.BANKALAR);
            
            tarih1.Text = DateTime.DaysInMonth((DateTime.Now.Year - 1), 1) + ".12." + (DateTime.Now.Year - 1).ToString();
            tarih2.Text = DateTime.DaysInMonth(DateTime.Now.Year, 12).ToString() + ".12." + DateTime.Now.Year.ToString(); 
            
            txtBankaAdi.Text = "";
            txtDoviz.Text = "";
        }

        private void btnTumunuAc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ExpandAllGroups();
        }

        private void btnTumunuKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.CollapseAllGroups();
        }

        private void btnTemizle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dSRaporlama.BankaHareketleri.Clear();
        }
        private void btnAra_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ps_aramaYap(anafrm.euro,anafrm.dolar);

            try
            {
               // ps_aramaYap();
            }
            catch (Exception)
            {

            }
            
        }

        private void btnAktar_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ps_ciktiXls();
        }

        private void bankaKodu_Properties_Closed_1(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            try
            {
                DataRow row = ((DataRowView)bankaKodu.Properties.GetRowByKeyValue(bankaKodu.EditValue)).Row;
                txtBankaAdi.Text = row[1].ToString();
                txtDoviz.Text = row[4].ToString(); 
            }
            catch
            {         
            }  
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gridView1.OptionsView.ShowGroupPanel = true;
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gridView1.OptionsView.ShowGroupPanel = false;
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
              gridView1.BestFitColumns();
        }

        private void btnIleGore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ps_aramaYap_IleGore(fn_ilKodu(),fn_smCek(),anafrm.dolar,anafrm.euro);
            }
            catch (Exception)
            {
                
            }
        
        }

    }
}