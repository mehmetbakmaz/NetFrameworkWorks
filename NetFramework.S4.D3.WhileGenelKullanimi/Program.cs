using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S4.D3.WhileGenelKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Genel Kullanımı
            //while (true) // true olduğu sürece boyunca döngü çalışır, False olana kadar veya Breake kadar.
            //{

            //}
            #endregion

            #region Örnek Kullanımı 1: ekrana 1-10 a kadar sayıların değerlerini yazdıralım.
            ////for (int i = 1; i <=10; i++)
            ////{
            ////    Console.WriteLine(i);
            ////}

            //int sayac = 1;
            //while (sayac<=10)
            //{
            //    Console.WriteLine(sayac);
            //    sayac++;
            //}
            #endregion

            #region Kullanıcıdan gelen sayısal değere göre ekrana 1 eksilterek 0 değerine ulaşınca kadar ekrana yazdıralım
            //Console.Write("Sayı giriniz: ");
            //int sayi=Convert.ToInt32(Console.ReadLine());
            //while(sayi>=0)
            //{
            //    Console.WriteLine(sayi--);
            //}
            #endregion

            #region Kullanıcıdan gelen değerlerin toplamını ekrana yazdıralım. 0 dan küşçük bir değer girişi yapılırsa toplama işlemini bitirelim ve ekrana toplam sonucu yazalım.
            //Console.Write("Kaç değer girmek istiyorsunuz: ");
            //int deger=Convert.ToInt32(Console.ReadLine());
            //int toplam = 0;
            //for (int i = 1;i <= deger; i++)
            //{
            //    if (deger>=0)
            //    {
            //        Console.Write(i + ". sayıyı giriniz: ");
            //        int sayi = Convert.ToInt32(Console.ReadLine());
            //        if (sayi>=0)
            //        {
            //            toplam += sayi;
            //        }
            //        else if (sayi < 0)
            //        {
            //            Console.WriteLine("0 dan küçük bir sayı girildi. Toplama işlemi yapılıyor...\nToplama: " + toplam);
            //            break;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hatalı İşlem");
            //    }
            //}

            //Console.Write("Lütfen bir sayı giriniz:\nNot: -1 değeri işlemlerinizi durdurur. ");
            //int ornekKullanimToplam = 0;
            //while (true)
            //{
            //    string Ornek2KullaniciGelenDeger = Console.ReadLine();
            //    int Ornek2KulGelenDegerInt = int.Parse(Ornek2KullaniciGelenDeger);
            //    if (Ornek2KulGelenDegerInt < 0)
            //        break;
            //    else
            //        ornekKullanimToplam += Ornek2KulGelenDegerInt;
            //}
            //Console.WriteLine("Toplam: "+ornekKullanimToplam);
            #endregion

            #region Ödev: Sistemin çalışma zamanında oluşturduğu 1 ile 10 arasındaki bir değeri kullanıcının tahmin etmesini isteyecek bir uygulama yazalım.

            Console.Write("1-10 arasında sayı giriniz.");
            Random rnd = new Random();
            int rastgele=rnd.Next(1,11);
            int adet = 1;
            while (true) 
            {
                Console.Write("Tahminde bulununuz: ");
                int tahmin=Convert.ToInt32(Console.ReadLine());
                if (tahmin==rastgele)
                {
                    Console.WriteLine("Tebrikler Doğru cevap."+adet+". deneyişinizde buldunuz. ");
                    break;
                }
                else
                {
                    adet++;
                    Console.WriteLine("Tekrar deneyiniz.");
                }
            }
            #endregion
            Console.ReadLine();
        }
    }
}
