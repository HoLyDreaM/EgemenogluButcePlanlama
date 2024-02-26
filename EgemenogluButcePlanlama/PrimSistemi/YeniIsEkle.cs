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
    public partial class YeniIsEkle : DevExpress.XtraEditors.XtraForm
    {
        public YeniIsEkle()
        {
            InitializeComponent();
        }

        public IsHareketleri frmIsHareketleri { get; set; }
        public Boolean kayitTuru = true;//Ekle = True ; Düzenle = False
        public int ID=0;

        private void YeniIsEkle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSRaporlama.prim_ProjeKodlari' table. You can move, or remove it, as needed.
            this.prim_ProjeKodlariTableAdapter.Fill(this.dSRaporlama.prim_ProjeKodlari);
            // TODO: This line of code loads data into the 'dSRaporlama.prim_SorumlulukMerkezleri' table. You can move, or remove it, as needed.
            this.prim_SorumlulukMerkezleriTableAdapter.Fill(this.dSRaporlama.prim_SorumlulukMerkezleri);
            // TODO: This line of code loads data into the 'dSRaporlama.prim_CariHesaplar' table. You can move, or remove it, as needed.
            this.prim_CariHesaplarTableAdapter1.Fill(this.dSRaporlama.prim_CariHesaplar);

            dtProjeTarihi.DateTime = DateTime.Now;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtCariKodu.Text) || !string.IsNullOrEmpty(txtSmKodu.Text) || !string.IsNullOrEmpty(txtProjeKodu.Text) || !string.IsNullOrEmpty(dtProjeTarihi.Text))
                {
                    if (dtProjeTarihi.DateTime > dtSonKabulTarihi.DateTime)
                        MessageBox.Show("Son Kabul Tarihinden İtibaren Proje Girilemez!");
                    else
                    {
                        if (kayitTuru)
                            this.queryies1.prim_IsHareketiEkle(txtCariKodu.Text, txtUnvan1.Text, txtUnvan2.Text, txtSmKodu.Text, txtSmAdi.Text, txtProjeKodu.Text, txtProjeAdi.Text, dtProjeTarihi.DateTime, txtEkAlan1.Text, txtEkAlan2.Text, txtEkAlan3.Text);
                        else
                            this.queryies1.prim_IsHareketiGuncelle(txtCariKodu.Text,txtUnvan1.Text,txtUnvan2.Text,txtSmKodu.Text,txtSmAdi.Text,txtProjeKodu.Text,txtProjeAdi.Text,dtProjeTarihi.DateTime,txtEkAlan1.Text,txtEkAlan2.Text,txtEkAlan3.Text,ID);

                        frmIsHareketleri.ps_yenile();
                        this.Close();
                    }            
                }
                else
                    MessageBox.Show("{Cari Kodu},{Sm Kodu},{Proje Kodu},{Proje Tarihi}\nBoş Bırakılamaz...");
       
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
     
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtCariKodu.Text = "";
            txtUnvan1.Text = "";
            txtUnvan2.Text = "";
            txtSmKodu.Text = "";
            txtSmAdi.Text = "";
            txtProjeKodu.Text = "";
            txtProjeAdi.Text = "";
            txtEkAlan1.Text = "";
            txtEkAlan2.Text = "";
            txtEkAlan3.Text = "";
            dtProjeTarihi.DateTime = DateTime.Now;
            YeniIsEkle_Load(null,null);
        }

        private void txtCariKodu_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            try
            {
                GridLookUpEdit gridLookUpCariKodu = sender as GridLookUpEdit;
                DataRow dr = gridLookUpCariKodu.Properties.View.GetDataRow(gridLookUpCariKodu.Properties.View.FocusedRowHandle);
                txtUnvan1.Text = dr[2].ToString();
                txtUnvan2.Text = dr[3].ToString();
                dtSonKabulTarihi.DateTime = (DateTime)dr[4];
            }
            catch (Exception)
            {
            }           
        }

        private void txtSmKodu_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            try
            {
                GridLookUpEdit gridLookUpSmKod = sender as GridLookUpEdit;
                DataRow dr = gridLookUpSmKod.Properties.View.GetDataRow(gridLookUpSmKod.Properties.View.FocusedRowHandle);
                txtSmAdi.Text=dr[colsom_isim.FieldName].ToString();
            }
            catch (Exception)
            {
            }  
        }

        private void txtProjeKodu_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            try
            {
                GridLookUpEdit gridLookUpProjeKodu = sender as GridLookUpEdit;
                DataRow dr = gridLookUpProjeKodu.Properties.View.GetDataRow(gridLookUpProjeKodu.Properties.View.FocusedRowHandle);
                txtProjeAdi.Text = dr[colProjeAdı.FieldName].ToString();
            }
            catch (Exception)
            {
            }
        }

    }
}