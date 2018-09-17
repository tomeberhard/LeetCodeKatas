using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.problems
{

    /// <summary>
    /// Asked by Stelllar
    /// </summary>
    public class Crypto_ArrayProblems
    {

        // Q1: 
        public static bool eachIntIsEqualOrGreaterThanPrecedent(int[] n)
        {
            // if array has length 0 or 1, there is no precedent, therefore return false
            if (n.Length == 0 || n.Length == 1)
            {
                return false;
            }

            // iterate through all integers, starting at the second one
            for (int i = 1; i < n.Length; i++)
            {
                if (n[i - 1] > n[i])
                {
                    return false;
                }
            }

            return true;
        }

        static public int numberOfTriples(string s)
        {
            // special cases when string has length 0, 1, or 2
            if (s.Length < 3)
            {
                return 0;
            }

            // basic idea: have a movable window that goes over the array
            int startIndex = 0;
            int endIndex = 2;

            int triplesFound = 0;
            while ((endIndex < s.Length) && (endIndex < s.Length))
            {
                // check if all 3 characters are the same
                if ((s[startIndex] == s[endIndex]) &&
                    (s[startIndex] == s[startIndex + 1]))
                {
                    triplesFound++;
                }

                // move window 
                startIndex++;
                endIndex++;
            }

            return triplesFound;

        }


        // Question is awkwardly phrased. 
        // What if one of the 6's occurs prior to the startIndex, which rule has precedence? Will assume that only 6's that 
        // occur *on or after* the startIndex have to be counted.
        // assuming that the array can contain negative integers

        public static bool sumIsReachable(int startIndex, int[] arr, int target)
        {
            /* Initial thoughts:
            // if the sum is reachable, an element is either part of the sum or not. 
            // choose n out of m has many subsets, but if we sort the array, then 
            // we can add/subtract until we reach or overshoot the target sum
            // on second thought, seems that have to do this by brute force. (adding / subtracting elements method
            // would still require going through the whole array multiple times.)
            */

            // step 1:take out all the 6's (set to 0) (nevermind, bad idea. 
            // ==> Actually a great idea, to force inclusion of the 6's. Just remember to decrement target by 6 each time)
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] == 6)
                {
                    target -= 6;
                    arr[i] = 0;
                }
            }

            // considering a recursive solution: 

            //int i = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                // is it reachable with element i included in the sum? 
                if (sumIsReachableHelper(i, true, arr, 0, target))
                {
                    return true;
                }

                // is it reachable without the 1st element? 
                if (sumIsReachableHelper(i, false, arr, 0, target))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool sumIsReachableHelper(int index, bool isIncluded, int[] arr, int currentSum, int target)
        {
            // exit if out of range
            if (index == arr.Length)
            {
                return false;
            }

            /*
            // deal with 6 and "not included"
            if ((arr[index] == 6) && (isIncluded == false))
            {
                return false;   // because 6 has to be included.
            }
            */

            if (isIncluded)
            {
                if (currentSum + arr[index] == target)
                {
                    return true;
                }

                currentSum += arr[index];
                if (sumIsReachableHelper(index + 1, true, arr, currentSum, target))
                {
                    return true;
                }
                if (sumIsReachableHelper(index + 1, false, arr, currentSum, target))
                {
                    return true;
                }
                return false;
            }
            else
            {
                if (sumIsReachableHelper(index + 1, true, arr, currentSum, target))
                {
                    return true;
                }
                if (sumIsReachableHelper(index + 1, false, arr, currentSum, target))
                {
                    return true;
                }
                return false;
            }
        }
    }
}

