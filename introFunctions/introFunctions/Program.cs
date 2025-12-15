namespace introFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UyariMesaji("Bu bir uyarıdır!");

           
           
            int toplam = topla(5, 10);


            BilgiMesaji(toplam.ToString());

            /*
             * Şifre en az karakter olmalı
             * büyük harf olmalı.
             * küçük harf olmalı
             * ve sembol olmalı.
             * 
             */

            string harf = ((char)(65)).ToString(); 
                        Console.WriteLine(harf);
            int sayi = (int)'A';
            Console.WriteLine(sayi);
            //Türkay
            Console.WriteLine(sifrele("Türkay"));
            //Uvslmz
        }

        static void UyariMesaji(string mesaj)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mesaj);
            Console.ForegroundColor = ConsoleColor.White;
        }


        static void BilgiMesaji(string mesaj)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(mesaj);
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// İki tam sayıyı toplar.
        /// </summary>
        /// <param name="a">Birinci</param>
        /// <param name="b">İkinci</param>
        /// <returns></returns>
        static int topla(int a, int b)
        {
            return a + b; 
        }

        static int asciiKodaCevir(char character)
        {
            int sayi = (int)character;
            return sayi;
        }

        static string harfeCevir(int ascii)
        {
            string harf = ((char)ascii).ToString();
            return harf;
        }

        static string sifrele(string kelime)
        {
            string sifreliKelime = string.Empty;
            foreach (var harf in kelime)
            {
                int ascii = asciiKodaCevir(harf);
                ascii++;
                string yeniHarf = harfeCevir(ascii);
                sifreliKelime+= yeniHarf;
            }

            return sifreliKelime;

        }

    }
}
