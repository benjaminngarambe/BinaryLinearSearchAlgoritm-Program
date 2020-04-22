using System;

namespace Project01
{
    internal class Program
    {
        //Random array generator function
        public static int[] GenerateRandomArray(int size)
        {
            //variable initialisation
            int Min = 0;
            int Max = 20;
            int[] test2 = new int[size];

            //generating random numbers to use inside the array
            Random randNum = new Random();

            //for loop to generate arrays with
            for (int i = 0; i < test2.Length; i++)
            {
                test2[i] = randNum.Next(Min, Max);
            }
            for (int k = 0; k < test2.Length; k++)
            {
                Console.WriteLine("\n" + test2[k]);
            }

            return test2;
        }

        //Simple linear search function
        private static bool SimpleLinearSearch(int[] array, int searchedValue)
        {
            //assigning variables
            int a = array.Length;
            int b = searchedValue;
            for (int i = 0; i < a; i++)
            {
                if (array[i] == b)
                {
                    Console.WriteLine(i);
                    return true;
                }
            }
            return true;
        }

        //Improved linear search function
        private static bool ImprovedLinearSearch(int[] array, int searchedValue)
        {
            int a = array.Length;
            int b = searchedValue;
            bool c = Convert.ToBoolean(b);
            for (int i = 0; i < a; i++)
            {
                if (array[i] == b)
                {
                    Console.WriteLine(array[i]);
                }
                else
                { 
                    return false;
                }
            }
            return true;
        } 

        //Improved linear search with sentinel function
        private static bool ImprovedLinearSearchWithSentinel(int[] array, int searchedValue)
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
            if (array[i] < a && last == array[i])
            {
                Console.WriteLine(array[i]);
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void Main(string[] args)
        {
            //prompting the user to write the number of elements of the array
            Console.WriteLine("Enter the number of elements you want inside your array");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Loading...");

            //implementing the array to generate the random array
            GenerateRandomArray(a);
            int theCreatedArray = a;
            Console.WriteLine("which NUmber inside your array are you searching for?");
            int searchedValue = Convert.ToInt32(Console.ReadLine());

           // ImprovedLinearSearch(theCreatedArray, searchedValue);
        }
    }
}