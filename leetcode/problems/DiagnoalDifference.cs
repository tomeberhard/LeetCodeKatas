using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.problems
{
    public class DiagnoalDifference
    {
        public static int diagonalDifference(int[][] a)
        {
            /*
            * Write your code here.
            */
            int size = 1 + a.GetUpperBound(0);
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < size; i++)
            {
                sum1 += a[i][i];
                sum2 += a[size - i - 1][i];
            }

            return Math.Abs(sum1 - sum2);
        }
    }
}
