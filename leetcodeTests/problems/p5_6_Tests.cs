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
    public class p5_6_Tests
    {
        [TestMethod()]
        public void bestTrade_Test()
        {
            // Arrange
            int[] prices = { 11, 10, 12, 13, 14, 12, 9, 11 };
            p5_6.Trade expected = new p5_6.Trade(prices, 1, 4);

            // Act
            p5_6.Trade result = p5_6.bestTrade(prices);

            // Assert
            Assert.AreEqual(expected.buyIndex, result.buyIndex);
            Assert.AreEqual(expected.sellIndex, result.sellIndex);
            Assert.AreEqual(expected.profit, result.profit);
        }

        [TestMethod()]
        public void bestTrade_Test_MonotonicallyIncreasing()
        {
            // Arrange
            int[] prices = { 1, 2, 3, 4, 5, 6, 7 };
            p5_6.Trade expected = new p5_6.Trade(prices, 0, 6);

            // Act
            p5_6.Trade result = p5_6.bestTrade(prices);

            // Assert
            Assert.AreEqual(expected.buyIndex, result.buyIndex);
            Assert.AreEqual(expected.sellIndex, result.sellIndex);
            Assert.AreEqual(expected.profit, result.profit);
        }

        [TestMethod()]
        public void bestTrade_Test_MonotonicallyDecreasing()
        {
            // Arrange
            int[] prices = { 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10 };
            p5_6.Trade expected = new p5_6.Trade(prices, 0, 0);

            // Act
            p5_6.Trade result = p5_6.bestTrade(prices);

            // Assert
            Assert.AreEqual(expected.buyIndex, result.buyIndex);
            Assert.AreEqual(expected.sellIndex, result.sellIndex);
            Assert.AreEqual(expected.profit, result.profit);
        }

        [TestMethod()]
        public void bestTrade_Test_GoodThenBetterTrade()
        {
            // Arrange
            int[] prices = { 10, 9, 8, 9, 10, 11, 12, 13, 11, 10, 8, 7, 13, 14, 13 };   // 8-9, 8-10, ... 8-13, ... 7-14
            p5_6.Trade expected = new p5_6.Trade(prices, 11, 13);

            // Act
            p5_6.Trade result = p5_6.bestTrade(prices);

            // Assert
            Assert.AreEqual(expected.buyIndex, result.buyIndex);
            Assert.AreEqual(expected.sellIndex, result.sellIndex);
            Assert.AreEqual(expected.profit, result.profit);
        }



    }
}