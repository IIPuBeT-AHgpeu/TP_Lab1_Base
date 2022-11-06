using TP_Lab1_Base.Models;

namespace TP_Lab1_Base.Service
{
    /// <summary>
    /// Класс обработки данных. Включает в себя методы получения необходимой информации из данных, полученных от парсера.
    /// </summary>
    internal static class Calculator
    {
        /// <summary>
        /// Осуществляет подсчет среднего по всем предметам рейтинга студента.
        /// </summary>
        /// <param name="student">Экземляр модели студента, по данным которого будет подсчитан средний рейтинг.</param>
        /// <returns>Средний рейтинг студента.</returns>
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
