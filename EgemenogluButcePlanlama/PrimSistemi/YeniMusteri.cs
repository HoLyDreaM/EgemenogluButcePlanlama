using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace EgemenOgluRaporlama.PrimSistemi
{
    public partial class YeniMusteri : DevExpress.XtraEditors.XtraForm
    {
        public YeniMusteri()
        {
            InitializeComponent();
        }

        private void YeniMusteri_Load(object sender, EventArgs e)
        {
            this.yeniMusteriTableAdapter.Fill(this.dSRaporlama.YeniMusteri);
            this.prim_MusteriGetirenPersonelTableAdapter.MusterGetiren_Personel(this.dSRaporlama.Prim_MusteriGetirenPersonel);
            dtBaslangicTarihi.DateTime = DateTime.Now;
        }

        private void txtGetirenKodu_EditValueChanged(object sender, EventArgs e)
        {
          this.prim_MusteriGetirenPersonelBindingSource.Position = this.prim_MusteriGetirenPersonelBindingSource.Find("GetirenCariKodu",txtGetirenKodu.Text);
        }

        private void txtGetirenAdi_EditValueChanged(object sender, EventArgs e)
        {
            this.prim_MusteriGetirenPersonelBindingSource.Position = this.prim_MusteriGetirenPersonelBindingSource.Find("GetirenAdi", txtGetirenAdi.Text);
        }

        private void txtMusteriKodu_EditValueChanged(object sender, EventArgs e)
        {
            this.yeniMusteriBindingSource.Position = this.yeniMusteriBindingSource.Find("MusteriKodu",txtMusteriKodu.Text);
        }

        private void txtMusteriAdi_EditValueChanged(object sender, EventArgs e)
        {
            this.yeniMusteriBindingSource.Position = this.yeniMusteriBindingSource.Find("MusteriAdi", txtMusteriAdi.Text);
        }

        private void btnYeni_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //txtGetirenAdi.Text = "";
            //txtGetirenIl.Text = "";
            //txtGetirenKodu.Text = "";
            //txtID.Text = "0";
            //txtGetirenFullAd.Text = "";

            //txtMusteriAdi.Text = "";
            //txtMusteriKodu.Text = "";
            //txtMusteriIli.Text = "";
            //txtMusteriId.Text = "0";
            //txtMusteriFullAd.Text = "";
            this.prim_MusteriGetirenPersonelTableAdapter.MusterGetiren_Personel(this.dSRaporlama.Prim_MusteriGetirenPersonel);
            this.yeniMusteriTableAdapter.Fill(this.dSRaporlama.YeniMusteri); 
        }

        private void btnKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            try
            {
                if (!string.IsNullOrEmpty(txtID.Text)||!string.IsNullOrEmpty(txtMusteriId.Text))
                {
                    string getirenTuru = "";
                    string musteriTuru = "";
                    if (txtGetirenTuru.Text == "Personel")
                    {
                        getirenTuru = "P";
                        musteriTuru = "M";
                    }
                    else
                    {
                        getirenTuru = "EM";
                        musteriTuru = "M";
                    }

                    if (!Convert.ToBoolean(this.queryies1.prim_musteriKontrol(Convert.ToInt32(txtMusteriId.Text))))
                    {
                        if (MessageBox.Show("Kaydetmek istediğinize emin misiniz?","Yeni Kayıt",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                        {
                            this.queryies1.prim_hareketEkle(Convert.ToInt32(txtID.Text), getirenTuru, Convert.ToInt32(txtMusteriId.Text), musteriTuru, dtBaslangicTarihi.DateTime, "Erkan123",DateTime.Now,Convert.ToInt32(txtPiramidinBasi.Text));
                            //Kayıt eklendikden sonra Müşteri ve Personelleri yeniden doldur
                            this.prim_MusteriGetirenPersonelTableAdapter.MusterGetiren_Personel(this.dSRaporlama.Prim_MusteriGetirenPersonel);
                            this.yeniMusteriTableAdapter.Fill(this.dSRaporlama.YeniMusteri);        
                      }
                    }else
                        MessageBox.Show("Bu Müşteri Sistemde Mevcut!", "Müşteri Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button3, MessageBoxOptions.ServiceNotification);
                }else
                    MessageBox.Show("{Getiren ID},{Müşteri ID}  Boş Geçilemez!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
 
    }
}