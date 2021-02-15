using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Engin Demirog
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "32324";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demirog";
            musteri1.TcNo = "345436454";

            //Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "43434543";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "12243456";


            //Gercek Musteri-Tuzel Musteri
            //SOLID  (L)

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            

        }
    }
}
