using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NewFramework.S7.D2.MatematikselIslemler
{
    public class Matematik
    {
        //Topla
        public decimal toplamaIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 + sayi2;
            return sonuc;
        }

        //Çıkart
        public decimal cikarmaIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 - sayi2;
            return sonuc;
        }

        //Bolme
        public decimal bolmeIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 / sayi2;
            return sonuc;
        }

        //Çarpma
        public decimal carpmaIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 * sayi2;
            return sonuc;
        }

        public void menuHazirla()
        {
            Console.Clear();
            Console.WriteLine("***** Menü *****");
            Console.WriteLine("1 - Toplama");
            Console.WriteLine("2 - Çıkartma");
            Console.WriteLine("3- Bölme");
            Console.WriteLine("4- Çarpma");
            Console.Write("Lütfen değer seçiniz: ");
        }

        public void sonucEkranaYaz(decimal kulllaniciSayi1, decimal kullaniciSayi2, decimal sonuc, string operators)
        {
            Console.WriteLine($"{kulllaniciSayi1}{operators}{kullaniciSayi2}={sonuc}");
        }
    }
}
