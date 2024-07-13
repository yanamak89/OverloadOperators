using System.Drawing;
using NUnit.Framework;
using Task6;

[TestFixture]
public class Point3DTests
{
    [Test]
    public void TestPoint3DConstructor()
    {
        //Arrange
        double x = 1.0, y = 2.0, z = 3.0;

        //Act
        Point3D point = new Point3D(x, y, z);

        //Assert
        Assert.AreEqual(x, point.X);
        Assert.AreEqual(y, point.Y);
        Assert.AreEqual(z, point.Z);
    }

    [Test]
    public void TestPoint3DAddition()
    {
        //Arrange
        Point3D point1 = new Point3D(1.0, 2.0, 3.0);
        Point3D point2 = new Point3D(4.0, 5.0, 6.0);
        
        //Act
        Point3D result = point1 + point2;
        
        //Assert
        Assert.AreEqual(5.0, result.X);
        Assert.AreEqual(7.0, result.Y);
        Assert.AreEqual(9.0, result.Z);
    }

    [Test]
    public void TestPoint3DToString()
    {
        //Arrange
        Point3D point = new Point3D(1.0, 2.0, 3.0);
        string expected = "(1, 2, 3)";
        
        //Act 
        string result = point.ToString();
        
        //Assert
        Assert.AreEqual(expected, result);
    }
}