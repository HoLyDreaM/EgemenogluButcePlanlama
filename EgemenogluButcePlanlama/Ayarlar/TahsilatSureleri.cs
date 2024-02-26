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
    public partial class TahsilatSureleri : DevExpress.XtraEditors.XtraForm
    {
        public TahsilatSureleri()
        {
            InitializeComponent();
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

        private void TahsilatSureleri_Load(object sender, EventArgs e)
        {
            this.prim_TahsilatSureleriTableAdapter.fill(this.dSRaporlama.prim_TahsilatSureleri);
        }

        private void btnKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSmKodu.Text))
            {
                if (txtID.Text == "0")
                    this.queryies1.prim_isTahsilatGunuEkle(txtSmKodu.Text,txtSmAdi.Text,Convert.ToInt32(txtGun.Text));
                else
                    this.queryies1.prim_isTahsilatGunuGuncelle(Convert.ToInt32(txtID.Text),Convert.ToInt32(txtGun.Text));

                this.prim_TahsilatSureleriTableAdapter.fill(this.dSRaporlama.prim_TahsilatSureleri);
            }
            else
                MessageBox.Show("{Sm Kodu} Boş Bırakılamaz.");
        }

        private void btnYenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.prim_TahsilatSureleriTableAdapter.fill(this.dSRaporlama.prim_TahsilatSureleri);
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ps_ciktiXls();
        }

        private void btnSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?", "Kayıt Sil!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    if (!string.IsNullOrEmpty(txtID.Text) || txtID.Text == "0")
                    {
                        this.queryies1.prim_isTahsilatGunusil(Convert.ToInt32(txtID.Text));
                        //this.prim_TahsilatSureleriTableAdapter.fill(this.dSRaporlama.prim_TahsilatSureleri);
                        this.primTahsilatSureleriBindingSource.EndEdit();
                    }
                    else
                        MessageBox.Show("Silinecek Kayıt Bulunamadı!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}