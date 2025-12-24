// See https://aka.ms/new-console-template for more information
using Inheritance;

Console.WriteLine("Hello, World!");

Oyuncu oyuncu = new Oyuncu();
Ak47 ak47 = new Ak47();
oyuncu.OyuncununSilahi = ak47;


oyuncu.SagClick();
oyuncu.Atak();


DesertEagle desertEagle = new DesertEagle();

oyuncu.OyuncununSilahi = desertEagle;

oyuncu.SagClick();
oyuncu.Atak();