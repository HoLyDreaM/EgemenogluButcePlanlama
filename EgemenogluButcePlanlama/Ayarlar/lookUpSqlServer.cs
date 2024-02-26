using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SQLDMO;
using System.Threading;

namespace EgemenOgluRaporlama.Ayarlar
{
    public partial class lookUpSqlServer : Form
    {
        public lookUpSqlServer()
        {
            InitializeComponent();
        }
        SQLDMO.Application sqlApp = new SQLDMO.Application();


        private void dbListesi(){
            SQLDMO.NameList sqlServers = sqlApp.ListAvailableSQLServers();
            for (int i = 0; i < sqlServers.Count; i++)
            {
                object srv = sqlServers.Item(i + 1);
                if (srv != null)
                {
                    lbEkle(srv.ToString());
                }
            }
        }

        private delegate void delegate_lbEkle(string item);
        private void lbEkle(string item) {
            if (base.InvokeRequired)
            {
                base.Invoke(new delegate_lbEkle(lbEkle),item);
            }
            else
                this.listBoxControl1.Items.Add(item);
        }
   
        public GirisFormu frmGiris { get; set; }
        private void lookUpSqlServer_Load(object sender, EventArgs e)
        {
            Thread t = new Thread(dbListesi);
            t.Start();
        }

        private void lookUpSqlServer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==System.Windows.Forms.Keys.Escape)
            {
                this.Dispose();
            }

            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                frmGiris.txtServer.Text = listBoxControl1.SelectedItem.ToString();
                this.Dispose();
            }
        }

        private void listBoxControl1_DoubleClick(object sender, EventArgs e)
        {
            frmGiris.txtServer.Text = listBoxControl1.SelectedItem.ToString();
            this.Dispose();
        }
    }
}
