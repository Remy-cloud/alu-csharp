using NUnit.Framework;
using Text;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
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
        public void UniqueChar_SingleUnique_ReturnsIndex()
        {
            Assert.AreEqual(0, Str.UniqueChar("leetcode")); // 'l' is unique
            Assert.AreEqual(2, Str.UniqueChar("aabbc")); // 'b' at index 2
        }

        [Test]
        public void UniqueChar_NoUnique_ReturnsMinusOne()
        {
            Assert.AreEqual(-1, Str.UniqueChar("aabbcc"));
        }

        [Test]
        public void UniqueChar_EmptyString_ReturnsMinusOne()
        {
            Assert.AreEqual(-1, Str.UniqueChar(""));
        }

        [Test]
        public void UniqueChar_OneCharacter_ReturnsZero()
        {
            Assert.AreEqual(0, Str.UniqueChar("z"));
        }

        [Test]
        public void UniqueChar_AllUnique_ReturnsZero()
        {
            Assert.AreEqual(0, Str.UniqueChar("abc"));
        }

        [Test]
        public void UniqueChar_LastUnique_ReturnsLastIndex()
        {
            Assert.AreEqual(4, Str.UniqueChar("aabbc"));
        }
    }
}