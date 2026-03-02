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
        public void IsPalindrome_EmptyString_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome(""));
        }

        [Test]
        public void IsPalindrome_SingleCharacter_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("a"));
        }

        [Test]
        public void IsPalindrome_SimplePalindrome_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("level"));
        }

        [Test]
        public void IsPalindrome_CaseInsensitive_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("Racecar"));
        }

        [Test]
        public void IsPalindrome_WithSpacesAndPunctuation_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("A man, a plan, a canal: Panama."));
        }

        [Test]
        public void IsPalindrome_NotPalindrome_ReturnsFalse()
        {
            Assert.IsFalse(Str.IsPalindrome("hello"));
        }

        [Test]
        public void IsPalindrome_NullString_ReturnsFalse()
        {
            Assert.IsFalse(Str.IsPalindrome(null));
        }

        [Test]
        public void IsPalindrome_OnlyPunctuation_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("!!!"));
        }

        [Test]
        public void IsPalindrome_WhitespaceOnly_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("   "));
        }
    }
}