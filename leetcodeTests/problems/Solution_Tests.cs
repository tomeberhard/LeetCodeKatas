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
    public class Solution_Tests
    {
        [TestMethod()]
        public void apply_Test()
        {

            Assert.Fail();
        }

        [TestMethod()]
        public void whMain_Test()
        {
            // Arrange
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("2");
            sb.AppendLine("7 5");
            sb.AppendLine("2 6 9");
            sb.AppendLine("5 11 4");
            string expected = sb.ToString();

            // Act
            string result = PrettyPrintTree.whMain();

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}