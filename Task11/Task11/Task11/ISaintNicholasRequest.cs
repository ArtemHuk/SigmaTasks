using System;
namespace Task11
{
    public interface ISaintNicholasRequest
    {
        public string Name { get; }
        public Sex Sex { get; }
        public int GoodDeeds { get; }
        public int BadDeeds { get; }
    }
}
