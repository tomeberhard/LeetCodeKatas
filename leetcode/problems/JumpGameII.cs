using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.problems
{
    /*
     Given an array of non-negative integers, you are initially positioned at the first index of the array.
     Each element in the array represents your maximum jump length at that position.
     Your goal is to reach the last index in the minimum number of jumps.

    For example:
    Given array A = [2,3,1,1,4]

    The minimum number of jumps to reach the last index is 2. (Jump 1 step from index 0 to 1, then 3 steps to the last index.)

    Note:
    You can assume that you can always reach the last index.
     */

    public class JumpGameII : IJumpGameII
    {
        // LINK: https://leetcode.com/problems/jump-game-ii/description/

        /// <summary>
        /// This is the (slow) dynamic programming approach. Use the greedy algorithm in JumpGameIIb instead.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int Jump(int[] nums)
        {
            if (nums == null)
            {
                return 0;
            }
            if (nums.Length == 1)
            {
                return 0;   // we're at the last index already
            }
            if (nums.Length < nums[0])
            {
                return 1;   // first jump does the trick
            }

            int lastIndex = nums.Length - 1;

            int[] minJumps = new int[lastIndex + 1];

            // iterate through the array, starting at the end
            for (int i = lastIndex; 0 <= i; i--)
            {
                if (nums[i] == 0)
                {
                    minJumps[i] = int.MaxValue;
                }
                else
                {
                    // iterate through the values in nums[i] to find minJumps from this point onwards (with i constant)
                    // ==> this is what kills the efficiency
                    int min = int.MaxValue;
                    int lastC = Math.Min(nums[i], lastIndex - i);
                    for (int c = 1; c <= nums[i];c++)
                    // for (int c = 1; c <= nums[i]; c++)
                    //for (int c = nums[i]; c <= 1; c++)
                    {
                        int index = i + c;
                        if (lastIndex <= i + c)
                        {
                            min = 1;
                            break;
                        }
                        if (minJumps[i + c] == int.MaxValue)
                        {
                            // can't get there from here (due to zero in array)
                            continue;
                        }
                        int steps = 1 + minJumps[i + c];
                        if (steps < min)
                        {
                            min = steps;
                        }
                    }
                    minJumps[i] = min;
                }
            }

            // if ya can't make it, return 0
            if (minJumps[0] == int.MaxValue)
            {
                return 0;
            }
            return minJumps[0];
        }

        public int Jump2(int[] A)
        {
            int step_count = 0;
            int last_jump_max = 0;
            int current_jump_max = 0;
            for (int i = 0; i < A.Length - 1; i++)
            {
                current_jump_max = Math.Max(current_jump_max, i + A[i]);
                if (i == last_jump_max)
                {
                    step_count++;
                    last_jump_max = current_jump_max;
                }
            }
            return step_count;
        }


    }
}
