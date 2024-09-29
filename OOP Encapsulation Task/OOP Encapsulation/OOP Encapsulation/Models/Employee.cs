using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Encapsulation.Models
{
    internal class Employee
    {
        private string _employeeName;
        private double _salary;



        public double GetSalary()
        {

            return _salary;

        }

        public void SetSalary(double Salary)
        {
            if (Salary < 0)
            {
                Console.WriteLine("Salary is not correct");
                return;
            }
            _salary = Salary;

        }
        public string GetEmployeeName()
        {
            return _employeeName;
        }
        public void SetEmployeeName(string EmployeeName)

        {
            if (string.IsNullOrWhiteSpace(EmployeeName))
            {
                Console.WriteLine("Adi duzgun daxil ele");
                return;
            }
            _employeeName = EmployeeName;
        }
    }
}
