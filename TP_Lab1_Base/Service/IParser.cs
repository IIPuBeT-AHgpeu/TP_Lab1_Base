namespace TP_Lab1_Base.Service
{
    /// <summary>
    /// Интерфейс, реализация которого подразумевает реализацию функций по парсингу данных из файла в некотором формате.
    /// </summary>
    /// <typeparam name="T">Класс модели, обрабатываемых данных.</typeparam>
    internal interface IParser<T>
    {
        /// <summary>
        /// Функция парсинга строки (данных в виде строки). Данную функцию нужно использовать в блоке try-catch, 
        /// так как если в процессе парсинга возникнет ошибка, то функция выбросит исключение.
        /// </summary>
        /// <param name="data">Данные для парсинга в формате строки.</param>
        /// <returns></returns>
        public T TryParse(string data);
        /// <summary>
        /// Функция парсинга строки (данных в виде строки). Если в процессе парсинга возникнет ошибка, то функция вернет null.
        /// </summary>
        /// <param name="data">Данные для парсинга в формате строки.</param>
        /// <returns></returns>
        public T? Parse(string data);
    }
}
