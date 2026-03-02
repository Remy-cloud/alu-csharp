using NUnit.Framework;
using MyMath;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Max_ListWithPositiveNumbers_ReturnsMax()
        {
            var nums = new List<int> { 1, 3, 2, 8, 5 };
            Assert.AreEqual(8, Operations.Max(nums));
        }

        [Test]
        public void Max_ListWithNegativeNumbers_ReturnsMax()
        {
            var nums = new List<int> { -10, -3, -50, -1 };
            Assert.AreEqual(-1, Operations.Max(nums));
        }

        [Test]
        public void Max_ListWithMixedNumbers_ReturnsMax()
        {
            var nums = new List<int> { -10, 0, 5, 3 };
            Assert.AreEqual(5, Operations.Max(nums));
        }

        [Test]
        public void Max_EmptyList_ReturnsZero()
        {
            var nums = new List<int>();
            Assert.AreEqual(0, Operations.Max(nums));
        }

        [Test]
        public void Max_NullList_ReturnsZero()
        {
            Assert.AreEqual(0, Operations.Max(null));
        }

        [Test]
        public void Max_ListWithOneElement_ReturnsThatElement()
        {
            var nums = new List<int> { 42 };
            Assert.AreEqual(42, Operations.Max(nums));
        }
    }
}