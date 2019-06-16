using System;
using System.Collections.Generic;
using System.Text;

namespace dividing_method
{
    static class divide
    {
        public static void OneFourth(int input, out int ans, out int rem)
        {
            ans = input / 4;
            rem = input % 4;
        }

        public static void OneFourth(float input, out float ans)
        {
            ans = input / 4f;
        }
    }
}
