using MindBox;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MindBox.Tests
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void Triangle_4_5_6()
        {
            Triangle triangle = new Triangle("Треугольник", 4, 5, 6);
            double expected = 10;

            double result = triangle.Calculate();

            Assert.AreEqual(expected, result);
        }
    }

    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void Circle_6()
        {
            Circle circle = new Circle("Круг", 6);
            double expected = 8;

            double result = circle.Calculate();

            Assert.AreEqual(expected, result);
        }
    }
}