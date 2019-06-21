using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Type a number");
            
            


            bool validInput = false;
            string input = "";
            int num = 0;
            while (!validInput)
            {



                try
                {
                    input = Console.ReadLine();
                    num = Convert.ToInt32(input);
                    validInput = true;
                }



                catch
                {
                    Console.WriteLine("Error. Please enter a whole number");
                    validInput = false;
                }



            }
            TimeSpan hours = TimeSpan.FromHours(num);
            Console.WriteLine("In  exactly {0} hours, it will be {1}", num, DateTime.Now + hours);
            Console.ReadLine();
        }
    }
}
