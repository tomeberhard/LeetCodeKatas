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
    public class p9_3_Tests
    {
        ///  Setup the binary tree on page 121 (of Elements of Programming in python)
        ///  Node A is the root.

        static p9_3.TreeNode D = new p9_3.TreeNode(28, null, null);
        static p9_3.TreeNode E = new p9_3.TreeNode(0, null, null);
        static p9_3.TreeNode C = new p9_3.TreeNode(271, D, E);

        static p9_3.TreeNode H = new p9_3.TreeNode(17, null, null);
        static p9_3.TreeNode G = new p9_3.TreeNode(3, H, null);
        static p9_3.TreeNode F = new p9_3.TreeNode(561, null, G);
        static p9_3.TreeNode B = new p9_3.TreeNode(6, C, F);

        static p9_3.TreeNode M = new p9_3.TreeNode(641, null, null);
        static p9_3.TreeNode L = new p9_3.TreeNode(401, null, M);
        static p9_3.TreeNode N = new p9_3.TreeNode(257, null, null);
        static p9_3.TreeNode K = new p9_3.TreeNode(1, L, N);
        static p9_3.TreeNode J = new p9_3.TreeNode(2, null, K);

        static p9_3.TreeNode P = new p9_3.TreeNode(28, null, null);
        static p9_3.TreeNode O = new p9_3.TreeNode(271, null, P);
        static p9_3.TreeNode I = new p9_3.TreeNode(6, J, O);

        static p9_3.TreeNode A = new p9_3.TreeNode(314, B, I);


        [TestMethod()]
        public void lca_Test1()
        {
            // Arrange 
            p9_3.TreeNode root = A;
            p9_3.TreeNode n1 = L;   // 401
            p9_3.TreeNode n2 = P;   // 28
            p9_3.TreeNode expectedLca = I;

            // Act
            p9_3.TreeNode result = p9_3.lca(A, n1, n2);

            // Assert
            Assert.AreEqual(expectedLca, result);
        }

        [TestMethod()]
        public void lca_Test2()
        {
            // Arrange 
            p9_3.TreeNode root = A;
            p9_3.TreeNode n1 = F;   // 561
            p9_3.TreeNode n2 = N;   // 257
            p9_3.TreeNode expectedLca = A;

            // Act
            p9_3.TreeNode result = p9_3.lca(A, n1, n2);

            // Assert
            Assert.AreEqual(expectedLca, result);
        }

        [TestMethod()]
        public void lca_Test3()
        {
            // Arrange 
            p9_3.TreeNode root = A;
            p9_3.TreeNode n1 = K;   // 1
            p9_3.TreeNode n2 = C;   // 271
            p9_3.TreeNode expectedLca = A;

            // Act
            p9_3.TreeNode result = p9_3.lca(A, n1, n2);

            // Assert
            Assert.AreEqual(expectedLca, result);
        }

        [TestMethod()]
        public void lca_Test4()
        {
            // Arrange 
            p9_3.TreeNode root = A;
            p9_3.TreeNode n1 = O;   // 271
            p9_3.TreeNode n2 = H;   // 17
            p9_3.TreeNode expectedLca = A;

            // Act
            p9_3.TreeNode result = p9_3.lca(A, n1, n2);

            // Assert
            Assert.AreEqual(expectedLca, result);
        }

    }
}