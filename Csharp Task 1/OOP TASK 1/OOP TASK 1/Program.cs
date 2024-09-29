using OOP_TASK_1.Models;

namespace OOP_TASK_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
             /*
             Bir İşçi sinifi yaradın.Proqramçı, Müəllim, Sürücü adında siniflər işçi sinifindən miras alsın.
             Hər bir işçinin özünə xas iş saatı, günlük və ya aylıq aldığı maaş olsun.
             CalculateSalary adında metodla bu işçilərin maaşlarını hesablayıb ekrana çıxarın.
             */
             Teacher teacher=new Teacher("Teacher", 150, 3); 
             Driver driver = new Driver("Driver", 200, 3);
             Programmer programmer = new Programmer("Programmer", 150, 3);
             teacher.CalculateSalary();
             driver.CalculateSalary();
             programmer.CalculateSalary();
             




        }
    }
}
