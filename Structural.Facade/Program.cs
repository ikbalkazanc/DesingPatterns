using System;

namespace Structural.Facade
{
    class Program
    {
        static void Main(string[] args)
        {

            var drawer = new ShapeDrawer();

            drawer.Draw("circle");

            drawer.Draw("triangle");

            Console.WriteLine("HALT");
        }
    }
}
