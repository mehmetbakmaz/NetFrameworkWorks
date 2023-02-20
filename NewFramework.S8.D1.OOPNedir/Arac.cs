using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFramework.S8.D1.OOPNedir
{
    public class Arac
    {
        public string Marka;
        public string Model;
        public int ModelYil;
        public decimal Km;
        public int YakitTipi;
        public int VitesTipi;
        public decimal AlisFiyat;
        public decimal SatisFiyat;
        public decimal MaxIndirimTutar;
        public decimal Fiyat;

        public Arac()
        {
            Model = "Volkwagen";
        }

        public Arac(string _marka,string _model)
        {
            Marka = _marka;
            Model = _model;
        }

        public Arac(string _marka, string _model, int _modelyil)
        {
            Marka = _marka;
            Model = _model;
            ModelYil = _modelyil;
        }
        public Arac(string _marka, string _model,int _modelyil, decimal _km)
        {
            Marka = _marka;
            Model = _model;
            ModelYil = _modelyil;
            Km= _km;
        }
        //\nKm: {Km}\nYakıt Tipi: {YakitTipi}\nVites Tipi: {VitesTipi}\nSatış Fiyatı: {SatisFiyat}\nİndirimli Satış Fiyatı: {Fiyat}
        public void BilgileriGoruntule()
        {
            Console.WriteLine("Araç Bilgileriniz Aşağıdaki Listelenmiştir...");
            Console.WriteLine($"Marka: {Marka}\nModel: {Model}\nModel Yılı: {ModelYil}");
        }
        public void FiyatAta(decimal _fiyat)
        {
            decimal fiyatHesap = SatisFiyat - MaxIndirimTutar;
            if (_fiyat<fiyatHesap)
            {
                Console.WriteLine("Geçersiz fiyat girişi yaptınız.");
            }
            else
            {
                Fiyat = _fiyat;
                Console.WriteLine("Fiyat Güncellendi.");
            }
        }

    }
}
