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
    public partial class Mesaj : Form
    {
        public Mesaj()
        {
            InitializeComponent();
        }
        SqlConnection yol = new SqlConnection(@"Data Source=COMPUTERENGINEE;Initial Catalog=KaracaOtel;Integrated Security=True");
        private void verilerigoster()
        {
            listView1.Items.Clear();
            yol.Open();
            SqlCommand komut = new SqlCommand("select * from Mesaj", yol);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Mesajid"].ToString();
                ekle.SubItems.Add(oku["AdSoyad"].ToString());
                ekle.SubItems.Add(oku["Mesaj"].ToString());

                listView1.Items.Add(ekle);
            }
            yol.Close();
        }

        private void Mesaj_Load(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void BtnStoklar_Click(object sender, EventArgs e)
        {
            yol.Open();
            SqlCommand komut11 = new SqlCommand("insert into Mesaj(Adsoyad,Mesaj) values('"+TxtAd.Text+ "','" + richTextBox1.Text + "')", yol);
            komut11.ExecuteNonQuery();
            yol.Close();
            verilerigoster();
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAd.Text = listView1.SelectedItems[0].SubItems[1].Text;
            richTextBox1.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtAd.Text = "";richTextBox1.Text = "";
            
        }
    }
}
