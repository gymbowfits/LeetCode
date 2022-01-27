using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solutions.Easy;

public static class Maths
{
    // 326. Power of Three
    public static bool IsPowerOfThree_326(int n)
    {
        if (n == 1)
        {
            return true;
        }
        else if ((n == 0) || (n % 3 != 0))
        {
            return false;
        }

        return IsPowerOfThree_326(n / 3);
    }

    // 412. Fizz Buzz
    public static IList<string> FizzBuzz_412(int n)
    {
        var result = new List<string>();

        for (int i = 1; i <= n; i++)
        {
            var s = new StringBuilder();

            if (i % 3 == 0)
            {
                s.Append("Fizz");
            }

            if (i % 5 == 0)
            {
                s.Append("Buzz");
            }

            if (s.Length == 0)
            {
                s.Append(i);
            }

            result.Add(s.ToString());
        }

        return result;
    }
}
