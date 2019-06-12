using System;

namespace Package_drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight: ");
            string packageweight = Console.ReadLine();
            double Weight = Convert.ToDouble(packageweight);


            if (Weight > 50)
            {
                Console.WriteLine("Package too heavy to shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                string packagewidth = Console.ReadLine();
                double Width = Convert.ToDouble(packagewidth);

                Console.WriteLine("Please enter the package height:");
                string packageheight = Console.ReadLine();
                double Height = Convert.ToDouble(packageheight);

                Console.WriteLine("Please enter the package length:");
                string packagelength = Console.ReadLine();
                double Length = Convert.ToDouble(packagelength);

                if (Width + Height + Length > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    double total = Width + Height + Length;
                    double w = total * Weight;
                    decimal h = Convert.ToDecimal(w);
                    decimal quotient = h / 100;
                    Console.WriteLine("Your estimated total for shipping this package is:" + quotient.ToString());
                    Console.ReadLine();
                }
            }
        }
    }
}
