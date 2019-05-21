﻿using System;

namespace SearchAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 10000000;
            RunAnalysis(size);
        }

        public static int SimpleLinearSearch(int[] array, int searchValue)
        {
            int SearchValueIndex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == searchValue)
                {
                    SearchValueIndex = i;
                }
            }
            return SearchValueIndex;
        } 
        public static int ImprovedLinearSearch(int[] array, int searchValue)
        {
            for ( int i = 0; i < array.Length; i++)
            {
                if (array[i] == searchValue)
                {
                    return i;
                }
            }
            return -1;
        }
        public static int ImprovedLinearSearchWithSentinel(int[] array, int searchValue)
        {
            int last = array[array.Length - 1];
            array[array.Length - 1] = searchValue;
            int i = 0;
            while (array[i]!= searchValue)
            {
                i++;
            }
            if (i < array.Length-1 || last == searchValue)
            {
                return i;
            }
            else
            {
                return -1;
            }
        }
        public static void RunAnalysis(int size)
        {
            
            int SearchValue = 8;
            int[] numbers = new int[size];
            numbers[size - 1] = SearchValue;
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            int IndexSimpleLinearSearch = SimpleLinearSearch(numbers, SearchValue);
            stopwatch.Stop();
            long TimeSimpleLinearSearch = stopwatch.ElapsedMilliseconds;
            stopwatch.Reset();
            stopwatch.Start();
            int IndexImprovedLinearSearch = ImprovedLinearSearch(numbers, SearchValue);
            stopwatch.Stop();
            long TimeImprovedLinearSearch = stopwatch.ElapsedMilliseconds;

            stopwatch.Reset();
            stopwatch.Start();
            int IndexImprovedLinearSearchWithSentinel = ImprovedLinearSearchWithSentinel(numbers, SearchValue);
            stopwatch.Stop();
            long TimeImprovedLinearSearchWithSentinel = stopwatch.ElapsedMilliseconds;
            Console.WriteLine("We are looking for number " + SearchValue);
            if (IndexSimpleLinearSearch == -1)
            {
                Console.WriteLine("Value was not found");
            }
            else
            {
                Console.WriteLine("Simple linear search give index {0} in time {1}ms", IndexSimpleLinearSearch, TimeSimpleLinearSearch);
                Console.WriteLine("Improved linear search give index {0} in time {1}ms", IndexImprovedLinearSearch, TimeImprovedLinearSearch);
                Console.WriteLine("Improved linear search with sentinel give index {0} in time {1}ms", IndexImprovedLinearSearchWithSentinel, TimeImprovedLinearSearchWithSentinel);
            }
        
        }
    }
}
