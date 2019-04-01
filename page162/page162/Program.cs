using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page162
{
    class Program
    {
        static void Main(string[] args)
        {
            const string greeting = "Hello!";
            var list = new List<int> { 3, 6, 9 };

            Console.WriteLine(greeting);
            foreach (int number in list)
            {
                Console.WriteLine(number);
            }

            Class1 class1 = new Class1("red");
            Console.WriteLine(class1.colors + " " + class1.size);
            Console.ReadLine();




        }
    }
}
