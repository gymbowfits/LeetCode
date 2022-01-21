using System;
using System.Collections.Generic;

namespace LeetCode.Solutions.Easy;

public static class Strings
{
    // 7. Reverse Integer
    public static int Reverse_7(int x)
    {
        try
        {
            return Reverse_7_Recursive(x);
        }
        catch (OverflowException)
        {
            return 0;
        }
    }

    private static int Reverse_7_Recursive(int x, int result = 0)
    {
        if (x == 0)
        {
            return result;
        }

        var remainder = x % 10;

        return Reverse_7_Recursive(x / 10, checked(result * 10) + remainder);
    }

    // 8. String to Integer (atoi)
    public static int MyAtoi_8(string s)
    {
        var match = System.Text.RegularExpressions.Regex.Match(s, "^(?:[ ]*)([+-]{0,1})(\\d*)");

        if (match.Success &&
            (!string.IsNullOrEmpty(match.Groups[2].Value)))
        {
            var isNegative = match.Groups[1].Value == "-";
            var numberString = match.Groups[1].Value + match.Groups[2].Value;

            int number;

            try
            {
                number = Convert.ToInt32(numberString);
            }
            catch (OverflowException)
            {
                if (isNegative)
                {
                    number = int.MinValue;
                }
                else
                {
                    number = int.MaxValue;
                }
            }

            return number;
        }

        return 0;
    }

    // 125. Valid Palindrome
    public static bool IsPalindrome_125(string s)
    {
        var alphanumericString = System.Text.RegularExpressions.Regex.Replace(s.ToLowerInvariant(), "[^a-z0-9]+", string.Empty);

        var end = alphanumericString.Length - 1;

        for (var start = 0; start < end; start++, end--)
        {
            if (alphanumericString[start] != alphanumericString[end])
            {
                return false;
            }
        }

        return true;
    }

    // 242. Valid Anagram
    public static bool IsAnagram_242(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        var sFrequencies = IsAnagram_242_GetCharacterFrequencies(s);
        var tFrequencies = IsAnagram_242_GetCharacterFrequencies(t);

        foreach (var key in sFrequencies.Keys)
        {
            if (!tFrequencies.ContainsKey(key))
            {
                return false;
            }

            if (sFrequencies[key] != tFrequencies[key])
            {
                return false;
            }
        }

        return true;
    }

    private static Dictionary<char, int> IsAnagram_242_GetCharacterFrequencies(string s)
    {
        var frequencies = new Dictionary<char, int>();

        foreach (var c in s)
        {
            if (!frequencies.ContainsKey(c))
            {
                frequencies[c] = 1;
            }
            else
            {
                ++frequencies[c];
            }
        }

        return frequencies;
    }

    // 344. Reverse String
    public static void ReverseString_344(char[] s)
    {
        if (s.Length > 1)
        {
            var end = s.Length - 1;
            for (var start = 0; start < end; start++)
            {
                var t = s[start];
                s[start] = s[end];
                s[end--] = t;
            }
        }
    }

    // 387. First Unique Character in a String
    public static int FirstUniqChar_387(string s)
    {
        var counts = new int[26];

        for (var i = 0; i < s.Length; i++)
        {
            counts[s[i] - 'a']++;
        }

        for (var i = 0; i < s.Length; i++)
        {

            if (counts[s[i] - 'a'] == 1)
            {
                return i;
            }
        }

        return -1;
    }
}
