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
    public partial class gunlukGiris : DevExpress.XtraEditors.XtraForm
    {
        public AnaForm anaFrm { get; set; }
        public InsanKaynaklari.gunlukGirisDuzenleme frmGirisCikisDuzenleme{get;set;}
        public gunlukGiris()
        {
            InitializeComponent();
        }
        public Boolean timerAcik = false;
        public Boolean _IKayitDuzenleme;
        public string _IDepartmanlar;
        public DateTime gTarihi;
        public Boolean IGiris_OtoYenileme;
        private void frmGirisDuzenleAc(){
            if (_IKayitDuzenleme)
            {
                DataRow dr = gridView1.GetFocusedDataRow();
                frmGirisCikisDuzenleme = new InsanKaynaklari.gunlukGirisDuzenleme();
                frmGirisCikisDuzenleme.Owner = this;
                if (!string.IsNullOrEmpty(gEventNumTextBox.Text))
                {//############# kayıt düzenle
                    frmGirisCikisDuzenleme.txtID.Text = dr["EmpNum"].ToString();
                    frmGirisCikisDuzenleme.iUserNum = (Int16)dr["EmpNum"];

                    frmGirisCikisDuzenleme.txtAdiSoyadi.Text = dr["AdiSoyadi"].ToString();
                    frmGirisCikisDuzenleme.txtIl.Text = dr["il"].ToString();
                    frmGirisCikisDuzenleme.txtDepartman.Text = dr["Departman"].ToString();
                    gTarihi = Convert.ToDateTime(dr["gTarihi"]);
                    frmGirisCikisDuzenleme.dt.EditValue = gTarihi; //dr["gTarihi"].ToString();
                    frmGirisCikisDuzenleme.txtGirisKapisi.Text = dr["gKapisi"].ToString();
                    frmGirisCikisDuzenleme.txtAciklama.Text = dr["gAciklama"].ToString();
                    frmGirisCikisDuzenleme.txtEventNo.Text = dr["gEventNum"].ToString();
                    frmGirisCikisDuzenleme.DegYapan = anaFrm.lblKullaniciAdi.Text.ToString();
                    frmGirisCikisDuzenleme.EskiTarih = (DateTime)dr["gTarihi"];
                    frmGirisCikisDuzenleme.IDuzenlemeMiEklemeMi = true;
                    frmGirisCikisDuzenleme.GC = false;//giriş
                }
                else
                { //############# kayıt ekle
                    frmGirisCikisDuzenleme.txtID.Text = dr["EmpNum"].ToString();
                    frmGirisCikisDuzenleme.txtAdiSoyadi.Text = dr["AdiSoyadi"].ToString();
                    frmGirisCikisDuzenleme.txtIl.Text = dr["il"].ToString();
                    frmGirisCikisDuzenleme.txtDepartman.Text = dr["Departman"].ToString();
                    frmGirisCikisDuzenleme.iUserSlot = (Int16)dr["iUserSlot"];
                    frmGirisCikisDuzenleme.iUserNum = (Int16)dr["EmpNum"];
                    frmGirisCikisDuzenleme.DegYapan = anaFrm.lblKullaniciAdi.Text.ToString();
                    frmGirisCikisDuzenleme.IDuzenlemeMiEklemeMi = false;
                    frmGirisCikisDuzenleme.GC = false;//giriş 
                }
                frmGirisCikisDuzenleme.ShowDialog();
            }
            else
                MessageBox.Show("Bu İşlem İçin Yetkiniz Bulunmamaktadır!");
        }
        private string fn_ilAdiCek() {
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
            }else
                q = q.Substring(0, q.Length - 1);

            return q;
        }
        private string fn_departmanCek()
        {
            string q1 = null;
            string q = null;
            for (int i = 0; i < anaFrm.lbDepartmanlar.CheckedItems.Count; i++)
            {
                q1 = anaFrm.lbDepartmanlar.Items[anaFrm.lbDepartmanlar.CheckedIndices[i]].ToString();
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
        private void ps_aramaYap()
        {
            string q = fn_ilAdiCek();
            string q1 = fn_departmanCek();
            if (string.IsNullOrEmpty(q))
                MessageBox.Show("Arama Kriteri Olarak {İL} Seçilmedi!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                if (string.IsNullOrEmpty(q1))
                    MessageBox.Show("Arama Kriteri Olarak {DEPARTMAN} Seçilmedi!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    try
                    {
                        if (!timerAcik)
                        {
                            barButtonItem2.Enabled = false;
                            barButtonItem1.Enabled = false;
                        }
                        
                        SqlConnection con = new SqlConnection(Properties.Settings.Default.CsInsanKaynaklari);
                        SqlConnection.ClearPool(con);
                        con.Open();

                        string sorgu = "SELECT     EmpNum, AdiSoyadi, il, Departman, gTarihi  AS 'gTarihi',CONVERT(varchar, gTarihi, 108) AS 'Saat', gKapisi, gGC, gGCs, gAciklama, ISNULL(gTip, 0) AS gTip, gDegTar, gDegYap, gEskiTar,iUserSlot, " +
                               " gEventNum, CASE WHEN CONVERT(varchar, gTarihi, 108) <= '08:00:00' THEN 1 ELSE 2 END AS p " +
                               " FROM         dbo.fn_Fn1('" + tarih.Value.ToString("yyyy.MM.dd") + "') AS fn_Fn1_1 " +
                               " WHERE     (il IN (" + q + ")) and Departman in(" + q1 + ")" +
                               " ORDER BY gTarihi desc ";

                        //string sorgu = "SELECT     EmpNum, AdiSoyadi, il, Departman, gTarihi  AS 'gTarihi',CONVERT(varchar, gTarihi, 108) AS 'Saat', gKapisi, gGC, gGCs, gAciklama, ISNULL(gTip, 0) AS gTip, gDegTar, gDegYap, gEskiTar,iUserSlot, " +
                        //       " gEventNum, CASE WHEN CONVERT(varchar, gTarihi, 108) <= '08:30:00' THEN 1 ELSE CASE WHEN CONVERT(varchar, gTarihi, 108) <= '08:45:00' AND  " +
                        //       " CONVERT(varchar, gTarihi, 108) > '08:30:00' THEN 2 ELSE CASE WHEN CONVERT(varchar, gTarihi, 108) > '08:45:00' THEN 3 ELSE 4 END END END AS p " +
                        //       " FROM         dbo.fn_Fn1('" + tarih.Value.ToString("yyyy.MM.dd") + "') AS fn_Fn1_1 " +
                        //       " WHERE     (il IN (" + q + ")) and Departman in(" + q1 + ")" +
                        //       " ORDER BY gTarihi desc ";

                        SqlDataAdapter da = new SqlDataAdapter(sorgu, con);

                        dSRaporlama.ik_gunlukListe.Clear();
                        da.Fill(dSRaporlama.ik_gunlukListe);

                        if (!timerAcik)
                        {
                            barButtonItem2.Enabled = true;
                            barButtonItem1.Enabled = true;

                        }

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {

                        barButtonItem1.Enabled = true;
                        barButtonItem2.Enabled = true;
                    }   
                }
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
      
        private void gunlukGiris_Load(object sender, EventArgs e)
        {
            oto.Visible = IGiris_OtoYenileme;
            labelControl2.Visible = IGiris_OtoYenileme;
            txtZaman.Visible = IGiris_OtoYenileme;

            pb1.Visible = false;           
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dSRaporlama.ik_gunlukListe.Clear();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {    
            Thread t = new Thread(new ThreadStart(ps_aramaYap));
            t.Start();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ps_ciktiXls();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ExpandAllGroups();gridView1.ExpandAllGroups();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.CollapseAllGroups();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gridView1.OptionsView.ShowGroupPanel = true;
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gridView1.OptionsView.ShowGroupPanel = false;
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.BestFitColumns();
        }

        private void oto_CheckedChanged(object sender, EventArgs e)
        {
            if (oto.Checked)
            {
                pb1.Visible = true;
                pb1.Properties.Maximum = (Int32)txtZaman.Value * 60;

                barButtonItem1.Enabled = false;
                barButtonItem2.Enabled = false;
                txtZaman.Enabled = false;
                timerAcik = true;
                timerPb.Start();
            }
            else
            {
                pb1.Visible = false;
                pb1.Position = 0;
                barButtonItem1.Enabled = true;
                barButtonItem2.Enabled = true;
                txtZaman.Enabled = true;
                timerAcik = false;          
                timerPb.Stop();
            }
        }

        private void timerPb_Tick(object sender, EventArgs e)
        {

            if (pb1.Position != pb1.Properties.Maximum)
            {

                pb1.Increment(1);
            }
            else
            {
                Thread t = new Thread(new ThreadStart(ps_aramaYap));
                t.Start();
                pb1.Position = 0;
            }
        }

        private void kayıtDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmGirisDuzenleAc();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Personel Seçilmedi!"+ex.Message.ToString());
            }
                
        }

    }
}