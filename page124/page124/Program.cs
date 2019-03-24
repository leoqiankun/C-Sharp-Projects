using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page124
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { LastName = "Student", FirstName = "Sample" };
            employee.SayName();
            Console.ReadLine();
        }
    }
}
