﻿using TP_Lab1_Base.Models;
using TP_Lab1_Base.Service;

//Console.WriteLine("Введите путь к файлу:");
//string path = Console.ReadLine();
//Console.WriteLine("Введите имя файла (включая расширение файла)");
//string fileName = Console.ReadLine();

//FileReader dataReader = new FileReader(fileName, path);

//while(!dataReader.FileIsExist)
//{
//    Console.WriteLine("Введите путь к файлу:");
//    path = Console.ReadLine();
//    Console.WriteLine("Введите имя файла (включая расширение файла)");
//    fileName = Console.ReadLine();

//    dataReader = new FileReader(fileName, path);
//}

//MyParser parser = new MyParser();

//Student[] students = parser.TryParse(dataReader.ReadStringFromFile());

//foreach (var student in students)
//{
//    Console.WriteLine(student.Name + ", средний балл:");
//    Console.WriteLine(Calculator.GetAverageScore(student));
//}

//dataReader = FileReader.OpenFileFromProject(fileName);

//foreach (var student in students)
//{
//    Console.WriteLine(student.Name + ", средний балл:");
//    Console.WriteLine(Calculator.GetAverageScore(student));
//}

string fileName = @"XMLTypeData1.xml";
FileReader reader = FileReader.OpenFileFromProject(fileName);

string data = reader.ReadStringFromFile();
Console.WriteLine(data);
XMLParser parser = new XMLParser();

//Act
Student[] parsedData = parser.Parse(data);