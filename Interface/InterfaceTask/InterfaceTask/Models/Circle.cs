using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask.Models
{
    internal class Circle : IShape
    {
        public double Radius {  get; set; } 
        public double GetArea()
        {
            double Area=Radius*Radius*Math.PI;
            return Area;
        }
    }
}
