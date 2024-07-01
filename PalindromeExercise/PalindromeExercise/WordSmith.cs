using System;
using System.Linq;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string input)
        {
            char[] inputArray = input.ToCharArray();
            Array.Reverse(inputArray);
            string inputReversed = new string(inputArray);

            return input.Equals(inputReversed);
        }
        
        
    }
}
