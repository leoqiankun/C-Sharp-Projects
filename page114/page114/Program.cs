using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page114
{
    class Program
    {
        static void Main(string[] args)
        {
            Class Class1 = new Class();
            Class1.Int = 12;

            int num1 = Class1.method(Class1.Int);
            Console.WriteLine(num1);
            

            Class Class2 = new Class();
            Class2.Double = 12.13;

            int num2 = Class2.method(Class2.Double);
            Console.WriteLine(num2);
            

            Class Class3 = new Class();
            Class3.String = "50";

            int num3 = Class3.method(Class3.String);
            Console.WriteLine(num3);
            Console.ReadLine();
        }
    }
}
