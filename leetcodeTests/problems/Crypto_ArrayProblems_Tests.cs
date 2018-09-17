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
    public class Crypto_ArrayProblems_Tests
    {
        [TestMethod()]
        public void Crypto_Array_MonotonicallyIncreasing()
        {
            // Arrange
            int[] n = new int[] { 1, 2, 3, 4, 5, 6, 8, 1000 };
            bool expected = true;

            // Act
            bool result = Crypto_ArrayProblems.eachIntIsEqualOrGreaterThanPrecedent(n);

            // Assert
            Assert.AreEqual(expected, result);
        }

        public void Crypto_Array_SomeBadElement()
        {
            // Arrange
            int[] n = new int[] { 1, 2, 3, 6, 5, 6, 8, 1000 };
            bool expected = false;

            // Act
            bool result = Crypto_ArrayProblems.eachIntIsEqualOrGreaterThanPrecedent(n);

            // Assert
            Assert.AreEqual(expected, result);
        }


        [TestMethod()]
        public void Crypto_Array_5555()
        {
            // Arrange
            int[] n = new int[] { 5, 5, 5, 5 };
            bool expected = true;

            // Act
            bool result = Crypto_ArrayProblems.eachIntIsEqualOrGreaterThanPrecedent(n);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void Crypto_Array_LastOneFails()
        {
            // Arrange
            int[] n = new int[] { 5, 6, 7, 9, 8 };
            bool expected = false;

            // Act
            bool result = Crypto_ArrayProblems.eachIntIsEqualOrGreaterThanPrecedent(n);

            // Assert
            Assert.AreEqual(expected, result);
        }


        [TestMethod()]
        public void Crypto_Array_FirstOneFails()
        {
            // Arrange
            int[] n = new int[] { 6, 5, 6, 7, 9, 8 };
            bool expected = false;

            // Act
            bool result = Crypto_ArrayProblems.eachIntIsEqualOrGreaterThanPrecedent(n);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void numberOfTriples_Test_3()
        {
            // Arrange
            String s = "abcabcabcccdddxxx";
            int expected = 3;

            // Act
            int result = Crypto_ArrayProblems.numberOfTriples(s);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void numberOfTriples_10a()
        {
            // Arrange
            String s = "aaaaaaaaaaaa";
            int expected = 10;

            // Act
            int result = Crypto_ArrayProblems.numberOfTriples(s);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void numberOfTriples_aaa()
        {
            // Arrange
            String s = "aaa";
            int expected = 1;

            // Act
            int result = Crypto_ArrayProblems.numberOfTriples(s);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void numberOfTriples_aabbaabbaaa()
        {
            // Arrange
            String s = "aabbaabbaaa";
            int expected = 1;

            // Act
            int result = Crypto_ArrayProblems.numberOfTriples(s);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void numberOfTriples_aaabbaabbaaa()
        {
            // Arrange
            String s = "aaabbaabbaaa";
            int expected = 2;

            // Act
            int result = Crypto_ArrayProblems.numberOfTriples(s);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void numberOfTriples_axabxbaxabxbaxa()
        {
            // Arrange
            String s = "axabxbaxabxbaxa";
            int expected = 0;

            // Act
            int result = Crypto_ArrayProblems.numberOfTriples(s);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /*
         * ****************************************************************************************
         */
        [TestMethod()]
        public void sumIsReachable_Test1()
        {
            // Arrange
            int[] arr = new int[] { 5, 6, 2 };
            int target = 8;
            bool expected = true;

            // Act
            bool result = Crypto_ArrayProblems.sumIsReachable(0, arr, target);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void sumIsReachable_Test_NeedAll()
        {
            // Arrange
            int[] arr = new int[] { 5, 6, 8, 6, 9, 2 };     // 11 + 14 + 11 = 22 + 14 = 30 + 6 = 36
            int target = 36;
            bool expected = true;

            // Act
            bool result = Crypto_ArrayProblems.sumIsReachable(0, arr, target);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void sumIsReachable_Test_NeedJust6s()
        {
            // Arrange
            int[] arr = new int[] { 5, 6, 8, 6, 9, 2 };     
            int target = 12;
            bool expected = true;

            // Act
            bool result = Crypto_ArrayProblems.sumIsReachable(0, arr, target);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void sumIsReachable_Test_FailsDueTo6s()
        {
            // Arrange
            int[] arr = new int[] { 5, 6, 8, 6, 9, 2 };
            int target = 11;
            bool expected = false;

            // Act
            bool result = Crypto_ArrayProblems.sumIsReachable(0, arr, target);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void sumIsReachable_Test_WithNegatives()
        {
            // Arrange
            int[] arr = new int[] { -5, 6, 8, 6, 8, 2 };
            int target = 9;
            bool expected = true;

            // Act
            bool result = Crypto_ArrayProblems.sumIsReachable(0, arr, target);

            // Assert
            Assert.AreEqual(expected, result);
        }


    }//  Crypto_Tests
}