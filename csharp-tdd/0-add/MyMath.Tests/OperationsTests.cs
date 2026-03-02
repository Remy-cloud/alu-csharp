using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void Add_PositiveNumbers_ReturnsSum()
        {
            Assert.AreEqual(5, Operations.Add(2, 3));
        }

        [Test]
        public void Add_NegativeNumbers_ReturnsSum()
        {
            Assert.AreEqual(-5, Operations.Add(-2, -3));
        }

        [Test]
        public void Add_PositiveAndNegative_ReturnsSum()
        {
            Assert.AreEqual(0, Operations.Add(2, -2));
        }

        [Test]
        public void Add_Zero_ReturnsOtherNumber()
        {
            Assert.AreEqual(7, Operations.Add(0, 7));
            Assert.AreEqual(-4, Operations.Add(-4, 0));
        }

        [Test]
        public void Add_LargeNumbers_ReturnsSum()
        {
            Assert.AreEqual(2000000000, Operations.Add(1000000000, 1000000000));
        }
    }
}
