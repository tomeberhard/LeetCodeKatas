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
    public class TimeConversion_Tests
    {
        [TestMethod()]
        public void timeConversion_Test()
        {
            string mil = TimeConversion.timeConversion("12:01:00AM");

            Assert.Fail();
        }
    }
}