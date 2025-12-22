using System;
using System.Collections.Generic;
using System.Text;

namespace OOPIntro
{
    class Urun
    {


        public string Ad { get; set; }

        public string Resim { get; set; }

        private decimal fiyat;

        //public void SetFiyat(decimal fiyat)
        //{
        //    if (fiyat > 0)
        //    {
        //        this.fiyat = fiyat;
        //    }
        //    throw new Exception("fiyat negatif olamaz");
        //}

        //public decimal GetFiyat()
        //{
        //    return this.fiyat;
        //}

        public decimal Fiyat
        {
            get { return this.fiyat; }
            set
            {
                if (value > 0)
                {
                    this.fiyat = value;
                }
                throw new ArgumentException("Fiyat negatif olamaz");
            }
        }

        public int Stok { get; set; }

        public bool StoktaVarmi
        {
            get
            {
                return Stok > 0;
            }
        }

        public string Test { private get; set; }

    }
}
