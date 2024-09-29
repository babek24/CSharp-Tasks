using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*{



                Console.WriteLine("Enter your number");
                double Num = double.Parse(Console.ReadLine());
                if (Num < 0)
                {
                    Console.WriteLine("Number is Negative");
                }
                else if (Num > 0)
                {
                    Console.WriteLine("Number is Positive");
                }
                else
                {
                    Console.WriteLine("Num is Zero");
                }
            }*/
            
            {
                Console.WriteLine("Enter only words");
                string objectX = Console.ReadLine();
                int count = 0;
                for (int i = 0; i < objectX.Length; i++)

                    if (char.IsDigit(objectX[i]))
                    {
                        {
                            count++;
                            if (count > 0) { Console.WriteLine("You can not use Digit"); }
                            break;
                        }
                    }
                    else
                    {
                        return;
                    }

                    }
            }
        }    
    }
}
