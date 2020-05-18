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
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }
        SqlConnection yol = new SqlConnection(@"Data Source=COMPUTERENGINEE;Initial Catalog=KaracaOtel;Integrated Security=True");
        private void veriler()
        {
            listView1.Items.Clear();
            yol.Open();
            SqlCommand komut9 = new SqlCommand("select * from Stok", yol);
            SqlDataReader oku9 = komut9.ExecuteReader();
            while (oku9.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku9["Gida"].ToString();
                ekle.SubItems.Add(oku9["İcecekler"].ToString());
                ekle.SubItems.Add(oku9["Cerezler"].ToString());
                listView1.Items.Add(ekle);
               
            }
            yol.Close();
            
        }
        
        private void veriler1()
        {
            listView2.Items.Clear();
            yol.Open();
            SqlCommand komut5 = new SqlCommand("select * from Faturalar", yol);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku5["Elektrik"].ToString();
                ekle.SubItems.Add(oku5["Su"].ToString());
                ekle.SubItems.Add(oku5["İnternet"].ToString());
                listView2.Items.Add(ekle);
            }
            yol.Close();
        }


        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            veriler();
            veriler1();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            yol.Open();
            SqlCommand komut6 = new SqlCommand("insert into Faturalar(Elektrik,Su,İnternet) values('" + textBox4.Text + "','" + textBox6.Text + "','" + textBox5.Text + "')", yol);
            komut6.ExecuteNonQuery();
            yol.Close();
            veriler1();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            yol.Open();
            SqlCommand komut1 = new SqlCommand("insert into Stok(Gida,İcecekler,Cerezler) values('" + textBox3.Text + "','" + textBox2.Text + "','" + textBox1.Text + "')", yol);
            komut1.ExecuteNonQuery();
            yol.Close();
            veriler();
            
        }
    }
}
