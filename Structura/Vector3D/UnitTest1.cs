using System;

namespace VectorStruct.UnitTests
{
    [TestFixture]
    public class Vector3DTests
    {
        [Test]
        public void ConstructorTest()
        {
            var v = new Vector3D(1.5, 2.5, 3.5);
            Assert.That(v.X, Is.EqualTo(1.5));
            Assert.That(v.Y, Is.EqualTo(2.5));
            Assert.That(v.Z, Is.EqualTo(3.5));
        }

        [Test]
        public void LengthTest()
        {
            var v = new Vector3D(1, 2, 2);
            Assert.That(v.Length, Is.EqualTo(3).Within(1e-13));
        }

        [TestCase(1, 2, 3, "(1, 2, 3)")]
        [TestCase(0, 0, 0, "(0, 0, 0)")]
        [TestCase(-1, -2, -3, "(-1, -2, -3)")]
        public void ToStringTest(double x, double y, double z, string expected)
        {
            var v = new Vector3D(x, y, z);
            Assert.That(v.ToString(), Is.EqualTo(expected));
        }

        [TestCase(1, 2, 3, 1, 2, 3, true)]
        [TestCase(1, 2, 3, 1, 2, 4, false)]
        public void EqualsTest(double x1, double y1, double z1,
                             double x2, double y2, double z2, bool expected)
        {
            var v1 = new Vector3D(x1, y1, z1);
            var v2 = new Vector3D(x2, y2, z2);
            Assert.That(v1.Equals(v2), Is.EqualTo(expected));
        }

        [Test]
        public void GetHashCodeTest()
        {
            var v1 = new Vector3D(1, 2, 3);
            var v2 = new Vector3D(1, 2, 3);
            var v3 = new Vector3D(1, 2, 4);

            Assert.That(v1.GetHashCode(), Is.EqualTo(v2.GetHashCode()));
            Assert.That(v1.GetHashCode(), Is.Not.EqualTo(v3.GetHashCode()));
        }

        [TestCase(1, 2, 3, 4, 5, 6, 5, 7, 9)]
        [TestCase(0, 0, 0, 1, 1, 1, 1, 1, 1)]
        public void AdditionTest(double x1, double y1, double z1,
                               double x2, double y2, double z2,
                               double xr, double yr, double zr)
        {
            var v1 = new Vector3D(x1, y1, z1);
            var v2 = new Vector3D(x2, y2, z2);
            var result = new Vector3D(xr, yr, zr);

            Assert.That(v1 + v2, Is.EqualTo(result));
        }

        [TestCase(1, 2, 3, 2, 2, 4, 6)]
        public void ScalarMultiplicationTest(double x, double y, double z,
                                           double scalar,
                                           double xr, double yr, double zr)
        {
            var v = new Vector3D(x, y, z);
            var result = new Vector3D(xr, yr, zr);

            Assert.That(v * scalar, Is.EqualTo(result));
            Assert.That(scalar * v, Is.EqualTo(result));
        }

        [TestCase(1, 2, 3, 4, 5, 6, 32)] 
        public void DotProductTest(double x1, double y1, double z1,
                                 double x2, double y2, double z2,
                                 double expected)
        {
            var v1 = new Vector3D(x1, y1, z1);
            var v2 = new Vector3D(x2, y2, z2);

            Assert.That(v1 * v2, Is.EqualTo(expected).Within(1e-13));
        }

        [TestCase(1, 0, 0, 0, 1, 0, 0, 0, 1)] 
        public void CrossProductTest(double x1, double y1, double z1,
                                   double x2, double y2, double z2,
                                   double xr, double yr, double zr)
        {
            var v1 = new Vector3D(x1, y1, z1);
            var v2 = new Vector3D(x2, y2, z2);
            var result = new Vector3D(xr, yr, zr);

            Assert.That(v1 ^ v2, Is.EqualTo(result));
        }
    }
}