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
    public partial class CekSenet : DevExpress.XtraEditors.XtraForm
    {
        public CekSenet()
        {
            InitializeComponent();
        }
        public AnaForm anaFrm{get;set;}

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
        private void ps_aramaYap(string ilKodlari, string smKodlari, double _euro, double _dolar)
        {
            if (!string.IsNullOrEmpty(ilKodlari) || !string.IsNullOrEmpty(smKodlari))
            {
        
                SqlConnection con = new SqlConnection(Properties.Settings.Default.Cs);
                con.Open();
                string q = ilKodlari;
                string sorgu = "SELECT TOP 100 PERCENT " +
                           " dbo.fn_CekSenetKisa(sck_tip)'TİPİ' ,  " +
                           " CASE  SUBSTRING(sck_sahip_cari_kodu,(CASE LEFT(sck_sahip_cari_kodu,3) WHEN '950' THEN 12 ELSE 8 END),2) WHEN '01' THEN 'İSTANBUL'   " +
                                                                                   " WHEN '02' THEN 'BURSA'   " +
                                                                                   " WHEN '03' THEN 'İZMİR'   " +
                                                                                   " WHEN '04' THEN 'ADANA'   " +
                                                                                   " WHEN '05' THEN 'ANKARA'   " +
                                                                                   " ELSE 'TANIMSIZ' END  AS İL, " +
                           " sck_srmmrk'SM Kodu', " +
                           " dbo.fn_SorumlulukMerkeziIsmi(sck_srmmrk)'SM Adi', " +
                           " dbo.fn_CekSenetPos(sck_sonpoz,0)'SON POZİSYON', " +
                           " sck_refno 'REFERANS', " +
                           " sck_sahip_cari_kodu'C/H Kod',  " +
                           " dbo.fn_CarininIsminiBul(sck_sahip_cari_cins,sck_sahip_cari_kodu)'C/H Adı', " +
                           " sck_nerede_cari_kodu'Ilk Pozisyon C/H Kod', " +
                           " dbo.fn_CarininIsminiBul(sck_nerede_cari_cins,sck_nerede_cari_kodu)'lk Pozisyon C/H Adı', " +
                           " sck_no 'ÇEK NO', " +
                           " sck_vade 'VADE TARİHİ', " +

                           " (CASE sck_doviz  "+
                           "  WHEN 0 THEN sck_tutar "+
                           "  WHEN 1 THEN sck_tutar *  (case " + _dolar.ToString().Replace(",", ".") + " WHEN 0 THEN sck_doviz ELSE  " + _dolar.ToString().Replace(",", ".") + " END) " + // --USD 
                           "  WHEN 2 THEN sck_tutar *  (case " + _euro.ToString().Replace(",", ".") + " WHEN 0 THEN sck_doviz ELSE  " + _euro.ToString().Replace(",", ".") + " END)  " +//--Euro
                           " ELSE 0 END) 'TUTAR' , " +
                           " sck_tutar 'ORJ_TUTAR' , " +
                           //" sck_tutar 'TUTAR' , " +

                           " (CASE sck_doviz  " +
                           "  WHEN 0 THEN sck_odenen " +
                           "  WHEN 1 THEN sck_odenen *  (case " + _dolar.ToString().Replace(",", ".") + " WHEN 0 THEN sck_doviz ELSE  " + _dolar.ToString().Replace(",", ".") + " END) " + // --USD 
                           "  WHEN 2 THEN sck_odenen *  (case " + _euro.ToString().Replace(",", ".") + " WHEN 0 THEN sck_doviz ELSE  " + _euro.ToString().Replace(",", ".") + " END)  " +//--Euro
                           " ELSE 0 END) 'ÖDENEN' , " +
                           //" sck_odenen 'ÖDENEN', " +
                           " dbo.fn_DovizIsmi(sck_doviz) 'DÖVİZ', " +
                           " sck_doviz_kur 'DÖVİZ KURU', " +
                                
                           " (CASE sck_doviz  "+
                           "  WHEN 0 THEN sck_tutar "+
                           "  WHEN 1 THEN sck_tutar *  (case " + _dolar.ToString().Replace(",", ".") + " WHEN 0 THEN sck_doviz ELSE  " + _dolar.ToString().Replace(",", ".") + " END) " + // --USD 
                           "  WHEN 2 THEN sck_tutar *  (case " + _euro.ToString().Replace(",", ".") + " WHEN 0 THEN sck_doviz ELSE  " + _euro.ToString().Replace(",", ".") + " END)  " +//--Euro
                           " ELSE 0 END) - "+
                           "(CASE sck_doviz  " +
                           "  WHEN 0 THEN sck_odenen " +
                           "  WHEN 1 THEN sck_odenen *  (case " + _dolar.ToString().Replace(",", ".") + " WHEN 0 THEN sck_doviz ELSE  " + _dolar.ToString().Replace(",", ".") + " END) " + // --USD 
                           "  WHEN 2 THEN sck_odenen *  (case " + _euro.ToString().Replace(",", ".") + " WHEN 0 THEN sck_doviz ELSE  " + _euro.ToString().Replace(",", ".") + " END)  " +//--Euro
                           " ELSE 0 END) 'KALAN MİKTAR', " +

                           //" sck_tutar-sck_odenen 'KALAN MİKTAR' , " +
                           " dbo.fn_gunfarkibul(sck_vade,Getdate())'GÜN'    " +
                           " FROM dbo.ODEME_EMIRLERI WITH (NOLOCK) " +
                           " WHERE sck_vade BETWEEN CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "',102) AND CONVERT(DATETIME,'" + tarih2.Value.ToString("yyyy-MM-dd") + "',102) AND sck_srmmrk IN ("+smKodlari+") " +
                           " ORDER BY sck_no ";

                //string sorgu = @"SELECT sck_vade,sck_refno,dbo.fn_CarininIsminiBul(sck_sahip_cari_cins,sck_sahip_cari_kodu)AS sck_borclu,dbo.fn_DovizSembolu(sck_doviz) AS sck_doviz, " +
                //               " sck_doviz_kur,sck_tutar,sck_srmmrk, " +
                //               " dbo.fn_SorumlulukMerkeziIsmi(sck_srmmrk) AS sm_adi,   " +
                //               " CASE  left(sck_srmmrk,2) WHEN '01' THEN 'İSTANBUL'   " +
                //                                        " WHEN '02' THEN 'BURSA'   " +
                //                                        " WHEN '03' THEN 'İZMİR'   " +
                //                                        " WHEN '04' THEN 'ADANA'   " +
                //                                        " WHEN '05' THEN 'ANKARA'   " +
                //                                        " ELSE 'TANIMSIZ' END  AS İL, " +
                //               " sck_sahip_cari_kodu,sck_nerede_cari_kodu " +
                //               " FROM  ODEME_EMIRLERI oe   " +
                //               " WHERE (left(sck_sahip_cari_kodu,3)='120' OR left(sck_sahip_cari_kodu,7)='950.120') AND   " +
                //               " (LEFT(sck_nerede_cari_kodu,3)='101' OR LEFT(sck_nerede_cari_kodu,7)='950.101')    " +
                //               " AND (sck_vade BETWEEN CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102)) " +
                //               "  AND LEFT(sck_srmmrk,2) IN(" + q + ")  " +
                //              //convert(VARCHAR,*****,102)
                //                " UNION " +

                //                " SELECT dbo.fn_OpVadeTarih(cha_vade,cha_tarihi)AS sck_vade,cha_trefno AS sck_refno,dbo.fn_CarininIsminiBul(cha_cari_cins,cha_kod) AS sck_borclu,dbo.fn_DovizSembolu(cha_d_cins) AS sck_doviz,cha_d_kur AS sck_doviz_kur, " +
                //                " cha_meblag AS sck_tutar,cha_srmrkkodu AS sck_srmmrk,dbo.fn_SorumlulukMerkeziIsmi(cha_srmrkkodu) AS sm_adi, " +
                //                " CASE  left(cha_srmrkkodu,2) WHEN '01' THEN 'İSTANBUL'   " +
                //                                        " WHEN '02' THEN 'BURSA'   " +
                //                                        " WHEN '03' THEN 'İZMİR'   " +
                //                                        " WHEN '04' THEN 'ADANA'   " +
                //                                        " WHEN '05' THEN 'ANKARA'   " +
                //                                        " ELSE 'TANIMSIZ' END  AS İL,cha_kod AS sck_sahip_cari_kodu ,cha_kasa_hizkod AS sck_nerede_cari_kodu " +

                //               " FROM CARI_HESAP_HAREKETLERI " +
                //               " WHERE cha_evrak_tip='4' AND cha_tip='1' AND left(cha_srmrkkodu,2) IN(" + q + ")  AND (cha_tarihi BETWEEN CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102)) and cha_srmrkkodu in("+smKodlari+")";
                                   
                                    // " AND (sck_vade BETWEEN CONVERT(VARCHAR,CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102),23) AND CONVERT(VARCHAR,CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102),23)) AND LEFT(sck_srmmrk,2) IN(" + q + ") ";
	 

                                                SqlDataAdapter da = new SqlDataAdapter(sorgu, con);

                                                dSRaporlama.CekSenet.Clear();
                                                da.Fill(dSRaporlama.CekSenet);

                                                gridControl1.DataSource = dSRaporlama.CekSenet;
                                            }
                                            else
                                            {
                                                MessageBox.Show("Arama Kriteri Olarak {il},{Sorumluluk Merkezi} Seçilmedi!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            }
        }
        private string fn_ilKodu()
        {
            string q, q1;
            q = null;
            q1 = null;
            for (int i = 0; i < anaFrm.lbIller.CheckedItems.Count; i++)
            {
                q1 = anaFrm.lbIller.CheckedItems[i].ToString();
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
            for (int i = 0; i < anaFrm.lbSm.CheckedItems.Count; i++)
            {
                _q1 = anaFrm.lbSm.CheckedItems[i].ToString();
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
        private void CekSenet_Load(object sender, EventArgs e)
        {
            tarih1.Text = "01.01." + DateTime.Now.Year.ToString();
            tarih2.Text = "01.01." + (DateTime.Now.Year +10).ToString();//DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month).ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString();
        }

        private void txtKasaKodu_Properties_Closed_1(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {

        }

        private void btnExcelAktar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ps_ciktiXls();
        }

        private void btnTumunuAc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ExpandAllGroups();
        }

        private void btnTumunuKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.CollapseAllGroups();
        }

        private void btnGrupAc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gridView1.OptionsView.ShowGroupPanel = true;
        }

        private void btnGrupKapa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gridView1.OptionsView.ShowGroupPanel = false;
        }

        private void btnEnUygunGenislik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.BestFitColumns();
        }

        private void btnSorgula_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ps_aramaYap(fn_ilKodu(), fn_smCek(), anaFrm.euro, anaFrm.dolar);
        }

        private void btnTemizle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.dSRaporlama.CekSenet.Clear();
        }
    }
}