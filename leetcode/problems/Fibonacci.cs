using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.problems
{
    public class Fibonacci
    {
        // cache related variables
        static private List<int> cache = new List<int>(512);
        static private int writeIndex = 3;
        static private bool isInitialized = false;
        
        // 1 2 3 4 5 6 7  8  9  10 11
        // 1 1 2 3 5 8 13 21 34 55 89
        public Fibonacci()
        {
            if (isInitialized)
            {
                return;
            }
            cache.Add(0);   // fib(0) = 0
            cache.Add(1);   // fib(1) = 1
            cache.Add(2);   // fib(2) = 1
        }


        public int getNthRecursively(int n)
        {
            if (n < 1)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else if (n == 2)
            {
                return 1;
            }

            // if it's in the cache, return it
            if (n < writeIndex)
            {
                return cache[n];
            }

            // compute it
            int f2 = getNthRecursively(n - 2);
            int f1 = getNthRecursively(n - 1);
            int fn = f1 + f2;

            // store it in the cache 
            cache.Add(fn);
            writeIndex++;
            
            return fn;
        }

        public int getNthUsingLoop(int n)
        {
            if ( n < 1 )
            {
                return 0;
            }
            else if ( n == 1 ) 
            {
                return 1;
            }
            else if ( n == 2 )
            {
                return 1;
            }

            if ( n < writeIndex )
            {
                return cache[n];
            }

            int f1 = 1;
            int f2 = 1;
            int fn = 0;

            for(int i=3; i<=n; i++)
            {
                fn = f1 + f2;
                f2 = f1;
                f1 = fn;

                // update cache
                if ( i == writeIndex )
                {
                    cache.Add(fn);
                    writeIndex++;
                }
            }

            return fn;
        }

        public ulong getNthUsingFormula(int n)
        {
            // from https://en.wikipedia.org/wiki/Fibonacci_number#Closed-form_expression
            double root5 = Math.Sqrt(5.0);

            double leftSide = Math.Pow( ((1.0 + root5) / 2.0), (double)n);
            double rightSide = Math.Pow(((1.0 - root5) / 2.0), (double)n);

            double Fn = (1.0 / root5) * (leftSide - rightSide);

            ulong Fni = (ulong)Fn;

            return Fni;
        }


    }
}
