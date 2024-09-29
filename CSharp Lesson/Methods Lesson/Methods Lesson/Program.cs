namespace Methods_Lesson
{
    internal class Program
    {
        static void Main(string[] args)
            //ForEach Array icerisindeki ededleri cap et
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //Console.WriteLine(numbers); bele yazsaq sistemin formatini qaytarir
            //Ona gore For la loop yaziriq
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
