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
    public class ArrayIsSorted_Tests
    {
        [TestMethod()]
        public void isSorted_Test()
        {
            // Arrange 
            int[] arr = new int[] { 4, 5, 6, 1, 2, 3 };
            int[] sorted = new int[] { 1, 2, 3, 4, 5, 6 };

            // Act
            bool result = ArrayIsSorted.isSorted(arr, sorted);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void isSorted_Test_NotSorted()
        {
            // Arrange 
            int[] arr = new int[] { 4, 5, 6, 1, 2, 3 };
            int[] sorted = new int[] { 1, 3, 2, 4, 5, 6 };

            // Act
            bool result = ArrayIsSorted.isSorted(arr, sorted);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void isSorted_Test_SortedWithExtraElements()
        {
            // Arrange 
            int[] arr = new int[] { 4, 5, 6, 1, 2, 3 };
            int[] sorted = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            // Act
            bool result = ArrayIsSorted.isSorted(arr, sorted);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void isSorted_Test_SortedWithMissingElements()
        {
            // Arrange 
            int[] arr = new int[] { 4, 5, 6, 1, 2, 3 };
            int[] sorted = new int[] { 1, 2, 4, 5, 6 };

            // Act
            bool result = ArrayIsSorted.isSorted(arr, sorted);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void isSorted_Test_SortedWithMissingAndExtraElements()
        {
            // Arrange 
            int[] arr = new int[] { 4, 5, 6, 1, 2, 3 };
            int[] sorted = new int[] { 1, 2, 4, 5, 6, 7 };

            // Act
            bool result = ArrayIsSorted.isSorted(arr, sorted);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void isSorted_Test_SortedWithLastElementWrong()
        {
            // Arrange 
            int[] arr = new int[] { 4, 5, 6, 1, 2, 3 };
            int[] sorted = new int[] { 1, 2, 3, 4, 5, 7 };

            // Act
            bool result = ArrayIsSorted.isSorted(arr, sorted);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void isSorted_Test_SortedWithManyDuplicates()
        {
            // Arrange 
            int[] arr = new int[] { 4, 4, 5, 2, 5, 6, 6, 6, 1, 1, 2, 2, 2, 2, 2, 2, 2, 3 };
            int[] sorted = new int[] { 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 3, 4, 4, 5, 5, 6, 6, 6 };

            // Act
            bool result = ArrayIsSorted.isSorted(arr, sorted);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void isSorted_Test_SortedWithManyDuplicates_AndMissingDuplicate_AndExtraDuplicate()
        {
            // Arrange 
            int[] arr = new int[] { 4, 4, 5, 2, 5, 6, 6, 6, 1, 1, 2, 2, 2, 2, 2, 2, 2, 3 };
            // take out a 2, and add a 6
            int[] sorted = new int[] { 1, 1, 2, 2, 2, 2, 2, 2, 2, 3, 4, 4, 5, 5, 6, 6, 6, 6 };

            // Act
            bool result = ArrayIsSorted.isSorted(arr, sorted);

            // Assert
            Assert.IsFalse(result);
        }

    }
}