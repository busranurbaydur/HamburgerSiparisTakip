using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerSiparisTakip
{
    public class Siparis : IEntity<int>, //Id kolonu alabilsin diye
       IAuditEntity<Type> // CreateTime Ve CreateUser Alani Eklensin diye Bu interface'i kullandik
    {
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        public int Adet { get; set; }
        public Boyut Boyut { get; set; }
        public decimal ToplamTutar { get; set; }
        public Type CreateUser { get; set ; }
        public Menu SeciliMenu { get; set; }
        public List<Extra> ExtraMalzeme { get; set; }

        //Bu kısım sipariş ekranına seçimlerimizi göstermek için yapılmıştır.
        public override string ToString()
        {
            if (ExtraMalzeme.Count < 1)
            {
                return $"{SeciliMenu} * {Adet} {Boyut} Seçim , Toplam: ";
            }
            else
            {
                string exMalzeme = null;
                foreach (Extra extra in ExtraMalzeme)
                {
                    exMalzeme = extra.ExtraAdi + " ,";
                }
                exMalzeme = exMalzeme.Trim(',');

                return $"{SeciliMenu} * {Adet} {Boyut} Seçim ,Extra Malzemeler : {exMalzeme} Toplam: {ToplamTutar.ToString()} ";

            }

        }

        public void Hesapla() 
        {
            //Burada sadece seçilmiş menünün fiyatını yazdırdık.
            ToplamTutar = 0;
            ToplamTutar += SeciliMenu.Fiyati;

            //Burada seçilmiş menü + seçmiş olduğumuz boyutun fiyatı hesaplanacak.
            switch (Boyut)
            {
                case Boyut.Kucuk:
                    break;
                case Boyut.Orta:
                    ToplamTutar = ToplamTutar * 0.1m;
                    break;
                case Boyut.Buyuk:
                    ToplamTutar = ToplamTutar + 0.2m;
                    break;
                default:
                    break;
            }

            //Burada da seçili menü+ boyut fiyatımızla eklenen ücret + seçtiğimiz
            //extra malzemelerimizin ücreti gösterilecek.

            foreach (Extra extra in ExtraMalzeme)
            {
                ToplamTutar += extra.Fiyati;
            }
            ToplamTutar = ToplamTutar * Adet;
        }

    }
}
