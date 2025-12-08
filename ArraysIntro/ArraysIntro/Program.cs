// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Array içinde olması gereken tüm elemanları biliyorsam:
string[] gunler = new string[] {  "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };

//Array içinde kaç eleman olması gerektiğini biliyorum. Elemanları bilmiyorum:
int[] sayilar = new int[6];

Console.WriteLine(gunler[0]);
Console.WriteLine(gunler[6]);


Console.WriteLine(gunler.Length);
//kaç elemanlı olursa olsun son değeri ekrana yazmak istiyoruz.
Console.WriteLine(gunler[gunler.Length - 1]);
//run-time error:
//Console.WriteLine(gunler[7]);

sayilar[0] = 45;
sayilar[1] = 29;
sayilar[2] = 17;

/*
 * Kullanıcının  girdiği iki basamaklı bir sayıyı okunuşuna çeviren uygulama:
 *   42 -> Kırk iki
 */

//36
//20
//06

string[] birler = {"", "bir","iki","üç","dört","beş","altı","yedi","sekiz","dokuz" };
string[] onlar = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };

Console.WriteLine("Lütfen iki basamaklı bir sayı girin:");
//96
//9
//6
int sayi = Convert.ToInt32(Console.ReadLine());
int onlarBasamagindakiDeger = sayi / 10;
int birlerBasmagindakiDeger = sayi % 10;

Console.WriteLine(onlar[onlarBasamagindakiDeger] + " " + birler[birlerBasmagindakiDeger]);


int index = 0;

islem: if (index < 7)
{
    Console.WriteLine(gunler[index]);
    index = index + 1;
    goto islem;
}

for (int i = 0; i < 7; i=i+1)
{
    Console.WriteLine(gunler[i]);
}
//Console.WriteLine(gunler[0]);
//Console.WriteLine(gunler[1]);
//Console.WriteLine(gunler[2]);
//Console.WriteLine(gunler[3]);
//Console.WriteLine(gunler[4]);
//Console.WriteLine(gunler[5]);
//Console.WriteLine(gunler[6]);

for (int i = 1; i < 100; i++)
{   
    int onlarBasamagindakiDeger1 = i / 10;
    int birlerBasmagindakiDeger1 = i % 10;

    Console.WriteLine(onlar[onlarBasamagindakiDeger1] + " " + birler[birlerBasmagindakiDeger1]);
}








