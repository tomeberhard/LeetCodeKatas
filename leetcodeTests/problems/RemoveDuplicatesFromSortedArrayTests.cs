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
    public class RemoveDuplicatesFromSortedArrayTests
    {
        [TestMethod()]
        public void RemoveDuplicatesTest()
        {
            // Arrange
            RemoveDuplicatesFromSortedArray algo = new RemoveDuplicatesFromSortedArray();
            int[] nums = { 0, 1, 2, 3, 4, 5, 6 };

            // Act
            int length = algo.RemoveDuplicates(nums);

            // Assert
            Assert.AreEqual(length, 7);
            for (int i = 0; i < 7; i++)
            {
                Assert.AreEqual(nums[i], i);
            }
        }

        [TestMethod()]
        public void RemoveDuplicatesTest_01234444()
        {
            // Arrange
            RemoveDuplicatesFromSortedArray algo = new RemoveDuplicatesFromSortedArray();
            int[] nums = { 0, 1, 2, 3, 4, 4, 4, 4 };

            // Act
            int length = algo.RemoveDuplicates(nums);

            // Assert
            Assert.AreEqual(length, 5);
            for (int i = 0; i < length; i++)
            {
                Assert.AreEqual(nums[i], i);
            }
        }


        [TestMethod()]
        public void RemoveDuplicatesTest_112()
        {
            // Arrange
            RemoveDuplicatesFromSortedArray algo = new RemoveDuplicatesFromSortedArray();
            int[] nums = { 1, 1, 2 };

            // Act
            int length = algo.RemoveDuplicates(nums);

            // Assert
            Assert.AreEqual(length, 2);
            Assert.AreEqual(nums[0], 1);
            Assert.AreEqual(nums[1], 2);
        }

        [TestMethod()]
        public void RemoveDuplicatesTest_122()
        {
            // Arrange
            RemoveDuplicatesFromSortedArray algo = new RemoveDuplicatesFromSortedArray();
            int[] nums = { 1, 2, 2 };

            // Act
            int length = algo.RemoveDuplicates(nums);

            // Assert
            Assert.AreEqual(length, 2);
            Assert.AreEqual(nums[0], 1);
            Assert.AreEqual(nums[1], 2);
        }



        [TestMethod()]
        public void RemoveDuplicatesTest_000123()
        {
            // Arrange
            RemoveDuplicatesFromSortedArray algo = new RemoveDuplicatesFromSortedArray();
            int[] nums = { 0, 0, 0, 1, 2, 3 };

            // Act
            int length = algo.RemoveDuplicates(nums);

            // Assert
            Assert.AreEqual(length, 4);
            for (int i = 0; i < length; i++)
            {
                Assert.AreEqual(nums[i], i);
            }
        }

        [TestMethod()]
        public void RemoveDuplicatesTest_0123444567()
        {
            // Arrange
            RemoveDuplicatesFromSortedArray algo = new RemoveDuplicatesFromSortedArray();
            int[] nums = { 0, 1, 2, 3, 4, 4, 4, 5, 6, 7 };

            // Act
            int length = algo.RemoveDuplicates(nums);

            // Assert
            Assert.AreEqual(length, 8);
            for (int i = 0; i < length; i++)
            {
                Assert.AreEqual(nums[i], i);
            }
        }

        [TestMethod()]
        public void RemoveDuplicatesTest_empty()
        {
            // Arrange
            RemoveDuplicatesFromSortedArray algo = new RemoveDuplicatesFromSortedArray();
            int[] nums = { };
            
            // Act
            int length = algo.RemoveDuplicates(nums);

            // Assert
            Assert.AreEqual(length, 0);
        }
    }
}