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
    public class ReverseLinkedList2_Tests
    {
        private int listSize = 8;

        public ListNode SetupLinkedList()
        {
            ListNode head = new ListNode(1);
            ListNode tail = head;
            for (int i = 2; i <= listSize; i++)
            {
                tail.next = new ListNode(i);
                tail = tail.next;
            }
            return head;
        }

        [TestMethod()]
        public void ReverseBetween_Test1()
        {
            // notation: to solve ReverseBetween(head, 3, 6)
            // [1] -> [2] -> [a] -> [b] -> [c] -> [d] -> [7] -> [8]
            //                3      4      5      6
            // [1] -> [2] -> [d] -> [c] -> [b] -> [a] -> [7] -> [8] 
            //                6      5      4      3    

            // Arrange
            ReverseLinkedList2 check = new ReverseLinkedList2();
            ListNode head = SetupLinkedList();

            // Act
            head = check.ReverseBetween(head, 3, 6);

            // Assert
            ListNode node = head;

            Assert.AreEqual(1, node.val);
            node = node.next;
            Assert.AreEqual(2, node.val);
            node = node.next;
            Assert.AreEqual(6, node.val);
            node = node.next;
            Assert.AreEqual(5, node.val);
            node = node.next;
            Assert.AreEqual(4, node.val);
            node = node.next;
            Assert.AreEqual(3, node.val);
            node = node.next;
            Assert.AreEqual(7, node.val);
            node = node.next;
            Assert.AreEqual(8, node.val);

            Assert.AreEqual(null, node.next);           
        }

        [TestMethod()]
        public void ReverseBetween_first_and_mid()
        {
            // Arrange
            ReverseLinkedList2 check = new ReverseLinkedList2();
            ListNode head = SetupLinkedList();

            // Act
            head = check.ReverseBetween(head, 1, 4);
            
            // Assert
            ListNode node = head;

            Assert.AreEqual(4, node.val);
            node = node.next;
            Assert.AreEqual(3, node.val);
            node = node.next;
            Assert.AreEqual(2, node.val);
            node = node.next;
            Assert.AreEqual(1, node.val);
            node = node.next;
            Assert.AreEqual(5, node.val);
            node = node.next;
            Assert.AreEqual(6, node.val);
            node = node.next;
            Assert.AreEqual(7, node.val);
            node = node.next;
            Assert.AreEqual(8, node.val);

            Assert.AreEqual(null, node.next);

        }

        [TestMethod()]
        public void ReverseBetween_mid_and_last()
        {
            // Arrange
            ReverseLinkedList2 check = new ReverseLinkedList2();
            ListNode head = SetupLinkedList();

            // Act
            head = check.ReverseBetween(head, 5, listSize);

            // Assert
            ListNode node = head;

            Assert.AreEqual(1, node.val);
            node = node.next;
            Assert.AreEqual(2, node.val);
            node = node.next;
            Assert.AreEqual(3, node.val);
            node = node.next;
            Assert.AreEqual(4, node.val);
            node = node.next;
            Assert.AreEqual(8, node.val);
            node = node.next;
            Assert.AreEqual(7, node.val);
            node = node.next;
            Assert.AreEqual(6, node.val);
            node = node.next;
            Assert.AreEqual(5, node.val);

            Assert.AreEqual(null, node.next);

        }

        [TestMethod()]
        public void ReverseBetween_first_and_last()
        {
            // Arrange
            ReverseLinkedList2 check = new ReverseLinkedList2();
            ListNode head = SetupLinkedList();

            // Act
            head = check.ReverseBetween(head, 1, listSize);
            
            // Assert
            ListNode node = head;

            Assert.AreEqual(8, node.val);
            node = node.next;
            Assert.AreEqual(7, node.val);
            node = node.next;
            Assert.AreEqual(6, node.val);
            node = node.next;
            Assert.AreEqual(5, node.val);
            node = node.next;
            Assert.AreEqual(4, node.val);
            node = node.next;
            Assert.AreEqual(3, node.val);
            node = node.next;
            Assert.AreEqual(2, node.val);
            node = node.next;
            Assert.AreEqual(1, node.val);

            Assert.AreEqual(null, node.next);

        }


    }
}