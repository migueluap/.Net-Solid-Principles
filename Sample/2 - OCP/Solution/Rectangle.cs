﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.OCP.Solution
{
    public class Rectangle : IGeometricShape
    {
        public double Sides { get; } = 4;
        public double Height { get; set; }
        public double Width { get; set; }

        public double Area()
        {
            return Height * Width;
        }

        public double Perimeter()
        {
            return Height * 2 + Width * 2;
        }
    }
}
