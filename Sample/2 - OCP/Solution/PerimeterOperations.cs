using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.OCP.Solution
{
    public class PerimeterOperations
    {
        public double Sum(IEnumerable<IGeometricShape> shapes)
        {
            double perimeter = 0;

            foreach (var shape in shapes)
                perimeter += shape.Perimeter();

            return perimeter;
        }
    }
}
