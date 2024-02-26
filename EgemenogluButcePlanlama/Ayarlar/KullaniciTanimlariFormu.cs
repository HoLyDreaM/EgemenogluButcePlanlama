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
    public partial class KullaniciTanimlariFormu : DevExpress.XtraEditors.XtraForm
    {
        public KullaniciTanimlariFormu()
        {
            InitializeComponent();
        }

        private void butonDurumlari(Boolean yeni , Boolean kaydet ,Boolean vazgec , Boolean sil,Boolean yenile,Boolean onay) {
            btnYeni.Enabled = yeni;
            btnKaydet.Enabled = kaydet;
            btnVazgec.Enabled = vazgec;
            btnSil.Enabled = sil;
            btnYenile.Enabled = yenile;
            btnOnay.Enabled = onay;
        }

        private void KullaniciTanimlariFormu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSRaporlama.Kullanicilar' table. You can move, or remove it, as needed.
            this.kullanicilarTableAdapter.GetAllUser(this.dSRaporlama.Kullanicilar);
            tabGecisiYap();
        }

        private void tabGecisiYap(){
            xtraTabControl1.SelectedTabPageIndex = 3;
            xtraTabControl1.SelectedTabPageIndex = 2;
            xtraTabControl1.SelectedTabPageIndex = 1;
            xtraTabControl1.SelectedTabPageIndex = 0;
        }

        private void btnYeni_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtAdiSoyadi.Focus();
            kullanicilarBindingSource.AddNew();
            gridControl1.Enabled = false;
            butonDurumlari(false,true,true,true,false,false);
            txtIlYetkisi.Text = ".";
            iFiltreYetkisiTextBox.Text = ".";
            txtSorumlulukMerkezleri.Text = ".";
            //aktifCheckBox.Checked = false;
            iBankaHaraketleriCheckBox.Checked = false;
            iKasaHareketleriCheckBox.Checked = false;
            iGiderlerCheckBox.Checked = false;
            iLikiditeCheckBox.Checked = false;
            iMuvekkilCheckBox.Checked = false;
            iKullaniciCheckBox.Checked = false;
            iPersonelAvanslariCheckBox.Checked = false;
            iBilancoCheckBox.Checked = false;
            iKasalarArasiCheckBox.Checked = false;
            iGelirCheckBox.Checked = false;
            iCekSenetCheckBox.Checked = false;
            iEmanetKasaCheckBox.Checked = false;
            iMenuFinansCheckBox.Checked = false;
            iMenuAyarlarCheckBox.Checked = false;
            iMenuInsanKaynaklariCheckBox.Checked = false;
            aktifCheckBox.Checked = false;

            iGirisCheckBox.Checked = false;
            iGirisCikisAylikCheckBox.Checked = false;
            iGirisCikisCheckBox.Checked = false;
            iGirisCikisDegisikliklerCheckBox.Checked = false;
            iGirisCikisHaftalikCheckBox.Checked = false;
            iGirisCikisTarihAraligiCheckBox.Checked = false;
            iKayitDuzenlemeCheckBox.Checked = false;
            iGirisCikis_OtoYenileCheckBox.Checked = false;
            iGiris_OtoYenileCheckBox.Checked = false;
            iGuncellemeCheckBox.Checked = false;

            iGrupVePrim.Checked = false;
            iPrimGiris.Checked = false;
            iPrimHesapla.Checked = false;
            iPrimRaporu.Checked = false;
            iPrimSistemi.Checked = false;
            iTahsilatSuresi.Checked = false;
            iDonemTanimlari.Checked = false;
            iPersoneleGrupAtama.Checked = false;
            iYeniMusteri.Checked = false;
            iMusteriHareketleri.Checked = false;
            iPrimRaporu1.Checked = false;
            iTahsilatSuresi1.Checked = false;
            iYeniIs.Checked = false;
        }

        private void btnVazgec_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            butonDurumlari(true, true, true, true,true,true);
            kullanicilarBindingSource.CancelEdit();
            gridControl1.Enabled = true;
        }

        private void btnSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Kayıt Silincek! Onaylıyor musunuz?","Kullanıcı Sil!",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button3)==DialogResult.Yes)
            {
                kullanicilarBindingSource.RemoveCurrent();
                butonDurumlari(true, true, true, true,true,true);
                gridControl1.Enabled = true;
            }
        }

        private void btnKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if ((!string.IsNullOrEmpty(txtAdiSoyadi.Text)) ||(!string.IsNullOrEmpty(txtKullaniciAdi.Text))|| (!string.IsNullOrEmpty(txtSifre.Text)))
            {   
                    try 
	                {	        
		                 this.kullanicilarBindingSource.EndEdit();
                         butonDurumlari(true,true,true,true,true,true);
                         gridControl1.Enabled = true;
	                }
	                catch (Exception ex)
	                {
                        btnVazgec_ItemClick(sender,e);
		                MessageBox.Show(ex.Message.ToString());
	                }         
            }else{
            MessageBox.Show("{Adı Soyadı} , {Kullanıcı Adı} , {Şifre} Boş bırakılamaz!");
            }

        }

        private void btnOnay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Değişikler Kaydetilcek! Onaylıyor musunuz?", "Kayıt Düzenle!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
                {
                    this.Validate();
                    this.kullanicilarBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.dSRaporlama);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.kullanicilarTableAdapter.GetAllUser(this.dSRaporlama.Kullanicilar);
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Ayarlar.lookUpDepartman frmLookUpDepartman = new lookUpDepartman();
            frmLookUpDepartman.frmKullanicilar = this;
            frmLookUpDepartman.Owner = this;
            frmLookUpDepartman.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Ayarlar.lookUpIller frmLookUpIller = new lookUpIller();
            frmLookUpIller.frmKullanicilar = this;
            frmLookUpIller.Owner = this;
            frmLookUpIller.ShowDialog();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Ayarlar.lookUpSorumlulukMerkezleri frmLookUpSorumlulukMerkezi = new lookUpSorumlulukMerkezleri();
            frmLookUpSorumlulukMerkezi.frmKullanicilar = this;
            frmLookUpSorumlulukMerkezi.Owner = this;
            frmLookUpSorumlulukMerkezi.ShowDialog();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            iFiltreYetkisiTextBox.Text = ".";
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            txtSorumlulukMerkezleri.Text = ".";
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            txtIlYetkisi.Text = ".";
        }
    }
}