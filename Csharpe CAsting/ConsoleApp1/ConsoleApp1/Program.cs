using System.Threading.Channels;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Zehmet olmasa ededi daxil edin");
              int Number=int.Parse(Console.ReadLine());
            */

            Console.WriteLine("Enter month number");
            int Season = int.Parse(Console.ReadLine());
            switch (Season)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Winter");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Spring");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Summer");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Autumn");
                    break;
                default:
                    Console.WriteLine("Number should be between 1 and 12");
                    break;







            }
            //task 2
            Console.WriteLine("Enter your Letter");

            char letter = char.Parse(Console.ReadLine());
            switch (letter)
            {
                case 'a':
                case 'i':
                case 'o':
                case 'u':
                case 'e':
                    Console.WriteLine("Letter is vowel");
                    break;
                default:
                    Console.WriteLine("Letter is consonant");
                    break;



            }
            //--------------------TASK 3-------------------
            Console.WriteLine("Enter sides of triangle");
            Console.WriteLine("Enter First Side");
            double side1 = double.Parse(Console.ReadLine());


            Console.WriteLine("Enter Second Side");

            double side2 = double.Parse(Console.ReadLine());


            Console.WriteLine("Enter Third Side");

            double side3 = double.Parse(Console.ReadLine());
            if (side1 > 0 && side2 > 0 && side3 > 0)
            {



             if (side3 == side1 && side2 == side1)
                {
                    Console.WriteLine(" Triangle is Equilateral");
                }
                else if (side3 == side1 || side3 == side2)
                {
                    Console.WriteLine(" Triangle is Isosceles");
                }
                else
                {
                    Console.WriteLine("Triangle is Scalene");
                }


            }
        }
        // ----------------------------TASK4----------------------------------- 
        /*string type1 = "10";
        string type2= "2.5";
        string type3 = "Hello";
        string[] types = { "10", "2.5", "Hello" };
        Console.WriteLine(types[0]);
       */

      
        
        
    }
}