using System;

namespace while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            bool entry = false;
            while (entry == false)
            {
                Console.Write("Enter your password: ");
                string password = Console.ReadLine();

                if (password == "1212")
                {
                    Console.WriteLine("Welcome back!");
                    entry = true;

                    Console.WriteLine("Please enter your coupon code for extra savings");
                    ushort code = Convert.ToUInt16(Console.ReadLine());
                    bool correct = code == 1552;

                    do
                    {
                        switch (code)
                        {
                            case 1552:
                                Console.WriteLine("Code redeemed. You now have 50% off your next order");
                                correct = true;
                                break;

                            default:
                                Console.WriteLine("Incorrect code. Try again.");
                                code = Convert.ToUInt16(Console.ReadLine());
                                break;
                        }
                    }
                    while (!correct);

                    Console.Read();
                }
                else
                {
                    Console.WriteLine("Password does not match.");
                    entry = false;
                }
            }
            Console.Read();
        }
    }
}
