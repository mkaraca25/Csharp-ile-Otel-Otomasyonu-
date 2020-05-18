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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        SqlConnection yol = new SqlConnection(@"Data Source=COMPUTERENGINEE;Initial Catalog=KaracaOtel;Integrated Security=True");

        private void verilerigoster()
        {
            listView1.Items.Clear();
            yol.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle",yol);
            SqlDataReader oku = komut.ExecuteReader();

            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            yol.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            yol.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where TC like '%"+textBox1.Text+"%'", yol);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            yol.Close();
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            ComBoCinsiyet.Text = listView1.SelectedItems[0].SubItems[3].Text;
            maskedTxtTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtTCNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtOdaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            TxtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtpGirisTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
            DtpCikisTarihi.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (TxtOdaNo.Text == "101")
            {
                yol.Open();
                SqlCommand komut = new SqlCommand("delete from  MusteriEkle where OdaNo= '"+TxtOdaNo.Text+"'", yol);
                komut.ExecuteNonQuery();
                yol.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "102")
            {
                yol.Open();
                SqlCommand komut = new SqlCommand("delete from Oda102", yol);
                komut.ExecuteNonQuery();
                yol.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "103")
            {
                yol.Open();
                SqlCommand komut = new SqlCommand("delete from Oda103", yol);
                komut.ExecuteNonQuery();
                yol.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "104")
            {
                yol.Open();
                SqlCommand komut = new SqlCommand("delete from Oda104", yol);
                komut.ExecuteNonQuery();
                yol.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "105")
            {
                yol.Open();
                SqlCommand komut = new SqlCommand("delete from Oda105", yol);
                komut.ExecuteNonQuery();
                yol.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "106")
            {
                yol.Open();
                SqlCommand komut = new SqlCommand("delete from Oda106", yol);
                komut.ExecuteNonQuery();
                yol.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "107")
            {
                yol.Open();
                SqlCommand komut = new SqlCommand("delete from Oda107", yol);
                komut.ExecuteNonQuery();
                yol.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "108")
            {
                yol.Open();
                SqlCommand komut = new SqlCommand("delete from Oda108", yol);
                komut.ExecuteNonQuery();
                yol.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "109")
            {
                yol.Open();
                SqlCommand komut = new SqlCommand("delete from Oda109", yol);
                komut.ExecuteNonQuery();
                yol.Close();
                verilerigoster();
            }
          
           


        }

            private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            ComBoCinsiyet.Text = "";
            maskedTxtTelefon.Clear();
            TxtMail.Clear();
            TxtTCNo.Clear();
            TxtOdaNo.Clear();
            TxtUcret.Clear();
            DtpGirisTarihi.Text = "";
            DtpCikisTarihi.Text = "";
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            yol.Open();
            SqlCommand komut = new SqlCommand("update  MusteriEkle set Adi='" +TxtAdi.Text + "',Soyadi='"+TxtSoyadi.Text+"',Cinsiyet='"+ComBoCinsiyet.Text+ "',Telefon='" + maskedTxtTelefon.Text + "',Mail='" + TxtMail.Text + "',TC='" + TxtTCNo.Text + "',OdaNo='" + TxtOdaNo.Text + "',Ucret='" + TxtUcret.Text + "',GirisTarihi='" + DtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "',CikisTarihi='" + DtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "' where musteriid="+id+"", yol);
            komut.ExecuteNonQuery();
            yol.Close();
            verilerigoster();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
