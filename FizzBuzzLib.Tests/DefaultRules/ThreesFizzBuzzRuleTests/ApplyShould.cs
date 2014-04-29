using System;
using FizzBuzzLib.DefaultRules;
using NUnit.Framework;

namespace FizzBuzzLib.Tests.DefaultRules.ThreesFizzBuzzRuleTests
{
    [TestFixture]
    public class ApplyShould
    {
        private ThreesFizzBuzzRule _threesFizzBuzzRule;

        [SetUp]
        public void Setup()
        {
            _threesFizzBuzzRule = new ThreesFizzBuzzRule();
        }

        [Test]
        public void ReturnAnEmptyStringIfTheNumberIsNotDivisibleByThree()
        {
            var result = _threesFizzBuzzRule.Apply(1);

            Assert.AreEqual(String.Empty, result);
        }

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        public void ReturnFizzIfTheNumberIsDivisibleByThree(int number)
        {
            var result = _threesFizzBuzzRule.Apply(number);

            Assert.AreEqual("Fizz", result);
        }
    }
}