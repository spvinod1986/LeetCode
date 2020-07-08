using System;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var solutions = new Solutions();

            System.Console.WriteLine(solutions.StrStrBetterOption("Hello", "ll"));
            //System.Console.WriteLine("ll".Length);

        }
    }

    class Solutions
    {
        // Problem: Reverse String
        // Write a function that reverses a string. The input string is given as an array of characters char[].
        // Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.
        // You may assume all the characters consist of printable ascii characters.
        public void ReverseString(char[] s)
        {
            if (s.Length == 0)
                return;

            int i = 0;
            int j = s.Length - 1;

            while (j > i)
            {
                var temp = s[i];
                s[i] = s[j];
                s[j] = temp;

                i++;
                j--;
            }
        }

        // Problem: Implement strStr()
        // Return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
        public int StrStr(string haystack, string needle)
        {
            if (needle.Length == 0)
                return 0;

            var haystackArray = haystack.ToCharArray();

            int i = 0;
            while (i <= (haystackArray.Length - needle.Length))
            {
                if (haystackArray[i] != needle[0])
                {
                    i++;
                    continue;
                }

                StringBuilder test = new StringBuilder();
                for (int temp = i; temp < (i + needle.Length); temp++)
                {
                    test.Append(haystackArray[temp]);
                }

                if (test.ToString() == needle)
                    return i;

                i++;
            }

            return -1;
        }

        public int StrStrBetterOption(string haystack, string needle)
        {
            for (int i = 0; ; i++)
            {
                for (int j = 0; ; j++)
                {
                    if (j == needle.Length)
                        return i;

                    if ((i + j) == haystack.Length)
                        return -1;

                    if (needle[j] != haystack[i + j])
                        break;
                }
            }
        }
    }
}
