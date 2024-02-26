using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;
using System.Data.Sql;
using System.Data.SqlClient;
namespace EgemenOgluRaporlama.InsanKaynaklari
{
    public partial class tariheGore : DevExpress.XtraEditors.XtraForm
    {
        public tariheGore()
        {
            InitializeComponent();
        }
        public AnaForm anaFrm { get; set; }
        public Boolean _IKayitDuzenleme;
        public string _IDepartmanlar;
        Thread t;
        private string fn_ilAdiCek()
        {
            string q1 = null;
            string q = null;
            for (int i = 0; i < anaFrm.lbIller.CheckedItems.Count; i++)
            {
                q1 = anaFrm.lbIller.Items[anaFrm.lbIller.CheckedIndices[i]].Description;
                q += ("'" + q1 + "',");
            }

            if (string.IsNullOrEmpty(q))
            {
                q = null;
            }
            else
                q = q.Substring(0, q.Length - 1);

            return q;
        }
        private string fn_deparmmanCek1()
        {
            string r=null;
            string[] depPArcala = _IDepartmanlar.Split(',');
            foreach (var item in depPArcala)
            {
                r += "'"+item+"',";
            }
            return r.Substring(0,r.Length-1);
        }
        private void ps_personelDoldur()
        {
            string q = fn_deparmmanCek1();
            string q1 = anaFrm._ilFiltre;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.CsInsanKaynaklari);
            con.Open();

            string sorgu = " SELECT        ID, [Adi&Soyadi], IL, Departman "+
                           " FROM            dbo.fn_L1() AS fl "+
                           " WHERE fl.Departman IN(" + q+ ") and fl.IL in("+q1+")";

            SqlDataAdapter da = new SqlDataAdapter(sorgu, con);

            dSRaporlama.Personeller.Clear();
            da.Fill(dSRaporlama.Personeller);
        }
        private void tariheGore_Load(object sender, EventArgs e)
        {         
            ps_personelDoldur();
        }

        private void ps_ciktiXls()
        {
            if (gridView1.RowCount > 0)
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
        }   
        private void fn_kayitGetir() {
            barButtonItem1.Enabled = false;
            barButtonItem2.Enabled = false;

            int ID = Convert.ToInt32(queryies1.PerID(personeller.Text));
            this.tariheGorePersonelTableAdapter.Fill(this.dSRaporlama.tariheGorePersonel, tarih.Value.ToString("yyyy.MM.dd"), tarih1.Value.ToString("yyyy.MM.dd"), Convert.ToInt32(queryies1.PerID(personeller.Text)));
          
            barButtonItem1.Enabled = true;
            barButtonItem2.Enabled = true;
        }
        //SELECT        Departman
        //FROM            dbo.fn_L0() AS fl
        //WHERE fl.Departman IN('A')
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!string.IsNullOrEmpty(personeller.Text))
            {
                try
                {
                    t = new Thread(new ThreadStart(fn_kayitGetir));
                    t.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                finally { 
                
                }
            }
            else
                MessageBox.Show("Personel Seçimi Yapılmadı.");
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.dSRaporlama.tariheGorePersonel.Clear();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ps_ciktiXls();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ExpandAllGroups();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.CollapseAllGroups();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gridView1.OptionsView.ShowGroupPanel = true;
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gridView1.OptionsView.ShowGroupPanel = false;
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.BestFitColumns();
        }

        private void personeller_Properties_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
        }
    }
}