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
    public partial class MenuTanim : Form
    {
        public MenuTanim()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.MenuAdi = txtMenuAdi.Text;
            m.Fiyati = nmrFiyat.Value;
            m.Id = SiparisEkrani.menuler.Count + 1;
            SiparisEkrani.menuler.Add(m);

            txtMenuAdi.Text = "";
            nmrFiyat.Value = 1;

            MessageBox.Show("Başariyla Eklendi");
        }
    }
}
