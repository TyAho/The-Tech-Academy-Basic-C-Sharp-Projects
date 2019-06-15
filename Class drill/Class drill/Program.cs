using System;

namespace Class_drill
{
    class Program
    {
        static void Main()
        {
            inputs in1 = new inputs();
            decimal firstNum = 6.78M;
            Console.WriteLine(in1.DoMath(firstNum));

            inputs in2 = new inputs();
            int secondNum = 8;
            Console.WriteLine(in2.DoMath(secondNum));

            inputs in3 = new inputs();
            string thirdNum = "10";
            Console.WriteLine(in3.DoMath(thirdNum));


            Console.ReadLine();
        }
    }
}
