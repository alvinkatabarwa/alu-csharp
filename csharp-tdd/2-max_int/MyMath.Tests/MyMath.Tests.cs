using NUnit.Framework;
using MyMath;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void Max_NonEmptyList_ReturnsMax()
        {
            List<int> nums = new List<int> { 1, 3, 5, 7, 9 };
            int result = Operations.Max(nums);
            Assert.AreEqual(9, result);
        }

        [Test]
        public void Max_EmptyList_ReturnsZero()
        {
            List<int> nums = new List<int>();
            int result = Operations.Max(nums);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Max_ListWithNegativeNumbers_ReturnsMax()
        {
            List<int> nums = new List<int> { -10, -3, -5, -7, -1 };
            int result = Operations.Max(nums);
            Assert.AreEqual(-1, result);
        }
    }
}
