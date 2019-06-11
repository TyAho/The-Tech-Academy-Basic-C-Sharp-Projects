using System;
namespace Math_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Choose a number that will be multiplied by 50");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number * 50);
            Console.ReadLine();


            int adding;
            Console.WriteLine("Choose a number that will be added by 25");
            adding = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(adding + 25);
            Console.ReadLine();

            int dividing;
            Console.WriteLine("Choose a number that will be divided by 12.5");
            dividing = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(dividing / 12.5);
            Console.ReadLine();

            //bool trueOrFalse;
            //long number1;
            //Console.WriteLine("Choose any number");
            //number1 = Convert.ToInt64(Console.ReadLine());
            //trueOrFalse = (number1 > 50);

            //if (trueOrFalse == true)
            //{
            //    Console.WriteLine("Your number, " + number1 + ", is greater than 50.");

            //};

            //if (trueOrFalse == false)
            //{
            //    Console.WriteLine("Your number, " + number1 + ", is less than 50.");
            //};
            //Console.ReadLine();


            //int rem;
            //Console.WriteLine("Enter a whole number to divide it by 7 and show the remainder:");
            //rem = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(rem % 7);
            //Console.ReadLine();



        }
    }
}
