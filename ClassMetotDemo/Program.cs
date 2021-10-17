using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Ali";
            musteri1.Soyad = "Candan";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Aslan";
            musteri2.Soyad = "Akbey";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri2);
           // musteriManager.Add(musteri1);

            musteriManager.Delete(musteri1);
        }
    }
}
