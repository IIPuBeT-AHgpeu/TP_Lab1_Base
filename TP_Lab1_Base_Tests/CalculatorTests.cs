using TP_Lab1_Base.Models;
using TP_Lab1_Base.Service;

namespace TP_Lab1_Base_Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void GetAverageScoreTest_IN_61x3_OUT_61()
        {
            //Arrange
            Student student = new Student()
            {
                Name = "Ivan",
                EducationalSubjects = new EducationalSubject[]
                    {
                    new EducationalSubject() { Name = "математика", Score = 61},
                    new EducationalSubject() { Name = "физика", Score = 61},
                    new EducationalSubject() { Name = "хими€", Score = 61}
                    }
            };
            float expected = 61.0F;

            //act
            float actual = Calculator.GetAverageScore(student);

            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void GetAverageScoreTest_IN_70_80_90_OUT_80()
        {
            //Arrange
            Student student = new Student()
            {
                Name = "Ivan",
                EducationalSubjects = new EducationalSubject[]
                    {
                    new EducationalSubject() { Name = "математика", Score = 70},
                    new EducationalSubject() { Name = "физика", Score = 90},
                    new EducationalSubject() { Name = "хими€", Score = 80}
                    }
            };
            float expected = 80.0F;

            //act
            float actual = Calculator.GetAverageScore(student);

            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void GetAverageScoreTest_IN_61_78_88_55_100_OUT_76dot4()
        {
            //Arrange
            Student student = new Student()
            {
                Name = "Ivan",
                EducationalSubjects = new EducationalSubject[]
                    {
                    new EducationalSubject() { Name = "математика", Score = 61},
                    new EducationalSubject() { Name = "физика", Score = 78},
                    new EducationalSubject() { Name = "музыка", Score = 88},
                    new EducationalSubject() { Name = "—оциологи€", Score = 55},
                    new EducationalSubject() { Name = "хими€", Score = 100}
                    }
            };
            float expected = 76.4F;

            //act
            float actual = Calculator.GetAverageScore(student);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}