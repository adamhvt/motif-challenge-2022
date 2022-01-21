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
                // Create new repository instance here


                // ...Add(new Rectangle(15, 20, 40, 60));
                // ...Add(new Circle(10, 0, 240));
                // ...Add(new Textbox(30, 5, 200, 10, "sample text"));

                
                // Query widgets from the repository here


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
