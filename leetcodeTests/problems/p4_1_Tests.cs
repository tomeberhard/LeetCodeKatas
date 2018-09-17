using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.problems.EPI.Tests
{
    [TestClass()]
    public class p4_1_Tests
    {
        [TestMethod()]
        public void getParity_Test_Small_Positives()
        {
            // Arrange
            List<int> numbers = new List<int>() { 0, 1, 2, 3, 4, 5, 0xA, 0xB };
            List<int> expected = new List<int>() { 0, 1, 1, 2, 1, 2, 2, 3 };
            List<int> result = new List<int>(numbers.Count);

            // Act
            int parity;
            for(int i=0; i<numbers.Count; i++)
            {
                parity = EPI.p4_1.getParity(numbers[i]);
                result.Add(parity);
            }

            // Assert
            for (int i = 0; i < numbers.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod()]
        public void getParity_Test_Small_Negatives()
        {
            List<int> numbers = new List<int>() { -0, -1, -2, -3, -4, -5, -0xA, -0xB };
            List<int> expected = new List<int>() { 1, 2, 2, 3, 2, 3, 3, 4 };
            List<int> result = new List<int>(numbers.Count);

            // Act
            int parity;
            for(int i = 0; i<numbers.Count; i++)
            {
                parity = EPI.p4_1.getParity(numbers[i]);
                result.Add(parity);
            }

            // Assert
            for (int i = 0; i<numbers.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
    }
}