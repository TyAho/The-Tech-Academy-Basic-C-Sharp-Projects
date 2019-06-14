using System;

namespace trycatch_drill
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] numbers = { 2, 4, 6, 8, 10, 12, 14 };
                Console.WriteLine("choose a number to divide the numbers in the list by.");
                int divider = Convert.ToInt32(Console.ReadLine());


                for (int i = 0; i < numbers.Length; i++)
                {
                    int equals = numbers[i] / divider;
                    Console.WriteLine(numbers[i] + " divided by " + divider + " is " + equals);
                }
            }


            catch (FormatException ex)
            {
                Console.WriteLine("Error. Type a whole number.");
                return;
            }


            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error. Cannot divide by zero.");
                return;
            }


            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            finally
            {
                Console.WriteLine("The program has emerged from the try/catch block and continued on with the program.");
                Console.ReadLine();
            }
        }
    }
}
