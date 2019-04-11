using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.LSP.Violation
{
    public class Square : Rectangle
    {
        public override double Height
        {

            set { base.Height = base.Width = value; }
        }

        public override double Width { get => base.Width; set => base.Width = value; }
    }
}
