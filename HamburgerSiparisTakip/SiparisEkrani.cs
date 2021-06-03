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
    public partial class SiparisEkrani : Form
    {
        public static List<Siparis> siparisler = new List<Siparis>();//Raporlama için tutuluyor
        public static List<Siparis> mevcutsiparis = new List<Siparis>();//Mevcut siparişi tutacak

        public static List<Menu> menuler = new List<Menu>()
        {
            new Menu { MenuAdi="Whooper" ,          Fiyati=30,  Id=1},
            new Menu { MenuAdi="BigKing" ,          Fiyati=35,  Id=2},
            new Menu { MenuAdi="King Chicken" ,     Fiyati=28 , Id=3},
            new Menu { MenuAdi="McFish" ,           Fiyati=40,  Id=4},
            new Menu { MenuAdi="Köfte Burger  " ,   Fiyati=55,  Id=5},
            new Menu { MenuAdi="Texas" ,            Fiyati=55,  Id=6},
            new Menu { MenuAdi="Junior " ,           Fiyati=55,  Id=7}

        };
        public static List<Extra> extralar = new List<Extra>()
        {
            new Extra { ExtraAdi=" Soğan Halkası", Fiyati=10 },
            new Extra { ExtraAdi=" Tavuk Parçaları", Fiyati=12 },
            new Extra { ExtraAdi=" Hardal", Fiyati=5 },
            new Extra { ExtraAdi=" Ranch Sos", Fiyati=5 },
            new Extra { ExtraAdi=" Sarımsaklı Mayonez", Fiyati=5 },
        };


        public SiparisEkrani()
        {
            InitializeComponent();
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparis yeniSiparis = new Siparis();
            yeniSiparis.SeciliMenu = (Menu)cbMenuler.SelectedItem;

            if (rbKucuk.Checked)
                yeniSiparis.Boyut = Boyut.Kucuk;
            if (rbOrta.Checked)
                yeniSiparis.Boyut = Boyut.Orta;
            if (rbBuyuk.Checked)
                yeniSiparis.Boyut = Boyut.Buyuk;

            yeniSiparis.Adet = (int)nmrAdet.Value;

            List<Extra> extras = new List<Extra>();
            foreach (CheckBox item in flpExtraMalzemeler.Controls)
            {
                if (item.Checked)
                {
                    extras.Add((Extra)item.Tag);
                }
            }
            yeniSiparis.ExtraMalzeme = extras;
            yeniSiparis.Hesapla();
            mevcutsiparis.Add(yeniSiparis);

            siparisler.Add(yeniSiparis);
            lstSiparisler.Items.Add(yeniSiparis);

            TutarHesapla();

        }

        private decimal TutarHesapla()
        {
            decimal toplamTutar = 0;
            foreach (Siparis siparis in lstSiparisler.Items)
            {
                toplamTutar += siparis.ToplamTutar;
            }
            lblToplamTutar.Text = toplamTutar.ToString();

            return toplamTutar;
        }

        private void SiparisEkrani_Load(object sender, EventArgs e)
        {
            foreach (var item in menuler)
            {
                cbMenuler.Items.Add(item);
            }


            foreach (var extra in extralar)
            {
                flpExtraMalzemeler.Controls.Add(new CheckBox() { Text = extra.ExtraAdi , Tag = extra });
            
            }
            //Menülerde başta görünmesini istediğimiz menu için yazıldı.
            cbMenuler.SelectedIndex = 1;

        }

        private void lstSiparisler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Sipariş tamamla butonu işlemleri
        private void btmSiparisTamamla_Click(object sender, EventArgs e)
        {
            string mesaj = "Toplam Siparis Ucreti:" + TutarHesapla().ToString() + " Satin Almayi Tamamlamak Ister misiniz?";
            DialogResult dr = MessageBox.Show(mesaj, "Siparis Bilgisi ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                //lblToplamTutar.Text = "Siparis Onaylandi";

                lstSiparisler.Items.Clear();
                mevcutsiparis.Clear();
                TutarHesapla();
                MessageBox.Show("Siparis Tamamlandi");
                
            }
            else
            {
                MessageBox.Show("Siparis iptal Edildi");
            }
        }
    }
}
