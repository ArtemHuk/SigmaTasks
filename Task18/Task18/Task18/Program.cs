using System;
using System.Collections;
using System.Collections.Generic;

namespace Task18
{
    class Blet : IComparer
    {
        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Blet> list = new List<Blet>(10);
            
            int[] data = { 3, 54,4, 64, 61 };
      
            data.QuickSort();
            
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
