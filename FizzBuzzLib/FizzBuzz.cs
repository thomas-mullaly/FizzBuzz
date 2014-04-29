using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLib
{
    public class FizzBuzz
    {
        public string ProcessNumber(int number)
        {
            string processedNumber = String.Empty;

            if (number % 3 == 0)
            {
                processedNumber = "Fizz";
            }

            if (number % 5 == 0)
            {
                processedNumber += "Buzz";
            }

            if (!String.IsNullOrEmpty(processedNumber))
            {
                return processedNumber;
            }

            return number.ToString();
        }
    }
}
