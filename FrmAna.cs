using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace FrmYeniMusteri
{
    public partial class FrmAna : Form
    {
        public FrmAna()
        {
            InitializeComponent();
        }
        

        private void FrmAna_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMusteriEkle fr = new FrmMusteriEkle();
            fr.Show();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            //this.Hide();
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmOdalar fr = new FrmOdalar();
            fr.Show();
            //this.Hide(); // Anasayfa gizlenmeli mi ?
        }

        private void FrmMusteriler_Click(object sender, EventArgs e)
        {
            FrmMusteriler fr = new FrmMusteriler();
            fr.Show();
            //this.Hide();
        }

        private void BtnHakkimizda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KARACA Otel Kayıt Uygulaması Dadaşlar Diyarı ERZURUM/2019");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGider_Click(object sender, EventArgs e)
        {
            Gider fr = new Gider();
            fr.Show();
            //this.Hide();
        }

        private void BtnRadyo_Click(object sender, EventArgs e)
        {
            FrmRadyo fr = new FrmRadyo();
            fr.Show();
            //this.Hide();
        }

        private void BtnStoklar_Click(object sender, EventArgs e)
        {
            FrmStoklar fr = new FrmStoklar();
            fr.Show();
            //this.Hide();
        }

        private void BtnGazeteler_Click(object sender, EventArgs e)
        {
            FrmGazeteler fr = new FrmGazeteler();
            fr.Show();
            //this.Hide();
        }

        private void BtnHava_Click(object sender, EventArgs e)
        {
            FrmGuncelle fr = new FrmGuncelle();
            fr.Show();
            //this.Hide();
        }

        private void BtnMusteriMesajlari_Click(object sender, EventArgs e)
        {
            Mesaj fr = new Mesaj();
            fr.Show();
            //this.Hide();
        }

        private void BtnMuzikler_Click(object sender, EventArgs e)
        {
            FrmTv fr = new FrmTv();
            fr.Show();
            //this.Hide();
        }
    }
}
