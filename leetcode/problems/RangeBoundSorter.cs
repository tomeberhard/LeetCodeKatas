using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.problems
{
    public class RangeBoundSorter
    {
        public const int Maximum = 500;

        // sort a list of non repeating integers whose values range from 0 to 500;

        public static int[] sort(int[] arr)
        {
            // initialize to -1's
            int[] fullArray = new int[Maximum + 1];
            for(int i=0; i<=Maximum; i++)
            {
                fullArray[i] = -1;
            }

            // use the value of each number as the index into which gets stored
            for(int i=0; i<arr.Length; i++)
            {
                fullArray[arr[i]] = arr[i];
            }

            // pick out the values != -1 and put into result array
            int[] sorted = new int[arr.Length];
            int writeIndex = 0;
            for (int i=0; i<=Maximum; i++)
            {
                if (fullArray[i] != -1)
                {
                    sorted[writeIndex++] = fullArray[i];
                }
            }

            return sorted;
        }

    }
}
