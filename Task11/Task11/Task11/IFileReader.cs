using System;
namespace Task11
{
    public interface IFileReader
    {
        public string[] Text { get;}
        public string[] ReadFromFile(string path);
    }
}
