namespace TP_Lab1_Base.Service
{
    internal class DataReader
    {
        private string _path;
        public TextFileFormat FileFormat { get; set; }
        public string FileName { get; set; }
        public bool IsExist { get; set; } = false;

        public DataReader(string fileName)
        {
            FileName = fileName;
            FileFormat = new TextFileFormat() { Format = TextFileFormat.TextFormat.TXT };

            _path = fileName + FileFormat.GetLowerFormatName();
            IsExist = File.Exists(_path);
        }

        public DataReader(string fileName, TextFileFormat fileFormat)
        {
            FileName = fileName;
            FileFormat = fileFormat;

            _path = fileName + FileFormat.GetLowerFormatName();
            IsExist = File.Exists(_path);
        }

        public byte[]? ReadBytesFromFile()
        {
            if (IsExist == false) return null;
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
            if (IsExist == false) return null;
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
            if (IsExist == false) return null;
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
            if (IsExist == false) return null;
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
