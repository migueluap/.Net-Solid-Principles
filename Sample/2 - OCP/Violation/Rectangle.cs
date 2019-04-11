using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.OCP.Violation
{
    public class Rectangle
    {
        public double Sides { get; } = 4;
        public double Height { get; set; }
        public double Width { get; set; }
    }
}
