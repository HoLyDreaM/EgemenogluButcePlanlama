using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraCharts;

namespace EgemenOgluRaporlama.Butce
{
    public partial class ButceChartKontrol : DevExpress.XtraEditors.XtraForm
    {
        public ButceChartKontrol()
        {
            InitializeComponent();
        }

        private void ButceChartKontrol_Load(object sender, EventArgs e)
        {
            this.tblButceRaporAnaliziTableAdapter.Fill(this.dsYeniRaporlar.tblButceRaporAnalizi);
        }

        private void btnYazdir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            chartButceAnalizi.ShowPrintPreview();
            chartButceAnalizi.OptionsPrint.SizeMode = DevExpress.XtraCharts.Printing.PrintSizeMode.Stretch;

        }

        private void ButceChartKontrol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.P)
                chartButceAnalizi.ShowPrintPreview();
            chartButceAnalizi.Print(DevExpress.XtraCharts.Printing.PrintSizeMode.Stretch);
            
        }
    }
}