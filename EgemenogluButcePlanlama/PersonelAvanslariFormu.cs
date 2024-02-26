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
using System.Threading;
namespace EgemenOgluRaporlama
{
    public partial class PersonelAvanslariFormu : DevExpress.XtraEditors.XtraForm
    {
        public PersonelAvanslariFormu()
        {
            InitializeComponent();
        }
        public AnaForm anafrm{get;set;}

        private string fn_ilKodu() {
            string q,q1;
            q = null;
            q1 = null;
            for (int i = 0; i < anafrm.lbIller.CheckedItems.Count; i++)
            {
                q1 = anafrm.lbIller.CheckedItems[i].ToString();
                q += q1+",";
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

        private void ps_aramaYap(string ilKodlari,string smKodlari) {
            if (!string.IsNullOrEmpty(ilKodlari))
            {
                //if (!string.IsNullOrEmpty(smKodlari))
                //{
                    SqlConnection con = new SqlConnection(Properties.Settings.Default.Cs);
                    con.Open();
                    string q = ilKodlari;
                    string sorgu = @"SELECT " +      
                    " CASE SUBSTRING(cha_kod,8,2) " + 
                        "WHEN '04' THEN 'ADANA' " +  
                        "WHEN '05' THEN 'ANKARA' " +  
                        "when '02' THEN 'BURSA' " +  
                        "WHEN '01' THEN 'İSTANBUL' " +
                        "WHEN '03' THEN 'İZMİR' " +   
                        "END AS il, " +
                    "cha_kod,dbo.fn_PersonelAdiBul(cha_kod) AS isim, " +

                    "CAST(SUM(CASE cha_tip WHEN '0' THEN cha_meblag END) -" +
                    "SUM(CASE cha_tip WHEN '1' THEN cha_meblag END)AS DECIMAL(21,2)) AS Para, " +

                    "COUNT(cha_kod) AS hareketSayisi " +
                    "FROM         CARI_HESAP_HAREKETLERI " +
                    "WHERE     (LEFT(cha_kod, 3) = '195') and (substring(cha_kod,8,2) in(" + q + ")) " +
                    "GROUP BY cha_kod " +
                    "HAVING      CAST(SUM(CASE cha_tip WHEN '0' THEN cha_meblag END) -" +
                                 "SUM(CASE cha_tip WHEN '1' THEN cha_meblag END)AS DECIMAL(21,2))  > 0" +
                    "ORDER BY il,isim";

                    SqlDataAdapter da = new SqlDataAdapter(sorgu, con);

                    dSRaporlama.PersonelAvanslari.Clear();
                    da.Fill(dSRaporlama.PersonelAvanslari);

                    gridControl1.DataSource = dSRaporlama.PersonelAvanslari;
                    //this.personelAvanslariTableAdapter.personelleriGetir(this.dSRaporlama.PersonelAvanslari,a);           
                //}
                //else {
                //    MessageBox.Show("Arama Kriteri Olarak {Sorumluluk Merkezi} Seçilmedi!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);   
                //}
            }
            else
            {
                MessageBox.Show("Arama Kriteri Olarak {il} Seçilmedi!","Dikkat!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
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
      
        private void PersonelAvanslariFormu_Load(object sender, EventArgs e)
        {
      
        }

        private void brnAra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {            
            ps_aramaYap(fn_ilKodu(),fn_smCek());  
        }

        private void btnTemizle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dSRaporlama.PersonelAvanslari.Clear();
        }

        private void btnExceleAktar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ps_ciktiXls();
        }

        private void btnExpendAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ExpandAllGroups();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.CollapseAllGroups();
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
    }
}