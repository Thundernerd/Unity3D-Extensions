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
        public void SingleIsWithinBounds()
        {
            int length = Random.Range(MIN, MAX);
            int[] array = new int[length];
            Assert.IsTrue(array.IsWithinBounds(Random.Range(0, length - 1)));
        }

        [Test]
        public void MultiIsWithinBounds()
        {
            int first = Random.Range(MIN, MAX);
            int second = Random.Range(MIN, MAX);
            int[,] array = new int[first, second];
            Assert.IsTrue(array.IsWithinBounds(Random.Range(0, first - 1), 0));
            Assert.IsTrue(array.IsWithinBounds(Random.Range(0, second - 1), 1));
        }

        [Test]
        public void SingleIsNotWithinBounds()
        {
            int length = Random.Range(MIN, MAX);
            int[] array = new int[length];
            Assert.IsFalse(array.IsWithinBounds(MAX + 1));
        }

        [Test]
        public void MultiIsNotWithinBounds()
        {
            int first = Random.Range(MIN, MAX);
            int second = Random.Range(MIN, MAX);
            int[,] array = new int[first, second];
            Assert.IsFalse(array.IsWithinBounds(MAX + 1, 0));
            Assert.IsFalse(array.IsWithinBounds(MAX + 1, 1));
        }
    }
}
