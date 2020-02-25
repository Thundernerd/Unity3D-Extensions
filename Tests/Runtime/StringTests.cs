using NUnit.Framework;

namespace TNRD.Extensions.Tests
{
    [TestFixture]
    internal class StringTests
    {
        [Test]
        public void IsNullOrEmpty_Null()
        {
            string foo = null;
            Assert.IsTrue(foo.IsNullOrEmpty());
        }

        [Test]
        public void IsNullOrEmpty_Empty()
        {
            Assert.IsTrue("".IsNullOrEmpty());
        }

        [Test]
        public void IsNullOrEmpty_Filled()
        {
            Assert.IsFalse("Hello, World!".IsNullOrEmpty());
        }

        [Test]
        public void IsNullOrWhiteSpace_Null()
        {
            string foo = null;
            Assert.IsTrue(foo.IsNullOrWhiteSpace());
        }

        [Test]
        public void IsNullOrWhiteSpace_WhiteSpace()
        {
            Assert.IsTrue(" ".IsNullOrWhiteSpace());
        }

        [Test]
        public void IsNullOrWhiteSpace_Filled()
        {
            Assert.IsFalse("Hello, World!".IsNullOrWhiteSpace());
        }
    }
}
