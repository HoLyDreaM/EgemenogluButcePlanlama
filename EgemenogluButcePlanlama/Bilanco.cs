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
namespace EgemenOgluRaporlama
{
    public partial class Bilanco : Form
    {
        public Bilanco()
        {
            InitializeComponent();
        }
        Ayarlar.lookUpBilancoFirmaSec frmLookUpFirmaSec;

        SqlDataReader rdr;
        SqlConnection con;
        SqlCommand cmd;

        SqlDataReader rdr1;
        SqlConnection con1;
        SqlCommand cmd1;

        //Bilanço Pasifler
        public void p_bilanco()
        {
            con = new SqlConnection(Properties.Settings.Default.Cs);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

           string sorgu950Dahil, sorgu950Dahil1,sorgu950_6Dahil,sorgu950_7Dahil;

            if (dahil950.Checked)
            {
                sorgu950Dahil = " OR  (LEFT(muh_hesap_kod,5) IN ('950.3','950.4','950.5') AND len(muh_hesap_kod)<8) ";
                sorgu950Dahil1 = " OR (left(fis_hesap_kod,LEN('950.'+muh_hesap_kod)) =CASE WHEN  LEN(muh_hesap_kod)<3 then  '950.'+ muh_hesap_kod ELSE '0' END) ";
               
                sorgu950_6Dahil = " OR (left(fis_hesap_kod,LEN('950.6')) ='950.6')";
                sorgu950_7Dahil = " OR (left(fis_hesap_kod,LEN('950.7')) ='950.7')";
            }
            else
            {
                sorgu950Dahil  ="";
                sorgu950Dahil1 ="";
                sorgu950_6Dahil = "";
                sorgu950_7Dahil = "";
            }

            string sorgu =
                   " SELECT CASE left(muh_hesap_kod,3) WHEN '950' THEN substring(muh_hesap_kod,5,LEN(muh_hesap_kod)-2)+'N' else  muh_hesap_kod END AS muh_hesap_kod,muh_hesap_isim1,muh_hesap_isim2, " +
                   " CASE  LEFT(muh_hesap_kod,1) WHEN '5' THEN " +
                       " CASE WHEN left(muh_hesap_kod,1)='5' and LEN(muh_hesap_kod)=1  THEN " +
                           " (SELECT ABS(isnull(SUM(fis_meblag0),0)) FROM MUHASEBE_FISLERI    " +
                           " WHERE ((left(fis_hesap_kod,LEN('7')) ='7') " + sorgu950_7Dahil + ")   " +
                           " AND fis_meblag0 > 0  And fis_firmano IN(" + txtFirmaSec.Text + ")  AND (fis_tarih BETWEEN  CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND  CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102))) + " +
                           " (SELECT isnull(SUM(fis_meblag0),0) FROM MUHASEBE_FISLERI     " +
                           " WHERE  ((left(fis_hesap_kod,LEN(muh_hesap_kod)) =muh_hesap_kod) " + sorgu950Dahil1 + ")  AND fis_meblag0 >0   And fis_firmano IN(" + txtFirmaSec.Text + ")  AND (fis_tarih BETWEEN  CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND  CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102))) " +
                       " ELSE " +
                          "  CASE WHEN left(muh_hesap_kod,2)='57' THEN " +
                               " (SELECT ABS(isnull(SUM(fis_meblag0),0)) FROM MUHASEBE_FISLERI    " +
                               " WHERE ((left(fis_hesap_kod,LEN('7')) ='7') " + sorgu950_7Dahil + ")   " +
                               " AND fis_meblag0 > 0  And fis_firmano IN(" + txtFirmaSec.Text + ")   AND (fis_tarih BETWEEN  CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND  CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102))) " +
                           " ELSE " +
                               " (SELECT isnull(SUM(fis_meblag0),0) FROM MUHASEBE_FISLERI    	  " +
                               " WHERE  ((left(fis_hesap_kod,LEN(muh_hesap_kod)) =muh_hesap_kod)  " + sorgu950Dahil1 + ")  AND fis_meblag0 >0  And fis_firmano IN(" + txtFirmaSec.Text + ")   AND (fis_tarih BETWEEN  CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND  CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102))) " +
                           " END	 " +
                       " END	 " +
                   " ELSE " +
                       " (SELECT isnull(SUM(fis_meblag0),0) FROM MUHASEBE_FISLERI    	  " +
                       " WHERE  ((left(fis_hesap_kod,LEN(muh_hesap_kod)) =muh_hesap_kod)  " + sorgu950Dahil1 + ")  AND fis_meblag0 >0  And fis_firmano IN(" + txtFirmaSec.Text + ")   AND (fis_tarih BETWEEN  CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND  CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102))) " +
                    " END	AS borc,     " +

                   " CASE  LEFT(muh_hesap_kod,1) WHEN '5' THEN " +
                       " CASE WHEN left(muh_hesap_kod,1)='5' and LEN(muh_hesap_kod)=1  THEN " +
                           " ABS((SELECT ABS(isnull(SUM(fis_meblag0),0)) FROM MUHASEBE_FISLERI    " +
                           " WHERE ((left(fis_hesap_kod,LEN('6')) ='6') " + sorgu950_6Dahil + ")   " +
                           " AND fis_meblag0 < 0  And fis_firmano IN(" + txtFirmaSec.Text + ")  AND (fis_tarih BETWEEN  CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND  CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102))) + " +
                           " (SELECT isnull(SUM(fis_meblag0),0) FROM MUHASEBE_FISLERI     " +
                           " WHERE  ((left(fis_hesap_kod,LEN(muh_hesap_kod)) =muh_hesap_kod)  " + sorgu950Dahil1 + ")  AND fis_meblag0 <0   And fis_firmano IN(" + txtFirmaSec.Text + ")  AND (fis_tarih BETWEEN  CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND  CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102)))) " +
                       " ELSE " +
                           " CASE WHEN left(muh_hesap_kod,2)='57' THEN " +
                               " ABS((SELECT ABS(isnull(SUM(fis_meblag0),0)) FROM MUHASEBE_FISLERI    " +
                               " WHERE ((left(fis_hesap_kod,LEN('6')) ='6') " + sorgu950_6Dahil + ")   " +
                               " AND fis_meblag0 < 0  And fis_firmano IN(" + txtFirmaSec.Text + ")  AND (fis_tarih BETWEEN  CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND  CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102)))) " +
                           " ELSE " +
                               " ABS((SELECT isnull(SUM(fis_meblag0),0) FROM MUHASEBE_FISLERI    	  " +
                              "  WHERE  ((left(fis_hesap_kod,LEN(muh_hesap_kod)) =muh_hesap_kod)  " + sorgu950Dahil1 + ")  AND fis_meblag0 <0   And fis_firmano IN(" + txtFirmaSec.Text + ")  AND (fis_tarih BETWEEN  CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND  CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102)))) " +
                           " END	 " +
                       " END	 " +
                    " ELSE " +
                       " ABS((SELECT isnull(SUM(fis_meblag0),0) FROM MUHASEBE_FISLERI    	  " +
                       " WHERE  ((left(fis_hesap_kod,LEN(muh_hesap_kod)) =muh_hesap_kod)  " + sorgu950Dahil1 + ")  AND fis_meblag0 <0  And fis_firmano IN(" + txtFirmaSec.Text + ")   AND (fis_tarih BETWEEN  CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND  CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102)))) " +
                   " END	AS Alacak,     " +

                    " CASE  LEFT(muh_hesap_kod,1) WHEN '5' THEN " +
                       " CASE WHEN left(muh_hesap_kod,1)='5' and LEN(muh_hesap_kod)=1  THEN " +
                           " (SELECT ABS(isnull(SUM(fis_meblag0),0)) FROM MUHASEBE_FISLERI    " +
                           " WHERE ((left(fis_hesap_kod,LEN('7')) ='7') " + sorgu950_7Dahil + ")   " +
                           " AND fis_meblag0 > 0  And fis_firmano IN(" + txtFirmaSec.Text + ")  AND (fis_tarih BETWEEN  CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND  CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102))) " +
                           " - " +
                           " (SELECT ABS(isnull(SUM(fis_meblag0),0)) FROM MUHASEBE_FISLERI    " +
                           " WHERE ((left(fis_hesap_kod,LEN('6')) ='6' " + sorgu950_6Dahil + ") )   " +
                           " AND fis_meblag0 < 0  And fis_firmano IN(" + txtFirmaSec.Text + ")  AND (fis_tarih BETWEEN  CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND  CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102)))		 " +
                       " ELSE " +
                           " CASE WHEN left(muh_hesap_kod,2)='57' THEN " +
                               " ((SELECT ABS(isnull(SUM(fis_meblag0),0)) FROM MUHASEBE_FISLERI    " +
                               " WHERE ((left(fis_hesap_kod,LEN('7')) ='7') " + sorgu950_7Dahil + ")   " +
                               " AND fis_meblag0 > 0  And fis_firmano IN(" + txtFirmaSec.Text + ")  AND (fis_tarih BETWEEN  CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND  CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102))) " +
                              "  - " +
                              "  (SELECT ABS(isnull(SUM(fis_meblag0),0)) FROM MUHASEBE_FISLERI    " +
                              "  WHERE ((left(fis_hesap_kod,LEN('6')) ='6' " + sorgu950_6Dahil + ") )   " +
                               " AND fis_meblag0 < 0  And fis_firmano IN(" + txtFirmaSec.Text + ")  AND (fis_tarih BETWEEN  CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND  CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102)))) + " +

                               " (SELECT isnull(SUM(fis_meblag0),0) FROM MUHASEBE_FISLERI    " +
                               " WHERE ((left(fis_hesap_kod,LEN(muh_hesap_kod)) =muh_hesap_kod)  " + sorgu950Dahil1 + ")  AND fis_meblag0 >0  And fis_firmano IN(" + txtFirmaSec.Text + ")   AND (fis_tarih BETWEEN  CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND  CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102))) -    " +

                               " (SELECT ABS(isnull(SUM(fis_meblag0),0)) FROM MUHASEBE_FISLERI " +
                               " WHERE ((left(fis_hesap_kod,LEN(muh_hesap_kod)) =muh_hesap_kod)  " + sorgu950Dahil1 + ")  AND fis_meblag0 < 0  And fis_firmano IN(" + txtFirmaSec.Text + ")   AND (fis_tarih BETWEEN  CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND  CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102))) " +
                           " ELSE " +
                               " (SELECT isnull(SUM(fis_meblag0),0) FROM MUHASEBE_FISLERI    	  " +
                               " WHERE  ((left(fis_hesap_kod,LEN(muh_hesap_kod)) =muh_hesap_kod)  " + sorgu950Dahil1 + ")  AND fis_meblag0 <0  And fis_firmano IN(" + txtFirmaSec.Text + ")   AND (fis_tarih BETWEEN  CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND  CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102))) " +
                          "  END	 " +

                       " END	 " +
                   " ELSE " +
                           " (SELECT isnull(SUM(fis_meblag0),0) FROM MUHASEBE_FISLERI    " +
                           " WHERE ((left(fis_hesap_kod,LEN(muh_hesap_kod)) =muh_hesap_kod) " + sorgu950Dahil1 + ")  AND fis_meblag0 >0   And fis_firmano IN(" + txtFirmaSec.Text + ")  AND (fis_tarih BETWEEN  CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND  CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102))) - " +
                           " (SELECT ABS(isnull(SUM(fis_meblag0),0)) FROM MUHASEBE_FISLERI " +
                           " WHERE ((left(fis_hesap_kod,LEN(muh_hesap_kod)) =muh_hesap_kod) " + sorgu950Dahil1 + ")  AND fis_meblag0 < 0  And fis_firmano IN(" + txtFirmaSec.Text + ")  AND (fis_tarih BETWEEN  CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND  CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102))) " +

                   " END AS bakiye " +

                           " FROM MUHASEBE_HESAP_PLANI WHERE ((LEFT(muh_hesap_kod,1) IN ('3','4','5') AND len(muh_hesap_kod) < 4 )  " +
                           " " + sorgu950Dahil + ") AND LEN(muh_hesap_isim1)>0  " +
                           " ORDER BY muh_hesap_kod; ";

            #region eski Sorgu
            //" SELECT CASE left(muh_hesap_kod,3) WHEN '950' THEN substring(muh_hesap_kod,5,LEN(muh_hesap_kod)-2)+'N' else  muh_hesap_kod END AS muh_hesap_kod,muh_hesap_isim1,muh_hesap_isim2,   " +
                          
                //           " CASE WHEN LEFT(muh_hesap_kod,2)=57 THEN "+
                //                   " (SELECT ABS(isnull(SUM(fis_meblag0),0)) FROM MUHASEBE_FISLERI    "+
                //                   " WHERE ((left(fis_hesap_kod,LEN('7')) ='7') " + sorgu950_7Dahil + ")   " +
                //                   " AND fis_meblag0 > 0  AND (fis_tarih BETWEEN  CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND  CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102))) " +
                //           " ELSE " +
                //                   " (SELECT isnull(SUM(fis_meblag0),0) FROM MUHASEBE_FISLERI     "+
                //                   " WHERE  ((left(fis_hesap_kod,LEN(muh_hesap_kod)) =muh_hesap_kod) " + sorgu950Dahil1 + ")  AND fis_meblag0 >0   AND (fis_tarih BETWEEN  CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND  CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102)) " +
                //                   " ) "+
                //          " END	AS borc, "+
                //                  //----------------------------------------
                //           " CASE WHEN LEFT(muh_hesap_kod,2)=57 THEN " +
                //                   " (SELECT ABS(isnull(SUM(fis_meblag0),0)) FROM MUHASEBE_FISLERI    " +
                //                   " WHERE ((left(fis_hesap_kod,LEN('6')) ='6') " + sorgu950_6Dahil + ")   " +
                //                   " AND fis_meblag0 < 0  AND (fis_tarih BETWEEN  CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND  CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102))) " +                          
                //           " ELSE " +
                //                   " (SELECT ABS(isnull(SUM(fis_meblag0),0)) FROM MUHASEBE_FISLERI    " +
                //                   " WHERE ((left(fis_hesap_kod,LEN(muh_hesap_kod)) =muh_hesap_kod) " + sorgu950Dahil1 + ")  AND fis_meblag0 < 0  AND (fis_tarih BETWEEN  CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND  CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102)) " +
                //                   "  ) " +
                //           " END	AS alacak, " +
                //                 //----------------------------------------
                //           " CASE WHEN LEFT(muh_hesap_kod,2)=57 THEN " +
                //                   "(SELECT ABS(isnull(SUM(fis_meblag0),0)) FROM MUHASEBE_FISLERI    "+
                //                   " WHERE ((left(fis_hesap_kod,LEN('7')) ='7') " + sorgu950_7Dahil + ")   " +
                //                   " AND fis_meblag0 > 0  AND (fis_tarih BETWEEN  CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND  CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102))) " +
                //                   " - "+
                //                   " (SELECT ABS(isnull(SUM(fis_meblag0),0)) FROM MUHASEBE_FISLERI    "+
                //                   " WHERE ((left(fis_hesap_kod,LEN('6')) ='6' " + sorgu950_6Dahil + ") )   " +
                //                   " AND fis_meblag0 < 0  AND (fis_tarih BETWEEN  CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND  CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102))) " +
                //          " else "+
                //                   " (SELECT isnull(SUM(fis_meblag0),0) FROM MUHASEBE_FISLERI    " +
                //                   " WHERE ((left(fis_hesap_kod,LEN(muh_hesap_kod)) =muh_hesap_kod) " + sorgu950Dahil1 + ")  AND fis_meblag0 >0   AND (fis_tarih BETWEEN  CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND  CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102)) " +
                //                   " ) -     " +
                //                   " (SELECT ABS(isnull(SUM(fis_meblag0),0)) FROM MUHASEBE_FISLERI    " +
                //                   " WHERE ((left(fis_hesap_kod,LEN(muh_hesap_kod)) =muh_hesap_kod) " + sorgu950Dahil1 + ")  AND fis_meblag0 < 0   AND (fis_tarih BETWEEN  CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND  CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102))) " +
                //           " END AS bakiye "+

                //           " FROM MUHASEBE_HESAP_PLANI WHERE ((LEFT(muh_hesap_kod,1) IN ('3','4','5') AND len(muh_hesap_kod) < 4 )  " +
                //           " " + sorgu950Dahil + ") AND LEN(muh_hesap_isim1)>0  " +
            //           " ORDER BY muh_hesap_kod; ";
            #endregion
            cmd = new SqlCommand(sorgu, con);
            rdr = cmd.ExecuteReader();
            dSRaporlama.bilanco_pasif.Clear();
            dSRaporlama.bilanco_pasif.Load(rdr);
        }
        //Bilanço aktifler
        public void a_bilanco()
        {
            con1= new SqlConnection(Properties.Settings.Default.Cs);
            if (con1.State != ConnectionState.Open)
            {
                con1.Open();
            }

            string sorgu950Dahil, sorgu950Dahil1;

            if (dahil950.Checked)
            {
                sorgu950Dahil = " OR  (LEFT(muh_hesap_kod,5) IN ('950.1','950.2') AND len(muh_hesap_kod)<8) ";
                sorgu950Dahil1 = " OR (left(fis_hesap_kod,LEN('950.'+muh_hesap_kod)) =CASE WHEN  LEN(muh_hesap_kod)<3 then  '950.'+ muh_hesap_kod ELSE '0' END) ";
            }
            else
            {
                sorgu950Dahil = "";
                sorgu950Dahil1 = "";
            }

            string sorgu = " SELECT CASE left(muh_hesap_kod,3) WHEN '950' THEN substring(muh_hesap_kod,5,LEN(muh_hesap_kod)-2)+'N' else  muh_hesap_kod END AS muh_hesap_kod,muh_hesap_isim1,muh_hesap_isim2,   " +
                           " (SELECT isnull(SUM(fis_meblag0),0) FROM MUHASEBE_FISLERI     " +
                           "  WHERE  ((left(fis_hesap_kod,LEN(muh_hesap_kod)) =muh_hesap_kod) " + sorgu950Dahil1 + ")  AND fis_meblag0 >0   And fis_firmano IN(" + txtFirmaSec.Text + ")  AND (fis_tarih BETWEEN  CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND  CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102)) " +
                           " )AS borc,     " +

                           " (SELECT ABS(isnull(SUM(fis_meblag0),0)) FROM MUHASEBE_FISLERI    " +
                           " WHERE ((left(fis_hesap_kod,LEN(muh_hesap_kod)) =muh_hesap_kod) " + sorgu950Dahil1 + ")  AND fis_meblag0 < 0   And fis_firmano IN(" + txtFirmaSec.Text + ")  AND (fis_tarih BETWEEN  CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND  CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102)) " +
                           "  ) AS alacak,     " +

                           " (SELECT isnull(SUM(fis_meblag0),0) FROM MUHASEBE_FISLERI    " +
                           " WHERE ((left(fis_hesap_kod,LEN(muh_hesap_kod)) =muh_hesap_kod) " + sorgu950Dahil1 + ")  AND fis_meblag0 >0   And fis_firmano IN(" + txtFirmaSec.Text + ")   AND (fis_tarih BETWEEN  CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND  CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102)) " +
                           " ) -     " +
                           " (SELECT ABS(isnull(SUM(fis_meblag0),0)) FROM MUHASEBE_FISLERI    " +
                           " WHERE ((left(fis_hesap_kod,LEN(muh_hesap_kod)) =muh_hesap_kod) " + sorgu950Dahil1 + ")  AND fis_meblag0 < 0  And fis_firmano IN(" + txtFirmaSec.Text + ")   AND (fis_tarih BETWEEN  CONVERT(DATETIME, '" + tarih1.Value.ToString("yyyy-MM-dd") + "', 102) AND  CONVERT(DATETIME, '" + tarih2.Value.ToString("yyyy-MM-dd") + "', 102)) " +
                           " ) AS bakiye     " +

                           " FROM MUHASEBE_HESAP_PLANI WHERE ((LEFT(muh_hesap_kod,1) IN ('1','2') AND len(muh_hesap_kod) < 4 )  " +
                           " " + sorgu950Dahil + ") AND LEN(muh_hesap_isim1)>0  " +
                           " ORDER BY muh_hesap_kod; ";

            cmd1 = new SqlCommand(sorgu, con1);
            rdr1 = cmd1.ExecuteReader();
            dSRaporlama.bilanco_aktif.Clear();
            dSRaporlama.bilanco_aktif.Load(rdr1);
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
        public void bilancoTablosu()
        {
            // p = pasif ; a = aktif
            string[] alfabetikBaslik = {"A)","B)","C)","D)","E)","F)","G)", "H)" ,"I)" ,"J)", "K)" ,"L)","M)","N)","O)","P)","R)","S)","T)","U)","V)","Y)","Z)"};
            string[] p_alfabetikBaslik = { "A)", "B)", "C)", "D)", "E)", "F)", "G)", "H)", "I)", "J)", "K)", "L)", "M)", "N)", "O)", "P)", "R)", "S)", "T)", "U)", "V)", "Y)", "Z)" };
            int detay, baslik, alfabetikBaslikIndex, p_baslik, p_alfabetikBaslikIndex;
            baslik = 1; p_baslik = 0;
            alfabetikBaslikIndex = 0;p_alfabetikBaslikIndex = 0;

            string muh_kod_ilk_2hane = ""; string p_muh_kod_ilk_2hane = "";
            string muh_kod_ilkHane = ""; string p_muh_kod_ilkHane = "";

            detay = 4;

            string a_muh_kod, a_muh_hesap_adi, a_muh_hesap_adi1,bosluk;
            double a_alacak, a_borc, a_bakiye,a_alacakToplam,a_borcToplam,a_bakiyeToplam;
            a_alacakToplam = 0; a_borcToplam = 0; a_bakiyeToplam = 0;

            string p_muh_kod, p_muh_hesap_adi, p_muh_hesap_adi1;
            double p_alacak, p_borc, p_bakiye,p_alacakToplam,p_borcToplam,p_bakiyeToplam;
            p_alacakToplam = 0; p_borcToplam = 0; p_bakiyeToplam = 0;
            
            int adet;

          
            this.dSRaporlama.bilanco_aktif.Clear();
            this.dSRaporlama.bilanco_pasif.Clear();
            this.dSRaporlama.bilanco.Clear();

            //this.bilanco_pasifTableAdapter.Fill(this.dSRaporlama.bilanco_pasif, detay, tarih1.Value, tarih2.Value);
            p_bilanco();
            //this.bilanco_aktifTableAdapter.Fill(this.dSRaporlama.bilanco_aktif, detay, tarih1.Value, tarih2.Value);
            a_bilanco();

            if (dSRaporlama.bilanco_aktif.Count() > dSRaporlama.bilanco_pasif.Count())
                adet = this.dSRaporlama.bilanco_aktif.Count();
            else
                adet = this.dSRaporlama.bilanco_pasif.Count();

         
            for (int i = 0; i < adet-1; i++)
            {
                //------------<Aktifler>
                if (dSRaporlama.bilanco_aktif.Count() > i)
                {
                    a_muh_kod = dSRaporlama.bilanco_aktif[i][0].ToString();
                    a_muh_hesap_adi = dSRaporlama.bilanco_aktif[i][1].ToString();
                    a_muh_hesap_adi1 = dSRaporlama.bilanco_aktif[i][2].ToString();
                    a_alacak = (double)dSRaporlama.bilanco_aktif[i][3];
                    a_borc = (double)dSRaporlama.bilanco_aktif[i][4];
                    a_bakiye = (double)dSRaporlama.bilanco_aktif[i][5];


                    if (a_muh_kod.Length > 3)
                        if (a_muh_kod.Substring(3, 1) == "N")//nazım hesap
                        {
                            a_muh_kod = a_muh_kod.Replace('N', ' ') + " (950)";
                        }


                    if (a_muh_kod.Length==1) {
                        if (muh_kod_ilkHane != a_muh_kod)
                        {
                            muh_kod_ilkHane = a_muh_kod.ToString();//ilk iki
                            alfabetikBaslikIndex = 0;
                        }
                        //a_muh_hesap_adi = "=>" +a_muh_hesap_adi;
                    }else if(a_muh_kod.Length==2){
                        if (muh_kod_ilk_2hane != a_muh_kod)
                        {                           
                            muh_kod_ilk_2hane = a_muh_kod.ToString();//ilk iki
                            baslik=1;                            
                        }
                        a_muh_hesap_adi = "  "+alfabetikBaslik[alfabetikBaslikIndex] + a_muh_hesap_adi;
                        alfabetikBaslikIndex += 1;
                    }
                    else if (a_muh_kod.Length > 2) {
                        a_muh_hesap_adi = "    "+baslik.ToString() +"."+ a_muh_hesap_adi;
                        baslik += 1;                
                    }

                    if (a_muh_kod.ToString().Length == 1 || a_muh_kod.ToString().StartsWith("950"))
                    {
                        a_alacakToplam += a_alacak;
                        a_borcToplam += a_borc;
                        a_bakiyeToplam += a_bakiye;
                    }

                }
                else {
                    a_muh_kod = "";
                    a_muh_hesap_adi = "";
                    a_muh_hesap_adi1 = "";
                    a_alacak = 0;
                    a_borc = 0;
                    a_bakiye = 0;
                }
                //------------</Aktifler>
                bosluk = "";
                //------------<Pasifler>
                if (dSRaporlama.bilanco_pasif.Count() > i)
                {
                    p_muh_kod = dSRaporlama.bilanco_pasif[i][0].ToString();
                    p_muh_hesap_adi = dSRaporlama.bilanco_pasif[i][1].ToString();
                    p_muh_hesap_adi1 = dSRaporlama.bilanco_pasif[i][2].ToString();
                    p_alacak = (double)dSRaporlama.bilanco_pasif[i][3];
                    p_borc = (double)dSRaporlama.bilanco_pasif[i][4];
                    p_bakiye = (double)dSRaporlama.bilanco_pasif[i][5];

                    if (p_muh_kod.Length > 3)
                        if (p_muh_kod.Substring(3, 1) == "N")//nazım hesap
                        {
                            p_muh_kod = p_muh_kod.Replace('N', ' ') + " (950)";
                        }


                    if (p_muh_kod.Length == 1)
                    {
                        if (p_muh_kod_ilkHane != p_muh_kod)
                        {
                            p_muh_kod_ilkHane = p_muh_kod.ToString();//ilk iki
                            p_alfabetikBaslikIndex = 0;
                        }
                        //p_muh_hesap_adi = "=>" + p_muh_hesap_adi;
                    }
                    else if (p_muh_kod.Length == 2)
                    {
                        if (p_muh_kod_ilk_2hane != p_muh_kod)
                        {
                            p_muh_kod_ilk_2hane = p_muh_kod.ToString();//ilk iki
                            p_baslik = 1;
                        }
                        p_muh_hesap_adi = "  " + p_alfabetikBaslik[p_alfabetikBaslikIndex] + p_muh_hesap_adi;
                        p_alfabetikBaslikIndex += 1;
                    }
                    else if (p_muh_kod.Length == 3)
                    {
                        p_muh_hesap_adi = "    " + p_baslik.ToString() + "." + p_muh_hesap_adi;
                        p_baslik += 1;
                    }

                    if (p_muh_kod.ToString().Length == 1 || p_muh_kod.ToString().StartsWith("950"))
                    {
                        p_alacakToplam += p_alacak;
                        p_borcToplam += p_borc;
                        p_bakiyeToplam += p_bakiye;
                    }
                }
                else {
                    p_muh_kod = "";
                    p_muh_hesap_adi = "";
                    p_muh_hesap_adi1 = "";
                    p_alacak = 0;
                    p_borc = 0;
                    p_bakiye = 0;
                }
                //-------------</pasifler>

          
                dSRaporlama.bilanco.Rows.Add(a_muh_kod,a_muh_hesap_adi,a_muh_hesap_adi1,a_alacak,a_borc,a_bakiye,"",p_muh_kod,p_muh_hesap_adi,p_muh_hesap_adi1,p_alacak,p_borc,p_bakiye);
            }
            dSRaporlama.bilanco.Rows.Add("", "----------------------------", "", 0, 0, 0, "", "", "----------------------------", 0, 0, 0);
            dSRaporlama.bilanco.Rows.Add(" ", "Aktif(Varlıklar) Toplamı", "", a_alacakToplam, a_borcToplam, a_bakiyeToplam, "", "", "Pasif(Varlıklar) Toplamı", "", p_alacakToplam, p_borcToplam, p_bakiyeToplam);
        }

        private void firmaDoldur()
        {
            string firmaAdi = "";
            this.fIRMALARTableAdapter.Fill(this.dSRaporlama.FIRMALAR);

            foreach (DataRow dr in dSRaporlama.FIRMALAR)
            {
                firmaAdi += "'" + dr[0].ToString() + "',";
            }
            txtFirmaSec.Text = firmaAdi.Substring(0, firmaAdi.Length - 1);
        }

        private void Bilanco_Load(object sender, EventArgs e)
        {
            firmaDoldur();

            tarih1.Text = DateTime.DaysInMonth((DateTime.Now.Year - 1), 1) + ".12." + (DateTime.Now.Year - 1).ToString();
            tarih2.Text = DateTime.DaysInMonth(DateTime.Now.Year, 12).ToString() + ".12." + DateTime.Now.Year.ToString();      

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bilancoTablosu();
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

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ps_ciktiXls();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.dSRaporlama.bilanco_aktif.Clear();
            this.dSRaporlama.bilanco_pasif.Clear();
            this.dSRaporlama.bilanco.Clear();
        }

        private void buttonEdit1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmLookUpFirmaSec = new Ayarlar.lookUpBilancoFirmaSec();
            frmLookUpFirmaSec.frmBilanco = this;
            frmLookUpFirmaSec.Owner = this;
            frmLookUpFirmaSec.ShowDialog();
        }




    }
}
