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
    public class p6_1_Tests
    {
        [TestMethod()]
        public void toString_Test()
        {
            // Arrange
            List<int> integers = new List<int> { 253, 0, 1, 2, 23, 439, 2929911, -1, -2, -44, -292992 };
            List<string> expected = new List<string> { "253", "0", "1", "2", "23", "439", "2929911", "-1", "-2", "-44", "-292992" };
            List<string> result = new List<string>();

            // Act
            foreach (int i in integers)
            {
                result.Add(p6_1.toString(i));
            }

            // Assert
            for (int i = 0; i < integers.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod()]
        public void toInt_Test()
        {
            // Arrange
            List<string> strings = new List<string> { "253", "0", "1", "2", "23", "439", "2929911", "-1", "-2", "-44", "-292992" };
            List<int> expected = new List<int> { 253, 0, 1, 2, 23, 439, 2929911, -1, -2, -44, -292992 };
            List<int> result = new List<int>();

            // Act
            foreach (string s in strings)
            {
                result.Add(p6_1.toInt(s));
            }

            // Assert
            for (int i = 0; i < strings.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }

        }
    }
}