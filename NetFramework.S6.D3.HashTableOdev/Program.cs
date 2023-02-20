using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S6.D3.HashTableOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.Write("Yeni kayıt eklemek istiyor musunuz (E/H)");
            //string kullaniciYeniKayit = Console.ReadLine();
            //if (kullaniciYeniKayit.ToUpper()=="E")
            //{
            //    Console.Write("Eklemek istediğiniz Kayıtın İngilizce (Key) Değerini Girin: ");
            //    string kullaniciIngilizce = Console.ReadLine();
            //    Console.WriteLine("Eklemek istediğiniz Kayıtın Türkçe Değerini Girin: ");
            //    string kullaniciTurkce = Console.ReadLine();
            //    //bool kontrol = sozluk.Contains(kullaniciIngilizce);
            //    if (sozluk.Contains(kullaniciIngilizce))
            //    {
            //        Console.WriteLine("Girmiş olduğunuz key değer zaten var lütfen başka bir değer giriniz.");
            //        System.Threading.Thread.Sleep(1000);
            //    }
            //    else
            //    {
            //        sozluk.Add(kullaniciIngilizce,kullaniciTurkce);
            //    }
            //}
            //else if (kullaniciYeniKayit.ToUpper() == "H")
            //{
            //    for (int i = 0; i < sozluk.Count; i++)
            //    {

            //        Console.WriteLine(i+1+". Değer: " + sozluk[i]);
            //    }
            //}
            Hashtable sozlukVeriTabani = new Hashtable();

            do
            {
                Console.Clear();
                Console.WriteLine("Eklemek istediğiniz sözlük değerini yazınız.");
                Console.Write("EN : ");
                string kullaniciIngilizceKayit= Console.ReadLine();
                bool sozlukKontrol = sozlukVeriTabani.Contains(kullaniciIngilizceKayit);
                if (sozlukKontrol)
                {
                    Console.Write("Lütfen Kayıtlarda olmayan bir sözlük değeri giriniz. ");
                }
                else
                {
                    Console.WriteLine(kullaniciIngilizceKayit+" Türkçe anlam değerinizi yazınız.");
                    Console.Write("TR : ");
                    string kullaniciTurkceKayit = Console.ReadLine();
                    sozlukVeriTabani.Add(kullaniciIngilizceKayit, kullaniciTurkceKayit);
                    Console.Write($"{kullaniciIngilizceKayit} Başarı ile Eklenmiştir. ");
                }
                Console.WriteLine("Yeni değer eklemek istiyor musunuz (E/H)");

            } while (Console.ReadLine().ToUpper()!="H");

            //1. yöntem
            foreach (var item in sozlukVeriTabani.Keys)
            {
                Console.WriteLine("ENG : {0} = TR : {1}", item, sozlukVeriTabani[item]);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //2.yöntem
            foreach (DictionaryEntry item in sozlukVeriTabani)
            {
                Console.WriteLine("ENG : {0} = TR : {1}",item.Key,item.Value);
            }
            Console.ReadLine();

        }
    }
}