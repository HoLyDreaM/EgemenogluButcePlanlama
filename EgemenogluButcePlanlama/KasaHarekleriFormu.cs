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
    public partial class KasaHarekleriFormu : DevExpress.XtraEditors.XtraForm
    {
        public KasaHarekleriFormu()
        {
            InitializeComponent();
        }

        public AnaForm anafrm { get; set; }
        private string fn_tumIlleriCek()
        {
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
        private void ps_kasaDoldur(string q)
        {
            if (!string.IsNullOrEmpty(q))
            {
                string sorgu = "SELECT kas_kod, kas_isim, kas_muh_kod, kas_RECno FROM KASALAR "+
                               " WHERE substring(kas_kod,CASE left(kas_kod,7) WHEN '950.100' THEN 12 WHEN '950.101'THEN 15 ELSE 11 END,2)IN("+q+") "+
                               " order by kas_kod ";

                using (SqlConnection con1 = new SqlConnection(Properties.Settings.Default["Cs"].ToString()))
                {
                    con1.Open();
                    using (SqlDataAdapter da1 = new SqlDataAdapter(sorgu, con1))
                    {
                        da1.Fill(dSRaporlama.KASALAR);
                    }
                }
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
        private void ps_aramaYap(double _dolar,double _euro)
        {
            if (!string.IsNullOrEmpty(txtKasaKodu.Text))
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.Cs);
                con.Open();

                string sorgu =
                   " SELECT cha_srmrkkodu,dbo.fn_SorumlulukMerkeziAdiBul(cha_srmrkkodu) AS sMerkezi,cha_aciklama, " +
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
                    //" CASE LEFT(cha_kod,3)   " +
                    //" WHEN '100' THEN dbo.fn_CarininIsminiBul(4,cha_kod)   " +
                    //" WHEN '102' THEN dbo.fn_CarininIsminiBul(2,cha_kod)  " +
                    //" WHEN '195' THEN dbo.fn_PersFullName(1,cha_kod)  " +
                    //" WHEN '120' THEN dbo.fn_CarininIsminiBul(0,cha_kod)  " +
                    //" ELSE cha_kasa_hizkod END AS karsiHesapAdi,   " +
                     " dbo.fn_CarininIsminiBul(cha_cari_cins,cha_kod) as karsiHesapAdi, " +
                          "  CASE	cha_d_cins    " +
                          "  WHEN 0 THEN 'TL'   " +
                          "  WHEN 1 THEN 'USD'   " +
                          "  WHEN 2 THEN 'EURO'  " +
                          "  ELSE 'Tanimsiz'   " +
                          "  END AS doviz       " +
                          "  ,cha_d_kur,   " +

                     " CASE LEFT(cha_kod,1)  " +
                     "  WHEN 1 THEN  " +
                      " 	CASE substring(cha_kod,11,2)  " +
                        " WHEN '04' THEN 'ADANA'   " +
                        " WHEN '05' THEN 'ANKARA'   " +
                        " when '02' THEN 'BURSA'   " +
                        " WHEN '01' THEN 'İSTANBUL'   " +
                        " WHEN '03' THEN 'İZMİR'   " +
                        " Else 'Tanımsız'  " +
                        " END  " +
                         "  WHEN 3 THEN  " +
                      " 	CASE substring(cha_kod,11,2)  " +
                        " WHEN '04' THEN 'ADANA'   " +
                        " WHEN '05' THEN 'ANKARA'   " +
                        " when '02' THEN 'BURSA'   " +
                        " WHEN '01' THEN 'İSTANBUL'   " +
                        " WHEN '03' THEN 'İZMİR'   " +
                        " Else 'Tanımsız'  " +
                        " END  " +
                        " ELSE  " +
                            "CASE substring(cha_kod,12,2)    " +
                        " WHEN '04' THEN 'ADANA'    " +
                        " WHEN '05' THEN 'ANKARA'    " +
                        " when '02' THEN 'BURSA'    " +
                        " WHEN '01' THEN 'İSTANBUL'    " +
                        " WHEN '03' THEN 'İZMİR'    " +
                        " Else 'Tanımsız'    " +
                        "END   	  " +
                    " END AS il  " +

                    " FROM CARI_HESAP_HAREKETLERI   " +
                        " WHERE     (cha_kod = '" + txtKasaKodu.Text + "')   " +
                             "  AND (cha_belge_tarih BETWEEN  CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND   " +
                              " CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102))  " +
                         " GROUP BY cha_srmrkkodu, cha_aciklama, cha_d_cins,cha_evrakno_seri,cha_cari_cins,   " +
                         " cha_evrakno_sira, cha_belge_tarih,cha_belge_no,cha_d_cins,cha_d_kur,cha_kod,cha_kasa_hizkod    " +

                          " Union  " +

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

                    //" CASE LEFT(cha_kod,3)   " +
                    //" WHEN '100' THEN dbo.fn_CarininIsminiBul(4,cha_kod)   " +
                    //" WHEN '102' THEN dbo.fn_CarininIsminiBul(2,cha_kod)  " +
                    //" WHEN '195' THEN dbo.fn_PersFullName(1,cha_kod)  " +
                    //" WHEN '120' THEN dbo.fn_CarininIsminiBul(0,cha_kod)  " +
                    //" ELSE cha_kasa_hizkod END AS karsiHesapAdi,   " +
                     " dbo.fn_CarininIsminiBul(cha_cari_cins,cha_kod) as karsiHesapAdi, " +
                          "  CASE	cha_d_cins    " +
                          "  WHEN 0 THEN 'TL'   " +
                          "  WHEN 1 THEN 'USD'   " +
                          "  WHEN 2 THEN 'EURO'   " +
                          "  ELSE 'Tanimsiz'   " +
                          "  END AS doviz       " +
                          "  ,cha_d_kur,   " +

                          " CASE LEFT(cha_kasa_hizkod,1)  " +
                     "  WHEN 1 THEN  " +
                      " 	CASE substring(cha_kasa_hizkod,11,2)  " +
                        " WHEN '04' THEN 'ADANA'   " +
                        " WHEN '05' THEN 'ANKARA'   " +
                        " when '02' THEN 'BURSA'   " +
                        " WHEN '01' THEN 'İSTANBUL'   " +
                        " WHEN '03' THEN 'İZMİR'   " +
                        " Else 'Tanımsız'  " +
                        " END  " +
                         "  WHEN 3 THEN  " +
                      " 	CASE substring(cha_kasa_hizkod,11,2)  " +
                        " WHEN '04' THEN 'ADANA'   " +
                        " WHEN '05' THEN 'ANKARA'   " +
                        " when '02' THEN 'BURSA'   " +
                        " WHEN '01' THEN 'İSTANBUL'   " +
                        " WHEN '03' THEN 'İZMİR'   " +
                        " Else 'Tanımsız'  " +
                        " END  " +
                        " ELSE  " +
                            "CASE substring(cha_kasa_hizkod,12,2)    " +
                        " WHEN '04' THEN 'ADANA'    " +
                        " WHEN '05' THEN 'ANKARA'    " +
                        " when '02' THEN 'BURSA'    " +
                        " WHEN '01' THEN 'İSTANBUL'    " +
                        " WHEN '03' THEN 'İZMİR'    " +
                        " Else 'Tanımsız'    " +
                        "END   	  " +
                    " END AS il  " +

                    " FROM CARI_HESAP_HAREKETLERI   " +
                        " WHERE     (cha_kasa_hizkod = '" + txtKasaKodu.Text + "')   " +
                              " AND (cha_belge_tarih BETWEEN  CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND   " +
                              " CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102))   " +
                          " GROUP BY cha_srmrkkodu, cha_aciklama, cha_d_cins,cha_evrakno_seri, cha_cari_cins,  " +
                         " cha_evrakno_sira, cha_belge_tarih,cha_belge_no,cha_d_cins,cha_d_kur,cha_kod,cha_kasa_hizkod ";


                SqlDataAdapter da = new SqlDataAdapter(sorgu, con);

                dSRaporlama.kasaHaraketleri.Clear();
                da.Fill(dSRaporlama.kasaHaraketleri);

                gridControl1.DataSource = dSRaporlama.kasaHaraketleri;
            }
            else
            {
                MessageBox.Show("Arama Kriteri Olarak {Kasa Kodu} Seçilmedi!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        
        private void ps_aramaYap_IleGore(string ilKodlari,string smKodlari,double _dolar,double _euro)
        {
            if (!string.IsNullOrEmpty(ilKodlari))
            {
                if (!string.IsNullOrEmpty(smKodlari))
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

                       //" CASE LEFT(cha_kod,3)  " +
                        //" WHEN '100' THEN dbo.fn_CarininIsminiBul(4,cha_kod)  " +
                        //" WHEN '102' THEN dbo.fn_CarininIsminiBul(2,cha_kod) " +
                        //" WHEN '195' THEN dbo.fn_PersFullName(1,cha_kod) " +
                        //" WHEN '120' THEN dbo.fn_CarininIsminiBul(0,cha_kod) " +
                        //" ELSE cha_kasa_hizkod END AS karsiHesapAdi,  " +
                        " dbo.fn_CarininIsminiBul(cha_cari_cins,cha_kod) as karsiHesapAdi, " +
                              " CASE	cha_d_cins   " +
                              " WHEN 0 THEN 'TL'  " +
                              " WHEN 1 THEN 'USD'  " +
                              " WHEN 2 THEN 'EURO'  " +
                              " ELSE 'Tanimsiz'  " +
                              " END AS doviz      " +
                              " ,cha_d_kur,  " +

                        " CASE LEFT(cha_kod,1)  " +
                         "  WHEN 1 THEN  " +
                          " 	CASE substring(cha_kod,11,2)  " +
                            " WHEN '04' THEN 'ADANA'   " +
                            " WHEN '05' THEN 'ANKARA'   " +
                            " when '02' THEN 'BURSA'   " +
                            " WHEN '01' THEN 'İSTANBUL'   " +
                            " WHEN '03' THEN 'İZMİR'   " +
                            " Else 'Tanımsız'  " +
                            " END  " +
                             "  WHEN 3 THEN  " +
                          " 	CASE substring(cha_kod,11,2)  " +
                            " WHEN '04' THEN 'ADANA'   " +
                            " WHEN '05' THEN 'ANKARA'   " +
                            " when '02' THEN 'BURSA'   " +
                            " WHEN '01' THEN 'İSTANBUL'   " +
                            " WHEN '03' THEN 'İZMİR'   " +
                            " Else 'Tanımsız'  " +
                            " END  " +
                            " ELSE  " +
                                "CASE substring(cha_kod,12,2)    " +
                            " WHEN '04' THEN 'ADANA'    " +
                            " WHEN '05' THEN 'ANKARA'    " +
                            " when '02' THEN 'BURSA'    " +
                            " WHEN '01' THEN 'İSTANBUL'    " +
                            " WHEN '03' THEN 'İZMİR'    " +
                            " Else 'Tanımsız'    " +
                            "END   	  " +
                        " END AS il  " +

                      "  FROM CARI_HESAP_HAREKETLERI  " +
                         "   WHERE     (cha_kod) IN (SELECT kas_kod FROM KASALAR " +
                                                           " WHERE   Case WHEN LEFT(kas_kod,3)='100' then substring(kas_kod,11,3) ELSE  substring(kas_kod,12,3) END IN (" + ilKodlari + "))  " +
                            " AND (cha_belge_tarih BETWEEN CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND  " +
                            " CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102))  and cha_srmrkkodu IN(" + smKodlari + ") " +
                       " GROUP BY cha_srmrkkodu, cha_aciklama, cha_d_cins,cha_evrakno_seri, cha_cari_cins, " +
                       " cha_evrakno_sira, cha_belge_tarih,cha_belge_no,cha_d_cins,cha_d_kur,cha_kasa_hizkod,cha_kod  " +

                       " Union " +//####################################################################################

                       " SELECT cha_srmrkkodu,dbo.fn_SorumlulukMerkeziAdiBul(cha_srmrkkodu) AS sMerkezi,cha_aciklama, " +
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
                        " cha_evrakno_seri, cha_evrakno_sira, cha_belge_tarih,cha_belge_no,cha_kod,  " +

                       //" CASE LEFT(cha_kod,3)  " +
                        //" WHEN '100' THEN dbo.fn_CarininIsminiBul(4,cha_kod)  " +
                        //" WHEN '102' THEN dbo.fn_CarininIsminiBul(2,cha_kod) " +
                        //" WHEN '195' THEN dbo.fn_PersFullName(1,cha_kod) " +
                        //" WHEN '120' THEN dbo.fn_CarininIsminiBul(0,cha_kod) " +
                        //" ELSE cha_kasa_hizkod END AS karsiHesapAdi,  " +
                        " dbo.fn_CarininIsminiBul(cha_cari_cins,cha_kod) as karsiHesapAdi, " +

                              " CASE	cha_d_cins   " +
                              " WHEN 0 THEN 'TL'  " +
                              " WHEN 1 THEN 'USD'  " +
                              " WHEN 2 THEN 'EURO'  " +
                              " ELSE 'Tanimsiz'  " +
                              " END AS doviz      " +
                              " ,cha_d_kur,  " +

                         " CASE LEFT(cha_kasa_hizkod,1)  " +
                         "  WHEN 1 THEN  " +
                          " 	CASE substring(cha_kasa_hizkod,11,2)  " +
                            " WHEN '04' THEN 'ADANA'   " +
                            " WHEN '05' THEN 'ANKARA'   " +
                            " when '02' THEN 'BURSA'   " +
                            " WHEN '01' THEN 'İSTANBUL'   " +
                            " WHEN '03' THEN 'İZMİR'   " +
                            " Else 'Tanımsız'  " +
                            " END  " +
                             "  WHEN 3 THEN  " +
                          " 	CASE substring(cha_kasa_hizkod,11,2)  " +
                            " WHEN '04' THEN 'ADANA'   " +
                            " WHEN '05' THEN 'ANKARA'   " +
                            " when '02' THEN 'BURSA'   " +
                            " WHEN '01' THEN 'İSTANBUL'   " +
                            " WHEN '03' THEN 'İZMİR'   " +
                            " Else 'Tanımsız'  " +
                            " END  " +
                            " ELSE  " +
                                "CASE substring(cha_kasa_hizkod,12,2)    " +
                            " WHEN '04' THEN 'ADANA'    " +
                            " WHEN '05' THEN 'ANKARA'    " +
                            " when '02' THEN 'BURSA'    " +
                            " WHEN '01' THEN 'İSTANBUL'    " +
                            " WHEN '03' THEN 'İZMİR'    " +
                            " Else 'Tanımsız'    " +
                            "END   	  " +
                        " END AS il  " +

                       //WHEN LEFT(kas_kod,3)='100' then
                        //substring(kas_kod,11,3) ELSE  substring(kas_kod,12,3) END  IN ('01','02','03') 
                      "  FROM CARI_HESAP_HAREKETLERI  " +
                      "   WHERE     (cha_kasa_hizkod) IN (SELECT kas_kod FROM KASALAR " +
                                                           " WHERE   Case WHEN LEFT(kas_kod,3)='100' then substring(kas_kod,11,3) ELSE  substring(kas_kod,12,3) END IN (" + ilKodlari + "))  " +
                       " AND (cha_belge_tarih BETWEEN CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) and " +
                       " CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102)) and cha_srmrkkodu in (" + smKodlari + ")" +
                       " GROUP BY cha_srmrkkodu, cha_aciklama, cha_d_cins,cha_evrakno_seri,cha_cari_cins,  " +
                       " cha_evrakno_sira, cha_belge_tarih,cha_belge_no,cha_d_cins,cha_d_kur,cha_kasa_hizkod,cha_kod  ";


                    SqlDataAdapter da = new SqlDataAdapter(sorgu, con);

                    dSRaporlama.kasaHaraketleri.Clear();
                    da.Fill(dSRaporlama.kasaHaraketleri);

                    gridControl1.DataSource = dSRaporlama.kasaHaraketleri;
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
        private string fn_ilKodu()
        {
            string q, q1;
            q = null;
            q1 = null;
            for (int i = 0; i < anafrm.lbIller.CheckedItems.Count; i++)
            {
                q1 = anafrm.lbIller.CheckedItems[i].ToString();
                q += ("'"+ q1 + "',");
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

        private void KasaHarekleriFormu_Load(object sender, EventArgs e)
        {
            ps_kasaDoldur(fn_tumIlleriCek());
            //this.kASALARTableAdapter.Fill(this.dSRaporlama.KASALAR);
            tarih1.Text = DateTime.DaysInMonth((DateTime.Now.Year-1),1)+".12." + (DateTime.Now.Year-1).ToString();
            tarih2.Text = DateTime.DaysInMonth(DateTime.Now.Year, 12).ToString() + ".12." + DateTime.Now.Year.ToString();
        }

        private void btnTumunuAc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ExpandAllGroups();
        }

        private void btnTumunuKapa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.CollapseAllGroups();
        }

        private void btnYenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dSRaporlama.kasaHaraketleri.Clear();
        }

        private void btnAktar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ps_ciktiXls();
        }

        private void txtKasaKodu_Properties_Closed_1(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            try
            {
                DataRow row = ((DataRowView)txtKasaKodu.Properties.GetRowByKeyValue(txtKasaKodu.EditValue)).Row;
                txtKasaadi.Text = row[1].ToString();
            }
            catch
            {
 
            }       
        }

        private void btnAra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ps_aramaYap(anafrm.dolar,anafrm.euro);
            }
            catch (Exception)
            {
            }
            
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gridView1.OptionsView.ShowGroupPanel = true;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gridView1.OptionsView.ShowGroupPanel = false;
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.BestFitColumns();
        }

        private void btnIleGoreSorgula_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ps_aramaYap_IleGore(fn_ilKodu(), fn_smCek(), anafrm.dolar, anafrm.euro);
            }
            catch 
            {

            }
       
        }
    }
}