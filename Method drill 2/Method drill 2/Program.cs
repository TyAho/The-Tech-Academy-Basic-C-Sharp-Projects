using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_drill_2
{
    class Program
    {
            public static void Main()
            {
                int number1 = 10;


                int number2 = 20;

                Number.Drill(number1, number2);
            }
        }
        class Number
        {


            public static void Drill(int construct1, int construct2)
            {
                int equals = construct1 - 8;
                Console.WriteLine(equals);
                Console.WriteLine(construct2);
                Console.ReadLine();
          }
     }
}
