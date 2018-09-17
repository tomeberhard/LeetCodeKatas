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
    public class p5_1_Tests
    {
        // Enum to identify in which region of the partitionned array we're in, relative to the pivot value 
        enum Region
        {
            smaller, equal, bigger
        }

        [TestMethod()]
        public void partitionArray_Test()
        {
            // Arrange
            int[] array = { 1, 6, 2 };
            int partitionIndex = 2;     // partition at array[2] = 2
            int[] expected = { 1, 2, 6 };

            // Act
            p5_1.partitionArray(array, partitionIndex);

            // Assert
            Assert.AreEqual(expected[0], array[0]);
            Assert.AreEqual(expected[1], array[1]);
            Assert.AreEqual(expected[2], array[2]);
        }

        [TestMethod()]
        public void partitionArray_Test_123()
        {
            // Arrange
            int[] array = { 1, 3, 1, 3, 2, 2, 2, 3, 3, 3, 1, 2 };
            int partitionIndex = 5;
            int[] expected = { 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 3 };

            // Act
            p5_1.partitionArray(array, partitionIndex);

            // Assert
            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(expected[i], array[i]);
            }
        }

        [TestMethod()]
        public void partitionArray_TestBothEndsAreEqualToLimit()
        {
            // Arrange
            int[] array = { 7, 1, 33, 21, 33, 5, 7, 7, 2, 2, 2, 7, 3, 3, 3, 1, 2, 7 };
            int partitionIndex = 7;
            int limit = array[partitionIndex];

            // Act
            p5_1.partitionArray(array, partitionIndex);

            // Assert
            Region state = Region.smaller;

            for (int i = 0; i < array.Length; i++)
            {
                switch (state)
                {
                    case Region.smaller:
                        // check if transitioning to equal region
                        if (array[i] == limit)
                        {
                            state = Region.equal;
                        }
                        else
                        {
                            Assert.IsTrue(array[i] < limit);
                        }
                        break;
                    case Region.equal:
                        // check if transition to bigger region
                        if (array[i] > limit)
                        {
                            state = Region.bigger;
                        }
                        else
                        {
                            Assert.AreEqual(limit, array[i]);
                        }
                        break;
                    case Region.bigger:
                        Assert.IsTrue(limit < array[i]);
                        break;
                    default:
                        Assert.Fail("unknown region");
                        break;
                }
            }
        }

        [TestMethod()]
        public void partitionArray_Test_bothEndsAreSmaller()
        {
            // Arrange
            int[] array = { 5, 1, 33, 21, 33, 5, 7, 7, 2, 2, 2, 7, 3, 3, 3, 1, 2, 5 };
            int partitionIndex = 7;
            int limit = array[partitionIndex];

            // Act
            p5_1.partitionArray(array, partitionIndex);

            // Assert
            Region state = Region.smaller;

            for (int i = 0; i < array.Length; i++)
            {
                switch (state)
                {
                    case Region.smaller:
                        // check if transitioning to equal region
                        if (array[i] == limit)
                        {
                            state = Region.equal;
                        }
                        else
                        {
                            Assert.IsTrue(array[i] < limit);
                        }
                        break;
                    case Region.equal:
                        // check if transition to bigger region
                        if (array[i] > limit)
                        {
                            state = Region.bigger;
                        }
                        else
                        {
                            Assert.AreEqual(limit, array[i]);
                        }
                        break;
                    case Region.bigger:
                        Assert.IsTrue(limit < array[i]);
                        break;
                    default:
                        Assert.Fail("unknown region");
                        break;
                }
            }

        }
        [TestMethod()]
        public void partitionArray_Test_bothEndsAreBigger()
        {
            // Arrange
            int[] array = { 15, 1, 33, 21, 33, 5, 7, 7, 2, 2, 2, 7, 3, 3, 3, 1, 2, 15 };
            int partitionIndex = 7;
            int limit = array[partitionIndex];

            // Act
            p5_1.partitionArray(array, partitionIndex);

            // Assert
            Region state = Region.smaller;

            for (int i = 0; i < array.Length; i++)
            {
                switch (state)
                {
                    case Region.smaller:
                        // check if transitioning to equal region
                        if (array[i] == limit)
                        {
                            state = Region.equal;
                        }
                        else
                        {
                            Assert.IsTrue(array[i] < limit);
                        }
                        break;
                    case Region.equal:
                        // check if transition to bigger region
                        if (array[i] > limit)
                        {
                            state = Region.bigger;
                        }
                        else
                        {
                            Assert.AreEqual(limit, array[i]);
                        }
                        break;
                    case Region.bigger:
                        Assert.IsTrue(limit < array[i]);
                        break;
                    default:
                        Assert.Fail("unknown region");
                        break;
                }
            }

        }

        [TestMethod()]
        public void partitionArray_Test_AllEntriesAreEqual()
        {
            // Arrange
            int[] array = { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            int partitionIndex = 7;
            int limit = array[partitionIndex];

            // Act
            p5_1.partitionArray(array, partitionIndex);

            // Assert
            Region state = Region.smaller;

            for (int i = 0; i < array.Length; i++)
            {
                switch (state)
                {
                    case Region.smaller:
                        // check if transitioning to equal region
                        if (array[i] == limit)
                        {
                            state = Region.equal;
                        }
                        else
                        {
                            Assert.IsTrue(array[i] < limit);
                        }
                        break;
                    case Region.equal:
                        // check if transition to bigger region
                        if (array[i] > limit)
                        {
                            state = Region.bigger;
                        }
                        else
                        {
                            Assert.AreEqual(limit, array[i]);
                        }
                        break;
                    case Region.bigger:
                        Assert.IsTrue(limit < array[i]);
                        break;
                    default:
                        Assert.Fail("unknown region");
                        break;
                }
            }

        }

        [TestMethod()]
        public void partitionArray_Test_FunkyInput1()
        {
            // Arrange
            int[] array = { 7, 1, 33, 21, 33, 5, 7, 6, 7, 5, 7, 6, 7, 4, 7, 2, 2, 2, 7, 3, 3, 3, 1, 2, 15, 7 };
            int partitionIndex = 8;
            int limit = array[partitionIndex];

            // Act
            p5_1.partitionArray(array, partitionIndex);

            // Assert
            Region state = Region.smaller;

            for (int i = 0; i < array.Length; i++)
            {
                switch (state)
                {
                    case Region.smaller:
                        // check if transitioning to equal region
                        if (array[i] == limit)
                        {
                            state = Region.equal;
                        }
                        else
                        {
                            Assert.IsTrue(array[i] < limit);
                        }
                        break;
                    case Region.equal:
                        // check if transition to bigger region
                        if (array[i] > limit)
                        {
                            state = Region.bigger;
                        }
                        else
                        {
                            Assert.AreEqual(limit, array[i]);
                        }
                        break;
                    case Region.bigger:
                        Assert.IsTrue(limit < array[i]);
                        break;
                    default:
                        Assert.Fail("unknown region");
                        break;
                }
            }

        }

        [TestMethod()]
        public void partitionArray_Test_FunkyInput2()
        {
            // Arrange
            int[] array = { 8, 9, 10, 11, 12, 13, 14, 15, 7, 1, 2, 3, 4, 5, 6 };
            int partitionIndex = 8;
            int limit = array[partitionIndex];

            // Act
            p5_1.partitionArray(array, partitionIndex);

            // Assert
            Region state = Region.smaller;

            for (int i = 0; i < array.Length; i++)
            {
                switch (state)
                {
                    case Region.smaller:
                        // check if transitioning to equal region
                        if (array[i] == limit)
                        {
                            state = Region.equal;
                        }
                        else
                        {
                            Assert.IsTrue(array[i] < limit);
                        }
                        break;
                    case Region.equal:
                        // check if transition to bigger region
                        if (array[i] > limit)
                        {
                            state = Region.bigger;
                        }
                        else
                        {
                            Assert.AreEqual(limit, array[i]);
                        }
                        break;
                    case Region.bigger:
                        Assert.IsTrue(limit < array[i]);
                        break;
                    default:
                        Assert.Fail("unknown region");
                        break;
                }
            }

        }

        [TestMethod()]
        public void partitionArray_Test_AllSmallerThankPivot()
        {
            // Arrange
            int[] array = { 1, 1, 1, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1, 1 };
            int partitionIndex = 8;
            int limit = array[partitionIndex];

            // Act
            p5_1.partitionArray(array, partitionIndex);

            // Assert
            Region state = Region.smaller;

            for (int i = 0; i < array.Length; i++)
            {
                switch (state)
                {
                    case Region.smaller:
                        // check if transitioning to equal region
                        if (array[i] == limit)
                        {
                            state = Region.equal;
                        }
                        else
                        {
                            Assert.IsTrue(array[i] < limit);
                        }
                        break;
                    case Region.equal:
                        // check if transition to bigger region
                        if (array[i] > limit)
                        {
                            state = Region.bigger;
                        }
                        else
                        {
                            Assert.AreEqual(limit, array[i]);
                        }
                        break;
                    case Region.bigger:
                        Assert.IsTrue(limit < array[i]);
                        break;
                    default:
                        Assert.Fail("unknown region");
                        break;
                }
            }
        }

        [TestMethod()]
        public void partitionArray_Test_AllBiggerThankPivot()
        {
            // Arrange
            int[] array = { 18, 19, 10, 11, 12, 13, 14, 15, 7, 11, 12, 13, 14, 15, 16 };
            int partitionIndex = 8;
            int limit = array[partitionIndex];

            // Act
            p5_1.partitionArray(array, partitionIndex);

            // Assert
            Region state = Region.smaller;

            for (int i = 0; i < array.Length; i++)
            {
                switch (state)
                {
                    case Region.smaller:
                        // check if transitioning to equal region
                        if (array[i] == limit)
                        {
                            state = Region.equal;
                        }
                        else
                        {
                            Assert.IsTrue(array[i] < limit);
                        }
                        break;
                    case Region.equal:
                        // check if transition to bigger region
                        if (array[i] > limit)
                        {
                            state = Region.bigger;
                        }
                        else
                        {
                            Assert.AreEqual(limit, array[i]);
                        }
                        break;
                    case Region.bigger:
                        Assert.IsTrue(limit < array[i]);
                        break;
                    default:
                        Assert.Fail("unknown region");
                        break;
                }
            }

        }


    }
}