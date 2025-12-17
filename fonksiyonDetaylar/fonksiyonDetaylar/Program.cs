namespace fonksiyonDetaylar
{
    internal class Program
    {

        const string Kare = "kare";
        const string Daire = "daire";
        const string Ucgen = "üçgen";
        const string Dikdortgen = "dikdörtgen";

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            double kare = alanHesapla(5, "kare");
            double dikdortgen = alanHesapla(3, 5, "dikdörtgen");

            //alanHesapla()

            Console.WriteLine($"Karenin alanı: {kare}, Dötgenin alanı: {dikdortgen}");

            var kareOpt = opsiyonelAlanHesapla(5);
            var daire = opsiyonelAlanHesapla(10,sekil:Daire);
            var dortgen = opsiyonelAlanHesapla(7, 8, Dikdortgen);
            var ucgen = opsiyonelAlanHesapla(6, 10, Ucgen);

            Console.WriteLine($"Daire:{daire}\nKare:{kareOpt}\nDörtgen:{dortgen}\nÜçgen:{ucgen}");

            int kalanDegeri = 0;

            int sonuc = bolmeIslemi(22, 4, out kalanDegeri);

            Console.WriteLine($"bölme işlemi sonucu: {sonuc}, kalan ise {kalanDegeri}");

            int x = 8;

            birIslem(ref x);

            Console.WriteLine($"main metodunda x değeri: {x}");

            double ortalama = ortalamasiniAl(85, 44, 13, 21, 34, 9, 23);
            Console.WriteLine(ortalama);

            (int fark, int toplam) = ikiIslem(3, 5);

            Console.WriteLine($"Toplam: {toplam}, fark:{fark}");

            var factorial = faktoriyelHesapla(10);

            
            Console.WriteLine(factorial);
            adimlariGoster(10);

        }

        //4 farklı şekil var: Kare, Dikdörtgen, Daire, Üçgen.
        static double alanHesapla(double birim1, string sekil)
        {
            double alan = 0;
            switch (sekil)
            {
                case "kare":
                    alan = Math.Pow(birim1, 2);
                    break;
                case "daire":
                    alan = Math.Pow(birim1, 2) * Math.PI;
                    break;
                default:
                    Console.WriteLine("Yanlış şekil");
                    return 0;
            }

            return alan;
        }

        static double alanHesapla(double birim1, double birim2, string sekil)
        {
            double alan = 0;
            switch (sekil)
            {
                case "üçgen":
                    alan = (birim1 * birim2) / 2;
                    return alan;
                case "dikdörtgen":
                    alan = birim1 * birim2;
                    return alan;
                default:
                    return 0;

            }
        }

        static double alanHesapla(string sekil, double birim1, double birim2)
        {
            return 1.5;
        }

        static double opsiyonelAlanHesapla(double birim1, double? birim2 = null, string sekil = Kare)
        {

            switch (sekil)
            {
                case Kare:
                    return Math.Pow(birim1, 2);
                case Dikdortgen:
                    if (birim2.HasValue)
                    {
                        return birim1 * birim2.Value;
                    }
                    Console.WriteLine("ikinci birimi girmemişsiniz");

                    return 0;
                case Ucgen:
                    if (birim2.HasValue)
                    {
                        return (birim1 * birim2.Value) / 2;
                    }
                    return 0;
                case Daire:
                    return Math.Pow(birim1, 2) * Math.PI;
                default:
                    return 0;

            }
        }

        static int bolmeIslemi(int bolunen, int bolen, out int kalan)
        {
            kalan = bolunen % bolen;
            return bolunen / bolen;
        }

        static void birIslem(ref int sayi)
        {
            sayi *= 2;

            Console.WriteLine($"Burasi birIslem metodu. {sayi}");
        }


        static double ortalamasiniAl(params double[] sayilar)
        {
            double toplam = 0;
            foreach (var sayi in sayilar)
            {
                toplam += sayi;
            }

            return toplam / sayilar.Length;
        }


        static (int, int) ikiIslem(int a, int b)
        {
            return (a - b, a + b);
        }




        static long faktoriyelHesapla(int n)
        {
            if (n == 0 || n==1)
            {
                return 1;
            }

            return n * faktoriyelHesapla(n - 1);
        }

        static void adimlariGoster(int n) {
            Console.WriteLine("\n İÇERİ DOĞRU: ");


            for (int i = n; i >=1; i--)
            {
                string indent = new string(' ', (n-i)*2);
                Console.WriteLine($"{indent}-> {i}! = {i} x {i-1}!");

            }

            Console.WriteLine($"{new string(' ', n*2)} -> 1! DUR!!");

            Console.WriteLine("DIŞA DOĞRU...");

            long sonuc = 1;
            for (int i = 1; i <= n; i++)
            {
                sonuc *= i;
                string indent = new string(' ', (n - i) * 2);
                Console.WriteLine($"{indent} <- {i}! = {sonuc} ");

            }



        }


    }
}
