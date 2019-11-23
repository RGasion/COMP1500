using System;
using System.Diagnostics;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle(5, 5);

            Debug.Assert(rectangle1.Width == 5);
            Debug.Assert(rectangle1.Height == 5);

            Debug.Assert(rectangle1.GetPerimeter() == 20.000);
            Debug.Assert(rectangle1.GetArea() == 25.000);

            Rectangle rectangle2 = new Rectangle(10, 4);

            Debug.Assert(rectangle2.Width == 10);
            Debug.Assert(rectangle2.Height == 4);

            Debug.Assert(rectangle2.GetPerimeter() == 28.000);
            Debug.Assert(rectangle2.GetArea() == 40.000);

            RightTriangle triangle1 = new RightTriangle(4, 7);

            Debug.Assert(triangle1.Width == 4);
            Debug.Assert(triangle1.Height == 7);

            Debug.Assert(triangle1.GetPerimeter() == 19.062);
            Debug.Assert(triangle1.GetArea() == 14.000);

            RightTriangle triangle2 = new RightTriangle(7, 2);

            Debug.Assert(triangle2.Width == 7);
            Debug.Assert(triangle2.Height == 2);

            Debug.Assert(triangle2.GetPerimeter() == 16.280);
            Debug.Assert(triangle2.GetArea() == 7.000);

            Circle circle1 = new Circle(8);

            Debug.Assert(circle1.Radius == 8);
            Debug.Assert(circle1.Diameter == 16);

            Debug.Assert(circle1.GetCircumference() == 50.265);
            Debug.Assert(circle1.GetArea() == 201.062);

            Circle circle2 = new Circle(4);

            Debug.Assert(circle2.Radius == 4);
            Debug.Assert(circle2.Diameter == 8);

            Debug.Assert(circle2.GetCircumference() == 25.133);
            Debug.Assert(circle2.GetArea() == 50.265);
        }
    }

    class Rectangle
    {
        public uint Width;
        public uint Height;
        public Rectangle(uint width, uint height)
        {
            Width = width;
            Height = height;
        }
        public double GetPerimeter()
        {
            return (double)(2 * (Width + Height));
        }

        public double GetArea()
        {
            return Math.Round((double)Width * Height, 3);
        }
    }

    class RightTriangle
    {
        public uint Width;
        public uint Height;
        public RightTriangle(uint width, uint height)
        {
            Width = width;
            Height = height;
        }
        public double GetPerimeter()
        {
            return Math.Round(Width + Height + Math.Sqrt((double)(Width * Width + Height * Height)), 3);
        }

        public double GetArea()
        {
            return Math.Round((double)(Width * Height) / 2, 3);
        }
    }

    class Circle
    {
        public uint Radius;
        public uint Diameter;
        public Circle(uint radius)
        {
            Radius = radius;
            Diameter = radius * 2;
        }
        public double GetCircumference()
        {
            return Math.Round(Diameter * Math.PI, 3);
        }

        public double GetArea()
        {
            return Math.Round(Radius * Radius * Math.PI, 3);
        }
    }
}
