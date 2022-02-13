using System;

namespace LeetCode.Solutions.Easy;

public static class SortingSearching
{
    private static int bv;

    // 278. FirstBadVersion
    public static int FirstBadVersion_278(int n, int badVersion)
    {
        bv = badVersion;

        int middle,
            left = 1,
            right = n;

        while (left < right)
        {
            middle = left + ((right - left) / 2);

            if (IsBadVersion(middle))
            {
                right = middle;
            }
            else
            {
                left = middle + 1;
            }
        }

        return left;
    }

    private static bool IsBadVersion(int v)
    {
        return (v >= bv);
    }
}
