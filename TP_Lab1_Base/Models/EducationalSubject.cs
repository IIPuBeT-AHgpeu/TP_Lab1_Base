namespace TP_Lab1_Base.Models
{
    /// <summary>
    /// Класс-модель, описывающий предмет, изучаемый студентом.
    /// </summary>
    public class EducationalSubject
    {
        /// <summary>
        /// Наименование предмета.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Количество баллов, полученных студентом, по предмету.
        /// </summary>
        public int Score { get; set; }
    }
}
