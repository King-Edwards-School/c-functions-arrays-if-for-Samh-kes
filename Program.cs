using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;

namespace Console_Blank_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string[] str_data = new string[] { "a", "b", "c", "d", "e" }; // example of what str[] data could hold
            PrintElements(str_data); */
            //
            /*int[] int_data = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine(PrintSum(int_data)); */
            //
            /*Console.WriteLine("Choose an integer to be checked if it's prime or not: ");
            int primevalue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Prime_Checker(primevalue));*/
            //
            Console.WriteLine("What would you like the size of the array to be? ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] integers = new int[size];
            for (int i = 0; i < integers.Length; i++)
            {
                Console.WriteLine($"Add a value at poisition: {i + 1}");
                integers[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.WriteLine("What number would you like to look for");
            int finding = Convert.ToInt32(Console.ReadLine());
            SearchingNumber(integers, finding);
        }
        static void PrintElements(string[] data) // Subroutine for task 1
        {
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }
        }
        static int PrintSum(int[] int_data) // Function for task 2
        {
            int sum = 0;
            for (int i = 0; i < int_data.Length; i++)
            {
                sum = sum + int_data[i];
            }
            return sum;
        }
        public static bool Prime_Checker(int primevalue)
        {
            bool Prime = true;
            for (int i = primevalue-1; i > 1; i--)
            {
                if(primevalue % i == 0)
                {
                    Prime = false;
                }
            }
            return Prime;
        }
        public static void SearchingNumber(int[] integers, int finding) // normal searching algorithm for task 4.
        {
            bool found = false;
            for (int i = 0;i < integers.Length; i++)
            {
                if (integers[i] == finding)
                {
                    Console.WriteLine($"Number searched for is at position: {i + 1}");
                    found = true;
                }
            } 
            if (!found)
            {
                Console.WriteLine($"Number was at position -1, ie. not found.");
            }
        }
        public static void BinarySearch(int[] integers, int finding)
        {
            int position;
            bool found = false;
            while (false)
            {
                position = 
            }
           
    }
}