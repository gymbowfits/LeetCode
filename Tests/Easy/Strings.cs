using System;
using NUnit.Framework;

namespace LeetCode.Tests.Easy;

public class Strings
{
    [Test]
    [TestCase(123, 321)]
    [TestCase(-123, -321)]
    [TestCase(120, 21)]
    public void Reverse_7(int x, int expectedResult)
    {
        var result = Solutions.Easy.Strings.Reverse_7(x);

        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    [TestCase("42", 42)]
    [TestCase("    -42", -42)]
    [TestCase("4193 with words", 4193)]
    [TestCase("2147483648", 2147483647)]
    [TestCase("-0", 0)]
    [TestCase("words and 987", 0)]
    public void MyAtoi_8(string s, int expectedResult)
    {
        var result = Solutions.Easy.Strings.MyAtoi_8(s);

        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    [TestCase("A man, a plan, a canal: Panama", true)]
    [TestCase("race a car", false)]
    [TestCase(" ", true)]
    [TestCase("", true)]
    public void IsPalindrome_125(string s, bool expectedResult)
    {
        var result = Solutions.Easy.Strings.IsPalindrome_125(s);

        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    [TestCase("anagram", "nagaram", true)]
    [TestCase("rat", "car", false)]
    public void IsAnagram_242(string s, string t, bool expectedResult)
    {
        var result = Solutions.Easy.Strings.IsAnagram_242(s, t);

        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    [TestCase(new char[] { 'h', 'e', 'l', 'l', 'o' }, new char[] { 'o', 'l', 'l', 'e', 'h' })]
    public void ReverseString_344(char[] s, char[] expectedString)
    {
        Solutions.Easy.Strings.ReverseString_344(s);

        Assert.That(s, Is.EqualTo(expectedString));
    }

    [Test]
    [TestCase("leetcode", 0)]
    [TestCase("loveleetcode", 2)]
    [TestCase("aabb", -1)]
    public void FirstUniqChar_387(string s, int expectedResult)
    {
        var result = Solutions.Easy.Strings.FirstUniqChar_387(s);

        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
