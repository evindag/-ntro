using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{
    internal class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi " + urun.Adi); 
            // Buradan parantez içine yapacığımız bir değişiklik tüm sayfaları etkiler. Tüm sayfalarda değişir.
        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Teprikler.Sepete eklendi: " + urunAdi);
        }
    }
}
