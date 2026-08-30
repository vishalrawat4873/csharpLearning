using System;

namespace csharpLearning.OOP.Abstraction
{
    // Abstract class
    public abstract class Figure
    {
        public double length, width, radius, height, slantHeight;

        public abstract double CalculateArea();
    }

    // Rectangle
    public class Rectangle : Figure
    {
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double CalculateArea()
        {
            return length * width;
        }
    }

    // Circle
    public class Circle : Figure
    {
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }

    // Triangle
    public class Triangle : Figure
    {
        public Triangle(double length, double height)
        {
            this.length = length;
            this.height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * length * height;
        }
    }

    // Cone
    public class Cone : Figure
    {
        public Cone(double radius, double slantHeight)
        {
            this.radius = radius;
            this.slantHeight = slantHeight;
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * slantHeight;
        }
    }

    // Main class
    public class Program
    {
        public static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(10, 5);
            Circle circle = new Circle(5);
            Triangle triangle = new Triangle(10, 5);
            Cone cone = new Cone(5, 10);

            Console.WriteLine("Rectangle Area: " + rectangle.CalculateArea());
            Console.WriteLine("Circle Area: " + circle.CalculateArea());
            Console.WriteLine("Triangle Area: " + triangle.CalculateArea());
            Console.WriteLine("Cone Area: " + cone.CalculateArea());

            Console.ReadLine();
        }
    }
}
