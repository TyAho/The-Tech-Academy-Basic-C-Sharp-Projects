using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_drill
{
    public class Program
    {
        public static void Main()
        {
            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string>();
            employee.Things.Add("Tom");
            employee.Things.Add("Hailey");
            employee.Things.Add("Kevin");
            employee.Things.Add("Lisa");


            Employee<int> ID = new Employee<int>();
            ID.Things = new List<int>();
            ID.Things.Add(1);
            ID.Things.Add(2);
            ID.Things.Add(3);
            ID.Things.Add(4);

            foreach (string x in employee.Things)
            {
                Console.WriteLine(x);
            }

            foreach (int y in ID.Things)
            {
                Console.WriteLine(y);
            }
            Console.ReadLine();
        }
    }
}
