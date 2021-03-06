﻿using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TransCosMosTest
{
    [TestClass]
    public class UnitTest
    {
        private const string ExpectedFizz = "Fizz";
        private const string ExpectedBuzz = "Buzz";
        private const string ExpectedFizzBuzz = "Fizz Buzz";
        private const string ExpectedError = "Error";

        //Tests for multiples of 3 return Fizz
        [TestMethod]
        public void TestFizz()
        {
            Assert.AreEqual(ExpectedFizz, TransCosMos.Program.FizzBuzz(3));
            Assert.AreEqual(ExpectedFizz, TransCosMos.Program.FizzBuzz(6));
            Assert.AreEqual(ExpectedFizz, TransCosMos.Program.FizzBuzz(33));
        }

        //Tests for multiples of 5 return Buzz
        [TestMethod]
        public void TestBuzz()
        {
            Assert.AreEqual(ExpectedBuzz, TransCosMos.Program.FizzBuzz(5));
            Assert.AreEqual(ExpectedBuzz, TransCosMos.Program.FizzBuzz(10));
            Assert.AreEqual(ExpectedBuzz, TransCosMos.Program.FizzBuzz(35));
        }

        //Tests for multiples of 5 and 3 return Fizz Buzz
        [TestMethod]
        public void TestFizzBuzz()
        {
            Assert.AreEqual(ExpectedFizzBuzz, TransCosMos.Program.FizzBuzz(15));
            Assert.AreEqual(ExpectedFizzBuzz, TransCosMos.Program.FizzBuzz(30));
            Assert.AreEqual(ExpectedFizzBuzz, TransCosMos.Program.FizzBuzz(45));
        }

        //Tests for non multiples of 5 and 3 return just the number
        [TestMethod]
        public void TestNumber()
        {
            Assert.AreEqual("2", TransCosMos.Program.FizzBuzz(2));
            Assert.AreEqual("4", TransCosMos.Program.FizzBuzz(4));
            Assert.AreEqual("31", TransCosMos.Program.FizzBuzz(31));
        }

        //Tests for error case
        [TestMethod]
        public void TestError()
        {
            Assert.AreEqual(ExpectedError, TransCosMos.Program.FizzBuzz(0));
            Assert.AreEqual(ExpectedError, TransCosMos.Program.FizzBuzz(103));
            Assert.AreEqual(ExpectedError, TransCosMos.Program.FizzBuzz(-5));
        }
    }
}
