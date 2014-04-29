using System.Collections.Generic;
using NUnit.Framework;

namespace FizzBuzzLib.Tests.FizzBuzzTests
{
    [TestFixture]
    public class ProcessNumbersShould
    {
        private FizzBuzz _fizzBuzz;

        [SetUp]
        public void Setup()
        {
            _fizzBuzz = new FizzBuzz();
        }

        [TestCase(1, 10, new [] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz" })]
        [TestCase(15, 20, new [] { "FizzBuzz", "16", "17", "Fizz", "19"})]
        public void ReturnTheExpectedList(int start, int end, IList<string> expectedResults)
        {
            FizzBuzzRange range = new FizzBuzzRange
            {
                Start = start,
                End = end
            };

            IList<string> result = _fizzBuzz.ProcessNumbers(range);

            Assert.AreEqual(expectedResults.Count, result.Count);
            for (int i = 0; i < expectedResults.Count; ++i)
            {
                Assert.AreEqual(expectedResults[i], result[i]);
            }
        }
    }
}