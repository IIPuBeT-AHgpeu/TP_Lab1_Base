using System.Reflection;

namespace TP_Lab1_Base.Service
{
    internal class FileReader
    {
        private string _path;
        public string Path { get; set; }
        public string FileName { get; set; }
        public bool FileIsExist { get; set; } = false;

        public FileReader(string fileName, string path)
        {
            FileName = fileName;
            Path = path;

            _path = path + "\\" + fileName;
            FileIsExist = File.Exists(_path);
        }

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
        public async Task<byte[]> ReadBytesFromFileAsync()
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
        public async Task<string> ReadStringFromFileAsync()
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
