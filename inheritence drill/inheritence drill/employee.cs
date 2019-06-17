using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace inheritence_drill
{
    public class Employee : Person
    {
        public int ID { get; set; }

        public static bool operator ==(Employee firstEmployee, Employee secondEmployee)
        {
            if (firstEmployee.ID == secondEmployee.ID)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Employee firstEmployee, Employee secondEmployee)
        {
            if (firstEmployee.ID != secondEmployee.ID)
            {
                return true;
            }
            return false;
        }
    }
}
