// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
 * Amaç 1.  Bilgisayarın tuttuğu 4 haneli (1000,9999) sayıyı bulmak.
 *         
 *         1. Bilgisayar bir sayı tutar
 *         2. Kullanıcı, sayıyı tahmin eder.
 *         3. Tahmini sayı tutulandan büyükse "AŞAĞI" der ve 2. adıma geçer
 *         4.                         küçükse "YUKARI" der ve 2. adıma geçer 
 *         5.                         eşite   "BİLİNDİ" yazar ve biter.
 *         
 */

Random random = new Random();

do
{
    int tutulanSayi = random.Next(100, 1000);
    int denemeSayisi = 0;
    do
    {
        Console.WriteLine("3 basamaklı Sayıyı tahmin edin:");
        int tahmin = Convert.ToInt32(Console.ReadLine());
        denemeSayisi++;
        if (tahmin > tutulanSayi)
        {
            Console.WriteLine("AŞAĞI");

        }
        else if (tahmin < tutulanSayi)
        {
            Console.WriteLine("YUKARI");
        }
        else
        {
            Console.WriteLine($" {denemeSayisi} denemede BİLDİNİZ");
            break;
        }
    } while (true);
    Console.WriteLine("Bir kez daha oynamak ister misniz (E / H)"); 
} while (Console.ReadLine()=="E");

