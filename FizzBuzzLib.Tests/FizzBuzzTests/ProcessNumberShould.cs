using NUnit.Framework;

namespace FizzBuzzLib.Tests.FizzBuzzTests
{
    [TestFixture]
    public class ProcessNumberShould
    {
        private FizzBuzz _fizzBuzz;

        [SetUp]
        public void Setup()
        {
            _fizzBuzz = new FizzBuzz();
        }

        [Test]
        public void ReturnOneIfPassedOne()
        {
            var result = _fizzBuzz.ProcessNumber(1);

            Assert.AreEqual("1", result);
        }

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        public void ReturnFizzIfTheNumberIsDivisibleByThree(int number)
        {
            var result = _fizzBuzz.ProcessNumber(number);

            Assert.AreEqual("Fizz", result);
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        public void ReturnBuzzIfTheNumberIsDivisibleByFive(int number)
        {
            var result = _fizzBuzz.ProcessNumber(number);

            Assert.AreEqual("Buzz", result);
        }

        [TestCase(15)]
        public void ReturnFizzBuzzIfTheNumberIsDivisibleByThreeAndFive(int number)
        {
            var result = _fizzBuzz.ProcessNumber(number);

            Assert.AreEqual("FizzBuzz", result);
        }
    }
}