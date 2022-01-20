using DrawingPackage.Widgets;
using System;

namespace DrawingPackage
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // ...AddWidget(new Rectangle(10, 10, 30, 40));
                // ...AddWidget(new Square(15, 30, 35));
                // ...AddWidget(new Circle(1, 1, 300));
                // ...AddWidget(new TextBox(5, 5, 200, 100, "sample text"));

                // ...Draw();

                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
