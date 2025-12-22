using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    class RaporOlusturucu
    {
        public string ExcelDosyaYolu { get; set; }
        public string RaporCiktisi { get; set; }



        public RaporOlusturucu(string excelDosyaYolu)
        {
            //1. Excel dosya yolu boş olamaz!.
            ArgumentNullException.ThrowIfNullOrEmpty(excelDosyaYolu);
            //2. Dosya yoksa:


            //3. format hatası
            kontrolEt(excelDosyaYolu);

            RaporCiktisi = "PDF";
            ExcelDosyaYolu = excelDosyaYolu;


        }

        void kontrolEt(string excelDosyaYolu)
        {
            dosyaKontrol(excelDosyaYolu);
            formatiDenetle(excelDosyaYolu);
        }
        void dosyaKontrol(string excelDosyaYolu)
        {
            if (!File.Exists(excelDosyaYolu))
            {
                throw new FileNotFoundException(excelDosyaYolu);
            }
        }

        void formatKontrol(string excelDosyaYolu)
        {
            //3. format hatası
            if (!formatiDenetle(excelDosyaYolu))
            {
                throw new Exception("Hatalı dosya formatı");
            }
        }

        bool formatiDenetle(string excelDosyaYolu)
        {
            return true;
        }

    }
}
