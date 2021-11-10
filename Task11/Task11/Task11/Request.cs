using System;
namespace Task11
{
    public class Request: ISaintNicholasRequest
    {
        public string Name { get; private set; }
        public Sex Sex { get; private set; }
        public int GoodDeeds { get; private set; }
        public int BadDeeds { get; private set; }

        
        public Request(string name="",Sex sex=Sex.Male,int goodDeeds=0,int badDeeds=0)
        {
            Name = name;
            Sex = sex;
            GoodDeeds = goodDeeds;
            BadDeeds = badDeeds;
        }

        public static ISaintNicholasRequest Parse(string s)
        {
            try
            {
                string[] parts = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = parts[0];
                Sex sex = (Sex)Enum.Parse(typeof(Sex), parts[1]);
                int goodDeeds = int.Parse(parts[2]);
                int badDeeds = int.Parse(parts[3]);
                return new Request(name, sex, goodDeeds, badDeeds);
            }
            catch (Exception ex)
            {
                throw;
            }    
        }
        
    }
}
