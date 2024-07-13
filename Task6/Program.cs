using System.Drawing;
using Task6;

class Program
{
    static void Main(string[] args)
    {
        // Створення двох точок
        Point3D point1 = new Point3D(1.0, 2.0, 3.0);
        Point3D point2 = new Point3D(4.0, 5.0, 6.0);
    
        // Складання двох точок
        Point3D result = point1 + point2;
    
        // Виведення результату
        Console.WriteLine($"Point1: {point1}");
        Console.WriteLine($"Point2: {point2}");
        Console.WriteLine($"Result: {result}");

    }
}