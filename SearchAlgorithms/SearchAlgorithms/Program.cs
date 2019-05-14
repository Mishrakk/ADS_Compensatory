using System;

namespace SearchAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]{ 3,8,11,17,5,8 };
            int SearchValue = 7;
            int SearchValueIndex = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == SearchValue)
                {
                    SearchValueIndex = i;
                }
            }

            Console.WriteLine("We are looking for number " + SearchValue);
            
            if (SearchValueIndex == -1)
            {
                Console.WriteLine("Value was not found");
            }
            else
            {
                Console.WriteLine("Number found at index " + SearchValueIndex);
            }
        }
    }
}
