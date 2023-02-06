// See https://aka.ms/new-console-template for more information
using OOP1;

Console.WriteLine("Hello, World!");
Airplane airplane = new Airplane("Kyiv", "Berlin", new Date(2023, 2, 6, 11, 17), new Date(2023, 2, 7, 14, 17));
Console.WriteLine(airplane.GetTotalTime());
Console.WriteLine(airplane.IsArrivingToday());
/*Console.WriteLine(airplane.GetStartDate());*/
