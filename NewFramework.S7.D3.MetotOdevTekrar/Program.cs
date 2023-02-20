using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NewFramework.S7.D3.MetotOdevTekrar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            yenidenIslem:
            decimal sonuc;
            Ogrenci ogrenci= new Ogrenci();
            ogrenci.Acilis();
            Console.Write("Adınızı giriniz: ");
            string name=Console.ReadLine();
            Console.Write("Soyadınızı giriniz: ");
            string surname=Console.ReadLine();
            Console.Write("1.Not: ");
            decimal sayi1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("2.Not: ");
            decimal sayi2 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("3.Not: ");
            decimal sayi3 = Convert.ToDecimal(Console.ReadLine());
            ogrenci.OgrenciBilgi(name, surname);
            sonuc =ogrenci.OgrenciNot(sayi1,sayi2,sayi3);
            if (sonuc>=45)
            {
                Console.WriteLine("Tebrikler notunuz: "+sonuc+" Geçtiniz.");
            }
            else if (sonuc<45 && sonuc>=0)
            {
                Console.WriteLine("Maalesef notunuz: "+sonuc+" Kaldınız.");
            }
            else
            {
                Console.WriteLine("Hatalı İşlem.");
                System.Threading.Thread.Sleep(1000);
                goto yenidenIslem;

            }
            Console.Read();
        }
    }
}
