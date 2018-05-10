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
    public class IntegerToAlphabet_Tests
    {
        private static char[] symbol = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        [TestMethod()]
        public void ToAlpha_TestAllSingleDigits()
        {
            // Arrange
            for (int n = 0; n < 26; n++)
            {
                string expected = symbol[n].ToString();

                // Act
                string result = IntegerToAlphabet.ToAlpha(n, "");

                // Assert
                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod()]
        public void ToAlphaTestCBX()
        {
            // C B X =  C * (26^2) + B * (26^1) + X * (26^0)
            //       =  2 * 676    + 1 * 26     + 23 * 1
            //       = 1352 + 26 + 23
            //       = 1401

            // Arrange
            int n = 1401;
            string expected = "CBX";

            // Act
            string result = IntegerToAlphabet.ToAlpha(n, "");

            // Assert
            Assert.AreEqual(expected, result);
        }


    }
}