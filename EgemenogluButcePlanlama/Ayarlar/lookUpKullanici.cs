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
    public partial class lookUpKullanici : Form
    {
        public lookUpKullanici()
        {
            InitializeComponent();
        }

        public GirisFormu frmGiris { get; set; }
        private void lookUpKullanici_Load(object sender, EventArgs e)
        {
            try
            {
                this.kullanicilarTableAdapter.GetLookUpUsers(this.dSRaporlama.Kullanicilar);
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı sağlanamadı.Server adını kontrol ediniz!");
                this.Dispose();
            }
          
        }

        private void lookUpKullanici_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData==Keys.Escape)
            {
                this.Dispose();
            }

            if (e.KeyData==Keys.Enter)
            {
                frmGiris.txtKullanici.Text = this.kullaniciAdiTextBox.Text;
                this.Dispose();
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            frmGiris.txtKullanici.Text = this.kullaniciAdiTextBox.Text;
            this.Dispose();
        }
    }
}
