// See https://aka.ms/new-console-template for more information
using OOP1;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding= Encoding.UTF8;
Console.WriteLine("Hello, World!");
Airplane airplane = new Airplane("Kyiv", "Berlin", new Date(2023, 2, 6, 11, 17), new Date(2023, 2, 7, 14, 17));
Console.WriteLine(airplane.GetTotalTime());
Console.WriteLine(airplane.IsArrivingToday());
/*Console.WriteLine(airplane.GetStartDate());*/
Product product = new Product("Ноутбук", 2, new Currency(), 5, "Acer", 2.7);
Console.WriteLine(product.GetPriceInUAH());
