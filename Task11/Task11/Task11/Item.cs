using System;
namespace Task11
{
    public abstract class Item
    {
        public string Name { get; private set; }
        public Item(string name="")
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name; 
        }

    }

    public class Toy : Item
    {
        public Toy(string name=""):base(name)
        {
            
        }
        public static Toy Parse(string s)
        {
            string[] name = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            return new Toy(name[0]);
        }
    }

    public class EatingGift : Item
    {
        public EatingGift(string name = "") : base(name)
        {

        }
        public static EatingGift Parse(string s)
        {
            string[] name = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            return new EatingGift(name[0]);
        }
    }

    public class Wish : Item
    {
        public Wish(string name = "") : base(name)
        {

        }
        public static Wish Parse(string s)
        {
            string[] name = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            return new Wish(name[0]);
        }
    }
}
