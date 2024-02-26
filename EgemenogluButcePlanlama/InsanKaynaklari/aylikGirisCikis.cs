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
using System.Text.RegularExpressions;
namespace EgemenOgluRaporlama.InsanKaynaklari
{
    public partial class aylikGirisCikis : DevExpress.XtraEditors.XtraForm
    {
        public aylikGirisCikis()
        {
            InitializeComponent();
        }
        public AnaForm anaFrm { get; set; }
        Thread t;
        DateTime tt, tt1;
        public DateTime altTarih, UstTarih;
        DataTable dTable;
        Regex reg;
        string regDesen = "^(0[1-9]|[12][0-9]|3[01])[.](0[1-9]|1[012])[.](19|20)[0-9]{2} - (0[1-9]|[12][0-9]|3[01])[.](0[1-9]|1[012])[.](19|20)[0-9]{2}$";
      
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
        private string fn_ilAdiCek()
        {
            string q1 = null;
            string q = null;
            for (int i = 0; i < anaFrm.lbIller.CheckedItems.Count; i++)
            {
                q1 = anaFrm.lbIller.Items[anaFrm.lbIller.CheckedIndices[i]].Description;
                q += ("'" + q1 + "',");
            }

            if (string.IsNullOrEmpty(q))
            {
                q = null;
            }
            else
                q = q.Substring(0, q.Length - 1);

            return q;
        }
        private string fn_departmanCek()
        {
            string q1 = null;
            string q = null;
            for (int i = 0; i < anaFrm.lbDepartmanlar.CheckedItems.Count; i++)
            {
                q1 = anaFrm.lbDepartmanlar.Items[anaFrm.lbDepartmanlar.CheckedIndices[i]].ToString();
                q += ("'" + q1 + "',");
            }

            if (string.IsNullOrEmpty(q))
            {
                q = null;
            }
            else
                q = q.Substring(0, q.Length - 1);

            return q;
        }

        delegate void dlg_gridviewPopulation();
        void fn_gridviewPopulation()
        {
            if (base.InvokeRequired)
            {
                base.Invoke(new dlg_gridviewPopulation(fn_gridviewPopulation));
            }
            else
                gridView1.PopulateColumns();
        }

        delegate void dlg_gridviewDatasource();
        void fn_gridviewDatasource()
        {
            if (base.InvokeRequired)
            {
                base.Invoke(new dlg_gridviewPopulation(fn_gridviewDatasource));
            }
            else
                gridControl1.DataSource = dSRaporlama.Aylik;
        }

        delegate void dlg_gridviewVisibleColum(int index);
        void fn_gridviewVisibleColum(int index)
        {
            if (base.InvokeRequired)
            {
                base.Invoke(new dlg_gridviewVisibleColum(this.fn_gridviewVisibleColum), index);

            }
            else
                gridView1.Columns[index].Visible = false;

        }

        delegate void dlg_gridviewBestFitColumns();
        void fn_gridviewBestFitColumns()
        {
            if (base.InvokeRequired)
            {
                base.Invoke(new dlg_gridviewBestFitColumns(this.fn_gridviewBestFitColumns));
            }
            else
                gridView1.BestFitColumns();

        }
     
        delegate void dlg_gridviewNull();
        void fn_gridviewNull()
        {
            if (base.InvokeRequired)
            {
                base.Invoke(new dlg_gridviewNull(this.fn_gridviewNull));
            }
            else
                gridControl1.DataSource = null;

        }

