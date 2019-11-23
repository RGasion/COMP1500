using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10
{
    class Rectangle
    {
        public uint mWidth;
        public uint mHeight;
        public Rectangle(uint width, uint height)
        {
            mWidth = width;
            mHeight = height;
        }

        public uint Width
        {
            get
            {
                return mWidth;
            }
            set
            {
                if (value < 0)
                {
                    mWidth = 0;
                }
            }
        }

        public uint Height
        {
            get
            {
                return mHeight;
            }
            set
            {
                if (value < 0)
                {
                    mHeight = 0;
                }
            }
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
