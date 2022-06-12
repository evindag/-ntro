using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Prgramlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Prgramlamaya başlangıç için temel kurs", "Java","Python" };
            for (int i = 0; i<kurslar.Length; i++) 
// yüksek bir sayı olduğunda aklımızda tutamıcağımız için kursların uzunluğu kadar dedik.
            {
                Console.WriteLine(kurslar[i]);  
            }
            Console.WriteLine("For bitti");
            // Şimdi aynısını foreach ile yapalım
            foreach (string kurs in kurslar) // string in s si büyük yazılırsa bir classa karşılık gelir.
            {
                Console.WriteLine(kurs);
            }
            // foreach döngüsü dizilere uygulanır.
            Console.WriteLine("Sayfa Sonu - footer");
        }
    } 
}