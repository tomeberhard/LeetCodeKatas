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
    public class ReverseIntegerTests
    {
        [TestMethod()]
        public void ReverseTest_Examples()
        {
            // Arrange
            ReverseInteger algo = new ReverseInteger();
            int[] input = { 123, -123, 120 };
            int[] expected = { 321, -321, 21 };

            for (int i=0; i<input.Length; i++)
            {
                // Act
                int result = algo.Reverse(input[i]);

                // Assert
                Assert.AreEqual(result, expected[i]);
            }
        }

        [TestMethod()]
        public void ReverseTest_Overflow()
        {
            Assert.Fail();
        }
    }

}