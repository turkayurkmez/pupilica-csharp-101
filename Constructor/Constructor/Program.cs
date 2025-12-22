// See https://aka.ms/new-console-template for more information
using Constructor;

Console.WriteLine("Hello, World!");

RaporOlusturucu raporOlusturucu = new RaporOlusturucu("Excel.xlsx");

Console.WriteLine(raporOlusturucu.RaporCiktisi);
raporOlusturucu.RaporCiktisi = "HTML";


Kullanici k1 = new Kullanici() { KullaniciAdi = "turkay", Email = "turkay@urkmez.com", Adres = "Ankara", Telefon = "0555 555 555", Sifre = "123" };


