using System;

namespace FibonacciFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // Introduction Text 
                Console.WriteLine("Faboulous Fibonacci Finder");
                Console.Write("How many places do you want to find?");
                // user input to determine number  of places to find
                int places = Int32.Parse(Console.ReadLine());
                Fibonacci(places);
            }

        }
        /// <summary>
        /// Function to determine Fibbonaci sequence
        /// </summary>
        /// <param name="length"> User input used to determine places printed to console</param>
        static void Fibonacci(int length)
        {
            int a = 0;
            int b = 1;
            int c = 0;
            Console.Write("{0} {1} ", a, b);
            for (int i = 2; i < length; i++)
            {
                c = a + b;
                Console.Write("{0} ", c);
                a = b;
                b = c;
            }
        }

    }
}
