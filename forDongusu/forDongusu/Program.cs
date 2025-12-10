// See https://aka.ms/new-console-template for more information

/*
 * Mevcut sayısı belirli olan bir sınıfta, tüm öğrencilerin adlarını ve notlarını almak istiyoruz.
 * 
 * Her öğrencinin notunu girdikten sonra:
 * 
 * 1. En yüksek not.
 * 2. En düşük not.
 * 3. En yüksek notu kim aldı?
 * 4. End düşük notu kim aldı?
 * 5. not ortalaması
 * 6. Geçenler
 * 7. Kalanlar
 */
//1. Aşama: Verilerin bellekte tutulması
Console.Write("Sınıfta kaç kişi var: ");
int ogrenciSayisi = Convert.ToInt32(Console.ReadLine());
string[] isimler = new string[ogrenciSayisi];
double[] notlar = new double[ogrenciSayisi];

Console.WriteLine("Öğrenci bilgilerini gir:");
for (int i = 0; i < ogrenciSayisi; i++)
{
    Console.Write($"{i + 1}. Öğrencinin adı:");
    isimler[i] = Console.ReadLine();

    Console.Write($"{i + 1}. Öğrencinin notu:");
    notlar[i] = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine();
}

//2. Aşama: Bellekteki verilerin gösterilmesi:

Console.WriteLine(new string('*',40));
Console.WriteLine("--- Bellekteki Öğrenciler ---");
for (int i = 0; i < ogrenciSayisi; i++)
{
    Console.WriteLine($"{isimler[i]} --> {notlar[i]}");
}


//3. Aşama istatistikler:
//[Türkay, Derya, İlknur, Dilek]
//[80, 95, 75, 50]

double enBuyuk = notlar[0];
string enIyiOgrenci = "";

double enKucuk = notlar[0];
string enZayifOgrenci = "";

double toplam = 0;
int gecenlerToplami = 0;
int kalanlarToplami = 0;

for (int i = 0; i < ogrenciSayisi; i++)
{

    if (notlar[i] > enBuyuk)
    {
        enBuyuk = notlar[i];
        enIyiOgrenci = isimler[i];
    }

    if (notlar[i] < enKucuk)
    {
        enKucuk = notlar[i];
        enZayifOgrenci = isimler[i];
    }

    toplam += notlar[i];

    if (notlar[i]>=45)
    {
        gecenlerToplami++;
    }
    else
    {
        kalanlarToplami++;
    }

}

Console.WriteLine(new String('-',40));
Console.WriteLine("--- İstatistikler ---");
Console.WriteLine($"En iyi ğrencinin adı: {enIyiOgrenci}, puanı: {enBuyuk} ");
Console.WriteLine($"En zayıf ğrencinin adı: {enZayifOgrenci}, puanı: {enKucuk} ");
double ortalama = toplam / ogrenciSayisi;
Console.WriteLine($"Ortalama Puan:{ortalama}");
Console.WriteLine($"Geçenler: {gecenlerToplami}, Kalanlar: {kalanlarToplami}");

string[] sehirler = {"Ankara","Eskişehir","Sivas"};

Console.WriteLine("Aradığınız şehri girin:");
string sehir = Console.ReadLine();
bool sehirVarmi = false;
int bulunanIndex = 0;

for (int i = 0;i < sehirler.Length;i++)
{
    if (sehirler[i] == sehir)
    {
        bulunanIndex = i;
        sehirVarmi = true;
        break;
    }
}

if (sehirVarmi)
{
    Console.WriteLine($"{sehir} listede var ve {bulunanIndex}. index sırasında");
}
else
{
    Console.WriteLine("Aradığınız şehir yok");
}






