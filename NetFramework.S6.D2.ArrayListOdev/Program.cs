using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S6.D2.ArrayListOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList degerListesi = new ArrayList();
            string kullaniciSecim="";
            do
            {
                Console.Clear();
                Console.WriteLine("****Menü****");
                Console.WriteLine("1 - Değer Ekle");
                Console.WriteLine("2 - Değer Listele");
                Console.WriteLine("3 - Değer Ara");
                Console.WriteLine("4 - Değer Düzenle");
                Console.WriteLine("5 - Değer Sil");
                Console.WriteLine("6 - Uygulama Çıkış");
                Console.Write("Seçiniz: ");

                kullaniciSecim= Console.ReadLine();


                degerListesi.Add("ORN1");
                degerListesi.Add("ORN2");
                degerListesi.Add("ORN3");
                degerListesi.Add("ORN4");
                degerListesi.Add("ORN5");
                degerListesi.Add(100);

                char kullaniciTekrar;
                switch (kullaniciSecim)
                {
                    case "1":
                        do
                        {
                            Console.Write("Eklemek İstediğiniz değeri giriniz: ");
                            string kullaniciDeger = Console.ReadLine();
                            degerListesi.Add(kullaniciDeger);
                            Console.Write("Tekrar değer eklemek istiyor musunuz?(E/H): ");
                            kullaniciTekrar = Convert.ToChar(Console.ReadLine().ToLower());
                        } while (kullaniciTekrar!='h');
                            
                        break;
                    case "2":
                        Console.Write("Değerler: ");
                        foreach (var item in degerListesi)
                        {
                            Console.Write(" " + item);
                        }

                        break;
                    case "3":
                        Console.WriteLine("Aramak istediğiniz değeri giriniz: ");
                        string kullaniciArama = Console.ReadLine();
                        if (degerListesi.Contains(kullaniciArama))
                        {
                            string kullaniciİndex = degerListesi.IndexOf(kullaniciArama).ToString();
                            Console.WriteLine(kullaniciArama + "değeri vardır. İndex No: " + kullaniciİndex);
                        }
                        else
                        {
                            Console.WriteLine("değeri yoktur.");
                        }

                        break;
                    case "4":
                        Console.WriteLine("Kaçıncı değeri düzenlemek istiyorsunuz: ");
                        int kullaniciDüzenleme = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ne yapmak istiyorsunuz?: ");
                        string kullaniciSonuc = Console.ReadLine();
                        degerListesi[kullaniciDüzenleme] = kullaniciSonuc;
                        Console.WriteLine("İşlem başarılı, yeni değer: " + kullaniciSonuc);
                        break;
                    case "5":
                        Console.WriteLine("Hangi Değeri Silmek istiyorsunuz?: ");
                        string kullaniciSilme = Console.ReadLine();
                        if (degerListesi.Contains(kullaniciSilme))
                        {
                            degerListesi.Remove(kullaniciSilme);
                            Console.WriteLine("İşlem başarılı. " + kullaniciSilme + " değeri silindi");
                        }
                        else
                        {
                            Console.WriteLine("Lütfen geçerli bir değer girin");
                        }
                        Console.Write("Üst Menüye Dönmek İstiyor musunuz?: ");
                        break;
                    default:


                        break;
                }
            } while (kullaniciSecim!="6");
        }
    }
}
