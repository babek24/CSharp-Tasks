using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            #region GoTo Foreach
            /*
            {  //ForEach Array icerisindeki ededleri cap et
                {
                    Console.WriteLine("Loop istifade ederek arrayin daxilini cap etmek");
                    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
                    //Console.WriteLine(numbers); bele yazsaq sistemin formatini qaytarir
                    //Ona gore For la loop yaziriq
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        Console.WriteLine(numbers[i]);
                    }

                    // ForEachle yazilis(int array daxilindeki verilenlerin type-di) 

                    foreach (int number in numbers)
                    {
                        Console.WriteLine(number);
                    }
                    // For indeks mentiqi ile isleyir Foreach obyekt mentiqi ile isleyir
                    // Key-ler var idi "break" ve "continue"


                }
                {//Bu continuedir, bele odugu halda indeksin qiymetine beraber ededi cap etmir
                    Console.WriteLine("Continue hali ucun");
                    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (numbers[i] == 5)
                        {
                            continue;
                        }
                        Console.WriteLine(numbers[i]);
                    }
                }
                {//break verdiyimiz halda ise indeksin qiymetine beraber olan edede catanda  qirilir
                    Console.WriteLine("Break hali");
                    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (numbers[i] == 5)
                        {
                            break;
                        }
                        Console.WriteLine(numbers[i]);
                    }
                }
                {// "goto" oldugu halda. Debugda bax basa dusmek ucun
                    Console.WriteLine("GoTo Misali");
                    int number = 5;
                test:
                    Console.WriteLine("Test1 isledi");
                    Console.WriteLine("Test2 Isledi");
                    if (number == 5)
                    {
                        Console.WriteLine("goto calisdi");
                        number++;
                        goto test;
                    }
                }
            }*/
            #endregion
            #region do while
            // WHILE, DO WHILE
            /*{// While isle yazildiqda 
              bool isContinue =true;
                  while (isContinue)
                  {
                      Console.WriteLine("Enter your first number");
                      double number1 = double.Parse(Console.ReadLine());
                      Console.WriteLine("Enter your second number");
                      double number2 = double.Parse(Console.ReadLine());

                      string operations = "1. +\n" +
                          "2. -\n" + "3. *\n" + "4. :\n" + "0. Exit\n";
                      Console.WriteLine(operations);
                      Console.WriteLine("Enter operation number");
                      int operationNumber = int.Parse(Console.ReadLine());
                      switch (operationNumber)
                      {
                          case 1:
                              double sum = number1 + number2;
                              Console.WriteLine($"Sum: {sum}");
                              break;
                          case 2:
                              double substraction = number1 - number2;
                              Console.WriteLine($" substraction: {substraction}");
                              break;
                          case 3:
                              double multp = number1 * number2;
                              Console.WriteLine($"multp: {multp}");
                              break;
                          case 4:
                              double division = number1 / number2;
                              Console.WriteLine($"division: {division}");
                              break;
                          case 0:
                              isContinue = false;
                              break;
                          default:
                              Console.WriteLine("Enter valid operation number");
                              break;

                      }
                  }*/






            // DO WHILE ile yazildiqda

            /* bool isContinue = true;
             do
           {
              Console.WriteLine("Enter your first number");
              double number1 = double.Parse(Console.ReadLine());
              Console.WriteLine("Enter your second number");
              double number2 = double.Parse(Console.ReadLine());

              string operations = "1. +\n" +
                  "2. -\n" + "3. *\n" + "4. :\n" + "0. Exit\n";
              Console.WriteLine(operations);
              Console.WriteLine("Enter operation number");
              int operationNumber = int.Parse(Console.ReadLine());
              switch (operationNumber)
              {
                  case 1:
                      double sum = number1 + number2;
                      Console.WriteLine($"Sum: {sum}");
                      break;
                  case 2:
                      double substraction = number1 - number2;
                      Console.WriteLine($" substraction: {substraction}");
                      break;
                  case 3:
                      double multp = number1 * number2;
                      Console.WriteLine($"multp: {multp}");
                      break;
                  case 4:
                      if(number2==0)
                      { Console.WriteLine("you can not divide zero");
                      break;
                      }
                      double division = number1 / number2;
                      Console.WriteLine($"division: {division}");
                      break;
                  case 0:
                      isContinue = false;
                      break;
                  default:
                      Console.WriteLine("Enter valid operation number");
                      break;
              }

          }
          while (isContinue);
         }*/
            #endregion
            #region Method
            Sum();

            {
                bool isContinue = true;
                while (isContinue)
                {
                    Console.WriteLine("Enter your first number");
                    double number1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter your second number");
                    double number2 = double.Parse(Console.ReadLine());

                    string operations = "1. +\n" +
                        "2. -\n" + "3. *\n" + "4. :\n" + "0. Exit\n";
                    Console.WriteLine(operations);
                    Console.WriteLine("Enter operation number");
                    int operationNumber = int.Parse(Console.ReadLine());
                    switch (operationNumber)
                    {
                        case 1:
                            double sum = Sum();
                            Console.WriteLine($"SUM= {sum}");
                            break;
                        case 2:
                            double substruc = Substrac();
                            Console.WriteLine($"Substrac= {substruc}");
                            break;
                        case 3:
                            double multp = Multp();
                            Console.WriteLine($"Multp= {multp}");
                            break;
                        case 4:
                            double division = Division();
                            Console.WriteLine($"Division= {division}");
                            break;
                        case 0:
                            isContinue = false;
                            break;
                        default:
                            Console.WriteLine("Enter valid operation number");
                            break;

                    }
                }

            }

        }

        static double Sum()
        {
            Console.Write("Enter number 1");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter number 2");
            int number2 = int.Parse(Console.ReadLine());
            double sum = number1 + number2;
            return sum;


        }
        static double Substrac()
        {
            Console.Write("Enter number 1");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter number 2");
            int number2 = int.Parse(Console.ReadLine());

            double substrac = number1 - number2;
            return substrac;

        }
        static double Multp()
        {
            Console.Write("Enter number 1");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter number 2");
            int number2 = int.Parse(Console.ReadLine());
            double multp = number1 * number2;
            return multp;

        }
        static double Division()
        {

            Console.Write("Enter number 1");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter number 2");
            int number2 = int.Parse(Console.ReadLine());
            double division = number1 / number2;
            return division;
            #endregion
            int result = GetMinimum();
            Console.WriteLine(result);
        }
        //--------------------------basqa------------
        static int GetMinimum()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, -7, -5, 98, 54 };
            int Minimum=numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[0])
                {
                     Minimum = numbers[i];
                }
                        
            }
            return Minimum;
        }
        
        
    }
}

    

    

    



