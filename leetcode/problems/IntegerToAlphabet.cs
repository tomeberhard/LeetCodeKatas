using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.problems
{
    public class IntegerToAlphabet
    {
        private static char[] symbol = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        public static string ToAlpha(int n, string coefficients)
        {
            if (n < 26)
            {
                return symbol[n] + coefficients;
            }

            int rem = n % 26;
            char c = symbol[rem];
            int N = (n - rem) / 26;
            
            return ToAlpha(N, c + coefficients);
        }
    }
}
