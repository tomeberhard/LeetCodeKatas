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
    public class _3Sum_Tests
    {
        [TestMethod()]
        public void getTriplets_Test()
        {
            // Arrange
            _3Sum algo = new _3Sum(false);
            int[] nums = { 1, 2, 3, 4, 5 };

            // Act
            List<IList<int>> triplets = algo.getTriplets(nums);

            // Assert
            Assert.AreEqual(10, triplets.Count);

            // 1,2,3
            Assert.AreEqual(1, triplets[0][0]);
            Assert.AreEqual(2, triplets[0][1]);
            Assert.AreEqual(3, triplets[0][2]);

            // 1,2,4
            Assert.AreEqual(1, triplets[1][0]);
            Assert.AreEqual(2, triplets[1][1]);
            Assert.AreEqual(4, triplets[1][2]);

            // 1,2,5
            Assert.AreEqual(1, triplets[2][0]);
            Assert.AreEqual(2, triplets[2][1]);
            Assert.AreEqual(5, triplets[2][2]);

            // 1,3,4
            Assert.AreEqual(1, triplets[3][0]);
            Assert.AreEqual(3, triplets[3][1]);
            Assert.AreEqual(4, triplets[3][2]);

            // 1,3,5
            Assert.AreEqual(1, triplets[4][0]);
            Assert.AreEqual(3, triplets[4][1]);
            Assert.AreEqual(5, triplets[4][2]);

            // 1,4,5
            Assert.AreEqual(1, triplets[5][0]);
            Assert.AreEqual(4, triplets[5][1]);
            Assert.AreEqual(5, triplets[5][2]);

            // 2,3,4
            Assert.AreEqual(2, triplets[6][0]);
            Assert.AreEqual(3, triplets[6][1]);
            Assert.AreEqual(4, triplets[6][2]);

            // 2,3,5
            Assert.AreEqual(2, triplets[7][0]);
            Assert.AreEqual(3, triplets[7][1]);
            Assert.AreEqual(5, triplets[7][2]);

            // 2,4,5
            Assert.AreEqual(2, triplets[8][0]);
            Assert.AreEqual(4, triplets[8][1]);
            Assert.AreEqual(5, triplets[8][2]);

            // 3,4,5
            Assert.AreEqual(3, triplets[9][0]);
            Assert.AreEqual(4, triplets[9][1]);
            Assert.AreEqual(5, triplets[9][2]);
        }

        [TestMethod()]
        public void ThreeSum_Test()
        {
            // Arrange
            int[] nums = new int[] { -1, 0, 1, 2, -1, -4 };
            _3Sum algo = new _3Sum(true);

            // Act
            IList<IList<int>> triplets = algo.ThreeSum(nums);    // as List<List<int>>;

            // Assert
            Assert.AreEqual(2, triplets.Count);
        }

        [TestMethod()]
        public void ThreeSum_0000_Test()
        {
            // Arrange
            int[] nums = new int[] { 0, 0, 0, 0 };
            _3Sum algo = new _3Sum(true);

            // Act
            IList<IList<int>> triplets = algo.ThreeSum(nums);

            // Assert
            Assert.AreEqual(1, triplets.Count);

            // 0,0,0
            Assert.AreEqual(0, triplets[0][0]);
            Assert.AreEqual(0, triplets[0][1]);
            Assert.AreEqual(0, triplets[0][2]);
        }

        [TestMethod()]
        public void removeDuplicates_Test()
        {
            // Arrange
            List<IList<int>> set = new List<IList<int>>();
            set.Add(new List<int> { -1, 0, 1} );
            set.Add(new List<int> { 0, -1, 1 });
            _3Sum algo = new _3Sum(false);

            // Act
            algo.removeDuplicates(set);

            // Assert
            Assert.AreEqual(1, set.Count);
        }

        [TestMethod()]
        public void removeDuplicates_3x000_Test()
        {
            // Arrange
            List<IList<int>> set = new List<IList<int>>();
            set.Add(new List<int> { 0, 0, 0 });
            set.Add(new List<int> { 0, 0, 0 });
            set.Add(new List<int> { 0, 0, 0 });
            _3Sum algo = new _3Sum(false);

            // Act
            algo.removeDuplicates(set);

            // Assert
            Assert.AreEqual(1, set.Count);
        }

        [TestMethod(), Timeout(10000)]  // timeout is in milliseconds
        public void BigArraySize_Test()
        {
            // Arrange
            // using ThreeSumTheSlowWay: 30:8ms, 40:5ms, 100:11ms, 200:180ms, 400:4s, 800:timeout 
            int size = 800;     // 100:4ms, 200:4ms, 400:4ms, 800:6ms, 1600:12ms, 3200:31ms, 6400:106ms, 128000:timeout   
            int[] nums = new int[size];
            Random rand = new Random(29322);
            for(int i=0; i<size; i++)
            {
                nums[i] = rand.Next(-100, 100);
            }
            _3Sum algo = new _3Sum(true);
            
            // Act
            IList<IList<int>> triplets = algo.ThreeSum(nums);

            // Assert
            Assert.IsTrue(true);    // if the test finishes within the timeout, it passes.
        }

        [TestMethod()]
        public void LeetInput_1()
        {
            // Arrange
            int[] nums = new int[] { 3, 0, -2, -1, 1, 2 };
            _3Sum algo = new _3Sum(true);

            // Act
            IList<IList<int>> triplets = algo.ThreeSum(nums);

            //Assert
            Assert.AreEqual(3, triplets.Count);

            // -2,-1,3
            Assert.AreEqual(-2, triplets[0][0]);
            Assert.AreEqual(-1, triplets[0][1]);
            Assert.AreEqual(3, triplets[0][2]);

            // -2, 0, 2
            Assert.AreEqual(-2, triplets[1][0]);
            Assert.AreEqual(0, triplets[1][1]);
            Assert.AreEqual(2, triplets[1][2]);

            // -1, 0, 1
            Assert.AreEqual(-1, triplets[2][0]);
            Assert.AreEqual(0, triplets[2][1]);
            Assert.AreEqual(1, triplets[2][2]);
        }

        [TestMethod()]
        public void LeetInput_2()
        {
            // Arrange
            int[] nums = new int[] { -2, 0, 1, 1, 2 };
            _3Sum algo = new _3Sum(true);

            // Act
            IList<IList<int>> triplets = algo.ThreeSum(nums);

            // Assert
            Assert.AreEqual(2, triplets.Count);

            // -2, 0, 2
            Assert.AreEqual(-2, triplets[0][0]);
            Assert.AreEqual(0, triplets[0][1]);
            Assert.AreEqual(2, triplets[0][2]);

            // -2, 1, 1
            Assert.AreEqual(-2, triplets[1][0]);
            Assert.AreEqual(1, triplets[1][1]);
            Assert.AreEqual(1, triplets[1][2]);
        }

        [TestMethod()]
        public void LeetInput_3()
        {
            // Arrange
            int[] nums = new int[] { 1, -1, -1, 0 };
            _3Sum algo = new _3Sum(true);

            // Act
            IList<IList<int>> triplets = algo.ThreeSum(nums);

            // Assert
            Assert.AreEqual(1, triplets.Count);

            // -1, 0, 1
            Assert.AreEqual(-1, triplets[0][0]);
            Assert.AreEqual(0, triplets[0][1]);
            Assert.AreEqual(1, triplets[0][2]);
        }
    }
}