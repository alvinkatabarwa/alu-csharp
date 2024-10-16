using NUnit.Framework;
using Text;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void IsPalindrome_ValidPalindrome_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("Racecar"));
            Assert.IsTrue(Str.IsPalindrome("A man, a plan, a canal: Panama."));
        }

        [Test]
        public void IsPalindrome_EmptyString_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome(""));
        }

        [Test]
        public void IsPalindrome_NonPalindrome_ReturnsFalse()
        {
            Assert.IsFalse(Str.IsPalindrome("Hello World"));
        }

        [Test]
        public void IsPalindrome_StringWithPunctuationAndSpaces_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("No 'x' in Nixon"));
        }
    }
}
