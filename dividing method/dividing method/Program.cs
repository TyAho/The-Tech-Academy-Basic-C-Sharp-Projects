using System;

namespace dividing_method
{
    class Program
    {
        static void Main(string[] args)
        {
            divider divider = new divider();
            Console.WriteLine("Input a whole number to be divided by two.");
            int input = Convert.ToInt32(Console.ReadLine());
            int res;
            divider.OneHalf (input, out res);

            Console.WriteLine("Answer: {0}", res);

            Console.WriteLine("Type a whole number that will be divided by four.");
            input = Convert.ToInt32(Console.ReadLine());
            int rem;
            divide.OneFourth(input, out res, out rem);

            Console.WriteLine("Answer: {0}", res);
            Console.WriteLine("Remainder: {0}", rem);

            Console.WriteLine("Type a floating point number that will be divided by four.");
            float flInput = Convert.ToSingle(Console.ReadLine());
            float Result;
            divide.OneFourth(input, out Result);

            Console.WriteLine("Answer: {0}", Result);

            Console.ReadLine();
        }
    }
}
