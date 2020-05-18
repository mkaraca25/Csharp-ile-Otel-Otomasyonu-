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
    public partial class FrmGuncelle : Form
    {
        public FrmGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection yol = new SqlConnection(@"Data Source=COMPUTERENGINEE;Initial Catalog=KaracaOtel;Integrated Security=True");

        private void FrmGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            yol.Open();
            SqlCommand komut8 = new SqlCommand("update  Admin set KullaniciAdi='" + TxtKllaniciAdi.Text + "',Sifre='"+TxtSifre.Text+"'", yol);
            komut8.ExecuteNonQuery();
            yol.Close();
            MessageBox.Show("Şifreniz Güncellendi...");
        }
    }
}
