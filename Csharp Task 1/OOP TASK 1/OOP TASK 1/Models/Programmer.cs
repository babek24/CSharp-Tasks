using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TASK_1.Models
{
    internal class Programmer:Worker
    {
        public Programmer (string Name, int Workhour, double HourlySalary) : base(Name, Workhour, HourlySalary)
        {

        }
        public override void CalculateSalary()
        {
            HourlySalary=1.5*HourlySalary;
            base.CalculateSalary();
        }
    }
}
