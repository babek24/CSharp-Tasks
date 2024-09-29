using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    internal abstract class Vehicle
    {
        public string Brand {  get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public virtual void display_info()
        {
            Console.WriteLine(Brand + " " + Model + " "+ Year);
            
        }
    }
}
