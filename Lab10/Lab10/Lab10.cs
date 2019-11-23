using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10
{
    class Rectangle
    {
        public uint Width { get; private set; }
        public uint Height { get; private set; }

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
        public uint Width { get; private set; }
        public uint Height { get; private set; }
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
        public uint Radius { get; private set; }
        public uint Diameter { get; private set; }
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
