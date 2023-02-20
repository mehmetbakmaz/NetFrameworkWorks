using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFramework.S7.D3.MetotOdevTekrar
{
    public class Ogrenci
    {
        decimal result = 0;
        public void Acilis()
        {
            Console.Clear();
            Console.WriteLine("***Not Hesaplama Programına Hoşgeldiniz.***\nLütfen Notlarınızı Giriniz");
        }
        public void OgrenciBilgi(string ad,string soyad)
        {
            Console.WriteLine("Ad Soyad: "+ad+" "+soyad);
        }
        public decimal OgrenciNot(decimal not1,decimal not2,decimal not3=45/*not3ün değeri girilmezse 45 otomatik al*/)
        {
            result = (not1 + not2 + not3) / 3;
            Console.WriteLine("Ortalamanız: " + result);
            return result;

        }

    }
}
