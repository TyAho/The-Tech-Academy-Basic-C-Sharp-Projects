using System;

namespace inheritance_drill
{
    class Program
    {
        static void Main()
        {
            Employee sample = new Employee() { FirstName = "Sample", LastName = "Student", ID = 1 };

            Employee different = new Employee() { FirstName = "Robert", LastName = "Smith", ID = 2 };

            sample.SayName();
            different.SayName();

           


            
        }
    }
}
