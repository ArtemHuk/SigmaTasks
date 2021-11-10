using System;
using System.IO;
using System.Collections.Generic;
namespace Task11
{
    public class FileReader:IFileReader
    {
        public string[] Text { get; private set; }

        public FileReader(string path)
        {
            ReadFromFile(path);
        }
        public FileReader() { }

        public string[] ReadFromFile(string path)
        {
            using (StreamReader reader= new StreamReader(path))
            {
                List<string> result = new List<string>();
                string line;
                while ((line=reader.ReadLine()) != null)
                {
                    result.Add(line);
                }
                Text = result.ToArray();
            }
            return Text;
        }
    }
}
