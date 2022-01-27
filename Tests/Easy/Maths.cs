using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace LeetCode.Tests.Easy;

public class Maths
{
    [Test]
    [TestCase(0, false)]
    [TestCase(1, true)]
    [TestCase(5, false)]
    [TestCase(6, false)]
    [TestCase(9, true)]
    [TestCase(27, true)]
    [TestCase(81, true)]
    public void IsPowerOfThree_326(int n, bool expectedResult)
    {
        var result = Solutions.Easy.Maths.IsPowerOfThree_326(n);

        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    [TestCase(5, new string[] { "1", "2", "Fizz", "4", "Buzz" })]
    [TestCase(15, new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" })]
    public void FizzBuzz_412(int n, IList<string> expectedResult)
    {
        var result = Solutions.Easy.Maths.FizzBuzz_412(n);

        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
