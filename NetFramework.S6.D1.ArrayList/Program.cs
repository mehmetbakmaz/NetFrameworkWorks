using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NetFramework.S6.D1.ArrayListGenelKullanim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Capacity = 0;
            int Count = 0;

            string[] isimler = new string[10];

            ArrayList a1 = new ArrayList();

            #region Tek Değer Ekleme
            a1.Add("Sercan Yöndem");
            a1.Add(100);
            #endregion

            #region Birden fazla değer ekleme
            ArrayList a2 = new ArrayList();
            a2.Add("yakup");
            a2.Add("merve");
            a2.Add("utkan");
            a1.AddRange(a2);//birden fazla değer ekleme
            #endregion

            #region capacity & count incele
            Capacity = a1.Capacity;
            Count = a1.Count;
            #endregion

            #region koleksiyon içindeki değere ulaşmak
            object o1 = a1[3];
            string s1 = a1[3].ToString();
            int i2 = (int)a1[1];

            a1[3] = "Hamza Atilla";
            #endregion

            #region
            // DİZİNİN MEVCUT ELEMANLARINI TERS OLARAK SIRALAMA
            a1.Reverse();

            // A-Z SIRALAMA
            a1.Remove(100); // string olduğu için inti sıralayamıyor bundan dolayı silindi
            a1.Sort();
            #endregion

            #region Koleksiyonlar yardımcı komutları(methot)

            if (a1.Contains("yakup"))
            {
                int IndexDegeri = a1.IndexOf("yakup"); // a1 koleksiyonu içerisinde "yakup" u ara yakupun indexini değişkene ata
                a1.RemoveAt(3);
            }

            bool Kontrol1 = a1.Contains("utkan");//ilgili değişken içerisinde değerin olup olmadığına bakar. True/False
            bool Kontrol2 = a1.Contains(900);

            object[] d1 = a1.ToArray(); //kopyasını diziye aktardı
            a1.Clear();
            a1.TrimToSize();//ilgili koleksiyonun değerlerini sıfırla capacity=4 olması gibi

            #endregion

            #region ArrayList koleksiyonu içerisindeki değeri silme
            a1.RemoveAt(3); //3.indexi siler
            a1.RemoveRange(1, 2);//1. indexden silmeye başla 2 tane sil => 2. ve 3. indexi siler
            a1.Remove("Hamza Atilla");
            #endregion

            #region 10 elemanlı (string) ArrayList içinde değerleri Z-A olacak şekilde sıralayın. [ÖDEV]

            ArrayList a4 = new ArrayList();
            a4.Add("Cengiz Atilla");
            a4.Add("Ahmet Çalık");
            a4.Add("Sezer Yöndem");
            a4.Add("Sercan Yöndem");
            a4.Add("Hasancan Yöndem");
            //sort ile a-z sıralayıp tekrar tersine çevirdik böylece z-a sıralanmış oldu.
            a4.Sort();
            a4.Reverse();

            #endregion
            Console.Read();
        }
    }
}
