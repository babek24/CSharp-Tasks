using System.ComponentModel;
using System;

namespace Null
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a method that takes two nullable integers and returns their sum. 
            //If either integer is null, treat it as zero.
            int result = Sum(null, null);
            Console.WriteLine(result);
        }

        public static int Sum(int? num1, int? num2)
        {
            if (!num1.HasValue)
            {
                num1 = 0;
            }
            if (!num2.HasValue)
            { 
                num2 = 0;
            }
            return num1.Value+num2.Value;   
        }

    }
}
