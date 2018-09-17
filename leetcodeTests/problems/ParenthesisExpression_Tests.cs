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
    public class ParenthesisExpression_Tests
    {
        [TestMethod()]
        public void maxDepth_Test_1()
        {
            // Arrange
            string s = "()";
            int expectedDepth = 1;

            // Act
            int result = ParenthesisExpression.maxDepth(s);

            // Assert
            Assert.AreEqual(expectedDepth, result);
        }

        [TestMethod()]
        public void maxDepth_Test_11()
        {
            // Arrange
            string s = "(())";
            int expectedDepth = 2;

            // Act
            int result = ParenthesisExpression.maxDepth(s);

            // Assert
            Assert.AreEqual(expectedDepth, result);
        }

        [TestMethod()]
        public void maxDepth_Test_11_1111()
        {
            // Arrange
            string s = "()((()))";
            int expectedDepth = 3;

            // Act
            int result = ParenthesisExpression.maxDepth(s);

            // Assert
            Assert.AreEqual(expectedDepth, result);
        }


        public void maxDepth_Test_1_11_1111_1()
        {
            // Arrange
            string s = "(()((())))";
            int expectedDepth = 4;

            // Act
            int result = ParenthesisExpression.maxDepth(s);

            // Assert
            Assert.AreEqual(expectedDepth, result);
        }

    }
}