﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFramework.S7.D4.RefOutKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ref ve Out anahtar sözcüklerinde eski .net framework versiyonlarında 1 fark vardı.

            //int sayi1 = 0;
            //degerAta(ref sayi1);
            topla(5,9,20,45,22,12,11,56);
            Console.Read();
        }

        static void degerAta(ref int gelenDeger)
        {
            gelenDeger = 10;
        }
        static void topla(params int[] sayilar)
        {
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            Console.WriteLine("Toplam: "+toplam);
        }

    }
}
