using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S6.D2.ArrayListOdevTekrar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kullaniciSecim = "";
            ArrayList degerListesi = new ArrayList();
            do
            {
                Console.Clear();
                Console.WriteLine("*************Menü*************");
                Console.WriteLine("1 - Değer Ekle");
                Console.WriteLine("2 - Değer Listele");
                Console.WriteLine("3 - Değer Ara");
                Console.WriteLine("4 - Değer Düzenle");
                Console.WriteLine("5 - Değer Sil");
                Console.WriteLine("6 - Uygulama Çıkış");
                Console.Write("Seçiniz: ");
                kullaniciSecim=Console.ReadLine();

                switch (kullaniciSecim)
                {
                    case "1":
                        Console.Write("Eklemek istediğiniz değeri giriniz: ");
                        string kullaniciDegerEkleme=Console.ReadLine();
                        if (degerListesi.Contains(kullaniciDegerEkleme)==true)
                        {
                            Console.Write("\n\nUYARI ! \nEklemek istediğiniz değer, listede mevcuttur lütfen farklı bir değer giriniz");
                        }
                        else
                        {
                            degerListesi.Add(kullaniciDegerEkleme);
                            Console.WriteLine("Ekleme işlemi başarılı.");
                        }
                        System.Threading.Thread.Sleep(1000);
                        break;
                    case "2":
                        Console.WriteLine("*********Değer Listesi*********");
                        for (int i = 0; i < degerListesi.Count; i++)
                        {
                            Console.Write(i+1+". Değer: " + degerListesi[i]+"\n");
                        }
                        Console.Write("Devam etmek için bir tuşa basınız: ");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.Write("Aramak İstediğiniz Değeri Giriniz: ");
                        string kullaniciDegerArama = Console.ReadLine();
                        bool kontrol = degerListesi.Contains(kullaniciDegerArama);
                        if (kontrol)
                        {
                            int bulunanIndex = degerListesi.IndexOf(kullaniciDegerArama);
                            string bulunanDeger = degerListesi[bulunanIndex].ToString();
                            Console.WriteLine($"Değeriniz Bulundu: {bulunanDeger}\n Index Numarası: {bulunanIndex}");
                        }
                        else
                        {
                            Console.WriteLine("\n\nUYARI ! \nAradığınız değer bulunamadı. Değeri listeye eklemek ister misiniz (E/H)");
                            string kullaniciEvetHayir=Console.ReadLine().ToUpper();
                            if (kullaniciEvetHayir=="E")
                            {
                                Console.WriteLine("Değer başarıyla eklendi.");
                                degerListesi.Add(kullaniciDegerArama);
                            }
                            else
                            {
                                Console.WriteLine("\n\nUYARI ! \nAna menüye yönlendiriliyorsunuz.");

                            }
                        }
                        System.Threading.Thread.Sleep(1000);
                        break;
                    case "4":
                        Console.Write("Liste içerisinde var olan, düzenlemek istediğiniz değeri giriniz: ");
                        string kullaniciDegerDuzenleme=Console.ReadLine();
                        if (degerListesi.Contains(kullaniciDegerDuzenleme)==true)
                        {
                            int bulunanIndex1 = degerListesi.IndexOf(kullaniciDegerDuzenleme);
                            string bulunanDeger1 = degerListesi[bulunanIndex1].ToString();
                            Console.Write("Liste dışarısında var olan, düzeltmek istediğiniz değeri giriniz: ");
                            string kullaniciYeniDeger=Console.ReadLine();
                            degerListesi[bulunanIndex1] = kullaniciYeniDeger;
                            Console.WriteLine("Düzenleme işlem başarılı.");
                        }
                        else
                        {
                            Console.WriteLine("\n\nUYARI ! \nListe içerisinde var olan bir değer girin.");
                        }
                        System.Threading.Thread.Sleep(2500);
                        break;
                    case "5":
                        Console.WriteLine("Tüm Değerleri mi silmek istiyorsunuz?: (E/H)");
                        string kullaniciSilCevap = Console.ReadLine();
                        if (kullaniciSilCevap.ToLower() == "e")
                        {
                            degerListesi.Clear();
                            Console.WriteLine("Tüm değerler silindi");
                        }
                        else
                        {
                            Console.Write("Silmek istediğiniz değeri giriniz: ");
                            string kullaniciDegerSilme = Console.ReadLine();
                            if (degerListesi.Contains(kullaniciDegerSilme) == true)
                            {
                                degerListesi.Remove(kullaniciDegerSilme);
                                Console.WriteLine("Silme işlemi başarılı.");
                            }
                            else
                            {
                                Console.WriteLine("\n\nUYARI ! \nSilmek istediğiniz değer listede mevcut değildir.");
                            }
                            System.Threading.Thread.Sleep(2500);
                        }
                        break;
                    default:
                        break;
                }
            } while (kullaniciSecim!="6");
        }
    }
}
