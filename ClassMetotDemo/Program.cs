using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musterimanager = new MusteriManager();

            Console.WriteLine("Müşteri Ekleme");
            musterimanager.Add(3, "Ayşe", true);

            Console.WriteLine("................................");

            Console.WriteLine("Müşteri Listesi");
            musterimanager.list();

            Console.WriteLine("Müşteri Silme");
            musterimanager.Delete(2, "Özge");
        }
    }
}
