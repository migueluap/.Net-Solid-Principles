using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.SRP.Solution
{
    public class PerimeterOperations
    {
        public double Sum(IEnumerable<Rectangle> rectangles)
        {
            double perimeter = 0;

            foreach (var rectangle in rectangles)
                perimeter += 2 * rectangle.Height + 2 * rectangle.Width;

            return perimeter;
        }
    }
}
