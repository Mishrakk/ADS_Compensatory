using System;

namespace SearchAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[100000000];
            numbers[100000000 - 1] = 8;
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            int SearchValue = 8;
            stopwatch.Start();
            int IndexSimpleLinearSearch = SimpleLinearSearch(numbers, SearchValue);
            stopwatch.Stop();
            long TimeSimpleLinearSearch = stopwatch.ElapsedMilliseconds;
            stopwatch.Reset();
            stopwatch.Start();
            int IndexImprovedLinearSearch = ImprovedLinearSearch(numbers, SearchValue);
            stopwatch.Stop();
            long TimeImprovedLinearSearch = stopwatch.ElapsedMilliseconds;
            Console.WriteLine("We are looking for number " + SearchValue);
            if (IndexSimpleLinearSearch == -1)
            {
                Console.WriteLine("Value was not found");
            }
            else
            {
                Console.WriteLine("Simple linear search give index {0} in time {1}ms", IndexSimpleLinearSearch, TimeSimpleLinearSearch);
                Console.WriteLine("Improved linear search give index {0} in time {1}ms", IndexImprovedLinearSearch, TimeImprovedLinearSearch);
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
    } 
}
