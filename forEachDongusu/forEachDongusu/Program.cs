// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<string> urunler = new List<string>()
{
    "Kalem","Silgi","Kalemtraş","0.5 Uç"
};

//Amaç: her bir ürünü ekranda göstermek:

//for (int i = 0; i < urunler.Count; i++)
//{
//    Console.WriteLine(urunler[i]);
//}

foreach (var urun in urunler)
{
    Console.WriteLine(urun);
    //urunler.Add("test");
}

int[] numbers = { 78, 12, 9, 45 };

int toplam = 0;
foreach (var number in numbers)
{
    toplam += number;
}

double ortalama = toplam / numbers.Length;
Console.WriteLine(ortalama);