using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFramework.S9.D1.KapsullemeNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Musteri m1 = new Musteri();
            //m1.id = 1;
            m1.isim = "Mehmet";
            m1.surname = "Bakmaz";
            /*
             Field içerisine değer ataması yapılamasın ama değer okunamasın
            field içerisine değer ataması yapılsın ama değer okunamasın
            field içerisine değer ataması yapılsın ama ilk 4 hanesi okunsun
            Field içerisine değer atamsı ve okuma işlemleri yapılsın ama bu iki işlem de bizim belirlediğimiz
            bir süreçten sgesin veri daha sonra gösterilsin
            //Class
            //field 
            //Property
            //Get&Set   
             
             */
            //m1.emailadres = "mehmet@gmail.com";
            m1.Emailadres = "mehmetbakmaz6@gmail.com";
            Console.WriteLine(m1.Emailadres);
            //1. değer ataması yapılamasın ama değer okunabilsin
            m1.ID = 10;
            Console.WriteLine("Musteri ıd degeri="+m1.ID.ToString());
            m1.TCkimlikno = "12345678910";
            string TC = m1.TCkimlikno;
            Console.WriteLine(TC);
            
        }
    }
}
