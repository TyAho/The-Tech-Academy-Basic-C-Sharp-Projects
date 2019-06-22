using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_drill
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validAnswer = false;
            int age = 0;


            while (!validAnswer)
            {


                try
                {
                    Console.WriteLine("What is your age?");
                    validAnswer = int.TryParse(Console.ReadLine(), out age);


                    if (!validAnswer) Console.WriteLine("Error. Enter digits only, no decimals");
                    if (age < 1) throw new Exception();

                    else
                    {
                        DateTime now = DateTime.Now;
                        int year = now.Year;
                        int YearOfBirth = year - age;

                        Console.WriteLine("You were born in " + YearOfBirth);
                        Console.ReadLine();
                    }
                }


                catch (Exception)
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    return;
                }
            }
        }
    }
}
