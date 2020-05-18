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
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }
        SqlConnection yol = new SqlConnection(@"Data Source=COMPUTERENGINEE;Initial Catalog=KaracaOtel;Integrated Security=True");

        private void BtnOda101_Click(object sender, EventArgs e)
        {

        }

        private void FrmOdalar_Load(object sender, EventArgs e)
        {
            readRoom();
        }

        private void readRoom()
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
                    button.Text = (name + "  " + surname);
                }
                catch (Exception)
                {
                    // 
                }
                
            }
            yol.Close();
        }


        private void BtnOda109_Click(object sender, EventArgs e)
        {
 
        }
         

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
