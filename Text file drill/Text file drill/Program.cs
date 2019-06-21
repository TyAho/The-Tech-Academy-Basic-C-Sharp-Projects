using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Text_file_drill
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Enter a number");
            bool validInput = false;
            string input = "";
            while (!validInput)
            {
                try
                {
                    input = Console.ReadLine();
                    Convert.ToInt32(input);
                    validInput = true;
                }
                catch
                {
                    Console.WriteLine("Error. Please enter a whole number!");
                    validInput = false;
                }
            }
            using (StreamWriter file = new StreamWriter(@"C:\Users\Public\file io\number.txt", false))
            {
                file.WriteLine(input);
            }

            string fileText = File.ReadAllText(@"C:\Users\Public\file io\number.txt");
            Console.WriteLine("The number you entered was {0}", fileText);
            Console.ReadLine();
        }
    }
}








