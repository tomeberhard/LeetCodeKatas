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
    public class JumpGameIITests
    {
        public static JumpAlgorithm jumpAlgorithm = JumpAlgorithm.Greedy;

        [TestMethod()]
        public void JumpTest_example1()
        {
            // Arrange
            IJumpGameII game = JumpGameIIFactory.GetJumpGameII(jumpAlgorithm);
            int[] nums = { 2, 3, 1, 1, 4 };

            // Act
            int minJumps = game.Jump(nums);

            // Assert
            Assert.AreEqual(2, minJumps);
        }

        [TestMethod()]
        public void JumpTest_111111()
        {
            IJumpGameII game = JumpGameIIFactory.GetJumpGameII(jumpAlgorithm);
            int[] nums = { 1, 1, 1, 1, 1, 1 };
            int minJumps = game.Jump(nums);
            Assert.AreEqual(5, minJumps);
        }

        [TestMethod()]
        public void JumpTest_611111()
        {
            IJumpGameII game = JumpGameIIFactory.GetJumpGameII(jumpAlgorithm);
            int[] nums = { 6, 1, 1, 1, 1, 1 };
            int minJumps = game.Jump(nums);
            Assert.AreEqual(1, minJumps);
        }

        [TestMethod()]
        public void JumpTest_13532245312()
        {
            IJumpGameII game = JumpGameIIFactory.GetJumpGameII(jumpAlgorithm);
            int[] nums = { 1, 3, 5, 3, 2, 4, 5, 3, 1, 2 };
            int minJumps = game.Jump(nums);
            Assert.AreEqual(4, minJumps);
        }

        // TODO: 
        // deal with 0 in the array, at first, mid, last position
        [TestMethod()]
        public void JumpTest_0()
        {
            IJumpGameII game = JumpGameIIFactory.GetJumpGameII(jumpAlgorithm);
            int[] nums = { 0 };
            int minJumps = game.Jump(nums);
            Assert.AreEqual(0, minJumps);   // already at last position
        }

        [TestMethod()]
        public void JumpTest_40()
        {
            IJumpGameII game = JumpGameIIFactory.GetJumpGameII(jumpAlgorithm);
            int[] nums = { 4, 0 };
            int minJumps = game.Jump(nums);
            Assert.AreEqual(1, minJumps);
        }

        [TestMethod()]
        public void JumpTest_43210()
        {
            IJumpGameII game = JumpGameIIFactory.GetJumpGameII(jumpAlgorithm);
            int[] nums = { 4, 3, 2, 1, 0 };
            int minJumps = game.Jump(nums);
            Assert.AreEqual(1, minJumps);
        }

        [TestMethod()]
        public void JumpTest_141114111()
        {
            IJumpGameII game = JumpGameIIFactory.GetJumpGameII(jumpAlgorithm);
            int[] nums = { 1,4,1,1,1,4,1,1,1 };
            int minJumps = game.Jump(nums);
            Assert.AreEqual(3, minJumps);
        }

        [TestMethod()]
        public void JumpTest_61111112()
        {
            IJumpGameII game = JumpGameIIFactory.GetJumpGameII(jumpAlgorithm);
            int[] nums = { 6, 1, 1, 1, 1, 1, 1, 2 };
            int minJumps = game.Jump(nums);
            Assert.AreEqual(2, minJumps);
        }

        [TestMethod()]
        public void JumpTest_30011400011()
        {
            IJumpGameII game = JumpGameIIFactory.GetJumpGameII(jumpAlgorithm);
            int[] nums = { 3,0,0,1,1,4,0,0,0,1,1 };
            int minJumps = game.Jump(nums);
            Assert.AreEqual(5, minJumps);
        }

        [TestMethod()]
        public void JumpTest_1()
        {
            IJumpGameII game = JumpGameIIFactory.GetJumpGameII(jumpAlgorithm);
            int[] nums = { 1 };
            int minJumps = game.Jump(nums);
            Assert.AreEqual(0, minJumps);
        }

        [TestMethod()]
        public void JumpTest_Test92()
        {
            IJumpGameII game = JumpGameIIFactory.GetJumpGameII(jumpAlgorithm);
            int bigNum = 5;
            int[] nums = new int[bigNum];
            for (int i = 0; i < bigNum; i++)
            {
                nums[i] = bigNum - i;
            }
            int minJumps = game.Jump(nums);
            Assert.AreEqual(1, minJumps);
        }

        [TestMethod()]
        public void JumpTest_Test12()
        {
            IJumpGameII game = JumpGameIIFactory.GetJumpGameII(jumpAlgorithm);
            int[] nums = { 1, 2 };
            int minJumps = game.Jump(nums);
            Assert.AreEqual(1, minJumps);
        }

        public void JumpTest_Test709()
        {
            IJumpGameII game = JumpGameIIFactory.GetJumpGameII(jumpAlgorithm);
            int[] nums = { 7, 0, 9, 6, 9, 6, 1, 7, 9, 0, 1, 2, 9, 0, 3 };

            int minJumps = game.Jump(nums);
            Assert.AreEqual(2, minJumps);
        }
    }
}