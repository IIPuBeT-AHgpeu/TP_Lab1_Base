using TP_Lab1_Base.Models;

namespace TP_Lab1_Base.Service
{
    /// <summary>
    /// Класс обработки данных. Включает в себя методы получения необходимой информации из данных, полученных от парсера.
    /// </summary>
    public static class Calculator
    {
        /// <summary>
        /// Осуществляет подсчет среднего по всем предметам рейтинга студента.
        /// </summary>
        /// <param name="student">Экземляр модели студента, по данным которого будет подсчитан средний рейтинг.</param>
        /// <returns>Средний рейтинг студента.</returns>
        public static float GetAverageScore(Student student)
        {
            float sum = 0;

            foreach (var subject in student.EducationalSubjects)
            {
                sum += subject.Score;
            }

            return sum / student.EducationalSubjects.Length;
        }

        public static ushort GetNumberOfGoodies(Student[] group)
        {
            ushort sum = 0;
            if (group == null) throw new ArgumentNullException("group");

            bool have4, have3 = false;
            foreach (Student student in group)
            {
                if (student == null) throw new ArgumentNullException("student");

                have3 = false; have4 = false;

                foreach (EducationalSubject subject in student.EducationalSubjects)
                {
                    if (subject == null) throw new ArgumentNullException("EducationalSubject");

                    if (subject.Score < 90 && subject.Score >= 76 && !have4) have4 = true;
                    else if (subject.Score < 76 && !have3) have3 = true;
                }

                if (!have3 && have4) sum++;
            }

            return sum;
        }
    }
}
