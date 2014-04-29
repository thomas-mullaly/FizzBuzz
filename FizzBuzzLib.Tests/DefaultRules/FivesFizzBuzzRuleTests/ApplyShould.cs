using System;
using FizzBuzzLib.DefaultRules;
using NUnit.Framework;

namespace FizzBuzzLib.Tests.DefaultRules.FivesFizzBuzzRuleTests
{
    [TestFixture]
    public class ApplyShould
    {
        private FivesFizzBuzzRule _fivesFizzBuzzRule;

        [SetUp]
        public void Setup()
        {
            _fivesFizzBuzzRule = new FivesFizzBuzzRule();
        }

        [Test]
        public void ReturnAnEmptyStringIfTheNumberIsNotDivisibleByFive()
        {
            var result = _fivesFizzBuzzRule.Apply(3);

            Assert.AreEqual(String.Empty, result);
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(15)]
        public void ReturnBuzzIfTheNumberIsDivisibleByFive(int number)
        {
            var result = _fivesFizzBuzzRule.Apply(number);

            Assert.AreEqual("Buzz", result);
        }
    }
}