using System.Drawing;
using System.Security.AccessControl;

namespace Task6;

// Структура, що описує точку в тривимірній системі координат
public struct Point3D
{
    public double X { get; }
    public double Y { get; }
    public double Z { get; }

    public Point3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public static Point3D operator +(Point3D p1, Point3D p2)
    {
        return new Point3D(p1.X + p2.X, p1.Y + p2.Y, p1.Z + p2.Z);
    }

    public override string ToString()
    {
        return $"({X}, {Y}, {Z})";
    }
}