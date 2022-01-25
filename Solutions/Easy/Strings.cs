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
        int i = 0;
        int number = 0;

        var isNegative = false;

        while ((i < s.Length) &&
               (s[i] == ' '))
        {
            i++;
        }

        if (i != s.Length)
        {
            if (s[i] == '-')
            {
                isNegative = true;
                i++;
            }
            else if (s[i] == '+')
            {
                i++;
            }

            while ((i < s.Length) &&
                   char.IsDigit(s[i]))
            {
                var digit = s[i++] - '0';

                if ((number > int.MaxValue / 10) ||
                    ((number == int.MaxValue / 10) && (digit > int.MaxValue % 10)))
                {
                    return isNegative ? int.MinValue : int.MaxValue;
                }

                number = (10 * number) + digit;
            }
        }

        return (isNegative ? -1 : 1) * number;
    }

    // 14. LongestCommonPrefix_14
    public static string LongestCommonPrefix_14(string[] strs)
    {
        if ((strs == null) || (strs.Length == 0))
        {
            return string.Empty;
        }
        else if (strs.Length == 1)
        {
            return strs[0];
        }

        for (var i = 0; i < strs[0].Length; i++)
        {
            for (int j = 1; j < strs.Length; j++)
            {
                if ((strs[j].Length == i) ||
                    (strs[0][i] != strs[j][i]))
                {
                    return strs[0][..i];
                }
            }
        }

        return strs[0];
    }

    // 28. StrStr
    public static int StrStr_28(string haystack, string needle)
    {
        if (string.IsNullOrEmpty(needle))
        {
            return 0;
        }

        for (int i = 0; i <= haystack.Length - needle.Length; i++)
        {
            int h = i;

            foreach (var n in needle)
            {
                if (haystack[h] != n)
                {
                    break;
                }

                h++;
            }

            if (h - i == needle.Length)
            {
                return i;
            }
        }

        return -1;
    }

    // 38. Count and Say
    public static string CountAndSay_38(int n)
    {
        if (n == 1)
        {
            return "1";
        }

        var previousString = CountAndSay_38(n - 1);

        var i = 0;
        var currentCount = 1;
        var currentString = new System.Text.StringBuilder();

        while (i < previousString.Length)
        {
            if ((i < previousString.Length - 1) &&
                (previousString[i] == previousString[i + 1]))
            {
                currentCount++;
            }
            else
            {
                currentString.AppendFormat("{0}{1}", currentCount, previousString[i]);
                currentCount = 1;
            }

            i++;
        }

        return currentString.ToString();
    }

    // 125. Valid Palindrome
    public static bool IsPalindrome_125(string s)
    {
        for (int start = 0, end = s.Length - 1; start < end;)
        {
            if (!char.IsLetterOrDigit(s[start]))
            {
                start++;
            }
            else if (!char.IsLetterOrDigit(s[end]))
            {
                end--;
            }
            else if (char.ToLowerInvariant(s[start++]) != char.ToLowerInvariant(s[end--]))
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
