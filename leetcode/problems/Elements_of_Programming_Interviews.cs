using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.problems.EPI
{
    /*
     * page 9: Scenario 1: Hackathon
     * 4.1 (ch4: Primitive Types)
     *      
     * Ch 5: Arrays
     *          5.1
     *          5.6
     * Ch 6: Strings
     *          6.1
     * Ch 7: Linked Lists
     *          7.1 Merge two sorted lists
     * Ch 8: Stacks and Queues
     *          8.1 Implement a stack that provides a Max() method
     * Ch 9: Binary Trees
     *          9.3 Compute the Lowest Common Ancestor in a binary tree
     *          9.4
     * Ch 10: Heaps (max-heap, min-heap, aka "priority queue")
     *          10.1 Merge sorted files
     * 11.1
     * 12.2
     * 13.1
     * 14.1
     * 15.1
     * 16.1
     * 17.4
     * 18.1
     * 19.3
     * 20.13
     */

    public class p4_1
    {
        /*
        // https://stackoverflow.com/questions/30496810/the-way-c-sharp-represents-negative-integers-in-memory-and-casts-them-unchecked
        // Looking for two's complement notation.
        // To put a number into two's complement is easy:
        // 1. convert its absolute value to binary/base-2 notation.
        // 2. if the value is negative,
                2.1 invert the bits
                2.2 add 1
            +1 --> 0x0001
            -1 --> 0x0001 --> 0x1110, +1 --> 0x1111
        */

        // counts the number of bits that are set to 1
        public static int getParity(int n)
        {
            int parity = 0;
            int mask = 0x1;

            for (int i = 0; i < 32; i++)
            {
                if ((n & mask) != 0)
                {
                    parity++;
                }
                mask = mask << 1;
            }

            return parity;
        }

    }

    public class p5_1
    {
        private static int newPartitionIndex(int smallIndex, int bigIndex)
        {
            // Note: divide them before adding them, to avoid 
            // overflow problem when dealing with huuuuge arrays

            if ((smallIndex % 2 == 0) || (bigIndex % 2 == 0))
            {
                return (smallIndex / 2) + (bigIndex / 2);
            }
            // add 1 if they're both odd
            return (smallIndex / 2) + (bigIndex / 2) + 1;
        }

        private static void swap(int[] a, int i, int j)
        {
            if (i == j)
            {
                return;
            }
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }

        /// <summary>
        /// partitions the array using two passes.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="partitionIndex"></param>
        public static void partitionArray_InTwoPasses(int[] a, int partitionIndex)
        {
            int limit = a[partitionIndex];

            // move the smaller elements
            int smallerIndex = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < limit)
                {
                    swap(a, i, smallerIndex);
                    smallerIndex++;
                }
            }

            // move the bigger elements
            int biggerIndex = a.Length - 1;
            for (int i = biggerIndex; smallerIndex <= i; i--)
            {
                if (limit < a[i])
                {
                    swap(a, i, biggerIndex);
                    biggerIndex--;
                }
            }
        }

        /// <summary>
        /// Partition the array in a single pass
        /// </summary>
        /// <param name="a"></param>
        /// <param name="partitionIndex"></param>
        public static void partitionArray_EPI(int[] a, int partitionIndex)
        {
            int limit = a[partitionIndex];

            int smallerIndex = 0;
            int unsortedIndex = 0;
            int biggerIndex = a.Length; // - 1;

            while (unsortedIndex < biggerIndex)
            {
                if (a[unsortedIndex] < limit)
                {
                    swap(a, unsortedIndex, smallerIndex);
                    smallerIndex++;
                    unsortedIndex++;
                }
                else if (a[unsortedIndex] == limit)
                {
                    unsortedIndex++;
                }
                else if (a[unsortedIndex] > limit)
                {
                    biggerIndex--;
                    swap(a, unsortedIndex, biggerIndex);
                }
            }

        }

        /// <summary>
        /// Partition the array in a single pass
        /// </summary>
        /// <param name="a"></param>
        /// <param name="partitionIndex"></param>
        public static void partitionArray(int[] a, int partitionIndex)
        {
            int limit = a[partitionIndex];

            int smallIndex = 0;             // keep track of where to insert smaller numbers
            int unsortedIndex = 0;          // keep track of which element to process
            int bigIndex = a.Length - 1;        // keep track of where to insert bigger numbers

            while (unsortedIndex <= bigIndex)
            {
                if (a[unsortedIndex] < limit)
                {
                    swap(a, unsortedIndex, smallIndex);
                    smallIndex++;
                    unsortedIndex++;
                }
                else if (a[unsortedIndex] == limit)
                {
                    unsortedIndex++;
                }
                else // a[unsortedIndex] > limit
                {
                    swap(a, unsortedIndex, bigIndex);
                    bigIndex--;
                    //NOTE: a[unsortedIndex] is now not processed, do not increment unsortedIndex (!)
                }
            }

        }


        public static void partitionArray_FaultyOriginal(int[] a, int partitionIndex)
        {
            int limit = a[partitionIndex];
            int smallIndex = 0;             // small numbers get inserted here (array of smaller numbers grows from the beginning, towards the end)
            int bigIndex = a.Length - 1;    // big numbers get inserted there (array of bigger numbers grows from the end, towards beginning)

            int temp;

            for (int i = 0; i <= bigIndex; i++)
            {
                if (a[i] < limit)
                {
                    temp = a[smallIndex];
                    a[smallIndex] = a[i];
                    a[i] = temp;
                    smallIndex++;
                    if (i != 0)
                    {
                        i--;
                    }
                }
                else if (limit < a[i])
                {
                    temp = a[bigIndex];
                    a[bigIndex] = a[i];
                    a[i] = temp;
                    bigIndex--;
                    if (i != bigIndex)
                    {
                        i--;
                    }
                }

                // else a[i] == limit
                // these elements get moved back and forth, and end up in 
                //the middle automatically
            }

        }

    }

    public class p5_6
    {
        public class Trade
        {
            public int buyIndex;
            public int sellIndex;
            public int profit;

            public Trade(int[] prices, int buy, int sell)
            {
                buyIndex = buy;
                sellIndex = sell;
                profit = prices[sellIndex] - prices[buyIndex];
            }
        }

        // Buy and Sell a Stock Once
        public static Trade bestTrade(int[] prices)
        {
            // assume that you buy and sell on the same day, to represent "no trade"
            Trade bestTrade = new Trade(prices, 0, 0);
            int minIndex = 0;
            int minPrice = prices[minIndex];

            for (int i = 0; i < prices.Length; i++)
            {
                int newProfit = prices[i] - minPrice;
                if (newProfit > bestTrade.profit)
                {
                    bestTrade = new Trade(prices, minIndex, i);
                }
                if (prices[i] < minPrice)
                {
                    minIndex = i;
                    minPrice = prices[minIndex];
                }
            }

            return bestTrade;
        }
    }

    public class p6_1
    {
        private static char toChar(int i)
        {
            switch (i)
            {
                case 0: return '0';
                case 1: return '1';
                case 2: return '2';
                case 3: return '3';
                case 4: return '4';
                case 5: return '5';
                case 6: return '6';
                case 7: return '7';
                case 8: return '8';
                case 9: return '9';
                default: return 'X';
            }
        }

        public static string toString(int i)
        {
            StringBuilder s = new StringBuilder();
            List<int> digits = new List<int>();

            if (i == 0)
            {
                return "0";
            }

            if (i < 0)
            {
                s.Append('-');
                i = -i;
            }

            while (i > 0)
            {
                int modulus = i % 10;
                digits.Add(modulus);
                i = (i - modulus) / 10;
            }

            for (int index = digits.Count - 1; index >= 0; index--)
            {
                s.Append(toChar(digits[index]));
            }

            return s.ToString();
        }

        public static int toInt(string s)
        {
            int result = 0;
            int sign = 1;

            char[] digits = s.ToCharArray();

            // deal with sign
            if (digits[0] == '-')
            {
                sign = -1;
                digits[0] = '0';
            }

            int base10 = 1;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                result = result + base10 * (digits[i] - 48);
                base10 = base10 * 10;
            }

            result = result * sign;   // correct sign as necessary

            return result;
        }
    }

    public class p7_1
    {
        public class Node71
        {
            public int value;
            public Node71 next;
            public Node71(int x)
            {
                value = x;
            }

            public Node71 Insert(int v)
            {
                Node71 newNode = new Node71(v);
                newNode.next = this;
                return newNode;
            }

            /// <summary>
            /// Inserts a new node with the given value, after the specified node. 
            /// If the specified node alreay has a next value, the new node takes on that value.
            /// Returns the new node
            /// </summary>
            /// <param name="node"></param>
            /// <param name="v"></param>
            /// <returns></returns>
            public Node71 Append(Node71 node, int v)
            {
                Node71 newNode = new Node71(v);

                newNode.next = node.next;
                node.next = newNode;

                return newNode;
            }

        }

        // Merge two sorted lists
        public static Node71 MergeLists(Node71 list1, Node71 list2)
        {
            // special cases
            if (list2 == null) { return list1; }
            if (list1 == null) { return list2; }

            // "pointers" to iterate through the lists
            Node71 p1 = list1;
            Node71 p2 = list2;

            // resulting list
            Node71 pointer;
            Node71 mergedList;
            if (p1.value < p2.value)
            {
                mergedList = p1;
                p1 = p1.next;
            }
            else
            {
                mergedList = p2;
                p2 = p2.next;
            }
            pointer = mergedList;

            // go through both lists
            while (p1 != null && p2 != null)
            {
                if (p1.value < p2.value)
                {
                    pointer.next = p1;
                    pointer = p1;
                    if (p1 != null)
                    {
                        p1 = p1.next;
                    }
                }
                else
                {
                    pointer.next = p2;
                    pointer = p2;
                    if (p2 != null)
                    {
                        p2 = p2.next;
                    }
                }

            }

            // deal with unequal length lists
            if (p1 == null)
            {
                pointer.next = p2;
            }
            else
            {
                pointer.next = p1;
            }

            return mergedList;
        }

    }

    public class p8_1
    {
        public class StackWithMax
        {
            public int count;

            p7_1.Node71 head;
            p7_1.Node71 maxStack;

            public void Push(int v)
            {
                if (count == 0)
                {
                    head = new p7_1.Node71(v);
                    maxStack = head;
                    count++;
                }
                else
                {
                    head = head.Insert(v);
                    count++;
                    if (v >= maxStack.value)
                    {
                        maxStack = maxStack.Insert(v);
                    }
                }
            }

            public int Pop()
            {
                if (count == 0)
                {
                    throw new Exception("Stack is empty!");
                }
                int v = head.value;
                head = head.next;
                count--;

                if (v == Max())
                {
                    maxStack = maxStack.next;
                }
                return v;
            }

            public int Peek()
            {
                if (count == 0)
                {
                    throw new Exception("Stack is empty!");
                }
                return head.value;
            }

            public int Max()
            {
                return maxStack.value;
            }

        }

    }

    public class p9_3
    {
        public class TreeNode
        {
            public int value;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int v, TreeNode left, TreeNode right)
            {
                value = v;
                this.left = left;
                this.right = right;
            }
        }

        public static TreeNode lca(TreeNode root, TreeNode n1, TreeNode n2)
        {
            // special cases:
            // root == n1, and/or root == n2
            if (root == n1 || n1 == n2)
            {
                return root;
            }

            if (root == null)
            {
                return null;
            }

            lcaResult lcaData = lca_func(root, n1, n2);
            return lcaData.ancestor;
        }

        public class lcaResult
        {
            public int nodesFound;
            public TreeNode ancestor;

            public lcaResult(int nodesFound, TreeNode ancestor)
            {
                this.nodesFound = nodesFound;
                this.ancestor = ancestor;
            }
        }

        /// <summary>
        /// Find the common ancestor to two nodes. The ancestor of the root node is itself.(!)
        /// </summary>
        /// <param name="root"></param>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static lcaResult lca_func(TreeNode root, TreeNode n1, TreeNode n2)
        {
            if (root == null)
            {
                return new lcaResult(0, null);
            }

            // recursively investigate left subtree
            lcaResult leftResult = lca_func(root.left, n1, n2);
            if (leftResult.nodesFound == 2)
            {
                return leftResult;
            }

            // recursively investigate right subtree
            lcaResult rightResult = lca_func(root.right, n1, n2);
            if (rightResult.nodesFound == 2)
            {
                return rightResult;
            }

            // if we got to this point, then:
            //      - the common ancestor is not in the left subtree, otherwise nodesFound == 2 would have been true earlier
            //      - ditto 
            // if one of the nodes is in the left subtree, and the other is in the right subtree, then the current root
            // node is the common ancestor we're looking for. 
            int nodesFound = leftResult.nodesFound + rightResult.nodesFound;
            if (root == n1)
            {
                nodesFound++;
            }
            if (root == n2)
            {
                nodesFound++;
            }

            if (nodesFound == 2)
            {
                return new lcaResult(2, root);
            }

            return new lcaResult(nodesFound, null);
        }


        /* first attempt */
        /*
        public class LcaHelper
        {
            public List<TreeNode> path;
            public bool found;
            public int index;

            public LcaHelper()
            {
                path = new List<TreeNode>();
                found = false;
                index = 0;
            }
        }

        static LcaHelper n1Helper;
        static LcaHelper n2Helper;
        
        /// <summary>
        /// Returns the Lowest Common Ancestor Node of nodes n1 and n2. 
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static TreeNode getLCA(TreeNode root, TreeNode n1,TreeNode n2)
        {
            if (root == null) { return null; }
            if ( n1 == root) { return null; }
            if ( n2 == root) { return null; }

            n1Helper = new LcaHelper();
            n2Helper = new LcaHelper();

            processTree(root, n1, n2);

            if ( n1Helper.found && n2Helper.found )
            {
                int i = 0;

                if ( n1Index < n2Index )
                {
                    return nodeList[n1Index - 1];
                }
                else
                {
                    return nodeList[n2Index - 1];
                }
            }
            return null;
        }

        private static void processTree(TreeNode root, TreeNode n1, TreeNode n2)
        {
            if (root == null)
            {
                return null;
            }

            if (root == n1)
            {


            }
        }
        */
    }

    public class p10_1
    {
        // Merge sorted files
        // 500 files for quotes of the S&P 500
        // 1 trade per line: 123111,AAPL,30,456.12
        //                   time, ticker, quantity, price

        

    }
}
