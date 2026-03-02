using System;
using System.Text;

namespace Text
{
    /// <summary>
    /// Provides string operations.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Returns True if a string is a palindrome, False otherwise. Ignores case, spaces, and punctuation.
        /// </summary>
        /// <param name="s">The string to check.</param>
        /// <returns>True if the string is a palindrome, False otherwise.</returns>
        public static bool IsPalindrome(string s)
        {
            if (s == null)
                return false;

            var sb = new StringBuilder();
            foreach (char c in s)
            {
                if (char.IsLetterOrDigit(c))
                    sb.Append(char.ToLower(c));
            }
            string cleaned = sb.ToString();
            int left = 0, right = cleaned.Length - 1;
            while (left < right)
            {
                if (cleaned[left] != cleaned[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }
    }

    public class Class1
    {

    }
}
