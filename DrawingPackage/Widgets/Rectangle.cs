using DrawingPackage.Interfaces;
using System;

namespace DrawingPackage.Widgets
{
    public class Rectangle : Widget
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int x, int y, int width, int height)
        {
            X = RequireNonNegative(x, nameof(x));
            Y = RequireNonNegative(y, nameof(y));
            Width = RequireNonNegative(width, nameof(width));
            Height = RequireNonNegative(height, nameof(height));
        }

        public override string ToString()
        {
            return $"Rectangle ({X},{Y}) width={Width} height={Height}";
        }
    }
}
