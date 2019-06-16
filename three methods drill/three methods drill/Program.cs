using System;
using System.Threading;

namespace three_methods_drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a whole number.");
            bool correctInput = false;
            int input = 0;
            while (!correctInput)
            {
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                    correctInput = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Error. Please enter a whole number.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine("1st operation equals:");
            input = operations.Add(input);
            Console.WriteLine(Convert.ToString(input));

            Thread.Sleep(100);

            Console.WriteLine("2nd operation equals:");
            input = operations.Third(input);
            Console.WriteLine(Convert.ToString(input));

            Thread.Sleep(100);

            Console.WriteLine("3rd operation equals:");
            input = operations.random(input);
            Console.WriteLine(Convert.ToString(input));




            Console.ReadLine();
        }
    }
}
