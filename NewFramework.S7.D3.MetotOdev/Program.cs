using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFramework.S7.D3.MetotOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcı adı soyadı 3 farklı ders notu öğrencipuanhesapla
            //1.not 50 2.not 50 3.not 40
            //50+50+40 = 140 
            // 140 /3 = 47 -- 45 den yukarı geçti, 45 den aşağı kaldı
            Ogrenci ogrenci= new Ogrenci();
            yeniİslem:
            decimal sonuc = 0;
            decimal ortalama = 0;
            ogrenci.Acilis();
            Console.Write("Ad: ");
            string kullaniciAd=Console.ReadLine();
            Console.Write("Soyad: ");
            string kullaniciSoyad = Console.ReadLine();
            Console.Write("Lütfen 1. notunuzu giriniz: ");
            int ogrenciNot1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen 2. notunuzu giriniz: ");
            int ogrenciNot2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen 3. notunuzu giriniz: ");
            int ogrenciNot3 = Convert.ToInt32(Console.ReadLine());
            sonuc = ogrenci.NotToplam(ogrenciNot1,ogrenciNot2,ogrenciNot3);
            ortalama = ogrenci.Averages(sonuc);
            ogrenci.sonucEkranaYaz(ogrenciNot1, ogrenciNot2, ogrenciNot3, sonuc, ortalama, kullaniciAd,kullaniciSoyad);
            if (ortalama>=45)
            {
                Console.WriteLine("Dersi geçtiniz.");
            }
            else if (ortalama >=0 && ortalama < 45)
            {
                Console.WriteLine("Dersden kaldınız.");
            }
            else 
            {
                Console.WriteLine("Lütfen - değer girmeyiniz. ! Hatalı işlem !");
                System.Threading.Thread.Sleep(2000);
                goto yeniİslem;
            }
            Console.ReadLine();
        }
    }
}
