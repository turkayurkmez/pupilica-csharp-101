using System;
using System.Collections.Generic;
using System.Text;

namespace FilmKoleksiyonu
{
    public class Film
    {
        //Her filmin ....... vardır
        public string Ad { get; set; }
        public string Yonetmen { get; set; }

        public int Yil { get; set; }
        public double Puan { get; set; }
        public string Tur { get; set; }

        public List<string> Oyuncular { get; set; }

        public Film(string ad, string yonetmen, int yil, double puan, string tur)
        {
            //neleri denetlemeliyim?
            //1. puan 0 ile 10 arasında olmalı.
            //2. yil 1800 ile gününümüzden 5 yıl sonrasını kapsamalı
            //3. film adı boş olamaz
            if (puan < 0 || puan >10 )
            {
                throw new ArgumentException("Puan değeri 0 ile 10 arasında olmalı");
            }

            if (yil < 1800 || yil > DateTime.Now.Year + 5)
            {
                throw new ArgumentException($"Yıl, 1800 ile {DateTime.Now.Year + 5} arasında olmalı");
            }

            ArgumentException.ThrowIfNullOrEmpty("ad");

            Ad = ad;
            Yonetmen = yonetmen;
            Yil = yil;
            Puan = puan;
            Tur = tur;
            Oyuncular = new List<string>();

        }

        //Bir filmin ekranda nasıl gösterileceği, Film nesnesi tarafından belirlensin.

        public override string ToString()
        {
            string info =  $" {Ad} {Yil} - Yönetmen: {Yonetmen} | Tür: {Tur} | {Puan}/10 | Oyuncular: " ;

            string oyuncular = string.Join(",", Oyuncular);

            info += oyuncular;

            return info;

        }
    }
}
