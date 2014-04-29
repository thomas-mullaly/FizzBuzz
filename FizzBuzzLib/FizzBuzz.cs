﻿using System;
using System.Collections.Generic;
using FizzBuzzLib.DefaultRules;

namespace FizzBuzzLib
{
    public class FizzBuzz
    {
        private readonly IList<IFizzBuzzRule> _rules;

        public FizzBuzz()
        {
            _rules = new List<IFizzBuzzRule> {new ThreesFizzBuzzRule(), new FivesFizzBuzzRule()};
        }

        public IList<string> ProcessNumbers(FizzBuzzRange range)
        {
            var processedNumbers = new List<string>();

            for (int i = range.Start; i < range.End; ++i)
            {
                string processedNumber = String.Empty;

                foreach (var rule in _rules)
                {
                    processedNumber += rule.Apply(i);
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
