using System;

namespace SearchAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 10000000;

            Console.WriteLine("Size; SimpleLinearSearch; ImprovedLinearSearch; ImprovedWithSentinel");
            for (int i = 1; i < 11; i++)
            {
                RunAnalysis(size * i);
            }
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
            if (IndexSimpleLinearSearch == -1)
            {
                Console.WriteLine("Value was not found");
            }
            else
            {
                Console.WriteLine(size + ";" + TimeSimpleLinearSearch + ";" + TimeImprovedLinearSearch + ";" + TimeImprovedLinearSearchWithSentinel);}
        
        }
    }
}
