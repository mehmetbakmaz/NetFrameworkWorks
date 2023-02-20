using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFramework.S7.D2.MatematikselIslemler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matematik M = new Matematik();
            YenidenIslemYap:
            M.menuHazirla();
            int kullaniciSecim = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lütfen 1. sayı değerini giriniz: ");
            decimal kullaniciSayi1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Lütfen 2. sayı değerini giriniz: ");
            decimal kullaniciSayi2 = Convert.ToDecimal(Console.ReadLine());
            decimal sonuc = 0;
            switch (kullaniciSecim)
            {
                case 1:
                    sonuc = M.toplamaIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "+");
                    break;
                case 2:
                    sonuc= M.cikarmaIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "-");
                    break;
                case 3:
                    sonuc = M.bolmeIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "/");
                    break;
                case 4:
                    sonuc = M.carpmaIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "*");
                    break;
                default:
                    Console.WriteLine("Lütfen geçerli bir değer girin.");
                    System.Threading.Thread.Sleep(2000);
                    goto YenidenIslemYap;
                    break;
            }
            Console.WriteLine("Yeni işlem yapmak istiyor musunuz? (E/H) ");
            string EH = Console.ReadLine();
            if (EH.ToUpper() == "E")
            {
                goto YenidenIslemYap;
            }
            Console.ReadLine();
        }
    }
}
