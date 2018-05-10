using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.problems
{
     public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
     }

    // from https://leetcode.com/problems/reverse-linked-list-ii/description/
    // Reverse a linked list from position m to n.Do it in-place and in one-pass.
    // For example:
    //     Given 1->2->3->4->5->NULL, m = 2 and n = 4,
    //     return 1->4->3->2->5->NULL.

    // Given m, n satisfy the following condition:
    // 1 ≤ m ≤ n ≤ length of list.
    public class ReverseLinkedList2
    {
        public ListNode ReverseBetween(ListNode head, int m, int n)
        {
            // notation: to solve ReverseBetween(head, 3, 6)
            // [1] -> [2] -> [a] -> [b] -> [c] -> [d] -> [7] -> [8]
            // [1] -> [2] -> [d] -> [c] -> [b] -> [a] -> [7] -> [8] 

            // special case
            if (m == n)
            {
                return head;
            }

            ListNode nodeA = head;
            ListNode fixedNode = new ListNode(-1);
            fixedNode.next = head;
            
            // move forward to position m (nodeA, 
            for (int i = 1; i < m; i++)
            {
                fixedNode = nodeA;
                nodeA = nodeA.next;
            }

            // go through the nodes and string up nodes ahead of A
            ListNode nodeToMove;
            for (int i = m; i < n; i++)
            {
                nodeToMove = nodeA.next;

                nodeA.next = nodeToMove.next;
                nodeToMove.next = fixedNode.next;
                fixedNode.next = nodeToMove;
            }

            if (m == 1)
            {
                return fixedNode.next;
            }
            return head;

        }

    }


}
