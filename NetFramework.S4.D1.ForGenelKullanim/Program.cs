using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S4.D1.ForGenelKullanim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For döngüsü genel kullanımı
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i+1+".Ben bir for döngüsüyüm");
            //}
            #endregion

            #region Ekran üzerinde 1-10 arasındaki değerleri yazdıralım
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i + ".Tekrar");
            //}
            #endregion

            #region 1 - 100 arasındaki çift sayıları ekran üzerinde yazdıralım.
            //for (int i = 0; i < 100; i++)
            //{
            //    if (i%2==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region Küçük ödev : 1 - 100 arasında ki çift sayıların toplamı.
            //int toplam = 0;
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i%2==0)
            //    {
            //        toplam += i;
            //    }
            //}
            //Console.WriteLine("Toplam: " + toplam);
            #endregion

            #region Ödev: Kullanıcı üzerinden bir sayı girişi yapacak. (5) girilen sayısının faktöriler hesabını alıp ekrana yazdıralım.
            //Console.WriteLine("Faktöriyel değerini giriniz: ");
            //int deger=Convert.ToInt32(Console.ReadLine());
            //int fak = 1;
            //for (int i = 1; i <= deger; i++)
            //{
            //    Console.WriteLine(i+".sayı: "+i);
            //    fak *= i;
            //}
            //Console.WriteLine("faktöriyel: "+fak);
            #endregion

            #region Sonsuz döngü oluşturmak
            //int sayac = 0;
            //for(; ; )
            //{
            //    sayac++;
            //    ////break anahtar kelimesi
            //    //if (sayac == 2)
            //    //    break;

            //    //continue anahtar kelimesi
            //    if (sayac == 2)
            //        continue;
            //    Console.WriteLine(sayac);
            //    Console.WriteLine("Merhaba ben bir sonsuz döngüyüm.");
            //}
            #endregion

            #region iç içe for döngüsü kullanımı
            //for (int i = 1; i <=20 ; i++)
            //{
            //    for (int j = 1; j <=i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Ödev çarpım tablosu
            for (int i = 1; i <=10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i+"x"+j+"="+i*j);
                }
                Console.WriteLine();
            }
            #endregion
        Console.ReadLine();
        }
    }
}
