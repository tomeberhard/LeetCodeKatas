using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.problems
{
    public class ParenthesisExpression
    {
        public static int maxDepth(string s)
        {
            int maxDepth = 0;
            int depth = 0;

            for(int i=0; i<s.Length; i++)
            {
                if (s[i] == '(')
                {
                    depth++;
                }
                else
                {
                    if ( depth>maxDepth )
                    {
                        maxDepth = depth;
                    }
                    depth--;
                }

                if ( depth < 0)
                {
                    return -1;
                }
            }

            if ( depth!= 0)
            {
                return -1;
            }

            return maxDepth;
        }
    }
}
