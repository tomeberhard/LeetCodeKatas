using System;
using System.IO;
using System.Collections.Generic;

namespace leetcode.problems
{
    public class RollingString
    {
        static void Main2(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int t = 0; t < n; t++)
            {
                String str = Console.ReadLine();
                String[] strArr = str.Split();
                int a = Convert.ToInt32(strArr[0]);
                int b = Convert.ToInt32(strArr[1]);
                Console.WriteLine(a + b);
            }
        }

        static int[] oddNumbers(int l, int r)
        {
            List<int> odds = new List<int>();

            int startNumber = l;

            if (l % 2 == 0)
            {
                // l is is even
                startNumber++;
            }

            int endNumber = r;
            if (endNumber % 2 == 0)
            {
                endNumber--;
            }

            for (int i = startNumber; i <= endNumber; i++)
            {
                odds.Add(i);
            }

            return odds.ToArray();

        }

        public static string rollingString(string s, string[] operations)
        {
            char[] letters = s.ToCharArray();

            for(int i=0; i<operations.Length; i++)
            {
                apply(operations[i], letters);
            }

            string newString = new string(letters);
            return newString;
        }

        public static void apply(string operation, char[] letters)
        {
            // parse the operation [i j R]
            char[] separator = { ' ' };
            string[] token = operation.Split(separator, 3);
                
            int i = int.Parse(token[0]);
            int j = int.Parse(token[1]);

            if (token[2] == "R")
            {
                // increment the letters, wrap z to a
                for (int x = i; x <= j; x++)
                {
                    if (letters[x] == 'z')
                    {
                        letters[x] = 'a';
                    }
                    else
                    {
                        letters[x]++;
                    }
                }
            }
            else if (token[2] == "L")
            {
                // decrement the letters, warp a to z
                for(int x=i; x<=j; x++)
                {
                    if (letters[x] == 'a')
                    {
                        letters[x] = 'z';
                    }
                    else
                    {
                        letters[x]--;
                    }
                }
            }
        }


    }
}
