using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace EgemenOgluRaporlama.InsanKaynaklari
{
    public partial class gunlukGirisDuzenleme : DevExpress.XtraEditors.XtraForm
    {
        public InsanKaynaklari.gunlukGiris frmGunlukGiris{ get; set; }
        public gunlukGirisDuzenleme()
        {
            InitializeComponent();
        }
        public Boolean IDuzenlemeMiEklemeMi;
        public string DegYapan;
        public DateTime EskiTarih;
        public Int16 iUserSlot;
        public Int16 iUserNum;
        public Int16 bDoorNumber;
        public int iReader;
        public Int16 iEventNum;
        public Boolean GC;
        private void gunlukGirisDuzenleme_Load(object sender, EventArgs e)
        {
            if (IDuzenlemeMiEklemeMi)
            {
                lblGKapisi0.Visible = false;
                txtGirisKapisi0.Visible = false;

                lblGKapisi.Visible = true;
                txtGirisKapisi.Visible = true;
            }
            else
            {
                lblGKapisi0.Visible = true;
                txtGirisKapisi0.Visible = true;
                    
                lblGKapisi.Visible = false;
                txtGirisKapisi.Visible = false;
                this.kapilarTableAdapter.Fill(dSRaporlama.kapilar, GC);
                dt.EditValue = DateTime.Now;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (GC==false)//Giriş Kaydı
            {
                if (IDuzenlemeMiEklemeMi)
                {
                    try
                    {
                        if (!string.IsNullOrEmpty(dt.EditValue.ToString()))
                        {
                            queryies1.guncelle(DateTime.Now, Convert.ToDateTime(dt.EditValue.ToString()), true, txtAciklama.Text, DateTime.Now, DegYapan, EskiTarih, Convert.ToInt64(txtEventNo.Text));
                            this.Close();
                        }
                        else
                            MessageBox.Show("{Tarih} Boş Bırakılamaz!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    try
                    {
                        if (!string.IsNullOrEmpty(dt.EditValue.ToString()) && !string.IsNullOrEmpty(txtGirisKapisi0.Text))
                        {//iSlotNum => kişilerin üzerindeki kartlar bazı kişilerde birden fazla kart gözüküyor bu yüzden  0 yazdım                                                    @Tip,@Aciklama,@DegisiklikTarihi,@DegisiklikYapan

                            iEventNum = Convert.ToInt16(queryies1.fn_ID01(bDoorNumber));
                            queryies1.ekle(iEventNum, bDoorNumber, DateTime.Now, (DateTime)dt.EditValue, "11", "01", "21", iUserNum, 0, "", iReader, 0, false, iUserSlot, 0, 0, 0, 0, "", 0, "", "", 218, true, txtAciklama.Text, DateTime.Now, DegYapan);
                            this.Close();
                        }
                        else
                            MessageBox.Show("{Tarih} veya {Giriş Kapısı} Boş Bırakılamaz!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            else//#################### Çıkış kaydı ##############################
            {
                if (IDuzenlemeMiEklemeMi)
                {
                    try
                    {
                        if (!string.IsNullOrEmpty(dt.EditValue.ToString()))
                        {
                            queryies1.guncelle(DateTime.Now, Convert.ToDateTime(dt.EditValue.ToString()), true, txtAciklama.Text, DateTime.Now, DegYapan, EskiTarih, Convert.ToInt64(txtEventNo.Text));
                            this.Close();
                        }
                        else
                            MessageBox.Show("{Tarih} Boş Bırakılamaz!");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    try
                    {
                        if (!string.IsNullOrEmpty(dt.EditValue.ToString()) && !string.IsNullOrEmpty(txtGirisKapisi0.Text))
                        {//iSlotNum => kişilerin üzerindeki kartlar bazı kişilerde birden fazla kart gözüküyor bu yüzden  0 yazdım                                                    @Tip,@Aciklama,@DegisiklikTarihi,@DegisiklikYapan

                            iEventNum = Convert.ToInt16(queryies1.fn_ID01(bDoorNumber));
                            queryies1.ekle(iEventNum, bDoorNumber, DateTime.Now, (DateTime)dt.EditValue, "11", "01", "22", iUserNum, 0, "", iReader, 0, false, iUserSlot, 0, 0, 0, 0, "", 0, "", "", 218, true, txtAciklama.Text, DateTime.Now, DegYapan);
                            this.Close();
                        }
                        else
                            MessageBox.Show("{Tarih} veya {Giriş Kapısı} Boş Bırakılamaz!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }

        private void txtGirisKapisi0_Properties_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtGirisKapisi0.Text))
                {
                    DataRow row = ((DataRowView)txtGirisKapisi0.Properties.GetRowByKeyValue(txtGirisKapisi0.EditValue)).Row;
                    bDoorNumber = Convert.ToInt16(row[1].ToString());
                    iReader = Convert.ToInt32(row[2].ToString());
                }
                //MessageBox.Show(row[1].ToString() + "-" + row[2].ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtGirisKapisi_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}