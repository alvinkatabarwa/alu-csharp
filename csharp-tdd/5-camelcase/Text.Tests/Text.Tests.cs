using NUnit.Framework;
using Text;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void CamelCase_ValidCamelCaseString_ReturnsWordCount()
        {
            Assert.AreEqual(3, Str.CamelCase("camelCaseString"));
            Assert.AreEqual(4, Str.CamelCase("thisIsATestString"));
        }

        [Test]
        public void CamelCase_EmptyString_ReturnsZero()
        {
            Assert.AreEqual(0, Str.CamelCase(""));
        }

        [Test]
        public void CamelCase_NullString_ReturnsZero()
        {
            Assert.AreEqual(0, Str.CamelCase(null));
        }
    }
}
