using System;

namespace Car_insurance_drill
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            bool underage = (age < 16);

            Console.WriteLine("Have you ever had a DUI?");
            string DUI = Console.ReadLine();
            bool noDUI = (DUI == "no" || DUI == "No");
            bool yesDUI = (DUI == "yes" || DUI == "Yes");

            Console.WriteLine("How many speeding tickets do you have?");
            int Tickets = Convert.ToInt32(Console.ReadLine());
            bool speeding = (Tickets > 3);




            Console.WriteLine("Your age: " + age);

            Console.WriteLine("DUI Present?");
            if (noDUI == true)
            {
                Console.WriteLine("False");
            }
            if (yesDUI == true)
            {
                Console.WriteLine("True");
            }


            Console.WriteLine("Number of speeding tickets: " + Tickets);



            Console.WriteLine("Qualified?");
            if (noDUI == true && underage == false && speeding == false)
            {
                Console.WriteLine(true);
            }

            if (yesDUI == true || underage == true || speeding == true)
            {
                Console.WriteLine(false);
            }

            Console.ReadLine();
        }
    }
}
