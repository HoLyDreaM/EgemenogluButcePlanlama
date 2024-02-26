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
    public partial class lookUpBilancoFirmaSec : Form
    {
        public lookUpBilancoFirmaSec()
        {
            InitializeComponent();
        }
        public Bilanco frmBilanco { get; set; }

        private void lookUpBilancoFirmaSec_Load(object sender, EventArgs e)
        {
            this.fIRMALARTableAdapter.Fill(this.dSRaporlama.FIRMALAR);

        }

        private void lookUpBilancoFirmaSec_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                this.Close();
            }
        }

        private void gridControl1_KeyUp(object sender, KeyEventArgs e)
        {
            string firmalar="";
            if (e.KeyCode==Keys.Enter)
            {
                foreach (var item in gridView1.GetSelectedRows())
                {
                    firmalar += "'"+gridView1.GetDataRow(item)[0].ToString()+"',";
                }
                frmBilanco.txtFirmaSec.Text = firmalar.Substring(0,firmalar.Length-1);
                this.Close();
            }
        }
    }
}
