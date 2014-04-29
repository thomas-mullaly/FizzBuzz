using System;
using FizzBuzzLib;

namespace FizzBuzzApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            for (int i = 1; i <= 100; ++i)
            {
                Console.WriteLine(fizzBuzz.ProcessNumber(i));
            }

            Console.Read();
        }
    }
}
