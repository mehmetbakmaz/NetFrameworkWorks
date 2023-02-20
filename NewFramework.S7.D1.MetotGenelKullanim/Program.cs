using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFramework.S7.D1.MetotGenelKullanim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Selamla();
            Ogrenci O1 = new Ogrenci();
            //O1.selamlaOgrenci();
            O1.OgrenciMetot2();
            Console.ReadLine();
        }
        static void Selamla()
        {
            Console.WriteLine("Merbaba");
        }
    }
}
