using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFramework.S8.D1.OOPNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Müşteri Classı
            //Musteri M1 = new Musteri("122544013254","Murat");
            //M1.TCKimliknumara = "12254401352";
            //M1.isim = "Cengiz";
            //M1.soyisim = "Atilla";
            //M1.cinsiyet = 717770001;

            //Musteri M2 = M1;
            //M2.isim = "Murat";
            //M1.TCKimliknumara = "12254401325";

            //bool musteriKontrol = M1.MusteriKontrol();

            ////M2 = null;
            ////M1 = null;

            ////string isim = M2.isim;
            #endregion

            #region Araç Classı
            //Araç Classı
            Arac A1 = new Arac("Volkswagen","Passat", 2020, 55550);
            A1.Marka = "Mercedes Benz";
            A1.Model = "C-180";
            A1.ModelYil = 2022;
            A1.AlisFiyat = 28000;
            A1.SatisFiyat = 32000;
            A1.MaxIndirimTutar = 1500;
            // Kapsülleme konusu... A1.Fiyat = A1.SatisFiyat - A1.MaxIndirimTutar;
            A1.FiyatAta(30000);

            A1.BilgileriGoruntule();
            Console.ReadLine();
            #endregion
        }
    }
}
