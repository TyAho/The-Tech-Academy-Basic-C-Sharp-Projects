using System;

namespace Optional_method_drill
{
    class Program
    {
        static void Main()
        {
            numbers numbers = new numbers();

            int firstNum = 0;
            int secondNum = 0;
            string Input = "";

            bool correctNum = true;
            do
            {
                try
                {
                    Console.WriteLine("Type a whole number.");
                    firstNum = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("The second whole number is optional. Press enter to continue.");
                    Input = Console.ReadLine();
                    if (Input != "") Convert.ToInt32(Input); 

                    correctNum = true;
                }
                catch
                {
                    correctNum = false;
                }


            } while (!correctNum);



            if (Input == "")
            {
                Console.WriteLine("Equals: {0}", numbers.Average(firstNum));
            }
            else
            {
                secondNum = Convert.ToInt32(Input);
                Console.WriteLine("Equals: {0}", numbers.Average(firstNum, secondNum));
            }

            Console.ReadLine();
        }
    }
}
