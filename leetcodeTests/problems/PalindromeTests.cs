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
    public class PalindromeTests
    {
        [TestMethod()]
        public void IsPalindromeTest_11()
        {
            // Arrange
            Palindrome p = new Palindrome();
            int number = 11;

            // Act
            bool result = p.IsPalindrome(number);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void IsPalindromeTest_12()
        {
            // Arrange
            Palindrome p = new Palindrome();
            int number = 12;

            // Act
            bool result = p.IsPalindrome(number);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void IsPalindromeTest_True()
        {
            // Arrange
            Palindrome p = new Palindrome();
            List<int> nList = new List<int> {
                1122332211,
                4321234
            };

            // Act / Assert
            foreach (int n in nList)
            {
                bool result = p.IsPalindrome(n);
                Assert.IsTrue(result);
            }
        }
    }
}