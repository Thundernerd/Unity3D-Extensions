using NUnit.Framework;
using UnityEngine;

namespace TNRD.Extensions.Tests
{
    [TestFixture]
    internal class MathTests
    {
        private const float FLOAT_MAX = 10.6f;
        private const float FLOAT_MIN = 5.25f;
        private const int INT_MAX = 10;
        private const int INT_MIN = 5;

        [Test]
        public void Clamp_Float_OverMax()
        {
            float foo = Random.Range(FLOAT_MAX * 2, FLOAT_MAX * 10);
            Assert.IsTrue(foo.Clamp(FLOAT_MIN, FLOAT_MAX) == FLOAT_MAX);
        }

        [Test]
        public void Clamp_Float_UnderMin()
        {
            float foo = Random.Range(0, FLOAT_MIN * 0.95f);
            Assert.IsTrue(foo.Clamp(FLOAT_MIN, FLOAT_MAX) == FLOAT_MIN);
        }

        [Test]
        public void Clamp_Float_InBetween()
        {
            float foo = Random.Range(FLOAT_MIN, FLOAT_MAX);
            Assert.IsTrue(foo.Clamp(FLOAT_MIN, FLOAT_MAX) == foo);
        }

        [Test]
        public void Clamp_Int_OverMax()
        {
            int foo = Random.Range(INT_MAX * 2, INT_MAX * 10);
            Assert.IsTrue(foo.Clamp(INT_MIN, INT_MAX) == INT_MAX);
        }

        [Test]
        public void Clamp_Int_UnderMin()
        {
            int foo = Random.Range(0, INT_MIN);
            Assert.IsTrue(foo.Clamp(INT_MIN, INT_MAX) == INT_MIN);
        }

        [Test]
        public void Clamp_Int_InBetween()
        {
            int foo = Random.Range(INT_MIN, INT_MAX);
            Assert.IsTrue(foo.Clamp(INT_MIN, INT_MAX) == foo);
        }
    }
}
