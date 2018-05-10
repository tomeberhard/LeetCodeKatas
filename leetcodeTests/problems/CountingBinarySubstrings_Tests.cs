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
    public class CountingBinarySubstrings_Tests
    {
        [TestMethod()]
        public void counting_Test()
        {
            string s = "00110";
            int result = CountingBinarySubstrings.counting(s);
            Assert.AreEqual(3, result);
        }

        [TestMethod()]
        public void test_10001()
        {
            string s = "10001";
            int result = CountingBinarySubstrings.counting(s);
            Assert.AreEqual(2, result);
        }
    }
}