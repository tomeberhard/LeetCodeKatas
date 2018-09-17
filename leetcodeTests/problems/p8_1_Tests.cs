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
    public class p8_1_Tests
    {
       
        [TestMethod()]
        public void PushPop_Test()
        {
            // Arrange
            p8_1.StackWithMax s = new p8_1.StackWithMax();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(2);
            List<int> expected = new List<int>() { 2, 3, 2, 1 };

            // Act
            List<int> result = new List<int>();
            while(0 < s.count)
            {
                int p = s.Pop();
                result.Add(p);
            }

            // Assert
            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }

        }

        [TestMethod()]
        public void Max_Test()
        {
            // Arrange
            p8_1.StackWithMax s = new p8_1.StackWithMax();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(2);
            s.Push(3);
            List<int> expected = new List<int>() { 3, 2, 3, 2, 1 };
            List<int> expectedMax = new List<int> { 3, 3, 3, 2, 1 };
            
            // Act
            List<int> result = new List<int>();
            List<int> resultMax = new List<int>();
            while (0 < s.count)
            {
                int max = s.Max();
                resultMax.Add(max);
                int p = s.Pop();
                result.Add(p);
            }

            // Assert
            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
                Assert.AreEqual(expectedMax[i], resultMax[i]);
            }

        }
    }
}