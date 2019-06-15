using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Class_drill
{
    class inputs
    {
        public int DoMath(decimal num)
        {
            return (int)(num + 5);
        }
        public int DoMath(int input)
        {
            return input * 2;
        }
        public int DoMath(string num)
        {
            int answer = 0;

            try
            {
                answer = Convert.ToInt32(num);
            }
            catch
            {
                Console.WriteLine("Error. Cannot do mat on strings");
                return 0;
            }

            answer = answer % 2;
            return answer;
        }
    }
}