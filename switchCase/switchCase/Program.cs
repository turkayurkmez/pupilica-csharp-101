// See https://aka.ms/new-console-template for more information
Console.WriteLine("Trafik ışığını giriniz:\nKIRMIZI\nSARI\nYESIL");
string renk = Console.ReadLine();

if (renk == "KIRMIZI")
{
    Console.WriteLine("DUR!");
}
else if (renk == "SARI")
{
    Console.WriteLine("DİKKAT!!!");
}
else if (renk == "YESIL")
{
    Console.WriteLine("GEÇ");
}
else
{
    Console.WriteLine("Bu ne biçim renk!?");
}

switch (renk)
{
    case "KIRMIZI":
        Console.WriteLine("DUR!");
        break;
    case "SARI":
        Console.WriteLine("DİKKAT!!!");
        break;
    case "YESIL":
        Console.WriteLine("GEÇ");
        break;


    default:
        Console.WriteLine("Bu ne biçim renk?");
        break;
}


switch (DateTime.Now.DayOfWeek)
{
    case DayOfWeek.Sunday:
        break;
    case DayOfWeek.Monday:
        break;
    case DayOfWeek.Tuesday:
        break;
    case DayOfWeek.Wednesday:
        break;
    case DayOfWeek.Thursday:
        break;
    case DayOfWeek.Friday:
        break;
    case DayOfWeek.Saturday:
        break;
    default:
        break;
}


