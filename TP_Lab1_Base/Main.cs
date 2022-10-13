// See https://aka.ms/new-console-template for more information
using TP_Lab1_Base.Service;

FileReader dataReader = new FileReader("StandartTypeData.txt", @"C:\Users\Kirpa\source\repos\TP_Lab1_Base\TP_Lab1_Base\Data");

Console.WriteLine(Directory.GetCurrentDirectory());

MyParser parser = new MyParser();
Console.WriteLine(dataReader.ReadStringFromFile());
parser.TryParse(dataReader.ReadStringFromFile());

