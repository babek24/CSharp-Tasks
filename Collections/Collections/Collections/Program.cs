using System.Collections.Generic;
using System.Xml;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Remove Duplicates from a List

             Create a List<int> with some duplicate numbers.
             Remove the duplicates and print the list with unique values only.*/

            /*
            HashSet <int> list = new HashSet<int>();
            list.Add(1);    
            list.Add(2);
            list.Add(3);
            list.Add(1);
            list.Add(2);

            foreach (int i in list)

            {
                Console.WriteLine(i);
            }   
            */
            Console.WriteLine("Enter numbers");
            string numbers = Console.ReadLine();
            string number = numbers.Split(' ');
            
            List <int> list = new List<int>();  
            
        }
    }
}
