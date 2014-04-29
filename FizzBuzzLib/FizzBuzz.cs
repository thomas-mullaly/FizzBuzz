using System;
using System.Collections.Generic;

namespace FizzBuzzLib
{
    public class FizzBuzz
    {
        public IList<string> ProcessNumbers(FizzBuzzRange range)
        {
            var processedNumbers = new List<string>();

            for (int i = range.Start; i < range.End; ++i)
            {
                string processedNumber = String.Empty;

                if (i % 3 == 0)
                {
                    processedNumber = "Fizz";
                }

                if (i % 5 == 0)
                {
                    processedNumber += "Buzz";
                }

                if (String.IsNullOrEmpty(processedNumber))
                {
                    processedNumber = i.ToString();
                }

                processedNumbers.Add(processedNumber);
            }

            return processedNumbers;
        }
    }
}
