namespace TRY_CATCH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = null;
            try
            {
               
                try
                {
                    Console.Write("Enter the number of elements: ");
                    int size = int.Parse(Console.ReadLine());
                    array = new int[size];

                    for (int i = 0; i < size; i++)
                    {
                        Console.Write($"Enter element {i}: ");
                        array[i] = int.Parse(Console.ReadLine());
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Invalid number format. ");
                    return; 
                }

                
                try
                {
                    Console.Write("Enter index to access: ");
                    int index = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Element at index {index}: {array[index]}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Invalid index format. ");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Error: Index out of range. ");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occurred: ");
            }
            finally
            {
                Console.WriteLine("Program execution has finished.");
            }
        }
    }
}
