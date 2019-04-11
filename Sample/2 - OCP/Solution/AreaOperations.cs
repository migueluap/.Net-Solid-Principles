using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.OCP.Solution
{
    public class AreaOperations
    {
        public double Sum(IEnumerable<IGeometricShape> shapes)
        {
            double area = 0;

            foreach (var shape in shapes)
                area += shape.Area(); 

            return area;
        }
    }
}
