using System;

namespace SearchAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, 8, 11, 17, 5, 8 };
            int SearchValue = 8;
            int IndexSimpleLinearSearch = SimpleLinearSearch(numbers, SearchValue);
            int IndexImprovedLinearSearch = ImprovedLinearSearch(numbers, SearchValue);
            Console.WriteLine("We are looking for number " + SearchValue);
            if (IndexSimpleLinearSearch == -1)
            {
                Console.WriteLine("Value was not found");
            }
            else
            {
                Console.WriteLine("Simple linear search give index " + IndexSimpleLinearSearch);
                Console.WriteLine("Improved linear search give index " + IndexImprovedLinearSearch);
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
