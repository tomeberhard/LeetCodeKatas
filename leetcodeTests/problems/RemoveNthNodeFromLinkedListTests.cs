using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode.problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace leetcode.problems.Tests
{
    [TestClass()]
    public class RemoveNthNodeFromLinkedListTests
    {

        [TestMethod()]
        public void RemoveSingleNodeList()
        {
            // Arrange
            RemoveNthNodeFromLinkedList.ListNode head = new RemoveNthNodeFromLinkedList.ListNode(1);
            RemoveNthNodeFromLinkedList algo = new RemoveNthNodeFromLinkedList();

            // Act
            head = algo.RemoveNthFromEnd(head, 1);

            // Acct;
            Assert.AreEqual(head, null);
        }

        [TestMethod()]
        public void RemoveNthFromEndTest_12345()
        {
            // Given linked list: 1->2->3->4->5, and n = 2.
            // After removing the second node from the end, 
            // the linked list becomes 1->2->3->5.

            // Arrange
            RemoveNthNodeFromLinkedList algo = new RemoveNthNodeFromLinkedList();
            int i;

            RemoveNthNodeFromLinkedList.ListNode head = new RemoveNthNodeFromLinkedList.ListNode(1);
            RemoveNthNodeFromLinkedList.ListNode current = head;
            for(i=2; i<=5; i++)
            {
                RemoveNthNodeFromLinkedList.ListNode node = new RemoveNthNodeFromLinkedList.ListNode(i);
                current.next = node;
                current = current.next;
            }
            RemoveNthNodeFromLinkedList.ListNode[] expected = new RemoveNthNodeFromLinkedList.ListNode[4];
            expected[0] = new RemoveNthNodeFromLinkedList.ListNode(1);
            expected[1] = new RemoveNthNodeFromLinkedList.ListNode(2);
            expected[2] = new RemoveNthNodeFromLinkedList.ListNode(3);
            expected[3] = new RemoveNthNodeFromLinkedList.ListNode(5);

            // Act
            head = algo.RemoveNthFromEnd(head, 2);

            // Assert
            i = 0;
            while (head != null)
            {
                Assert.AreEqual(head.val, expected[i].val);
                head = head.next;
                i++;
            }

        }
    }
}