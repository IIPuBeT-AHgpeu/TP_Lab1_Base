// See https://aka.ms/new-console-template for more information
using TP_Lab1_Base.Models;
using TP_Lab1_Base.Service;

FileReader dataReader = new FileReader("StandartTypeData.txt", @"C:\Users\Kirpa\source\repos\TP_Lab1_Base\TP_Lab1_Base\Data");

MyParser parser = new MyParser();

StandartModel[] students = parser.TryParse(dataReader.ReadStringFromFile());

Console.WriteLine(students.Length);