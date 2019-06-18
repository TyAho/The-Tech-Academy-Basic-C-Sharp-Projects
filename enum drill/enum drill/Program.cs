using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_drill
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please type a day of the week.");
            Week day = 0;
            bool CorrectDay = false;


            while (!CorrectDay)
            {


                try
                {
                    string input = Console.ReadLine();
                    
                    

                             
                    CorrectDay = Enum.TryParse(input, out day);
                    if (!CorrectDay) throw new Exception();
                }


                catch
                {
                    CorrectDay = false;
                    Console.WriteLine("Please enter an actual day of the week.");
                }
            }

            Console.WriteLine(day);

            Console.ReadLine();
        }
    }
    public enum Week
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
}

