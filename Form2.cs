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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection yol = new SqlConnection(@"Data Source=COMPUTERENGINEE;Initial Catalog=KaracaOtel;Integrated Security=True");

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                yol.Open();
                string sql = "SELECT * FROM Admin where KullaniciAdi=@adi AND Sifre=@sifre";
                SqlParameter prm1 = new SqlParameter("adi", TxtKllaniciAdi.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifre", TxtSifre.Text.Trim());
                SqlCommand komut10 = new SqlCommand(sql, yol);
                komut10.Parameters.Add(prm1);
                komut10.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut10);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    FrmAna f2 = new FrmAna();
                    f2.Show();
                }
                else
                    MessageBox.Show("Kullanıcı adı ya da şifre yanlış Lütfen tekrar deneyiniz..");
                }
            catch (Exception)
            {
                
            }
            
            

                      
        
        }

        private void BtnGirisYap_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                BtnGirisYap_Click(this, new EventArgs());
            }
            //if (e.KeyCode == Keys.Enter)

            //{

            //    BtnGirisYap.Focus();

            //}
        }
    

        private void BtnGirisYap_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
       
        }

        private void TxtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSifre_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                BtnGirisYap_Click(this, new EventArgs());
            }
        }
    }

}
