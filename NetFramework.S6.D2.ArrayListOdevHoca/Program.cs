using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S6.D2.ArrayListOdevHoca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kullaniciSecim=string.Empty;
            ArrayList degerListesi = new ArrayList();
            do
            {
                Console.Clear();
                Console.WriteLine("Menü");
                Console.WriteLine("1 - Değer Ekle");
                Console.WriteLine("2 - Değer Listele");
                Console.WriteLine("3 - Değer Ara");
                Console.WriteLine("4 - Değer Düzenle");
                Console.WriteLine("5 - Değer Sil");
                Console.WriteLine("6 - Uygulama Çıkış");
                Console.Write("Seçiniz: ");

                kullaniciSecim = Console.ReadLine();



                switch (kullaniciSecim)
                {
                    case "1":
                        Console.Write("Lütfen eklemek istediğiniz değeri giriniz: ");
                        string kullaniciDeger = Console.ReadLine();
                        degerListesi.Add(kullaniciDeger);
                        Console.WriteLine("Değeriniz başarıyla eklendi");
                        System.Threading.Thread.Sleep(500);//2 saniye bekletme kodu
                        break;
                    case "2":
                        for (int i = 0; i < degerListesi.Count; i++)
                        {
                            Console.WriteLine(i+1+". Değer= " + degerListesi[i]);
                        }
                        Console.WriteLine("Devam etmek için bir tuşa basınıız.");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Aramak istediğiniz değeri giriniz: ");
                        string kullaniciAramaDeger = Console.ReadLine();
                        bool kontrol = degerListesi.Contains(kullaniciAramaDeger);
                        if (kontrol)
                        {
                            int bulunanIndex = degerListesi.IndexOf(kullaniciAramaDeger);
                            string bulunanDeger = degerListesi[bulunanIndex].ToString();
                            Console.WriteLine("Değeriniz bulundu: Index Sırası: {0} - Değer:{1} ",bulunanIndex,bulunanDeger);
                        }
                        else
                        {
                            Console.WriteLine("Aradığınız kritelerde bir değer bulunamadı.");
                            //eğer aradığı kriterde değer bulamadı ise kullanıcıya bu değer listeye ekleyelim mi olarak sorun eğer kullanıcı E derse listeye ekleyin
                            Console.WriteLine();
                            Console.WriteLine("Bu değeri listeye eklemek istiyor musunuz?(E/H): ");
                            string kullaniciCevap = Console.ReadLine().ToLower();
                            if (kullaniciCevap=="e")
                            {
                                degerListesi.Add(kullaniciAramaDeger);
                            }
                            else if (kullaniciCevap == "h")
                            {
                                Console.WriteLine("Menüye yönlendiriliyorsunuz...");
                                System.Threading.Thread.Sleep(500);
                            }
                            else
                                Console.WriteLine("Lütfen 'e' yada 'h' tuşuna basınız..");
                        }
                        System.Threading.Thread.Sleep(500);
                        break;
                    case "4":
                        Console.WriteLine("Güncellemek istediğiniz değeri giriniz: ");
                        string kullaniciDuzenlenecekDeger = Console.ReadLine();
                        Console.WriteLine("{0} değerini hangi değer ile güncellemek istiyorsunuz",kullaniciDuzenlenecekDeger);
                        string kullaniciYeniDeger = Console.ReadLine();
                        if (degerListesi.Contains(kullaniciDuzenlenecekDeger))
                        {
                            int kullaniciHedefIndex = degerListesi.IndexOf(kullaniciDuzenlenecekDeger);
                            degerListesi[kullaniciHedefIndex] = kullaniciYeniDeger;
                            Console.WriteLine("Değeriniz Güncellendi.");
                        }
                        else
                        {
                            Console.WriteLine("aradığınız değer liste içerisinde bulunamadı.");
                        }
                        System.Threading.Thread.Sleep(500);
                        break;
                    case "5":
                        Console.WriteLine("Tüm Değerleri mi silmek istiyorsunuz?: (E/H)");
                        string kullaniciSilCevap= Console.ReadLine();
                        if (kullaniciSilCevap.ToLower()=="e")
                        {
                            degerListesi.Clear();
                            Console.WriteLine("Tüm değerler silindi");
                        }
                        else
                        {
                            Console.WriteLine("Değer giriniz.");
                            string kullaniciSilDeger = Console.ReadLine();
                            if (degerListesi.Contains(kullaniciSilDeger))
                            {
                                degerListesi.Remove(kullaniciSilDeger);
                                Console.WriteLine("Değeriniz silindi");
                            }
                            else
                            {
                                Console.WriteLine("Değer mevcut değil.");
                            }
                        }
                        System.Threading.Thread.Sleep(500);
                        break;
                    default:
                        break;
                }
            } while (kullaniciSecim!="6");
        }
    }
}
