using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode.problems.EPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.problems.EPI.Tests
{
    [TestClass()]
    public class p7_1_Tests
    {
        [TestMethod()]
        public void MergeLists_Test()
        {
            int i;

            // Arrange
            p7_1.Node71 evenList = new p7_1.Node71(10);
            for (i = 8; 0 <= i; i -= 2)
            {
                evenList = evenList.Insert(i);
            }

            p7_1.Node71 oddList = new p7_1.Node71(9);
            for (i = 7; 0 <= i; i -= 2)
            {
                oddList = oddList.Insert(i);
            }


            // Act
            p7_1.Node71 mergedList = p7_1.MergeLists(oddList, evenList);


            // Assert
            int[] expected = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            p7_1.Node71 node = mergedList;
            i = 0;
            while(node != null)
            {
                Assert.AreEqual(expected[i++], node.value);
                node = node.next;
            }
            Assert.AreEqual(11, i);

        }

        [TestMethod()]
        public void MergeLists_Test_RepeatingCommon()
        {
            int i;
            p7_1.Node71 pointer;

            // Arrange
            int[] integers1 = new int[] { 1, 2, 3, 3, 3, 4, 4, 4, 5, 6 };
            p7_1.Node71 list1 = new p7_1.Node71(0);
            pointer = list1;
            for (i = 0; i < 10; i++)
            {
                pointer = pointer.Append(pointer, integers1[i]);
            }

            int[] integers2 = new int[] { 1, 2, 3, 4, 4, 4, 5, 5, 5, 6 };
            p7_1.Node71 list2 = new p7_1.Node71(0);
            pointer = list2;
            for (i = 0; i < 10; i++)
            {
                pointer = pointer.Append(pointer, integers2[i]);
            }


            // Act
            p7_1.Node71 mergedList = p7_1.MergeLists(list1, list2);


            // Assert
            int[] expected = new int[] { 0, 0, 1, 1, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 5, 5, 5, 5, 6, 6, 10, 10};
            
            p7_1.Node71 node = mergedList;
            i = 0;
            while (node != null)
            {
                Assert.AreEqual(expected[i++], node.value);
                node = node.next;
            }
            Assert.AreEqual(22, i);

        }
    }
}