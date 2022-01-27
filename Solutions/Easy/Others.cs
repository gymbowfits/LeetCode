using System;

namespace LeetCode.Solutions.Easy;

public static class Others
{
    // 171. Excel Sheet Column Number
    public static int TitleToNumber_171(string columnTitle)
    {
        if (string.IsNullOrEmpty(columnTitle))
        {
            return 0;
        }

        var number = 0;

        foreach (var c in columnTitle)
        {
            number *= 26;
            number += c - 'A' + 1;
        }

        return number;
    }

    // 190. ReverseBits
    public static uint ReverseBits_190(uint n)
    {
        var result = 0u;

        for (var i = 0; i <= 31; i++)
        {
            result <<= 1;

            result |= (n & 1u);

            n >>= 1;
        }

        return result;
    }

    // 191. HammingWeight
    public static int HammingWeight_191(uint n)
    {
        var result = 0u;

        for (int i = 0; i <= 31; i++)
        {
            result += n & 1u;
            n >>= 1;
        }

        return (int)result;
    }

    // 461. HammingDistance
    public static int HammingDistance_461(int x, int y)
    {
        var z = x ^ y;

        return HammingWeight_191((uint)z);
    }
}
