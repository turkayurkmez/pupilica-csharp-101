// See https://aka.ms/new-console-template for more information
Console.WriteLine("Lütfen bir sayı giriniz:");
int girilenSayi = Convert.ToInt32(Console.ReadLine());

string mesaj = "";
if (girilenSayi % 2 == 0)
{
    //Console.WriteLine("Çift");
    mesaj = "Çift";
}
else
{
    //Console.WriteLine("Tek");
    mesaj = "Tek";
}

Console.WriteLine(mesaj);

string alternatifMesaj = girilenSayi % 2 == 0 ? "Çift" : "Tek"; //ternary operatör (? : )
Console.WriteLine(alternatifMesaj);





