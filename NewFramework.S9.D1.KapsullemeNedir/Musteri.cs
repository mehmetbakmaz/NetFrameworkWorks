using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFramework.S9.D1.KapsullemeNedir
{
    internal class Musteri
    {


        public Musteri()
        {
            this.id = IDUret();
        }
         private string _tckimlikno;
        public string TCkimlikno
        {
            get
            { return _tckimlikno.Substring(0,3); }
            set
            {
                if (value.Length == 11)
                {
                    bool bayrak = false;
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool karakterKontrol = char.IsNumber(value[i]);
                        if (karakterKontrol)
                        {

                        }
                        else
                        {
                            bayrak = true;
                            break;
                        }
                    }
                    if (bayrak) { Console.WriteLine("Değer değiştirildi"); }
                    else
                    {
                        this._tckimlikno = value;
                    }
                }
                else
                {
                    Console.WriteLine("Tc kimlik no 11 haneden az veya fazla olamaz");
                }
            }

        }   
        //class field=
        int id;
        public int ID
        {
            get { return this.id; }
            set 
            {
                this.id = value;
            }
        }
        public string isim;
        public string surname;

        

        private string emailadres;

        //class - Property
        public string Emailadres 
        
        {
            //get;//database veya farklı bir veri kaynağı... Classı çağıran programcıya datayı gösterdiğimiz bölüm
            //set;//dış dünyadan alınan datanın private olarak saklanan field içerisine değer atandığı kısım
            set { emailadres = value; }
            get { return this.emailadres; }
        }

        private int IDUret()
        
        {
        Random random= new Random();
            return random.Next(10000,90000);
        }




       





        }
    }

