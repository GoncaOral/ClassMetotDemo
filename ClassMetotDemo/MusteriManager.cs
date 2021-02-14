using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(int Id, string MusteriAdi, bool MusteriDurumu)
        {
            Console.WriteLine("Müşteri Eklendi :" + MusteriAdi);
        }
        public void list()
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.MusteriAdi = "Demet";
            musteri1.MusteriDurumu = true;


            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.MusteriAdi = "Özge";
            musteri2.MusteriDurumu = true;


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (Musteri item in musteriler)
            {
                Console.WriteLine("Müşteri Adı : " + item.MusteriAdi);
                Console.WriteLine("Müşteri Durumu :" + item.MusteriDurumu);
                Console.WriteLine(".........................................");
            }

        }

        public void Delete(int Id, string MusteriAdi)
        {
            Console.WriteLine(MusteriAdi + " Adlı Müşteri Silindi :");
        }
    }
}
