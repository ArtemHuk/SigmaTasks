using System;
using System.Collections.Generic;
namespace Task18
{
    public delegate int Comparer<T>(T obj1, T obj2);
    public static class Sorter
    {
        public static void QuickSort<T>(this T[] data,int lIndex,int rIndex,Comparer<T> comparer,bool descendingMode)
        {
            
            int start = lIndex, end = rIndex;
            T mValue = data[(start + end) / 2];
            int one = descendingMode ? -1 : 1;
            while (lIndex < rIndex)
            {
                try
                {
                    while (comparer(data[lIndex], mValue) == -one)
                        ++lIndex;
                    while (comparer(data[rIndex], mValue) == one)
                        --rIndex;
                }
                catch (Exception ex)
                {
                    throw new Exception("Problem with comparer");
                }
                
                if (lIndex <= rIndex)
                {
                    T temp = data[lIndex];
                    data[lIndex] = data[rIndex];
                    data[rIndex] = temp;
                    ++lIndex;
                    --rIndex;
                }
            }

            if (rIndex > start)
               data.QuickSort<T>(start, rIndex, comparer,descendingMode);
            if (lIndex < end)
               data.QuickSort<T>(lIndex, end, comparer,descendingMode);
        }

        public static void QuickSort<T>(this T[] data, Comparer<T> comparer, bool descendingMode = false)
        {
            data.QuickSort( 0, data.Length - 1, comparer,descendingMode);  
        }

        public static void QuickSort<T>(this T[] data, bool descendingMode = false)
        {
             data.QuickSort(0, data.Length - 1, (x, y) => { return ((IComparable)x).CompareTo(((IComparable)y)); }, descendingMode);        
        }

    }
}
