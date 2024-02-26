using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace EgemenOgluRaporlama
{
    public partial class muvekkilAlacaklari : Form
    {
        public muvekkilAlacaklari()
        {
            InitializeComponent();
        }
        public AnaForm anaFrm { get; set; }
        private string fn_ilKodu()
        {
            string q, q1;
            q = null;
            q1 = null;
            for (int i = 0; i < anaFrm.lbIller.CheckedItems.Count; i++)
            {
                q1 = anaFrm.lbIller.CheckedItems[i].ToString();
                q += q1 + ",";
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
        private void ps_aramaYap(string ilKodlari,string smKodlari)
        {
            if (!string.IsNullOrEmpty(ilKodlari))
            {
                if (!string.IsNullOrEmpty(smKodlari))
                {
                    SqlConnection con = new SqlConnection(Properties.Settings.Default.Cs);
                    con.Open();
                    string q = ilKodlari;
                    string sorgu =
                                               " SELECT cha_kod,dbo.fn_CarininIsminiBul(cha_cari_cins,cha_kod) AS cariAdi, " +
                          "  isnull(SUM(CASE cha_tip WHEN '0' THEN (CASE cha_d_cins WHEN '0' THEN cha_meblag ELSE cha_meblag * cha_d_kur END) END),0) AS borc, " +
                           " isnull(SUM(CASE cha_tip WHEN '1' THEN (CASE cha_d_cins WHEN '0' THEN cha_meblag ELSE cha_meblag * cha_d_kur END) END),0) AS alacak, " +

                           " isnull(SUM(CASE cha_tip WHEN '0' THEN (CASE cha_d_cins WHEN '0' THEN cha_meblag ELSE cha_meblag * cha_d_kur END) END),0) - " +
                                  " isnull(SUM(CASE cha_tip WHEN '1' THEN (CASE cha_d_cins WHEN '0' THEN cha_meblag ELSE cha_meblag * cha_d_kur END) END),0)AS bakiye, " +
                                  " cha_srmrkkodu,dbo.fn_SorumlulukMerkeziIsmi(cha_srmrkkodu) AS smAdi, " +

                                  " CASE substring(cha_kod,(Case left(cha_kod,1) when '1' then 8 else 12 End),2) " +
                                                             " WHEN '01' THEN 'İSTANBUL' " +
                                                             " WHEN '02' THEN 'BURSA' " +
                                                             " WHEN '03' THEN 'İZMİR' " +
                                                             " WHEN '04' THEN 'ADANA' " +
                                                             " WHEN '05' THEN 'ANKARA'  " +
                                                             " WHEN '00' THEN 'Ortak Cari İşlemleri' End As İL,(CASE WHEN len(isnull(ch.cari_grup_kodu,'')) < 2 then dbo.fn_CarininIsminiBul(cha_cari_cins,cha_kod) ELSE ch.cari_grup_kodu END)'GrupKodu',isnull(chu.Avans,0)'Avans'" +
                          
                                                             " FROM  CARI_HESAP_HAREKETLERI INNER JOIN CARI_HESAPLAR ch ON CARI_HESAP_HAREKETLERI.cha_kod = ch.cari_kod " +
                            " LEFT JOIN CARI_HESAPLAR_USER chu ON ch.cari_RECid_RECno = chu.RecID_RECno " +

                             " WHERE (left(cha_kod,3)='120' OR left(cha_kod,7)='950.120') AND right(cha_srmrkkodu,2) not in ('98','99') AND substring(cha_kod,(Case left(cha_kod,1) when '1' then 8 else 12 End),2) in (" + q + ",'00') " +
                           " AND (cha_belge_tarih  BETWEEN CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102)) and cha_srmrkkodu in ("+smKodlari+") " +
                           " GROUP BY cha_kod,cha_cari_cins,cha_srmrkkodu,ch.cari_grup_kodu,chu.Avans";

                    SqlDataAdapter da = new SqlDataAdapter(sorgu, con);

                    dSRaporlama.muvekkilAlacaklari.Clear();
                    da.Fill(dSRaporlama.muvekkilAlacaklari);

                    gridControl1.DataSource = dSRaporlama.muvekkilAlacaklari;
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

        private void muvekkilAlacaklari_Load(object sender, EventArgs e)
        {
            tarih1.Text = "31.12." + (DateTime.Now.Year - 1).ToString();
            tarih2.Text = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month).ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dSRaporlama.muvekkilAlacaklari.Clear();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ps_ciktiXls();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ExpandAllGroups();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.CollapseAllGroups();
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

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ps_aramaYap(fn_ilKodu(),fn_smCek());
        }
    }
}