        private void ps_aramaYap(string ilAdiCek, string departmanCek, string columns)
        {
            string q = ilAdiCek;
            string q1 = departmanCek;
            if (string.IsNullOrEmpty(q))
                MessageBox.Show("Arama Kriteri Olarak {İL} Seçilmedi!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                if (string.IsNullOrEmpty(q1))
                    MessageBox.Show("Arama Kriteri Olarak {DEPARTMAN} Seçilmedi!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    try
                    {
                        barButtonItem1.Enabled = false;
                        barButtonItem2.Enabled = false;
                        SqlConnection con = new SqlConnection(Properties.Settings.Default.CsInsanKaynaklari);
                        SqlConnection.ClearPool(con);
                        con.Open();

                        string sorgu = " SELECT kList.EmpNum 'ID', kList.AdiSoyadi, kList.il 'İL', kList.Departman,g.* from dbo.fn_01() kList LEFT JOIN " +
                                       " (SELECT p.* " +
                                         " FROM (SELECT f.EmpNum,convert(NVARCHAR,f.ilkGirisZamani,108) AS ilkGirisZamani,(CASE f.BTip WHEN 0 THEN 'Ilk Giriş' ELSE 'Son Çıkış' END) +' : '+  f.Tarih AS Tarih " +
                                                       " FROM dbo.fn_04_3('" + ps_aramaIcinTarihCek(cmbTarihAraligi.Text, 1).ToString("yyyy.MM.dd") + "','" + ps_aramaIcinTarihCek(cmbTarihAraligi.Text, 2).ToString("yyyy.MM.dd") + "') f) tbl1  " +
                                        " PIVOT (max(tbl1.ilkGirisZamani) FOR tbl1.Tarih IN (  " +
                                        columns
                                        + " )) p)AS g " +
                                        " ON kList.EmpNum = g.EmpNum " +
                                        "Where kList.il in(" + q + ") and kList.Departman in (" + q1 + ")";

                        SqlCommand cmd = new SqlCommand(sorgu, con);
                        cmd.CommandTimeout = 360;

                        SqlDataReader rdr = cmd.ExecuteReader();

                        dSRaporlama.Aylik.Clear();
                        dSRaporlama.Aylik.Columns.Clear();

                        fn_gridviewPopulation();//gridView1.PopulateColumns();

                        fn_gridviewNull();// gridControl1.DataSource = null;

                        dSRaporlama.Aylik.Load(rdr);
                        fn_gridviewDatasource();// gridControl1.DataSource = dSRaporlama.Haftalik;

                        fn_gridviewVisibleColum(4);//gridView1.Columns[4].Visible = false;
                        fn_gridviewBestFitColumns();//gridView1.BestFitColumns();


                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }finally { 
                    
                    barButtonItem1.Enabled = true;
                    barButtonItem2.Enabled = true;
                    }   
                }
        }

        private void ps_kayitGetir() {
            try
            {
                ps_aramaYap(fn_ilAdiCek(), fn_departmanCek(), ps_sorgudaKullanilacakKolonlar(ps_aramaIcinTarihCek(cmbTarihAraligi.Text, 1), ps_aramaIcinTarihCek(cmbTarihAraligi.Text, 2)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        
        }

        private void ps_AylikTarihler(DateTime t, DateTime t1)
        {
            try
            {
                List<string> list = new List<string>();
                int i = 0;

                while (t <= t1)
                {
                    list.Insert(i++,t.ToString("dd.MM.yyyy") + " - " + t.AddDays(DateTime.DaysInMonth(t.Year, t.Month) - 1).ToString("dd.MM.yyyy"));
                    t = t.AddMonths(1);
                }

                for (int ii = list.Count -1; ; ii--)
                {
                    cmbTarihAraligi.Properties.Items.Add(list[ii].ToString());
                }
            }
            catch
            {
            }
        }
        private DateTime ps_aramaIcinTarihCek(string stringTarih, short kacinciTarih_1_2)
        {
            DateTime tarih = DateTime.MinValue;
            // {01.01.2013} - {01.12.2013}
            try
            {
                switch (kacinciTarih_1_2)
                {
                    case 1:
                        stringTarih = stringTarih.Substring(0, 10); break;
                    case 2:
                        stringTarih = stringTarih.Substring(13, 10); break;
                }
                tarih = Convert.ToDateTime(stringTarih);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Girilen tarih formatında bir hata var! " + ex.Message.ToString());
                tarih = DateTime.Now;
            }

            return tarih;
        }
        private string ps_sorgudaKullanilacakKolonlar(DateTime ps_aramaIcinTarihCek1, DateTime ps_aramaIcinTarihCek2)
        {
            //[Ilk Giriş : 2012-01-02],[Son Çıkış : 2012-01-02],[Ilk Giriş : 2012-01-03],[Son Çıkış : 2012-01-03],[Ilk Giriş : 2012-01-04],[Son Çıkış : 2012-01-04],
            string colums = null;
            while (ps_aramaIcinTarihCek1 < ps_aramaIcinTarihCek2)
            {
                colums += "[Ilk Giriş : " + ps_aramaIcinTarihCek1.ToString("yyyy-MM-dd") + "],[Son Çıkış : " + ps_aramaIcinTarihCek1.ToString("yyyy-MM-dd") + "],";
                ps_aramaIcinTarihCek1 = ps_aramaIcinTarihCek1.AddDays(1);
            }
            return colums.Substring(0, colums.Length - 1);
        }
    
        private void aylikGirisCikis_Load(object sender, EventArgs e)
        {
            reg = new Regex(regDesen);
            ps_AylikTarihler(Convert.ToDateTime("01.01.2010"), Convert.ToDateTime("31.12."+DateTime.Now.Year.ToString()));
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (reg.IsMatch(cmbTarihAraligi.Text))
            {
                t = new Thread(new ThreadStart(ps_kayitGetir));
                t.Start();
            }
            else
            {
                MessageBox.Show("Tarih formatını doğru girmediniz! Format:[GG.AA.YYYY - GG.AA.YYYY]");
            }       
      
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ps_ciktiXls();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dSRaporlama.Aylik.Clear();
            dSRaporlama.Aylik.Columns.Clear();
            gridView1.PopulateColumns();
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
    }
}