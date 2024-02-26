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
    public partial class PrimGiris : DevExpress.XtraEditors.XtraForm
    {
        public PrimGiris()
        {
            InitializeComponent();
        }

        private void PrimGiris_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSRaporlama.PrimOdemeleri' table. You can move, or remove it, as needed.
            this.primOdemeleriTableAdapter.Fill(this.dSRaporlama.PrimOdemeleri);
            // TODO: This line of code loads data into the 'dSRaporlama.prim_PrimGiris' table. You can move, or remove it, as needed.
            this.prim_PrimGirisTableAdapter.Fill(this.dSRaporlama.prim_PrimGiris);
            dtTarih.DateTime = DateTime.Now;
        }

        private void butonDurumlari(Boolean yeni, Boolean kaydet, Boolean vazgec, Boolean sil, Boolean yenile, Boolean onay)
        {
            btnYeni.Enabled = yeni;
            btnKaydet.Enabled = kaydet;
            btnVazgec.Enabled = vazgec;
            btnSil.Enabled = sil;
            btnYenile.Enabled = yenile;
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

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if ((!string.IsNullOrEmpty(txtID.Text)) && !string.IsNullOrEmpty(txtPersonelAdi.Text))
            {
                if (!string.IsNullOrEmpty(txtPrimMiktari.Text))
                {
                    try
                    {
                        if (MessageBox.Show("Kaydetmek istediğinize emin misiniz?","Kayıt",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                        if (Convert.ToInt32(txtID.Text) < 0)
                        {
                            this.queryies1.prim_primOdemesiYap(Convert.ToInt32(txtPerID.Text),txtPersonelKodu.Text,txtPersonelAdi.Text,Convert.ToDecimal(txtPrimMiktari.Text),dtTarih.DateTime,"Erkan",DateTime.Now);
                            this.primOdemeleriTableAdapter.Fill(this.dSRaporlama.PrimOdemeleri);
                            butonDurumlari(true, true, true, true, true, true);
                            gridControl1.Enabled = true;
                        }
                        else
                        {
                            this.queryies1.prim_primOdemesiGuncelle(Convert.ToInt32(txtPerID.Text),txtPersonelKodu.Text,txtPersonelAdi.Text,Convert.ToDecimal(txtPrimMiktari.Text),dtTarih.DateTime,"Erkan",DateTime.Now,Convert.ToInt32(txtID.Text));
                            this.primOdemeleriBindingSource.EndEdit();
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
                    MessageBox.Show("{ Meblag } Boş Bırakılamaz!");
            }
            else
            {
                MessageBox.Show("{ Personel Adı } Boş bırakılamaz!");
            }
        }


        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ps_ciktiXls();
        }

        private void btnYeni_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtPersonelAdi.Focus();
            primOdemeleriBindingSource.AddNew();
            gridControl1.Enabled = false;
            txtPrimMiktari.Text = Convert.ToString(0);
            dtTarih.DateTime = DateTime.Now;
            butonDurumlari(false, true, true, false, false, false);
        }

        private void btnVazgec_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            butonDurumlari(true, true, true, true, true, true);
            primOdemeleriBindingSource.CancelEdit();
            gridControl1.Enabled = true;
        }

        private void btnSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.DataRowCount > 0 || !string.IsNullOrEmpty(txtID.Text))
            {
                if (MessageBox.Show("Kayıt Silincek! Onaylıyor musunuz?", "Kayıt Sil!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
                {
                    if (!string.IsNullOrEmpty(txtID.Text))
                    {
                        this.queryies1.prim_primOdemesiSil(Convert.ToInt32(txtID.Text));
                        primOdemeleriBindingSource.RemoveCurrent();
                        butonDurumlari(true, true, true, true, true, true);
                        gridControl1.Enabled = true;
                    }
                }
            }
        }

        private void txtPersonelKodu_Properties_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            //this.prim_PrimGirisBindingSource.Position = this.prim_PrimGirisBindingSource.Find("PerKodu", txtPersonelKodu.Text);
            try
            {
                DataRow row = gridView1.GetFocusedDataRow();
                txtPerID.Text = row[0].ToString();
                txtPersonelKodu.Text = row[1].ToString();
                txtPersonelAdi.Text = row[2].ToString();
            }
            catch (Exception)
            {
            }
        }

        private void txtPersonelAdi_Properties_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            //this.prim_PrimGirisBindingSource.Position = this.prim_PrimGirisBindingSource.Find("PersonelAdi", txtPersonelAdi.Text);
            try
            {
                DataRow row = gridLookUpEdit1View.GetFocusedDataRow();
                txtPerID.Text = row[0].ToString();
                txtPersonelKodu.Text = row[1].ToString();
                txtPersonelAdi.Text = row[2].ToString();
            }
            catch (Exception)
            {
            }
        }

        private void btnYenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.primOdemeleriTableAdapter.Fill(this.dSRaporlama.PrimOdemeleri);
        }

        private void txtPrimMiktari_Leave(object sender, EventArgs e)
        {
            if(btnYeni.Enabled==true)
            this.primOdemeleriBindingSource.CancelEdit();
        }


    }
}