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
    public class DiagnoalDifference_Tests
    {
        [TestMethod()]
        public void diagonalDifference_Test()
        {
            int[][] a = new int[3][];
            a[0] = new int[3];
            a[0][0] = 11;
            a[0][1] = 2;
            a[0][2] = 4;

            a[1] = new int[3];
            a[1][0] = 4;
            a[1][1] = 5;
            a[1][2] = 6;

            a[2] = new int[3];
            a[2][0] = 10;
            a[2][1] = 8;
            a[2][2] = -12;

            int diff = DiagnoalDifference.diagonalDifference(a);

            Assert.AreEqual(15, diff);
        }
    }
}