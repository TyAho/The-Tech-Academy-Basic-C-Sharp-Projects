using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace three_methods_drill
{
    static public class operations
    {
        static public int Add(int input)
        {
            return input + 6;
        }

        static public int Third(int input)
        {
            return (input / 3);
        }

        static public int random(int input)
        {
            Random random = new Random();
            return input + random.Next(-4, 4);
        }
    }
}
