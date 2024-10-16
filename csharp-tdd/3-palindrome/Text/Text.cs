using System;
using System.Text.RegularExpressions;

namespace Text
{
    public class Str
    {
        /// <summary>
        /// Checks if a string is a palindrome, ignoring spaces, punctuation, and case.
        /// </summary>
        /// <param name="s">The input string.</param>
        /// <returns>True if the string is a palindrome, False otherwise.</returns>
        public static bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return true;
            }

            // Remove non-alphanumeric characters and convert to lowercase
            string cleaned = Regex.Replace(s, @"[^a-zA-Z0-9]", "").ToLower();

            // Check if the cleaned string is equal to its reverse
            char[] charArray = cleaned.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);

            return cleaned == reversed;
        }
    }
}
