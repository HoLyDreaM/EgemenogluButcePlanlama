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
    public partial class IsHareketleri : DevExpress.XtraEditors.XtraForm
    {
        public IsHareketleri()
        {
            InitializeComponent();
        }

        YeniIsEkle frmYeniIsEkle;

        private void frmYeniIsEkleAc(Boolean kayitTuru) {
            if (frmYeniIsEkle == null || frmYeniIsEkle.IsDisposed)
            {
                frmYeniIsEkle = new YeniIsEkle();
                frmYeniIsEkle.Owner = this;
                frmYeniIsEkle.frmIsHareketleri = this;
                frmYeniIsEkle.kayitTuru = kayitTuru;
                if (!kayitTuru)
                {
                    DataRow dr = bandedGridView1.GetDataRow(bandedGridView1.FocusedRowHandle);
                    frmYeniIsEkle.txtCariKodu.Text = dr[colCariKod.FieldName].ToString();
                    frmYeniIsEkle.txtUnvan1.Text = dr[colCariUnvan1.FieldName].ToString();
                    frmYeniIsEkle.txtUnvan2.Text = dr[colCariUnvan2.FieldName].ToString();
                    frmYeniIsEkle.txtSmKodu.Text = dr[colSmKodu.FieldName].ToString();
                    frmYeniIsEkle.txtSmAdi.Text = dr[colSmAdi.FieldName].ToString();
                    frmYeniIsEkle.txtProjeKodu.Text = dr[colProjeKod.FieldName].ToString();
                    frmYeniIsEkle.txtProjeAdi.Text = dr[colSmAdi.FieldName].ToString();
                    frmYeniIsEkle.txtEkAlan1.Text = dr[colEkAlan1.FieldName].ToString();
                    frmYeniIsEkle.txtEkAlan2.Text = dr[colEkAlan2.FieldName].ToString();
                    frmYeniIsEkle.txtEkAlan3.Text = dr[colEkAlan3.FieldName].ToString();
                    frmYeniIsEkle.dtProjeTarihi.DateTime = (DateTime)dr[colBitisTarihi.FieldName];
                    frmYeniIsEkle.dtSonKabulTarihi.DateTime = Convert.ToDateTime(dr[colBitisTarihi.FieldName]).AddDays((int)dr[colGün.FieldName]);
                    frmYeniIsEkle.ID =Convert.ToInt32(txtID.Text);
                }
                frmYeniIsEkle.Show();
            }
            else
                frmYeniIsEkle.Activate();

        }
        public void ps_yenile() {
            this.musterininVerdigiIslerTableAdapter.Fill(this.dSRaporlama.MusterininVerdigiIsler);
        }

        private void IsHareketleri_Load(object sender, EventArgs e)
        {
            this.musterininVerdigiIslerTableAdapter.Fill(this.dSRaporlama.MusterininVerdigiIsler);
        }

        private void ps_ciktiXls()
        {
            if (this.dSRaporlama.MusterininVerdigiIsler.Rows.Count > 0)
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

        private void btnYenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.musterininVerdigiIslerTableAdapter.Fill(this.dSRaporlama.MusterininVerdigiIsler);
        }

        private void btnYeni_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmYeniIsEkleAc(true);
        }

        private void btnSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                if (MessageBox.Show("Silmek İstediğinize Emin misiniz?","Kayıt Sil",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    this.queryies1.prim_IsHareketiSil(Convert.ToInt32(txtID.Text));
                    this.musterininVerdigiIslerBindingSource.RemoveCurrent();
                }         
            }else
                MessageBox.Show("Silinecek Kayıt Bulunamadı!");
        }

        private void btnDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                frmYeniIsEkleAc(false);
            }
            else
                MessageBox.Show("Düzenlenecek Kayıt Bulunamadı!");
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ps_ciktiXls();
        }
    }
}