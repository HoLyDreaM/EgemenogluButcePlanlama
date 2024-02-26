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
    public partial class MuvekkilUcretleriFormu : DevExpress.XtraEditors.XtraForm
    {
        public MuvekkilUcretleriFormu()
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
        private void ps_aramaYap(string ilKodlari,string somKod, double dolar,double euro)
        {
            if (!string.IsNullOrEmpty(ilKodlari))
            {
                if (!string.IsNullOrEmpty(somKod))
                {
                    SqlConnection con = new SqlConnection(Properties.Settings.Default.Cs);
                    con.Open();
                    string q = ilKodlari;
                    string sorgu =
                          " SELECT   " +
                                " CASE LEFT(cha_srmrkkodu,2)     " +
                                       "  WHEN '01' THEN 'ISTANBUL'     " +
                                       "  WHEN '02' THEN 'BURSA'     " +
                                       "  WHEN '03' THEN 'IZMIR'     " +
                                       "  WHEN '04' THEN 'ADANA'     " +
                                       "  WHEN '05' THEN 'ANKARA'	       " +
                                       "  ELSE 'TANIMSIZ'     " +
                                    " END AS IL,		     " +
                                " cha_belge_tarih,cha_kod,dbo.fn_CarininIsminiBul(cha_cari_cins,cha_kod) AS cariAdi ,     " +
                                " dbo.fn_SorumlulukMerkeziAdiBul(cha_srmrkkodu) AS Sm_adi,cha_kasa_hizkod,dbo.fn_CarininIsminiBul(CASE WHEN (left(cha_kasa_hizkod,3)='100' OR left(cha_kasa_hizkod,7)='950.100') THEN 4 ELSE 2 END ,cha_kasa_hizkod)AS hesapIsmi,   " +
                                " CASE cha_d_cins WHEN 0 THEN 'TL'     " +
                                                " WHEN 1 THEN 'USD'     " +
                                                " WHEN 2 THEN 'EURO' END AS Doviz,cha_d_kur,     " +

                                           " (ISNULL( CASE cha_tip WHEN 1 THEN      " +
                                           "  (CASE cha_d_cins      " +
                                           "  WHEN 0 THEN cha_meblag     " +
                                           "  WHEN 1 THEN cha_meblag * (CASE    " + dolar.ToString().Replace(",", ".") + "    WHEN 0 THEN cha_d_kur ELSE    " + dolar.ToString().Replace(",", ".") + "    END)     " +
                                           "  WHEN 2 THEN cha_meblag * (CASE    " + euro.ToString().Replace(",", ".") + "    WHEN 0 THEN cha_d_kur ELSE    " + euro.ToString().Replace(",", ".") + "    END)       " +
                                           "  END)END,0) -     " +
                                           "   ISNULL( CASE cha_tip WHEN 0 THEN      " +
                                           "  (CASE cha_d_cins      " +
                                           "  WHEN 0 THEN cha_meblag     " +
                                           "  WHEN 1 THEN cha_meblag * (CASE      " + dolar.ToString().Replace(",", ".") + "   WHEN 0 THEN cha_d_kur ELSE      " + dolar.ToString().Replace(",", ".") + "    END)     " +
                                           "  WHEN 2 THEN cha_meblag * (CASE      " + euro.ToString().Replace(",", ".") + "    WHEN 0 THEN cha_d_kur ELSE     " + euro.ToString().Replace(",", ".") + "     END)      " +
                                           "  END)END,0)) AS bakiye,     " +

                                            " isnull(CASE WHEN cha_d_cins =1 THEN cha_meblag END ,0)AS d_bakiye,     " +
                                            " isnull(CASE WHEN cha_d_cins =2 THEN cha_meblag END ,0)AS e_bakiye,     " +

                                " cha_aciklama,cha_srmrkkodu     " +
                                " FROM CARI_HESAP_HAREKETLERI WHERE (((left(cha_kasa_hizkod,3)IN('100','102') OR left(cha_kasa_hizkod,7)IN('950.100','950.102'))) and  (left(cha_kod,3)='120' OR left(cha_kod,7)='950.120'))" +
                        //"             Or   (((left(cha_kod,3)IN('100','102') OR left(cha_kod,7)IN('950.100','950.102'))) and  (left(cha_kasa_hizkod,3)='120' OR left(cha_kasa_hizkod,7)='950.120')))" +
                    " and left(cha_srmrkkodu,2) IN(" + ilKodlari + ") AND (cha_belge_tarih BETWEEN CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102)) and cha_srmrkkodu in (" + somKod + ")";

                    SqlDataAdapter da = new SqlDataAdapter(sorgu, con);

                    dSRaporlama.muvekkiller.Clear();
                    da.Fill(dSRaporlama.muvekkiller);

                    gridControl1.DataSource = dSRaporlama.muvekkiller;
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

        private void btnTumunuKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.CollapseAllGroups();
        }

        private void btnTumunuAc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ExpandAllGroups();
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ps_ciktiXls();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gridView1.OptionsView.ShowGroupPanel = true;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gridView1.OptionsView.ShowGroupPanel = false;
        }

        private void MuvekkilUcretleriFormu_Load(object sender, EventArgs e)
        {

            tarih1.Text = "01." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString();
            tarih2.Text = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month).ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString();
        }

        private void btnTemizle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dSRaporlama.muvekkiller.Clear();
        }

        private void btnSorgula_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ps_aramaYap(fn_ilKodu(),fn_smCek(),anafrm.dolar,anafrm.euro);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.BestFitColumns();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

    }
}