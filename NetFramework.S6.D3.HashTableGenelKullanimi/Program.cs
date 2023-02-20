using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S6.D3.HashTableGenelKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable H1 = new Hashtable();
            #region Yeni değer ekleme

            H1.Add("Car","Araba");
            H1.Add("House", "Ev");

            H1.Add("Cars", "Araba");
            //H1.Add("Cars", "Arabalar"); key değeri benzersiz olmak zorundadır.

            #endregion

            #region Yardımcı metotlar
            bool kontrol = H1.Contains("House");
            bool kontrol2 = H1.Contains("Door");

            bool kontrol3 = H1.ContainsKey("House");
            bool kontrol4 = H1.ContainsValue("Araba");

            H1["House"] = "Villa"; //keyi düzenleme

            H1.Remove("Cars");
            int koleksiyonIcindekiToplamDeger= H1.Count;
            H1.Clear();


            #endregion
        }
    }
}
