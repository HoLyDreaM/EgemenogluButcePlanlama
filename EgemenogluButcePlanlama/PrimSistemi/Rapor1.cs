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

namespace EgemenOgluRaporlama.PrimSistemi
{
    public partial class Rapor1 : DevExpress.XtraEditors.XtraForm
    {
        public Rapor1()
        {
            InitializeComponent();
        }

        private void ps_sorgula(string yil) {
            try
            {
                if (string.IsNullOrEmpty(yil))
                    MessageBox.Show("{Dönem yılı} boş olamaz!");

                string sorgu = "SELECT *,tbl2.Hakettigi-tbl2.Odenen'Kalan' FROM( " +
                   " SELECT *,(SELECT isnull(SUM(po.Meblag),0) FROM  EgemenogluRaporlama.dbo.PrimOdemeleri po WHERE po.PerKodu = tbl1.PerKodu AND convert(nvarchar(10),po.PrimTarihi,102) BETWEEN convert(VARCHAR,'" + yil + ".01.01',102) AND convert(VARCHAR,'" + yil + ".12.31',102))'Odenen'  FROM(  " +
                       " SELECT tbl0.PerKodu, tbl0.PerAdi, sum(ph.Meblag)'Kazandirdigi', avg(ph.PrimOrani)'PrimOrani', sum(ph.HakettigiPrim)'Hakettigi'  " +
                         " from(  " +
                               " SELECT ph.PerKodu, ph.PerAdi,ph.DonemYili FROM  EgemenogluRaporlama.dbo.PrimHakedisleri ph  " +
                               " WHERE ph.DonemYili='" + yil + "'  " +
                               " GROUP BY ph.PerKodu, ph.PerAdi,ph.DonemYili  " +
                        " ) AS tbl0 LEFT JOIN  EgemenogluRaporlama.dbo.PrimHakedisleri ph ON ph.DonemYili = tbl0.DonemYili AND ph.PerKodu = tbl0.PerKodu  " +
                       " WHERE ph.DonemYili='" + yil + "'  " +
                       " GROUP BY  tbl0.PerKodu, tbl0.PerAdi  " +
                   " )AS tbl1  " +
               " )AS tbl2";

                using (SqlConnection con = new SqlConnection(Properties.Settings.Default.CsRaporlama))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    using (SqlCommand cmd = new SqlCommand(sorgu,con))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        dSRaporlama.prim_raporu1.Clear();
                        dSRaporlama.prim_raporu1.Load(dr);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Rapor1_Load(object sender, EventArgs e)
        {
            for (int i = DateTime.Now.Year - 5; i < DateTime.Now.Year + 3; i++)
            {
                txtYil.Properties.Items.Add(i.ToString());
            }

            txtYil.Text = DateTime.Now.Year.ToString();
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
        private void btnSorgula_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ps_sorgula(txtYil.Text);
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ps_ciktiXls();
        }

        private void btnDetayAc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ExpandAllGroups();
        }

        private void btnDetayKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.CollapseAllGroups();
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
            this.dSRaporlama.prim_raporu1.Clear();
            this.dSRaporlama.prim_raporu1.Columns.Clear();
        }
    }
}