// See https://aka.ms/new-console-template for more information
try
{
	Console.WriteLine("Lütfen bir tam sayı giriniz");
	int sayi1 = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Bir sayı daha giriniz");
	int sayi2 = Convert.ToInt32(Console.ReadLine());
	int sonuc = sayi1 / sayi2;
	Console.WriteLine($"Sonuç: {sonuc}");

}
catch (FormatException)
{

    Console.WriteLine("Lütfen sadece TAM sayı giriniz.");
}
catch (DivideByZeroException)
{
	Console.WriteLine("Tam sayılar 0'a bölünemez");
}
catch (Exception hata)
{
    Console.WriteLine($"Bilinmeyen bir hata geldi. Hatanın mesajı: {hata.Message}");
}




Console.WriteLine("Çalışmaya devam edecek....");




