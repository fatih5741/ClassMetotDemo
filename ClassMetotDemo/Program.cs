using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.musteriId = 1;
            musteri1.musteriAdi = "Fatih";
            musteri1.musteriSoyadi = "Demir";
            musteri1.musteriSinifi = "Gold";
            musteri1.musteriTel = "541 125 41 57";

            Musteri musteri2 = new Musteri();

            musteri2.musteriId = 2;
            musteri2.musteriAdi = "Ercan";
            musteri2.musteriSoyadi = "Öztürk";
            musteri2.musteriSinifi = "Standart";
            musteri2.musteriTel = "541 125 52 60";


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();

            foreach (Musteri musteri in musteriler)
            {
                musteriManager.musteriEkle(musteri);
               
            }

            Console.WriteLine("--------------------------------------------------");


            foreach (Musteri musteri in musteriler)
            {
                musteriManager.musteriSil(musteri);
            }

            Console.WriteLine("--------------------------------------------------");


            foreach (Musteri musteri in musteriler)
            {
                musteriManager.musteriListele(musteri);
            }
        }
    }
}
