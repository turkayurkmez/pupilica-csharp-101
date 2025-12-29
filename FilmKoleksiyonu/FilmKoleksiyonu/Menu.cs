using System;
using System.Collections.Generic;
using System.Text;

namespace FilmKoleksiyonu
{
    public static class Menu
    {
        public static void Goster()
        {
            Console.WriteLine("1. Film Ekle");
            Console.WriteLine("2. Ada göre film ara");
            Console.WriteLine("3. Yıla göre film ara");
            Console.WriteLine("4. Türe göre film ara");
            Console.WriteLine("5. Tüm filmleri listele");
            Console.WriteLine("6. En yüksek puanlı film");
            Console.WriteLine("7. Ortalama Puan");
            Console.WriteLine("8. Çıkış");




        }

        public static void FilmEkle(FilmListesi liste)
        {
            try
            {
                Console.Write("Film Adı: ");
                string ad = Console.ReadLine();

                Console.Write("Yönetmen: ");
                string yonetmen = Console.ReadLine();

                Console.Write("Yıl: ");
                int yil = Convert.ToInt32(Console.ReadLine());

                Console.Write("Puan (0-10): ");
                double puan = Convert.ToDouble(Console.ReadLine());

                Console.Write("Tür: ");
                var tur = Console.ReadLine();

                Film film = new Film(ad, yonetmen, yil, puan, tur);
                liste.Ekle(film);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public static void AdaGoreFilmAra(FilmListesi liste)
        {
            Console.WriteLine("Aranacak ismi girin:");
            string ad = Console.ReadLine();

            var filmler = liste.AdaGoreAra(ad);

            if (filmler.Count!=0)
            {
                filmleriListele(filmler);
            }
        }

        public static void YilaGoreFilmAra(FilmListesi liste)
        {
            Console.WriteLine("Yıl giriniz:");
            int yil = Convert.ToInt32( Console.ReadLine());

            var filmler = liste.YilaGoreAra(yil);

            if (filmler.Count != 0)
            {
                filmleriListele(filmler);
            }
        }


        public static void TureGoreFilmAra(FilmListesi liste)
        {
            Console.WriteLine("Tür giriniz:");
            var tur = Console.ReadLine();

            var filmler = liste.TureGoreAra(tur);

            if (filmler.Count != 0)
            {
                filmleriListele(filmler);
            }
        }


        public static void TumFilmleriListele(FilmListesi liste)
        {
            var filmler = liste.TumFilmleriGetir();
            filmleriListele(filmler);
        }

        public static void EnIyiFilm(FilmListesi filmListesi)
        {
            var film = filmListesi.EnYuksekPuanliFilmiBul();

            Console.WriteLine($"En yüksek puanlı film: {film.ToString()}");
        }

        public static void OrtalamaPuan(FilmListesi filmListesi)
        {
            var ortalama = filmListesi.OrtalamaPuan();
            Console.WriteLine($"Ortalama puan: {ortalama}");

        }

        public static void Cikis()
        {
            Console.WriteLine("Uygulamadan çıkılıyor...");

        }

        private static void filmleriListele(List<Film> filmler)
        {
            Console.WriteLine("------------------ Filmler ------------------");
            foreach (var item in filmler)
            {
                Console.WriteLine(item);    
            }
        }
    }
}
