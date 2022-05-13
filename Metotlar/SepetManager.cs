using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun) //Urun urun  parametredir.
        {
            Console.WriteLine("Tebrikler "+ urun.Adi + " Sepete eklendi : " );

        }

        public void Ekle2(string urunAdi,string aciklama,double fiyat,int stokAdedi)
        {
            Console.WriteLine("Tebrikler " + urunAdi + " Sepete eklendi : ");
        }
    }
}
