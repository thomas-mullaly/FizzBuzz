using System;

namespace FizzBuzzLib.DefaultRules
{
    public class DefaultFizzBuzzRule : IFizzBuzzRule
    {
        public string Apply(int number)
        {
            if (number % 3 != 0 && number % 5 != 0)
            {
                return number.ToString();
            }

            return String.Empty;
        }
    }
}