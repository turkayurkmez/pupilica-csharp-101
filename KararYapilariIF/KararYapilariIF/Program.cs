// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hava şu an kaç derece?");
int sicaklik = int.Parse(Console.ReadLine()); //Convert.ToInt32(Console.ReadLine())

if (sicaklik < 10) // önerme doğruysa
{
    Console.WriteLine("Mont giy :)");
}
else if (sicaklik < 15)
{
    Console.WriteLine("Kot ceket giy :)");

}
else
{
    Console.WriteLine("Rahat şeyler giy");
}

//Console.WriteLine("Herhangi bir şey :)");

Random rastgeleSayiUretici = new Random();
int rastgeleSayi = rastgeleSayiUretici.Next(1, 3);
Console.WriteLine("Yazı mı tura mı?\nSeçiminizi yapın\n1 - YAZI\n2 - TURA");
string kullaniciSecimi = Console.ReadLine();

if (rastgeleSayi.ToString() == kullaniciSecimi) 
{
    Console.WriteLine("Bildiniz!");
}
else
{
    Console.WriteLine("Bilemediniz...");
}


int yas = 18;
bool ebeveynIzni = true;

if (yas >= 20)
{
    Console.WriteLine("Filme girebilirsiniz");
}
else if(yas <18 & ebeveynIzni)
{
    Console.WriteLine("Ebeveyn izni var. Girebilirsiniz...");
}
else
{
    Console.WriteLine("Filme giremezsiniz");
}

