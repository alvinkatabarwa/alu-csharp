using System;

namespace Text
{
    public class Str
    {
        /// <summary>
        /// Determines the number of words in a camelCase string.
        /// </summary>
        /// <param name="s">The camelCase string.</param>
        /// <returns>Number of words in the string.</returns>
        public static int CamelCase(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            int wordCount = 1; // Start with 1 for the first word
            
            // Count capital letters in the string, each denotes a new word
            foreach (char c in s)
            {
                if (char.IsUpper(c))
                {
                    wordCount++;
                }
            }

            return wordCount;
        }
    }
}
