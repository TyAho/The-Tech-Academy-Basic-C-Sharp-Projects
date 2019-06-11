using System;

namespace Incomedrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program: Press Enter");
            Console.ReadLine();

            Console.WriteLine("Person 1:");

            Console.WriteLine("Hourly rate?");
            string hour1 = Console.ReadLine();
            int rate1 = Convert.ToInt32(hour1);

            Console.WriteLine("Hours worked per week?");
            string weekworked1 = Console.ReadLine();
            int hours1 = Convert.ToInt32(weekworked1);

            Console.WriteLine("Person 2:");

            Console.WriteLine("Hourly rate?");
            string hour2 = Console.ReadLine();
            int rate2 = Convert.ToInt32(hour2);

            Console.WriteLine("Hours worked per week?");
            string weekworked2 = Console.ReadLine();
            int hours2 = Convert.ToInt32(weekworked2);

            int salary1 = (rate1 * hours1 * 1);
            int salary2 = (rate2 * hours2 * 1);
            string weeklySalary1 = Convert.ToString(salary1);
            string weeklySalary2 = Convert.ToString(salary2);

            Console.WriteLine("Weekly Salary of Person 1");
            Console.WriteLine(weeklySalary1);

            Console.WriteLine("Weekly Salary of Person 2");
            Console.WriteLine(weeklySalary2);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            if (salary1 > salary2)
            {
                Console.WriteLine("Yes.");
            }

            else
            {
                Console.WriteLine("No.");
            }

            Console.WriteLine("Press Enter to exit program");
            Console.ReadLine();
        }
    }
}
