using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S6.D5.SortedListGenelKullanim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //küçükten büyüğe key değerlerine göre sıralar ve key değerleri aynı olmalı string string... int int gibi
            SortedList SortedL = new SortedList();
            SortedL.Add(100, "Yüz");
            SortedL.Add(90,"Doksan");
            SortedL.Add(1, "Bir");
            SortedL.Add(9000, "Dokuzbin");
            //SortedL.Add("A", "B"); varlık değerleri tek koleksiyonda tutamaz. string ve int gibi
        }
    }
}
