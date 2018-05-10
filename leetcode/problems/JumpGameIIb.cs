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

    public class JumpGameIIb : IJumpGameII
    {
        // LINK: https://leetcode.com/problems/jump-game-ii/description/

        // This is the second attempt, using a greedy algorithm
        public int Jump(int[] nums)
        {
            if (nums == null)
            {
                return 0;
            }

            int jumpCount = 0;
            int bestJump = 0;
            int current_jump_max = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if ( i + nums[i] > current_jump_max )
                {
                    // jumping from here yields an improvement
                    current_jump_max = i + nums[i];
                }

                if (i == bestJump)
                {
                    // we've caught up to the landing from the previous best jump, update variables
                    jumpCount++;
                    bestJump = current_jump_max;
                }
            }
            return jumpCount;
        }
    }
}

