using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.problems
{
    public enum JumpAlgorithm
    {
        DynamicProgramming,
        Greedy
    }

    public interface IJumpGameII
    {
        int Jump(int[] nums);
    }

    public class JumpGameIIFactory
    {
        public static IJumpGameII GetJumpGameII(JumpAlgorithm type)
        {
            switch (type)
            {
                case JumpAlgorithm.DynamicProgramming:
                    return new JumpGameII();
                case JumpAlgorithm.Greedy:
                    return new JumpGameIIb();
                default:
                    throw new NotSupportedException("Pick one of the supported algorithms.");
            }
        }
    }
}
