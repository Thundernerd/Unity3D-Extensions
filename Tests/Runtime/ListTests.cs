using System.Collections.Generic;
using NUnit.Framework;

namespace TNRD.Extensions.Tests
{
    [TestFixture]
    public class ListTests
    {
        [Test]
        public void IsNullOrEmpty_Null()
        {
            List<int> dummy = null;
            Assert.IsTrue(dummy.IsNullOrEmpty());
        }

        [Test]
        public void IsNullOrEmpty_Empty()
        {
            List<int> dummy = new List<int>();
            Assert.IsTrue(dummy.IsNullOrEmpty());
        }

        [Test]
        public void IsNullOrEmpty_Filled()
        {
            List<int> dummy = new List<int>
            {
                1, 2, 3, 4, 5
            };
            Assert.IsFalse(dummy.IsNullOrEmpty());
        }
    }
}
