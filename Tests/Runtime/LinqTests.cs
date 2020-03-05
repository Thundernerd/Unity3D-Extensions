using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace TNRD.Extensions.Tests
{
    [TestFixture]
    public class LinqTests
    {
        [Test]
        public void None()
        {
            List<int> dummy = new List<int>
            {
                1, 2, 4, 5
            };

            Assert.IsTrue(dummy.None(x => x == 3));
        }
    }
}
