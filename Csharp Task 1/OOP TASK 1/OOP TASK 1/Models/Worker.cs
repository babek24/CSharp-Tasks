using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TASK_1.Models
{
    internal abstract class Worker
    {
        public string Name { get; set; }   
        public int Workhour { get; set; }
        public double HourlySalary { get; set; }

        public Worker(string Name,int Workhour, double HourlySalary)
        {
            this.Name = Name;
            this.Workhour = Workhour;
            this.HourlySalary = HourlySalary;
            
        }

        public virtual void CalculateSalary()
        {
          double MonthlySalary = Workhour * HourlySalary;
          double DaylySalary = HourlySalary * 8;

          Console.WriteLine($"{Name} Monthly Salary = {MonthlySalary} \n Dayly Salary = {DaylySalary}");

        }
    }
}
