using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page131
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<int> employee1 = new Employee<int>();
            employee1.things = new List<int>() { 2, 4, 5 };

            Employee<string> employee2 = new Employee<string>();
            employee2.things = new List<string>() { "bob", "sam", "kate" };

            foreach (int number in employee1.things)
            {
                Console.WriteLine(number);
            }
            foreach (string name in employee2.things)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

        }
    }
}
