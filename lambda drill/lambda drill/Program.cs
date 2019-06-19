using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda_drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { FirstName = "Joe", LastName = "Morgan", ID = 1 };

            Employee employee2 = new Employee() { FirstName = "Joe", LastName = "James", ID = 2 };

            Employee employee3 = new Employee() { FirstName = "Robert", LastName = "Johnson", ID = 3 };

            Employee employee4 = new Employee() { FirstName = "James", LastName = "Albert", ID = 4 };

            Employee employee5 = new Employee() { FirstName = "Dianna", LastName = "Goldberg", ID = 5 };

            Employee employee6 = new Employee() { FirstName = "Rachel", LastName = "Jean", ID = 6 };

            Employee employee7 = new Employee() { FirstName = "Mike", LastName = "Richard", ID = 7 };

            Employee employee8 = new Employee() { FirstName = "Hailey", LastName = "Stone", ID = 8 };

            Employee employee9 = new Employee() { FirstName = "Matt", LastName = "James", ID = 9 };

            Employee employee10 = new Employee() { FirstName = "Isaac", LastName = "Lucas", ID = 10 };

            List<Employee> employees = new List<Employee> { employee1, employee2, employee3, employee4, employee5, employee6, employee7, employee8, employee9, employee10 };

            
            Console.WriteLine("Employees");

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " ID:" + employee.ID);
            }
            Console.WriteLine();

            
            List<Employee> EmployeesNamedJoe = new List<Employee>();

            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    EmployeesNamedJoe.Add(employee);
                }
            }

            
            Console.WriteLine("Employees named Joe:");

            foreach (Employee guy in EmployeesNamedJoe)
            {
                Console.WriteLine(guy.FirstName + " " + guy.LastName + " ID:" + guy.ID);
            }
            Console.WriteLine();

            
            List<Employee> EmployeesNamedJoe2 = employees.Where(x => x.FirstName == "Joe").ToList();

            
            Console.WriteLine("Employees named Joe from the Lambda method:");

            foreach (Employee guy in EmployeesNamedJoe2)
            {
                Console.WriteLine(guy.FirstName + " " + guy.LastName + " ID:" + guy.ID);
            }
            Console.WriteLine();

            
            List<Employee> ID5 = employees.Where(x => x.ID > 5).ToList();

            
            Console.WriteLine("Employees with ID > 5:");

            foreach (Employee employee in ID5)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " ID:" + employee.ID);
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
