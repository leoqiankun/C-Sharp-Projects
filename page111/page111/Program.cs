using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page111
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in an integer for some operations: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int result1 = operations.operation1(input);
            Console.WriteLine("Your first result is " + result1);
            int result2 = operations.operation2(input);
            Console.WriteLine("Your second result is " + result2);
            int result3 = operations.operation3(input);
            Console.WriteLine("Your third result is " + result3);
            Console.ReadLine();
        }
    }
}
