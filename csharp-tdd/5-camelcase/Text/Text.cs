namespace Text
{
    /// <summary>
    /// Provides string operations.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Returns the number of words in a camelCase string.
        /// Each word begins with a capital letter except the first word.
        /// </summary>
        /// <param name="s">The camelCase string.</param>
        /// <returns>The number of words in the string.</returns>
        public static int CamelCase(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;
            int count = 1;
            foreach (char c in s)
            {
                if (char.IsUpper(c))
                    count++;
            }
            return count;
        }
    }
}