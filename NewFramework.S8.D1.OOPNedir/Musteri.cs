using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFramework.S8.D1.OOPNedir
{
    internal class Musteri
    {
        /*
        TCKimlik Numarası
        İsim
        Soyisim
        Cinsiyet
        */

        //Yapıcı Metot ctor

        public Musteri()
        {
            //TCKimliknumara = "1234567890";
        }
        public Musteri(string _tckimlikno)
        {
            TCKimliknumara = _tckimlikno;
        }
        public Musteri(string _tckimlikno, string _isim)
        {
            TCKimliknumara = _tckimlikno;
            isim = _isim;
        }

        public Musteri(string _tckimlikno, string _isim, string _soyisim)
        {
            TCKimliknumara = _tckimlikno;
            isim = _isim;
            soyisim = _soyisim;
        }
        public string TCKimliknumara;
        public string isim;
        public string soyisim;
        public int cinsiyet; //717770001 bay - 717770002 bayan

        public bool MusteriKontrol()
        {
            bool kontrol = MusteriKontrolDatabese(TCKimliknumara);
            return kontrol;
        }
        private bool MusteriKontrolDatabese(string tckimlikNumarasi)
        {
            //database gidilir müşterinin tckimlik numarasına göre daha önce kayıt edilip edilmediği bilgisi sorgulanır...
            return true;
        }
    }
}
