using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzKata;
using NUnit.Framework;

namespace FizzBuzzKataTests
{
    [TestFixture]
    public class FizzBuzzTest
    {
        private FizzBuzz fizzBuzz;

        [SetUp]
        public void SetUp()
        {
            fizzBuzz = new FizzBuzz();
        }

        [Test]
        public void GivenAnInputOf1TheFunctionReturns1()
        {
            var result = fizzBuzz.GetFizzBuzz(1);
            Assert.AreEqual("1", result);
        }

        [Test]
        public void GivenAnInputOf2TheFunctionReturns2()
        {
            var result = fizzBuzz.GetFizzBuzz(2);
            Assert.AreEqual("2", result);
        }

        [Test]
        public void GivenAnInputOf3TheFunctionReturnsFizz()
        {
            var result = fizzBuzz.GetFizzBuzz(3);
            Assert.AreEqual("Fizz", result);
        }

        [Test]
        public void GivenAnInputOf5TheFunctionReturnsBuzz()
        {
            var result = fizzBuzz.GetFizzBuzz(5);
            Assert.AreEqual("Buzz", result);
        }

        [Test]
        public void GivenAnInputOf6TheFunctionReturnsFizz()
        {
            var result = fizzBuzz.GetFizzBuzz(6);
            Assert.AreEqual("Fizz", result);
        }

        [Test]
        public void GivenAnInputOf10TheFunctionReturnsBuzz()
        {
            var result = fizzBuzz.GetFizzBuzz(10);
            Assert.AreEqual("Buzz", result);
        }

        [Test]
        public void GivenAnInputOf15TheFunctionReturnsFizzBuzz()
        {
            var result = fizzBuzz.GetFizzBuzz(15);
            Assert.AreEqual("FizzBuzz", result);
        }

        [Test]
        public void GivenAnInputOf30TheFunctionReturnsFizzBuzz()
        {
            var result = fizzBuzz.GetFizzBuzz(30);
            Assert.AreEqual("FizzBuzz", result);
        }

    }
}
