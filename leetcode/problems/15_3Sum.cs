using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.problems
{
    public class _3Sum
    {
        public bool checkConditionInline = true;

        public _3Sum(bool checkCondition)
        {
            checkConditionInline = checkCondition;
        }

        public IList<IList<int>> ThreeSum_shpolsky(int[] num)
        {
            Array.Sort(num);
            List<IList<int>> res = new List<IList<int>>();
            for (int i = 0; i < num.Length - 2; i++)
            {
                if (i == 0 || (i > 0 && num[i] != num[i - 1]))
                {
                    int lo = i + 1, hi = num.Length - 1, sum = 0 - num[i];
                    while (lo < hi)
                    {
                        if (num[lo] + num[hi] == sum)
                        {
                            res.Add(new List<int>() { num[i], num[lo], num[hi] });
                            while (lo < hi && num[lo] == num[lo + 1]) lo++;
                            while (lo < hi && num[hi] == num[hi - 1]) hi--;
                            lo++; hi--;
                        }
                        else if (num[lo] + num[hi] < sum) lo++;
                        else hi--;
                    }
                }
            }
            return res;
        }

        public IList<IList<int>> ThreeSum(int[] nums)
        {
            // special cases: {}, {a}, {a,b}
            if ((nums == null) || (nums.Length < 3))
            {
                return new List<IList<int>>() as IList<IList<int>>;
            }

            // nums has 4 or more elements   

            // Sort the array to avoid generating all subsets of size 3 (n choose m, factorial on size of input)
            Array.Sort(nums);

            List<IList<int>> triplets = new List<IList<int>>();
            
            for(int i=0; i<nums.Length; i++)
            {
                // skip duplicates
                if ((0<i) && (nums[i] == nums[i-1]))
                {
                    continue;
                }
        
                if (0 < nums[i])
                {
                    break;  // all subsequent values cannot bring the sum down towards zero, so done.
                }

                // find the pair that sums to nums[i], by searching rest of array from both sides
                int j = i + 1;
                int k = nums.Length - 1;
                int targetSum = -nums[i];
                while(j < k)
                {
                    if (nums[j] + nums[k] == targetSum)
                    {
                        triplets.Add(new List<int> { nums[i], nums[j], nums[k] });
                        
                        // move j up, move k down, skipping over duplicates
                        while ((j < k) && (nums[j] == nums[j+1])) { j++;  }
                        while ((j < k) && (nums[k] == nums[k-1])) { k--; }
                        j++;
                        k--;
                    }
                    else if (nums[j] + nums[k] < targetSum)
                    {
                        j++;
                    }
                    else
                    {
                        k--;
                    }
                }
            } 

            return triplets as List<IList<int>>;
        }


        public IList<IList<int>> ThreeSumTheSlowWay(int[] nums)
        {
            // special cases: {}, {a}, {a,b}
            if ((nums == null) || (nums.Length < 3))
            {
                return new List<IList<int>>() as IList<IList<int>>;
            }

            // nums has 4 or more elements   
            List<IList<int>> triplets = getTriplets(nums);

            removeDuplicates(triplets);

            return triplets as List<IList<int>>;
        }

        public List<IList<int>> getTriplets(int[] nums)
        {
            List<IList<int>> triplets = new List<IList<int>>();

            for(int a=0; a<nums.Length-2; a++)
            {
                for (int b = a + 1; b < nums.Length - 1; b++)
                {
                    for(int c=b+1; c<nums.Length;c++)
                    {
                        // might as well check for sum==0 right here
                        if (checkConditionInline)
                        {
                            if (nums[a] + nums[b] + nums[c] == 0)
                            {
                                var entry = new List<int>() { nums[a], nums[b], nums[c] };
                                triplets.Add(entry);
                            }
                        }
                        else
                        {
                            var entry = new List<int>() { nums[a], nums[b], nums[c] };
                            triplets.Add(entry);
                        }
                    }
                }
            }

            return triplets;
        }

        public void removeDuplicates(List<IList<int>> tripletsList)
        {
            for(int i=0; i<tripletsList.Count-1; i++)
            {
                for(int j=i+1; j<tripletsList.Count; j++)
                {
                    if (sameList(tripletsList[i], tripletsList[j]))
                    {
                        tripletsList.RemoveAt(j);
                        j = j - 1;
                    }
                }
            }
            return;
        }

        public bool sameList(IList<int> a, IList<int> b)
        {
            // a0,a1,a2 == b0,b1,b2
            if (a[0] == b[0])
            {
                if (a[1] == b[1])
                {
                    if (a[2] == b[2])
                    {
                        return true;
                    }
                    return false;
                }
                else
                {
                    // a0,a1,a2 == b0,b2,b1
                    if (a[1] == b[2])
                    {
                        if (a[2] == b[1])
                        {
                            return true;
                        }
                        return false;
                    }
                    return false;
                }
            }
            else if (a[0] == b[1])
            {
                if (a[1] == b[0])
                {
                    if (a[2] == b[2])
                    {
                        return true;
                    }
                    return false;
                }
                else if (a[1] == b[2])
                {
                    if (a[2] == b[0])
                    {
                        return true;
                    }
                    return false;
                }
                return false;
            }
            else if (a[0] == b[2])
            {
                if (a[1] == b[0])
                {
                    if (a[2] == b[1])
                    {
                        return true;
                    }
                    return false;
                }
                else if (a[1] == b[1])
                {
                    if (a[2] == b[0])
                    {
                        return true;
                    }
                    return false;
                }
                return false;
            }
            return false;
        }
        
    }
}
