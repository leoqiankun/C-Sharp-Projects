using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page129
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee p1 = new Employee() { ID = 234 };
            Employee p2 = new Employee() { ID = 223 };
            Employee p3 = new Employee() { ID = 234 };

           

            Console.WriteLine(p1.ID == p2.ID);
            Console.WriteLine(p1.ID == p3.ID);
            Console.WriteLine(p2.ID == p3.ID);
            Console.ReadLine();
        }
    }
}
