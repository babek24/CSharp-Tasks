using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    internal class Car: Vehicle
    {
        public int Mileage {  get; set; }
        public override void display_info()

        {
            Console.WriteLine(Mileage);
            base.display_info();
        }

    }
}
