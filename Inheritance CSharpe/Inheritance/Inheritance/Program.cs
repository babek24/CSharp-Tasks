using Inheritance.Models;
using Microsoft.VisualBasic;
using System.Reflection;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Task 6 : Create a C# program that demonstrates the concept of inheritance. Follow these steps:

Create a class called Vehicle.

The Vehicle class should have the following attributes:
make: The make of the vehicle.
model: The model of the vehicle.
        year: The year the vehicle was manufactured.

Define a method within the class called display_info() that prints out all the information about the vehicle(make, model, and year).

Create a class called Car that inherits from the Vehicle class.
Add an additional attribute to the Car class:
mileage: The current mileage of the car.
Override the display_info() method in the Car class to also display the mileage of the car.
Create an object of the Car class and display its information.*/
           Car car = new Car();
            car.Model = "X5";
            car.Brand = "BMW";
            car.Year = 2003;
            car.Mileage = 150000;
            car.display_info();
        }
}
}
