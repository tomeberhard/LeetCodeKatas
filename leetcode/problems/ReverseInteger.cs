using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.problems
{
    public class ReverseInteger
    {
        // from https://leetcode.com/problems/reverse-integer/description/
        // Given a 32-bit signed integer, reverse digits of an integer

        public int Reverse(int x)
        {
            try
            {
                bool negative = false;
                if (x < 0)
                {
                    negative = true;
                    x = -x;
                }

                char[] s = x.ToString().ToCharArray();
                char[] s2 = new char[s.Length];
                int length = s.Length;
                for (int i = 0; i < length; i++)
                {
                    s2[length - 1 - i] = s[i];
                }

                int x2 = Int32.Parse(new string(s2));

                if (negative)
                {
                    x2 = -x2;
                }

                return x2;

            }
            catch
            {
                return 0;
            }
        }
    }
}
