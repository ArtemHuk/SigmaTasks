using System;
using System.Collections;
using System.Collections.Generic;

namespace Task18
{
    
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] data = { 3, 54, 4, 64, 61 };

                data.QuickSort();

                foreach (var item in data)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
            
        }
    }
}
