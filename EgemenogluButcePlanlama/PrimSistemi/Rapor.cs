using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils;
using System.Data.Sql;
using System.Data.SqlClient;

namespace EgemenOgluRaporlama.PrimSistemi
{
    public partial class Rapor : DevExpress.XtraEditors.XtraForm
    {
        public Rapor()
        {
            InitializeComponent();
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

        private void Rapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSRaporlama.prim_DonemTanimlari' table. You can move, or remove it, as needed.
            this.prim_DonemTanimlariTableAdapter.Fill(this.dSRaporlama.prim_DonemTanimlari);

            for (int i = DateTime.Now.Year - 5; i < DateTime.Now.Year + 3; i++)
            {
                txtYil.Properties.Items.Add(i.ToString());
            }

            txtYil.Text = DateTime.Now.Year.ToString();
        }

        private void ps_aramaYap(string yil, string columns,string columns1)
        {
            string q = yil;
            decimal toplamMeblag=0;
            decimal hakedis=0;
            decimal devreden=0;
            decimal odenecekMiktar = 0;
            if (string.IsNullOrEmpty(q))
                MessageBox.Show("{Dönem} Seçilmedi!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                if (string.IsNullOrEmpty(columns))
                    this.dSRaporlama.prim_sistemiPivotRapor.Clear();
                else
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(Properties.Settings.Default.CsRaporlama);
                        SqlConnection.ClearPool(con);
                        con.Open();

                        string sorgu = "SELECT [Personel Kodu],[Personel Adı]," + columns1 + " FROM( " +
                                           " SELECT tbl0.Donem, ph.PerKodu'Personel Kodu', ph.PerAdi'Personel Adı', isnull(sum(ph.HakettigiPrim),0)'Hakettgi' " +
                                             " FROM (SELECT ph.DonemAdi+' ( '+ph.DonemYili+' )Hakkettiği'AS'Donem',ph.DonemAdi,ph.DonemYili " +
                                                   " FROM PrimHakedisleri ph  " +
                                           " GROUP BY ph.DonemAdi, ph.DonemYili) AS tbl0 LEFT JOIN PrimHakedisleri ph " +
                                                                               " ON ph.DonemAdi = tbl0.DonemAdi AND ph.DonemYili = tbl0.DonemYili " +
                                           " GROUP BY tbl0.Donem, ph.PerKodu, ph.PerAdi " +
                                   " )AS pTablo PIVOT ( SUM(pTablo.Hakettgi) " +
                                                          " FOR Donem IN (" + columns + ")) AS p";


                        SqlCommand cmd = new SqlCommand(sorgu, con);
                        cmd.CommandTimeout = 360;
                        SqlDataReader rdr = cmd.ExecuteReader();

                        dSRaporlama.prim_sistemiPivotRapor.Clear();
                        dSRaporlama.prim_sistemiPivotRapor.Columns.Clear();


                        gridControl1.DataSource = null;

                        dSRaporlama.prim_sistemiPivotRapor.Load(rdr);
 
                        gridControl1.DataSource = dSRaporlama.prim_sistemiPivotRapor;

                        foreach (DataRow row in dSRaporlama.prim_sistemiPivotRapor.Rows)
                        {
                            toplamMeblag = (decimal)this.queryies1.prim_odenenToplamMeblag(row[0].ToString(), Convert.ToDateTime(yil + "-01-01"), Convert.ToDateTime(yil + "-12-31"));

                            for (int i = 2; i < dSRaporlama.prim_sistemiPivotRapor.Columns.Count; i++)
                            {

                                if (i == 2 || i == 5 || i == 8 || i == 11 || i == 14 || i == 17 || i == 20 || i == 23 || i == 26 || i == 29 || i == 32 || i == 35)//en fazla 12 dönem olabilir | 1 ay = 1 dönem
                                    hakedis = Convert.ToDecimal(row[i].ToString());


                                if (i == 3 || i == 6 || i == 9 || i == 12 || i == 15 || i == 18 || i == 21 || i == 24 || i == 27 || i == 30 || i == 33 || i == 36)
                                {
                                    if (hakedis < toplamMeblag)
                                    {
                                        devreden = toplamMeblag - hakedis;
                                        odenecekMiktar = hakedis;
                                        toplamMeblag = devreden;
                                    }
                                    else
                                    {
                                        odenecekMiktar = toplamMeblag;
                                        toplamMeblag -= toplamMeblag;
                                        devreden = 0;
                                    }

                                    dSRaporlama.prim_sistemiPivotRapor.Columns[i].ReadOnly = false;//Tablo kolonu default olarak true geliyor yani değiştirilemiyordu.
                                    row[i] = odenecekMiktar;
                                }

                                if (i == 4 || i == 7 || i == 10 || i == 13 || i == 16 || i == 19 || i == 22 || i == 25 || i == 28 || i == 31 || i == 34 || i == 37)
                                {
                                    odenecekMiktar = Convert.ToDecimal(row[i - 2].ToString()) - Convert.ToDecimal(row[i - 1].ToString());

                                    dSRaporlama.prim_sistemiPivotRapor.Columns[i].ReadOnly = false;//Tablo kolonu default olarak true geliyor yani değiştirilemiyordu.
                                    row[i] = odenecekMiktar;
                                }

                            }
                            odenecekMiktar = 0;
                        }

                        for (int i = 2; i < dSRaporlama.prim_sistemiPivotRapor.Columns.Count; i++)
                        {
                            gridView1.Columns[i].DisplayFormat.FormatString = "{0:n2}";
                            gridView1.Columns[i].DisplayFormat.FormatType = FormatType.Custom;
                        }

                        for (int i = 1; i < dSRaporlama.prim_donemAdi.Rows.Count+1; i++)
                        {
                            if(i==1)
                                gridView1.Columns[4].AppearanceCell.Font = new Font(gridView1.Columns[i].AppearanceCell.Font, FontStyle.Bold);
                            else
                                gridView1.Columns[(i * 3) + 1].AppearanceCell.Font = new Font(gridView1.Columns[i].AppearanceCell.Font, FontStyle.Bold);
                        }

                        gridView1.BestFitColumns();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }
       
        private string fn_kolonlar() {
            this.prim_donemAdiTableAdapter.prim_donemIsimleri(dSRaporlama.prim_donemAdi,txtYil.Text);
            string kolonlar = "";

            if (this.dSRaporlama.prim_donemAdi.Rows.Count >= 1)
            {
                foreach (DataRow dr in dSRaporlama.prim_donemAdi)
                    kolonlar += "[" + dr[0].ToString() + "Hakkettiği]," + "[" + dr[0].ToString() + " Ödenen]," + "[" + dr[0].ToString() + " Kalan],";


                if (!string.IsNullOrEmpty(kolonlar))
                    kolonlar = kolonlar.Substring(0, kolonlar.Length - 1);
            }
            return kolonlar;
        }
        private string fn_kolonlar1()
        {
            this.prim_donemAdiTableAdapter.prim_donemIsimleri(dSRaporlama.prim_donemAdi, txtYil.Text);
            string kolonlar = "";
            // ISNULL ([1.Dönem ( 2013 ) Ödenen],0)'1.Dönem ( 2013 ) Ödenen'
            if (this.dSRaporlama.prim_donemAdi.Rows.Count >= 1)
            {
                foreach (DataRow dr in dSRaporlama.prim_donemAdi)
                    kolonlar += "ISNULL([" + dr[0].ToString() + "Hakkettiği],0)'" + "[" + dr[0].ToString() + "Hakkettiği]" + "'," + "ISNULL([" + dr[0].ToString() + " Ödenen],0)'" + "[" + dr[0].ToString() + " Ödenen]" + "'," + "ISNULL([" + dr[0].ToString() + " Kalan],0)'" + "[" + dr[0].ToString() + " Kalan]" + "',";


                if (!string.IsNullOrEmpty(kolonlar))
                    kolonlar = kolonlar.Substring(0, kolonlar.Length - 1);
            }
            return kolonlar;
        }
        private void btnExceleAktar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ps_ciktiXls();
        }

        private void btnDetayAc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ExpandAllGroups();
        }

        private void btnDetayKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.CollapseAllGroups() ;
        }

        private void btnGrupAc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gridView1.OptionsView.ShowGroupPanel = true;
        }

        private void btnGrupKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gridView1.OptionsView.ShowGroupPanel = false;
        }

        private void btnEnUygunGenislik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.BestFitColumns();
        }

        private void btnTemizle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.dSRaporlama.prim_sistemiPivotRapor.Clear();
            this.dSRaporlama.prim_sistemiPivotRapor.Columns.Clear();
        }

        private void btnSorgula_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ps_aramaYap(txtYil.Text,fn_kolonlar(),fn_kolonlar1());
        }

    }
}