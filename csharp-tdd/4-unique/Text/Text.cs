using System;
using System.Collections.Generic;

namespace Text
{
    public class Str
    {
        /// <summary>
        /// Finds the index of the first non-repeating character in a string.
        /// </summary>
        /// <param name="s">The input string.</param>
        /// <returns>Index of the first non-repeating character, or -1 if there are no non-repeating characters.</returns>
        public static int UniqueChar(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return -1;
            }

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            // Count the occurrence of each character in the string
            foreach (char c in s)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            // Find the first character with a count of 1
            for (int i = 0; i < s.Length; i++)
            {
                if (charCount[s[i]] == 1)
                {
                    return i;
                }
            }

            return -1; // No non-repeating character found
        }
    }
}
