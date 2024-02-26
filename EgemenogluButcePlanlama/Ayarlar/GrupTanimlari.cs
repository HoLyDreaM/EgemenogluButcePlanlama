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
    public partial class GrupTanimlari : DevExpress.XtraEditors.XtraForm
    {
        public GrupTanimlari()
        {
            InitializeComponent();
        }

        private void butonDurumlari(Boolean yeni, Boolean kaydet, Boolean vazgec, Boolean sil, Boolean yenile, Boolean onay)
        {
            btnYeni.Enabled = yeni;
            btnKaydet.Enabled = kaydet;
            btnVazgec.Enabled = vazgec;
            btnSil.Enabled = sil;
            btnYenile.Enabled = yenile;
   
        }

        private void GrupTanimlari_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSRaporlama.prim_GrupTanimlari' table. You can move, or remove it, as needed.
            this.prim_GrupTanimlariTableAdapter.Fill(this.dSRaporlama.prim_GrupTanimlari);
            // TODO: This line of code loads data into the 'dSRaporlama.prim_GrupTanimlari' table. You can move, or remove it, as needed.
            this.prim_GrupTanimlariTableAdapter.Fill(this.dSRaporlama.prim_GrupTanimlari);
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
        private void btnYeni_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtGrupAdi.Focus();
            primGrupTanimlariBindingSource.AddNew();
            gridControl1.Enabled = false;
            butonDurumlari(false, true, true, false, false, false);
            txtPrimOrani.Text = "0";
        }

        private void btnKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if ((!string.IsNullOrEmpty(txtGrupKodu.Text)) && !string.IsNullOrEmpty(txtGrupAdi.Text))
            {
                try
                {
                    if (Convert.ToInt32(txtGrupKodu.Text)<0)
                    {
                        this.queryies1.prim_grupTanimiEkle(txtGrupAdi.Text, Convert.ToDecimal(txtPrimOrani.Text), true);
                        this.prim_GrupTanimlariTableAdapter.Fill(dSRaporlama.prim_GrupTanimlari);
                        butonDurumlari(true, true, true, true, true, true);
                        gridControl1.Enabled = true;
                    }
                    else
                    {
                        this.queryies1.prim_grupTanimiGuncelle(txtGrupAdi.Text, Convert.ToDecimal(txtPrimOrani.Text), true,Convert.ToInt32(txtGrupKodu.Text));
                        //this.prim_GrupTanimlariTableAdapter.Fill(dSRaporlama.prim_GrupTanimlari);
                        this.primGrupTanimlariBindingSource.EndEdit();
                        butonDurumlari(true, true, true, true, true, true);
                        gridControl1.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    btnVazgec_ItemClick(sender, e);
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show("{Grup Adı} Boş bırakılamaz!");
            }

        }

        private void btnVazgec_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            butonDurumlari(true, true, true, true, true, true);
            primGrupTanimlariBindingSource.CancelEdit();
            gridControl1.Enabled = true;
        }

        private void btnSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGrupKodu.Text))
            if (MessageBox.Show("Kayıt Silincek! Onaylıyor musunuz?", "Kullanıcı Sil!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
            {
                this.queryies1.prim_grupTanimiSil(Convert.ToInt32(txtGrupKodu.Text));
                primGrupTanimlariBindingSource.RemoveCurrent();
                butonDurumlari(true, true, true, true, true, true);
                gridControl1.Enabled = true;
            }
        }


        private void btnExceleAktar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ps_ciktiXls();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.prim_GrupTanimlariTableAdapter.Fill(dSRaporlama.prim_GrupTanimlari);
        }
    }
}