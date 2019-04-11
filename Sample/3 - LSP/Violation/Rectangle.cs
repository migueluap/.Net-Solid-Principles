using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.LSP.Violation
{
    public class Rectangle
    {
        public virtual double Sides { get; } = 4;
        public virtual double Height { get; set; }
        public virtual double Width { get; set; }
    }
}
