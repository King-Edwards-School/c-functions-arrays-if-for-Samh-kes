using System.Collections.Specialized;

namespace Console_Blank_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string[] str_data = new string[] { "a", "b", "c", "d", "e" }; // example of what str[] data could hold
            int[] int_data = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            PrintElements(str_data);
            Console.WriteLine(PrintSum(int_data));
            Console.WriteLine("Choose an integer to be checked if it's prime or not: ");
            int primevalue = Convert.ToInt32(Console.ReadLine());
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
        static bool Prime_Checker(int primevalue)
        {
            bool Prime = false;
            int count = primevalue;
            for (int i = count; count > 0; i--)
            {
                if (count % 2)
            }
        }
    }
}