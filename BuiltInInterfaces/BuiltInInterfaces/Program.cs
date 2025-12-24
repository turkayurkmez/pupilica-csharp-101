// See https://aka.ms/new-console-template for more information
using BuiltInInterfaces;

Console.WriteLine("Hello, World!");

ClassRoom classRoom = new ClassRoom();
classRoom.Add(new Student { Id = 1, Name = "Zeynep", Score = 75 });
classRoom.Add(new Student { Id = 2, Name = "Elnur", Score = 80 });
classRoom.Add(new Student { Id = 3, Name = "Elif", Score = 78 });

classRoom.Sort();

foreach (var item in classRoom)
{
    Console.WriteLine($"{item.Name} - {item.Score}");
}