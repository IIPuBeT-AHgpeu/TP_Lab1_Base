﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TP_Lab1_Base.Models;

namespace TP_Lab1_Base.Service
{
    public class XMLParser : IParser<Student[]>
    {
        public Student[]? Parse(string data)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student[]));
            Student[]? group;

            using (Stream s = GenerateStreamFromString(data))
            {
                group = xmlSerializer.Deserialize(s) as Student[];
            }

            return group;
        }

        public Student[] TryParse(string data)
        {
            throw new NotImplementedException();
        }

        private Stream GenerateStreamFromString(string s)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }
    }
}
