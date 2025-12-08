// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");
string[] urunler = new string[1];

//Ctrl + K + C
//urunler[0] = "Masa";
//Array.Resize(ref urunler, 2);
//urunler[1] = "Sandalye";

ArrayList calisanlar = new ArrayList();
calisanlar.Add("Türkay");
calisanlar.Add("Yasemin");

Console.WriteLine(calisanlar[0]);
Console.WriteLine(calisanlar[calisanlar.Count - 1]);

calisanlar.Add("test");
string calisan = (string)calisanlar[2];
Console.WriteLine(calisan);
//boxing:
calisanlar.Add(7500);
//unboxing:
//string deger = (string)calisanlar[3];
//Console.WriteLine(deger);

List<string> ogrenciler = new List<string>();
ogrenciler.Add("Doğaç");
var ogrenciAdi = ogrenciler[0];

ogrenciler.Add("Elnur");


ArrayList liste = new ArrayList();
liste.Add(true);
liste.Add(1.14);
liste.Add(DateTime.Now);

//List<string> meyveler = new List<string>();
//meyveler.Add("Elma");
//meyveler.Add(false);

bool yasiyorum = true;
int yil = 20;
while (yasiyorum)
{
    yil += 1;
    Console.WriteLine($" {yil} yaşındayım ve Seni Seviyorum");

    if (yil == 120)
    {
        yasiyorum = false;
    }
    
}

//Kullanıcı, menü için yemek girsin. Tamamladığında "Bitti" anlamına gelen bir karakter girsin.

List<string> yemekler = new List<string>();

bool girisYapıyorMu = true;

while (girisYapıyorMu)
{
    Console.WriteLine("Akşamki menü için yemek adını girin. Bittiyse \"TAMAM\" yazın");
    string yemekAdi = Console.ReadLine();
    if (yemekAdi == "TAMAM")
    {
        girisYapıyorMu = false;
    }
    else
    {
        yemekler.Add(yemekAdi);
    }
      

}

Console.WriteLine($"Menüde toplam {yemekler.Count} adet yemek var");



