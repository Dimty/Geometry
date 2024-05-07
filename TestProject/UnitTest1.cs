using Geometry;

namespace TestProject;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var _radius = 5;
        Shape circle = new Circle(_radius);

        var expected = Math.Floor(Math.PI * _radius * _radius);
        var actual = Math.Floor(circle.GetArea());
        
        Assert.AreEqual(expected, actual);
    }
}