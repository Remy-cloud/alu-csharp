using System.Collections.Generic;

namespace Text
{
    /// <summary>
    /// Provides string operations.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Returns the index of the first non-repeating character in a string, or -1 if none exists.
        /// </summary>
        /// <param name="s">The input string (only lowercase letters, no spaces or special characters).</param>
        /// <returns>The index of the first non-repeating character, or -1 if none exists.</returns>
        public static int UniqueChar(string s)
        {
            if (string.IsNullOrEmpty(s))
                return -1;

            var counts = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (counts.ContainsKey(c))
                    counts[c]++;
                else
                    counts[c] = 1;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (counts[s[i]] == 1)
                    return i;
            }
            return -1;
        }
    }

    public class Class1
    {

    }
}
