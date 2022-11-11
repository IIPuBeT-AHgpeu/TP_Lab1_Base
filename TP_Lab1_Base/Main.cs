using TP_Lab1_Base.Models;
using TP_Lab1_Base.Service;

Console.WriteLine("Выберите парсер:\n1 - парсер стартового формата (формат предоставил преподаватель);\n2 - парсер XML.");

const string STANDART_TYPE_FILENAME = "StandartTypeData{NUMBER}.txt";
const string XML_TYPE_FILENAME = "XMLTypeData{NUMBER}.xml";

string input_buffer = "";
int mode = 0;
string fileName;
FileReader reader;
IParser<Student[]> parser;

input_buffer = Console.ReadLine();
if (input_buffer == "1" || input_buffer == "2")
{
    mode = Int32.Parse(input_buffer);

    Console.WriteLine("Выберите набор данных:" +
            "\n - введите \"E\" (без кавычек), для получения расширенного набор (5 записей);" +
            "\n - введите любую другую строку для получения стандартного набора.");
    input_buffer = Console.ReadLine();

    if (mode == 1)
    {
        if (input_buffer == "E") fileName = STANDART_TYPE_FILENAME.Replace("{NUMBER}", "2");
        else fileName = STANDART_TYPE_FILENAME.Replace("{NUMBER}", "1");

        parser = new MyParser();
    }
    else
    {
        if (input_buffer == "E") fileName = XML_TYPE_FILENAME.Replace("{NUMBER}", "2");
        else fileName = XML_TYPE_FILENAME.Replace("{NUMBER}", "1");

        parser = new XMLParser();
    }

    reader = FileReader.OpenFileFromProject(fileName);
    string data = reader.ReadStringFromFile();

    Student[] group = parser.Parse(data);

    Console.WriteLine("Количество студентов в группе: {0}", group.Length);
    Console.WriteLine("Состав группы: ");

    foreach (Student student in group)
    {
        Console.WriteLine("ФИО: {0}, средний балл: {1}", student.Name, Calculator.GetAverageScore(student));
    }
    Console.WriteLine("Количество хорошистов группы: {0}", Calculator.GetNumberOfGoodies(group));

    Console.WriteLine("-----------------------------------------------------------");
    Console.WriteLine("Исходник: \n{0}", data);
    Console.WriteLine("-----------------------------------------------------------");
}
else
{
    Console.WriteLine("Неккоректный ввод. Программа завершает работу.");
}