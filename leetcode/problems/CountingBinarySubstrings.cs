using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.problems
{
    public class CountingBinarySubstrings
    {
        public enum Counting
        {
            zeroes,
            ones
        }


        public static int counting(string s)
        {
            int substringCount = 0;

            char[] array = s.ToCharArray();

            Counting state = Counting.ones;
            if ( array[0] == '0')
            {
                state = Counting.zeroes;
            }

            int count0 = 0;
            int count1 = 0;

            for (int i = 0; i < s.Length - 1; i++)
            {

                // detect transition
                if ( array[i] != array[i+1])
                {
                    substringCount++;
                    // see if there's more by reading forward
                    if (state == Counting.zeroes)
                    {
                        // read forward to find all substrings based on the transition we just saw
                        count1 = 0;
                        for (int j = i + 1; (j < (i + 1 + count0) && (j < s.Length)); j++)
                        {
                            if (array[j] == '1')
                            {
                                substringCount++;
                            }
                            else
                            {
                                break;
                            }
                        }

                        state = Counting.ones;
                    }
                    else
                    {
                        // read forward to find all substrings based on the transition we just saw
                        count0 = 0;
                        for (int j = i + 1; (j < (i + 1 + count1) && (j < s.Length)); j++)
                        {
                            if (array[j] == '1')
                            {
                                substringCount++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        state = Counting.ones;

                        state = Counting.zeroes;
                    }
                }
                else
                {
                    // no transition occured
                    if (array[i] == '0')
                    {
                        count0++;
                    }
                    else
                    {
                        count1++;
                    }

                }

                


            }
            return substringCount;           
        }
    }
}
