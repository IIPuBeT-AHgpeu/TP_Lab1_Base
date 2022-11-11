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

        [TestMethod]
        public void GetNumberOfGoodiesTest_IN_3stdnt_OUT_0()
        {
            Student[] group = new Student[3]
            {
                new Student()
                {
                    Name = "name1",
                    EducationalSubjects = new EducationalSubject[3]
                    {
                        new EducationalSubject()
                        {
                            Name = "subj1",
                            Score = 100
                        },
                        new EducationalSubject()
                        {
                            Name = "subj2",
                            Score = 90
                        },
                        new EducationalSubject()
                        {
                            Name = "subj3",
                            Score = 95
                        }
                    }
                },
                new Student()
                {
                    Name = "name2",
                    EducationalSubjects = new EducationalSubject[3]
                    {
                        new EducationalSubject()
                        {
                            Name = "subj1",
                            Score = 55
                        },
                        new EducationalSubject()
                        {
                            Name = "subj2",
                            Score = 75
                        },
                        new EducationalSubject()
                        {
                            Name = "subj3",
                            Score = 61
                        }
                    }
                },
                new Student()
                {
                    Name = "name3",
                    EducationalSubjects = new EducationalSubject[3]
                    {
                        new EducationalSubject()
                        {
                            Name = "subj1",
                            Score = 61
                        },
                        new EducationalSubject()
                        {
                            Name = "subj2",
                            Score = 100
                        },
                        new EducationalSubject()
                        {
                            Name = "subj3",
                            Score = 100
                        }
                    }
                }
            };
            ushort expected = 0;
            
            ushort actual = Calculator.GetNumberOfGoodies(group);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetNumberOfGoodiesTest_IN_5stdnt_OUT_3()
        {
            Student[] group = new Student[5]
            {
                new Student()
                {
                    Name = "name1",
                    EducationalSubjects = new EducationalSubject[3]
                    {
                        new EducationalSubject()
                        {
                            Name = "subj1",
                            Score = 100
                        },
                        new EducationalSubject()
                        {
                            Name = "subj2",
                            Score = 76
                        },
                        new EducationalSubject()
                        {
                            Name = "subj3",
                            Score = 76
                        }
                    }
                },
                new Student()
                {
                    Name = "name2",
                    EducationalSubjects = new EducationalSubject[3]
                    {
                        new EducationalSubject()
                        {
                            Name = "subj1",
                            Score = 76
                        },
                        new EducationalSubject()
                        {
                            Name = "subj2",
                            Score = 76
                        },
                        new EducationalSubject()
                        {
                            Name = "subj3",
                            Score = 78
                        }
                    }
                },
                new Student()
                {
                    Name = "name3",
                    EducationalSubjects = new EducationalSubject[3]
                    {
                        new EducationalSubject()
                        {
                            Name = "subj1",
                            Score = 89
                        },
                        new EducationalSubject()
                        {
                            Name = "subj2",
                            Score = 76
                        },
                        new EducationalSubject()
                        {
                            Name = "subj3",
                            Score = 80
                        }
                    }
                },
                new Student()
                {
                    Name = "name4",
                    EducationalSubjects = new EducationalSubject[3]
                    {
                        new EducationalSubject()
                        {
                            Name = "subj1",
                            Score = 61
                        },
                        new EducationalSubject()
                        {
                            Name = "subj2",
                            Score = 89
                        },
                        new EducationalSubject()
                        {
                            Name = "subj3",
                            Score = 89
                        }
                    }
                },
                new Student()
                {
                    Name = "name5",
                    EducationalSubjects = new EducationalSubject[3]
                    {
                        new EducationalSubject()
                        {
                            Name = "subj1",
                            Score = 89
                        },
                        new EducationalSubject()
                        {
                            Name = "subj2",
                            Score = 89
                        },
                        new EducationalSubject()
                        {
                            Name = "subj3",
                            Score = 89
                        }
                    }
                }
            };
            ushort expected = 4;

            ushort actual = Calculator.GetNumberOfGoodies(group);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetNumberOfGoodiesTest_IN_5stdnt_OUT_3_FROM_file2()
        {
            FileReader reader = FileReader.OpenFileFromProject("XMLTypeData2.xml");
            XMLParser parser = new XMLParser();

            Student[] group = parser.Parse(reader.ReadStringFromFile());
            ushort expected = 3;

            ushort actual = Calculator.GetNumberOfGoodies(group);

            Assert.AreEqual(expected, actual);
        }
    }
}