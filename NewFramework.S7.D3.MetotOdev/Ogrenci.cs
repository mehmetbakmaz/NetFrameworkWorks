using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFramework.S7.D3.MetotOdev
{
    public class Ogrenci
    {
        //kullanıcı adı soyadı 3 farklı ders notu öğrencipuanhesapla
        //1.not 50 2.not 50 3.not 40
        //50+50+40 = 140 
        // 140 /3 = 47 -- 45 den yukarı geçti, 45 den aşağı kaldı
        public void Acilis()
        {
            Console.Clear();
            Console.WriteLine("**Öğrenci puan hesaplama sistemine hoşgeldiniz.**");
        }

        public void OgrenciBilgi(string ad, string soyad)
        {

        }

        public decimal NotToplam(decimal not1, decimal not2, decimal not3)
        {
            decimal sonuc = not1 + not2 + not3;
            return sonuc;
        }

        public decimal Averages(decimal sonuc)
        {
            decimal ortalama = sonuc / 3;
            ortalama = Math.Round(ortalama, 2);
            return ortalama;
        }

        public void sonucEkranaYaz(decimal not1, decimal not2, decimal not3, decimal sonuc, decimal ortalama,string ad, string soyad)
        {
            Console.WriteLine("Sayın: "+ad+" "+soyad+ "\n1. Notunuz: "+not1+"\n2. Notunuz: "+not2+"\n3.Notunuz: "+not3+"\nSonuç: "+sonuc+"\nOrtalamanız: "+ortalama);
        }
    }
}
