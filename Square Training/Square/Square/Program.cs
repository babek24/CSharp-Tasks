using Square.Extention;

namespace Square
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter your Number");
           double number= double.Parse(Console.ReadLine());
           Console.WriteLine(number.toSquare());
        }
    }
}
