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
    public partial class PiramitHareketleri : DevExpress.XtraEditors.XtraForm
    {
        public PiramitHareketleri()
        {
            InitializeComponent();
        }
        private void ps_ciktiXls()
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

        private void PiramitHareketleri_Load(object sender, EventArgs e)
        {
            this.prim_PiramitTableAdapter.Fill(this.dSRaporlama.prim_Piramit);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.prim_PiramitTableAdapter.Fill(this.dSRaporlama.prim_Piramit);
        }

        private void btnSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(musteriIDTextBox.Text))
                if (MessageBox.Show("Bu hareketi silmek istiyor musunuz?", "Kayıt Sil", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.queryies1.prim_musteriHareketiSil("M",Convert.ToInt16(musteriIDTextBox.Text));
                    this.prim_PiramitTableAdapter.Fill(this.dSRaporlama.prim_Piramit);
                }
            }
            catch 
            {
            
            }
    
        }

        private void btnExcelAktar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ps_ciktiXls();
        }

        private void btnDetayAc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bandedGridView1.ExpandAllGroups();
        }

        private void btnDetayKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bandedGridView1.CollapseAllGroups();
        }

        private void btnGrupAc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.bandedGridView1.OptionsView.ShowGroupPanel = true;
        }

        private void btnGrupKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.bandedGridView1.OptionsView.ShowGroupPanel = false;
        }

        private void btnEnUygunGenislik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bandedGridView1.BestFitColumns();
        }

    }
}