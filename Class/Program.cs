using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "evin";
            int yas = 30;
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Java";
            kurs1.Egitmen = "Kerem Varış";
            kurs1.IzlenmeOrani = 64;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C#";
            kurs2.Egitmen = "Engin Demiroğ";
            kurs2.IzlenmeOrani = 68;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Evin Dağ";
            kurs3.IzlenmeOrani = 90;

            // Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);
            Console.WriteLine("hello");
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; } // class tanımlıyoruz.
        public String Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}