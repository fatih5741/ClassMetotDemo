using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void musteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Id: " + musteri.musteriId);
            Console.WriteLine("Müşteri Adı: " + musteri.musteriAdi);
            Console.WriteLine("Müşteri Soyadı: " + musteri.musteriSoyadi);
            Console.WriteLine("Müşteri Sınıfı: " + musteri.musteriSinifi);
            Console.WriteLine("Müşteri Tel: " + musteri.musteriTel);
            Console.WriteLine("Müşteriniz Eklendi");
        }

        public void musteriSil(Musteri musteri)
        {

            Console.WriteLine("Müşteri Id: " + musteri.musteriId);
            Console.WriteLine("Müşteri Adı: " + musteri.musteriAdi);
            Console.WriteLine("Müşteri Soyadı: " + musteri.musteriSoyadi);
            Console.WriteLine("Müşteriniz Silindi");
        }


        public void musteriListele (Musteri musteri)
        {
            Console.WriteLine("Müşteri Id: " + musteri.musteriId);
            Console.WriteLine("Müşteri Adı: " + musteri.musteriAdi);
            Console.WriteLine("Müşteri Soyadı: " + musteri.musteriSoyadi);
            Console.WriteLine("Müşteri Sınıfı: " + musteri.musteriSinifi);
            Console.WriteLine("Müşteri Tel: " + musteri.musteriTel);
            Console.WriteLine("Müşteriniz Listelendi");
        }
    }
}
