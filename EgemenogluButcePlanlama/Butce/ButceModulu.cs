using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace EgemenOgluRaporlama.Butce
{
    public partial class ButceModulu : DevExpress.XtraEditors.XtraForm
    {
        public ButceModulu()
        {
            InitializeComponent();
        }

        public AnaForm anafrm { get; set; }
        string SrmMrkzAdi, SrmMrkzKodu;
        decimal ButceGelir, ButceGider;
        int ButceYil;
        int ButceID;


        private void ButceModulu_Load(object sender, EventArgs e)
        {

            this.tblSrmMrkzAdiTableAdapter.Fill(this.dsYeniRaporlar.tblSrmMrkzAdi);
            this.tblButceTableAdapter.Fill(this.dsYeniRaporlar.tblButce);

            int Yil = Convert.ToInt32(DateTime.Now.Year);
            int Yil2 = Yil + 1;

            if (!IsDisposed)
            {
                cmbYil.Items.Add(Yil);
                cmbYil.Items.Add(Yil2);
            }
            cmbYil.SelectedIndex = 0;

            foreach (DataRow dr in dsYeniRaporlar.tblSrmMrkzAdi.Rows)
            {
                cmbSrmMrkzAdi.Items.Add(dr["som_isim"].ToString());
            }

            cmbSrmMrkzAdi.SelectedIndex = 0;
        }

        string[] srmMrkzParcala;

        private void btnButceTanimiKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtButceGelir.Text))
            {
                MessageBox.Show("Gelir Bütçesini Boş Bıraktınız.Lütfen Kontrol Ediniz.");
                return;
            }
            else if (string.IsNullOrEmpty(txtButceGider.Text))
            {
                MessageBox.Show("Gider Bütçesini Boş Bıraktınız.Lütfen Kontrol Ediniz");
                return;
            }
            else
            {

                SrmMrkzAdi = cmbSrmMrkzAdi.SelectedItem.ToString();
                SrmMrkzKodu = cmbSrmMrkzKodu.SelectedItem.ToString();

                srmMrkzParcala = SrmMrkzKodu.Split('<');
                SrmMrkzKodu = srmMrkzParcala[1].ToString();

                SrmMrkzKodu = SrmMrkzKodu.Replace(">", "");

                ButceGelir = Convert.ToDecimal(txtButceGelir.Text);
                ButceGider = Convert.ToDecimal(txtButceGider.Text);
                ButceYil = Convert.ToInt32(cmbYil.SelectedItem.ToString());

                this.tblButceTableAdapter.ButceEkle(SrmMrkzAdi, SrmMrkzKodu, ButceGelir, ButceGider, ButceYil);
                MessageBox.Show("Bütçe Ekleme Başarılı");
                this.tblButceTableAdapter.Fill(this.dsYeniRaporlar.tblButce);
            }
        }

        private void cmbSrmMrkzAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSrmMrkzKodu.Items.Clear();
            txtButceGelir.Clear();
            txtButceGider.Clear();
            txtID.Text = "";

            string SrmMrkzSecimi = cmbSrmMrkzAdi.SelectedItem.ToString();

            this.tblSrmMrkzKoduTableAdapter.Fill(this.dsYeniRaporlar.tblSrmMrkzKodu, SrmMrkzSecimi.ToString());

            if (!IsDisposed)
            {

                foreach (DataRow dr in dsYeniRaporlar.tblSrmMrkzKodu.Rows)
                {
                    cmbSrmMrkzKodu.Items.Add(dr["SorumlulukMerkezi"].ToString());
                }
            }

            cmbSrmMrkzKodu.SelectedIndex = 0;
        }

        private void btnYenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.tblButceTableAdapter.Fill(this.dsYeniRaporlar.tblButce);
        }

        private void btnYeniButce_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtButceGelir.Clear();
            txtButceGider.Clear();
            txtID.Text = "";
        }

        private void btnButceSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.DataRowCount > 0)
            {
                if (MessageBox.Show("Kayıt Silincek! Onaylıyor musunuz?", "Kayıt Sil!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
                {
                    this.butceIslemleriTableAdapter1.ButceSil(Convert.ToInt32(txtID.Text));
                    tblButceBindingSource.RemoveCurrent();

                }
            }
        }

        string[] srmMrkzParcala2;

        private void btnButceDuzenle_Click(object sender, EventArgs e)
        {
             if (string.IsNullOrEmpty(txtButceGelir.Text))
            {
                MessageBox.Show("Gelir Bütçesini Boş Bıraktınız.Lütfen Kontrol Ediniz.");
                return;
            }
             else if (string.IsNullOrEmpty(txtButceGider.Text))
             {
                 MessageBox.Show("Gider Bütçesini Boş Bıraktınız.Lütfen Kontrol Ediniz");
                 return;
             }
             else
             {

                 SrmMrkzAdi = cmbSrmMrkzAdi.SelectedItem.ToString();
                 SrmMrkzKodu = cmbSrmMrkzKodu.SelectedItem.ToString();

                 srmMrkzParcala2 = SrmMrkzKodu.Split('<');
                 SrmMrkzKodu = srmMrkzParcala2[1].ToString();

                 SrmMrkzKodu = SrmMrkzKodu.Replace(">", "");

                 ButceGelir = Convert.ToDecimal(txtButceGelir.Text);
                 ButceGider = Convert.ToDecimal(txtButceGider.Text);
                 ButceYil = Convert.ToInt32(cmbYil.SelectedItem.ToString());
                 ButceID = Convert.ToInt32(txtID.Text);

                 this.tblButceTableAdapter.ButceEdit(SrmMrkzAdi, SrmMrkzKodu, ButceGelir, ButceGider, ButceYil, ButceID);
                 MessageBox.Show("Bütçeniz Başarılı Bir Şekilde Düzenlenmiştir");
                 this.tblButceTableAdapter.Fill(this.dsYeniRaporlar.tblButce);
             }

        }
    }
}