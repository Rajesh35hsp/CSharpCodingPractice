using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    public static class palindrome
    {
        public static bool isPalindrome(string inputStr)
        {
            if (inputStr.Length < 2)
            {
                return true;
            }

            char[] chrs = inputStr.ToCharArray();

            if (chrs[0] == chrs[chrs.Length - 1])
            {
                return isPalindrome(inputStr.Substring(1, inputStr.Length - 2));
            }
            else
            {
                return false;
            }
        }
    }
}
