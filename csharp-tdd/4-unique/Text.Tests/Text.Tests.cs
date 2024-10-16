using NUnit.Framework;
using Text;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void UniqueChar_FirstUniqueChar_ReturnsIndex()
        {
            Assert.AreEqual(0, Str.UniqueChar("abac"));
            Assert.AreEqual(1, Str.UniqueChar("aabbc"));
        }

        [Test]
        public void UniqueChar_NoUniqueChar_ReturnsMinusOne()
        {
            Assert.AreEqual(-1, Str.UniqueChar("aabbcc"));
        }

        [Test]
        public void UniqueChar_EmptyString_ReturnsMinusOne()
        {
            Assert.AreEqual(-1, Str.UniqueChar(""));
        }
    }
}
