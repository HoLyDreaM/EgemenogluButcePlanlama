using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace EgemenOgluRaporlama.Ayarlar
{
    public partial class PersoneleGrupAtama : DevExpress.XtraEditors.XtraForm
    {
        public PersoneleGrupAtama()
        {
            InitializeComponent();
        }

        private void PersoneleGrupAtama_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSRaporlama.prim_GrupTanimlari' table. You can move, or remove it, as needed.
            this.prim_GrupTanimlariTableAdapter.Fill(this.dSRaporlama.prim_GrupTanimlari);
            this.prim_PersoneleGrupAtamaTableAdapter.Fill(this.dSRaporlama.Prim_PersoneleGrupAtama);
        }
        private void ps_ciktiXls()
        {
            if (gridView2.RowCount > 0)
            {
                raporKaydet.Title = "Rapor Kaydet!";
                raporKaydet.DefaultExt = "Rapor Kaydet";
                raporKaydet.Filter = "Excel Dosyaları (*.xls)|*.xls";

                DialogResult = raporKaydet.ShowDialog();
                if (DialogResult == DialogResult.OK || DialogResult == DialogResult.Yes)
                {
                    gridView2.ExportToExcelOld(raporKaydet.FileName);
                }
            }
        }

        private void btnYeni1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.prim_PersoneleGrupAtamaTableAdapter.Fill(this.dSRaporlama.Prim_PersoneleGrupAtama);
        }

        private void txtGrupAdi_Properties_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            try
            {
                DataRow row = ((DataRowView)txtGrupAdi.Properties.GetRowByKeyValue(txtGrupAdi.EditValue)).Row;
                txtPrimOrani.Text= row[2].ToString();
                txtGrupKodu.Text = row[0].ToString();
            }
            catch
            {
            }  
        }

        private void btnExceleAktar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ps_ciktiXls();
        }

        private void btnKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGrupAdi.Text))
            {
                if ((int)this.queryies1.prim_personelKontrol(Convert.ToInt32(txtPerID.Text)) == 0)
                    this.queryies1.prim_personelGrupEslesmesiKayitEkle(Convert.ToInt32(txtPerID.Text), Convert.ToInt32(txtGrupKodu.Text));
                else
                    this.queryies1.prim_personelGrupEslesmesiKayitGuncelle(Convert.ToInt32(txtGrupKodu.Text),Convert.ToInt32(txtPerID.Text));
                
                this.prim_PersoneleGrupAtamaTableAdapter.Fill(dSRaporlama.Prim_PersoneleGrupAtama);
                
            }else
                MessageBox.Show("{Grup Adı} Boş Bırakılamaz.");
        }

        private void btnSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?","Kayıt Sil!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    if (!string.IsNullOrEmpty(txtPerID.Text) && !string.IsNullOrEmpty(txtGrupKodu.Text))
                    {
                        this.queryies1.prim_personelGrupEslesmesiKayitSil(Convert.ToInt32(txtPerID.Text));
                        this.prim_PersoneleGrupAtamaTableAdapter.Fill(dSRaporlama.Prim_PersoneleGrupAtama);
                    }
                    else
                        MessageBox.Show("Silinecek Grup Kodu Bulunamadı!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());             
            }
     
        }

    }
}