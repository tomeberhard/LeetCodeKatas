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
    public class Fibonacci_Tests
    {
        [TestMethod()]
        public void getNthRecursively_Test_5()
        {
            // Arrange
            Fibonacci fib = new Fibonacci();
            int expected = 5;

            // Act
            int result = fib.getNthRecursively(5);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void getNthRecursively_TestFirst11()
        {
            // Arrange
            Fibonacci fib = new Fibonacci();
            int[] n = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int[] expected = new int[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };
            int[] result = new int[11];

            // Act
            for (int i = 0; i < n.Length; i++)
            {
                result[i] = fib.getNthRecursively(n[i]);
            }

            // Assert
            for (int i = 0; i < n.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod()]
        public void getNthUsingLoop_Test_5()
        {
            // Arrange
            Fibonacci fib = new Fibonacci();
            int expected = 5;

            // Act
            int result = fib.getNthRecursively(5);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void getNthUsingLoop_TestFirst11()
        {
            // Arrange
            Fibonacci fib = new Fibonacci();
            int[] n = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int[] expected = new int[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };
            int[] result = new int[11];

            // Act
            for (int i = 0; i < n.Length; i++)
            {
                result[i] = fib.getNthUsingLoop(n[i]);
            }

            // Assert
            for (int i = 0; i < n.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod()]
        public void getNthUsingFormula_Test_20_thru_25()
        {
            // Arrange
            Fibonacci fib = new Fibonacci();
            int[] n = new int[] { 20, 21, 22, 23, 24, 25 };
            ulong[] expected = new ulong[] { 6765, 10946, 17711, 28657, 46368, 75025 };
            ulong[] result = new ulong[6];

            // Act
            for (int i = 0; i < n.Length; i++)
            {
                result[i] = fib.getNthUsingFormula(n[i]);
            }

            // Assert
            for (int i = 0; i < n.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
            ulong f20 = expected[0];
            ulong f21 = expected[1];
            ulong f22 = expected[2];
            ulong f23 = expected[3];
            ulong f24 = expected[4];
            ulong f25 = expected[5];
            Assert.AreEqual(f22, f21 + f20);
            Assert.AreEqual(f23, f22 + f21);
            Assert.AreEqual(f24, f23 + f22);
            Assert.AreEqual(f25, f24 + f23);
        }
    }
}