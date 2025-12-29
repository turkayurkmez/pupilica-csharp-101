// See https://aka.ms/new-console-template for more information
using FilmKoleksiyonu;

//Console.WriteLine("Hello, World!");
/*
 *  Filmleri bir arada tutan ve çeşitli işlevlere sahip bir uygulama geliştirmek istiyoruz.
 *   İşlevler:
 *     1. Film ekleme
 *     2. Arama
 *     3. Filtreleme (yıla göre, türe göre...)
 *     4. En yüksek puanlı filmi bulma
 *     5. Ortalama puan hesaplama
 *   
 *  uygulama başladığında bir menü gelir. Bu menüye göre kullanıcı seçim yaparak ilerler. 
 *  
 */
//Nesne testi:

//try
//{
//	Film inception = new Film("Inception", "Christopher Nolan", 2010, 7.5, "Bilim Kurgu");
//	Console.WriteLine("Film nesnesi oluşturuldu");
//	Console.WriteLine(inception.ToString());

//	Film film2 = new Film("Test Film", "Test", 2020, 15, "Aksiyon");
//}
//catch (Exception ex)
//{

//	Console.WriteLine(ex.Message);
//}
bool devamEtsinMi = true;
FilmListesi filmListesi = new FilmListesi();
while (devamEtsinMi)
{
    Menu.Goster();
    Console.Write("Seçiminiz: ");
    string secim = Console.ReadLine();


    switch (secim)
    {
        case "1":
            Menu.FilmEkle(filmListesi);
            break;
        case "2":
            Menu.AdaGoreFilmAra(filmListesi);
            break;
        case "3":
            Menu.YilaGoreFilmAra(filmListesi);
            break;
        case "4":
            Menu.TureGoreFilmAra(filmListesi);

            break;
        case "5":
            Menu.TumFilmleriListele(filmListesi);
            break;

        case "6":
            Menu.EnIyiFilm(filmListesi);
            break;
        case "7":
            Menu.OrtalamaPuan(filmListesi);
            break;
        case "8":
            Menu.Cikis();
            devamEtsinMi = false;
            break;


        default:
            break;
    }

    if (devamEtsinMi)
    {
        Console.WriteLine("Devam etmek için bir tuşa basın...");
        Console.ReadKey();
        Console.Clear();
    }
}