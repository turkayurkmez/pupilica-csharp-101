// See https://aka.ms/new-console-template for more information
using OOPIntro;

Console.WriteLine("Hello, World!");


Urun urun2 = new Urun();

urun2.Ad = "Yağmurluk";

Console.WriteLine(urun1.Ad);

//Console.WriteLine("Fiyat giriniz");
//decimal fiyat = Convert.ToDecimal(Console.ReadLine());
//if (fiyat<0)
//{
//    Console.Write("Fiyat negatif olamaz");
//}
//else
//{
//    urun1.Fiyat = fiyat;
//}

//urun1.SetFiyat(fiyat);
//urun1.Fiyat = fiyat;
Urun urun1 = new Urun();
urun1.Ad = "Şemsiye";

urun1.Fiyat = 15;
Console.WriteLine(urun1.Fiyat.ToString())   ;
urun1.Stok = 100;
Console.WriteLine(urun1.Stok);

