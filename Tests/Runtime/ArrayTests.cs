using System;
using NUnit.Framework;
using Random = UnityEngine.Random;

namespace TNRD.Extensions.Tests
{
    [TestFixture]
    public class ArrayTests
    {
        private const int MIN = 10;
        private const int MAX = 100;

        [Test]
        public void IsWithinBounds()
        {
            int length = Random.Range(MIN, MAX);
            int[] array = new int[length];
            Assert.IsTrue(array.IsWithinBounds(Random.Range(0, length - 1)));
        }

        [Test]
        public void IsNotWithinBounds()
        {
            int length = Random.Range(MIN, MAX);
            int[] array = new int[length];
            Assert.IsFalse(array.IsWithinBounds(MAX + 1));
        }
    }
}
