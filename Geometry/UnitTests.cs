using Geometry;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometryTest;

[TestClass]
public class GeometryLibTest
{
    [TestMethod]
    public void TriangleAreaTest()
    {
        double a = 3.0d;
        double b = 4.0d;
        double c = 5.0d;
        double expected = 6;

        Shape triangle = new Triangle(a, b, c);
        var actual = triangle.GetArea();

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CircleAreaTest()
    {
        double r = 1.0d;
        double expected = Math.PI;

        Shape triangle = new Circle(r);
        var actual = triangle.GetArea();

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TriangleIsRectangularTest()
    {
        double a = 3.0d;
        double b = 4.0d;
        double c = 5.0d;

        ITypeOfTriangle triangle = new Triangle(a, b, c);
        var actual = triangle.IsRectangular();

        Assert.IsTrue(actual);
    }
}