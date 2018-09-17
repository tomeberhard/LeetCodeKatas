using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace leetcode.problems
{
    // Tom Eberhard
    public class DLLnode
    {
        // TODO: refactor with getter / setter (not really, use C#'s LinkedList for read-only)
        public char val;
        public DLLnode previous;
        public DLLnode next;

        public DLLnode(char newVal)
        {
            val = newVal;
        }
    }

    public class SolutionIter : IEnumerable<int>
    {
        Stream st;

        // See https://stackoverflow.com/questions/11313373/how-to-implement-ienumerablet-with-getenumerator
        public SolutionIter(Stream stream)
        {
            st = stream;
        }      

        private IEnumerable<int> Events()
        {
            StringBuilder sb = new StringBuilder();
            string line;
            int c = 0;

            while (true)
            {
                c = st.ReadByte();
                if ( c== 13)
                {
                    // skip 13, Carriage Return (CR)
                    c = st.ReadByte();
                    c = 10;
                }

                if (c == 10)
                {
                    // linefeed detected
                    line = sb.ToString().Trim();
                    int result;
                    if (int.TryParse(line, out result))
                    {
                        if ((-2000000000 < result) && (result < 2000000000))
                        {
                            yield return result;
                        }
                    }
                    sb.Clear();
                }
                else
                {

                    if (('0' <= c) && (c <= '9'))
                    {
                        sb.Append(c-'0');
                    }
                    else if (c == '-')
                    {
                        sb.Append('-');
                    }
                    else if (c == '+')
                    {
                        sb.Append('+');
                    }
                    else if (c == ' ')
                    {
                        sb.Append(' ');
                    }
                    else
                    {
                        // invalid character, ignore the line
                        sb.Clear();
                        // forward to end of line if line is  not valid
                        do
                        {
                            c = st.ReadByte();
                        }
                        while (c != 10 && c != -1);
                    }
                }

                // stop after reaching end of stream
                if (c == -1)
                {
                    break;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Events().GetEnumerator();
        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            return Events().GetEnumerator();
        }

    }





    public class Codility_Kantaloop
    {
        // Notes and Comments
        // URL to the invitation: https://app.codility.com/test/YYF5GP-F2W/
        // Time: 190 minutes: 60+60+60+10 = 190 (3 hours + 10 minutes)
        // Links: https://app.codility.com/programmers/

        public int addTwoNumbers(int a, int b)
        {
            return a + b;
        }

        /**
        * Example usage:
        *
        * IEnumerable<int> it = new SolutionIter(stream);
        * int[] arr = it.ToArray();
        */
        public int[] GetNumbers(string filepath)
        {
            FileStream fs = new FileStream(filepath, FileMode.Open);
            IEnumerable<int> it = new SolutionIter(fs);
            int[] numbers = it.ToArray();
            return numbers;
        }



        public string solution(string S)
        {
            // deal with special and corner cases
            if ((S==null || S==""))
            {
                return "";
            }
            if (S.Length == 1)
            {
                return S;
            }
            if (S.Length == 2)
            {
                if (S[0] == S[1])
                {
                    return "";
                }
                else
                {
                    return S;
                }
            }

            // string length is 3 or more


            // Load the string into a Doubly Linked List
            //LinkedList<char> list = new LinkedList<char>(S.ToCharArray());
            DLLnode list = new DLLnode(S[0]);
            list.previous = null;

            DLLnode nCurr = list;
            DLLnode nNext;
            DLLnode nPrev = null;
            for (int i = 1; i < S.Length; i++)
            {
                nNext = new DLLnode(S[i]);
                nCurr.next = nNext;
                nNext.previous = nCurr;

                nCurr = nCurr.next;
            }

            string transformed = DLLtoString(list);

            // Process the Doubly Linked List
            nCurr = list;
            while (nCurr != null)
            {
                nNext = nCurr.next;
                nPrev = nCurr.previous;
                
                if ( nNext == null )
                {
                    break;
                }

                if (nCurr.val == nNext.val)
                {
                    // take out those two, careful if first or last elements
                    if (nCurr == list)
                    {
                        if ( nCurr.next != null )
                        {
                            nCurr = nCurr.next.next;
                        }
                        list = nCurr;
                    }
                    else 
                    {
                        // 2 elements somewhere in the middle of the list, unlink them
                        // unlink the current one
                        nCurr.previous.next = nNext.next;
                        nCurr = nPrev;  // go back 1 node, because the new next might also match

                        if ( nNext.next != null )
                        {
                            nNext.next.previous = nCurr;    // since nCurr was alread updated
                        }
                    }
                }
                else
                {
                    // nCurr != nNext, keep both and move nCurr up by one
                    nCurr = nCurr.next;

                }
                transformed = DLLtoString(list);

            }

            transformed = DLLtoString(list);
            return transformed;
        }

        public string DLLtoString(DLLnode node)
        {
            StringBuilder sb = new StringBuilder();
            while (node != null)
            {
                sb.Append(node.val);
                node = node.next;
            }
            return sb.ToString();
        }



        

        public int smallestPositiveIntegerNotInArray(int[] A)
        {
            HashSet<int> seen = new HashSet<int>();

            int spi = 1;    // the smallest positive integer is 1, assume it's not in the array
            foreach (int e in A)    // e as in "element" 
            {
                // add e to what we've seen
                if (!seen.Contains(e))
                {
                    seen.Add(e);
                }

                if (e == spi)
                {
                    // turns out it's actually in the array, increment spi, 
                    // then check if (spi+1) was already seen, if so keep incrementing and looking
                    do
                    {
                        spi = spi + 1;
                    }
                    while(seen.Contains(spi));
                }
            }

            return spi;
        }

    }


}
