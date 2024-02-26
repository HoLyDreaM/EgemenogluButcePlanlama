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
    public partial class GelirTablosu : DevExpress.XtraEditors.XtraForm
    {
        Ayarlar.lookUpGTFirmaSec frmLookUpFirmaSec;

        public GelirTablosu()
        {
            InitializeComponent();
        }
        SqlDataReader rdr;
        SqlConnection con;
        SqlCommand cmd;

        public void gelirTablosuDoldur() {      
            con = new SqlConnection(Properties.Settings.Default.Cs);
            if (con.State!=ConnectionState.Open) {
                con.Open();
            }
            double alacakToplam, borcToplam,bakiyeToplam;
            Int16 turu=4;

            string nazimHesap; string sorgu950Dahil, sorgu950Dahil1;

            
            alacakToplam = 0;
            borcToplam = 0;
            bakiyeToplam = 0;

            if (dahil950.Checked)
            {
                sorgu950Dahil =  " OR  (LEFT(muh_hesap_kod,5) IN ('950.6','950.7') AND len(muh_hesap_kod)<8) ";
                sorgu950Dahil1 = " OR (left(fis_hesap_kod,LEN('950.'+muh_hesap_kod)) =CASE WHEN  LEN(muh_hesap_kod)<3 then  '950.'+ muh_hesap_kod ELSE '0' END) ";
            }
            else
            {
                sorgu950Dahil = "";
                sorgu950Dahil1 = "";
            }

            string sorgu =" SELECT CASE left(muh_hesap_kod,3) WHEN '950' THEN substring(muh_hesap_kod,5,LEN(muh_hesap_kod)-2)+'N' else  muh_hesap_kod END AS muh_hesap_kod        " +
                       " ,muh_hesap_isim1,muh_hesap_isim2,  " +
                       " (SELECT isnull(SUM(fis_meblag0),0) FROM MUHASEBE_FISLERI " +
                      " WHERE  ((left(fis_hesap_kod,LEN(muh_hesap_kod)) =muh_hesap_kod) " + sorgu950Dahil1 + ") AND  fis_meblag0 > 0 And fis_firmano IN("+txtFirmaSec.Text+") " +
                      " AND (fis_tarih BETWEEN  CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND  CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102)))AS borc,  " +
                
                      " (SELECT ABS(isnull(SUM(fis_meblag0),0)) FROM MUHASEBE_FISLERI  " +
                      " WHERE((left(fis_hesap_kod,LEN(muh_hesap_kod)) =muh_hesap_kod)  " + sorgu950Dahil1 + ") AND  fis_meblag0 < 0 And fis_firmano IN(" + txtFirmaSec.Text + ") " +
                      " AND (fis_tarih BETWEEN  CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND  CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102) )) AS alacak,  " +

                      " (SELECT isnull(SUM(fis_meblag0),0) FROM MUHASEBE_FISLERI  " +
                       " WHERE " +
                       " ((left(fis_hesap_kod,LEN(muh_hesap_kod)) =muh_hesap_kod)  " + sorgu950Dahil1 + ") AND fis_meblag0 > 0  And fis_firmano IN(" + txtFirmaSec.Text + ") " +


                      " AND (fis_tarih BETWEEN  CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND  CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102) )) -  " +
                      " (SELECT ABS(isnull(SUM(fis_meblag0),0)) FROM MUHASEBE_FISLERI  " +
                      " WHERE  " +
                      " ((left(fis_hesap_kod,LEN(muh_hesap_kod)) =muh_hesap_kod)  " + sorgu950Dahil1 + ") AND fis_meblag0 < 0  And fis_firmano IN(" + txtFirmaSec.Text + ") " +
                      " AND (fis_tarih BETWEEN  CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND  CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102) )) AS bakiye  " +

                      " FROM MUHASEBE_HESAP_PLANI WHERE (LEFT(muh_hesap_kod,1) IN ('6','7') AND len(muh_hesap_kod)<"+turu+") " +
                      sorgu950Dahil +
                      " ORDER BY muh_hesap_kod ";

            #region eskiSorgu
            //string sorgu =" SELECT CASE left(muh_hesap_kod,3) WHEN '950' THEN substring(muh_hesap_kod,5,LEN(muh_hesap_kod)-2)+'N' else  muh_hesap_kod END AS muh_hesap_kod      " +
            //              "  ,muh_hesap_isim1,muh_hesap_isim2,  " +
            //              "  (SELECT isnull(SUM(fis_meblag0),0) FROM MUHASEBE_FISLERI  " +
            //              "  WHERE ((left(fis_hesap_kod,LEN(muh_hesap_kod)) =muh_hesap_kod) " + sorgu950Dahil1 + ") AND fis_firmano='0' AND fis_meblag0 >0  " +
            //              "  AND (fis_tarih BETWEEN  CONVERT(VARCHAR, CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102), 23) AND  CONVERT(VARCHAR, CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102), 23) ))AS borc,  " +
            //              "  (SELECT ABS(isnull(SUM(fis_meblag0),0)) FROM MUHASEBE_FISLERI  " +

            //              "  WHERE (left(fis_hesap_kod,LEN(muh_hesap_kod)) =muh_hesap_kod) " + sorgu950Dahil1 + " AND fis_firmano='0' AND fis_meblag0 < 0  " +
            //              "  AND (fis_tarih BETWEEN CONVERT(VARCHAR, CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102), 23) AND  CONVERT(VARCHAR, CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102), 23) )) AS alacak,  " +

            //              "  (SELECT isnull(SUM(fis_meblag0),0) FROM MUHASEBE_FISLERI  " +
            //              "  WHERE ((left(fis_hesap_kod,LEN(muh_hesap_kod)) =muh_hesap_kod) " + sorgu950Dahil1 + ") AND fis_firmano='0' AND fis_meblag0 >0  " +
            //              "  AND (fis_tarih BETWEEN  CONVERT(VARCHAR, CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102), 23) AND  CONVERT(VARCHAR, CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102), 23) )) -  " +
            //              "  (SELECT ABS(isnull(SUM(fis_meblag0),0)) FROM MUHASEBE_FISLERI  " +
            //              "  WHERE ((left(fis_hesap_kod,LEN(muh_hesap_kod)) =muh_hesap_kod) " + sorgu950Dahil1 + ") AND fis_firmano='0' AND fis_meblag0 < 0  " +
            //              "  AND (fis_tarih BETWEEN  CONVERT(VARCHAR, CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102), 23) AND  CONVERT(VARCHAR, CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102), 23) )) AS bakiye  " +

            //              "  FROM MUHASEBE_HESAP_PLANI WHERE (LEFT(muh_hesap_kod,1) IN ('6','7')  AND len(muh_hesap_kod)<"+turu+") " +
            //              "  " + sorgu950Dahil +
            //              " ORDER BY muh_hesap_kod; ";

           
            //string sorgu = " SELECT CASE left(muh_hesap_kod,3) WHEN '950' THEN substring(muh_hesap_kod,5,LEN(muh_hesap_kod)-2)+'N' else  muh_hesap_kod END AS muh_hesap_kod "+
            //              ",muh_hesap_isim1,muh_hesap_isim2, " +
            //              "  (SELECT isnull(SUM(fis_meblag0),0) FROM MUHASEBE_FISLERI " +
            //              "  WHERE left(fis_hesap_kod,LEN(muh_hesap_kod)) =muh_hesap_kod AND fis_firmano='0' AND fis_meblag0 >0 "+
            //              "  AND (fis_tarih BETWEEN  CONVERT(VARCHAR, CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102), 23) AND  CONVERT(VARCHAR, CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102), 23) ))AS borc, " +

            //               " (SELECT ABS(isnull(SUM(fis_meblag0),0)) FROM MUHASEBE_FISLERI "+
            //               " WHERE left(fis_hesap_kod,LEN(muh_hesap_kod)) =muh_hesap_kod AND fis_firmano='0' AND fis_meblag0 < 0 "+
            //               " AND (fis_tarih BETWEEN  CONVERT(VARCHAR, CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102), 23) AND  CONVERT(VARCHAR, CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102), 23) )) AS alacak, " +

            //               " (SELECT isnull(SUM(fis_meblag0),0) FROM MUHASEBE_FISLERI "+
            //               " WHERE left(fis_hesap_kod,LEN(muh_hesap_kod)) =muh_hesap_kod AND fis_firmano='0' AND fis_meblag0 >0 "+
            //               " AND (fis_tarih BETWEEN  CONVERT(VARCHAR, CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102), 23) AND  CONVERT(VARCHAR, CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102), 23) )) - " +
            //               " (SELECT ABS(isnull(SUM(fis_meblag0),0)) FROM MUHASEBE_FISLERI "+
            //               " WHERE left(fis_hesap_kod,LEN(muh_hesap_kod)) =muh_hesap_kod AND fis_firmano='0' AND fis_meblag0 < 0 "+
            //               " AND (fis_tarih BETWEEN  CONVERT(VARCHAR, CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102), 23) AND  CONVERT(VARCHAR, CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102), 23) )) AS bakiye " +

            //               " FROM MUHASEBE_HESAP_PLANI WHERE (LEFT(muh_hesap_kod,1) IN ('6','7') AND len(muh_hesap_kod) < " + turu + ") OR  " +
            //                                               " (LEFT(muh_hesap_kod,5) IN ('950.6','950.7') AND len(muh_hesap_kod)<8) "+
            //               " ORDER BY muh_hesap_kod ";
            #endregion
            cmd = new SqlCommand(sorgu,con);
            rdr = cmd.ExecuteReader();
            dSRaporlama.gelirTablosu.Clear();

            while(rdr.Read()){
                if (Convert.ToDouble(rdr[3]) != 0 || Convert.ToDouble(rdr[4]) != 0 || check1.Checked == false)
                {
                    nazimHesap = rdr[0].ToString();
                   
                    if (nazimHesap.Length>3)
                    if (nazimHesap.Substring(3, 1) == "N")//nazım hesap
                    {
                        nazimHesap = "950." + nazimHesap.Replace('N',' ');
                    }

                    if (rdr[0].ToString().Length == 1 || rdr[0].ToString().StartsWith("950"))
                    {
                        borcToplam += (double)rdr[3];
                        alacakToplam += (double)rdr[4];
                        bakiyeToplam += (double)rdr[5];
                    }
                    dSRaporlama.gelirTablosu.Rows.Add(nazimHesap, rdr[1], rdr[2], Math.Abs(Convert.ToDouble(rdr[3])), Math.Abs(Convert.ToDouble(rdr[4])), Math.Abs(Convert.ToDouble(rdr[5])));
                    //dSRaporlama.gelirTablosu.Rows.Add(nazimHesap, rdr[1], rdr[2], Math.Abs(Convert.ToDouble(rdr[3])), Math.Abs(Convert.ToDouble(rdr[4])), Math.Abs(Convert.ToDouble(rdr[5])));
                }

            }
            dSRaporlama.gelirTablosu.Rows.Add("-------------------", "-----------------------------", "---------------------------", 0, 0, 0);
            dSRaporlama.gelirTablosu.Rows.Add(" ", "DÖNEM NET KARI VEYA ZARARI", "", Math.Abs(borcToplam), Math.Abs(alacakToplam),Math.Abs(bakiyeToplam));
            // dSRaporlama.gelirTablosu.Rows.Add(" ", "DÖNEM NET KARI VEYA ZARARI", "", Math.Abs(borcToplam), Math.Abs(alacakToplam),Math.Abs(bakiyeToplam));
        }

        //private delegate void _kayitEkle(string _a,string _b,string _c , double _alacak , double _borc,double bakiye);
        //private void kayitEkle(string _a, string _b, string _c, double _alacak, double _borc, double bakiye)
        //{
        //    Object[] obj = new Object[]{_a,_b,_c,_alacak,_borc,bakiye};
        //    if (this.InvokeRequired) {
        //        this.Invoke(new _kayitEkle(kayitEkle),obj);
        //    }
        //    dSRaporlama.gelirTablosu.Rows.Add(_a, _b, _c, _alacak, _borc, bakiye);
        //}

        private void firmaDoldur() {
            string firmaAdi="";
            this.fIRMALARTableAdapter.Fill(this.dSRaporlama.FIRMALAR);

            foreach (DataRow dr in dSRaporlama.FIRMALAR)
            {
                firmaAdi += "'" + dr[0].ToString() + "',";
            }
            txtFirmaSec.Text = firmaAdi.Substring(0,firmaAdi.Length-1);
        }

        private void GelirTablosu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSRaporlama.FIRMALAR' table. You can move, or remove it, as needed.

            firmaDoldur();
            tarih1.Text = DateTime.DaysInMonth((DateTime.Now.Year - 1), 1) + ".12." + (DateTime.Now.Year - 1).ToString();
            tarih2.Text = DateTime.DaysInMonth(DateTime.Now.Year, 12).ToString() + ".12." + DateTime.Now.Year.ToString();
            
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

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gelirTablosuDoldur();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dSRaporlama.gelirTablosu.Clear();
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

        private void buttonEdit1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmLookUpFirmaSec = new Ayarlar.lookUpGTFirmaSec();
            frmLookUpFirmaSec.frmGelirTablosu = this;
            frmLookUpFirmaSec.Owner = this;
            frmLookUpFirmaSec.ShowDialog();
        }

    }
}