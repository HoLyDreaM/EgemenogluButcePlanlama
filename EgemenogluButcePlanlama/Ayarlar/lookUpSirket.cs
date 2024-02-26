using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EgemenOgluRaporlama.Ayarlar
{
    public partial class lookUpSirket : Form
    {
        public lookUpSirket()
        {
            InitializeComponent();
        }
        public GirisFormu frmGiris { get; set; }
        private void lookUpSirket_Load(object sender, EventArgs e)
        {
            try
            {
                this.vERI_TABANLARITableAdapter3.Fill(this.dSRaporlama.VERI_TABANLARI);
            }
            catch
            {
                MessageBox.Show("Bağlantı sağlanamadı.Server adını kontrol ediniz!");
                this.Dispose();
            }   
        }

        private void lookUpSirket_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData==Keys.Escape)
            {
                this.Dispose();
            }

            if (e.KeyData == Keys.Enter)
            {
                frmGiris.txtSirket.Text = "MikroDB_V14_"+dB_kodTextBox.Text;
                this.Dispose();
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            frmGiris.txtSirket.Text = "MikroDB_V14_" + dB_kodTextBox.Text;
            this.Dispose();
        }
    }
}
