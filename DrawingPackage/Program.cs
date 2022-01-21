using DrawingPackage.Interfaces;
using DrawingPackage.Widgets;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DrawingPackage
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IWidgetRepository widgetRepository = new WidgetRepository();
                widgetRepository.Add(new Rectangle(15, 20, 40, 60));
                widgetRepository.Add(new Circle(10, 0, 240));
                widgetRepository.Add(new Textbox(30, 5, 200, 10, "sample text"));
                foreach (var widget in widgetRepository.GetWidgets())
                {
                    widget.Draw();
                }

                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
