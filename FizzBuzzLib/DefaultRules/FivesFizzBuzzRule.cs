using System;

namespace FizzBuzzLib.DefaultRules
{
    public class FivesFizzBuzzRule : IFizzBuzzRule
    {
        public string Apply(int number)
        {
            return number % 5 == 0 ? "Buzz" : String.Empty;
        }
    }
}