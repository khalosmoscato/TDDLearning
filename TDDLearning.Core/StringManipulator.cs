using System;
using System.Collections.Generic;
using System.Text;

namespace TDDLearning.Core
{
    public class StringManipulator
    {
        public string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            return new string(input.Reverse().ToArray());
        }

        public bool IsPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input)) return true;
            string cleanInput = input.ToLower();
            return ReverseString(input) == cleanInput;
        }
    }
}
