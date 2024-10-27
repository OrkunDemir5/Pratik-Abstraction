using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_Abstraction
{
    // Abstract Calisan sınıfı
    abstract class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Departman { get; set; }

        // Abstract metod tanımı (her pozisyon bu metodu kendi göreviyle dolduracak)
        public abstract void Gorev();
    }

    // YazilimGelistirici sınıfı, Calisan'dan miras alır
    class YazilimGelistirici : Calisan
    {
        // Yazılım geliştirici için görev
        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad}, Yazılım Geliştirici olarak çalışıyorum.");
        }
    }

    // ProjeYoneticisi sınıfı, Calisan'dan miras alır
    class ProjeYoneticisi : Calisan
    {
        // Proje yöneticisi için görev
        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad}, Proje yöneticisi olarak çalışıyorum.");
        }
    }

    // SatisTemsilcisi sınıfı, Calisan'dan miras alır
    class SatisTemsilcisi : Calisan
    {
        // Satış temsilcisi için görev
        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad}, Satış temsilcisi olarak çalışıyorum.");
        }
    }
}
