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
    public partial class ExtraMalzemeFrm : Form
    {
        public ExtraMalzemeFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Extra m = new Extra();
            m.ExtraAdi = txtAd.Text;
            m.Fiyati = nmrFiyat.Value;
            m.Id = SiparisEkrani.extralar.Count + 1;
            SiparisEkrani.extralar.Add(m);

            txtAd.Text = "";
            nmrFiyat.Value = 1;

            MessageBox.Show("Başariyla Eklendi");
        }
    }
}
