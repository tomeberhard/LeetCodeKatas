using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.problems
{
    public class ArrayIsSorted
    {
        // Interviewer provided a method that sorts an array. Verify that the method works. 
        public static bool isSorted(int[] arr, int[] sorted)
        {
            // element counts must be the same
            if (arr.Count() != sorted.Count())
            {
                return false;
            }

            // "int[] sorted" must actually be sorted
            if (!isIncreasing(sorted))
            {
                return false;
            }

            // check that all values from arr[] are in sorted[]
            Dictionary<int, int> backup = makeBackup(arr);

            if ( ! allElementsPresent(sorted, backup )) // TODO: check if this should be other way around: allElementsPresent(backup, sorted)
            {
                return false;
            }
                
            return true;
        }

        private static bool isIncreasing(int[] array)
        {
            int size = array.Count();
            // there are 0 or 1 elements in the array
            if ( size <= 1)
            {
                return true;
            }

            // there are exactly 2 elements
            if ( size == 2 )
            {
                return (array[0] <= array[1]);
            }

            // there are at least 3 elements
            for (int i = 0; i < size - 2; i++)
            {
                if (array[i] > array[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        private static Dictionary<int, int> makeBackup(int[] array)
        {
            Dictionary<int, int> backup = new Dictionary<int, int>();
            int size = array.Count();
            for(int i=0; i<size; i++)
            {
                if (backup.Keys.Contains<int>(array[i]))
                {
                    int count = backup[array[i]];
                    backup[array[i]] = count + 1;
                }
                else
                {
                    backup.Add(array[i], 1);
                }
            }
            return backup;
        }

        private static bool allElementsPresent(int[] sorted, Dictionary<int, int> backup)
        {
            int size = sorted.Count();
            for(int i=0; i<size; i++)
            {
                if (! backup.ContainsKey(sorted[i]))
                {
                    return false;
                }

                int count = backup[sorted[i]];
                if ( count <= 0 )
                {
                    return false;
                }
                count--;
                backup[sorted[i]] = count;
            }

            // extra check: verify that all counts are at 0

            // here we assume that backup doesn't contain anything else (by construction)

            return true;
        }

    }
}
