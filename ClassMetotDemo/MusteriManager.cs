using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Id +" "+musteri.Ad+" "+musteri.Soyad+" Musteri Bilgileri Eklendi");
        }

        public void Listele(Musteri musteri)
        {
          
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + musteri.Ad + " " + musteri.Soyad + " Musteri Bilgileri Silindi");
        }
    }
}
