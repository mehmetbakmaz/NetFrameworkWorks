using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S4.D2.ForeachGenelKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Genel Kullanımı
            //string[] isimler = new[]{ "Sercan Yöndem", "Cengiz Atilla", "Mustafa Gökmen", "Mustafa Sel" };

            //foreach (var item in isimler)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Örnek Uygulamalar

            #endregion

            #region Uygulama 1: int veri tipinde bir dizi oluşturalım, kullanıcımız dizinin kaç elemanlı olacağı bilgisini bize versin ve dizi içindeki alanlara değer ataması yapsın. Daha sonra dizi içerisindeki elemanların ve ortalamasını ekrana yazdıran bir uygulama yazalım.
            //Console.Write("Dizi kaç elemanlı olsun: ");
            //int diziElaman=Convert.ToInt32(Console.ReadLine()); 
            //int[] dizi = new int[diziElaman];
            //int toplam = 0;
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.Write(i+1+". değeri giriniz: ");
            //    dizi[i] = Convert.ToInt32(Console.ReadLine());  
            //}
            //Console.Write("Diziler: ");
            //foreach (var item in dizi)
            //{
            //    Console.Write(" "+item);
            //    toplam += item;
            //}
            //Console.Write("\nToplam: "+toplam);
            //Console.Write("\nOrtalama: "+dizi.Average());
            #endregion

            #region Uygulama 2: 20 elemanlı int dizi oluşturalım. değerlerimizi random sınıfının next fonksiyonu ile 1-10 arasındaki değerlerle dolduralım. daha sonra dizi içerisindeki elemanlarımızı ekrana yazdıralım ve ilgili dizi içerisnde kaç tane 4 değer olduğunu bulalım.

            Random rnd= new Random();
            int[] dizi = new int[20];
            int adet = 0;
            for (int i = 0;i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(1,10);
            }
            Console.Write("Diziler: ");
            foreach (var item in dizi)
            {
                Console.Write(" "+item);
                if (item==4)
                {
                    adet++;
                }
            }

            Console.Write("\nDizi içerisinde "+adet+" tane 4 vardır.");
            #endregion
            Console.ReadLine();
        }
    }
}
