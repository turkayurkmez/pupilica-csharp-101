using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Oyuncu
    {
        public string Nick { get; set; }
        public string Ad { get; set; }

        public Silah OyuncununSilahi { get; set; }

        public void Atak()
        {
            OyuncununSilahi.Saldir();
        }

        public void SagClick()
        {
            OyuncununSilahi.PozisyonDegistir();
        }

        public int Hiz { get; set; } = 100;
        public void Kos()
        {
            Hiz = Hiz - (OyuncununSilahi.Agirlik * 20) / 100;
        }
    }


}
