using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

        }

    }

    class Solutions
    {
        // Problem: Remove duplicates from Sorted Array
        // Given a sorted array nums, remove the duplicates in-place such that each element appear only once and return the new length.
        // Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
                throw new InvalidOperationException("nums array is empty");

            int i = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                    continue;

                nums[++i] = nums[j];
            }
            return ++i;
        }

        // Problem: Rotate Array
        // Given an array, rotate the array to the right by k steps, where k is non-negative.
        public void Rotate(int[] nums, int k)
        {
            if (nums.Length == 0 || nums.Length == 1)
                return;

            if (k > nums.Length)
                k = k - nums.Length;

            Reverse(nums, 0, nums.Length - 1);
            Reverse(nums, 0, k - 1);
            Reverse(nums, k, nums.Length - 1);
        }

        private void Reverse(int[] nums, int i, int j)
        {
            while (i < j)
            {
                Swap(nums, i, j);
                i++;
                j--;
            }
        }

        private void Swap(int[] nums, int i, int j)
        {
            var temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
