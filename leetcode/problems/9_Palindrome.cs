using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.problems
{
    public class Palindrome
    {
        // LINK: https://leetcode.com/problems/palindrome-number/description/
        // (easy)
        public bool IsPalindrome(int x)
        {
            string s = x.ToString();

            int last = s.Length-1;
            for (int i=0; i<s.Length/2; i++)
            {
                if ( s[i] != s[last-i])
                {
                    return false;
                }
            }
            return true;
        }


    }
}
