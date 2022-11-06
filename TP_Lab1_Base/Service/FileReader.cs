using System.Reflection;

namespace TP_Lab1_Base.Service
{
    /// <summary>
    /// Класс, который считывает данные из текстового файла.
    /// </summary>
    internal class FileReader
    {
        private string _path;
        /// <summary>
        /// Путь к файлу.
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// Имя файла.
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// Свойство характеризующие наличие файла с именем FileName в директории Path. 
        /// </summary>
        public bool FileIsExist { get; set; } = false;

        public FileReader(string fileName, string path)
        {
            FileName = fileName;
            Path = path;

            _path = path + "\\" + fileName;
            FileIsExist = File.Exists(_path);
        }

        /// <summary>
        /// Считывает данные из файла, как массив байт.
        /// </summary>
        /// <returns>Возвращает массив байт. Если файл не был найден или во время считывания данных возникла ошибка, 
        /// то функция вернет null.</returns>
        public byte[]? ReadBytesFromFile()
        {
            if (FileIsExist == false) return null;
            else
            {
                try
                {
                    return File.ReadAllBytes(_path);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error! " + ex.Message);
                    return null;
                }
            }
        }
        /// <summary>
        /// Считывает данные из файла, как массив байт, в ассинхронном режиме.
        /// </summary>
        /// <returns>Возвращает массив байт в составе задачи (Task). Если файл не был найден или во время считывания данных возникла ошибка, 
        /// то функция вернет null.</returns>
        public async Task<byte[]?> ReadBytesFromFileAsync()
        {
            if (FileIsExist == false) return null;
            else
            {
                try
                {
                    return await File.ReadAllBytesAsync(_path);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error! " + ex.Message);
                    return null;
                }
            }
        }
        /// <summary>
        /// Считывает данные из файла в строку.
        /// </summary>
        /// <returns>Возвращает строку. Если файл не был найден или во время считывания данных возникла ошибка, 
        /// то функция вернет null.</returns>
        public string ReadStringFromFile()
        {
            if (FileIsExist == false) return null;
            else
            {
                try
                {
                    return File.ReadAllText(_path);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error! " + ex.Message);
                    return null;
                }
            }
        }
        /// <summary>
        /// Считывает данные из файла строкой в ассинхронном режиме.
        /// </summary>
        /// <returns>Возвращает массив байт в составе задачи (Task). Если файл не был найден или во время считывания данных возникла ошибка, 
        /// то функция вернет null.</returns>
        public async Task<string?> ReadStringFromFileAsync()
        {
            if (FileIsExist == false) return null;
            else
            {
                try
                {
                    return await File.ReadAllTextAsync(_path);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error! " + ex.Message);
                    return null;
                }
            }
        }
    }
}
