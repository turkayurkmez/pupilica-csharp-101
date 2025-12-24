using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Silah
    {
        public int Hasar { get; set; }
        public int Agirlik { get; set; }

        public string Ad { get; set; }
        public void Saldir()
        {
            Console.WriteLine($"{Ad} ile {Hasar} hasar verildi");
        }

        public virtual void PozisyonDegistir()
        {
            Console.WriteLine("Bıçak dik konuma geldi...");
        }

        

    }

    public class AtesliSilah  : Silah
    {
        public int MermiSayisi { get; set; }
        public int MaksimumMermi { get; set; }

    }

    public class Tabanca : AtesliSilah
    {
        public bool SusturucuVarMi { get; set; }

    }

    public class DesertEagle : Tabanca
    {
        public DesertEagle()
        {
            Hasar = 49;
            Agirlik = 10;
            Ad = "Desert Eagle";
            MermiSayisi = 7;
            MaksimumMermi = 70;

        }
        public void Cevir()
        {
            Console.WriteLine("Silah çevriliyor");
        }

        public override void PozisyonDegistir()
        {
            Console.WriteLine( $"{Ad} silahına susturucu takıldı");
        }
    }

    public class Tufek : AtesliSilah
    {
        public bool YakinlastiriliyorMu { get; set; }
    }

    public class Ak47 : Tufek
    {
        public bool OtomatikMod { get; set; }
        public Ak47()
        {
            Ad = "AK47";
            MermiSayisi = 30;
            MaksimumMermi = 100;
            Hasar = 34;

        }
        public override void PozisyonDegistir()
        {
            Console.WriteLine("AK47 ile zoom yapıldı");
        }
    }
}
