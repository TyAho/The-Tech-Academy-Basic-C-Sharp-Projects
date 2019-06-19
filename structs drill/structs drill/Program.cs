using System;

namespace structs_drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num = new Number();
            num.Amount = 10;
            Console.WriteLine(num.Amount);
            Console.ReadLine();
        }
    }

    struct Number
    {
        public decimal Amount { get; set; }
    }
}
    

