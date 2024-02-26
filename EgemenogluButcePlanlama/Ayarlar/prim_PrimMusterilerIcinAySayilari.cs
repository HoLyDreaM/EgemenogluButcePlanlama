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
    public partial class prim_PrimMusterilerIcinAySayilari : DevExpress.XtraEditors.XtraForm
    {
        public prim_PrimMusterilerIcinAySayilari()
        {
            InitializeComponent();
        }

        private void prim_PrimMusterilerIcinAySayilari_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSRaporlama.TahsilatSureleri' table. You can move, or remove it, as needed.
            this.tahsilatSureleriTableAdapter.Fill(this.dSRaporlama.TahsilatSureleri);

        }

        private void btnYenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.tahsilatSureleriTableAdapter.Fill(this.dSRaporlama.TahsilatSureleri);
        }

        private void btnKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.tahsilatSureleriBindingSource.EndEdit();
                this.tahsilatSureleriTableAdapter.Update(dSRaporlama.TahsilatSureleri);
                MessageBox.Show("Kayıtlarda Güncelleme Yapılmıştır!");  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        
        }
    }
}