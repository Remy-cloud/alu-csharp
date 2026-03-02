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
        public void CamelCase_EmptyString_ReturnsZero()
        {
            Assert.AreEqual(0, Str.CamelCase(""));
        }

        [Test]
        public void CamelCase_SingleWord_ReturnsOne()
        {
            Assert.AreEqual(1, Str.CamelCase("word"));
        }

        [Test]
        public void CamelCase_TwoWords_ReturnsTwo()
        {
            Assert.AreEqual(2, Str.CamelCase("camelCase"));
        }

        [Test]
        public void CamelCase_MultipleWords_ReturnsCorrectCount()
        {
            Assert.AreEqual(5, Str.CamelCase("thisIsCamelCaseTest"));
        }

        [Test]
        public void CamelCase_AllUppercase_ReturnsLength()
        {
            Assert.AreEqual(4, Str.CamelCase("ABCd"));
        }

        [Test]
        public void CamelCase_NullString_ReturnsZero()
        {
            Assert.AreEqual(0, Str.CamelCase(null));
        }
    }
}