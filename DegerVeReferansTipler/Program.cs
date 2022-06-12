using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);
            //cevap 30

            int[] sayilar1 = new int[] {10,20,30};
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);
            //cevap 999
            // çünkü diziler referans değer tutar sayi1 in referans numarasının sayı2 ile aynı yaptık
            // sonra sayı2 nin sıfırıncı değeri 999 dedik o zaman sayı1 in de sıfırıncı değeri 999 dur.
            // sayilar1 dizisini tutan bişey olmadığı için bellekten silinir
           //int, decimal,float,double,bool = değer tiplerdir.
           //array,class,interface = referans tiplerdir.


        }
    }
}

