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
    public class GradingStudents_Tests
    {
        [TestMethod()]
        public void roundGrade_Test()
        {
            int newGrade = GradingStudents.roundGrade(73);

            Assert.AreEqual(75, newGrade);
        }
    }
}