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
    public partial class lookUpGTFirmaSec : Form
    {
        public lookUpGTFirmaSec()
        {
            InitializeComponent();
        }

        public GelirTablosu frmGelirTablosu { get; set; }

        private void lookUpGTFirmaSec_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSRaporlama.FIRMALAR' table. You can move, or remove it, as needed.
            this.fIRMALARTableAdapter.Fill(this.dSRaporlama.FIRMALAR);

        }

        private void gridControl1_KeyUp(object sender, KeyEventArgs e)
        {
            string firmalar = "";
            if (e.KeyCode == Keys.Enter)
            {
                foreach (var item in gridView1.GetSelectedRows())
                {
                    firmalar += "'" + gridView1.GetDataRow(item)[0].ToString() + "',"+Environment.NewLine;
                }
                frmGelirTablosu.txtFirmaSec.Text = firmalar.Substring(0, firmalar.Length - 1);
                this.Close();
            }
        }

    }
}
