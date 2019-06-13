using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace String_drill
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(" This is an assignment");
            sb.Append("\nIt is for a stringbuilder");
            sb.Append("\nThis is supposed to be a few sentences long");
            sb.Append("\nI think that should be good");

            Console.WriteLine(sb);

            string that = ("\n\nthat ");
            string looks = ("is ");
            string right = ("all");
            string sentence = (that + looks + right);

            Console.WriteLine(sentence);

            string bye = ("\nbye");
            bye = bye.ToUpper();

            Console.WriteLine(bye);


            Console.ReadLine();
        }
    }
}
