// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string isim = "pubilica";

var buyukHarfli = isim.ToUpper();
                

Console.WriteLine(buyukHarfli);

if (isim.StartsWith('p'))
{
    Console.WriteLine("Küçük p ile başlıyor!");
}

var index = isim.IndexOf('x');
Console.WriteLine(index);

//türkay ürkmez: Türkay Ürkmez

Console.WriteLine("Adınızı giriniz");
string ad = Console.ReadLine();

var format = baslikFormatinaDonustur(ad);


Console.WriteLine(format);
Console.WriteLine(baslikFormatinaDonustur("ali cengiz"));
Console.WriteLine(baslikFormatinaDonustur("dürdane nebakıyon"));

//var kelimeler = ad.Split(' ');
//List<string> baslikBicimi = new List<string>();
//foreach (var kelime in kelimeler)
//{
//    //T ürkay
//    string ilkHarf = kelime.Substring(0, 1).ToUpper();
//    string digerleri = kelime.Substring(1).ToLower();

//    string baslikFormati = $"{ilkHarf}{digerleri}";
//    baslikBicimi.Add(baslikFormati);

//}

//string baslikFormatindaIsim = string.Join(" ", baslikBicimi);
//Console.WriteLine(baslikFormatindaIsim);
string baslikFormatinaDonustur(string ifade)
{
    var kelimeler = ifade.Split(' ');
    List<string> baslikBicimi = new List<string>();
    foreach (var kelime in kelimeler)
    {
        //T ürkay
        string ilkHarf = kelime.Substring(0, 1).ToUpper();
        string digerleri = kelime.Substring(1).ToLower();

        string baslikFormati = $"{ilkHarf}{digerleri}";
        baslikBicimi.Add(baslikFormati);

    }
    string baslikFormatindaIsim = string.Join(" ", baslikBicimi);
    return baslikFormatindaIsim;
}