using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page66
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type in a number:");
            string input1 = Console.ReadLine();
            double result1 = Convert.ToDouble(input1) * 50.0;
            Console.WriteLine(input1 + " multiplied by 50 is " + result1);
            
            Console.WriteLine("Please type in a number:");
            string input2 = Console.ReadLine();
            double result2 = Convert.ToDouble(input2) + 25.0;
            Console.WriteLine(input2 + " add 25 is " + result2);

            Console.WriteLine("Please type in a number:");
            string input3 = Console.ReadLine();
            double result3 = Convert.ToDouble(input3) / 12.5;
            Console.WriteLine(input3 + " divided by 12.5 is " + result3);

            Console.WriteLine("Please type in a number:");
            string input4 = Console.ReadLine();
            bool result4 = Convert.ToDouble(input4) > 50;
            Console.WriteLine(result4);

            Console.WriteLine("Please type in a number:");
            string input5 = Console.ReadLine();
            int result5 = Convert.ToInt32(input5) % 7;
            Console.WriteLine("The remainder of " + input5 + " divided by 7 is " + result5);

            Console.ReadLine();
        }
    }
}
