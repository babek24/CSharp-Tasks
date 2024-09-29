using OOP_Encapsulation;
using OOP_Encapsulation.Models;
/*Task 1 : Create a C# program that demonstrates the concept of encapsulation. Follow these steps:

Create a class called Employee.
The Employee class should have the following attributes:
name: The name of the employee.
salary: The salary of the employee.
Encapsulate the salary attribute so that it cannot be accessed directly from outside the class.
Provide methods to set and get the salary attribute.
Create an object of the Employee class, set its salary, and then display the salary using the appropriate method.

Task 2 : Bir Kitab sinfi yaradın. Constructor ilə Kitab adı, yazıçı və səhifə sayını qeyd edin. Bütün verilənləri ekrana çıxarın.*/


/*Employee employee=new Employee();
employee.SetEmployeeName("RadomName");
employee.SetSalary(2000);
Console.WriteLine(employee.GetSalary());
Console.WriteLine(employee.GetEmployeeName());
*/
Book book = new Book("Qirmizi Kitab", "Memmed", 200);
Console.WriteLine(book.Name);
Console.WriteLine(book.Author);
Console.WriteLine(book.Page);
