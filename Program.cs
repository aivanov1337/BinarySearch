using System;

namespace BinarySearch
{
    class Program
    {
        public static int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

        public static object BinarySearch(int[] input, int key)
        {
            int min = 0;
            int max = input.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == input[mid])
                {
                    return ++mid;
                }
                else if (key < input[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return "Element not found.";
        }


        static void Main(string[] args)
        {
            Console.WriteLine(BinarySearch(array, 19));
            Console.ReadLine();
        }
    }
}
