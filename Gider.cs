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
    public partial class Gider : Form
    {
        public Gider()
        {
            InitializeComponent();
        }
        SqlConnection yol = new SqlConnection(@"Data Source=COMPUTERENGINEE;Initial Catalog=KaracaOtel;Integrated Security=True");
        private void BtnGider_Click(object sender, EventArgs e)
        {
            int sonuc;
            sonuc = Convert.ToInt32(label3.Text) - (Convert.ToInt32(label4.Text) + Convert.ToInt32(label6.Text) + Convert.ToInt32(label8.Text) + Convert.ToInt32(label13.Text) + Convert.ToInt32(label14.Text) + Convert.ToInt32(label15.Text) + Convert.ToInt32(label17.Text));
            label10.Text = sonuc.ToString();
            int personel;
            personel = Convert.ToInt32(textBox1.Text);
            label4.Text = (personel * 2324).ToString();
        }
        private void Gider_Load(object sender, EventArgs e)
        {
            yol.Open();
            SqlCommand komut1 = new SqlCommand("select sum(Ucret) as Toplam from MusteriEkle", yol);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                label3.Text = oku1["Toplam"].ToString();

            }
            yol.Close();
            //İçeceklerin toplamı
            yol.Open();
            SqlCommand komut2 = new SqlCommand("select sum(İcecekler) as toplam1 from stok", yol);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                label6.Text = oku2["toplam1"].ToString();
            }
            yol.Close();
            yol.Open();
            SqlCommand komut3 = new SqlCommand("select sum(Gida) as toplam2 from stok", yol);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                label8.Text = oku3["toplam2"].ToString();
            }
            yol.Close();
            yol.Open();
            SqlCommand komut4 = new SqlCommand("select sum(Cerezler) as toplam3 from stok", yol);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                label13.Text = oku4["toplam3"].ToString();
            }
            yol.Close();
            //elektrik
            yol.Open();
            SqlCommand komut6 = new SqlCommand("select sum(Elektrik) as toplam6 from Faturalar", yol);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                label14.Text = oku6["toplam6"].ToString();
            }
            yol.Close();
            yol.Open();
            SqlCommand komut7 = new SqlCommand("select sum(Elektrik) as toplam7 from Faturalar", yol);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                label15.Text = oku7["toplam7"].ToString();
            }
            yol.Close();
            yol.Open();
            SqlCommand komut8 = new SqlCommand("select sum(Elektrik) as toplam8 from Faturalar", yol);
            SqlDataReader oku8 = komut8.ExecuteReader();
            while (oku8.Read())
            {
                label17.Text = oku8["toplam8"].ToString();
            }
            yol.Close();
        }


    }

}

