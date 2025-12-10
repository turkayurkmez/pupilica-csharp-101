// See https://aka.ms/new-console-template for more information
Console.WriteLine("Lütfen bir sayı giriniz:");
/*
 * Bir sayının kaç basamaklı olduğunu matematiksel olarak nasıl bulurum?
 * 1595 - 159 - 15 - 1 - 0
 * 
 */

int sayi = Convert.ToInt32(Console.ReadLine());

int bolmeSayisi = 0;
while (sayi != 0 )
{
    sayi /= 10;
    bolmeSayisi++;
}

Console.WriteLine($"Girdiğiniz sayı {bolmeSayisi} basamaklı!");

Console.WriteLine("Alışveriş sepeti sistemi");
Console.WriteLine("Sepete ekleme işini bitirmek için 0 girin");

double toplamTutar = 0;
int sepettekiUrunSayisi = 0;

while (true)
{
    Console.WriteLine($"{sepettekiUrunSayisi + 1}. Ürünün fiyatı:");
    double fiyat = Convert.ToDouble(Console.ReadLine());

    if (fiyat == 0)
    {
        Console.WriteLine("Alışveriş tamamlandı");
        break;
    }

    if (fiyat<0)
    {
        Console.WriteLine("Negatif değer girdiniz. Tekrar deneyin.");
        continue;
    }

    toplamTutar += fiyat;
    sepettekiUrunSayisi++;
}

Console.WriteLine($"Toplam ürün fiyatı: {toplamTutar} ve seppeteki ürün sayısı: {sepettekiUrunSayisi}  ");

