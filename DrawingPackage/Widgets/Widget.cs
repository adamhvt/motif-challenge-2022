using DrawingPackage.Interfaces;
using System;

namespace DrawingPackage.Widgets
{
    public abstract class Widget : IWidget
    {
        public void Draw()
        {
            Console.WriteLine(ToString());
        }

        protected int RequireNonNegative(int value, string parameterName)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(parameterName, value, "Value must be positive");
            }

            return value;
        }

        protected string RequireNonEmpty(string value, string parameterName)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(parameterName);
            }

            return value;
        }
    }
}
