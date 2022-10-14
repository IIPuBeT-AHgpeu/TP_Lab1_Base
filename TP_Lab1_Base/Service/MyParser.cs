using System.Text.RegularExpressions;
using TP_Lab1_Base.Models;

namespace TP_Lab1_Base.Service
{
    internal class MyParser : IParser<StandartModel[]>
    {
        public StandartModel[]? Parse(string data)
        {
            data = data.Replace("\r", "");

            var chunks = Regex.Matches(data, CHUNK_REGEX, RegexOptions.Multiline);

            if (chunks.Count == 0) return null;

            List<StandartModel> students = new List<StandartModel>();

            foreach (Match chunk in chunks)
            {
                StandartModel student = new StandartModel();
                string[] parsedChunk = chunk.Value.Split('\n');

                if (parsedChunk.Length < 2) return null;

                student.Name = parsedChunk[0];

                List<EducationalSubject> subjects = new List<EducationalSubject>();
                for (int i = 1; i < parsedChunk.Length && parsedChunk[i] != ""; i++)
                {
                    if (parsedChunk[i][0] == ' ')
                    {
                        string[] subjNameSubjScoreString = parsedChunk[i].Split(':');

                        if (subjNameSubjScoreString.Length < 2) return null;

                        subjects.Add(new EducationalSubject() { Name = subjNameSubjScoreString[0].Remove(0), Score = Int32.Parse(subjNameSubjScoreString[1]) });
                    }
                }

                student.EducationalSubjects = subjects.ToArray();
                students.Add(student);
            }

            return students.ToArray();
        }

        public StandartModel[] TryParse(string data)
        {
            data = data.Replace("\r", "");

            var chunks = Regex.Matches(data, CHUNK_REGEX, RegexOptions.Multiline);

            if (chunks.Count == 0) throw new Exception("Have no matches!");

            List<StandartModel> students = new List<StandartModel>();

            foreach (Match chunk in chunks)
            {
                StandartModel student = new StandartModel();
                string[] parsedChunk = chunk.Value.Split('\n');

                if (parsedChunk.Length < 2) throw new Exception("Invalid parsed data!");

                student.Name = parsedChunk[0];

                List<EducationalSubject> subjects = new List<EducationalSubject>();
                for (int i = 1; i < parsedChunk.Length && parsedChunk[i] != ""; i++)
                {
                    if (parsedChunk[i][0] == ' ')
                    {
                        string[] subjNameSubjScoreString = parsedChunk[i].Split(':');

                        if (subjNameSubjScoreString.Length < 2) throw new Exception("Invalid parsed \"subject:score\" string!");

                        subjects.Add(new EducationalSubject() { Name = subjNameSubjScoreString[0].Remove(0), Score = Int32.Parse(subjNameSubjScoreString[1]) });
                    }
                }

                student.EducationalSubjects = subjects.ToArray();
                students.Add(student);
            }

            return students.ToArray();
        }

        private static readonly string CHUNK_REGEX = @"[а-яА-Я a-zA-Z-.]+\n((\t| )[a-zA-Zа-яА-Я-.]+:[0-9]{1,3}(\n|$))+";
    }
}
