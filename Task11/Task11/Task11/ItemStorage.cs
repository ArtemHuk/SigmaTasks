using System;
using System.Collections;
using System.Collections.Generic;

namespace Task11
{
    public abstract class ItemStorage
    {
        protected List<Item> items;
        private int curentIndex=0;
        public ItemStorage()
        {
            items = new List<Item>();
        }

        public abstract void ParseStorage(string[] text);

        public Item GetRandomItem()
        {
            Random random = new Random();
            int index = random.Next(0, items.Count);
            return items[index];
        }
        public Item GetNextItem()
        {
            if (curentIndex >= items.Count)
                curentIndex = 0;
            return items[curentIndex++];

        }

        
    }

    public class ToyStorage : ItemStorage
    {
        public override void ParseStorage(string[] text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                items.Add(Toy.Parse(text[i]));
            }
        }
    }

    public class EatingGiftStorage : ItemStorage
    {
        public override void ParseStorage(string[] text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                items.Add(EatingGift.Parse(text[i]));
            }
        }
    }

    public class WishStorage : ItemStorage
    {
        public override void ParseStorage(string[] text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                items.Add(Wish.Parse(text[i]));
            }
        }
    }

}
