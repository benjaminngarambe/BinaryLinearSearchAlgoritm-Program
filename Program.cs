using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01
{
    class Program
    {
        public static int[] GenerateRandomArray(int size)
        {
            Random random = new Random();
            int Min = 0;
            int Max = 20;
            int[] size = new int[1];
            for (int i = 0; i < size.Length; i++)
            {
                size[i] = random.Next(Min, Max);
            }
        }
        static bool SimpleLinearSearch(int[] array, int searchedValue)
        {
            int result = -1;
            int a = array.Length;
            int b = searchedValue;
            for (int i = 0; i < a; i++)
            {
                if (array[i] = b)
                {
                    Console.WriteLine(i);
                    return result;
                }
            }
        }
        static bool ImprovedLinearSearch(int[] array, int searchedValue)
        {
            int a = array.Length;
            int b = searchedValue;
            for (int i = 0; i < a; i++)
            {
                if (array[i] == b)
                {
                    return i;
                }
                else
                {
                    return -1;
                }
            }
        }
        static bool ImprovedLinearSearchWithSentinel(int[] array, int searchedValue)
        {
            int a = array.Length;
            int b = searchedValue;
            int n = 1;
            int last = array[n - 1];
            array[n - 1] = b;
            int i = 0;
            while (array[i] != b)
            {
                i++;
            }
            array[n - 1] = last;
            if (i < a || last = i)
            {
                return i;
            }
            else
            {
                return -1;
            }
        }
        static void Main(string[] args)
        {
            int[] arr = {1, 2, 3, 4, 5, 6, 7 };
            int n = arr.Length;
            int x = 5;
            ImprovedLinearSearchWithSentinel(arr, x);
        }
    }
}