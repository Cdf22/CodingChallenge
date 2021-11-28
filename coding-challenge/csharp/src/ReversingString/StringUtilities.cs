using System;

namespace CodingChallenge.ReversingString
{
    /// <summary>
    /// Utilities for manipulating strings
    /// </summary>
    public class StringUtilities
    {
        /// <summary>
        /// Reverses the string parameter
        /// </summary>
        /// <param name="s"></param>
        /// <returns>Reverse of the input</returns>
        public static string Reverse(string s)
        {
            if(s == null)
            {
                throw new ArgumentNullException();
            }

            if(s == string.Empty)
            {
                throw new ArgumentException();
            }

            var inputAsCharArray = s.ToCharArray();
            var inputReversed = String.Empty;

            for (int i = inputAsCharArray.Length - 1; i >= 0; i--)
            {
                inputReversed += inputAsCharArray[i];
            }

            return inputReversed;
        }
    }
}
