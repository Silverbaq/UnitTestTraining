using System;
using System.Linq;

namespace UnitTestTraining.Exercise3
{
    public class MyStringUtil
    {
        public static string Reverse(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static bool IsPalindrome(string input)
        {
            return input == Reverse(input);
        }

        public static int CountOccurrences(string input, char target)
        {
            int count = 0;
            foreach (char c in input)
            {
                if (c == target)
                {
                    count++;
                }
            }
            return count;
        }

        public static string RemoveWhitespace(string input)
        {
            return new string(input.Where(c => !Char.IsWhiteSpace(c)).ToArray());
        }
    }
}