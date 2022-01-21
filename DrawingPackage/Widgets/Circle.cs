using System;
using System.Collections.Generic;
using System.Text;

namespace DrawingPackage.Widgets
{
    public class Circle : Widget
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Size { get; set; }

        public Circle(int x, int y, int size)
        {
            X = RequireNonNegative(x, nameof(x));
            Y = RequireNonNegative(y, nameof(y));
            Size = RequireNonNegative(size, nameof(size));
        }

        public override string ToString()
        {
            return $"Circle ({X},{Y}) size={Size}";
        }
    }
}
