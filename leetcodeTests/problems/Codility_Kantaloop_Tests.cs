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
    public class Codility_Kantaloop_Tests
    {
        [TestMethod()]
        public void addTwoNumbers_Test1()
        {
            // Arrange
            Codility_Kantaloop test = new Codility_Kantaloop();
            int a = 1;
            int b = 2;
            int expected = (1 + 2);

            // Act
            int result = test.addTwoNumbers(a, b);

            // Assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod()]
        public void smallestPositiveIntegerNotInArray_Test()
        {
            // Arrange
            Codility_Kantaloop test = new Codility_Kantaloop();
            int[] A = new int[] { 1, 3, 6, 4, 1, 2 };
            int expected = 5;

            // Act
            int result = test.smallestPositiveIntegerNotInArray(A);

            // Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void smallestPositiveIntegerNotInArray_Test1()
        {
            // Arrange 
            Codility_Kantaloop test = new Codility_Kantaloop();
            int[] A = new int[] { 1, 2, 3 };
            int expected = 4;

            // Act
            int result = test.smallestPositiveIntegerNotInArray(A);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void smallestPositiveIntegerNotInArray_Test2()
        {
            // Arrange 
            Codility_Kantaloop test = new Codility_Kantaloop();
            int[] A = new int[] { -1, -2, -3 };
            int expected = 1;

            // Act
            int result = test.smallestPositiveIntegerNotInArray(A);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void solution_Test_ACCAABBCC()
        {
            // Arrange 
            Codility_Kantaloop test = new Codility_Kantaloop();
            string S = "ACCAABBCC";
            string expected = "A";

            // Act
            string result = test.solution(S);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void solution_Test_ABCBBCBA()
        {
            // Arrange 
            Codility_Kantaloop test = new Codility_Kantaloop();
            string S = "ABCBBCBA";
            string expected = "";

            // Act
            string result = test.solution(S);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void solution_Test_BABABA()
        {
            // Arrange 
            Codility_Kantaloop test = new Codility_Kantaloop();
            string S = "BABABA";
            string expected = "BABABA";

            // Act
            string result = test.solution(S);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void solution_Test_ABCABCABCCBACBACBA()
        {
            // Arrange 
            Codility_Kantaloop test = new Codility_Kantaloop();
            string S = "ABCABCABCCBACBACBA";
            string expected = "";

            // Act
            string result = test.solution(S);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void solution_Test_A()
        {
            // Arrange 
            Codility_Kantaloop test = new Codility_Kantaloop();
            string S = "A";
            string expected = "A";

            // Act
            string result = test.solution(S);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void solution_Test_AB()
        {
            // Arrange 
            Codility_Kantaloop test = new Codility_Kantaloop();
            string S = "AB";
            string expected = "AB";

            // Act
            string result = test.solution(S);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void solution_Test_CC()
        {
            // Arrange 
            Codility_Kantaloop test = new Codility_Kantaloop();
            string S = "CC";
            string expected = "";

            // Act
            string result = test.solution(S);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void solution_Test_BBB()
        {
            // Arrange 
            Codility_Kantaloop test = new Codility_Kantaloop();
            string S = "BBB";
            string expected = "B";

            // Act
            string result = test.solution(S);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void solution_Test_BBBA()
        {
            // Arrange 
            Codility_Kantaloop test = new Codility_Kantaloop();
            string S = "BBBA";
            string expected = "BA";

            // Act
            string result = test.solution(S);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void solution_Test_ABBB()
        {
            // Arrange 
            Codility_Kantaloop test = new Codility_Kantaloop();
            string S = "ABBB";
            string expected = "AB";

            // Act
            string result = test.solution(S);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void solution_Test_ACCAABBC()
        {
            // Arrange 
            Codility_Kantaloop test = new Codility_Kantaloop();
            string S = "ACCAABBC";
            string expected = "AC";

            // Act
            string result = test.solution(S);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void solution_Test_AACBABABABCCCAAAAAAAABABABABABABABACCCACCACCAAAAABABCBCBCBACACBACCABBA()
        {
            // Arrange 
            Codility_Kantaloop test = new Codility_Kantaloop();
            string S = "AACBABABABCCCAAAAAAAABABABABABABABACCCACCACCAAAAABABCBCBCBACACBACCABBA";
            string expected = "CBABABABCBABABABABABABACABABCBCBCBACACBA";

            // Act
            string result = test.solution(S);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void GetNumbers_Test()
        {
            // Arrange 
            Codility_Kantaloop test = new Codility_Kantaloop();
            string filepath = @"C:\TEMP\canta1.txt";
            int[] expected = new int[] { 137, -104, 0, 1, 0, -1 };

            // Act
            int[] result = test.GetNumbers(filepath);

            // Assert
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
    }

}
