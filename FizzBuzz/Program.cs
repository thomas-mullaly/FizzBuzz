using System;
using System.Collections.Generic;
using FizzBuzzLib;

namespace FizzBuzzApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            FizzBuzzRange range = new FizzBuzzRange
            {
                Start = 1,
                End = 101
            };

            IList<string> result = fizzBuzz.ProcessNumbers(range);

            Console.WriteLine(String.Join(Environment.NewLine, result));

            Console.Read();
        }
    }
}
