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
    public partial class lookUpSorumlulukMerkezleri : Form
    {
        public lookUpSorumlulukMerkezleri()
        {
            InitializeComponent();
        }
        public KullaniciTanimlariFormu frmKullanicilar { get; set; }
        private string fn_yetkiSec()
        {
            DataRowView dr;
            string yetkiler = "";
            foreach (int RowIndex in gridView1.GetSelectedRows())
            {
                dr = (DataRowView)gridView1.GetRow(RowIndex);
                yetkiler += dr[0].ToString() + ":" + dr[1].ToString() + "," + Environment.NewLine;
            }

            if (!string.IsNullOrEmpty(yetkiler))
            {
                yetkiler = yetkiler.TrimEnd();
                yetkiler = yetkiler.Substring(0, yetkiler.Length - 1);
            }
            else yetkiler = "";

            return yetkiler;
        }

        private void lookUpSorumlulukMerkezleri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSRaporlama.LookUpSorumlulukMerkezleri' table. You can move, or remove it, as needed.
            this.lookUpSorumlulukMerkezleriTableAdapter.Fill(this.dSRaporlama.LookUpSorumlulukMerkezleri);

        }

        private void gridControl1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                frmKullanicilar.txtSorumlulukMerkezleri.Text = fn_yetkiSec();
                this.Close();
            }
        }

        private void lookUpSorumlulukMerkezleri_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Escape))
            {
                this.Close();
            }
        }

    }
}
