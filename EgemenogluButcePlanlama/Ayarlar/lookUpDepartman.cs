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
    public partial class lookUpDepartman : DevExpress.XtraEditors.XtraForm
    {
        public lookUpDepartman()
        {
            InitializeComponent();
        }
        public Ayarlar.KullaniciTanimlariFormu frmKullanicilar{get;set;}

        private string fn_yetkiSec() {
            DataRowView dr;
            string yetkiler = "";
            foreach (int RowIndex in gridView1.GetSelectedRows())
            {
                dr = (DataRowView)gridView1.GetRow(RowIndex);
                yetkiler+=dr[0].ToString()+","+Environment.NewLine;
            }

            if (!string.IsNullOrEmpty(yetkiler))
            {
                yetkiler = yetkiler.TrimEnd();
                yetkiler = yetkiler.Substring(0, yetkiler.Length - 1);
            }
            else yetkiler = "";

            return yetkiler;
        }

        private void lookUpDepartman_Load(object sender, EventArgs e)
        {
            this.departmanlarTableAdapter.Fill(this.dSRaporlama.Departmanlar);
        }

        private void lookUpDepartman_KeyUp(object sender, KeyEventArgs e)
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
                frmKullanicilar.iFiltreYetkisiTextBox.Text = fn_yetkiSec();
                this.Dispose();
            }
        }
    }
}