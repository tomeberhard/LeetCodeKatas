using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.problems
{
    public class MiniMaxSum
    {
        static void miniMaxSum(int[] arr)
        {
            Int64 bigSum = 0;
            for(int i=0; i<arr.Length; i++)
            {
                bigSum += arr[i];
            }

            Int64 minSum = bigSum;
            Int64 maxSum = 0;
            for(int i=0; i<arr.Length; i++)
            {
                Int64 thisSum = bigSum - arr[i];
                if ( thisSum < minSum )
                {
                    minSum = thisSum;
                }
                if (thisSum > maxSum)
                {
                    maxSum = thisSum;
                }
            }

            Console.WriteLine(minSum + " " + maxSum);
        }
    }
}
