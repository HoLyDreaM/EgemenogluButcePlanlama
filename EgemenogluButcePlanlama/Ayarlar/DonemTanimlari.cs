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
    public partial class DonemTanimlari : DevExpress.XtraEditors.XtraForm
    {
        public DonemTanimlari()
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
        private void butonDurumlari(Boolean yeni, Boolean kaydet, Boolean vazgec, Boolean sil, Boolean yenile, Boolean onay)
        {
            btnYeni.Enabled = yeni;
            btnKaydet.Enabled = kaydet;
            btnVazgec.Enabled = vazgec;
            btnSil.Enabled = sil;
            btnYenile.Enabled = yenile;

        }

        private void DonemTanimlari_Load(object sender, EventArgs e)
        {
            this.prim_DonemTanimlariTableAdapter.Fill(this.dSRaporlama.prim_DonemTanimlari);
        }

        private void btnExceleAktar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ps_ciktiXls();
        }

        private void btnYenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.prim_DonemTanimlariTableAdapter.Fill(this.dSRaporlama.prim_DonemTanimlari);
        }

        private void btnYeni_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtDonemAdi.Focus();
            primDonemTanimlariBindingSource.AddNew();
            gridControl1.Enabled = false;
            butonDurumlari(false, true, true, false, false, false);
        }

        private void btnVazgec_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            butonDurumlari(true, true, true, true, true, true);
            primDonemTanimlariBindingSource.CancelEdit();
            gridControl1.Enabled = true;
        }

        private void btnSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.DataRowCount > 0)
            {
                if (MessageBox.Show("Kayıt Silincek! Onaylıyor musunuz?", "Kayıt Sil!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
                {
                    this.queryies1.prim_donemSil(Convert.ToInt32(txtID.Text));
                    primDonemTanimlariBindingSource.RemoveCurrent();
                    butonDurumlari(true, true, true, true, true, true);
                    gridControl1.Enabled = true;
                }
            }
        }

        private void btnKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if ((!string.IsNullOrEmpty(txtID.Text)) && !string.IsNullOrEmpty(txtDonemAdi.Text))
            {
                if (txtDonemBasi.DateTime.Year.ToString()==txtDonemSonu.DateTime.Year.ToString())
                {
                        try
                        {
                            if (Convert.ToInt32(txtID.Text) < 0)
                            {
                                this.queryies1.prim_donemEkle(txtDonemAdi.Text, txtDonemBasi.DateTime, txtDonemSonu.DateTime, txtDonemBasi.DateTime.ToString("yyyy"));
                                this.prim_DonemTanimlariTableAdapter.Fill(this.dSRaporlama.prim_DonemTanimlari);
                                butonDurumlari(true, true, true, true, true, true);
                                gridControl1.Enabled = true;
                            }
                            else
                            {
                                this.queryies1.prim_donemGuncelle(txtDonemAdi.Text, txtDonemBasi.DateTime, txtDonemSonu.DateTime, txtDonemBasi.DateTime.ToString("yyyy"), Convert.ToInt32(txtID.Text));
                                //this.prim_GrupTanimlariTableAdapter.Fill(dSRaporlama.prim_GrupTanimlari);
                                this.primDonemTanimlariBindingSource.EndEdit();
                                butonDurumlari(true, true, true, true, true, true);
                                gridControl1.Enabled = true;
                            }
                        }
                        catch (Exception ex)
                        {
                            btnVazgec_ItemClick(sender, e);
                            MessageBox.Show(ex.Message.ToString());
                        }

                }else
                    MessageBox.Show("Dönem Başı ve Dönem Sonu Tarihleri Aynı Yıl İçerisinde Olmalı!");
            }
            else
            {
                MessageBox.Show("{Dönem Adı} Boş bırakılamaz!");
            }
        }
    }
}