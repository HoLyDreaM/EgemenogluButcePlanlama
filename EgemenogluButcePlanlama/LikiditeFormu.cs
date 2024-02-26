using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Data.Sql;
namespace EgemenOgluRaporlama
{
    public partial class LikiditeFormu : DevExpress.XtraEditors.XtraForm
    {
        public LikiditeFormu()
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

        private void ps_aramaYap(string ilKodlari,string smKodlari,double _euro, double _dolar)
        {
            if (!string.IsNullOrEmpty(ilKodlari))
            {
                if (!string.IsNullOrEmpty(smKodlari))
                {
                    SqlConnection con = new SqlConnection(Properties.Settings.Default.Cs);
                    con.Open();
                    string q = ilKodlari;

                    string sorgu = " select( " +
                   "  ISNULL((SELECT( " +
                   " SELECT SUM(CASE cha_tip WHEN 1 THEN  " +
                   "    -1*(CASE cha_d_cins " +
                    "   WHEN 0 THEN cha_meblag " +
                     "  WHEN 1 THEN cha_meblag *  (case " + _dolar.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _dolar.ToString().Replace(",", ".") + " END) " + // --USD 
                      " WHEN 2 THEN cha_meblag *  (case " + _euro.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _euro.ToString().Replace(",", ".") + " END)  " +//--Euro
                      " ELSE 0 END) " +

                   " ELSE  " + //--cha_tip
                      " (CASE cha_d_cins " +
                      " WHEN 0 THEN cha_meblag " +
                      " WHEN 1 THEN cha_meblag * (case " + _dolar.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _dolar.ToString().Replace(",", ".") + " END)  " +// --USD
                      " WHEN 2 THEN cha_meblag * (case " + _euro.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _euro.ToString().Replace(",", ".") + " END)  " +//--Euro
                      " ELSE 0 END) " +
                   " END)AS a " +
                   " FROM CARI_HESAP_HAREKETLERI " +

                   " WHERE cha_srmrkkodu=sm.som_kod       AND (left(cha_kod,3)IN('100','102') OR left(cha_kod,7)IN('950.100'))))" +

                   " + " +

                   " (SELECT( " +
                   " SELECT SUM(CASE cha_tip WHEN 0 THEN  " +
                     "  -1*(CASE cha_d_cins " +
                     "  WHEN 0 THEN cha_meblag " +
                     "  WHEN 1 THEN cha_meblag * (case " + _dolar.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _dolar.ToString().Replace(",", ".") + " END)  " +// --USD
                     "  WHEN 2 THEN cha_meblag * (case " + _euro.ToString().Replace(",", ".") + "WHEN 0 THEN cha_d_kur ELSE  " + _euro.ToString().Replace(",", ".") + " END) " +//--Euro  
                     "  ELSE 0 END) " +

                   " ELSE  " +//--cha_tip
                      " (CASE cha_d_cins " +
                      " WHEN 0 THEN cha_meblag " +
                      " WHEN 1 THEN cha_meblag * (case " + _dolar.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _dolar.ToString().Replace(",", ".") + " END)  " +//--USD
                      " WHEN 2 THEN cha_meblag * (case " + _euro.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _euro.ToString().Replace(",", ".") + " END)   " +//--Euro 
                      " ELSE 0 END) " +
                   " END)AS a " +
                   " FROM CARI_HESAP_HAREKETLERI  " +
                   " WHERE cha_karsisrmrkkodu=sm.som_kod AND (left(cha_kasa_hizkod,3)IN('100','102') OR left(cha_kasa_hizkod,7)IN('950.100')))),0))AS b,  " +
                        //----------------
                     " CASE LEFT(sm.som_kod,2)  " +
                     " WHEN '01' THEN 'ISTANBUL' " +
                     " WHEN '02' THEN 'BURSA' " +
                     " WHEN '03' THEN 'IZMIR' " +
                     " WHEN '04' THEN 'ADANA' " +
                     " WHEN '05' THEN 'ANKARA' " +
                     " Else (Case left(sm.som_kod,2) when '99' then 'YUNUS EGEMENOGLU'  when '00' then 'ORTAK CARİ İŞLEMLERİ' when '98' then 'Masraf' Else 'Tanımsız' END) " +//when '98' then 'Masraf'
                     " END AS il,sm.som_kod, " +

                     " sm.som_isim , " +
                     " CASE RIGHT(sm.som_kod,2) " +
                     " WHEN '99' THEN 'Vekaleten Tahsilat' " +
                     " WHEN '98' THEN 'Masraf' " +
                     " ELSE 'Ücret' " +
                     " END AS kasaTuru " +
                   " FROM SORUMLULUK_MERKEZLERI AS sm  " +
                             " WHERE left(sm.som_kod,2) IN (" + ilKodlari + ",'98') And sm.som_kod in(" + fn_smCek() + ")" +
                   "Order by sm.som_kod"; //,'99','00','',' '

                    SqlDataAdapter da = new SqlDataAdapter(sorgu, con);

                    dSRaporlama.LikiditeRaporu.Clear();
                    da.Fill(dSRaporlama.LikiditeRaporu);

                    gridControl1.DataSource = dSRaporlama.LikiditeRaporu;
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
        //string sorgu = " select( " +
        //       " CASE WHEN len(sm.som_kod)<6 THEN  ISNULL((SELECT( " +
        //       " SELECT SUM(CASE cha_tip WHEN 1 THEN  " +
        //       "    -1*(CASE cha_d_cins " +
        //        "   WHEN 0 THEN cha_meblag " +
        //         "  WHEN 1 THEN cha_meblag *  (case " + _dolar.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _dolar.ToString().Replace(",", ".") + " END) " + // --USD 
        //          " WHEN 2 THEN cha_meblag *  (case " + _euro.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _euro.ToString().Replace(",", ".") + " END)  " +//--Euro
        //          " ELSE 0 END) " +

        //       " ELSE  " + //--cha_tip
        //          " (CASE cha_d_cins " +
        //          " WHEN 0 THEN cha_meblag " +
        //          " WHEN 1 THEN cha_meblag * (case " + _dolar.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _dolar.ToString().Replace(",", ".") + " END)  " +// --USD
        //          " WHEN 2 THEN cha_meblag * (case " + _euro.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _euro.ToString().Replace(",", ".") + " END)  " +//--Euro
        //          " ELSE 0 END) " +
        //       " END)AS a " +
        //       " FROM CARI_HESAP_HAREKETLERI " +

        //       " WHERE cha_srmrkkodu=sm.som_kod AND (left(cha_kod,3)IN('100','102') OR left(cha_kod,7)IN('950.100'))))" +

        //       " + " +

        //       " (SELECT( " +
        //       " SELECT SUM(CASE cha_tip WHEN 0 THEN  " +
        //         "  -1*(CASE cha_d_cins " +
        //         "  WHEN 0 THEN cha_meblag " +
        //         "  WHEN 1 THEN cha_meblag * (case " + _dolar.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _dolar.ToString().Replace(",", ".") + " END)  " +// --USD
        //         "  WHEN 2 THEN cha_meblag * (case " + _euro.ToString().Replace(",", ".") + "WHEN 0 THEN cha_d_kur ELSE  " + _euro.ToString().Replace(",", ".") + " END) " +//--Euro  
        //         "  ELSE 0 END) " +

        //       " ELSE  " +//--cha_tip
        //          " (CASE cha_d_cins " +
        //          " WHEN 0 THEN cha_meblag " +
        //          " WHEN 1 THEN cha_meblag * (case " + _dolar.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _dolar.ToString().Replace(",", ".") + " END)  " +//--USD
        //          " WHEN 2 THEN cha_meblag * (case " + _euro.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _euro.ToString().Replace(",", ".") + " END)   " +//--Euro 
        //          " ELSE 0 END) " +
        //       " END)AS a " +
        //       " FROM CARI_HESAP_HAREKETLERI  " +
        //       " WHERE cha_karsisrmrkkodu=sm.som_kod AND (left(cha_kasa_hizkod,3)IN('100','102') OR left(cha_kasa_hizkod,7)IN('950.100')))),0) ELSE 0 END) AS b,  " +
        //    //----------------
        //       " (CASE WHEN len(sm.som_kod)>5 THEN  ISNULL((SELECT( " +
        //       " SELECT SUM(CASE cha_tip WHEN 1 THEN  " +
        //       "    -1*(CASE cha_d_cins " +
        //        "   WHEN 0 THEN cha_meblag " +
        //         "  WHEN 1 THEN cha_meblag *  (case " + _dolar.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _dolar.ToString().Replace(",", ".") + " END) " + // --USD 
        //          " WHEN 2 THEN cha_meblag *  (case " + _euro.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _euro.ToString().Replace(",", ".") + " END)  " +//--Euro
        //          " ELSE 0 END) " +

        //       " ELSE  " + //--cha_tip
        //          " (CASE cha_d_cins " +
        //          " WHEN 0 THEN cha_meblag " +
        //          " WHEN 1 THEN cha_meblag * (case " + _dolar.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _dolar.ToString().Replace(",", ".") + " END)  " +// --USD
        //          " WHEN 2 THEN cha_meblag * (case " + _euro.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _euro.ToString().Replace(",", ".") + " END)  " +//--Euro
        //          " ELSE 0 END) " +
        //       " END)AS a " +
        //       " FROM CARI_HESAP_HAREKETLERI " +

        //       " WHERE cha_srmrkkodu=sm.som_kod AND (left(cha_kod,3)IN('100','102') OR left(cha_kod,7)IN('950.100'))))" +

        //       " + " +

        //       " (SELECT( " +
        //       " SELECT SUM(CASE cha_tip WHEN 0 THEN  " +
        //         "  -1*(CASE cha_d_cins " +
        //         "  WHEN 0 THEN cha_meblag " +
        //         "  WHEN 1 THEN cha_meblag * (case " + _dolar.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _dolar.ToString().Replace(",", ".") + " END)  " +// --USD
        //         "  WHEN 2 THEN cha_meblag * (case " + _euro.ToString().Replace(",", ".") + "WHEN 0 THEN cha_d_kur ELSE  " + _euro.ToString().Replace(",", ".") + " END) " +//--Euro  
        //         "  ELSE 0 END) " +

        //       " ELSE  " +//--cha_tip
        //          " (CASE cha_d_cins " +
        //          " WHEN 0 THEN cha_meblag " +
        //          " WHEN 1 THEN cha_meblag * (case " + _dolar.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _dolar.ToString().Replace(",", ".") + " END)  " +//--USD
        //          " WHEN 2 THEN cha_meblag * (case " + _euro.ToString().Replace(",", ".") + " WHEN 0 THEN cha_d_kur ELSE  " + _euro.ToString().Replace(",", ".") + " END)   " +//--Euro 
        //          " ELSE 0 END) " +
        //       " END)AS a " +
        //       " FROM CARI_HESAP_HAREKETLERI  " +
        //       " WHERE cha_karsisrmrkkodu=sm.som_kod AND (left(cha_kasa_hizkod,3)IN('100','102') OR left(cha_kasa_hizkod,7)IN('950.100')))),0) ELSE 0 END) AS b1,  " +


        //          " CASE LEFT(sm.som_kod,2)  " +
        //         " WHEN '01' THEN 'ISTANBUL' " +
        //         " WHEN '02' THEN 'BURSA' " +
        //         " WHEN '03' THEN 'IZMIR' " +
        //         " WHEN '04' THEN 'ADANA' " +
        //         " WHEN '05' THEN 'ANKARA' " +
        //         " END AS il,sm.som_kod, " +

        //         " sm.som_isim , " +
        //         " CASE RIGHT(sm.som_kod,2) " +
        //         " WHEN '98' THEN 'Masraf' " +
        //         " ELSE 'Ücret' " +
        //         " END AS kasaTuru " +
        //       " FROM SORUMLULUK_MERKEZLERI AS sm  " +
        //                 " WHERE left(sm.som_kod,2) IN (" + ilKodlari + ")  Order by sm.som_kod";
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
        private void LikiditeFormu_Load(object sender, EventArgs e)
        {

        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ps_ciktiXls();
        }

        private void btnTumunuAc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ExpandAllGroups();
        }

        private void btnTumunuKapa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.CollapseAllGroups();
        }

        private void btnSorgula_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ps_aramaYap(fn_ilKodu(),fn_smCek(),anafrm.euro,anafrm.dolar);
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

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.OptionsView.ShowGroupPanel = true;
        }

        private void btnTemizle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dSRaporlama.LikiditeRaporu.Clear();
        }

    }
}