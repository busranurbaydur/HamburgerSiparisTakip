using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgerSiparisTakip
{
    public partial class SiparisRaporFrm : Form
    {
        public SiparisRaporFrm()
        {
            InitializeComponent();
        }

        private void SiparisRaporFrm_Load(object sender, EventArgs e)
        {
            decimal ciro = 0;
            decimal exMalzemeGeliri = 0;
            int satisAdedi = 0;

            foreach (Siparis siparis in SiparisEkrani.siparisler)
            {
                ciro += siparis.ToplamTutar;

                foreach (Extra extra in siparis.ExtraMalzeme)
                {
                    exMalzemeGeliri += extra.Fiyati;
                }
                satisAdedi += siparis.Adet;

                lstSiparisler.Items.Add(siparis);
            }

            lblCiro.Text = ciro.ToString();
            lblExtraMalzemeGeliri.Text = exMalzemeGeliri.ToString();
            lblSatilanUrunAdedi.Text = satisAdedi.ToString();
            lblSiparisSayisi.Text = lstSiparisler.Items.Count.ToString();

        }
    }
}
