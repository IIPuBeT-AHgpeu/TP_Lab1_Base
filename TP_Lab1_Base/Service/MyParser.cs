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
            Regex regex = new Regex(CHUNK_REGEX, RegexOptions.Multiline);
            Console.WriteLine(regex.Matches(data).Count);

            return null;
        }

        private static readonly string CHUNK_REGEX = @"[а-яА-Я a-zA-Z-.]+\n((\t| )[a-zA-Zа-яА-Я-.]+:[0-9]{1,3}(\n|$))+";
    }
}
