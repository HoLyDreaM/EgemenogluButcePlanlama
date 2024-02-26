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
    public partial class PrimHesapla : DevExpress.XtraEditors.XtraForm
    {
        public PrimHesapla()
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
                    gridView1.ExportToExcelOld(raporKaydet.FileName);
                }
            }
        }
    
        public void ps_PrimKaydet(){
            SqlBulkCopy sbc = new SqlBulkCopy(Properties.Settings.Default.CsRaporlama.ToString());
            sbc.DestinationTableName = "PrimHakedisleri";
            sbc.BatchSize = 1000;
            sbc.NotifyAfter = 1;
            sbc.BulkCopyTimeout = 60;
            // Dataset - VeriTabanı
            sbc.ColumnMappings.Add(0, 1);
            sbc.ColumnMappings.Add(1, 2);
            sbc.ColumnMappings.Add(2, 3);
            sbc.ColumnMappings.Add(3, 4);
            sbc.ColumnMappings.Add(4, 5);
            sbc.ColumnMappings.Add(5, 6);
            sbc.ColumnMappings.Add(6, 7);
            sbc.ColumnMappings.Add(7, 8);
            sbc.ColumnMappings.Add(8, 9);
            sbc.ColumnMappings.Add(9, 10);
            sbc.ColumnMappings.Add(10, 11);
            sbc.ColumnMappings.Add(11, 12);
            sbc.ColumnMappings.Add(12, 13);
            sbc.ColumnMappings.Add(13, 14);
            sbc.ColumnMappings.Add(14, 15);
            sbc.ColumnMappings.Add(15, 16);
            sbc.ColumnMappings.Add(16, 17);
            sbc.ColumnMappings.Add(17, 18);
            sbc.ColumnMappings.Add(18, 19);
            sbc.ColumnMappings.Add(19, 20);
            sbc.ColumnMappings.Add(20, 21);
            sbc.ColumnMappings.Add(21, 22);
            sbc.ColumnMappings.Add(22, 23);

            sbc.ColumnMappings.Add(26, 24);//ProjeKodu
            sbc.ColumnMappings.Add(27, 25);
            sbc.ColumnMappings.Add(28, 26);
            sbc.ColumnMappings.Add(29, 27);

            sbc.ColumnMappings.Add(30, 28);//EkAlan1
            sbc.ColumnMappings.Add(31, 29);
            sbc.ColumnMappings.Add(32, 30);
            sbc.WriteToServer(dSRaporlama.primHareketleri);
            sbc.Close();
            MessageBox.Show(txtDonemAdi.Text+"("+txtDonem.Text+") Kayıt edildi!.");
        }

        private void PrimHesapla_Load(object sender, EventArgs e)
        {
            this.prim_DonemTanimlariTableAdapter.Fill(this.dSRaporlama.prim_DonemTanimlari);
        }

        private void txtGrupAdi_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataRow row = gridLookUpEdit1View.GetFocusedDataRow();
                txtDonemBasi.Text = row[2].ToString().Substring(0, 10);
                txtDonemSonu.Text = row[3].ToString().Substring(0, 10);
                txtDonemAdi.Text = row[1].ToString();
                txtDonem.Text = row[4].ToString();

                this.primHareketleriTableAdapter.kayitliKayitlariGetir(dSRaporlama.primHareketleri, txtDonemAdi.Text, txtDonem.Text);
            }
            catch
            {
            }  
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (gridView1.DataRowCount <= 0)
                    MessageBox.Show("Kayıt bulunamadı!");
                else
                {
                    if ((int)this.queryies1.prim_primHareketKontrol(txtDonemAdi.Text,txtDonem.Text)>0)
                        MessageBox.Show("Bu döneme ait kayıt mevcut!");
                    else
                         if (MessageBox.Show( "Kaydetmek istediğinize Emin misiniz?","Prim Kaydet!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                         ps_PrimKaydet();
                          
                }
	        }
	        catch (Exception ex)
	        {
                MessageBox.Show(ex.Message.ToString());
	        }
           
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ps_ciktiXls();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.DataRowCount <= 0)
                MessageBox.Show("Siliecek Kayıt Bulunamadı!");
            else
                if (MessageBox.Show("Bu Dönemin Kayıtlarını Silmek İstediğiniz Emin misiniz?", "Kayıt Sil!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.primHareketleriTableAdapter.donemSil(txtDonemAdi.Text,txtDonem.Text);
                    this.primHareketleriTableAdapter.kayitliKayitlariGetir(dSRaporlama.primHareketleri, txtDonemAdi.Text, txtDonem.Text);
                }
        }

        private void btnTemizle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDonemAdi.Text) || !string.IsNullOrEmpty(txtDonem.Text))
            this.primHareketleriTableAdapter.kayitliKayitlariGetir(dSRaporlama.primHareketleri, txtDonemAdi.Text, txtDonem.Text);
        }

        private void btnHesapla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDonem.Text) || !string.IsNullOrEmpty(txtDonemAdi.Text))
            {
                this.primHareketleriTableAdapter.Fill(dSRaporlama.primHareketleri,Convert.ToDateTime(txtDonemBasi.Text).ToString("yyyy.MM.dd"),Convert.ToDateTime(txtDonemSonu.Text).ToString("yyyy.MM.dd"), txtDonemAdi.Text, txtDonem.Text);
            }else
                MessageBox.Show("Dönem Seçimi Yapmadınız!");
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

        private void btnGenislik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.BestFitColumns();
        }
    }
}