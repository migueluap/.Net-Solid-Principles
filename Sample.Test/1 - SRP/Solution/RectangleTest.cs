using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sample.SRP.Solution;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Test.SRP.Solution
{
    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void Single_Responsability_Principle_Violation()
        {
            var rectangles = new[]
            {
                new Rectangle { Width = 10, Height = 5},
                new Rectangle { Width = 4, Height = 6},
                new Rectangle { Width = 5, Height = 1},
                new Rectangle { Width = 8, Height = 9}
            };

            var sumAreas = new AreaOperations().Sum(rectangles);
            var sumPerimetro = new PerimeterOperations().Sum(rectangles);
        }
    }
}
