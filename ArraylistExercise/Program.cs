using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:



            // Create an int array and populate it with numbers 1-10  Done      
            int[] populate = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /* Create a list of type int
             
             * Name the list "evens"
             */
            List<int> Evens = new List<int>();



            // Create another list of type int, name the list "odds"
            List<int> Odds = new List<int>();

            // Iterate through the array to separate even and odd numbers
            foreach (int i in populate)
            {
                if (i % 2 == 0)
                {
                    Evens.Add(i);
                }
                else
                {
                    Odds.Add(i);
                }
            }

            // Display even numbers using a foreach loop
            Console.WriteLine("Even Numbers:");
            foreach (int even in Evens)
            {
                Console.WriteLine(even);
            }

            // Display odd numbers using a foreach loop
            Console.WriteLine("\nOdd Numbers:");
            foreach (int odd in Odds)
            {
                Console.WriteLine(odd);
            }
        }
    }
}