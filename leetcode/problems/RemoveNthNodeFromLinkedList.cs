using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.problems
{
    public class RemoveNthNodeFromLinkedList
    {
        // Definition for singly-linked list.
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }


        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode endMarker;
            ListNode preMarker;

            // advance by n nodes
            endMarker = head;
            for(int i=0; i<n; i++)
            {
                endMarker = endMarker.next;

            }

            // continue to end
            preMarker = head;
            while(endMarker.next != null)
            {
                endMarker = endMarker.next;
                preMarker = preMarker.next;
            }

            // remove the node after preMarker
            preMarker.next = preMarker.next.next;

            return head;
        }
    }

}



