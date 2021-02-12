using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {

        //namig convertion
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi: "+ urun.Adi);

        }

        public void Ekle2(string UrunAdi,string Aciklama,int Fiyati)
        {
            Console.WriteLine("Sepete Eklendi: " + UrunAdi);

        }






    }
}
