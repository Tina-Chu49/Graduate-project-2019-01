using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! 12091029");
            Console.WriteLine(alphaNumericSort("Hello World! 12091029"));
            Console.WriteLine(alphaNumericSort("Sorting0123456789"));             // ginortS0246813579
            Console.WriteLine(alphaNumericSort("foobar1237348421"));              // abfoor2244811337
            Console.WriteLine(alphaNumericSort("789765445whjdbjwhwfbs977865"));   // bbdfhhjjswww446688555777799

            Console.ReadKey();
        }

        public static string alphaNumericSort(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            return "";
        }
    }
}