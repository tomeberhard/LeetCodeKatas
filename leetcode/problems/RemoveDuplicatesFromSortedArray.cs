using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.problems
{
    public class RemoveDuplicatesFromSortedArray
    {
        // from: https://leetcode.com/problems/remove-duplicates-from-sorted-array/description/
        // (easy)
        public int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length == 0 )
            {
                return 0;
            }

            if (nums.Length== 1)
            {
                return 1;
            }

            int write = 0;
            for (int read = 1; read < nums.Length; read++)
            {
                // fast forward over the duplicate entries
                while (nums[read] == nums[write])
                {
                    read++;
                    // deal with duplicates at end of array
                    if (read > (nums.Length - 1))
                    {
                        return write + 1;
                    }
                }
                write++;
                // do we have to shift numbers down?
                if ( write < read)
                {
                    nums[write] = nums[read];
                }
            }

            return write+1;
        }
    }

}
