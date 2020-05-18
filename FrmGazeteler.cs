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
    public partial class FrmGazeteler : Form
    {
        public FrmGazeteler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.hurriyet.com.tr");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.milliyet.com.tr");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.sozcu.com.tr");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.haberturk.com.tr");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.fanatik.com.tr");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.onedio.com");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.instagram.com/accounts/login/?hl=tr");
        }
        
        private void button8_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/?hl=tr&gl=TR");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.facebook.com/campaign/landing.php?&campaign_id=1603087355&extra_1=s%7Cc%7C358240685191%7Ce%7Cfacebook%7C&placement=&creative=358240685191&keyword=facebook&partner_id=googlesem&extra_2=campaignid%3D1603087355%26adgroupid%3D61834755758%26matchtype%3De%26network%3Dg%26source%3Dnotmobile%26search_or_content%3Ds%26device%3Dc%26devicemodel%3D%26adposition%3D1t1%26target%3D%26targetid%3Dkwd-541132862%26loc_physical_ms%3D1012763%26loc_interest_ms%3D%26feeditemid%3D919461022%26param1%3D%26param2%3D&gclid=EAIaIQobChMIgt2wvbrU5gIVGLLtCh1uVAo3EAAYASABEgJ4s_D_BwE");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com.tr/");
        }
    }
}
