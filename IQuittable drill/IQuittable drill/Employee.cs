using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace IQuittable_drill
{
    public class Employee : Person, IQuittable
    {
        public void Quit()
        {
            IQuittable quittable = new Employee();
            Console.WriteLine("Player has quit the game.");
            Console.ReadLine();
        }
    }
}