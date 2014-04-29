using System;
using FizzBuzzLib.DefaultRules;
using NUnit.Framework;

namespace FizzBuzzLib.Tests.DefaultRules.DefaultFizzBuzzRuleTests
{
    [TestFixture]
    public class ApplyShould
    {
        private DefaultFizzBuzzRule _defaultFizzBuzzRule;

        [SetUp]
        public void Setup()
        {
            _defaultFizzBuzzRule = new DefaultFizzBuzzRule();
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(7)]
        public void ReturnTheNumberIfItIsNotDivisibleByThreeOrFive(int number)
        {
            var result = _defaultFizzBuzzRule.Apply(number);

            Assert.AreEqual(number.ToString(), result);
        }

        [TestCase(3)]
        [TestCase(5)]
        [TestCase(15)]
        public void ReturnAnEmptyStringIfTheNumberIsDivisibleByThreeOrFive(int number)
        {
            var result = _defaultFizzBuzzRule.Apply(number);

            Assert.AreEqual(String.Empty, result);
        }
    }
}