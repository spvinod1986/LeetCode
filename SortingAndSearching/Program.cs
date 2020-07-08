using System;

namespace SortingAndSearching
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            solution.Merge(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3);
        }
    }

    class Solution
    {
        private bool IsBadVersion(int n)
        {
            if (n >= 1702766719)
                return true;

            return false;
        }


        // You are a product manager and currently leading a team to develop a new product. Unfortunately, the latest version of your product fails the quality check. Since each version is developed based on the previous version, all the versions after a bad version are also bad.
        // Suppose you have n versions [1, 2, ..., n] and you want to find out the first bad one, which causes all the following ones to be bad.
        // You are given an API bool isBadVersion(version) which will return whether version is bad. Implement a function to find the first bad version. You should minimize the number of calls to the API.
        public int FirstBadVersion(int n)
        {
            return FirstBadVersion(0, n);
        }

        private int FirstBadVersion(int start, int end)
        {
            if (start == end)
                return IsBadVersion(start) ? start : -1;

            if (start > end)
                return -1;

            int middle = start + ((end - start) / 2);

            if (!IsBadVersion(middle))
            {
                return FirstBadVersion(middle + 1, end);
            }
            else
            {
                return FirstBadVersion(start, middle);
            }
        }

        // Problem: Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as one sorted array
        // The number of elements initialized in nums1 and nums2 are m and n respectively.
        // You may assume that nums1 has enough space (size that is equal to m + n) to hold additional elements from nums2.
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var i = m - 1;
            var j = n - 1;
            var k = (m + n) - 1;

            while (i >= 0 && j >= 0)
            {
                System.Console.WriteLine($"i is {i} and nums1[{i}] is {nums1[i]}");
                System.Console.WriteLine($"j is {j} and nums2[{j}] is {nums2[j]}");
                if (nums1[i] > nums2[j])
                    nums1[k--] = nums1[i--];
                else
                    nums1[k--] = nums2[j--];
            }

            while (j >= 0)
            {
                nums1[k--] = nums2[j--];
            }
        }
    }
}
