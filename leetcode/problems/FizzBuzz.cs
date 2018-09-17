using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.problems
{
    class FizzBuzz
    {
        public string run(int last)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= last; i++)
            {
                sb.Append(i + " - ");
                if (i % 3 == 0)
                {
                    sb.Append("Fizz");
                }
                if (i % 5 == 0)
                {
                    sb.Append("Buzz");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }

        public string withoutRemainderOperator(int last)
        {
            StringBuilder sb = new StringBuilder();

            int count3 = 1;
            int count5 = 1;
            for(int i=1; i<=last; i++)
            {
                sb.Append(i + " - ");

                if ( count3==3 )
                {
                    sb.Append("Fizz");
                    count3 = 0;
                }
                if (count5 == 5)
                {
                    sb.Append("Buzz");
                    count5 = 0;
                }
                sb.AppendLine();

                count3++;
                count5++;

            }

            return sb.ToString();
        }
    }
}
