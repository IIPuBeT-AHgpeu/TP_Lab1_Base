using TP_Lab1_Base.Models;
using TP_Lab1_Base.Service;

namespace TP_Lab1_Base_Tests
{
    [TestClass]
    public class XMLParserTests
    {
        [TestMethod]
        public void XMLParseTest_file_1()
        {
            //Arrange
            string fileName = @"XMLTypeData1.xml";
            FileReader reader = FileReader.OpenFileFromProject(fileName);

            string data = reader.ReadStringFromFile();
            XMLParser parser = new XMLParser();

            //Act
            Student[] parsedData = parser.Parse(data);
            bool isCorrect = true;

            if (parsedData.Length != 3) isCorrect = false;
            else
            {
                if (parsedData[0] == null) isCorrect = false;
                else
                {
                    if (parsedData[parsedData.Length - 1].Name != "Соколов Михаил Сергеевич") isCorrect = false;
                }
            }

            //Assert
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void XMLParseTest_file_2()
        {
            //Arrange
            string fileName = @"XMLTypeData2.xml";
            FileReader reader = FileReader.OpenFileFromProject(fileName);

            string data = reader.ReadStringFromFile();
            XMLParser parser = new XMLParser();

            //Act
            Student[] parsedData = parser.Parse(data);
            bool isCorrect = true;
            string message = "";

            if (parsedData.Length != 5)
            {
                isCorrect = false;
                message = "Студентов не 5";
            }
            else
            {
                if (parsedData[0] == null)
                {
                    isCorrect = false;
                    message = "Первый студент null";
                }
                else
                {
                    if (parsedData[2].EducationalSubjects.Length != 5)
                    {
                        isCorrect = false;
                        message = "Предметов не 5";
                    }
                    else
                    {
                        if (parsedData[parsedData.Length - 1].Name != "Вак Михаил Сергеевич")
                        {
                            isCorrect = false;
                            message = "Последнее имя студента на Пак Михаил Сергеевич";
                        }
                    }
                }
            }

            //Assert
            Assert.IsTrue(isCorrect, message);
        }
    }
}
