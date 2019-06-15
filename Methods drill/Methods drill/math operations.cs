using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_drill
{
    public class math_operations
    {
        public static void Method(int Number)
        {
            int equals = Number - 4;
            Console.WriteLine(Number + " minus 4 = " + equals);
        }
        public static void Method(float Fl)
        {
            float equals2 = Fl * 7;
            Console.WriteLine(Fl + " multiplied by  7 = " + equals2);
        }
        public static void Method(string Str)
        {
            try
            {
                int num = Convert.ToInt32(Str);
                int equals3 = num + 10;
                Console.WriteLine(num + " plus 10 = " + equals3);
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect.");
                return;
            }
        }
    }
}