using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace overload
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName + " ID: " + ID);
            Console.ReadLine();
        }
    }
}
