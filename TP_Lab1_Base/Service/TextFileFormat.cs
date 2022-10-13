namespace TP_Lab1_Base.Service
{
    internal class TextFileFormat
    {
        public TextFormat Format { get; set; }

        public string? GetUpperFormatName()
        {
            return Enum.GetName(typeof(TextFormat), Format);
        }

        public string? GetLowerFormatName()
        {
            string? result = Enum.GetName(typeof(TextFormat), Format);
            if (result == null) return null;
            else return result.ToLower();
        }

        public enum TextFormat
        {
            TXT,
            JSON,
            XML
        }
    }
}
