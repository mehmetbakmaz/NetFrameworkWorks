using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S5.D1.DiziNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ogrenciİsimListesi = new string[5];

            ogrenciİsimListesi[0] = "Sercan Yöndem";
            ogrenciİsimListesi[1] = "Cengiz Atilla";
            ogrenciİsimListesi[2] = "Mustafa Sel";
            ogrenciİsimListesi[3] = "Mustafa Seg";
            ogrenciİsimListesi[4] = "Mustafa Ses";

            //Console.WriteLine(ogrenciİsimListesi[2]);

            //foreach (var item in ogrenciİsimListesi)
            //{
            //    Console.WriteLine(item);
            //}

            for (int i = 0; i < ogrenciİsimListesi.Length; i++)
            {
                //string gelenIsim = ogrenciİsimListesi[i];
                //Console.WriteLine(gelenIsim);
                Console.WriteLine(ogrenciİsimListesi[i]);
            }
            Console.ReadLine();
        }
    }
}
