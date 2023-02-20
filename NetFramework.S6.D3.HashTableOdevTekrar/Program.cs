using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NetFramework.S6.D3.HashTableOdevTekrar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable sozlukVeriTabani = new Hashtable();
            do
            {
                Console.Clear();
                Console.Write("Eklemek istediğiniz Değeri Girin.\n ENG: ");
                string kullaniciİngilizce=Console.ReadLine();
                if (sozlukVeriTabani.Contains(kullaniciİngilizce) == true)
                {
                    Console.WriteLine("Lütfen listede olmayan bir değer girin.");
                }
                else
                {
                    Console.Write("Eklemek istediğiniz Değeri Girin.\n TR: ");
                    string kullaniciTurkce = Console.ReadLine();
                    sozlukVeriTabani.Add(kullaniciİngilizce, kullaniciTurkce);
                    Console.WriteLine("Ekleme işlemi başarılı.");
                }
                Console.WriteLine("Yeni değer eklemek istiyor musunuz (E/H)");
            } while (Console.ReadLine().ToUpper() != "H");

            foreach (var item in sozlukVeriTabani.Keys)
            {
                Console.WriteLine($"ENG = {item} TR = {sozlukVeriTabani[item]}");
            }

            Console.WriteLine();

            foreach (DictionaryEntry item in sozlukVeriTabani)
            {
                Console.WriteLine($"ENG = {item.Key} TR = {item.Value}");
            }
            Console.ReadLine();
        }
    }
}
10-7-4-1-1-2  -2 