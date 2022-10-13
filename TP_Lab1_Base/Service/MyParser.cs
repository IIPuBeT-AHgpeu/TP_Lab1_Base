using System.Text.RegularExpressions;
using TP_Lab1_Base.Models;

namespace TP_Lab1_Base.Service
{
    internal class MyParser : IParser<StandartModel[]>
    {
        public StandartModel[]? Parse(string data)
        {
            throw new NotImplementedException();
        }

        public StandartModel[] TryParse(string data)
        {
            throw new NotImplementedException();
            Regex regex = new Regex(CHUNK_REGEX);
            Console.WriteLine(regex.Matches(data).Count);

        }

        private static readonly string CHUNK_REGEX = @"[а-яА-Я ]+\s(\s[а-яА-Я]+)";
    }
}
