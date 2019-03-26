using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page140
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee p1 = new Employee() { FirstName = "Joe", LastName = "Smith", ID = 1 };
            Employee p2 = new Employee() { FirstName = "Kate", LastName = "Lauron", ID = 2 };
            Employee p3 = new Employee() { FirstName = "Connor", LastName = "Joseph", ID = 3 };
            Employee p4 = new Employee() { FirstName = "Brian", LastName = "Ford", ID = 4 };
            Employee p5 = new Employee() { FirstName = "Joe", LastName = "Beckham", ID = 5 };
            Employee p6 = new Employee() { FirstName = "Liam", LastName = "Conner", ID = 6 };
            Employee p7 = new Employee() { FirstName = "Aron", LastName = "Erbach", ID = 7 };
            Employee p8 = new Employee() { FirstName = "Jamie", LastName = "Stone", ID = 8 };
            Employee p9 = new Employee() { FirstName = "Bill", LastName = "Billy", ID = 9 };
            Employee p10 = new Employee() { FirstName = "Mic", LastName = "Blaha", ID = 10 };

            List<Employee> employees = new List<Employee>() { p1, p2, p3, p4, p5, p6, p7, p8, p9, p10 };

            List<Employee> list1 = new List<Employee>();

            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    list1.Add(employee);
                }
            }

            foreach (Employee employee in list1)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.ID);
            }
            Console.ReadLine();

            List<Employee> list2 = new List<Employee>();
            list2 = employees.FindAll(x => x.FirstName == "Joe");

            foreach (Employee employee in list2)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.ID);
            }
            Console.ReadLine();

            List<Employee> list3 = new List<Employee>();
            list3 = employees.FindAll(x => x.ID > 5);

            foreach (Employee employee in list3)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.ID);
            }
            Console.ReadLine();
        }
    }
}
