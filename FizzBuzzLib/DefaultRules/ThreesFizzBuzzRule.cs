using System;

namespace FizzBuzzLib.DefaultRules
{
    public class ThreesFizzBuzzRule : IFizzBuzzRule
    {
        public string Apply(int number)
        {
            return number % 3 == 0 ? "Fizz" : String.Empty;
        }
    }
}