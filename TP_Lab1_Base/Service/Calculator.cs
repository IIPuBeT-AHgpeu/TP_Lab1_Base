using TP_Lab1_Base.Models;

namespace TP_Lab1_Base.Service
{
    internal static class Calculator
    {
        public static double GetAverageRating(Student student)
        {
            double sum = 0;

            foreach (var subject in student.EducationalSubjects)
            {
                sum += subject.Score;
            }

            return sum / student.EducationalSubjects.Length;
        }
    }
}
