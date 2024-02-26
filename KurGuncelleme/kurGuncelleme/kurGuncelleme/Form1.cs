using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using System.Threading;
using System.Data.Sql;
using System.Data.SqlClient;
using Microsoft.Win32;
namespace kurGuncelleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Thread t;

        iniOku.iniOku iniOku = new iniOku.iniOku(Application.StartupPath+"\\kurLogin.ini");

        SqlConnection con;

        string _srv;
        public string Srv
        {
            get { return _srv; }
            set { _srv = value; }
        }
        string _vt;
        public string Vt
        {
            get { return _vt; }
            set { _vt = value; }
        }
        double _euro;
        public double Euro
        {
            get { return _euro; }
            set { _euro = value; }
        }
        double _dolar;
        public double Dolar
        {
            get { return _dolar; }
            set { _dolar = value; }
        }

        private void sp_baglantiKontrol()
        {
            Srv = iniOku.IniOku("Ayar", "SRV");
            Vt = iniOku.IniOku("Ayar", "VT");

            Properties.Settings.Default["Cs"] = "Data Source=" + Srv + ";Initial Catalog=" + Vt + ";Integrated Security=True";
            con = new SqlConnection(Properties.Settings.Default["Cs"].ToString());
            con.Open();
        }
        public DataTable source()
        {
            //DataTable dt = new DataTable(); 
            // DataTable nesnemizi yaratıyoruz         
            egemenogluRaporlamaDataSet.DataTable1.Clear();
            DataRow dr;
            // DataTable ın satırlarını tanımlıyoruz.
            //egemenogluRaporlamaDataSet.DataTable1.Columns.Add(new DataColumn("Adı", typeof(string)));
            //egemenogluRaporlamaDataSet.DataTable1.Columns.Add(new DataColumn("Kod", typeof(string)));
            //egemenogluRaporlamaDataSet.DataTable1.Columns.Add(new DataColumn("Döviz alış", typeof(string)));
            //egemenogluRaporlamaDataSet.DataTable1.Columns.Add(new DataColumn("Döviz satış", typeof(string)));
            //egemenogluRaporlamaDataSet.DataTable1.Columns.Add(new DataColumn("Efektif alış", typeof(string)));
            //egemenogluRaporlamaDataSet.DataTable1.Columns.Add(new DataColumn("Efektif Satış", typeof(string)));
            // DataTableımıza 6 sütün ekliyoruz ve değişken tiplerini tanımlıyoruz.
            XmlTextReader rdr = new XmlTextReader("http://www.tcmb.gov.tr/kurlar/today.xml");
            // XmlTextReader nesnesini yaratıyoruz ve parametre olarak xml dokümanın urlsini veriyoruz
            // XmlTextReader urlsi belirtilen xml dokümanlarına hızlı ve forward-only giriş imkanı sağlar.
            XmlDocument myxml = new XmlDocument();
            // XmlDocument nesnesini yaratıyoruz.
            myxml.Load(rdr);
            // Load metodu ile xml yüklüyoruz
            XmlNode tarih = myxml.SelectSingleNode("/Tarih_Date/@Tarih");
            XmlNodeList mylist = myxml.SelectNodes("/Tarih_Date/Currency");
            XmlNodeList adi = myxml.SelectNodes("/Tarih_Date/Currency/Isim");
            XmlNodeList kod = myxml.SelectNodes("/Tarih_Date/Currency/@Kod");
            XmlNodeList doviz_alis = myxml.SelectNodes("/Tarih_Date/Currency/ForexBuying");
            XmlNodeList doviz_satis = myxml.SelectNodes("/Tarih_Date/Currency/ForexSelling");
            XmlNodeList efektif_alis = myxml.SelectNodes("/Tarih_Date/Currency/BanknoteBuying");
            XmlNodeList efektif_satis = myxml.SelectNodes("/Tarih_Date/Currency/BanknoteSelling");
            // XmlNodeList cinsinden her bir nodu, SelectSingleNode metoduna nodların xpathini parametre olarak
            // göndererek tanımlıyoruz.
            //this.Text = tarih.InnerText.ToString() + " Tarihli Merkez Bankası Kur Bilgileri";
            // datagridimin captionu ayarlıyoruz.
            int x = 19;
            /*  Burada xmlde bahsettiğim - bence-  mantık hatasından dolayı x gibi bir değişken tanımladım.
            bu x =19  DataTable a sadece 19 satır eklenmesini sağlıyor. çünkü xml dökümanında 19. node dan sonra
            güncel kur bilgileri değil Euro dönüşüm kurları var ve bu node dan sonra yapı ilk 18 node ile tutmuyor
            Bence ayrı bir xml dökümanda tutulması gerekirdi. 
            */
            for (int i = 0; i < x; i++)
            {
                dr = egemenogluRaporlamaDataSet.DataTable1.NewRow();
                dr[0] = adi.Item(i).InnerText.ToString(); // i. adi nodunun içeriği
                // Adı isimli DataColumn un satırlarını  /Tarih_Date/Currency/Isim node ları ile dolduruyoruz.
                dr[1] = kod.Item(i).InnerText.ToString();
                // Kod satırları
                dr[2] = doviz_alis.Item(i).InnerText.ToString();
                // Döviz Alış
                dr[3] = doviz_satis.Item(i).InnerText.ToString();
                // Döviz  Satış
                dr[4] = efektif_alis.Item(i).InnerText.ToString();
                // Efektif Alış
                dr[5] = efektif_satis.Item(i).InnerText.ToString();
                // Efektif Satış.
                egemenogluRaporlamaDataSet.DataTable1.Rows.Add(dr);
            }
            // DataTable ımızın satırlarını 18 satır olacak şekilde dolduruyoruz
            // gerçi yine web mastırın insafı devreye giriyor:).
            // yukarıda bahsettiğim sorun.
            return egemenogluRaporlamaDataSet.DataTable1;
            // DataTable ı döndürüyoruz.
        }
        private void sp_kurCek() {
            dg.DataSource = source();
        }
        private void sp_kurGuncelle() {
            foreach (DataRow item in egemenogluRaporlamaDataSet.DataTable1)
            {
                if (item[1].ToString() == "USD")
                {
                    Dolar = Convert.ToDouble(item[2].ToString().Replace('.', ','));
                    queriesTableAdapter1.UpdateQuery(Dolar, DateTime.Now.ToString(), "USD");
                }

                if (item[1].ToString() == "EUR")
                {
                    Euro = Convert.ToDouble(item[2].ToString().Replace('.', ','));
                    queriesTableAdapter1.UpdateQuery(Euro, DateTime.Now.ToString(), "EURO");
                }
            }     
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            notifyIcon1.ShowBalloonTip(1000,"Bilgilendirme","Kur Güncelleyici Çalışıyor!",ToolTipIcon.Info);
            try
            {
                //Srv = iniOku.IniOku("Ayar", "SRV");
                //Vt =  iniOku.IniOku("Ayar", "VT");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.ToString("HH:mm:ss") == "15:50:00")
            {
                try
                {
                    sp_baglantiKontrol();
                    sp_kurCek();
                    sp_kurGuncelle();
                    this.kurlarTableAdapter.Fill(egemenogluRaporlamaDataSet.Kurlar);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
        
            }
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                sp_baglantiKontrol();
                sp_kurCek();
                sp_kurGuncelle();
                this.kurlarTableAdapter.Fill(egemenogluRaporlamaDataSet.Kurlar);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message.ToString());
            }
       
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void gösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Maximized;
            notifyIcon1.Visible = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
                Thread.Sleep(3000);
                notifyIcon1.ShowBalloonTip(1000, "Bilgilendirme", "Kur Güncelleyici Çalışıyor!", ToolTipIcon.Info);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Maximized;
            notifyIcon1.Visible = false;
        }

    }
}
