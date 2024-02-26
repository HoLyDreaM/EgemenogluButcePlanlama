using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;
namespace EgemenOgluRaporlama.Ayarlar
{
    public partial class lookUpIller : DevExpress.XtraEditors.XtraForm
    {
        public lookUpIller()
        {
            InitializeComponent();
        }
        public KullaniciTanimlariFormu frmKullanicilar { get; set; }
        private void listeDoldur() {
            List<string> ilListesi = new List<string>();
            ilListesi.Add("ISTANBUL:01");
            ilListesi.Add("BURSA:02");
            ilListesi.Add("ISTANBUL2:03");
            ilListesi.Add("ADANA:04");
            ilListesi.Add("ANKARA:05");

            foreach (var item in ilListesi)
            {
                dsRaporlama1.ik_iller.Rows.Add(item);
            }
        }
        private string fn_yetkiSec()
        {
            DataRowView dr;
            string yetkiler = "";
            foreach (int RowIndex in gridView1.GetSelectedRows())
            {
                dr = (DataRowView)gridView1.GetRow(RowIndex);
                yetkiler += dr[0].ToString() + ","+Environment.NewLine;
            }

            if (!string.IsNullOrEmpty(yetkiler))
            {
                yetkiler = yetkiler.TrimEnd();
                yetkiler = yetkiler.Substring(0, yetkiler.Length - 1);
            }
            else yetkiler = "";

            return yetkiler;
        }
        private void lookUpIller_Load(object sender, EventArgs e)
        {
            listeDoldur();
        }

        private void lookUpIller_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                this.Dispose();
            }
        }

        private void gridControl1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                frmKullanicilar.txtIlYetkisi.Text = fn_yetkiSec();
                this.Dispose();
            }
        }
    }
}