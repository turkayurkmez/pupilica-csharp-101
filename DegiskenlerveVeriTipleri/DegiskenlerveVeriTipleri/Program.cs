// See https://aka.ms/new-console-template for more information
int suAnKiYil = DateTime.Now.Year;

Console.WriteLine("Doğum yılınızı 4 haneli olarak giriniz:");
string girilenYil = Console.ReadLine();
int dogumYiliniz = Convert.ToInt32(girilenYil);

int yas = suAnKiYil - dogumYiliniz;
//interpolation:
Console.WriteLine($"{yas} yaşındasınız");

/*
 * pirimitif (primitive) tipler
 * 
 *  Sayısal
 *     -- Tam sayılar
 *         
 *     -- Ondalıklı sayılar
 *  
 *  Sözel
 *  
 *  Mantıksal 
 * 
 * 
 */

byte cayBardagi = 255;
sbyte negatifOlabilenCayBardagi = 127; //-128;

short suBardagi = 32767;
ushort su2 = 65535;

int surahi = 2000000000;
uint surahi2 = 4000000000;

long damacana = 35135146546545646;
ulong x = 0;

byte a = 10;
byte b = 255;

byte total = (byte)(a + b);
Console.WriteLine($"Toplam: {total} ");

checked
{
    byte total2 = (byte)(a + b);
    Console.WriteLine($"Toplam: {total} ");

}

//Ondalıklı sayılar:
double pi = 3.14;
float fPi = 3.14f;
decimal deger = 0.000000000000000000000000000000000000000000000001m;


char sembol = '!';
string kelime = "Pupilica";


bool olurMu = false;

//boxing: kutulamak.
object test = 5;

var isim = "Türkay";
var sayi = 8;
var oran = 1.6;








