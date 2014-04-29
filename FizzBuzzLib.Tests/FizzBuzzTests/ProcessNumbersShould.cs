using System;
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
            var range = new FizzBuzzRange
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

        [Test]
        public void ThrowAnExceptionIfTheRangeIsInvalid()
        {
            var range = new FizzBuzzRange
            {
                Start = 12,
                End = 5
            };

            Assert.Throws<ArgumentException>(() => _fizzBuzz.ProcessNumbers(range));
        }

        public class FooFizzBuzzRule : IFizzBuzzRule
        {
            public string Apply(int number)
            {
                return number % 3 == 0 ? "Foo" : String.Empty;
            }
        }

        [Test]
        public void HonorAnyCustomFizzBuzzRules()
        {
            var range = new FizzBuzzRange
            {
                Start = 1,
                End = 6
            };

            var expectedResult = new List<string> { "1", "2", "Foo", "4", "5" };
            var rules = new List<IFizzBuzzRule> { new FooFizzBuzzRule() };

            var fizzBuzz = new FizzBuzz(rules);

            IList<string> result = fizzBuzz.ProcessNumbers(range);

            Assert.AreEqual(expectedResult.Count, result.Count);
            for (int i = 0; i < expectedResult.Count; ++i)
            {
                Assert.AreEqual(expectedResult[i], result[i]);
            }
        }
    }
}