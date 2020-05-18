using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace FrmYeniMusteri
{
    public partial class FrmMusteriEkle : Form
    {
        public FrmMusteriEkle()
        {
            InitializeComponent();
        }

        SqlConnection yol = new SqlConnection(@"Data Source=COMPUTERENGINEE;Initial Catalog=KaracaOtel;Integrated Security=True");
        private void BtnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı renkli butonlar dolu odaları gösterir.");

        }

        private void BtnOda101_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "101";

        }

        private void BtnOda102_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "102";
        }

        private void BtnOda103_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "103";
        }

        private void BtnOda104_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "104";
        }

        private void BtnOda105_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "105";
        }

        private void BtnOda106_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "106";
        }

        private void BtnOda107_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "107";
        }

        private void BtnOda108_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "108";
        }

        private void BtnOda109_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "109";
        }

        private void BtnBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil renkli butonlar boş odaları gösterir.");
        }
        //private void readRoom1()
        //{
        //    string staticRoomName = "Adi and Soyadi";
        //    SqlCommand komut1 = new SqlCommand("delete from  MusteriEkle where OdaNo= '" + BtnOda101.Text + "'", yol);
        //    yol.Open();
        //    SqlDataReader oku1 = komut1.ExecuteReader();
        //    while (oku1.Read())
        //    {
        //        string odaNo = oku1["OdaNo"].ToString();
        //        try
        //        {
        //            Control[] btn = this.Controls.Find(staticRoomName + odaNo, true);
        //            Button button = btn[0] as Button;
        //            button.BackColor = Color.Green;
        //            button.Text = (odaNo);
        //        }
        //        catch (Exception)
        //        {
        //            // 
        //        }

        //    }
        //    yol.Close();
        //}

        private void DtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;
            DateTime KucukTarih = Convert.ToDateTime(DtpGirisTarihi.Text);
            DateTime BuyukTarih = Convert.ToDateTime(DtpCikisTarihi.Text);
            TimeSpan sonuc;
            sonuc = BuyukTarih - KucukTarih;
            label11.Text = sonuc.TotalDays.ToString();
            Ucret = Convert.ToInt32(label11.Text) * 50;
            TxtUcret.Text = Ucret.ToString();


        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            yol.Open();
            SqlCommand komut = new SqlCommand("insert into MusteriEkle (Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "','" + ComBoCinsiyet.Text + "','" + maskedTxtTelefon.Text + "','" + TxtMail.Text + "','" + TxtTCNo.Text + "','" + TxtOdaNo.Text + "','" + TxtUcret.Text + "','" + DtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + DtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "')", yol);
            komut.ExecuteNonQuery();
            yol.Close();
            MessageBox.Show("Müşteri Kaydı Yapıldı...");
        }

        private void FrmMusteriEkle_Load(object sender, EventArgs e)
        {
                string staticRoomName = "BtnOda";
                SqlCommand komut1 = new SqlCommand("select * from MusteriEkle", yol);
                yol.Open();
                SqlDataReader oku1 = komut1.ExecuteReader();
                while (oku1.Read())
                {
                    string odaNo = oku1["OdaNo"].ToString();
                    string name = oku1["Adi"].ToString();
                    string surname = oku1["Soyadi"].ToString();

                    try
                    {
                        Control[] btn = this.Controls.Find(staticRoomName + odaNo, true);
                        Button button = btn[0] as Button;
                        button.BackColor = Color.Red;
                        button.Enabled = false;
                        button.Text = (name + "  " + surname);
                    }
                    catch (Exception)
                    {
                        // 
                    }

                    //if (BtnOda101.Text == odaNo)
                    //{
                    //    BtnOda101.Text = (name + "  " + surname);
                    //    BtnOda101.BackColor = Color.Red;
                    //}else if(BtnOda105.Text == odaNo)
                    //{
                    //    BtnOda105.Text = (name + "  " + surname);
                    //    BtnOda105.BackColor = Color.Red;
                    //}
                    //else if (BtnOda101.Text == string.Empty || BtnOda101.Text == "")
                    //{
                    //    BtnOda101.BackColor = Color.Green;
                    //    BtnOda101.Text = "BOŞ";
                    //}
                }
                yol.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BtnOda101.Text == "101")
                {
                    yol.Open();
                SqlCommand komut = new SqlCommand("update  MusteriEkle set OdaNo='" + BtnOda101.Text + "'", yol);
                    komut.ExecuteNonQuery();
                    yol.Close();
                    //FrmMusteriler fr = new FrmMusteriler();
                    //fr.Show();
                    ////this.Hide();
                }

        }
    }
}
