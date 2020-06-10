//type of program Search algorithm programs
//programer: Benjamin Ngarambe
//Year: 2020
using System;

namespace Project01
{
    internal class Program
    {
        //Random array generator function
        public static int[] GenerateRandomArray(int size)
        {
             var stopwatch = new Stopwatch();
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
             stopwatch.Stop();
                        Console.WriteLine($"creation of array:   {stopwatch.Elapsed.TotalMilliseconds} ms");
                        stopwatch.Reset();
        }

        //Simple linear search function
        private static bool SimpleLinearSearch(int[] array, int searchedValue)
        {
             var stopwatch = new Stopwatch();//creating the stopwatch
            //assigning variables
            int a = array.Length;
            int b = searchedValue;
            for (int i = 0; i < a; i++)
            {
                if (array[i] == b)
                {
                    Console.WriteLine("using simple linear search"+ array[i]);
                }
                else
                {
                    Console.WriteLine("the value you are searching for is not in the array!!!");
                }
            }
             stopwatch.Stop();
                        Console.WriteLine($"Simple:   {stopwatch.Elapsed.TotalMilliseconds} ms");
                        stopwatch.Reset();
        }

        //Improved linear search function
        private static bool ImprovedLinearSearch(int[] array, int searchedValue)
        {
             var stopwatch = new Stopwatch();//creating the stopwatch
            int a = array.Length;
            int b = searchedValue;
            bool c = Convert.ToBoolean(b);
            for (int i = 0; i < a; i++)
            {
                if (array[i] == b)
                {
                    Console.WriteLine("Using improved linear search"+array[i]);
                }
                else
                {
                    return false;
                }
            }
            stopwatch.Stop();
                        Console.WriteLine($"Improved linear search:   {stopwatch.Elapsed.TotalMilliseconds} ms");
                        stopwatch.Reset();
            return true;
        }

        //Improved linear search with sentinel function
        private static bool ImprovedLinearSearchWithSentinel(int[] array, int searchedValue)
        {
             var stopwatch = new Stopwatch();//creating the stopwatch
            Console.Clear();
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
                Console.WriteLine("Using Improved linear search with sentinel"+array[i]);
                return true;
            }
            else
            {
                return false;
            }
             stopwatch.Stop();
                        Console.WriteLine($"Improved linear search:   {stopwatch.Elapsed.TotalMilliseconds} ms");
                        stopwatch.Reset();
        }

        //using binary search algorithm
        public static bool BinarySearch(int[] array, int searchedValue)
        {
            var stopwatch = new Stopwatch();//creating the stopwatch
            int floor = 0;
            int ceiling = array.Length - 1;

            while (floor < ceiling)
            {
                int middle = ((ceiling + floor) / 2);
                if (middle == searchedValue)
                {
                    return true;
                }
                else if (middle < searchedValue)
                {
                    floor = middle + 1;
                }
                else
                {
                    ceiling = middle - 1;
                }
            }
            stopwatch.Stop();
                        Console.WriteLine($"Improved linear search:   {stopwatch.Elapsed.TotalMilliseconds} ms");
                        stopwatch.Reset();
            return false;
        }

        private static void Main(string[] args)
        {
            //prompting the user to write the number of elements of the array
            Console.WriteLine("Enter the number of elements you want inside your array");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Loading...");

            //implementing the array to generate the random array
            GenerateRandomArray(a);
            Console.WriteLine("which NUmber inside your array are you searching for?");
            int Svalue = Convert.ToInt32(Console.ReadLine());

            SimpleLinearSearch(GenerateRandomArray(a),Svalue);
            ImprovedLinearSearch(GenerateRandomArray(a),Svalue);
            ImprovedLinearSearchWithSentinel(GenerateRandomArray(a),Svalue);
            BinarySearch(GenerateRandomArray(a),Svalue);

           // SimpleLinearSearch(theCreatedArray, searchedValue);
        }
    }
}