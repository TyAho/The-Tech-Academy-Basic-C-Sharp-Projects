using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Methods_drill
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("type a whole number.");
        int number = Convert.ToInt32(Console.ReadLine());
        math_operations.Method(number);

            Console.WriteLine("type a decimal.");


            float number2 = float.Parse(Console.ReadLine());
        math_operations.Method(number2);
        Console.WriteLine("type an integer.");


            string number3 = Console.ReadLine();
        math_operations.Method(number3);
        Console.ReadLine();
    }
    }
}
