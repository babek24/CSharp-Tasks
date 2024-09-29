using InterfaceTask.Models;

namespace InterfaceTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Define an interface IShape with a method GetArea() that returns a double. 
            Implement this interface in a class Circle that has a constructor accepting the radius and calculates the area.

            */

            Circle circle = new Circle();
            circle.Radius = 10;
            double Area = circle.GetArea();
            Console.WriteLine(Area);
        }

    }
}
