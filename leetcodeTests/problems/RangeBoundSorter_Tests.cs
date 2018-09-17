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
    public class RangeBoundSorter_Tests
    {
        [TestMethod()]
        public void sort_Test()
        {
            // Arrange
            int[] unsorted = { 10, 11, 8, 23, 44, 500, 2, 0 };
            int[] expected = { 0, 2, 8, 10, 11, 23, 44, 500 };

            // Act
            int[] result = RangeBoundSorter.sort(unsorted);

            // Assert
            Assert.AreEqual(expected.Length, result.Length);
            for(int i=0; i<expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod()]
        public void sort_Test_min_max()
        {
            // Arrange
            int[] unsorted = { 500, 200, 400, 110, 0 };
            int[] expected = { 0, 110, 200, 400, 500 };

            // Act
            int[] result = RangeBoundSorter.sort(unsorted);

            // Assert
            Assert.AreEqual(expected.Length, result.Length);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
    }
}