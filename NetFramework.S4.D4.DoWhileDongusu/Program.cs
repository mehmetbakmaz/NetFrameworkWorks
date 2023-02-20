using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S4.D4.DoWhileDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{

            //}

            do
            {
                Console.WriteLine("Merhaba Do While");
            } while (1==2);

            //do while döngülerinde ki en temel fark, şartları ne olursa olsun 1 kere kesin çalışır.
            Console.ReadLine();
        }
    }
}
