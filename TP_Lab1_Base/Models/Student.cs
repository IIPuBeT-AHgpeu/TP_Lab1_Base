namespace TP_Lab1_Base.Models
{
    /// <summary>
    /// Класс-модели, описывающий сущность "Студент".
    /// </summary>
    internal class Student
    {
        /// <summary>
        /// Имя студента.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Список предметов, изучаемых студентом.
        /// </summary>
        public EducationalSubject[] EducationalSubjects { get; set; }
    }
}
