using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S4.D5.doWhileOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ödev 1: Kullanıcıyı do while içerisine alın ve kullanıcı adı ve password sorun. Kullanıcı adı: Demo Şifre: Demo eğer kullanıcı bu değerleri bilirse döngüden çıkın ve başarılı yazın. Eğer yanlış giriş yapıyorsa do while ile ilgili değerleri sormaya devam edin.

            //string username = string.Empty;
            //string password = "";
            //int sayac = 0;
            //do
            //{
            //    Console.Write("Kullanıcı Adı: ");
            //    username = Console.ReadLine().ToLower();
            //    Console.Write("Şifre: ");
            //    password = Console.ReadLine().ToLower();
            //    sayac++;
            //    if (sayac>0)
            //    {
            //        Console.WriteLine("kullanıcı adı veya şifre hatalı");
            //    }

            //} while (username!="demo" || password!="demo");
            //Console.WriteLine("Tebrikler.");

            #endregion

            #region Ödev 2: Kullanıcıdan 1 ile x arasında bir sayı girmesini isteyin. daha sonra sistem kullanıcının girmiş olduğu 1 ile x değerleri arasında bir sayı tahmini yapsın. Daaha sonras kullanıcı sistemin tahmin etmiş olduğu sayıyı bulmaya çalışsın. Bulamaz ise yeniden yeniden sorsun. Ne zaman kullanıcı ile ilgili değeri bulursa Y kadar denediniz ve sonuca ulaştınız desin.

            Random rnd= new Random();   
            Console.Write("Tahmin programına hoşgeldiniz. Lütfen sistemimize 2 sayı giriniz. Gireceğiniz bu 2 sayı aralığında sistem random sayı oluşturucaktır ve bu sayıyı bulmaya çalışın\n1. Sayı: ");
            int sayi1=Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayı: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int rastgele = rnd.Next(sayi1, sayi2 + 1);
            string tahmin = string.Empty ;
            int adet = 0;
            do
            {
                Console.Write(sayi1+" ve "+sayi2+" Değerleri arasında bir tahmin giriniz.");
                tahmin=Console.ReadLine();
                adet++;
            } while (tahmin!=rastgele.ToString());
            Console.Write("Tebrikler "+adet+". denemenizde bildiniz.");
            #endregion
            Console.ReadLine();
        }
    }
}
