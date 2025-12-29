using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace FilmKoleksiyonu
{
    public class FilmListesi
    {
        /*
         * Bu nesne oluştuğunda, varsayılan olarak birkaç film koleksiyonda olsun.
         */
        private List<Film> filmler = new List<Film>();

        /*
       1. Film ekleme
 *     2. Arama
 *     3. Filtreleme (yıla göre, türe göre...)
 *     4. En yüksek puanlı filmi bulma
 *     5. Ortalama puan hesaplama
         */

        public FilmListesi()
        {
            varsayilanFilmleriEkle();
        }

        private void varsayilanFilmleriEkle()
        {
            try
            {
                filmler.Add(new Film("Matrix", "Wachowski Kardeşler", 1999, 9.4, "Bilim Kurgu"));
                filmler.Add(new Film("Fargo", "Joel Coen", 1997, 8, "Karanlık Komedi"));
                filmler.Add(new Film("Pulp Fiction", "Quentin Tarantino", 1994, 8, "Suç-Komedi"));
                filmler.Add(new Film("Interstellar", "Christopher Nolan", 2014, 8.2, "Bilim Kurgu"));
                filmler.Add(new Film("The Contact", "Robert Zemeckis", 1997, 8.6, "Bilim Kurgu"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }
        // 1. Film ekleme
        public void Ekle(Film film)
        {
            //1. film nesnesi boş olamaz!!!
            ArgumentNullException.ThrowIfNull(film);

            filmler.Add(film);

            Console.WriteLine($"{film.Ad} isimli film başarıyla eklendi");

        }

        //  2. Arama

        public List<Film> AdaGoreAra(string filmAdi)
        {
            //1. liste boşsa aramaya gerek yok!
            listeKontrol();

            List<Film> bulunanFilmler = new List<Film>();

            foreach (var film in filmler)
            {
                if (film.Ad.ToLower() == filmAdi.ToLower())
                {
                    bulunanFilmler.Add(film);
                }
            }

            return bulunanFilmler;
        }

        private void listeKontrol()
        {
            if (filmler.Count == 0)
            {
                throw new InvalidOperationException("filmler koleksiyonu boş!");
            }
        }

        public List<Film> YilaGoreAra(int yil)
        {
            listeKontrol();
            List<Film> bulunanFilmler = new List<Film>();

            foreach (var film in filmler)
            {
                if (film.Yil== yil)
                {
                    bulunanFilmler.Add(film);
                }
            }

            return bulunanFilmler;
        }

        public List<Film> TureGoreAra(string tur)
        {
            listeKontrol();
            List<Film> bulunanFilmler = new List<Film>();

            foreach (var film in filmler)
            {
                if (film.Tur.ToLower() == tur.ToLower())
                {
                    bulunanFilmler.Add(film);
                }
            }

            return bulunanFilmler;
        }

        public Film EnYuksekPuanliFilmiBul()
        {
            listeKontrol();

            Film enIyiFilm = filmler[0];
            foreach (var film in filmler)
            {
                if (film.Puan > enIyiFilm.Puan)
                {
                    enIyiFilm = film;
                }
            }

            return enIyiFilm;

        }

        //Ortalama puan hesaplama

        public double OrtalamaPuan()
        {
            listeKontrol();

            double toplam = 0;
            foreach (var film in filmler)
            {
                toplam += film.Puan;
            }

            return toplam / filmler.Count;
        }

        public List<Film> TumFilmleriGetir()
        {
            listeKontrol();
            return filmler;
        }

    }
}
